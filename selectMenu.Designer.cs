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
			this.label1 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("MS UI Gothic", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.label1.Location = new System.Drawing.Point(222, 102);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(100, 40);
			this.label1.TabIndex = 0;
			this.label1.Text = "label1";
			this.label1.Click += new System.EventHandler(this.label1_Click);
			// 
			// selectMenu
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
			this.ClientSize = new System.Drawing.Size(1344, 912);
			this.Controls.Add(this.label1);
			this.Margin = new System.Windows.Forms.Padding(5);
			this.Name = "selectMenu";
			this.Text = "購入したい食券を選択してください";
			this.Load += new System.EventHandler(this.selectMenu_Load);
			this.ResumeLayout(false);

        }

		#endregion

		private System.Windows.Forms.Label label1;
	}
}
