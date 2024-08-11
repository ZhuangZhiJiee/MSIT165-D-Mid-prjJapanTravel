namespace slnJapanTravel.Component
{
    partial class itineraryBox
    {
        /// <summary> 
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 元件設計工具產生的程式碼

        /// <summary> 
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(15, 10);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(290, 290);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(342, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(505, 132);
            this.label1.TabIndex = 1;
            this.label1.Text = "行程名稱";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("微軟正黑體", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(344, 185);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(505, 106);
            this.label2.TabIndex = 1;
            this.label2.Text = "出團備註";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(873, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(211, 30);
            this.label3.TabIndex = 2;
            this.label3.Text = "可預約人數 / Num";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.Location = new System.Drawing.Point(873, 78);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(163, 30);
            this.label4.TabIndex = 2;
            this.label4.Text = "總團位 / Num";
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("微軟正黑體", 26F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(867, 188);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(272, 103);
            this.label5.TabIndex = 3;
            this.label5.Text = "金額";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // itineraryBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "itineraryBox";
            this.Size = new System.Drawing.Size(1160, 310);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}
