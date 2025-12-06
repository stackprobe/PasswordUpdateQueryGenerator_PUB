// Processed by SolutionConv >>>
//
// 本ソースファイルは、公開時の所定の手続きとして一部のセンシティブな情報をマスキングしています。
// 元データの機微に触れる可能性がある箇所を伏せ字化したものであり、
// リリース版との処理内容に実質的な差異が生じない範囲で調整を加えています。
//

namespace HLTStudio
{
	partial class LiteConverterFixedSaltWin
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LiteConverterFixedSaltWin));
			this.BtnClear = new System.Windows.Forms.Button();
			this.BtnCopyPasswordHash = new System.Windows.Forms.Button();
			this.BtnCopyOriginalPassword = new System.Windows.Forms.Button();
			this.BtnCopyToClipboard = new System.Windows.Forms.Button();
			this.BtnConvert = new System.Windows.Forms.Button();
			this.Salt = new System.Windows.Forms.TextBox();
			this.SaltTitle = new System.Windows.Forms.Label();
			this.PasswordHash = new System.Windows.Forms.TextBox();
			this.PasswordHashTitle = new System.Windows.Forms.Label();
			this.OriginalPassword = new System.Windows.Forms.TextBox();
			this.OriginalPasswordTitle = new System.Windows.Forms.Label();
			this.Password = new System.Windows.Forms.TextBox();
			this.PasswordTitle = new System.Windows.Forms.Label();
			this.BtnCreateSalt = new System.Windows.Forms.Button();
			this.BtnCopyOriginalSalt = new System.Windows.Forms.Button();
			this.OriginalSalt = new System.Windows.Forms.TextBox();
			this.OriginalSaltTitle = new System.Windows.Forms.Label();
			this.StatusMessage = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// ////////
			// 
			this.BtnClear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.BtnClear.Location = new System.Drawing.Point(303, 150);
			this.BtnClear.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.BtnClear.Name = "BtnClear";
			this.BtnClear.Size = new System.Drawing.Size(120, 40);
			this.BtnClear.TabIndex = 5;
			this.BtnClear.Text = "クリア";
			this.BtnClear.UseVisualStyleBackColor = true;
			this.BtnClear.Click += new System.EventHandler(this.BtnClear_Click);
			// 
			// ///////////////////
			// 
			this.BtnCopyPasswordHash.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.BtnCopyPasswordHash.Location = new System.Drawing.Point(491, 293);
			this.BtnCopyPasswordHash.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.BtnCopyPasswordHash.Name = "BtnCopyPasswordHash";
			this.BtnCopyPasswordHash.Size = new System.Drawing.Size(60, 27);
			this.BtnCopyPasswordHash.TabIndex = 12;
			this.BtnCopyPasswordHash.Text = "Copy";
			this.BtnCopyPasswordHash.UseVisualStyleBackColor = true;
			this.BtnCopyPasswordHash.Click += new System.EventHandler(this.BtnCopyPasswordHash_Click);
			// 
			// ///////////////////////
			// 
			this.BtnCopyOriginalPassword.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.BtnCopyOriginalPassword.Location = new System.Drawing.Point(491, 223);
			this.BtnCopyOriginalPassword.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.BtnCopyOriginalPassword.Name = "BtnCopyOriginalPassword";
			this.BtnCopyOriginalPassword.Size = new System.Drawing.Size(60, 27);
			this.BtnCopyOriginalPassword.TabIndex = 9;
			this.BtnCopyOriginalPassword.Text = "Copy";
			this.BtnCopyOriginalPassword.UseVisualStyleBackColor = true;
			this.BtnCopyOriginalPassword.Click += new System.EventHandler(this.BtnCopyOriginalPassword_Click);
			// 
			// //////////////////
			// 
			this.BtnCopyToClipboard.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.BtnCopyToClipboard.Location = new System.Drawing.Point(303, 427);
			this.BtnCopyToClipboard.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.BtnCopyToClipboard.Name = "BtnCopyToClipboard";
			this.BtnCopyToClipboard.Size = new System.Drawing.Size(248, 40);
			this.BtnCopyToClipboard.TabIndex = 17;
			this.BtnCopyToClipboard.Text = "クリップボードにコピー";
			this.BtnCopyToClipboard.UseVisualStyleBackColor = true;
			this.BtnCopyToClipboard.Click += new System.EventHandler(this.BtnCopyToClipboard_Click);
			// 
			// //////////
			// 
			this.BtnConvert.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.BtnConvert.Location = new System.Drawing.Point(431, 150);
			this.BtnConvert.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.BtnConvert.Name = "BtnConvert";
			this.BtnConvert.Size = new System.Drawing.Size(120, 40);
			this.BtnConvert.TabIndex = 6;
			this.BtnConvert.Text = "変　換";
			this.BtnConvert.UseVisualStyleBackColor = true;
			this.BtnConvert.Click += new System.EventHandler(this.BtnConvert_Click);
			// 
			// ////
			// 
			this.Salt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.Salt.Location = new System.Drawing.Point(12, 93);
			this.Salt.MaxLength = 300;
			this.Salt.Name = "Salt";
			this.Salt.Size = new System.Drawing.Size(412, 27);
			this.Salt.TabIndex = 3;
			this.Salt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Salt_KeyPress);
			// 
			// /////////
			// 
			this.SaltTitle.AutoSize = true;
			this.SaltTitle.Location = new System.Drawing.Point(12, 70);
			this.SaltTitle.Name = "SaltTitle";
			this.SaltTitle.Size = new System.Drawing.Size(33, 20);
			this.SaltTitle.TabIndex = 2;
			this.SaltTitle.Text = "Salt";
			// 
			// ////////////
			// 
			this.PasswordHash.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.PasswordHash.Location = new System.Drawing.Point(12, 293);
			this.PasswordHash.Name = "PasswordHash";
			this.PasswordHash.ReadOnly = true;
			this.PasswordHash.Size = new System.Drawing.Size(472, 27);
			this.PasswordHash.TabIndex = 11;
			this.PasswordHash.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PasswordHash_KeyPress);
			// 
			// /////////////////
			// 
			this.PasswordHashTitle.AutoSize = true;
			this.PasswordHashTitle.Location = new System.Drawing.Point(12, 270);
			this.PasswordHashTitle.Name = "PasswordHashTitle";
			this.PasswordHashTitle.Size = new System.Drawing.Size(178, 20);
			this.PasswordHashTitle.TabIndex = 10;
			this.PasswordHashTitle.Text = "ハッシュ化されたパスワード";
			// 
			// ////////////////
			// 
			this.OriginalPassword.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.OriginalPassword.Location = new System.Drawing.Point(12, 223);
			this.OriginalPassword.Name = "OriginalPassword";
			this.OriginalPassword.ReadOnly = true;
			this.OriginalPassword.Size = new System.Drawing.Size(472, 27);
			this.OriginalPassword.TabIndex = 8;
			this.OriginalPassword.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OriginalPassword_KeyPress);
			// 
			// /////////////////////
			// 
			this.OriginalPasswordTitle.AutoSize = true;
			this.OriginalPasswordTitle.Location = new System.Drawing.Point(12, 200);
			this.OriginalPasswordTitle.Name = "OriginalPasswordTitle";
			this.OriginalPasswordTitle.Size = new System.Drawing.Size(100, 20);
			this.OriginalPasswordTitle.TabIndex = 7;
			this.OriginalPasswordTitle.Text = "元のパスワード";
			// 
			// ////////
			// 
			this.Password.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.Password.Location = new System.Drawing.Point(12, 32);
			this.Password.MaxLength = 300;
			this.Password.Name = "Password";
			this.Password.Size = new System.Drawing.Size(540, 27);
			this.Password.TabIndex = 1;
			this.Password.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Password_KeyPress);
			// 
			// /////////////
			// 
			this.PasswordTitle.AutoSize = true;
			this.PasswordTitle.Location = new System.Drawing.Point(12, 9);
			this.PasswordTitle.Name = "PasswordTitle";
			this.PasswordTitle.Size = new System.Drawing.Size(74, 20);
			this.PasswordTitle.TabIndex = 0;
			this.PasswordTitle.Text = "パスワード";
			// 
			// /////////////
			// 
			this.BtnCreateSalt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.BtnCreateSalt.Location = new System.Drawing.Point(432, 86);
			this.BtnCreateSalt.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.BtnCreateSalt.Name = "BtnCreateSalt";
			this.BtnCreateSalt.Size = new System.Drawing.Size(120, 40);
			this.BtnCreateSalt.TabIndex = 4;
			this.BtnCreateSalt.Text = "<-- 生 成";
			this.BtnCreateSalt.UseVisualStyleBackColor = true;
			this.BtnCreateSalt.Click += new System.EventHandler(this.BtnCreateSalt_Click);
			// 
			// ///////////////////
			// 
			this.BtnCopyOriginalSalt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.BtnCopyOriginalSalt.Location = new System.Drawing.Point(491, 363);
			this.BtnCopyOriginalSalt.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.BtnCopyOriginalSalt.Name = "BtnCopyOriginalSalt";
			this.BtnCopyOriginalSalt.Size = new System.Drawing.Size(60, 27);
			this.BtnCopyOriginalSalt.TabIndex = 15;
			this.BtnCopyOriginalSalt.Text = "Copy";
			this.BtnCopyOriginalSalt.UseVisualStyleBackColor = true;
			this.BtnCopyOriginalSalt.Click += new System.EventHandler(this.BtnCopyOriginalSalt_Click);
			// 
			// ////////////
			// 
			this.OriginalSalt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.OriginalSalt.Location = new System.Drawing.Point(12, 363);
			this.OriginalSalt.Name = "OriginalSalt";
			this.OriginalSalt.ReadOnly = true;
			this.OriginalSalt.Size = new System.Drawing.Size(472, 27);
			this.OriginalSalt.TabIndex = 14;
			this.OriginalSalt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OriginalSalt_KeyPress);
			// 
			// /////////////////
			// 
			this.OriginalSaltTitle.AutoSize = true;
			this.OriginalSaltTitle.Location = new System.Drawing.Point(12, 340);
			this.OriginalSaltTitle.Name = "OriginalSaltTitle";
			this.OriginalSaltTitle.Size = new System.Drawing.Size(33, 20);
			this.OriginalSaltTitle.TabIndex = 13;
			this.OriginalSaltTitle.Text = "Salt";
			// 
			// /////////////
			// 
			this.StatusMessage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.StatusMessage.AutoSize = true;
			this.StatusMessage.ForeColor = System.Drawing.Color.Teal;
			this.StatusMessage.Location = new System.Drawing.Point(12, 452);
			this.StatusMessage.Name = "StatusMessage";
			this.StatusMessage.Size = new System.Drawing.Size(104, 20);
			this.StatusMessage.TabIndex = 16;
			this.StatusMessage.Text = "StatusMessage";
			// 
			// /////////////////////////
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(564, 481);
			this.Controls.Add(this.BtnCopyOriginalSalt);
			this.Controls.Add(this.OriginalSalt);
			this.Controls.Add(this.OriginalSaltTitle);
			this.Controls.Add(this.BtnCreateSalt);
			this.Controls.Add(this.BtnClear);
			this.Controls.Add(this.BtnCopyPasswordHash);
			this.Controls.Add(this.BtnCopyOriginalPassword);
			this.Controls.Add(this.BtnCopyToClipboard);
			this.Controls.Add(this.BtnConvert);
			this.Controls.Add(this.Salt);
			this.Controls.Add(this.SaltTitle);
			this.Controls.Add(this.PasswordHash);
			this.Controls.Add(this.PasswordHashTitle);
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
			this.Name = "LiteConverterFixedSaltWin";
			this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "簡易版 - 固定 Salt";
			this.Load += new System.EventHandler(this.LiteConverterFixedSaltWin_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button BtnClear;
		private System.Windows.Forms.Button BtnCopyPasswordHash;
		private System.Windows.Forms.Button BtnCopyOriginalPassword;
		private System.Windows.Forms.Button BtnCopyToClipboard;
		private System.Windows.Forms.Button BtnConvert;
		private System.Windows.Forms.TextBox Salt;
		private System.Windows.Forms.Label SaltTitle;
		private System.Windows.Forms.TextBox PasswordHash;
		private System.Windows.Forms.Label PasswordHashTitle;
		private System.Windows.Forms.TextBox OriginalPassword;
		private System.Windows.Forms.Label OriginalPasswordTitle;
		private System.Windows.Forms.TextBox Password;
		private System.Windows.Forms.Label PasswordTitle;
		private System.Windows.Forms.Button BtnCreateSalt;
		private System.Windows.Forms.Button BtnCopyOriginalSalt;
		private System.Windows.Forms.TextBox OriginalSalt;
		private System.Windows.Forms.Label OriginalSaltTitle;
		private System.Windows.Forms.Label StatusMessage;
	}
}

//
// <<< Processed by SolutionConv
//