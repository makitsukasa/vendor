namespace helloworld
{
    partial class selectMenu
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
			this.comfirmButton = new System.Windows.Forms.Button();
			this.totalAmountLabel = new System.Windows.Forms.Label();
			this.moneyLabel = new System.Windows.Forms.Label();
			this.cancelButton = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// comfirmButton
			// 
			this.comfirmButton.Font = new System.Drawing.Font("MS UI Gothic", 27F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.comfirmButton.Location = new System.Drawing.Point(972, 617);
			this.comfirmButton.Margin = new System.Windows.Forms.Padding(16, 2, 16, 2);
			this.comfirmButton.Name = "comfirmButton";
			this.comfirmButton.Size = new System.Drawing.Size(195, 76);
			this.comfirmButton.TabIndex = 1;
			this.comfirmButton.Text = "決定";
			this.comfirmButton.UseVisualStyleBackColor = true;
			this.comfirmButton.Click += new System.EventHandler(this.comfirmButton_Click);
			// 
			// totalAmountLabel
			// 
			this.totalAmountLabel.Font = new System.Drawing.Font("MS UI Gothic", 23F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.totalAmountLabel.Location = new System.Drawing.Point(600, 300);
			this.totalAmountLabel.Margin = new System.Windows.Forms.Padding(21, 0, 21, 0);
			this.totalAmountLabel.Name = "totalAmountLabel";
			this.totalAmountLabel.Size = new System.Drawing.Size(356, 56);
			this.totalAmountLabel.TabIndex = 2;
			this.totalAmountLabel.Text = "total";
			// 
			// moneyLabel
			// 
			this.moneyLabel.AutoSize = true;
			this.moneyLabel.Font = new System.Drawing.Font("MS UI Gothic", 23F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.moneyLabel.Location = new System.Drawing.Point(800, 500);
			this.moneyLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.moneyLabel.Name = "moneyLabel";
			this.moneyLabel.Size = new System.Drawing.Size(52, 39);
			this.moneyLabel.TabIndex = 3;
			this.moneyLabel.Text = "all";
			// 
			// cancelButton
			// 
			this.cancelButton.Font = new System.Drawing.Font("MS UI Gothic", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.cancelButton.Location = new System.Drawing.Point(1043, 775);
			this.cancelButton.Margin = new System.Windows.Forms.Padding(4);
			this.cancelButton.Name = "cancelButton";
			this.cancelButton.Size = new System.Drawing.Size(156, 62);
			this.cancelButton.TabIndex = 4;
			this.cancelButton.Text = "取消";
			this.cancelButton.UseVisualStyleBackColor = true;
			this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
			// 
			// selectMenu
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
			this.ClientSize = new System.Drawing.Size(1344, 912);
			this.Controls.Add(this.comfirmButton);
			this.Controls.Add(this.cancelButton);
			this.Controls.Add(this.moneyLabel);
			this.Controls.Add(this.totalAmountLabel);
			this.Margin = new System.Windows.Forms.Padding(28, 19, 28, 19);
			this.Name = "selectMenu";
			this.Text = "購入したい食券を選択してください";
			this.Load += new System.EventHandler(this.selectMenu_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

        private System.Windows.Forms.Button comfirmButton;
        private System.Windows.Forms.Label totalAmountLabel;
		private System.Windows.Forms.Label moneyLabel;
		private System.Windows.Forms.Button cancelButton;
	}
}
