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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmItineraryInsert));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnDEMO = new System.Windows.Forms.Button();
            this.PiclistView = new System.Windows.Forms.ListView();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.Picpanel = new System.Windows.Forms.Panel();
            this.txtPictureDescription = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtPictureName = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.picbItinerary = new System.Windows.Forms.PictureBox();
            this.btnDateDelete = new System.Windows.Forms.Button();
            this.btnDateAdd = new System.Windows.Forms.Button();
            this.DatelistBox = new System.Windows.Forms.ListBox();
            this.label9 = new System.Windows.Forms.Label();
            this.Actpanel = new System.Windows.Forms.Panel();
            this.btnActivitySearch = new System.Windows.Forms.Button();
            this.ActivitydataGridView = new System.Windows.Forms.DataGridView();
            this.txtActivitySearch = new System.Windows.Forms.TextBox();
            this.cbAreaInsert = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDateTimeInsert = new System.Windows.Forms.TextBox();
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
            this.Picpanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picbItinerary)).BeginInit();
            this.Actpanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ActivitydataGridView)).BeginInit();
            this.panel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnDEMO);
            this.panel1.Controls.Add(this.PiclistView);
            this.panel1.Controls.Add(this.Picpanel);
            this.panel1.Controls.Add(this.btnDateDelete);
            this.panel1.Controls.Add(this.btnDateAdd);
            this.panel1.Controls.Add(this.DatelistBox);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.Actpanel);
            this.panel1.Controls.Add(this.cbAreaInsert);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txtDateTimeInsert);
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
            // btnDEMO
            // 
            this.btnDEMO.Font = new System.Drawing.Font("Meiryo UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDEMO.Location = new System.Drawing.Point(1099, 12);
            this.btnDEMO.Name = "btnDEMO";
            this.btnDEMO.Size = new System.Drawing.Size(75, 33);
            this.btnDEMO.TabIndex = 38;
            this.btnDEMO.Text = "DEMO";
            this.btnDEMO.UseVisualStyleBackColor = true;
            this.btnDEMO.Click += new System.EventHandler(this.btnDEMO_Click);
            // 
            // PiclistView
            // 
            this.PiclistView.HideSelection = false;
            this.PiclistView.LargeImageList = this.imageList1;
            this.PiclistView.Location = new System.Drawing.Point(807, 104);
            this.PiclistView.Name = "PiclistView";
            this.PiclistView.Size = new System.Drawing.Size(367, 565);
            this.PiclistView.SmallImageList = this.imageList1;
            this.PiclistView.StateImageList = this.imageList1;
            this.PiclistView.TabIndex = 37;
            this.PiclistView.UseCompatibleStateImageBehavior = false;
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // Picpanel
            // 
            this.Picpanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Picpanel.Controls.Add(this.txtPictureDescription);
            this.Picpanel.Controls.Add(this.label11);
            this.Picpanel.Controls.Add(this.txtPictureName);
            this.Picpanel.Controls.Add(this.label8);
            this.Picpanel.Controls.Add(this.picbItinerary);
            this.Picpanel.Location = new System.Drawing.Point(387, 104);
            this.Picpanel.Name = "Picpanel";
            this.Picpanel.Size = new System.Drawing.Size(403, 565);
            this.Picpanel.TabIndex = 36;
            // 
            // txtPictureDescription
            // 
            this.txtPictureDescription.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPictureDescription.Font = new System.Drawing.Font("Meiryo UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPictureDescription.Location = new System.Drawing.Point(112, 112);
            this.txtPictureDescription.Name = "txtPictureDescription";
            this.txtPictureDescription.Size = new System.Drawing.Size(225, 20);
            this.txtPictureDescription.TabIndex = 39;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Meiryo UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(20, 111);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(56, 20);
            this.label11.TabIndex = 38;
            this.label11.Text = "描   述";
            // 
            // txtPictureName
            // 
            this.txtPictureName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPictureName.Font = new System.Drawing.Font("Meiryo UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPictureName.Location = new System.Drawing.Point(112, 52);
            this.txtPictureName.Name = "txtPictureName";
            this.txtPictureName.Size = new System.Drawing.Size(225, 20);
            this.txtPictureName.TabIndex = 37;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Meiryo UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(20, 51);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 20);
            this.label8.TabIndex = 36;
            this.label8.Text = "名   稱";
            // 
            // picbItinerary
            // 
            this.picbItinerary.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.picbItinerary.BackColor = System.Drawing.SystemColors.Window;
            this.picbItinerary.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picbItinerary.BackgroundImage")));
            this.picbItinerary.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.picbItinerary.Location = new System.Drawing.Point(13, 186);
            this.picbItinerary.Name = "picbItinerary";
            this.picbItinerary.Size = new System.Drawing.Size(375, 361);
            this.picbItinerary.TabIndex = 31;
            this.picbItinerary.TabStop = false;
            this.picbItinerary.DoubleClick += new System.EventHandler(this.picbItinerary_DoubleClick_1);
            // 
            // btnDateDelete
            // 
            this.btnDateDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDateDelete.AutoSize = true;
            this.btnDateDelete.Font = new System.Drawing.Font("Meiryo UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDateDelete.Location = new System.Drawing.Point(344, 418);
            this.btnDateDelete.Name = "btnDateDelete";
            this.btnDateDelete.Size = new System.Drawing.Size(26, 25);
            this.btnDateDelete.TabIndex = 25;
            this.btnDateDelete.Text = "-";
            this.btnDateDelete.UseVisualStyleBackColor = true;
            this.btnDateDelete.Click += new System.EventHandler(this.btnDateDelete_Click);
            // 
            // btnDateAdd
            // 
            this.btnDateAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDateAdd.AutoSize = true;
            this.btnDateAdd.Font = new System.Drawing.Font("Meiryo UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDateAdd.Location = new System.Drawing.Point(317, 418);
            this.btnDateAdd.Name = "btnDateAdd";
            this.btnDateAdd.Size = new System.Drawing.Size(26, 25);
            this.btnDateAdd.TabIndex = 25;
            this.btnDateAdd.Text = "+";
            this.btnDateAdd.UseVisualStyleBackColor = true;
            this.btnDateAdd.Click += new System.EventHandler(this.btnDateAdd_Click);
            // 
            // DatelistBox
            // 
            this.DatelistBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DatelistBox.Font = new System.Drawing.Font("Meiryo UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DatelistBox.FormattingEnabled = true;
            this.DatelistBox.ItemHeight = 17;
            this.DatelistBox.Location = new System.Drawing.Point(41, 461);
            this.DatelistBox.Name = "DatelistBox";
            this.DatelistBox.Size = new System.Drawing.Size(329, 208);
            this.DatelistBox.TabIndex = 31;
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Meiryo UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(383, 81);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(56, 20);
            this.label9.TabIndex = 27;
            this.label9.Text = "圖   片";
            // 
            // Actpanel
            // 
            this.Actpanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Actpanel.Controls.Add(this.btnActivitySearch);
            this.Actpanel.Controls.Add(this.ActivitydataGridView);
            this.Actpanel.Controls.Add(this.txtActivitySearch);
            this.Actpanel.Location = new System.Drawing.Point(39, 107);
            this.Actpanel.Name = "Actpanel";
            this.Actpanel.Size = new System.Drawing.Size(331, 296);
            this.Actpanel.TabIndex = 26;
            // 
            // btnActivitySearch
            // 
            this.btnActivitySearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnActivitySearch.AutoSize = true;
            this.btnActivitySearch.Font = new System.Drawing.Font("Meiryo UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActivitySearch.Location = new System.Drawing.Point(262, 13);
            this.btnActivitySearch.Name = "btnActivitySearch";
            this.btnActivitySearch.Size = new System.Drawing.Size(49, 30);
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
            this.ActivitydataGridView.Location = new System.Drawing.Point(0, 58);
            this.ActivitydataGridView.Name = "ActivitydataGridView";
            this.ActivitydataGridView.RowTemplate.Height = 24;
            this.ActivitydataGridView.Size = new System.Drawing.Size(327, 234);
            this.ActivitydataGridView.TabIndex = 1;
            this.ActivitydataGridView.Paint += new System.Windows.Forms.PaintEventHandler(this.ActivitydataGridView_Paint);
            this.ActivitydataGridView.DoubleClick += new System.EventHandler(this.ActivitydataGridView_DoubleClick);
            // 
            // txtActivitySearch
            // 
            this.txtActivitySearch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtActivitySearch.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtActivitySearch.Location = new System.Drawing.Point(16, 16);
            this.txtActivitySearch.Name = "txtActivitySearch";
            this.txtActivitySearch.Size = new System.Drawing.Size(228, 20);
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
            this.label6.Location = new System.Drawing.Point(35, 84);
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
            // txtDateTimeInsert
            // 
            this.txtDateTimeInsert.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDateTimeInsert.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDateTimeInsert.Font = new System.Drawing.Font("Meiryo UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDateTimeInsert.Location = new System.Drawing.Point(116, 421);
            this.txtDateTimeInsert.Name = "txtDateTimeInsert";
            this.txtDateTimeInsert.Size = new System.Drawing.Size(195, 20);
            this.txtDateTimeInsert.TabIndex = 10;
            // 
            // txtItineraryPrice
            // 
            this.txtItineraryPrice.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtItineraryPrice.Font = new System.Drawing.Font("Meiryo UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtItineraryPrice.Location = new System.Drawing.Point(591, 53);
            this.txtItineraryPrice.Name = "txtItineraryPrice";
            this.txtItineraryPrice.Size = new System.Drawing.Size(229, 20);
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
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Meiryo UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(37, 420);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "出發時間";
            // 
            // txtItinerarySpace
            // 
            this.txtItinerarySpace.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtItinerarySpace.Font = new System.Drawing.Font("Meiryo UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtItinerarySpace.Location = new System.Drawing.Point(743, 10);
            this.txtItinerarySpace.Name = "txtItinerarySpace";
            this.txtItinerarySpace.Size = new System.Drawing.Size(197, 20);
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
            this.txtItineraryId.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtItineraryId.Font = new System.Drawing.Font("Meiryo UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtItineraryId.Location = new System.Drawing.Point(97, 12);
            this.txtItineraryId.Name = "txtItineraryId";
            this.txtItineraryId.Size = new System.Drawing.Size(220, 20);
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
            this.txtItineraryName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtItineraryName.Font = new System.Drawing.Font("Meiryo UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtItineraryName.Location = new System.Drawing.Point(97, 48);
            this.txtItineraryName.Name = "txtItineraryName";
            this.txtItineraryName.Size = new System.Drawing.Size(400, 20);
            this.txtItineraryName.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Meiryo UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(18, 50);
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
            this.panel6.Location = new System.Drawing.Point(0, 711);
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
            this.ClientSize = new System.Drawing.Size(1196, 746);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblProduct);
            this.Name = "FrmItineraryInsert";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmItineraryInsert";
            this.Load += new System.EventHandler(this.FrmItineraryInsert_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.Picpanel.ResumeLayout(false);
            this.Picpanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picbItinerary)).EndInit();
            this.Actpanel.ResumeLayout(false);
            this.Actpanel.PerformLayout();
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
        private System.Windows.Forms.Panel Actpanel;
        private System.Windows.Forms.DataGridView ActivitydataGridView;
        private System.Windows.Forms.TextBox txtActivitySearch;
        private System.Windows.Forms.Button btnActivitySearch;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button btnCancelMain;
        private System.Windows.Forms.Button btnInsertMain;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtItineraryPrice;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ListBox DatelistBox;
        private System.Windows.Forms.TextBox txtDateTimeInsert;
        private System.Windows.Forms.Button btnDateDelete;
        private System.Windows.Forms.Button btnDateAdd;
        private System.Windows.Forms.Panel Picpanel;
        private System.Windows.Forms.TextBox txtPictureDescription;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtPictureName;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.PictureBox picbItinerary;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ListView PiclistView;
        private System.Windows.Forms.Button btnDEMO;
    }
}