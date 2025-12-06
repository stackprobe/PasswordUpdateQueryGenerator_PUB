// Processed by SolutionConv >>>
//
// 本ソースファイルは、公開時の所定の手続きとして一部のセンシティブな情報をマスキングしています。
// 元データの機微に触れる可能性がある箇所を伏せ字化したものであり、
// リリース版との処理内容に実質的な差異が生じない範囲で調整を加えています。
//

namespace HLTStudio
{
	partial class LiteConverterUpdateQueryWin
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LiteConverterUpdateQueryWin));
			this.BtnClear = new System.Windows.Forms.Button();
			this.BtnCopyOriginalPassword = new System.Windows.Forms.Button();
			this.BtnCopyToClipboard = new System.Windows.Forms.Button();
			this.BtnConvert = new System.Windows.Forms.Button();
			this.UpdateQuery = new System.Windows.Forms.TextBox();
			this.UpdateQueryTitle = new System.Windows.Forms.Label();
			this.OriginalPassword = new System.Windows.Forms.TextBox();
			this.OriginalPasswordTitle = new System.Windows.Forms.Label();
			this.Password = new System.Windows.Forms.TextBox();
			this.PasswordTitle = new System.Windows.Forms.Label();
			this.VendorCodeTitle = new System.Windows.Forms.Label();
			this.VendorCode = new System.Windows.Forms.TextBox();
			this.StatusMessage = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// ////////
			// 
			this.BtnClear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.BtnClear.Location = new System.Drawing.Point(323, 138);
			this.BtnClear.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.BtnClear.Name = "BtnClear";
			this.BtnClear.Size = new System.Drawing.Size(120, 40);
			this.BtnClear.TabIndex = 4;
			this.BtnClear.Text = "クリア";
			this.BtnClear.UseVisualStyleBackColor = true;
			this.BtnClear.Click += new System.EventHandler(this.BtnClear_Click);
			// 
			// ///////////////////////
			// 
			this.BtnCopyOriginalPassword.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.BtnCopyOriginalPassword.Location = new System.Drawing.Point(511, 213);
			this.BtnCopyOriginalPassword.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.BtnCopyOriginalPassword.Name = "BtnCopyOriginalPassword";
			this.BtnCopyOriginalPassword.Size = new System.Drawing.Size(60, 27);
			this.BtnCopyOriginalPassword.TabIndex = 8;
			this.BtnCopyOriginalPassword.Text = "Copy";
			this.BtnCopyOriginalPassword.UseVisualStyleBackColor = true;
			this.BtnCopyOriginalPassword.Click += new System.EventHandler(this.BtnCopyOriginalPassword_Click);
			// 
			// //////////////////
			// 
			this.BtnCopyToClipboard.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.BtnCopyToClipboard.Location = new System.Drawing.Point(323, 427);
			this.BtnCopyToClipboard.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.BtnCopyToClipboard.Name = "BtnCopyToClipboard";
			this.BtnCopyToClipboard.Size = new System.Drawing.Size(248, 40);
			this.BtnCopyToClipboard.TabIndex = 12;
			this.BtnCopyToClipboard.Text = "クリップボードにコピー";
			this.BtnCopyToClipboard.UseVisualStyleBackColor = true;
			this.BtnCopyToClipboard.Click += new System.EventHandler(this.BtnCopyToClipboard_Click);
			// 
			// //////////
			// 
			this.BtnConvert.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.BtnConvert.Location = new System.Drawing.Point(451, 138);
			this.BtnConvert.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.BtnConvert.Name = "BtnConvert";
			this.BtnConvert.Size = new System.Drawing.Size(120, 40);
			this.BtnConvert.TabIndex = 5;
			this.BtnConvert.Text = "変　換";
			this.BtnConvert.UseVisualStyleBackColor = true;
			this.BtnConvert.Click += new System.EventHandler(this.BtnConvert_Click);
			// 
			// ///////////
			// 
			this.UpdateQuery.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.UpdateQuery.Font = new System.Drawing.Font("ＭＳ ゴシック", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.UpdateQuery.Location = new System.Drawing.Point(12, 283);
			this.UpdateQuery.Multiline = true;
			this.UpdateQuery.Name = "UpdateQuery";
			this.UpdateQuery.ReadOnly = true;
			this.UpdateQuery.ScrollBars = System.Windows.Forms.ScrollBars.Both;
			this.UpdateQuery.Size = new System.Drawing.Size(560, 136);
			this.UpdateQuery.TabIndex = 10;
			this.UpdateQuery.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.UpdateQuery_KeyPress);
			// 
			// ////////////////
			// 
			this.UpdateQueryTitle.AutoSize = true;
			this.UpdateQueryTitle.Location = new System.Drawing.Point(12, 260);
			this.UpdateQueryTitle.Name = "UpdateQueryTitle";
			this.UpdateQueryTitle.Size = new System.Drawing.Size(103, 20);
			this.UpdateQueryTitle.TabIndex = 9;
			this.UpdateQueryTitle.Text = "UPDATE クエリ";
			// 
			// ////////////////
			// 
			this.OriginalPassword.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.OriginalPassword.Location = new System.Drawing.Point(12, 213);
			this.OriginalPassword.Name = "OriginalPassword";
			this.OriginalPassword.ReadOnly = true;
			this.OriginalPassword.Size = new System.Drawing.Size(492, 27);
			this.OriginalPassword.TabIndex = 7;
			this.OriginalPassword.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OriginalPassword_KeyPress);
			// 
			// /////////////////////
			// 
			this.OriginalPasswordTitle.AutoSize = true;
			this.OriginalPasswordTitle.Location = new System.Drawing.Point(12, 190);
			this.OriginalPasswordTitle.Name = "OriginalPasswordTitle";
			this.OriginalPasswordTitle.Size = new System.Drawing.Size(100, 20);
			this.OriginalPasswordTitle.TabIndex = 6;
			this.OriginalPasswordTitle.Text = "元のパスワード";
			// 
			// ////////
			// 
			this.Password.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.Password.Location = new System.Drawing.Point(12, 103);
			this.Password.MaxLength = 300;
			this.Password.Name = "Password";
			this.Password.Size = new System.Drawing.Size(560, 27);
			this.Password.TabIndex = 3;
			this.Password.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Password_KeyPress);
			// 
			// /////////////
			// 
			this.PasswordTitle.AutoSize = true;
			this.PasswordTitle.Location = new System.Drawing.Point(12, 80);
			this.PasswordTitle.Name = "PasswordTitle";
			this.PasswordTitle.Size = new System.Drawing.Size(74, 20);
			this.PasswordTitle.TabIndex = 2;
			this.PasswordTitle.Text = "パスワード";
			// 
			// ///////////////
			// 
			this.VendorCodeTitle.AutoSize = true;
			this.VendorCodeTitle.Location = new System.Drawing.Point(12, 9);
			this.VendorCodeTitle.Name = "VendorCodeTitle";
			this.VendorCodeTitle.Size = new System.Drawing.Size(100, 20);
			this.VendorCodeTitle.TabIndex = 0;
			this.VendorCodeTitle.Text = "ベンダーコード";
			// 
			// //////////
			// 
			this.VendorCode.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.VendorCode.Location = new System.Drawing.Point(12, 32);
			this.VendorCode.MaxLength = 300;
			this.VendorCode.Name = "VendorCode";
			this.VendorCode.Size = new System.Drawing.Size(560, 27);
			this.VendorCode.TabIndex = 1;
			this.VendorCode.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.VendorCode_KeyPress);
			// 
			// /////////////
			// 
			this.StatusMessage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.StatusMessage.AutoSize = true;
			this.StatusMessage.ForeColor = System.Drawing.Color.Teal;
			this.StatusMessage.Location = new System.Drawing.Point(12, 452);
			this.StatusMessage.Name = "StatusMessage";
			this.StatusMessage.Size = new System.Drawing.Size(104, 20);
			this.StatusMessage.TabIndex = 11;
			this.StatusMessage.Text = "StatusMessage";
			// 
			// ///////////////////////////
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(584, 481);
			this.Controls.Add(this.VendorCode);
			this.Controls.Add(this.VendorCodeTitle);
			this.Controls.Add(this.BtnClear);
			this.Controls.Add(this.BtnCopyOriginalPassword);
			this.Controls.Add(this.BtnCopyToClipboard);
			this.Controls.Add(this.BtnConvert);
			this.Controls.Add(this.UpdateQuery);
			this.Controls.Add(this.UpdateQueryTitle);
			this.Controls.Add(this.OriginalPassword);
			this.Controls.Add(this.OriginalPasswordTitle);
			this.Controls.Add(this.Password);
			this.Controls.Add(this.PasswordTitle);
			this.Controls.Add(this.StatusMessage);
			this.Font = new System.Drawing.Font("メイリオ", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "LiteConverterUpdateQueryWin";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "簡易版 - UPDATE クエリ";
			this.Load += new System.EventHandler(this.LiteConverterUpdateQueryWin_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button BtnClear;
		private System.Windows.Forms.Button BtnCopyOriginalPassword;
		private System.Windows.Forms.Button BtnCopyToClipboard;
		private System.Windows.Forms.Button BtnConvert;
		private System.Windows.Forms.TextBox UpdateQuery;
		private System.Windows.Forms.Label UpdateQueryTitle;
		private System.Windows.Forms.TextBox OriginalPassword;
		private System.Windows.Forms.Label OriginalPasswordTitle;
		private System.Windows.Forms.TextBox Password;
		private System.Windows.Forms.Label PasswordTitle;
		private System.Windows.Forms.Label VendorCodeTitle;
		private System.Windows.Forms.TextBox VendorCode;
		private System.Windows.Forms.Label StatusMessage;
	}
}

//
// <<< Processed by SolutionConv
//