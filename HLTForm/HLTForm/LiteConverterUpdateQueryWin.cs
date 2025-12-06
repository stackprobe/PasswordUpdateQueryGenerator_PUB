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
	public partial class LiteConverterUpdateQueryWin : Form
	{
		public LiteConverterUpdateQueryWin()
		{
			InitializeComponent();
		}

		private void LiteConverterUpdateQueryWin_Load(object sender, EventArgs e)
		{
			this.MinimumSize = this.Size;

			this.StatusMessage.Text = "";
		}

		private void BtnClear_Click(object sender, EventArgs e)
		{
			this.VendorCode.Text = "";
			this.Password.Text = "";
			this.OriginalPassword.Text = "";
			this.UpdateQuery.Text = "";
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

			string updateQuery = StringTools.ReplaceAll(
				Setting.Instance.Value.UpdateQueryTemplate,
				true,
				Consts.UPDATE_QUERY_TEMPLATE_PATTERN_VENDOR_CODE,
				this.VendorCode.Text,
				Consts.UPDATE_QUERY_TEMPLATE_PATTERN_HASHED_PASSWORD,
				hp.PasswordHash,
				Consts.UPDATE_QUERY_TEMPLATE_PATTERN_SALT,
				hp.Salt,
				Consts.UPDATE_QUERY_TEMPLATE_PATTERN_UPDATE_USER_ID,
				Setting.Instance.Value.UpdateUserID,
				Consts.UPDATE_QUERY_TEMPLATE_PATTERN_UPDATE_PROGRAM_ID,
				Setting.Instance.Value.UpdateProgramID
				);

			this.OriginalPassword.Text = password;
			this.UpdateQuery.Text = updateQuery;
		}

		private void NormalizeInput()
		{
			this.VendorCode.Text = this.VendorCode.Text.Trim();
			this.Password.Text = this.Password.Text.Trim();
		}

		private string ValidationCheck()
		{
			if (this.VendorCode.Text == "")
				return "ベンダーコードを入力して下さい。";

			if (this.Password.Text == "")
				return "パスワードを入力して下さい。";

			if (StringTools.HasControl(this.VendorCode.Text))
				return "ベンダーコードに制御文字が含まれています。";

			if (StringTools.HasControl(this.Password.Text))
				return "パスワードに制御文字が含まれています。";

			if (!StringTools.IsShiftJIS(this.VendorCode.Text))
				return "ベンダーコードに Shift_JIS に変換できない文字が含まれています。";

			if (!StringTools.IsShiftJIS(this.Password.Text))
				return "パスワードに Shift_JIS に変換できない文字が含まれています。";

			return null;
		}

		private void BtnCopyOriginalPassword_Click(object sender, EventArgs e)
		{
			StringTools.CopyToClipboard(this.OriginalPassword.Text);

			this.StatusMessage.Text = StringTools.GetCopiedToClipboardMessage();
		}

		private void BtnCopyToClipboard_Click(object sender, EventArgs e)
		{
			StringTools.CopyToClipboard(this.UpdateQuery.Text);

			this.StatusMessage.Text = StringTools.GetCopiedToClipboardMessage();
		}

		private void VendorCode_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (e.KeyChar == (char)13) // /////
			{
				this.Password.Focus();
				this.Password.SelectAll();
			}
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

		private void UpdateQuery_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (e.KeyChar == (char)1) // //// / /
			{
				this.UpdateQuery.SelectAll();
			}
		}
	}
}

//
// <<< Processed by SolutionConv
//