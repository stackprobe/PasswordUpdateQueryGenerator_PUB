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
using HLTStudio.Commons;
using HLTStudio.Tools;

namespace HLTStudio
{
	public partial class SettingWin : Form
	{
		public SettingWin()
		{
			InitializeComponent();
		}

		private void SettingWin_Load(object sender, EventArgs e)
		{
			this.MinimumSize = this.Size;

			this.UpdateUserID.Text = Setting.Instance.Value.UpdateUserID;
			this.UpdateProgramID.Text = Setting.Instance.Value.UpdateProgramID;
			this.UpdateQueryTemplate.Text = Setting.Instance.Value.UpdateQueryTemplate;
		}

		private void BtnDefault_Click(object sender, EventArgs e)
		{
			this.UpdateQueryTemplate.Text = Consts.DEAULT_UPDATE_QUERY_TEMPLATE;
		}

		private void BtnCancel_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void BtnOK_Click(object sender, EventArgs e)
		{
			this.NormalizeInput();

			string errorMessage = this.ValidationCheck();

			if (errorMessage != null)
			{
				MessageDlg.Show(this, errorMessage, "入力エラー", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}

			Setting.Instance.Value.UpdateUserID = this.UpdateUserID.Text;
			Setting.Instance.Value.UpdateProgramID = this.UpdateProgramID.Text;
			Setting.Instance.Value.UpdateQueryTemplate = this.UpdateQueryTemplate.Text;

			this.Close();
		}

		private void NormalizeInput()
		{
			this.UpdateUserID.Text = this.UpdateUserID.Text.Trim();
			this.UpdateProgramID.Text = this.UpdateProgramID.Text.Trim();
			this.UpdateQueryTemplate.Text = this.UpdateQueryTemplate.Text.Trim();
		}

		private string ValidationCheck()
		{
			if (this.UpdateUserID.Text == "")
				return "更新ユーザーID が空です。";

			if (this.UpdateProgramID.Text == "")
				return "更新プログラムID が空です。";

			if (this.UpdateQueryTemplate.Text == "")
				return "更新クエリ・テンプレートが空です。";

			if (StringTools.HasControl(this.UpdateUserID.Text))
				return "更新ユーザーID に制御文字が含まれています。";

			if (StringTools.HasControl(this.UpdateProgramID.Text))
				return "更新プログラムID に制御文字が含まれています。";

			if (StringTools.HasControlWithoutTabCRLF(this.UpdateQueryTemplate.Text))
				return "更新クエリ・テンプレートに制御文字が含まれています。";

			if (!StringTools.IsShiftJIS(this.UpdateUserID.Text))
				return "更新ユーザーID に Shift_JIS に変換できない文字が含まれています。";

			if (!StringTools.IsShiftJIS(this.UpdateProgramID.Text))
				return "更新プログラムID に Shift_JIS に変換できない文字が含まれています。";

			if (!StringTools.IsShiftJIS(this.UpdateQueryTemplate.Text))
				return "更新クエリ・テンプレートに Shift_JIS に変換できない文字が含まれています。";

			return null;
		}
	}
}

//
// <<< Processed by SolutionConv
//