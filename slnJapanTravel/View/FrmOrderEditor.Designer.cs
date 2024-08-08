namespace slnJapanTravel.View
{
    partial class FrmOrderEditor
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.fieldBox6 = new prjCustomerSystem.FieldBox();
            this.fieldBox4 = new prjCustomerSystem.FieldBox();
            this.fieldBox5 = new prjCustomerSystem.FieldBox();
            this.fieldBox3 = new prjCustomerSystem.FieldBox();
            this.fieldBox2 = new prjCustomerSystem.FieldBox();
            this.fieldBox1 = new prjCustomerSystem.FieldBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button1.Location = new System.Drawing.Point(455, 381);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(141, 44);
            this.button1.TabIndex = 1;
            this.button1.Text = "新增";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button2.Location = new System.Drawing.Point(278, 381);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(141, 44);
            this.button2.TabIndex = 1;
            this.button2.Text = "取消";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // fieldBox6
            // 
            this.fieldBox6.fieldName = "　總金額";
            this.fieldBox6.fieldValue = "";
            this.fieldBox6.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.fieldBox6.Location = new System.Drawing.Point(107, 321);
            this.fieldBox6.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.fieldBox6.Name = "fieldBox6";
            this.fieldBox6.Size = new System.Drawing.Size(399, 29);
            this.fieldBox6.TabIndex = 0;
            // 
            // fieldBox4
            // 
            this.fieldBox4.fieldName = "訂單狀態";
            this.fieldBox4.fieldValue = "";
            this.fieldBox4.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.fieldBox4.Location = new System.Drawing.Point(107, 217);
            this.fieldBox4.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.fieldBox4.Name = "fieldBox4";
            this.fieldBox4.Size = new System.Drawing.Size(399, 29);
            this.fieldBox4.TabIndex = 0;
            // 
            // fieldBox5
            // 
            this.fieldBox5.fieldName = "　優惠券";
            this.fieldBox5.fieldValue = "";
            this.fieldBox5.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.fieldBox5.Location = new System.Drawing.Point(107, 269);
            this.fieldBox5.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.fieldBox5.Name = "fieldBox5";
            this.fieldBox5.Size = new System.Drawing.Size(399, 29);
            this.fieldBox5.TabIndex = 0;
            // 
            // fieldBox3
            // 
            this.fieldBox3.fieldName = "付款狀態";
            this.fieldBox3.fieldValue = "";
            this.fieldBox3.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.fieldBox3.Location = new System.Drawing.Point(107, 165);
            this.fieldBox3.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.fieldBox3.Name = "fieldBox3";
            this.fieldBox3.Size = new System.Drawing.Size(399, 29);
            this.fieldBox3.TabIndex = 0;
            // 
            // fieldBox2
            // 
            this.fieldBox2.fieldName = "付款方式";
            this.fieldBox2.fieldValue = "";
            this.fieldBox2.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.fieldBox2.Location = new System.Drawing.Point(107, 113);
            this.fieldBox2.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.fieldBox2.Name = "fieldBox2";
            this.fieldBox2.Size = new System.Drawing.Size(399, 29);
            this.fieldBox2.TabIndex = 0;
            // 
            // fieldBox1
            // 
            this.fieldBox1.fieldName = "會員名稱";
            this.fieldBox1.fieldValue = "";
            this.fieldBox1.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.fieldBox1.Location = new System.Drawing.Point(107, 61);
            this.fieldBox1.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.fieldBox1.Name = "fieldBox1";
            this.fieldBox1.Size = new System.Drawing.Size(399, 29);
            this.fieldBox1.TabIndex = 0;
            // 
            // FrmOrderEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(633, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.fieldBox6);
            this.Controls.Add(this.fieldBox4);
            this.Controls.Add(this.fieldBox5);
            this.Controls.Add(this.fieldBox3);
            this.Controls.Add(this.fieldBox2);
            this.Controls.Add(this.fieldBox1);
            this.Name = "FrmOrderEditor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmOrderEditor";
            this.ResumeLayout(false);

        }

        #endregion

        private prjCustomerSystem.FieldBox fieldBox1;
        private prjCustomerSystem.FieldBox fieldBox2;
        private prjCustomerSystem.FieldBox fieldBox3;
        private prjCustomerSystem.FieldBox fieldBox4;
        private prjCustomerSystem.FieldBox fieldBox5;
        private prjCustomerSystem.FieldBox fieldBox6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}