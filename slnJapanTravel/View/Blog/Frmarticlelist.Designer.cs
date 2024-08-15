namespace slnJapanTravel.View.Blog
{
    partial class Frmarticlelist
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frmarticlelist));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnhtadd = new System.Windows.Forms.ToolStripButton();
            this.btnhtedit = new System.Windows.Forms.ToolStripButton();
            this.btnhtdelete = new System.Windows.Forms.ToolStripButton();
            this.btnhtclose = new System.Windows.Forms.ToolStripButton();
            this.btnkysearch = new System.Windows.Forms.ToolStripButton();
            this.txtkysearch = new System.Windows.Forms.ToolStripTextBox();
            this.dateTimePickerstart = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerend = new System.Windows.Forms.DateTimePicker();
            this.lbldaystart = new System.Windows.Forms.Label();
            this.lblend = new System.Windows.Forms.Label();
            this.btndaysearch = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.toolStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
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
            this.btnkysearch,
            this.txtkysearch});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 39);
            this.toolStrip1.TabIndex = 3;
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
            this.btnhtdelete.Click += new System.EventHandler(this.btnhtdelete_Click);
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
            // btnkysearch
            // 
            this.btnkysearch.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btnkysearch.Image = ((System.Drawing.Image)(resources.GetObject("btnkysearch.Image")));
            this.btnkysearch.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnkysearch.Name = "btnkysearch";
            this.btnkysearch.Size = new System.Drawing.Size(75, 36);
            this.btnkysearch.Text = "查詢";
            this.btnkysearch.Click += new System.EventHandler(this.btnkysearch_Click);
            // 
            // txtkysearch
            // 
            this.txtkysearch.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.txtkysearch.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9F);
            this.txtkysearch.Name = "txtkysearch";
            this.txtkysearch.Size = new System.Drawing.Size(76, 39);
            this.txtkysearch.Text = "輸入關鍵字";
            // 
            // dateTimePickerstart
            // 
            this.dateTimePickerstart.Location = new System.Drawing.Point(149, 7);
            this.dateTimePickerstart.Name = "dateTimePickerstart";
            this.dateTimePickerstart.Size = new System.Drawing.Size(185, 22);
            this.dateTimePickerstart.TabIndex = 4;
            // 
            // dateTimePickerend
            // 
            this.dateTimePickerend.Location = new System.Drawing.Point(446, 7);
            this.dateTimePickerend.Name = "dateTimePickerend";
            this.dateTimePickerend.Size = new System.Drawing.Size(185, 22);
            this.dateTimePickerend.TabIndex = 5;
            // 
            // lbldaystart
            // 
            this.lbldaystart.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbldaystart.Location = new System.Drawing.Point(43, 0);
            this.lbldaystart.Name = "lbldaystart";
            this.lbldaystart.Size = new System.Drawing.Size(100, 35);
            this.lbldaystart.TabIndex = 6;
            this.lbldaystart.Text = "開始日期";
            this.lbldaystart.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbldaystart.Click += new System.EventHandler(this.lbldaystart_Click);
            // 
            // lblend
            // 
            this.lblend.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblend.Location = new System.Drawing.Point(340, 0);
            this.lblend.Name = "lblend";
            this.lblend.Size = new System.Drawing.Size(100, 35);
            this.lblend.TabIndex = 7;
            this.lblend.Text = "結束日期";
            this.lblend.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btndaysearch
            // 
            this.btndaysearch.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btndaysearch.Location = new System.Drawing.Point(637, 0);
            this.btndaysearch.Name = "btndaysearch";
            this.btndaysearch.Size = new System.Drawing.Size(96, 35);
            this.btndaysearch.TabIndex = 8;
            this.btndaysearch.Text = "查詢";
            this.btndaysearch.UseVisualStyleBackColor = true;
            this.btndaysearch.Click += new System.EventHandler(this.btndaysearch_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblend);
            this.panel1.Controls.Add(this.lbldaystart);
            this.panel1.Controls.Add(this.dateTimePickerend);
            this.panel1.Controls.Add(this.dateTimePickerstart);
            this.panel1.Controls.Add(this.btndaysearch);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 39);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 36);
            this.panel1.TabIndex = 9;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint_1);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView1.Location = new System.Drawing.Point(0, 81);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(800, 369);
            this.dataGridView1.TabIndex = 10;
            this.dataGridView1.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_RowEnter);
            // 
            // Frmarticlelist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "Frmarticlelist";
            this.Text = "Frmarticlelist";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Frmarticlelist_FormClosed);
            this.Load += new System.EventHandler(this.Frmarticlelist_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
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
        private System.Windows.Forms.ToolStripButton btnkysearch;
        private System.Windows.Forms.ToolStripTextBox txtkysearch;
        private System.Windows.Forms.DateTimePicker dateTimePickerstart;
        private System.Windows.Forms.DateTimePicker dateTimePickerend;
        private System.Windows.Forms.Label lbldaystart;
        private System.Windows.Forms.Label lblend;
        private System.Windows.Forms.Button btndaysearch;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}