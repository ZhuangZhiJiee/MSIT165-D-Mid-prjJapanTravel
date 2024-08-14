namespace slnJapanTravel.View
{
    partial class FrmShip
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmShip));
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.btnRoute = new System.Windows.Forms.ToolStripButton();
            this.btnSchedule = new System.Windows.Forms.ToolStripButton();
            this.btnPort = new System.Windows.Forms.ToolStripButton();
            this.btnRoutePhoto = new System.Windows.Forms.ToolStripButton();
            this.btnExit = new System.Windows.Forms.ToolStripButton();
            this.toolStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip2
            // 
            this.toolStrip2.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnRoute,
            this.btnSchedule,
            this.btnPort,
            this.btnRoutePhoto,
            this.btnExit});
            this.toolStrip2.Location = new System.Drawing.Point(0, 0);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(800, 39);
            this.toolStrip2.TabIndex = 1;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // btnRoute
            // 
            this.btnRoute.Image = ((System.Drawing.Image)(resources.GetObject("btnRoute.Image")));
            this.btnRoute.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnRoute.Name = "btnRoute";
            this.btnRoute.Size = new System.Drawing.Size(91, 36);
            this.btnRoute.Text = "航線管理";
            this.btnRoute.Click += new System.EventHandler(this.btnRoute_Click);
            // 
            // btnSchedule
            // 
            this.btnSchedule.Image = ((System.Drawing.Image)(resources.GetObject("btnSchedule.Image")));
            this.btnSchedule.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSchedule.Name = "btnSchedule";
            this.btnSchedule.Size = new System.Drawing.Size(91, 36);
            this.btnSchedule.Text = "航班管理";
            this.btnSchedule.Click += new System.EventHandler(this.btnSchedule_Click);
            // 
            // btnPort
            // 
            this.btnPort.Image = ((System.Drawing.Image)(resources.GetObject("btnPort.Image")));
            this.btnPort.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnPort.Name = "btnPort";
            this.btnPort.Size = new System.Drawing.Size(91, 36);
            this.btnPort.Text = "港口管理";
            this.btnPort.Click += new System.EventHandler(this.btnPort_Click);
            // 
            // btnRoutePhoto
            // 
            this.btnRoutePhoto.Image = ((System.Drawing.Image)(resources.GetObject("btnRoutePhoto.Image")));
            this.btnRoutePhoto.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnRoutePhoto.Name = "btnRoutePhoto";
            this.btnRoutePhoto.Size = new System.Drawing.Size(91, 36);
            this.btnRoutePhoto.Text = "圖片管理";
            this.btnRoutePhoto.Click += new System.EventHandler(this.btnRoutePhoto_Click);
            // 
            // btnExit
            // 
            this.btnExit.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.Image")));
            this.btnExit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(67, 36);
            this.btnExit.Text = "離開";
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // FrmShip
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.toolStrip2);
            this.Name = "FrmShip";
            this.Text = "船票系統";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripButton btnRoutePhoto;
        private System.Windows.Forms.ToolStripButton btnSchedule;
        private System.Windows.Forms.ToolStripButton btnRoute;
        private System.Windows.Forms.ToolStripButton btnPort;
        private System.Windows.Forms.ToolStripButton btnExit;
    }
}