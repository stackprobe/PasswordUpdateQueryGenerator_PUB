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
using System.Windows.Forms;

namespace HLTStudio
{
	public partial class MessageDlg : Form
	{
		private static Image IconImage;

		public static void Show(Form owner, string text, string caption, MessageBoxButtons buttons, MessageBoxIcon icon)
		{
			switch (buttons)
			{
				case MessageBoxButtons.OK:
					break;

				default:
					throw null; // /////
			}

			switch (icon)
			{
				case MessageBoxIcon.Information:
					IconImage = SystemIcons.Information.ToBitmap();
					break;

				case MessageBoxIcon.Warning:
					IconImage = SystemIcons.Warning.ToBitmap();
					break;

				default:
					throw null; // /////
			}

			using (MessageDlg f = new MessageDlg())
			{
				f.Owner = owner;
				f.MessageText.Text = text;
				f.Text = caption;

				f.ShowDialog();
			}
		}

		public MessageDlg()
		{
			InitializeComponent();
		}

		private void MessageDlg_Load(object sender, EventArgs e)
		{
			this.MinimumSize = this.Size;

			this.MessageIcon.Image = IconImage;
			this.MessageIcon.Width = IconImage.Width;
			this.MessageIcon.Height = IconImage.Height;

			{
				int d = this.MessageText.Left - this.MessageIcon.Right - 10;

				this.MessageText.Left -= d;
				this.MessageText.Width += d;
			}

			this.UpdateControls();
		}

		private void MessageDlg_Resize(object sender, EventArgs e)
		{
			this.UpdateControls();
		}

		private void UpdateControls()
		{
			this.BtnOK.Left = (this.Width - this.BtnOK.Width) / 2;
		}

		private void BtnOK_Click(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}

//
// <<< Processed by SolutionConv
//