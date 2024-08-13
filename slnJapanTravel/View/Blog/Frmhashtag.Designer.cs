namespace slnJapanTravel.View.Blog
{
    partial class Frmhashtag
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frmhashtag));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnhtadd = new System.Windows.Forms.ToolStripButton();
            this.btnhtedit = new System.Windows.Forms.ToolStripButton();
            this.btnhtdelete = new System.Windows.Forms.ToolStripButton();
            this.btnhtclose = new System.Windows.Forms.ToolStripButton();
            this.btnhtsearch = new System.Windows.Forms.ToolStripButton();
            this.txtsearch = new System.Windows.Forms.ToolStripTextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.DarkGray;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnhtadd,
            this.btnhtedit,
            this.btnhtdelete,
            this.btnhtclose,
            this.btnhtsearch,
            this.txtsearch});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 39);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnhtadd
            // 
            this.btnhtadd.Image = ((System.Drawing.Image)(resources.GetObject("btnhtadd.Image")));
            this.btnhtadd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnhtadd.Name = "btnhtadd";
            this.btnhtadd.Size = new System.Drawing.Size(75, 36);
            this.btnhtadd.Text = "新增";
            this.btnhtadd.Click += new System.EventHandler(this.btnhtadd_Click);
            // 
            // btnhtedit
            // 
            this.btnhtedit.Image = ((System.Drawing.Image)(resources.GetObject("btnhtedit.Image")));
            this.btnhtedit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnhtedit.Name = "btnhtedit";
            this.btnhtedit.Size = new System.Drawing.Size(75, 36);
            this.btnhtedit.Text = "修改";
            // 
            // btnhtdelete
            // 
            this.btnhtdelete.Image = ((System.Drawing.Image)(resources.GetObject("btnhtdelete.Image")));
            this.btnhtdelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnhtdelete.Name = "btnhtdelete";
            this.btnhtdelete.Size = new System.Drawing.Size(75, 36);
            this.btnhtdelete.Text = "刪除";
            // 
            // btnhtclose
            // 
            this.btnhtclose.Image = ((System.Drawing.Image)(resources.GetObject("btnhtclose.Image")));
            this.btnhtclose.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnhtclose.Name = "btnhtclose";
            this.btnhtclose.Size = new System.Drawing.Size(75, 36);
            this.btnhtclose.Text = "關閉";
            this.btnhtclose.Click += new System.EventHandler(this.btnhtclose_Click);
            // 
            // btnhtsearch
            // 
            this.btnhtsearch.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btnhtsearch.Image = ((System.Drawing.Image)(resources.GetObject("btnhtsearch.Image")));
            this.btnhtsearch.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnhtsearch.Name = "btnhtsearch";
            this.btnhtsearch.Size = new System.Drawing.Size(75, 36);
            this.btnhtsearch.Text = "查詢";
            // 
            // txtsearch
            // 
            this.txtsearch.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.txtsearch.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9F);
            this.txtsearch.Name = "txtsearch";
            this.txtsearch.Size = new System.Drawing.Size(100, 39);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 39);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 27;
            this.dataGridView1.Size = new System.Drawing.Size(800, 411);
            this.dataGridView1.TabIndex = 2;
            // 
            // Frmhashtag
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "Frmhashtag";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frmhashtag";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Frmhashtag_FormClosed);
            this.Load += new System.EventHandler(this.Frmhashtag_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnhtadd;
        private System.Windows.Forms.ToolStripButton btnhtedit;
        private System.Windows.Forms.ToolStripButton btnhtdelete;
        private System.Windows.Forms.ToolStripButton btnhtclose;
        private System.Windows.Forms.ToolStripButton btnhtsearch;
        private System.Windows.Forms.ToolStripTextBox txtsearch;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}