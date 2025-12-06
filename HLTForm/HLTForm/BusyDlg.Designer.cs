// Processed by SolutionConv >>>
//
// 本ソースファイルは、公開時の所定の手続きとして一部のセンシティブな情報をマスキングしています。
// 元データの機微に触れる可能性がある箇所を伏せ字化したものであり、
// リリース版との処理内容に実質的な差異が生じない範囲で調整を加えています。
//

namespace HLTStudio
{
	partial class BusyDlg
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BusyDlg));
			this.MainProgressBar = new System.Windows.Forms.ProgressBar();
			this.BtnCancel = new System.Windows.Forms.Button();
			this.LabelMessage = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// ///////////////
			// 
			this.MainProgressBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.MainProgressBar.Location = new System.Drawing.Point(12, 69);
			this.MainProgressBar.Name = "MainProgressBar";
			this.MainProgressBar.Size = new System.Drawing.Size(460, 30);
			this.MainProgressBar.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
			this.MainProgressBar.TabIndex = 1;
			// 
			// /////////
			// 
			this.BtnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.BtnCancel.Location = new System.Drawing.Point(351, 107);
			this.BtnCancel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.BtnCancel.Name = "BtnCancel";
			this.BtnCancel.Size = new System.Drawing.Size(120, 40);
			this.BtnCancel.TabIndex = 2;
			this.BtnCancel.Text = "中　止";
			this.BtnCancel.UseVisualStyleBackColor = true;
			this.BtnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
			// 
			// ////////////
			// 
			this.LabelMessage.AutoSize = true;
			this.LabelMessage.Location = new System.Drawing.Point(12, 30);
			this.LabelMessage.Name = "LabelMessage";
			this.LabelMessage.Size = new System.Drawing.Size(89, 20);
			this.LabelMessage.TabIndex = 0;
			this.LabelMessage.Text = "処理中です...";
			// 
			// ///////
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(484, 161);
			this.Controls.Add(this.LabelMessage);
			this.Controls.Add(this.BtnCancel);
			this.Controls.Add(this.MainProgressBar);
			this.Font = new System.Drawing.Font("メイリオ", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "BusyDlg";
			this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "処理中...";
			this.Load += new System.EventHandler(this.BusyDlg_Load);
			this.Shown += new System.EventHandler(this.BusyDlg_Shown);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ProgressBar MainProgressBar;
		private System.Windows.Forms.Button BtnCancel;
		private System.Windows.Forms.Label LabelMessage;
	}
}

//
// <<< Processed by SolutionConv
//