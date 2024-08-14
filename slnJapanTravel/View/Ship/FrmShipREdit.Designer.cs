namespace slnJapanTravel.View
{
    partial class FrmShipREdit
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
            this.tbID = new System.Windows.Forms.TextBox();
            this.lbRouteID = new System.Windows.Forms.Label();
            this.lbDeparture = new System.Windows.Forms.Label();
            this.lbDestibation = new System.Windows.Forms.Label();
            this.lbDescription = new System.Windows.Forms.Label();
            this.tbDesc = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.cbOri = new System.Windows.Forms.ComboBox();
            this.port港口BindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.japanTravelDataSet1 = new slnJapanTravel.JapanTravelDataSet1();
            this.cbDest = new System.Windows.Forms.ComboBox();
            this.port港口BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.japanTravelDataSet = new slnJapanTravel.JapanTravelDataSet();
            this.port港口TableAdapter = new slnJapanTravel.JapanTravelDataSetTableAdapters.Port港口TableAdapter();
            this.port港口TableAdapter1 = new slnJapanTravel.JapanTravelDataSet1TableAdapters.Port港口TableAdapter();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.port港口BindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.japanTravelDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.port港口BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.japanTravelDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // tbID
            // 
            this.tbID.Location = new System.Drawing.Point(102, 115);
            this.tbID.Name = "tbID";
            this.tbID.Size = new System.Drawing.Size(686, 22);
            this.tbID.TabIndex = 1;
            this.tbID.Visible = false;
            // 
            // lbRouteID
            // 
            this.lbRouteID.AutoSize = true;
            this.lbRouteID.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbRouteID.Location = new System.Drawing.Point(10, 115);
            this.lbRouteID.Name = "lbRouteID";
            this.lbRouteID.Size = new System.Drawing.Size(86, 24);
            this.lbRouteID.TabIndex = 2;
            this.lbRouteID.Text = "航線編號";
            this.lbRouteID.Visible = false;
            // 
            // lbDeparture
            // 
            this.lbDeparture.AutoSize = true;
            this.lbDeparture.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbDeparture.Location = new System.Drawing.Point(29, 161);
            this.lbDeparture.Name = "lbDeparture";
            this.lbDeparture.Size = new System.Drawing.Size(67, 24);
            this.lbDeparture.TabIndex = 4;
            this.lbDeparture.Text = "出發港";
            // 
            // lbDestibation
            // 
            this.lbDestibation.AutoSize = true;
            this.lbDestibation.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbDestibation.Location = new System.Drawing.Point(29, 207);
            this.lbDestibation.Name = "lbDestibation";
            this.lbDestibation.Size = new System.Drawing.Size(67, 24);
            this.lbDestibation.TabIndex = 6;
            this.lbDestibation.Text = "到達港";
            // 
            // lbDescription
            // 
            this.lbDescription.AutoSize = true;
            this.lbDescription.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbDescription.Location = new System.Drawing.Point(38, 245);
            this.lbDescription.Name = "lbDescription";
            this.lbDescription.Size = new System.Drawing.Size(48, 24);
            this.lbDescription.TabIndex = 8;
            this.lbDescription.Text = "描述";
            // 
            // tbDesc
            // 
            this.tbDesc.AllowDrop = true;
            this.tbDesc.HideSelection = false;
            this.tbDesc.Location = new System.Drawing.Point(102, 245);
            this.tbDesc.Multiline = true;
            this.tbDesc.Name = "tbDesc";
            this.tbDesc.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbDesc.Size = new System.Drawing.Size(686, 188);
            this.tbDesc.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.AutoSize = true;
            this.button1.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button1.Location = new System.Drawing.Point(581, 494);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(93, 34);
            this.button1.TabIndex = 13;
            this.button1.Text = "確定";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.AutoSize = true;
            this.button2.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button2.Location = new System.Drawing.Point(695, 494);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(93, 34);
            this.button2.TabIndex = 13;
            this.button2.Text = "取消";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblTitle);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 100);
            this.panel1.TabIndex = 15;
            // 
            // lblTitle
            // 
            this.lblTitle.BackColor = System.Drawing.Color.White;
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTitle.ForeColor = System.Drawing.Color.Black;
            this.lblTitle.Location = new System.Drawing.Point(100, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(700, 100);
            this.lblTitle.TabIndex = 16;
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 100);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // cbOri
            // 
            this.cbOri.DataSource = this.port港口BindingSource1;
            this.cbOri.DisplayMember = "PortName港口名稱";
            this.cbOri.FormattingEnabled = true;
            this.cbOri.Location = new System.Drawing.Point(102, 165);
            this.cbOri.Name = "cbOri";
            this.cbOri.Size = new System.Drawing.Size(686, 20);
            this.cbOri.TabIndex = 17;
            // 
            // port港口BindingSource1
            // 
            this.port港口BindingSource1.DataMember = "Port港口";
            this.port港口BindingSource1.DataSource = this.japanTravelDataSet1;
            // 
            // japanTravelDataSet1
            // 
            this.japanTravelDataSet1.DataSetName = "JapanTravelDataSet1";
            this.japanTravelDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cbDest
            // 
            this.cbDest.DataSource = this.port港口BindingSource;
            this.cbDest.DisplayMember = "PortName港口名稱";
            this.cbDest.FormattingEnabled = true;
            this.cbDest.Location = new System.Drawing.Point(102, 207);
            this.cbDest.Name = "cbDest";
            this.cbDest.Size = new System.Drawing.Size(686, 20);
            this.cbDest.TabIndex = 17;
            // 
            // port港口BindingSource
            // 
            this.port港口BindingSource.DataMember = "Port港口";
            this.port港口BindingSource.DataSource = this.japanTravelDataSet;
            // 
            // japanTravelDataSet
            // 
            this.japanTravelDataSet.DataSetName = "JapanTravelDataSet";
            this.japanTravelDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // port港口TableAdapter
            // 
            this.port港口TableAdapter.ClearBeforeFill = true;
            // 
            // port港口TableAdapter1
            // 
            this.port港口TableAdapter1.ClearBeforeFill = true;
            // 
            // FrmShipREdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 540);
            this.Controls.Add(this.cbDest);
            this.Controls.Add(this.cbOri);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lbDescription);
            this.Controls.Add(this.tbDesc);
            this.Controls.Add(this.lbDestibation);
            this.Controls.Add(this.lbDeparture);
            this.Controls.Add(this.lbRouteID);
            this.Controls.Add(this.tbID);
            this.Name = "FrmShipREdit";
            this.Text = "FrmShipEdit";
            this.Load += new System.EventHandler(this.FrmShipREdit_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.port港口BindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.japanTravelDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.port港口BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.japanTravelDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox tbID;
        private System.Windows.Forms.Label lbRouteID;
        private System.Windows.Forms.Label lbDeparture;
        private System.Windows.Forms.Label lbDestibation;
        private System.Windows.Forms.Label lbDescription;
        private System.Windows.Forms.TextBox tbDesc;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox cbOri;
        private System.Windows.Forms.ComboBox cbDest;
        private JapanTravelDataSet japanTravelDataSet;
        private System.Windows.Forms.BindingSource port港口BindingSource;
        private JapanTravelDataSetTableAdapters.Port港口TableAdapter port港口TableAdapter;
        private JapanTravelDataSet1 japanTravelDataSet1;
        private System.Windows.Forms.BindingSource port港口BindingSource1;
        private JapanTravelDataSet1TableAdapters.Port港口TableAdapter port港口TableAdapter1;
    }
}