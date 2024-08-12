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
            this.lblName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblAccount = new System.Windows.Forms.Label();
            this.txtAccount = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.picAdmin = new System.Windows.Forms.PictureBox();
            this.clbStatus = new System.Windows.Forms.CheckedListBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAdmin)).BeginInit();
            this.tsAdmin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAdmin)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvAdmin
            // 
            this.dgvAdmin.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAdmin.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvAdmin.Location = new System.Drawing.Point(0, 372);
            this.dgvAdmin.Name = "dgvAdmin";
            this.dgvAdmin.RowTemplate.Height = 24;
            this.dgvAdmin.Size = new System.Drawing.Size(1235, 334);
            this.dgvAdmin.TabIndex = 0;
            // 
            // tsAdmin
            // 
            this.tsAdmin.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbInsert});
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
            this.txtName.Size = new System.Drawing.Size(160, 29);
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
            this.txtAccount.Size = new System.Drawing.Size(160, 29);
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
            this.txtEmail.Size = new System.Drawing.Size(160, 29);
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
            this.txtPassword.Size = new System.Drawing.Size(160, 29);
            this.txtPassword.TabIndex = 9;
            // 
            // picAdmin
            // 
            this.picAdmin.BackColor = System.Drawing.Color.White;
            this.picAdmin.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picAdmin.Location = new System.Drawing.Point(87, 23);
            this.picAdmin.Name = "picAdmin";
            this.picAdmin.Size = new System.Drawing.Size(228, 291);
            this.picAdmin.TabIndex = 10;
            this.picAdmin.TabStop = false;
            // 
            // clbStatus
            // 
            this.clbStatus.Font = new System.Drawing.Font("微軟正黑體", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.clbStatus.FormattingEnabled = true;
            this.clbStatus.Items.AddRange(new object[] {
            "管理員管理權限",
            "會員管理權限",
            "行程管理權限",
            "航線管理權限",
            "訂單管理權限",
            "部落格管理權限",
            "評論管理權限",
            "優惠券管理權限"});
            this.clbStatus.Location = new System.Drawing.Point(642, 17);
            this.clbStatus.Name = "clbStatus";
            this.clbStatus.Size = new System.Drawing.Size(224, 270);
            this.clbStatus.TabIndex = 6;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnCancel);
            this.panel1.Controls.Add(this.btnSave);
            this.panel1.Controls.Add(this.clbStatus);
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
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnSave.Location = new System.Drawing.Point(642, 274);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(86, 40);
            this.btnSave.TabIndex = 11;
            this.btnSave.Text = "儲存";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnCancel.Location = new System.Drawing.Point(780, 273);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(86, 40);
            this.btnCancel.TabIndex = 12;
            this.btnCancel.Text = "取消";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // FrmAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1235, 706);
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
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvAdmin;
        private System.Windows.Forms.ToolStrip tsAdmin;
        private System.Windows.Forms.ToolStripButton tsbInsert;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.PictureBox picAdmin;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblAccount;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtAccount;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.CheckedListBox clbStatus;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
    }
}