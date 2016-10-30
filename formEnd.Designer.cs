namespace helloworld
{
    partial class formEnd
    {
        /// <summary>
        /// 必要なデザイナ変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースが破棄される場合 true、破棄されない場合は false です。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナで生成されたコード

        /// <summary>
        /// デザイナ サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディタで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
			this.totalAmountLabel = new System.Windows.Forms.Label();
			this.moneyLabel = new System.Windows.Forms.Label();
			this.changeLabel = new System.Windows.Forms.Label();
			this.thanksTextLabel = new System.Windows.Forms.Label();
			this.changeTextLabel = new System.Windows.Forms.Label();
			this.moneyTextLabel = new System.Windows.Forms.Label();
			this.totalAmountTextLabel = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// totalAmountLabel
			// 
			this.totalAmountLabel.AutoSize = true;
			this.totalAmountLabel.Location = new System.Drawing.Point(1074, 125);
			this.totalAmountLabel.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
			this.totalAmountLabel.Name = "totalAmountLabel";
			this.totalAmountLabel.Size = new System.Drawing.Size(35, 15);
			this.totalAmountLabel.TabIndex = 2;
			this.totalAmountLabel.Text = "total";
			// 
			// moneyLabel
			// 
			this.moneyLabel.AutoSize = true;
			this.moneyLabel.Location = new System.Drawing.Point(1074, 192);
			this.moneyLabel.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
			this.moneyLabel.Name = "moneyLabel";
			this.moneyLabel.Size = new System.Drawing.Size(49, 15);
			this.moneyLabel.TabIndex = 3;
			this.moneyLabel.Text = "money";
			// 
			// changeLabel
			// 
			this.changeLabel.AutoSize = true;
			this.changeLabel.Location = new System.Drawing.Point(1074, 288);
			this.changeLabel.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
			this.changeLabel.Name = "changeLabel";
			this.changeLabel.Size = new System.Drawing.Size(53, 15);
			this.changeLabel.TabIndex = 4;
			this.changeLabel.Text = "change";
			// 
			// thanksTextLabel
			// 
			this.thanksTextLabel.AutoSize = true;
			this.thanksTextLabel.Location = new System.Drawing.Point(570, 398);
			this.thanksTextLabel.Name = "thanksTextLabel";
			this.thanksTextLabel.Size = new System.Drawing.Size(170, 15);
			this.thanksTextLabel.TabIndex = 5;
			this.thanksTextLabel.Text = "ご購入ありがとうございました";
			// 
			// changeTextLabel
			// 
			this.changeTextLabel.AutoSize = true;
			this.changeTextLabel.Location = new System.Drawing.Point(570, 288);
			this.changeTextLabel.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
			this.changeTextLabel.Name = "changeTextLabel";
			this.changeTextLabel.Size = new System.Drawing.Size(40, 15);
			this.changeTextLabel.TabIndex = 8;
			this.changeTextLabel.Text = "おつり";
			// 
			// moneyTextLabel
			// 
			this.moneyTextLabel.AutoSize = true;
			this.moneyTextLabel.Location = new System.Drawing.Point(570, 192);
			this.moneyTextLabel.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
			this.moneyTextLabel.Name = "moneyTextLabel";
			this.moneyTextLabel.Size = new System.Drawing.Size(67, 15);
			this.moneyTextLabel.TabIndex = 7;
			this.moneyTextLabel.Text = "投入金額";
			// 
			// totalAmountTextLabel
			// 
			this.totalAmountTextLabel.AutoSize = true;
			this.totalAmountTextLabel.Location = new System.Drawing.Point(570, 125);
			this.totalAmountTextLabel.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
			this.totalAmountTextLabel.Name = "totalAmountTextLabel";
			this.totalAmountTextLabel.Size = new System.Drawing.Size(37, 15);
			this.totalAmountTextLabel.TabIndex = 6;
			this.totalAmountTextLabel.Text = "合計";
			// 
			// formEnd
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
			this.ClientSize = new System.Drawing.Size(1344, 912);
			this.Controls.Add(this.changeTextLabel);
			this.Controls.Add(this.moneyTextLabel);
			this.Controls.Add(this.totalAmountTextLabel);
			this.Controls.Add(this.thanksTextLabel);
			this.Controls.Add(this.changeLabel);
			this.Controls.Add(this.moneyLabel);
			this.Controls.Add(this.totalAmountLabel);
			this.Margin = new System.Windows.Forms.Padding(12, 10, 12, 10);
			this.Name = "formEnd";
			this.Text = "購入結果";
			this.Load += new System.EventHandler(this.formEnd_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

        #endregion
		private System.Windows.Forms.Label totalAmountLabel;
		private System.Windows.Forms.Label moneyLabel;
		private System.Windows.Forms.Label changeLabel;
		private System.Windows.Forms.Label thanksTextLabel;
		private System.Windows.Forms.Label changeTextLabel;
		private System.Windows.Forms.Label moneyTextLabel;
		private System.Windows.Forms.Label totalAmountTextLabel;
	}
}
