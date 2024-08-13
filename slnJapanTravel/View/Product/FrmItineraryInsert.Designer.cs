namespace slnJapanTravel.View
{
    partial class FrmItineraryInsert
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmItineraryInsert));
            this.panel1 = new System.Windows.Forms.Panel();
            this.InsertdateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.picbItinerary = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnActivitySearch = new System.Windows.Forms.Button();
            this.ActivitydataGridView = new System.Windows.Forms.DataGridView();
            this.txtActivitySearch = new System.Windows.Forms.TextBox();
            this.cbAreaInsert = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtItineraryPrice = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtItinerarySpace = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtItineraryId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtItineraryName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblProduct = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.btnCancelMain = new System.Windows.Forms.Button();
            this.btnInsertMain = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picbItinerary)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ActivitydataGridView)).BeginInit();
            this.panel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.InsertdateTimePicker);
            this.panel1.Controls.Add(this.picbItinerary);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.cbAreaInsert);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txtItineraryPrice);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txtItinerarySpace);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtItineraryId);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtItineraryName);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 26);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1196, 732);
            this.panel1.TabIndex = 14;
            // 
            // InsertdateTimePicker
            // 
            this.InsertdateTimePicker.CalendarFont = new System.Drawing.Font("Meiryo UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InsertdateTimePicker.Font = new System.Drawing.Font("Meiryo UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InsertdateTimePicker.Location = new System.Drawing.Point(946, 53);
            this.InsertdateTimePicker.Name = "InsertdateTimePicker";
            this.InsertdateTimePicker.Size = new System.Drawing.Size(200, 27);
            this.InsertdateTimePicker.TabIndex = 31;
            this.InsertdateTimePicker.ValueChanged += new System.EventHandler(this.InsertdateTimePicker_ValueChanged);
            // 
            // picbItinerary
            // 
            this.picbItinerary.BackColor = System.Drawing.SystemColors.Window;
            this.picbItinerary.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picbItinerary.BackgroundImage")));
            this.picbItinerary.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.picbItinerary.Location = new System.Drawing.Point(454, 136);
            this.picbItinerary.Name = "picbItinerary";
            this.picbItinerary.Size = new System.Drawing.Size(331, 340);
            this.picbItinerary.TabIndex = 30;
            this.picbItinerary.TabStop = false;
            this.picbItinerary.DoubleClick += new System.EventHandler(this.picbItinerary_DoubleClick);
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(23, 524);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1152, 195);
            this.panel2.TabIndex = 29;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Meiryo UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(18, 501);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 20);
            this.label7.TabIndex = 28;
            this.label7.Text = "出團備註";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Meiryo UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(450, 95);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(56, 20);
            this.label9.TabIndex = 27;
            this.label9.Text = "圖   片";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnActivitySearch);
            this.panel3.Controls.Add(this.ActivitydataGridView);
            this.panel3.Controls.Add(this.txtActivitySearch);
            this.panel3.Location = new System.Drawing.Point(40, 136);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(364, 340);
            this.panel3.TabIndex = 26;
            // 
            // btnActivitySearch
            // 
            this.btnActivitySearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnActivitySearch.AutoSize = true;
            this.btnActivitySearch.Font = new System.Drawing.Font("Meiryo UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActivitySearch.Location = new System.Drawing.Point(304, 12);
            this.btnActivitySearch.Name = "btnActivitySearch";
            this.btnActivitySearch.Size = new System.Drawing.Size(46, 25);
            this.btnActivitySearch.TabIndex = 25;
            this.btnActivitySearch.Text = "搜尋";
            this.btnActivitySearch.UseVisualStyleBackColor = true;
            this.btnActivitySearch.Click += new System.EventHandler(this.btnActivitySearch_Click);
            // 
            // ActivitydataGridView
            // 
            this.ActivitydataGridView.BackgroundColor = System.Drawing.SystemColors.Window;
            this.ActivitydataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ActivitydataGridView.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ActivitydataGridView.Location = new System.Drawing.Point(0, 63);
            this.ActivitydataGridView.Name = "ActivitydataGridView";
            this.ActivitydataGridView.RowTemplate.Height = 24;
            this.ActivitydataGridView.Size = new System.Drawing.Size(364, 277);
            this.ActivitydataGridView.TabIndex = 1;
            this.ActivitydataGridView.DoubleClick += new System.EventHandler(this.ActivitydataGridView_DoubleClick);
            // 
            // txtActivitySearch
            // 
            this.txtActivitySearch.Location = new System.Drawing.Point(15, 15);
            this.txtActivitySearch.Name = "txtActivitySearch";
            this.txtActivitySearch.Size = new System.Drawing.Size(252, 22);
            this.txtActivitySearch.TabIndex = 0;
            // 
            // cbAreaInsert
            // 
            this.cbAreaInsert.FormattingEnabled = true;
            this.cbAreaInsert.Location = new System.Drawing.Point(444, 13);
            this.cbAreaInsert.Name = "cbAreaInsert";
            this.cbAreaInsert.Size = new System.Drawing.Size(183, 20);
            this.cbAreaInsert.TabIndex = 25;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Meiryo UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(36, 95);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 20);
            this.label6.TabIndex = 11;
            this.label6.Text = "體   驗";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Meiryo UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(383, 13);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 20);
            this.label5.TabIndex = 11;
            this.label5.Text = "地   區";
            // 
            // txtItineraryPrice
            // 
            this.txtItineraryPrice.Font = new System.Drawing.Font("Meiryo UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtItineraryPrice.Location = new System.Drawing.Point(591, 51);
            this.txtItineraryPrice.Name = "txtItineraryPrice";
            this.txtItineraryPrice.Size = new System.Drawing.Size(229, 27);
            this.txtItineraryPrice.TabIndex = 10;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Meiryo UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(529, 53);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(56, 20);
            this.label10.TabIndex = 9;
            this.label10.Text = "價   格";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Meiryo UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(867, 58);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "出發時間";
            // 
            // txtItinerarySpace
            // 
            this.txtItinerarySpace.Font = new System.Drawing.Font("Meiryo UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtItinerarySpace.Location = new System.Drawing.Point(743, 10);
            this.txtItinerarySpace.Name = "txtItinerarySpace";
            this.txtItinerarySpace.Size = new System.Drawing.Size(197, 27);
            this.txtItinerarySpace.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Meiryo UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(682, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "總團位";
            // 
            // txtItineraryId
            // 
            this.txtItineraryId.Font = new System.Drawing.Font("Meiryo UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtItineraryId.Location = new System.Drawing.Point(97, 12);
            this.txtItineraryId.Name = "txtItineraryId";
            this.txtItineraryId.Size = new System.Drawing.Size(220, 27);
            this.txtItineraryId.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Meiryo UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(18, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "行程編號";
            // 
            // txtItineraryName
            // 
            this.txtItineraryName.Font = new System.Drawing.Font("Meiryo UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtItineraryName.Location = new System.Drawing.Point(97, 51);
            this.txtItineraryName.Name = "txtItineraryName";
            this.txtItineraryName.Size = new System.Drawing.Size(400, 27);
            this.txtItineraryName.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Meiryo UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(18, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "行程名稱";
            // 
            // lblProduct
            // 
            this.lblProduct.BackColor = System.Drawing.Color.PapayaWhip;
            this.lblProduct.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblProduct.Font = new System.Drawing.Font("Meiryo UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProduct.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblProduct.Location = new System.Drawing.Point(0, 0);
            this.lblProduct.Name = "lblProduct";
            this.lblProduct.Size = new System.Drawing.Size(1196, 26);
            this.lblProduct.TabIndex = 13;
            this.lblProduct.Text = "新增行程";
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.btnCancelMain);
            this.panel6.Controls.Add(this.btnInsertMain);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel6.Location = new System.Drawing.Point(0, 760);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(1196, 35);
            this.panel6.TabIndex = 24;
            // 
            // btnCancelMain
            // 
            this.btnCancelMain.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelMain.AutoSize = true;
            this.btnCancelMain.Font = new System.Drawing.Font("Meiryo UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelMain.Location = new System.Drawing.Point(1122, 4);
            this.btnCancelMain.Name = "btnCancelMain";
            this.btnCancelMain.Size = new System.Drawing.Size(62, 28);
            this.btnCancelMain.TabIndex = 24;
            this.btnCancelMain.Text = "取消";
            this.btnCancelMain.UseVisualStyleBackColor = true;
            this.btnCancelMain.Click += new System.EventHandler(this.btnCancelMain_Click);
            // 
            // btnInsertMain
            // 
            this.btnInsertMain.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnInsertMain.AutoSize = true;
            this.btnInsertMain.Font = new System.Drawing.Font("Meiryo UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInsertMain.Location = new System.Drawing.Point(1054, 4);
            this.btnInsertMain.Name = "btnInsertMain";
            this.btnInsertMain.Size = new System.Drawing.Size(62, 28);
            this.btnInsertMain.TabIndex = 25;
            this.btnInsertMain.Text = "確定";
            this.btnInsertMain.UseVisualStyleBackColor = true;
            this.btnInsertMain.Click += new System.EventHandler(this.btnInsertMain_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // FrmItineraryInsert
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1196, 795);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblProduct);
            this.Name = "FrmItineraryInsert";
            this.Text = "FrmItineraryInsert";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmItineraryInsert_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picbItinerary)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ActivitydataGridView)).EndInit();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtItinerarySpace;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtItineraryId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtItineraryName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblProduct;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbAreaInsert;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView ActivitydataGridView;
        private System.Windows.Forms.TextBox txtActivitySearch;
        private System.Windows.Forms.Button btnActivitySearch;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button btnCancelMain;
        private System.Windows.Forms.Button btnInsertMain;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtItineraryPrice;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox picbItinerary;
        private System.Windows.Forms.DateTimePicker InsertdateTimePicker;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}