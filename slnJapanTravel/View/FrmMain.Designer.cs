namespace slnJapanTravel.View
{
    partial class FrmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.tsAdmin = new System.Windows.Forms.ToolStripButton();
            this.tsbMember = new System.Windows.Forms.ToolStripButton();
            this.tsbItinerary = new System.Windows.Forms.ToolStripButton();
            this.trs = new System.Windows.Forms.ToolStrip();
            this.tsbShip = new System.Windows.Forms.ToolStripButton();
            this.tsbOrder = new System.Windows.Forms.ToolStripSplitButton();
            this.行程ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.船票ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.tsbBlog = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripSplitButton();
            this.行程ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.船票ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.trs.SuspendLayout();
            this.SuspendLayout();
            // 
            // tsAdmin
            // 
            this.tsAdmin.AutoSize = false;
            this.tsAdmin.BackColor = System.Drawing.Color.Cornsilk;
            this.tsAdmin.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tsAdmin.BackgroundImage")));
            this.tsAdmin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.tsAdmin.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tsAdmin.Image = ((System.Drawing.Image)(resources.GetObject("tsAdmin.Image")));
            this.tsAdmin.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsAdmin.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsAdmin.Name = "tsAdmin";
            this.tsAdmin.Padding = new System.Windows.Forms.Padding(10);
            this.tsAdmin.RightToLeftAutoMirrorImage = true;
            this.tsAdmin.Size = new System.Drawing.Size(180, 100);
            this.tsAdmin.Text = "管理員系統";
            this.tsAdmin.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.tsAdmin.Click += new System.EventHandler(this.tsAdmin_Click);
            // 
            // tsbMember
            // 
            this.tsbMember.AutoSize = false;
            this.tsbMember.BackColor = System.Drawing.Color.Cornsilk;
            this.tsbMember.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.tsbMember.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tsbMember.Image = ((System.Drawing.Image)(resources.GetObject("tsbMember.Image")));
            this.tsbMember.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbMember.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbMember.Name = "tsbMember";
            this.tsbMember.Padding = new System.Windows.Forms.Padding(10);
            this.tsbMember.RightToLeftAutoMirrorImage = true;
            this.tsbMember.Size = new System.Drawing.Size(180, 100);
            this.tsbMember.Text = "會員系統";
            this.tsbMember.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.tsbMember.Click += new System.EventHandler(this.tsbMember_Click);
            // 
            // tsbItinerary
            // 
            this.tsbItinerary.AutoSize = false;
            this.tsbItinerary.BackColor = System.Drawing.Color.Cornsilk;
            this.tsbItinerary.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.tsbItinerary.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tsbItinerary.Image = ((System.Drawing.Image)(resources.GetObject("tsbItinerary.Image")));
            this.tsbItinerary.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbItinerary.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbItinerary.Name = "tsbItinerary";
            this.tsbItinerary.Padding = new System.Windows.Forms.Padding(10);
            this.tsbItinerary.RightToLeftAutoMirrorImage = true;
            this.tsbItinerary.Size = new System.Drawing.Size(180, 100);
            this.tsbItinerary.Text = "旅遊行程系統";
            this.tsbItinerary.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.tsbItinerary.Click += new System.EventHandler(this.tsbLtinerary_Click);
            // 
            // trs
            // 
            this.trs.AutoSize = false;
            this.trs.BackColor = System.Drawing.Color.PowderBlue;
            this.trs.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("trs.BackgroundImage")));
            this.trs.Dock = System.Windows.Forms.DockStyle.Left;
            this.trs.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.trs.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsAdmin,
            this.tsbMember,
            this.tsbItinerary,
            this.tsbShip,
            this.tsbOrder,
            this.tsbBlog,
            this.toolStripButton1,
            this.toolStripButton2});
            this.trs.Location = new System.Drawing.Point(0, 0);
            this.trs.Name = "trs";
            this.trs.Size = new System.Drawing.Size(167, 908);
            this.trs.TabIndex = 1;
            this.trs.Text = "toolStrip1";
            // 
            // tsbShip
            // 
            this.tsbShip.AutoSize = false;
            this.tsbShip.BackColor = System.Drawing.Color.Cornsilk;
            this.tsbShip.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.tsbShip.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tsbShip.Image = ((System.Drawing.Image)(resources.GetObject("tsbShip.Image")));
            this.tsbShip.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbShip.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbShip.Name = "tsbShip";
            this.tsbShip.Padding = new System.Windows.Forms.Padding(10);
            this.tsbShip.RightToLeftAutoMirrorImage = true;
            this.tsbShip.Size = new System.Drawing.Size(180, 100);
            this.tsbShip.Text = "船票系統";
            this.tsbShip.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.tsbShip.Click += new System.EventHandler(this.tsbShip_Click);
            // 
            // tsbOrder
            // 
            this.tsbOrder.AutoSize = false;
            this.tsbOrder.BackColor = System.Drawing.Color.Cornsilk;
            this.tsbOrder.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.tsbOrder.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.行程ToolStripMenuItem1,
            this.船票ToolStripMenuItem1});
            this.tsbOrder.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tsbOrder.Image = ((System.Drawing.Image)(resources.GetObject("tsbOrder.Image")));
            this.tsbOrder.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbOrder.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbOrder.Name = "tsbOrder";
            this.tsbOrder.Padding = new System.Windows.Forms.Padding(10);
            this.tsbOrder.RightToLeftAutoMirrorImage = true;
            this.tsbOrder.Size = new System.Drawing.Size(180, 100);
            this.tsbOrder.Text = "訂單系統";
            this.tsbOrder.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // 行程ToolStripMenuItem1
            // 
            this.行程ToolStripMenuItem1.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.行程ToolStripMenuItem1.Name = "行程ToolStripMenuItem1";
            this.行程ToolStripMenuItem1.Size = new System.Drawing.Size(179, 46);
            this.行程ToolStripMenuItem1.Text = "行程";
            this.行程ToolStripMenuItem1.Click += new System.EventHandler(this.行程ToolStripMenuItem1_Click);
            // 
            // 船票ToolStripMenuItem1
            // 
            this.船票ToolStripMenuItem1.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.船票ToolStripMenuItem1.Name = "船票ToolStripMenuItem1";
            this.船票ToolStripMenuItem1.Size = new System.Drawing.Size(179, 46);
            this.船票ToolStripMenuItem1.Text = "船票";
            this.船票ToolStripMenuItem1.Click += new System.EventHandler(this.船票ToolStripMenuItem1_Click);
            // 
            // tsbBlog
            // 
            this.tsbBlog.AutoSize = false;
            this.tsbBlog.BackColor = System.Drawing.Color.Cornsilk;
            this.tsbBlog.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.tsbBlog.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tsbBlog.Image = ((System.Drawing.Image)(resources.GetObject("tsbBlog.Image")));
            this.tsbBlog.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbBlog.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbBlog.Name = "tsbBlog";
            this.tsbBlog.Padding = new System.Windows.Forms.Padding(10);
            this.tsbBlog.RightToLeftAutoMirrorImage = true;
            this.tsbBlog.Size = new System.Drawing.Size(180, 100);
            this.tsbBlog.Text = "部落格系統";
            this.tsbBlog.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.tsbBlog.Click += new System.EventHandler(this.tsbBlog_Click);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.AutoSize = false;
            this.toolStripButton1.BackColor = System.Drawing.Color.SkyBlue;
            this.toolStripButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.toolStripButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.行程ToolStripMenuItem,
            this.船票ToolStripMenuItem});
            this.toolStripButton1.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Padding = new System.Windows.Forms.Padding(10);
            this.toolStripButton1.RightToLeftAutoMirrorImage = true;
            this.toolStripButton1.Size = new System.Drawing.Size(180, 100);
            this.toolStripButton1.Text = "購物車";
            this.toolStripButton1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // 行程ToolStripMenuItem
            // 
            this.行程ToolStripMenuItem.AutoSize = false;
            this.行程ToolStripMenuItem.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.行程ToolStripMenuItem.Name = "行程ToolStripMenuItem";
            this.行程ToolStripMenuItem.Size = new System.Drawing.Size(180, 32);
            this.行程ToolStripMenuItem.Text = "行程";
            this.行程ToolStripMenuItem.Click += new System.EventHandler(this.行程ToolStripMenuItem_Click);
            // 
            // 船票ToolStripMenuItem
            // 
            this.船票ToolStripMenuItem.AutoSize = false;
            this.船票ToolStripMenuItem.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.船票ToolStripMenuItem.Name = "船票ToolStripMenuItem";
            this.船票ToolStripMenuItem.Size = new System.Drawing.Size(180, 32);
            this.船票ToolStripMenuItem.Text = "船票";
            this.船票ToolStripMenuItem.Click += new System.EventHandler(this.船票ToolStripMenuItem_Click);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripButton2.AutoSize = false;
            this.toolStripButton2.BackColor = System.Drawing.Color.SkyBlue;
            this.toolStripButton2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.toolStripButton2.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Padding = new System.Windows.Forms.Padding(10);
            this.toolStripButton2.RightToLeftAutoMirrorImage = true;
            this.toolStripButton2.Size = new System.Drawing.Size(180, 100);
            this.toolStripButton2.Text = "離開";
            this.toolStripButton2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toolStripButton2.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1298, 908);
            this.Controls.Add(this.trs);
            this.Font = new System.Drawing.Font("微軟正黑體", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmMain";
            this.Text = "日本旅遊後台系統";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.trs.ResumeLayout(false);
            this.trs.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ToolStripButton tsAdmin;
        private System.Windows.Forms.ToolStripButton tsbMember;
        private System.Windows.Forms.ToolStripButton tsbItinerary;
        private System.Windows.Forms.ToolStrip trs;
        private System.Windows.Forms.ToolStripButton tsbShip;
        private System.Windows.Forms.ToolStripButton tsbBlog;
        private System.Windows.Forms.ToolStripSplitButton toolStripButton1;
        private System.Windows.Forms.ToolStripMenuItem 行程ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 船票ToolStripMenuItem;
        private System.Windows.Forms.ToolStripSplitButton tsbOrder;
        private System.Windows.Forms.ToolStripMenuItem 行程ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 船票ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
    }
}