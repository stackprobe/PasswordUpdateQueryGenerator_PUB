// Processed by SolutionConv >>>
//
// 本ソースファイルは、公開時の所定の手続きとして一部のセンシティブな情報をマスキングしています。
// 元データの機微に触れる可能性がある箇所を伏せ字化したものであり、
// リリース版との処理内容に実質的な差異が生じない範囲で調整を加えています。
//

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Security.Permissions;
using System.Windows.Forms;

namespace HLTStudio
{
	public partial class BusyDlg : Form
	{
		public static bool CancelRequested;

		private static Action WorkerRoutine;
		private static Exception WorkerRoutineException;

		public static void Show(Action workerRoutine)
		{
			CancelRequested = false;

			WorkerRoutine = workerRoutine;
			WorkerRoutineException = null;

			using (BusyDlg f = new BusyDlg())
			{
				f.ShowDialog();
			}

			if (WorkerRoutineException != null)
				throw new Exception(WorkerRoutineException.Message, WorkerRoutineException);
		}

		public BusyDlg()
		{
			InitializeComponent();
		}

		private void BusyDlg_Load(object sender, EventArgs e)
		{
			this.MinimumSize = this.Size;
		}

		private void BusyDlg_Shown(object sender, EventArgs e)
		{
			new Thread(() =>
			{
				Thread keepDispTh = new Thread(() =>
				{
					Thread.Sleep(500);
				});

				keepDispTh.Start();

				try
				{
					WorkerRoutine();
				}
				catch (Exception ex)
				{
					WorkerRoutineException = ex;
				}

				keepDispTh.Join();

				this.BeginInvoke((MethodInvoker)delegate
				{
					this.Close();
				});
			})
			.Start();
		}

		[SecurityPermission(SecurityAction.LinkDemand, Flags = SecurityPermissionFlag.UnmanagedCode)]
		protected override void WndProc(ref Message m)
		{
			const int WM_SYSCOMMAND = 0x112;
			const long SC_CLOSE = 0xF060L;
			const long WP_MASK = 0xFFF0L;

			if (m.Msg == WM_SYSCOMMAND && (m.WParam.ToInt64() & WP_MASK) == SC_CLOSE)
			{
				this.RequestCancel();
				return;
			}
			base.WndProc(ref m);
		}

		private void BtnCancel_Click(object sender, EventArgs e)
		{
			this.RequestCancel();
		}

		private void RequestCancel()
		{
			if (!CancelRequested)
			{
				CancelRequested = true;

				this.LabelMessage.Text = "処理をキャンセルしています...";
				this.BtnCancel.Enabled = false;
			}
		}
	}
}

//
// <<< Processed by SolutionConv
//