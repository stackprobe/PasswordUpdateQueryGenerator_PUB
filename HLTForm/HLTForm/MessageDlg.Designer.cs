// Processed by SolutionConv >>>
//
// 本ソースファイルは、公開時の所定の手続きとして一部のセンシティブな情報をマスキングしています。
// 元データの機微に触れる可能性がある箇所を伏せ字化したものであり、
// リリース版との処理内容に実質的な差異が生じない範囲で調整を加えています。
//

namespace HLTStudio
{
	partial class MessageDlg
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MessageDlg));
			this.MessageIcon = new System.Windows.Forms.PictureBox();
			this.MessageText = new System.Windows.Forms.TextBox();
			this.BtnOK = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.MessageIcon)).BeginInit();
			this.SuspendLayout();
			// 
			// ///////////
			// 
			this.MessageIcon.Location = new System.Drawing.Point(12, 12);
			this.MessageIcon.Name = "MessageIcon";
			this.MessageIcon.Size = new System.Drawing.Size(100, 100);
			this.MessageIcon.TabIndex = 0;
			this.MessageIcon.TabStop = false;
			// 
			// ///////////
			// 
			this.MessageText.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.MessageText.BackColor = System.Drawing.SystemColors.Control;
			this.MessageText.Location = new System.Drawing.Point(118, 12);
			this.MessageText.Multiline = true;
			this.MessageText.Name = "MessageText";
			this.MessageText.ScrollBars = System.Windows.Forms.ScrollBars.Both;
			this.MessageText.Size = new System.Drawing.Size(354, 131);
			this.MessageText.TabIndex = 1;
			// 
			// /////
			// 
			this.BtnOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.BtnOK.Location = new System.Drawing.Point(12, 149);
			this.BtnOK.Name = "BtnOK";
			this.BtnOK.Size = new System.Drawing.Size(200, 40);
			this.BtnOK.TabIndex = 0;
			this.BtnOK.Text = "OK";
			this.BtnOK.UseVisualStyleBackColor = true;
			this.BtnOK.Click += new System.EventHandler(this.BtnOK_Click);
			// 
			// //////////
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(484, 201);
			this.Controls.Add(this.BtnOK);
			this.Controls.Add(this.MessageText);
			this.Controls.Add(this.MessageIcon);
			this.Font = new System.Drawing.Font("メイリオ", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "MessageDlg";
			this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "情報";
			this.Load += new System.EventHandler(this.MessageDlg_Load);
			this.Resize += new System.EventHandler(this.MessageDlg_Resize);
			((System.ComponentModel.ISupportInitialize)(this.MessageIcon)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.PictureBox MessageIcon;
		private System.Windows.Forms.TextBox MessageText;
		private System.Windows.Forms.Button BtnOK;
	}
}

//
// <<< Processed by SolutionConv
//