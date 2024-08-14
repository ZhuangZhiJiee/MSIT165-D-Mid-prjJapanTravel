namespace slnJapanTravel.View
{
    partial class FrmItineraryCart
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmItineraryCart));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblTheme = new System.Windows.Forms.Label();
            this.lblArea = new System.Windows.Forms.Label();
            this.cbArea = new System.Windows.Forms.ComboBox();
            this.area地區BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.japanTravelDataSet = new slnJapanTravel.JapanTravelDataSet();
            this.cbTheme = new System.Windows.Forms.ComboBox();
            this.theme主題BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtKeyword = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cbPaymentMethod = new System.Windows.Forms.ComboBox();
            this.付款方式BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lblPaymentMethod = new System.Windows.Forms.Label();
            this.fbQuantity = new prjCustomerSystem.FieldBox();
            this.fbMemberId = new prjCustomerSystem.FieldBox();
            this.label2 = new System.Windows.Forms.Label();
            this.theme主題TableAdapter = new slnJapanTravel.JapanTravelDataSetTableAdapters.Theme主題TableAdapter();
            this.area地區TableAdapter = new slnJapanTravel.JapanTravelDataSetTableAdapters.Area地區TableAdapter();
            this.付款方式TableAdapter = new slnJapanTravel.JapanTravelDataSetTableAdapters.付款方式TableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.area地區BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.japanTravelDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.theme主題BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.付款方式BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.flowLayoutPanel1);
            this.splitContainer1.Panel1.Controls.Add(this.panel1);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dataGridView1);
            this.splitContainer1.Panel2.Controls.Add(this.panel3);
            this.splitContainer1.Panel2.Controls.Add(this.panel2);
            this.splitContainer1.Panel2.Controls.Add(this.label2);
            this.splitContainer1.Size = new System.Drawing.Size(944, 566);
            this.splitContainer1.SplitterDistance = 528;
            this.splitContainer1.TabIndex = 0;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 157);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(528, 409);
            this.flowLayoutPanel1.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.PowderBlue;
            this.panel1.Controls.Add(this.lblTheme);
            this.panel1.Controls.Add(this.lblArea);
            this.panel1.Controls.Add(this.cbArea);
            this.panel1.Controls.Add(this.cbTheme);
            this.panel1.Controls.Add(this.btnSearch);
            this.panel1.Controls.Add(this.txtKeyword);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 90);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(528, 67);
            this.panel1.TabIndex = 1;
            // 
            // lblTheme
            // 
            this.lblTheme.AutoSize = true;
            this.lblTheme.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblTheme.Location = new System.Drawing.Point(7, 24);
            this.lblTheme.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTheme.Name = "lblTheme";
            this.lblTheme.Size = new System.Drawing.Size(42, 21);
            this.lblTheme.TabIndex = 6;
            this.lblTheme.Text = "主題";
            // 
            // lblArea
            // 
            this.lblArea.AutoSize = true;
            this.lblArea.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblArea.Location = new System.Drawing.Point(148, 23);
            this.lblArea.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblArea.Name = "lblArea";
            this.lblArea.Size = new System.Drawing.Size(42, 21);
            this.lblArea.TabIndex = 7;
            this.lblArea.Text = "地區";
            // 
            // cbArea
            // 
            this.cbArea.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.area地區BindingSource, "地區編號", true));
            this.cbArea.DataSource = this.area地區BindingSource;
            this.cbArea.DisplayMember = "地區名稱";
            this.cbArea.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.cbArea.FormattingEnabled = true;
            this.cbArea.Location = new System.Drawing.Point(193, 20);
            this.cbArea.Name = "cbArea";
            this.cbArea.Size = new System.Drawing.Size(87, 28);
            this.cbArea.TabIndex = 4;
            this.cbArea.ValueMember = "地區編號";
            // 
            // area地區BindingSource
            // 
            this.area地區BindingSource.DataMember = "Area地區";
            this.area地區BindingSource.DataSource = this.japanTravelDataSet;
            // 
            // japanTravelDataSet
            // 
            this.japanTravelDataSet.DataSetName = "JapanTravelDataSet";
            this.japanTravelDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cbTheme
            // 
            this.cbTheme.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.theme主題BindingSource, "主題編號", true));
            this.cbTheme.DataSource = this.theme主題BindingSource;
            this.cbTheme.DisplayMember = "主題名稱";
            this.cbTheme.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.cbTheme.FormattingEnabled = true;
            this.cbTheme.Location = new System.Drawing.Point(49, 21);
            this.cbTheme.Name = "cbTheme";
            this.cbTheme.Size = new System.Drawing.Size(87, 28);
            this.cbTheme.TabIndex = 5;
            this.cbTheme.ValueMember = "主題編號";
            // 
            // theme主題BindingSource
            // 
            this.theme主題BindingSource.DataMember = "Theme主題";
            this.theme主題BindingSource.DataSource = this.japanTravelDataSet;
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSearch.Image = ((System.Drawing.Image)(resources.GetObject("btnSearch.Image")));
            this.btnSearch.Location = new System.Drawing.Point(470, 13);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(42, 42);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // txtKeyword
            // 
            this.txtKeyword.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtKeyword.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtKeyword.Location = new System.Drawing.Point(295, 19);
            this.txtKeyword.Name = "txtKeyword";
            this.txtKeyword.Size = new System.Drawing.Size(172, 33);
            this.txtKeyword.TabIndex = 1;
            this.txtKeyword.Text = "關鍵字";
            this.txtKeyword.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtKeyword.Click += new System.EventHandler(this.txtKeyword_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.SkyBlue;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(528, 90);
            this.label1.TabIndex = 0;
            this.label1.Text = "購物車";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 166);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(412, 330);
            this.dataGridView1.TabIndex = 3;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.button2);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 496);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(412, 70);
            this.panel3.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Font = new System.Drawing.Font("微軟正黑體", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(343, 70);
            this.label3.TabIndex = 1;
            this.label3.Text = "$0";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // button2
            // 
            this.button2.Dock = System.Windows.Forms.DockStyle.Right;
            this.button2.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button2.Location = new System.Drawing.Point(343, 0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(69, 70);
            this.button2.TabIndex = 0;
            this.button2.Text = "結帳";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.PowderBlue;
            this.panel2.Controls.Add(this.cbPaymentMethod);
            this.panel2.Controls.Add(this.lblPaymentMethod);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 68);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(412, 98);
            this.panel2.TabIndex = 1;
            // 
            // cbPaymentMethod
            // 
            this.cbPaymentMethod.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.付款方式BindingSource, "付款方式編號", true));
            this.cbPaymentMethod.DataSource = this.付款方式BindingSource;
            this.cbPaymentMethod.DisplayMember = "付款方式";
            this.cbPaymentMethod.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbPaymentMethod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPaymentMethod.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.cbPaymentMethod.FormattingEnabled = true;
            this.cbPaymentMethod.Location = new System.Drawing.Point(73, 0);
            this.cbPaymentMethod.Margin = new System.Windows.Forms.Padding(4);
            this.cbPaymentMethod.Name = "cbPaymentMethod";
            this.cbPaymentMethod.Size = new System.Drawing.Size(339, 28);
            this.cbPaymentMethod.TabIndex = 2;
            this.cbPaymentMethod.ValueMember = "付款方式編號";
            // 
            // 付款方式BindingSource
            // 
            this.付款方式BindingSource.DataMember = "付款方式";
            this.付款方式BindingSource.DataSource = this.japanTravelDataSet;
            // 
            // lblPaymentMethod
            // 
            this.lblPaymentMethod.AutoSize = true;
            this.lblPaymentMethod.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblPaymentMethod.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblPaymentMethod.Location = new System.Drawing.Point(0, 64);
            this.lblPaymentMethod.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPaymentMethod.Name = "lblPaymentMethod";
            this.lblPaymentMethod.Size = new System.Drawing.Size(73, 20);
            this.lblPaymentMethod.TabIndex = 4;
            this.lblPaymentMethod.Text = "付款方式";
            // 
            // fbQuantity
            // 
            this.fbQuantity.Dock = System.Windows.Forms.DockStyle.Top;
            this.fbQuantity.fieldName = "數　　量";
            this.fbQuantity.fieldValue = "1";
            this.fbQuantity.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.fbQuantity.Location = new System.Drawing.Point(0, 32);
            this.fbQuantity.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.fbQuantity.Name = "fbQuantity";
            this.fbQuantity.Size = new System.Drawing.Size(412, 32);
            this.fbQuantity.TabIndex = 1;
            // 
            // fbMemberId
            this.lblPaymentMethod.AutoSize = true;
            this.lblPaymentMethod.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblPaymentMethod.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblPaymentMethod.Location = new System.Drawing.Point(0, 0);
            this.lblPaymentMethod.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPaymentMethod.Name = "lblPaymentMethod";
            this.lblPaymentMethod.Size = new System.Drawing.Size(73, 20);
            this.lblPaymentMethod.TabIndex = 4;
            this.lblPaymentMethod.Text = "付款方式";
            this.fbMemberId.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.PowderBlue;
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Font = new System.Drawing.Font("微軟正黑體", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(412, 68);
            this.label2.TabIndex = 0;
            this.label2.Text = "行程名稱";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // theme主題TableAdapter
            // 
            this.theme主題TableAdapter.ClearBeforeFill = true;
            // 
            // area地區TableAdapter
            // 
            this.area地區TableAdapter.ClearBeforeFill = true;
            // 
            // 付款方式TableAdapter
            // 
            this.付款方式TableAdapter.ClearBeforeFill = true;
            // 
            // FrmItineraryCart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(944, 566);
            this.Controls.Add(this.splitContainer1);
            this.Name = "FrmItineraryCart";
            this.Text = "行程購物車";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmItineraryCart_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.area地區BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.japanTravelDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.theme主題BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.付款方式BindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtKeyword;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private prjCustomerSystem.FieldBox fbMemberId;
        private prjCustomerSystem.FieldBox fbQuantity;
        private System.Windows.Forms.ComboBox cbPaymentMethod;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lblTheme;
        private System.Windows.Forms.Label lblArea;
        private System.Windows.Forms.ComboBox cbArea;
        private System.Windows.Forms.ComboBox cbTheme;
        private System.Windows.Forms.Label lblPaymentMethod;
        private JapanTravelDataSet japanTravelDataSet;
        private System.Windows.Forms.BindingSource theme主題BindingSource;
        private JapanTravelDataSetTableAdapters.Theme主題TableAdapter theme主題TableAdapter;
        private System.Windows.Forms.BindingSource area地區BindingSource;
        private JapanTravelDataSetTableAdapters.Area地區TableAdapter area地區TableAdapter;
        private System.Windows.Forms.BindingSource 付款方式BindingSource;
        private JapanTravelDataSetTableAdapters.付款方式TableAdapter 付款方式TableAdapter;
    }
}