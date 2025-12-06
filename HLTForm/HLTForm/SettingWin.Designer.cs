// Processed by SolutionConv >>>
//
// 本ソースファイルは、公開時の所定の手続きとして一部のセンシティブな情報をマスキングしています。
// 元データの機微に触れる可能性がある箇所を伏せ字化したものであり、
// リリース版との処理内容に実質的な差異が生じない範囲で調整を加えています。
//

namespace HLTStudio
{
	partial class SettingWin
	{
		/// /////////
		/// /////////////
		/// //////////
		private System.ComponentModel.IContainer components = null;

		/// /////////
		/// ///////////////////////
		/// //////////
		/// ////// ///////////////////// //////////// ////////////// ///// ///////////
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region /////// //// //////////////

		/// /////////
		/// ///// /////////////////////////
		/// /// /////////////////
		/// //////////
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingWin));
			this.MainTab = new System.Windows.Forms.TabControl();
			this.TabPage_01 = new System.Windows.Forms.TabPage();
			this.UpdateProgramID = new System.Windows.Forms.TextBox();
			this.UpdateProgramIDTitle = new System.Windows.Forms.Label();
			this.UpdateUserID = new System.Windows.Forms.TextBox();
			this.UpdateUserIDTitle = new System.Windows.Forms.Label();
			this.TabPage_02 = new System.Windows.Forms.TabPage();
			this.UpdateQueryDescription = new System.Windows.Forms.Label();
			this.BtnDefault = new System.Windows.Forms.Button();
			this.UpdateQueryTemplate = new System.Windows.Forms.TextBox();
			this.BtnCancel = new System.Windows.Forms.Button();
			this.BtnOK = new System.Windows.Forms.Button();
			this.MainTab.SuspendLayout();
			this.TabPage_01.SuspendLayout();
			this.TabPage_02.SuspendLayout();
			this.SuspendLayout();
			// 
			// ///////
			// 
			this.MainTab.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.MainTab.Controls.Add(this.TabPage_01);
			this.MainTab.Controls.Add(this.TabPage_02);
			this.MainTab.Location = new System.Drawing.Point(13, 14);
			this.MainTab.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.MainTab.Name = "MainTab";
			this.MainTab.SelectedIndex = 0;
			this.MainTab.Size = new System.Drawing.Size(558, 283);
			this.MainTab.TabIndex = 0;
			// 
			// //////////
			// 
			this.TabPage_01.Controls.Add(this.UpdateProgramID);
			this.TabPage_01.Controls.Add(this.UpdateProgramIDTitle);
			this.TabPage_01.Controls.Add(this.UpdateUserID);
			this.TabPage_01.Controls.Add(this.UpdateUserIDTitle);
			this.TabPage_01.Location = new System.Drawing.Point(4, 29);
			this.TabPage_01.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.TabPage_01.Name = "TabPage_01";
			this.TabPage_01.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.TabPage_01.Size = new System.Drawing.Size(550, 250);
			this.TabPage_01.TabIndex = 0;
			this.TabPage_01.Text = "基本";
			this.TabPage_01.UseVisualStyleBackColor = true;
			// 
			// ///////////////
			// 
			this.UpdateProgramID.Location = new System.Drawing.Point(44, 143);
			this.UpdateProgramID.MaxLength = 4;
			this.UpdateProgramID.Name = "UpdateProgramID";
			this.UpdateProgramID.Size = new System.Drawing.Size(200, 27);
			this.UpdateProgramID.TabIndex = 3;
			// 
			// ////////////////////
			// 
			this.UpdateProgramIDTitle.AutoSize = true;
			this.UpdateProgramIDTitle.Location = new System.Drawing.Point(40, 120);
			this.UpdateProgramIDTitle.Name = "UpdateProgramIDTitle";
			this.UpdateProgramIDTitle.Size = new System.Drawing.Size(208, 20);
			this.UpdateProgramIDTitle.TabIndex = 2;
			this.UpdateProgramIDTitle.Text = "更新プログラムID　(最大 4 文字)";
			// 
			// ////////////
			// 
			this.UpdateUserID.Location = new System.Drawing.Point(44, 63);
			this.UpdateUserID.MaxLength = 7;
			this.UpdateUserID.Name = "UpdateUserID";
			this.UpdateUserID.Size = new System.Drawing.Size(200, 27);
			this.UpdateUserID.TabIndex = 1;
			// 
			// /////////////////
			// 
			this.UpdateUserIDTitle.AutoSize = true;
			this.UpdateUserIDTitle.Location = new System.Drawing.Point(40, 40);
			this.UpdateUserIDTitle.Name = "UpdateUserIDTitle";
			this.UpdateUserIDTitle.Size = new System.Drawing.Size(195, 20);
			this.UpdateUserIDTitle.TabIndex = 0;
			this.UpdateUserIDTitle.Text = "更新ユーザーID　(最大 7 文字)";
			// 
			// //////////
			// 
			this.TabPage_02.Controls.Add(this.UpdateQueryDescription);
			this.TabPage_02.Controls.Add(this.BtnDefault);
			this.TabPage_02.Controls.Add(this.UpdateQueryTemplate);
			this.TabPage_02.Location = new System.Drawing.Point(4, 29);
			this.TabPage_02.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.TabPage_02.Name = "TabPage_02";
			this.TabPage_02.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.TabPage_02.Size = new System.Drawing.Size(550, 250);
			this.TabPage_02.TabIndex = 1;
			this.TabPage_02.Text = "更新クエリ・テンプレート";
			this.TabPage_02.UseVisualStyleBackColor = true;
			// 
			// //////////////////////
			// 
			this.UpdateQueryDescription.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.UpdateQueryDescription.AutoSize = true;
			this.UpdateQueryDescription.ForeColor = System.Drawing.Color.Blue;
			this.UpdateQueryDescription.Location = new System.Drawing.Point(7, 205);
			this.UpdateQueryDescription.Name = "UpdateQueryDescription";
			this.UpdateQueryDescription.Size = new System.Drawing.Size(499, 40);
			this.UpdateQueryDescription.TabIndex = 2;
			this.UpdateQueryDescription.Text = "<VNCD> ベンダーコード　<HSPW> ハッシュ化されたパスワード　<SALT> Salt\r\n<UUID> 更新ユーザーID　<UPID> 更新プログラムID" +
    "";
			// 
			// //////////
			// 
			this.BtnDefault.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.BtnDefault.Location = new System.Drawing.Point(382, 10);
			this.BtnDefault.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.BtnDefault.Name = "BtnDefault";
			this.BtnDefault.Size = new System.Drawing.Size(160, 40);
			this.BtnDefault.TabIndex = 0;
			this.BtnDefault.Text = "デフォルトに戻す";
			this.BtnDefault.UseVisualStyleBackColor = true;
			this.BtnDefault.Click += new System.EventHandler(this.BtnDefault_Click);
			// 
			// ///////////////////
			// 
			this.UpdateQueryTemplate.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.UpdateQueryTemplate.Font = new System.Drawing.Font("ＭＳ ゴシック", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.UpdateQueryTemplate.Location = new System.Drawing.Point(7, 58);
			this.UpdateQueryTemplate.MaxLength = 10000;
			this.UpdateQueryTemplate.Multiline = true;
			this.UpdateQueryTemplate.Name = "UpdateQueryTemplate";
			this.UpdateQueryTemplate.ScrollBars = System.Windows.Forms.ScrollBars.Both;
			this.UpdateQueryTemplate.Size = new System.Drawing.Size(536, 144);
			this.UpdateQueryTemplate.TabIndex = 1;
			// 
			// /////////
			// 
			this.BtnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.BtnCancel.Location = new System.Drawing.Point(411, 307);
			this.BtnCancel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.BtnCancel.Name = "BtnCancel";
			this.BtnCancel.Size = new System.Drawing.Size(160, 40);
			this.BtnCancel.TabIndex = 2;
			this.BtnCancel.Text = "キャンセル";
			this.BtnCancel.UseVisualStyleBackColor = true;
			this.BtnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
			// 
			// /////
			// 
			this.BtnOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.BtnOK.Location = new System.Drawing.Point(243, 307);
			this.BtnOK.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.BtnOK.Name = "BtnOK";
			this.BtnOK.Size = new System.Drawing.Size(160, 40);
			this.BtnOK.TabIndex = 1;
			this.BtnOK.Text = "OK";
			this.BtnOK.UseVisualStyleBackColor = true;
			this.BtnOK.Click += new System.EventHandler(this.BtnOK_Click);
			// 
			// //////////
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(584, 361);
			this.Controls.Add(this.BtnOK);
			this.Controls.Add(this.BtnCancel);
			this.Controls.Add(this.MainTab);
			this.Font = new System.Drawing.Font("メイリオ", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.Name = "SettingWin";
			this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "設定";
			this.Load += new System.EventHandler(this.SettingWin_Load);
			this.MainTab.ResumeLayout(false);
			this.TabPage_01.ResumeLayout(false);
			this.TabPage_01.PerformLayout();
			this.TabPage_02.ResumeLayout(false);
			this.TabPage_02.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TabControl MainTab;
		private System.Windows.Forms.TabPage TabPage_01;
		private System.Windows.Forms.TabPage TabPage_02;
		private System.Windows.Forms.Button BtnCancel;
		private System.Windows.Forms.Button BtnOK;
		private System.Windows.Forms.TextBox UpdateProgramID;
		private System.Windows.Forms.Label UpdateProgramIDTitle;
		private System.Windows.Forms.TextBox UpdateUserID;
		private System.Windows.Forms.Label UpdateUserIDTitle;
		private System.Windows.Forms.Label UpdateQueryDescription;
		private System.Windows.Forms.Button BtnDefault;
		private System.Windows.Forms.TextBox UpdateQueryTemplate;
	}
}

//
// <<< Processed by SolutionConv
//