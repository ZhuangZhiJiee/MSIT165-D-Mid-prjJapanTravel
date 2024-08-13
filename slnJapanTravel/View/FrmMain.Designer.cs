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
            this.tsbCart = new System.Windows.Forms.ToolStripSplitButton();
            this.行程ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.船票ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsbLeave = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.trs.SuspendLayout();
            this.SuspendLayout();
            // 
            // tsAdmin
            // 
            this.tsAdmin.AutoSize = false;
            this.tsAdmin.BackColor = System.Drawing.Color.MintCream;
            this.tsAdmin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tsAdmin.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tsAdmin.Image = ((System.Drawing.Image)(resources.GetObject("tsAdmin.Image")));
            this.tsAdmin.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsAdmin.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsAdmin.Margin = new System.Windows.Forms.Padding(0, 1, 10, 20);
            this.tsAdmin.Name = "tsAdmin";
            this.tsAdmin.Padding = new System.Windows.Forms.Padding(10);
            this.tsAdmin.RightToLeftAutoMirrorImage = true;
            this.tsAdmin.Size = new System.Drawing.Size(150, 70);
            this.tsAdmin.Text = "管理員系統";
            this.tsAdmin.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.tsAdmin.Click += new System.EventHandler(this.tsAdmin_Click);
            // 
            // tsbMember
            // 
            this.tsbMember.AutoSize = false;
            this.tsbMember.BackColor = System.Drawing.Color.MintCream;
            this.tsbMember.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.tsbMember.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tsbMember.Image = ((System.Drawing.Image)(resources.GetObject("tsbMember.Image")));
            this.tsbMember.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbMember.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbMember.Margin = new System.Windows.Forms.Padding(0, 1, 0, 20);
            this.tsbMember.Name = "tsbMember";
            this.tsbMember.Padding = new System.Windows.Forms.Padding(10);
            this.tsbMember.RightToLeftAutoMirrorImage = true;
            this.tsbMember.Size = new System.Drawing.Size(150, 70);
            this.tsbMember.Text = "會員系統";
            this.tsbMember.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.tsbMember.Click += new System.EventHandler(this.tsbMember_Click);
            // 
            // tsbItinerary
            // 
            this.tsbItinerary.AutoSize = false;
            this.tsbItinerary.BackColor = System.Drawing.Color.MintCream;
            this.tsbItinerary.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.tsbItinerary.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tsbItinerary.Image = ((System.Drawing.Image)(resources.GetObject("tsbItinerary.Image")));
            this.tsbItinerary.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbItinerary.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbItinerary.Margin = new System.Windows.Forms.Padding(0, 1, 0, 20);
            this.tsbItinerary.Name = "tsbItinerary";
            this.tsbItinerary.Padding = new System.Windows.Forms.Padding(10);
            this.tsbItinerary.RightToLeftAutoMirrorImage = true;
            this.tsbItinerary.Size = new System.Drawing.Size(150, 70);
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
            this.tsbCart,
            this.tsbLeave,
            this.toolStripButton3});
            this.trs.Location = new System.Drawing.Point(0, 0);
            this.trs.Name = "trs";
            this.trs.Size = new System.Drawing.Size(167, 908);
            this.trs.TabIndex = 1;
            this.trs.Text = "toolStrip1";
            // 
            // tsbShip
            // 
            this.tsbShip.AutoSize = false;
            this.tsbShip.BackColor = System.Drawing.Color.MintCream;
            this.tsbShip.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.tsbShip.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tsbShip.Image = ((System.Drawing.Image)(resources.GetObject("tsbShip.Image")));
            this.tsbShip.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbShip.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbShip.Margin = new System.Windows.Forms.Padding(0, 1, 0, 20);
            this.tsbShip.Name = "tsbShip";
            this.tsbShip.Padding = new System.Windows.Forms.Padding(10);
            this.tsbShip.RightToLeftAutoMirrorImage = true;
            this.tsbShip.Size = new System.Drawing.Size(150, 70);
            this.tsbShip.Text = "船票系統";
            this.tsbShip.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.tsbShip.Click += new System.EventHandler(this.tsbShip_Click);
            // 
            // tsbOrder
            // 
            this.tsbOrder.AutoSize = false;
            this.tsbOrder.BackColor = System.Drawing.Color.MintCream;
            this.tsbOrder.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.tsbOrder.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.行程ToolStripMenuItem1,
            this.船票ToolStripMenuItem1});
            this.tsbOrder.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tsbOrder.Image = ((System.Drawing.Image)(resources.GetObject("tsbOrder.Image")));
            this.tsbOrder.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbOrder.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbOrder.Margin = new System.Windows.Forms.Padding(0, 1, 0, 20);
            this.tsbOrder.Name = "tsbOrder";
            this.tsbOrder.Padding = new System.Windows.Forms.Padding(10);
            this.tsbOrder.RightToLeftAutoMirrorImage = true;
            this.tsbOrder.Size = new System.Drawing.Size(150, 70);
            this.tsbOrder.Text = "訂單系統";
            this.tsbOrder.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // 行程ToolStripMenuItem1
            // 
            this.行程ToolStripMenuItem1.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.行程ToolStripMenuItem1.Name = "行程ToolStripMenuItem1";
            this.行程ToolStripMenuItem1.Size = new System.Drawing.Size(180, 28);
            this.行程ToolStripMenuItem1.Text = "行程";
            this.行程ToolStripMenuItem1.Click += new System.EventHandler(this.行程ToolStripMenuItem1_Click);
            // 
            // 船票ToolStripMenuItem1
            // 
            this.船票ToolStripMenuItem1.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.船票ToolStripMenuItem1.Name = "船票ToolStripMenuItem1";
            this.船票ToolStripMenuItem1.Size = new System.Drawing.Size(180, 28);
            this.船票ToolStripMenuItem1.Text = "船票";
            this.船票ToolStripMenuItem1.Click += new System.EventHandler(this.船票ToolStripMenuItem1_Click);
            // 
            // tsbBlog
            // 
            this.tsbBlog.AutoSize = false;
            this.tsbBlog.BackColor = System.Drawing.Color.MintCream;
            this.tsbBlog.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.tsbBlog.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tsbBlog.Image = ((System.Drawing.Image)(resources.GetObject("tsbBlog.Image")));
            this.tsbBlog.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbBlog.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbBlog.Margin = new System.Windows.Forms.Padding(0, 1, 0, 20);
            this.tsbBlog.Name = "tsbBlog";
            this.tsbBlog.Padding = new System.Windows.Forms.Padding(10);
            this.tsbBlog.RightToLeftAutoMirrorImage = true;
            this.tsbBlog.Size = new System.Drawing.Size(150, 70);
            this.tsbBlog.Text = "部落格系統";
            this.tsbBlog.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.tsbBlog.Click += new System.EventHandler(this.tsbBlog_Click);
            // 
            // tsbCart
            // 
            this.tsbCart.AutoSize = false;
            this.tsbCart.BackColor = System.Drawing.Color.SkyBlue;
            this.tsbCart.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.tsbCart.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.行程ToolStripMenuItem,
            this.船票ToolStripMenuItem});
            this.tsbCart.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tsbCart.Image = ((System.Drawing.Image)(resources.GetObject("tsbCart.Image")));
            this.tsbCart.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbCart.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbCart.Margin = new System.Windows.Forms.Padding(0, 1, 0, 20);
            this.tsbCart.Name = "tsbCart";
            this.tsbCart.Padding = new System.Windows.Forms.Padding(10);
            this.tsbCart.RightToLeftAutoMirrorImage = true;
            this.tsbCart.Size = new System.Drawing.Size(150, 70);
            this.tsbCart.Text = "購物車";
            this.tsbCart.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
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
            // tsbLeave
            // 
            this.tsbLeave.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tsbLeave.AutoSize = false;
            this.tsbLeave.BackColor = System.Drawing.Color.CadetBlue;
            this.tsbLeave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.tsbLeave.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tsbLeave.Image = ((System.Drawing.Image)(resources.GetObject("tsbLeave.Image")));
            this.tsbLeave.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbLeave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbLeave.Margin = new System.Windows.Forms.Padding(0, 1, 0, 5);
            this.tsbLeave.Name = "tsbLeave";
            this.tsbLeave.Padding = new System.Windows.Forms.Padding(10);
            this.tsbLeave.RightToLeftAutoMirrorImage = true;
            this.tsbLeave.Size = new System.Drawing.Size(180, 50);
            this.tsbLeave.Text = "離開";
            this.tsbLeave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.tsbLeave.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton3.Image")));
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(165, 28);
            this.toolStripButton3.Text = "toolStripButton3";
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
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
        private System.Windows.Forms.ToolStripSplitButton tsbCart;
        private System.Windows.Forms.ToolStripMenuItem 行程ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 船票ToolStripMenuItem;
        private System.Windows.Forms.ToolStripSplitButton tsbOrder;
        private System.Windows.Forms.ToolStripMenuItem 行程ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 船票ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripButton tsbLeave;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
    }
}