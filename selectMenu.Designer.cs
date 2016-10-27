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
            this.comfirm = new System.Windows.Forms.Button();
            this.availableMoneyLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // comfirm
            // 
            this.comfirm.Location = new System.Drawing.Point(742, 591);
            this.comfirm.Margin = new System.Windows.Forms.Padding(2);
            this.comfirm.Name = "comfirm";
            this.comfirm.Size = new System.Drawing.Size(194, 103);
            this.comfirm.TabIndex = 1;
            this.comfirm.Text = "button2";
            this.comfirm.UseVisualStyleBackColor = true;
            this.comfirm.Click += new System.EventHandler(this.button2_Click);
            // 
            // availableMoneyLabel
            // 
            this.availableMoneyLabel.Font = new System.Drawing.Font("MS UI Gothic", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.availableMoneyLabel.Location = new System.Drawing.Point(806, 525);
            this.availableMoneyLabel.Name = "availableMoneyLabel";
            this.availableMoneyLabel.Size = new System.Drawing.Size(100, 30);
            this.availableMoneyLabel.TabIndex = 2;
            this.availableMoneyLabel.Text = "label1";
            // 
            // selectMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.ClientSize = new System.Drawing.Size(1008, 730);
            this.Controls.Add(this.availableMoneyLabel);
            this.Controls.Add(this.comfirm);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "selectMenu";
            this.Text = "購入したい食券を選択してください"; 
            this.Load += new System.EventHandler(this.selectMenu_Load);
            this.ResumeLayout(false);

        }

		#endregion

        private System.Windows.Forms.Button comfirm;
        private System.Windows.Forms.Label availableMoneyLabel;
	}
}
