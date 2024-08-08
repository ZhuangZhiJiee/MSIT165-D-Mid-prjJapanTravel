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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnSpotSearch = new System.Windows.Forms.Button();
            this.SpotdataGridView = new System.Windows.Forms.DataGridView();
            this.txtSpotSearch = new System.Windows.Forms.TextBox();
            this.cbAreaInsert = new System.Windows.Forms.ComboBox();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtItineraryPrice = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtItinerarySpace = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtItineraryId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtItineraryName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.DetaildataGridView = new System.Windows.Forms.DataGridView();
            this.lblProduct = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.btnCancelMain = new System.Windows.Forms.Button();
            this.btnInsertMain = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btnSpotSearchDetail = new System.Windows.Forms.Button();
            this.SpotDetaildataGridView = new System.Windows.Forms.DataGridView();
            this.txtSpotDetailSearch = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnHotelSearchDetail = new System.Windows.Forms.Button();
            this.HoteldataGridView = new System.Windows.Forms.DataGridView();
            this.txtHotelSearch = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnPushDetail = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SpotdataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DetaildataGridView)).BeginInit();
            this.panel6.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SpotDetaildataGridView)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.HoteldataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.cbAreaInsert);
            this.panel1.Controls.Add(this.monthCalendar1);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txtItineraryPrice);
            this.panel1.Controls.Add(this.textBox4);
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
            this.panel1.Size = new System.Drawing.Size(1196, 507);
            this.panel1.TabIndex = 14;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Meiryo UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(36, 277);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(56, 20);
            this.label9.TabIndex = 27;
            this.label9.Text = "圖   片";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnSpotSearch);
            this.panel3.Controls.Add(this.SpotdataGridView);
            this.panel3.Controls.Add(this.txtSpotSearch);
            this.panel3.Location = new System.Drawing.Point(97, 95);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(364, 140);
            this.panel3.TabIndex = 26;
            // 
            // btnSpotSearch
            // 
            this.btnSpotSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSpotSearch.AutoSize = true;
            this.btnSpotSearch.Font = new System.Drawing.Font("Meiryo UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSpotSearch.Location = new System.Drawing.Point(296, 11);
            this.btnSpotSearch.Name = "btnSpotSearch";
            this.btnSpotSearch.Size = new System.Drawing.Size(46, 25);
            this.btnSpotSearch.TabIndex = 25;
            this.btnSpotSearch.Text = "搜尋";
            this.btnSpotSearch.UseVisualStyleBackColor = true;
            this.btnSpotSearch.Click += new System.EventHandler(this.btnSpotSearch_Click);
            // 
            // SpotdataGridView
            // 
            this.SpotdataGridView.BackgroundColor = System.Drawing.SystemColors.Window;
            this.SpotdataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SpotdataGridView.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.SpotdataGridView.Location = new System.Drawing.Point(0, 39);
            this.SpotdataGridView.Name = "SpotdataGridView";
            this.SpotdataGridView.RowTemplate.Height = 24;
            this.SpotdataGridView.Size = new System.Drawing.Size(364, 101);
            this.SpotdataGridView.TabIndex = 1;
            this.SpotdataGridView.DoubleClick += new System.EventHandler(this.SpotdataGridView_DoubleClick);
            // 
            // txtSpotSearch
            // 
            this.txtSpotSearch.Location = new System.Drawing.Point(7, 11);
            this.txtSpotSearch.Name = "txtSpotSearch";
            this.txtSpotSearch.Size = new System.Drawing.Size(252, 22);
            this.txtSpotSearch.TabIndex = 0;
            // 
            // cbAreaInsert
            // 
            this.cbAreaInsert.FormattingEnabled = true;
            this.cbAreaInsert.Location = new System.Drawing.Point(444, 13);
            this.cbAreaInsert.Name = "cbAreaInsert";
            this.cbAreaInsert.Size = new System.Drawing.Size(183, 20);
            this.cbAreaInsert.TabIndex = 25;
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(935, 46);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Meiryo UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(36, 95);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 20);
            this.label6.TabIndex = 11;
            this.label6.Text = "景   點";
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
            this.txtItineraryPrice.Location = new System.Drawing.Point(926, 236);
            this.txtItineraryPrice.Name = "txtItineraryPrice";
            this.txtItineraryPrice.Size = new System.Drawing.Size(229, 27);
            this.txtItineraryPrice.TabIndex = 10;
            // 
            // textBox4
            // 
            this.textBox4.Font = new System.Drawing.Font("Meiryo UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox4.Location = new System.Drawing.Point(926, 13);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(229, 27);
            this.textBox4.TabIndex = 10;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Meiryo UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(864, 238);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(56, 20);
            this.label10.TabIndex = 9;
            this.label10.Text = "價   格";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Meiryo UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(847, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "出發時間";
            // 
            // txtItinerarySpace
            // 
            this.txtItinerarySpace.Font = new System.Drawing.Font("Meiryo UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtItinerarySpace.Location = new System.Drawing.Point(609, 53);
            this.txtItinerarySpace.Name = "txtItinerarySpace";
            this.txtItinerarySpace.Size = new System.Drawing.Size(197, 27);
            this.txtItinerarySpace.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Meiryo UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(548, 55);
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
            // DetaildataGridView
            // 
            this.DetaildataGridView.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.DetaildataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DetaildataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DetaildataGridView.Location = new System.Drawing.Point(0, 26);
            this.DetaildataGridView.Name = "DetaildataGridView";
            this.DetaildataGridView.RowTemplate.Height = 24;
            this.DetaildataGridView.Size = new System.Drawing.Size(1196, 769);
            this.DetaildataGridView.TabIndex = 15;
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
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.NavajoWhite;
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.btnPushDetail);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Font = new System.Drawing.Font("Meiryo UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.Location = new System.Drawing.Point(0, 533);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(688, 227);
            this.panel2.TabIndex = 25;
            // 
            // panel5
            // 
            this.panel5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel5.Controls.Add(this.btnSpotSearchDetail);
            this.panel5.Controls.Add(this.SpotDetaildataGridView);
            this.panel5.Controls.Add(this.txtSpotDetailSearch);
            this.panel5.Location = new System.Drawing.Point(437, 52);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(234, 113);
            this.panel5.TabIndex = 31;
            // 
            // btnSpotSearchDetail
            // 
            this.btnSpotSearchDetail.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSpotSearchDetail.AutoSize = true;
            this.btnSpotSearchDetail.Font = new System.Drawing.Font("Meiryo UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSpotSearchDetail.Location = new System.Drawing.Point(174, 11);
            this.btnSpotSearchDetail.Name = "btnSpotSearchDetail";
            this.btnSpotSearchDetail.Size = new System.Drawing.Size(46, 25);
            this.btnSpotSearchDetail.TabIndex = 25;
            this.btnSpotSearchDetail.Text = "搜尋";
            this.btnSpotSearchDetail.UseVisualStyleBackColor = true;
            this.btnSpotSearchDetail.Click += new System.EventHandler(this.btnSpotSearchDetail_Click);
            // 
            // SpotDetaildataGridView
            // 
            this.SpotDetaildataGridView.BackgroundColor = System.Drawing.SystemColors.Window;
            this.SpotDetaildataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SpotDetaildataGridView.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.SpotDetaildataGridView.Location = new System.Drawing.Point(0, 42);
            this.SpotDetaildataGridView.Name = "SpotDetaildataGridView";
            this.SpotDetaildataGridView.RowTemplate.Height = 24;
            this.SpotDetaildataGridView.Size = new System.Drawing.Size(234, 71);
            this.SpotDetaildataGridView.TabIndex = 1;
            this.SpotDetaildataGridView.DoubleClick += new System.EventHandler(this.SpotDetaildataGridView_DoubleClick);
            // 
            // txtSpotDetailSearch
            // 
            this.txtSpotDetailSearch.Location = new System.Drawing.Point(7, 11);
            this.txtSpotDetailSearch.Name = "txtSpotDetailSearch";
            this.txtSpotDetailSearch.Size = new System.Drawing.Size(161, 27);
            this.txtSpotDetailSearch.TabIndex = 0;
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Meiryo UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(433, 29);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(41, 20);
            this.label8.TabIndex = 30;
            this.label8.Text = "景點";
            // 
            // panel4
            // 
            this.panel4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel4.Controls.Add(this.btnHotelSearchDetail);
            this.panel4.Controls.Add(this.HoteldataGridView);
            this.panel4.Controls.Add(this.txtHotelSearch);
            this.panel4.Location = new System.Drawing.Point(179, 52);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(220, 113);
            this.panel4.TabIndex = 29;
            // 
            // btnHotelSearchDetail
            // 
            this.btnHotelSearchDetail.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnHotelSearchDetail.AutoSize = true;
            this.btnHotelSearchDetail.Font = new System.Drawing.Font("Meiryo UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHotelSearchDetail.Location = new System.Drawing.Point(165, 10);
            this.btnHotelSearchDetail.Name = "btnHotelSearchDetail";
            this.btnHotelSearchDetail.Size = new System.Drawing.Size(46, 25);
            this.btnHotelSearchDetail.TabIndex = 25;
            this.btnHotelSearchDetail.Text = "搜尋";
            this.btnHotelSearchDetail.UseVisualStyleBackColor = true;
            this.btnHotelSearchDetail.Click += new System.EventHandler(this.btnHotelSearchDetail_Click_1);
            // 
            // HoteldataGridView
            // 
            this.HoteldataGridView.BackgroundColor = System.Drawing.SystemColors.Window;
            this.HoteldataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.HoteldataGridView.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.HoteldataGridView.Location = new System.Drawing.Point(0, 42);
            this.HoteldataGridView.Name = "HoteldataGridView";
            this.HoteldataGridView.RowTemplate.Height = 24;
            this.HoteldataGridView.Size = new System.Drawing.Size(220, 71);
            this.HoteldataGridView.TabIndex = 1;
            this.HoteldataGridView.DoubleClick += new System.EventHandler(this.HoteldataGridView_DoubleClick_1);
            // 
            // txtHotelSearch
            // 
            this.txtHotelSearch.Location = new System.Drawing.Point(7, 11);
            this.txtHotelSearch.Name = "txtHotelSearch";
            this.txtHotelSearch.Size = new System.Drawing.Size(152, 27);
            this.txtHotelSearch.TabIndex = 0;
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Meiryo UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(184, 29);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 20);
            this.label7.TabIndex = 28;
            this.label7.Text = "飯店";
            // 
            // btnPushDetail
            // 
            this.btnPushDetail.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnPushDetail.AutoSize = true;
            this.btnPushDetail.Font = new System.Drawing.Font("Meiryo UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPushDetail.Location = new System.Drawing.Point(609, 193);
            this.btnPushDetail.Name = "btnPushDetail";
            this.btnPushDetail.Size = new System.Drawing.Size(62, 28);
            this.btnPushDetail.TabIndex = 24;
            this.btnPushDetail.Text = "加入";
            this.btnPushDetail.UseVisualStyleBackColor = true;
            // 
            // FrmItineraryInsert
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1196, 795);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.DetaildataGridView);
            this.Controls.Add(this.lblProduct);
            this.Name = "FrmItineraryInsert";
            this.Text = "FrmItineraryInsert";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmItineraryInsert_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SpotdataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DetaildataGridView)).EndInit();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SpotDetaildataGridView)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.HoteldataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtItinerarySpace;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtItineraryId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtItineraryName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView DetaildataGridView;
        private System.Windows.Forms.Label lblProduct;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbAreaInsert;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView SpotdataGridView;
        private System.Windows.Forms.TextBox txtSpotSearch;
        private System.Windows.Forms.Button btnSpotSearch;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button btnCancelMain;
        private System.Windows.Forms.Button btnInsertMain;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button btnSpotSearchDetail;
        private System.Windows.Forms.DataGridView SpotDetaildataGridView;
        private System.Windows.Forms.TextBox txtSpotDetailSearch;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnHotelSearchDetail;
        private System.Windows.Forms.DataGridView HoteldataGridView;
        private System.Windows.Forms.TextBox txtHotelSearch;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnPushDetail;
        private System.Windows.Forms.TextBox txtItineraryPrice;
        private System.Windows.Forms.Label label10;
    }
}