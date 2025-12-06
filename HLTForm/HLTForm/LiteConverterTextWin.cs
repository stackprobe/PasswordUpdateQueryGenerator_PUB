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
using HLTStudio.Tools;

namespace HLTStudio
{
	public partial class LiteConverterTextWin : Form
	{
		public LiteConverterTextWin()
		{
			InitializeComponent();
		}

		private void LiteConverterTextWin_Load(object sender, EventArgs e)
		{
			this.MinimumSize = this.Size;

			this.StatusMessage.Text = "";
		}

		private void BtnClear_Click(object sender, EventArgs e)
		{
			this.Password.Text = "";
			this.OriginalPassword.Text = "";
			this.PasswordHash.Text = "";
			this.Salt.Text = "";
		}

		private void BtnConvert_Click(object sender, EventArgs e)
		{
			this.NormalizeInput();

			string errorMessage = this.ValidationCheck();

			if (errorMessage != null)
			{
				MessageDlg.Show(this, errorMessage, "入力エラー", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}

			string password = this.Password.Text;

			HashedPassword hp = new HashedPassword(password);

			this.OriginalPassword.Text = password;
			this.PasswordHash.Text = hp.PasswordHash;
			this.Salt.Text = hp.Salt;
		}

		private void NormalizeInput()
		{
			this.Password.Text = this.Password.Text.Trim();
		}

		private string ValidationCheck()
		{
			if (this.Password.Text == "")
				return "パスワードを入力して下さい。";

			if (StringTools.HasControl(this.Password.Text))
				return "パスワードに制御文字が含まれています。";

			if (!StringTools.IsShiftJIS(this.Password.Text))
				return "パスワードに Shift_JIS に変換できない文字が含まれています。";

			return null;
		}

		private void BtnCopyOriginalPassword_Click(object sender, EventArgs e)
		{
			StringTools.CopyToClipboard(this.OriginalPassword.Text);

			this.StatusMessage.Text = StringTools.GetCopiedToClipboardMessage();
		}

		private void BtnCopyPasswordHash_Click(object sender, EventArgs e)
		{
			StringTools.CopyToClipboard(this.PasswordHash.Text);

			this.StatusMessage.Text = StringTools.GetCopiedToClipboardMessage();
		}

		private void BtnCopySalt_Click(object sender, EventArgs e)
		{
			StringTools.CopyToClipboard(this.Salt.Text);

			this.StatusMessage.Text = StringTools.GetCopiedToClipboardMessage();
		}

		private void BtnCopyToClipboard_Click(object sender, EventArgs e)
		{
			StringTools.CopyToClipboard(string.Join("\r\n"
				, this.OriginalPassword.Text
				, this.PasswordHash.Text
				, this.Salt.Text
				));

			this.StatusMessage.Text = StringTools.GetCopiedToClipboardMessage();
		}

		private void Password_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (e.KeyChar == (char)13) // /////
			{
				this.BtnConvert_Click(null, null);
				this.Password.SelectAll();
			}
		}

		private void OriginalPassword_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (e.KeyChar == (char)1) // //// / /
			{
				this.OriginalPassword.SelectAll();
			}
		}

		private void PasswordHash_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (e.KeyChar == (char)1) // //// / /
			{
				this.PasswordHash.SelectAll();
			}
		}

		private void Salt_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (e.KeyChar == (char)1) // //// / /
			{
				this.Salt.SelectAll();
			}
		}
	}
}

//
// <<< Processed by SolutionConv
//