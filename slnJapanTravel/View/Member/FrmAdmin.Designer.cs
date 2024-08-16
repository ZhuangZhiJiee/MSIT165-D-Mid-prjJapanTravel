namespace slnJapanTravel.View
{
    partial class FrmAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAdmin));
            this.dgvAdmin = new System.Windows.Forms.DataGridView();
            this.tsAdmin = new System.Windows.Forms.ToolStrip();
            this.tsbInsert = new System.Windows.Forms.ToolStripButton();
            this.tsbUpdate = new System.Windows.Forms.ToolStripButton();
            this.tsbDelete = new System.Windows.Forms.ToolStripButton();
            this.lblName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblAccount = new System.Windows.Forms.Label();
            this.txtAccount = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.picAdmin = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnShow = new System.Windows.Forms.Button();
            this.txtID = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbCoupon = new System.Windows.Forms.CheckBox();
            this.cbComment = new System.Windows.Forms.CheckBox();
            this.cbBlog = new System.Windows.Forms.CheckBox();
            this.cbOrder = new System.Windows.Forms.CheckBox();
            this.cbShip = new System.Windows.Forms.CheckBox();
            this.cbItinerary = new System.Windows.Forms.CheckBox();
            this.cbMember = new System.Windows.Forms.CheckBox();
            this.cbAdmin = new System.Windows.Forms.CheckBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.ofdAdminPicture = new System.Windows.Forms.OpenFileDialog();
            this.txtKeyword = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnSearch = new System.Windows.Forms.Button();
            this.cboStatus = new System.Windows.Forms.ComboBox();
            this.btnDemo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAdmin)).BeginInit();
            this.tsAdmin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAdmin)).BeginInit();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvAdmin
            // 
            this.dgvAdmin.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAdmin.BackgroundColor = System.Drawing.Color.Linen;
            this.dgvAdmin.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAdmin.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvAdmin.Location = new System.Drawing.Point(0, 372);
            this.dgvAdmin.MultiSelect = false;
            this.dgvAdmin.Name = "dgvAdmin";
            this.dgvAdmin.ReadOnly = true;
            this.dgvAdmin.RowTemplate.Height = 24;
            this.dgvAdmin.Size = new System.Drawing.Size(1235, 334);
            this.dgvAdmin.TabIndex = 0;
            this.dgvAdmin.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAdmin_RowEnter);
            // 
            // tsAdmin
            // 
            this.tsAdmin.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbInsert,
            this.tsbUpdate,
            this.tsbDelete});
            this.tsAdmin.Location = new System.Drawing.Point(0, 0);
            this.tsAdmin.Name = "tsAdmin";
            this.tsAdmin.Size = new System.Drawing.Size(1235, 53);
            this.tsAdmin.TabIndex = 4;
            this.tsAdmin.Text = "toolStrip1";
            // 
            // tsbInsert
            // 
            this.tsbInsert.AutoSize = false;
            this.tsbInsert.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tsbInsert.Image = ((System.Drawing.Image)(resources.GetObject("tsbInsert.Image")));
            this.tsbInsert.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbInsert.Name = "tsbInsert";
            this.tsbInsert.Size = new System.Drawing.Size(150, 50);
            this.tsbInsert.Text = "新增管理員";
            this.tsbInsert.Click += new System.EventHandler(this.tsbInsert_Click);
            // 
            // tsbUpdate
            // 
            this.tsbUpdate.AutoSize = false;
            this.tsbUpdate.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tsbUpdate.Image = ((System.Drawing.Image)(resources.GetObject("tsbUpdate.Image")));
            this.tsbUpdate.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbUpdate.Name = "tsbUpdate";
            this.tsbUpdate.Size = new System.Drawing.Size(150, 50);
            this.tsbUpdate.Text = "修改資料";
            this.tsbUpdate.Click += new System.EventHandler(this.tsbUpdate_Click);
            // 
            // tsbDelete
            // 
            this.tsbDelete.AutoSize = false;
            this.tsbDelete.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tsbDelete.Image = ((System.Drawing.Image)(resources.GetObject("tsbDelete.Image")));
            this.tsbDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbDelete.Name = "tsbDelete";
            this.tsbDelete.Size = new System.Drawing.Size(150, 50);
            this.tsbDelete.Text = "刪除資料";
            this.tsbDelete.Click += new System.EventHandler(this.tsbDelete_Click);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblName.Location = new System.Drawing.Point(390, 12);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(53, 24);
            this.lblName.TabIndex = 2;
            this.lblName.Text = "姓名:";
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtName.Location = new System.Drawing.Point(391, 41);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(216, 29);
            this.txtName.TabIndex = 3;
            // 
            // lblAccount
            // 
            this.lblAccount.AutoSize = true;
            this.lblAccount.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblAccount.Location = new System.Drawing.Point(390, 172);
            this.lblAccount.Name = "lblAccount";
            this.lblAccount.Size = new System.Drawing.Size(53, 24);
            this.lblAccount.TabIndex = 4;
            this.lblAccount.Text = "帳號:";
            // 
            // txtAccount
            // 
            this.txtAccount.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtAccount.Location = new System.Drawing.Point(391, 201);
            this.txtAccount.Name = "txtAccount";
            this.txtAccount.Size = new System.Drawing.Size(216, 29);
            this.txtAccount.TabIndex = 5;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblEmail.Location = new System.Drawing.Point(390, 94);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(65, 24);
            this.lblEmail.TabIndex = 6;
            this.lblEmail.Text = "Email:";
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtEmail.Location = new System.Drawing.Point(391, 123);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(216, 29);
            this.txtEmail.TabIndex = 7;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblPassword.Location = new System.Drawing.Point(390, 253);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(53, 24);
            this.lblPassword.TabIndex = 8;
            this.lblPassword.Text = "密碼:";
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtPassword.Location = new System.Drawing.Point(391, 282);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(216, 29);
            this.txtPassword.TabIndex = 9;
            // 
            // picAdmin
            // 
            this.picAdmin.BackColor = System.Drawing.Color.White;
            this.picAdmin.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picAdmin.Image = ((System.Drawing.Image)(resources.GetObject("picAdmin.Image")));
            this.picAdmin.Location = new System.Drawing.Point(87, 47);
            this.picAdmin.Name = "picAdmin";
            this.picAdmin.Size = new System.Drawing.Size(223, 220);
            this.picAdmin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picAdmin.TabIndex = 10;
            this.picAdmin.TabStop = false;
            this.picAdmin.DoubleClick += new System.EventHandler(this.picAdmin_DoubleClick);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnShow);
            this.panel1.Controls.Add(this.txtID);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.btnCancel);
            this.panel1.Controls.Add(this.btnSave);
            this.panel1.Controls.Add(this.picAdmin);
            this.panel1.Controls.Add(this.txtPassword);
            this.panel1.Controls.Add(this.lblPassword);
            this.panel1.Controls.Add(this.txtEmail);
            this.panel1.Controls.Add(this.lblEmail);
            this.panel1.Controls.Add(this.txtAccount);
            this.panel1.Controls.Add(this.lblAccount);
            this.panel1.Controls.Add(this.txtName);
            this.panel1.Controls.Add(this.lblName);
            this.panel1.Location = new System.Drawing.Point(4, 54);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(888, 317);
            this.panel1.TabIndex = 5;
            // 
            // btnShow
            // 
            this.btnShow.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnShow.Location = new System.Drawing.Point(617, 278);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(86, 40);
            this.btnShow.TabIndex = 15;
            this.btnShow.Text = "顯示密碼";
            this.btnShow.UseVisualStyleBackColor = true;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(575, 12);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(32, 22);
            this.txtID.TabIndex = 14;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbCoupon);
            this.groupBox1.Controls.Add(this.cbComment);
            this.groupBox1.Controls.Add(this.cbBlog);
            this.groupBox1.Controls.Add(this.cbOrder);
            this.groupBox1.Controls.Add(this.cbShip);
            this.groupBox1.Controls.Add(this.cbItinerary);
            this.groupBox1.Controls.Add(this.cbMember);
            this.groupBox1.Controls.Add(this.cbAdmin);
            this.groupBox1.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.groupBox1.Location = new System.Drawing.Point(642, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(234, 274);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "權限";
            // 
            // cbCoupon
            // 
            this.cbCoupon.AutoSize = true;
            this.cbCoupon.Font = new System.Drawing.Font("微軟正黑體", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.cbCoupon.Location = new System.Drawing.Point(5, 235);
            this.cbCoupon.Name = "cbCoupon";
            this.cbCoupon.Size = new System.Drawing.Size(223, 39);
            this.cbCoupon.TabIndex = 7;
            this.cbCoupon.Text = "優惠券管理權限";
            this.cbCoupon.UseVisualStyleBackColor = true;
            // 
            // cbComment
            // 
            this.cbComment.AutoSize = true;
            this.cbComment.Font = new System.Drawing.Font("微軟正黑體", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.cbComment.Location = new System.Drawing.Point(6, 204);
            this.cbComment.Name = "cbComment";
            this.cbComment.Size = new System.Drawing.Size(196, 39);
            this.cbComment.TabIndex = 6;
            this.cbComment.Text = "評論管理權限";
            this.cbComment.UseVisualStyleBackColor = true;
            // 
            // cbBlog
            // 
            this.cbBlog.AutoSize = true;
            this.cbBlog.Font = new System.Drawing.Font("微軟正黑體", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.cbBlog.Location = new System.Drawing.Point(5, 176);
            this.cbBlog.Name = "cbBlog";
            this.cbBlog.Size = new System.Drawing.Size(223, 39);
            this.cbBlog.TabIndex = 5;
            this.cbBlog.Text = "部落格管理權限";
            this.cbBlog.UseVisualStyleBackColor = true;
            // 
            // cbOrder
            // 
            this.cbOrder.AutoSize = true;
            this.cbOrder.Font = new System.Drawing.Font("微軟正黑體", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.cbOrder.Location = new System.Drawing.Point(6, 146);
            this.cbOrder.Name = "cbOrder";
            this.cbOrder.Size = new System.Drawing.Size(196, 39);
            this.cbOrder.TabIndex = 4;
            this.cbOrder.Text = "訂單管理權限";
            this.cbOrder.UseVisualStyleBackColor = true;
            // 
            // cbShip
            // 
            this.cbShip.AutoSize = true;
            this.cbShip.Font = new System.Drawing.Font("微軟正黑體", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.cbShip.Location = new System.Drawing.Point(6, 115);
            this.cbShip.Name = "cbShip";
            this.cbShip.Size = new System.Drawing.Size(196, 39);
            this.cbShip.TabIndex = 3;
            this.cbShip.Text = "航線管理權限";
            this.cbShip.UseVisualStyleBackColor = true;
            // 
            // cbItinerary
            // 
            this.cbItinerary.AutoSize = true;
            this.cbItinerary.Font = new System.Drawing.Font("微軟正黑體", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.cbItinerary.Location = new System.Drawing.Point(6, 85);
            this.cbItinerary.Name = "cbItinerary";
            this.cbItinerary.Size = new System.Drawing.Size(196, 39);
            this.cbItinerary.TabIndex = 2;
            this.cbItinerary.Text = "行程管理權限";
            this.cbItinerary.UseVisualStyleBackColor = true;
            // 
            // cbMember
            // 
            this.cbMember.AutoSize = true;
            this.cbMember.Font = new System.Drawing.Font("微軟正黑體", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.cbMember.Location = new System.Drawing.Point(3, 24);
            this.cbMember.Name = "cbMember";
            this.cbMember.Size = new System.Drawing.Size(196, 39);
            this.cbMember.TabIndex = 1;
            this.cbMember.Text = "會員管理權限";
            this.cbMember.UseVisualStyleBackColor = true;
            // 
            // cbAdmin
            // 
            this.cbAdmin.AutoSize = true;
            this.cbAdmin.Font = new System.Drawing.Font("微軟正黑體", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.cbAdmin.Location = new System.Drawing.Point(4, 57);
            this.cbAdmin.Name = "cbAdmin";
            this.cbAdmin.Size = new System.Drawing.Size(223, 39);
            this.cbAdmin.TabIndex = 0;
            this.cbAdmin.Text = "管理員管理權限";
            this.cbAdmin.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnCancel.Location = new System.Drawing.Point(799, 276);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(86, 40);
            this.btnCancel.TabIndex = 12;
            this.btnCancel.Text = "取消";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnSave.Location = new System.Drawing.Point(707, 277);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(86, 40);
            this.btnSave.TabIndex = 11;
            this.btnSave.Text = "儲存";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // txtKeyword
            // 
            this.txtKeyword.Font = new System.Drawing.Font("微軟正黑體", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtKeyword.Location = new System.Drawing.Point(3, 6);
            this.txtKeyword.Name = "txtKeyword";
            this.txtKeyword.Size = new System.Drawing.Size(216, 43);
            this.txtKeyword.TabIndex = 6;
            this.txtKeyword.Text = "關鍵字查詢";
            this.txtKeyword.TextChanged += new System.EventHandler(this.txtKeyword_TextChanged);
            this.txtKeyword.Enter += new System.EventHandler(this.txtSearch_Enter);
            this.txtKeyword.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSearch_KeyPress);
            this.txtKeyword.Leave += new System.EventHandler(this.txtKeyword_Leave);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnSearch);
            this.panel2.Controls.Add(this.txtKeyword);
            this.panel2.Location = new System.Drawing.Point(971, 66);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(264, 48);
            this.panel2.TabIndex = 8;
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSearch.Image = ((System.Drawing.Image)(resources.GetObject("btnSearch.Image")));
            this.btnSearch.Location = new System.Drawing.Point(220, 3);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(42, 42);
            this.btnSearch.TabIndex = 7;
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // cboStatus
            // 
            this.cboStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboStatus.Font = new System.Drawing.Font("微軟正黑體", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.cboStatus.FormattingEnabled = true;
            this.cboStatus.Items.AddRange(new object[] {
            "",
            "會員管理權限",
            "管理員管理權限",
            "行程管理權限",
            "航線管理權限",
            "訂單管理權限",
            "部落格管理權限",
            "評論管理權限",
            "優惠券管理權限"});
            this.cboStatus.Location = new System.Drawing.Point(971, 166);
            this.cboStatus.Name = "cboStatus";
            this.cboStatus.Size = new System.Drawing.Size(262, 43);
            this.cboStatus.TabIndex = 9;
            this.cboStatus.TextChanged += new System.EventHandler(this.cboStatus_TextChanged);
            // 
            // btnDemo
            // 
            this.btnDemo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnDemo.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnDemo.Location = new System.Drawing.Point(921, 333);
            this.btnDemo.Name = "btnDemo";
            this.btnDemo.Size = new System.Drawing.Size(77, 35);
            this.btnDemo.TabIndex = 10;
            this.btnDemo.Text = "Demo";
            this.btnDemo.UseVisualStyleBackColor = false;
            this.btnDemo.Click += new System.EventHandler(this.btnDemo_Click);
            // 
            // FrmAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Bisque;
            this.ClientSize = new System.Drawing.Size(1235, 706);
            this.Controls.Add(this.btnDemo);
            this.Controls.Add(this.cboStatus);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.tsAdmin);
            this.Controls.Add(this.dgvAdmin);
            this.Controls.Add(this.panel1);
            this.Name = "FrmAdmin";
            this.Text = "管理員系統";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmAdmin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAdmin)).EndInit();
            this.tsAdmin.ResumeLayout(false);
            this.tsAdmin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAdmin)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvAdmin;
        private System.Windows.Forms.ToolStrip tsAdmin;
        private System.Windows.Forms.ToolStripButton tsbInsert;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblAccount;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtAccount;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox cbAdmin;
        private System.Windows.Forms.CheckBox cbItinerary;
        private System.Windows.Forms.CheckBox cbMember;
        private System.Windows.Forms.CheckBox cbOrder;
        private System.Windows.Forms.CheckBox cbShip;
        private System.Windows.Forms.CheckBox cbComment;
        private System.Windows.Forms.CheckBox cbBlog;
        private System.Windows.Forms.CheckBox cbCoupon;
        private System.Windows.Forms.ToolStripButton tsbUpdate;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.OpenFileDialog ofdAdminPicture;
        private System.Windows.Forms.PictureBox picAdmin;
        private System.Windows.Forms.ToolStripButton tsbDelete;
        private System.Windows.Forms.TextBox txtKeyword;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.ComboBox cboStatus;
        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.Button btnDemo;
    }
}