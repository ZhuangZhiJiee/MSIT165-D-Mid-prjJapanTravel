namespace slnJapanTravel.View.Blog
{
    partial class Frmarticleedit
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
            this.lbltitle = new System.Windows.Forms.Label();
            this.txttitle = new System.Windows.Forms.TextBox();
            this.lbllaunchtime = new System.Windows.Forms.Label();
            this.lblstatus = new System.Windows.Forms.Label();
            this.lbllaunchtime1 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txttitle);
            this.panel1.Controls.Add(this.lbltitle);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 55);
            this.panel1.TabIndex = 0;
            // 
            // lbltitle
            // 
            this.lbltitle.Dock = System.Windows.Forms.DockStyle.Left;
            this.lbltitle.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbltitle.Location = new System.Drawing.Point(0, 0);
            this.lbltitle.Name = "lbltitle";
            this.lbltitle.Size = new System.Drawing.Size(106, 55);
            this.lbltitle.TabIndex = 0;
            this.lbltitle.Text = "文章標題";
            this.lbltitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txttitle
            // 
            this.txttitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txttitle.Location = new System.Drawing.Point(106, 0);
            this.txttitle.Multiline = true;
            this.txttitle.Name = "txttitle";
            this.txttitle.Size = new System.Drawing.Size(694, 55);
            this.txttitle.TabIndex = 1;
            // 
            // lbllaunchtime
            // 
            this.lbllaunchtime.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbllaunchtime.Location = new System.Drawing.Point(546, 58);
            this.lbllaunchtime.Name = "lbllaunchtime";
            this.lbllaunchtime.Size = new System.Drawing.Size(194, 40);
            this.lbllaunchtime.TabIndex = 0;
            this.lbllaunchtime.Text = "發布時間";
            this.lbllaunchtime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblstatus
            // 
            this.lblstatus.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblstatus.Location = new System.Drawing.Point(546, 150);
            this.lblstatus.Name = "lblstatus";
            this.lblstatus.Size = new System.Drawing.Size(204, 40);
            this.lblstatus.TabIndex = 2;
            this.lblstatus.Text = "文章狀態";
            this.lblstatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblstatus.Click += new System.EventHandler(this.lblstatus_Click);
            // 
            // lbllaunchtime1
            // 
            this.lbllaunchtime1.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbllaunchtime1.Location = new System.Drawing.Point(590, 98);
            this.lbllaunchtime1.Name = "lbllaunchtime1";
            this.lbllaunchtime1.Size = new System.Drawing.Size(112, 52);
            this.lbllaunchtime1.TabIndex = 3;
            this.lbllaunchtime1.Text = "時間顯示";
            this.lbllaunchtime1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbllaunchtime1.Click += new System.EventHandler(this.lbllaunchtime1_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 55);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(469, 395);
            this.flowLayoutPanel1.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(546, 216);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(204, 40);
            this.label2.TabIndex = 6;
            this.label2.Text = "hashtag";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(533, 277);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(233, 20);
            this.comboBox1.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(543, 386);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(108, 49);
            this.button1.TabIndex = 9;
            this.button1.Text = "確定";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(657, 386);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(108, 49);
            this.button2.TabIndex = 10;
            this.button2.Text = "取消";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(550, 193);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(199, 20);
            this.comboBox2.TabIndex = 11;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 12;
            this.listBox1.Location = new System.Drawing.Point(507, 318);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(279, 52);
            this.listBox1.TabIndex = 12;
            // 
            // Frmarticleedit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.lbllaunchtime1);
            this.Controls.Add(this.lbllaunchtime);
            this.Controls.Add(this.lblstatus);
            this.Controls.Add(this.panel1);
            this.Name = "Frmarticleedit";
            this.Text = "Frmarticleedit";
            this.Load += new System.EventHandler(this.Frmarticleedit_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txttitle;
        private System.Windows.Forms.Label lbltitle;
        private System.Windows.Forms.Label lbllaunchtime;
        private System.Windows.Forms.Label lblstatus;
        private System.Windows.Forms.Label lbllaunchtime1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ListBox listBox1;
    }
}