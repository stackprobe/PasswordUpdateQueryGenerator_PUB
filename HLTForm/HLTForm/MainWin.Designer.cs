// Processed by SolutionConv >>>
//
// 本ソースファイルは、公開時の所定の手続きとして一部のセンシティブな情報をマスキングしています。
// 元データの機微に触れる可能性がある箇所を伏せ字化したものであり、
// リリース版との処理内容に実質的な差異が生じない範囲で調整を加えています。
//

namespace HLTStudio
{
	partial class MainWin
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWin));
			this.InputCSVFileGroup = new System.Windows.Forms.GroupBox();
			this.BtnBrowseInputCSVFile = new System.Windows.Forms.Button();
			this.InputCSVFile = new System.Windows.Forms.TextBox();
			this.InputCSVFileDropArea = new System.Windows.Forms.Label();
			this.MainMenu = new System.Windows.Forms.MenuStrip();
			this.MainMenu_File = new System.Windows.Forms.ToolStripMenuItem();
			this.MainMenu_File_Exit = new System.Windows.Forms.ToolStripMenuItem();
			this.MainMenu_Edit = new System.Windows.Forms.ToolStripMenuItem();
			this.MainMenu_Edit_Clear = new System.Windows.Forms.ToolStripMenuItem();
			this.MainMenu_Edit_Separater = new System.Windows.Forms.ToolStripSeparator();
			this.MainMenu_Edit_Setting = new System.Windows.Forms.ToolStripMenuItem();
			this.MainMenu_Tool = new System.Windows.Forms.ToolStripMenuItem();
			this.MainMenu_Tool_LiteConverter = new System.Windows.Forms.ToolStripMenuItem();
			this.MainMenu_Tool_LiteConverter_Text = new System.Windows.Forms.ToolStripMenuItem();
			this.MainMenu_Tool_LiteConverter_FixedSalt = new System.Windows.Forms.ToolStripMenuItem();
			this.MainMenu_Tool_LiteConverter_UpdateQuery = new System.Windows.Forms.ToolStripMenuItem();
			this.BtnOutputCsv = new System.Windows.Forms.Button();
			this.BtnOutputUpdateQuery = new System.Windows.Forms.Button();
			this.InputCSVFileGroup.SuspendLayout();
			this.MainMenu.SuspendLayout();
			this.SuspendLayout();
			// 
			// /////////////////
			// 
			this.InputCSVFileGroup.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.InputCSVFileGroup.Controls.Add(this.BtnBrowseInputCSVFile);
			this.InputCSVFileGroup.Controls.Add(this.InputCSVFile);
			this.InputCSVFileGroup.Controls.Add(this.InputCSVFileDropArea);
			this.InputCSVFileGroup.Location = new System.Drawing.Point(12, 27);
			this.InputCSVFileGroup.Name = "InputCSVFileGroup";
			this.InputCSVFileGroup.Size = new System.Drawing.Size(560, 230);
			this.InputCSVFileGroup.TabIndex = 1;
			this.InputCSVFileGroup.TabStop = false;
			this.InputCSVFileGroup.Text = "入力ファイル";
			// 
			// /////////////////////
			// 
			this.BtnBrowseInputCSVFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.BtnBrowseInputCSVFile.Location = new System.Drawing.Point(514, 197);
			this.BtnBrowseInputCSVFile.Name = "BtnBrowseInputCSVFile";
			this.BtnBrowseInputCSVFile.Size = new System.Drawing.Size(40, 27);
			this.BtnBrowseInputCSVFile.TabIndex = 1;
			this.BtnBrowseInputCSVFile.Text = "...";
			this.BtnBrowseInputCSVFile.UseVisualStyleBackColor = true;
			this.BtnBrowseInputCSVFile.Click += new System.EventHandler(this.BtnBrowseInputCSVFile_Click);
			// 
			// ////////////
			// 
			this.InputCSVFile.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.InputCSVFile.Location = new System.Drawing.Point(6, 197);
			this.InputCSVFile.MaxLength = 300;
			this.InputCSVFile.Name = "InputCSVFile";
			this.InputCSVFile.Size = new System.Drawing.Size(502, 27);
			this.InputCSVFile.TabIndex = 2;
			this.InputCSVFile.TextChanged += new System.EventHandler(this.InputCSVFile_TextChanged);
			// 
			// ////////////////////
			// 
			this.InputCSVFileDropArea.AllowDrop = true;
			this.InputCSVFileDropArea.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.InputCSVFileDropArea.Location = new System.Drawing.Point(6, 23);
			this.InputCSVFileDropArea.Name = "InputCSVFileDropArea";
			this.InputCSVFileDropArea.Size = new System.Drawing.Size(548, 171);
			this.InputCSVFileDropArea.TabIndex = 0;
			this.InputCSVFileDropArea.Text = "ここへ CSV ファイルを\r\nドラッグアンドドロップして下さい";
			this.InputCSVFileDropArea.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.InputCSVFileDropArea.DragDrop += new System.Windows.Forms.DragEventHandler(this.InputCSVFileDropArea_DragDrop);
			this.InputCSVFileDropArea.DragEnter += new System.Windows.Forms.DragEventHandler(this.InputCSVFileDropArea_DragEnter);
			// 
			// ////////
			// 
			this.MainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MainMenu_File,
            this.MainMenu_Edit,
            this.MainMenu_Tool});
			this.MainMenu.Location = new System.Drawing.Point(0, 0);
			this.MainMenu.Name = "MainMenu";
			this.MainMenu.Size = new System.Drawing.Size(584, 24);
			this.MainMenu.TabIndex = 0;
			this.MainMenu.Text = "menuStrip1";
			// 
			// /////////////
			// 
			this.MainMenu_File.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MainMenu_File_Exit});
			this.MainMenu_File.Name = "MainMenu_File";
			this.MainMenu_File.Size = new System.Drawing.Size(67, 20);
			this.MainMenu_File.Text = "ファイル(&F)";
			// 
			// //////////////////
			// 
			this.MainMenu_File_Exit.Name = "MainMenu_File_Exit";
			this.MainMenu_File_Exit.Size = new System.Drawing.Size(112, 22);
			this.MainMenu_File_Exit.Text = "終了(&F)";
			this.MainMenu_File_Exit.Click += new System.EventHandler(this.MainMenu_File_Exit_Click);
			// 
			// /////////////
			// 
			this.MainMenu_Edit.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MainMenu_Edit_Clear,
            this.MainMenu_Edit_Separater,
            this.MainMenu_Edit_Setting});
			this.MainMenu_Edit.Name = "MainMenu_Edit";
			this.MainMenu_Edit.Size = new System.Drawing.Size(57, 20);
			this.MainMenu_Edit.Text = "編集(&E)";
			// 
			// ///////////////////
			// 
			this.MainMenu_Edit_Clear.Name = "MainMenu_Edit_Clear";
			this.MainMenu_Edit_Clear.Size = new System.Drawing.Size(115, 22);
			this.MainMenu_Edit_Clear.Text = "クリア(&C)";
			this.MainMenu_Edit_Clear.Click += new System.EventHandler(this.MainMenu_Edit_Clear_Click);
			// 
			// ///////////////////////
			// 
			this.MainMenu_Edit_Separater.Name = "MainMenu_Edit_Separater";
			this.MainMenu_Edit_Separater.Size = new System.Drawing.Size(112, 6);
			// 
			// /////////////////////
			// 
			this.MainMenu_Edit_Setting.Name = "MainMenu_Edit_Setting";
			this.MainMenu_Edit_Setting.Size = new System.Drawing.Size(115, 22);
			this.MainMenu_Edit_Setting.Text = "設定(&S)";
			this.MainMenu_Edit_Setting.Click += new System.EventHandler(this.MainMenu_Edit_Setting_Click);
			// 
			// /////////////
			// 
			this.MainMenu_Tool.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MainMenu_Tool_LiteConverter});
			this.MainMenu_Tool.Name = "MainMenu_Tool";
			this.MainMenu_Tool.Size = new System.Drawing.Size(60, 20);
			this.MainMenu_Tool.Text = "ツール(&T)";
			// 
			// ///////////////////////////
			// 
			this.MainMenu_Tool_LiteConverter.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MainMenu_Tool_LiteConverter_Text,
            this.MainMenu_Tool_LiteConverter_FixedSalt,
            this.MainMenu_Tool_LiteConverter_UpdateQuery});
			this.MainMenu_Tool_LiteConverter.Name = "MainMenu_Tool_LiteConverter";
			this.MainMenu_Tool_LiteConverter.Size = new System.Drawing.Size(124, 22);
			this.MainMenu_Tool_LiteConverter.Text = "簡易版(&L)";
			// 
			// ////////////////////////////////
			// 
			this.MainMenu_Tool_LiteConverter_Text.Name = "MainMenu_Tool_LiteConverter_Text";
			this.MainMenu_Tool_LiteConverter_Text.Size = new System.Drawing.Size(163, 22);
			this.MainMenu_Tool_LiteConverter_Text.Text = "テキスト(&T)";
			this.MainMenu_Tool_LiteConverter_Text.Click += new System.EventHandler(this.MainMenu_Tool_LiteConverter_Text_Click);
			// 
			// /////////////////////////////////////
			// 
			this.MainMenu_Tool_LiteConverter_FixedSalt.Name = "MainMenu_Tool_LiteConverter_FixedSalt";
			this.MainMenu_Tool_LiteConverter_FixedSalt.Size = new System.Drawing.Size(163, 22);
			this.MainMenu_Tool_LiteConverter_FixedSalt.Text = "固定 Salt(&S)";
			this.MainMenu_Tool_LiteConverter_FixedSalt.Click += new System.EventHandler(this.MainMenu_Tool_LiteConverter_FixedSalt_Click);
			// 
			// ///////////////////////////////////////
			// 
			this.MainMenu_Tool_LiteConverter_UpdateQuery.Name = "MainMenu_Tool_LiteConverter_UpdateQuery";
			this.MainMenu_Tool_LiteConverter_UpdateQuery.Size = new System.Drawing.Size(163, 22);
			this.MainMenu_Tool_LiteConverter_UpdateQuery.Text = "UPDATE クエリ(&Q)";
			this.MainMenu_Tool_LiteConverter_UpdateQuery.Click += new System.EventHandler(this.MainMenu_Tool_LiteConverter_UpdateQuery_Click);
			// 
			// ////////////
			// 
			this.BtnOutputCsv.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.BtnOutputCsv.Location = new System.Drawing.Point(12, 263);
			this.BtnOutputCsv.Name = "BtnOutputCsv";
			this.BtnOutputCsv.Size = new System.Drawing.Size(200, 40);
			this.BtnOutputCsv.TabIndex = 2;
			this.BtnOutputCsv.Text = "CSV 出力";
			this.BtnOutputCsv.UseVisualStyleBackColor = true;
			this.BtnOutputCsv.Click += new System.EventHandler(this.BtnOutputCsv_Click);
			// 
			// ////////////////////
			// 
			this.BtnOutputUpdateQuery.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.BtnOutputUpdateQuery.Location = new System.Drawing.Point(12, 309);
			this.BtnOutputUpdateQuery.Name = "BtnOutputUpdateQuery";
			this.BtnOutputUpdateQuery.Size = new System.Drawing.Size(200, 40);
			this.BtnOutputUpdateQuery.TabIndex = 3;
			this.BtnOutputUpdateQuery.Text = "UPDATE クエリ出力";
			this.BtnOutputUpdateQuery.UseVisualStyleBackColor = true;
			this.BtnOutputUpdateQuery.Click += new System.EventHandler(this.BtnOutputUpdateQuery_Click);
			// 
			// ///////
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(584, 361);
			this.Controls.Add(this.InputCSVFileGroup);
			this.Controls.Add(this.BtnOutputUpdateQuery);
			this.Controls.Add(this.BtnOutputCsv);
			this.Controls.Add(this.MainMenu);
			this.Font = new System.Drawing.Font("メイリオ", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MainMenuStrip = this.MainMenu;
			this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "MainWin";
			this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "ハッシュ化パスワード更新クエリ生成ツール";
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainWin_FormClosed);
			this.Load += new System.EventHandler(this.MainWin_Load);
			this.InputCSVFileGroup.ResumeLayout(false);
			this.InputCSVFileGroup.PerformLayout();
			this.MainMenu.ResumeLayout(false);
			this.MainMenu.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.GroupBox InputCSVFileGroup;
		private System.Windows.Forms.Button BtnBrowseInputCSVFile;
		private System.Windows.Forms.TextBox InputCSVFile;
		private System.Windows.Forms.Label InputCSVFileDropArea;
		private System.Windows.Forms.MenuStrip MainMenu;
		private System.Windows.Forms.ToolStripMenuItem MainMenu_File;
		private System.Windows.Forms.ToolStripMenuItem MainMenu_File_Exit;
		private System.Windows.Forms.ToolStripMenuItem MainMenu_Edit;
		private System.Windows.Forms.ToolStripMenuItem MainMenu_Edit_Clear;
		private System.Windows.Forms.ToolStripSeparator MainMenu_Edit_Separater;
		private System.Windows.Forms.ToolStripMenuItem MainMenu_Edit_Setting;
		private System.Windows.Forms.ToolStripMenuItem MainMenu_Tool;
		private System.Windows.Forms.ToolStripMenuItem MainMenu_Tool_LiteConverter;
		private System.Windows.Forms.Button BtnOutputCsv;
		private System.Windows.Forms.Button BtnOutputUpdateQuery;
		private System.Windows.Forms.ToolStripMenuItem MainMenu_Tool_LiteConverter_Text;
		private System.Windows.Forms.ToolStripMenuItem MainMenu_Tool_LiteConverter_FixedSalt;
		private System.Windows.Forms.ToolStripMenuItem MainMenu_Tool_LiteConverter_UpdateQuery;

	}
}

//
// <<< Processed by SolutionConv
//