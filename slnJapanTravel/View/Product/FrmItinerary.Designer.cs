namespace slnJapanTravel.View
{
    partial class FrmItinerary
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmItinerary));
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnInsert = new System.Windows.Forms.Button();
            this.lblProduct = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.cbAreaInsert = new System.Windows.Forms.ComboBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtItineraryId = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnMainSearch = new System.Windows.Forms.Button();
            this.btnMainUpdate = new System.Windows.Forms.Button();
            this.btnMainDelete = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnInsert);
            this.panel2.Controls.Add(this.lblProduct);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1165, 30);
            this.panel2.TabIndex = 13;
            // 
            // btnInsert
            // 
            this.btnInsert.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnInsert.Font = new System.Drawing.Font("Meiryo UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInsert.Location = new System.Drawing.Point(1077, 1);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(85, 27);
            this.btnInsert.TabIndex = 16;
            this.btnInsert.Text = "新增行程";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // lblProduct
            // 
            this.lblProduct.BackColor = System.Drawing.Color.MintCream;
            this.lblProduct.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblProduct.Font = new System.Drawing.Font("Meiryo UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProduct.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblProduct.Location = new System.Drawing.Point(0, 0);
            this.lblProduct.Name = "lblProduct";
            this.lblProduct.Size = new System.Drawing.Size(1165, 30);
            this.lblProduct.TabIndex = 17;
            this.lblProduct.Text = "行程管理";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.monthCalendar1);
            this.panel3.Controls.Add(this.cbAreaInsert);
            this.panel3.Controls.Add(this.textBox7);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.txtItineraryId);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Controls.Add(this.textBox10);
            this.panel3.Controls.Add(this.label10);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 30);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1165, 191);
            this.panel3.TabIndex = 14;
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(838, 22);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 27;
            // 
            // cbAreaInsert
            // 
            this.cbAreaInsert.FormattingEnabled = true;
            this.cbAreaInsert.Location = new System.Drawing.Point(428, 45);
            this.cbAreaInsert.Name = "cbAreaInsert";
            this.cbAreaInsert.Size = new System.Drawing.Size(183, 20);
            this.cbAreaInsert.TabIndex = 26;
            // 
            // textBox7
            // 
            this.textBox7.Font = new System.Drawing.Font("Meiryo UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox7.Location = new System.Drawing.Point(104, 141);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(229, 27);
            this.textBox7.TabIndex = 21;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Meiryo UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(753, 22);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 20);
            this.label6.TabIndex = 18;
            this.label6.Text = "出發時間";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Meiryo UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(54, 143);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 20);
            this.label7.TabIndex = 19;
            this.label7.Text = "主題";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Meiryo UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(369, 45);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(41, 20);
            this.label8.TabIndex = 16;
            this.label8.Text = "地區";
            // 
            // txtItineraryId
            // 
            this.txtItineraryId.Font = new System.Drawing.Font("Meiryo UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtItineraryId.Location = new System.Drawing.Point(101, 43);
            this.txtItineraryId.Name = "txtItineraryId";
            this.txtItineraryId.Size = new System.Drawing.Size(220, 27);
            this.txtItineraryId.TabIndex = 14;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Meiryo UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(22, 45);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(73, 20);
            this.label9.TabIndex = 12;
            this.label9.Text = "行程編號";
            // 
            // textBox10
            // 
            this.textBox10.Font = new System.Drawing.Font("Meiryo UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox10.Location = new System.Drawing.Point(101, 92);
            this.textBox10.Name = "textBox10";
            this.textBox10.Size = new System.Drawing.Size(588, 27);
            this.textBox10.TabIndex = 15;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Meiryo UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(22, 94);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(73, 20);
            this.label10.TabIndex = 13;
            this.label10.Text = "行程名稱";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 281);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1165, 501);
            this.panel1.TabIndex = 15;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1165, 501);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.Paint += new System.Windows.Forms.PaintEventHandler(this.dataGridView1_Paint);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btnMainSearch);
            this.panel4.Controls.Add(this.btnMainUpdate);
            this.panel4.Controls.Add(this.btnMainDelete);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(0, 219);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1165, 62);
            this.panel4.TabIndex = 16;
            // 
            // btnMainSearch
            // 
            this.btnMainSearch.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnMainSearch.Image = ((System.Drawing.Image)(resources.GetObject("btnMainSearch.Image")));
            this.btnMainSearch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMainSearch.Location = new System.Drawing.Point(158, 8);
            this.btnMainSearch.Name = "btnMainSearch";
            this.btnMainSearch.Size = new System.Drawing.Size(71, 37);
            this.btnMainSearch.TabIndex = 0;
            this.btnMainSearch.Text = "查詢";
            this.btnMainSearch.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnMainSearch.UseVisualStyleBackColor = true;
            // 
            // btnMainUpdate
            // 
            this.btnMainUpdate.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnMainUpdate.Image = ((System.Drawing.Image)(resources.GetObject("btnMainUpdate.Image")));
            this.btnMainUpdate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMainUpdate.Location = new System.Drawing.Point(81, 9);
            this.btnMainUpdate.Name = "btnMainUpdate";
            this.btnMainUpdate.Size = new System.Drawing.Size(71, 37);
            this.btnMainUpdate.TabIndex = 0;
            this.btnMainUpdate.Text = "修改";
            this.btnMainUpdate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnMainUpdate.UseVisualStyleBackColor = true;
            // 
            // btnMainDelete
            // 
            this.btnMainDelete.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnMainDelete.Image = ((System.Drawing.Image)(resources.GetObject("btnMainDelete.Image")));
            this.btnMainDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMainDelete.Location = new System.Drawing.Point(4, 8);
            this.btnMainDelete.Name = "btnMainDelete";
            this.btnMainDelete.Size = new System.Drawing.Size(71, 38);
            this.btnMainDelete.TabIndex = 0;
            this.btnMainDelete.Text = "刪除";
            this.btnMainDelete.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnMainDelete.UseVisualStyleBackColor = true;
            // 
            // FrmItinerary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1165, 782);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Name = "FrmItinerary";
            this.Text = "旅遊行程系統";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmItinerary_Load);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Label lblProduct;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtItineraryId;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBox10;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cbAreaInsert;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnMainSearch;
        private System.Windows.Forms.Button btnMainUpdate;
        private System.Windows.Forms.Button btnMainDelete;
    }
}