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
using System.IO;
using System.Security.Permissions;
using System.Windows.Forms;
using HLTStudio.Commons;

namespace HLTStudio
{
	public partial class MainWin : Form
	{
		public MainWin()
		{
			InitializeComponent();
		}

		private void MainWin_Load(object sender, EventArgs e)
		{
			this.MinimumSize = this.Size;

			if (Setting.Instance.Value.LastMainWinRect.Width != 0) // / ////////
				this.SetWindowRectangle(Setting.Instance.Value.LastMainWinRect);

			this.UpdateControls();
		}

		private void SetWindowRectangle(Rectangle rect)
		{
			int l = rect.Left;
			int t = rect.Top;
			int w = rect.Width;
			int h = rect.Height;

			Point center = new Point(l + w / 2, t + h / 2);
			Screen screen = GetScreen(center);

			if (screen == null)
				return;

			l = Math.Max(l, screen.Bounds.Left);
			t = Math.Max(t, screen.Bounds.Top);
			w = Math.Min(w, screen.Bounds.Width);
			h = Math.Min(h, screen.Bounds.Height);

			this.Left = l;
			this.Top = t;
			this.Width = w;
			this.Height = h;
		}

		private static Screen GetScreen(Point center)
		{
			int x = center.X;
			int y = center.Y;

			foreach (Screen screen in Screen.AllScreens)
			{
				if (
					screen.Bounds.Left <= x && x < screen.Bounds.Right &&
					screen.Bounds.Top <= y && y < screen.Bounds.Bottom
					)
					return screen;
			}
			return null;
		}

		private void MainWin_FormClosed(object sender, FormClosedEventArgs e)
		{
			Setting.Instance.Value.LastMainWinRect = new Rectangle(
				this.Left,
				this.Top,
				this.Width,
				this.Height
				);

			Setting.Instance.Value.SaveSetting();
		}

		private void InputCSVFileDropArea_DragEnter(object sender, DragEventArgs e)
		{
			e.Effect = DragDropEffects.Copy;
		}

		private void InputCSVFileDropArea_DragDrop(object sender, DragEventArgs e)
		{
			try
			{
				string[] files = (string[])e.Data.GetData(DataFormats.FileDrop, false);

				if (files == null)
					throw new Exception("CSVファイルをドラッグアンドドロップして下さい。");

				if (files.Length != 1)
					throw new Exception("1つのCSVファイルをドラッグアンドドロップして下さい。");

				string file = files[0];

				if (!File.Exists(file))
					throw new Exception("CSVファイルをドラッグアンドドロップして下さい。");

				if (!Path.GetExtension(file).EqualsIgnoreCase(".csv"))
					throw new Exception("ファイルの拡張子は .csv でなければなりません。");

				this.InputCSVFile.Text = file;
				this.InputCSVFile.SelectAll();

				this.UpdateControls();
			}
			catch (Exception ex)
			{
				MessageDlg.Show(this, ex.Message, "ドラッグアンドドロップの失敗", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
		}

		private void InputCSVFile_TextChanged(object sender, EventArgs e)
		{
			this.UpdateControls();
		}

		private void BtnBrowseInputCSVFile_Click(object sender, EventArgs e)
		{
			string file = this.BrowseInputCSVFile();

			if (file == null)
				return;

			this.InputCSVFile.Text = file;
			this.InputCSVFile.SelectAll();

			this.UpdateControls();
		}

		private void UpdateControls()
		{
			{
				string file = this.InputCSVFile.Text.Trim();

				if (this.InputCSVFile.Text != file)
					this.InputCSVFile.Text = file;
			}

			bool enabled = this.InputCSVFile.Text != "";

			this.InputCSVFileDropArea.BackColor = enabled ? SystemColors.Control : Color.LightCyan;

			this.BtnOutputCsv.Enabled = enabled;
			this.BtnOutputUpdateQuery.Enabled = enabled;

			this.BtnOutputCsv.ForeColor = enabled ? Color.Blue : Color.Black;
			this.BtnOutputUpdateQuery.ForeColor = enabled ? Color.Blue : Color.Black;
		}

		private void BtnOutputCsv_Click(object sender, EventArgs e)
		{
			string file = BrowseOutputCSVFile();

			if (file == null)
				return;

			new PasswordConverter(this).OutputCsv(this.InputCSVFile.Text, file);
		}

		private void BtnOutputUpdateQuery_Click(object sender, EventArgs e)
		{
			string file = BrowseOutputQueryFile();

			if (file == null)
				return;

			new PasswordConverter(this).OutputQuery(this.InputCSVFile.Text, file);
		}

		private string BrowseInputCSVFile()
		{
			for (; ; )
			{
				using (OpenFileDialog f = new OpenFileDialog())
				{
					f.FileName = "*csv";
					f.InitialDirectory = "";
					f.Filter = "CSVファイル(*.csv)|*.csv";
					f.FilterIndex = 1;
					f.Title = "入力CSVファイルを選択してください";
					f.RestoreDirectory = true;

					if (f.ShowDialog() == DialogResult.OK)
					{
						string file = f.FileName;

						if (!Path.GetExtension(file).EqualsIgnoreCase(".csv"))
						{
							MessageDlg.Show(this
								, "ファイルの拡張子は .csv でなければなりません。"
								, "ファイル選択エラー"
								, MessageBoxButtons.OK
								, MessageBoxIcon.Warning
								);
							continue;
						}
						return file;
					}
				}
				break;
			}
			return null;
		}

		private string BrowseOutputCSVFile()
		{
			using (SaveFileDialog f = new SaveFileDialog())
			{
				f.FileName = SimpleDateTime.Now.ToTimeStamp() + ".csv";
				f.InitialDirectory = string.Empty;
				f.Filter = "CSVファイル(*.csv)|*.csv|すべてのファイル(*.*)|*.*";
				f.FilterIndex = 1;
				f.Title = "出力CSVファイルを選択してください";
				f.RestoreDirectory = true;

				if (f.ShowDialog() == DialogResult.OK)
					return f.FileName;
			}
			return null;
		}

		private string BrowseOutputQueryFile()
		{
			using (SaveFileDialog f = new SaveFileDialog())
			{
				f.FileName = SimpleDateTime.Now.ToTimeStamp() + ".sql";
				f.InitialDirectory = string.Empty;
				f.Filter = "クエリファイル(*.sql)|*.sql|すべてのファイル(*.*)|*.*";
				f.FilterIndex = 1;
				f.Title = "出力クエリファイルを選択してください";
				f.RestoreDirectory = true;

				if (f.ShowDialog() == DialogResult.OK)
					return f.FileName;
			}
			return null;
		}

		private void MainMenu_File_Exit_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void MainMenu_Edit_Clear_Click(object sender, EventArgs e)
		{
			this.InputCSVFile.Text = "";
		}

		private void MainMenu_Edit_Setting_Click(object sender, EventArgs e)
		{
			using (SettingWin f = new SettingWin())
			{
				f.ShowDialog();
			}
		}

		private void MainMenu_Tool_LiteConverter_Text_Click(object sender, EventArgs e)
		{
			using (LiteConverterTextWin f = new LiteConverterTextWin())
			{
				f.ShowDialog();
			}
		}

		private void MainMenu_Tool_LiteConverter_FixedSalt_Click(object sender, EventArgs e)
		{
			using (LiteConverterFixedSaltWin f = new LiteConverterFixedSaltWin())
			{
				f.ShowDialog();
			}
		}

		private void MainMenu_Tool_LiteConverter_UpdateQuery_Click(object sender, EventArgs e)
		{
			using (LiteConverterUpdateQueryWin f = new LiteConverterUpdateQueryWin())
			{
				f.ShowDialog();
			}
		}
	}
}

//
// <<< Processed by SolutionConv
//