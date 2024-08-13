namespace slnJapanTravel.View
{
    partial class FrmTicketCart
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmTicketCart));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblDestination = new System.Windows.Forms.Label();
            this.lblStarting = new System.Windows.Forms.Label();
            this.cbDestination = new System.Windows.Forms.ComboBox();
            this.port港口BindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.japanTravelDataSet = new slnJapanTravel.JapanTravelDataSet();
            this.cbStarting = new System.Windows.Forms.ComboBox();
            this.port港口BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txtKeyword = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cbPaymentMethods = new System.Windows.Forms.ComboBox();
            this.c付款方式BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.付款方式BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lblPaymentMethod = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.fbQuantity = new prjCustomerSystem.FieldBox();
            this.fbMemberId = new prjCustomerSystem.FieldBox();
            this.lblTicket = new System.Windows.Forms.Label();
            this.port港口TableAdapter = new slnJapanTravel.JapanTravelDataSetTableAdapters.Port港口TableAdapter();
            this.付款方式TableAdapter = new slnJapanTravel.JapanTravelDataSetTableAdapters.付款方式TableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.port港口BindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.japanTravelDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.port港口BindingSource)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.c付款方式BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.付款方式BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(4);
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
            this.splitContainer1.Panel2.Controls.Add(this.panel3);
            this.splitContainer1.Panel2.Controls.Add(this.dataGridView1);
            this.splitContainer1.Panel2.Controls.Add(this.panel2);
            this.splitContainer1.Panel2.Controls.Add(this.lblTicket);
            this.splitContainer1.Size = new System.Drawing.Size(1419, 854);
            this.splitContainer1.SplitterDistance = 759;
            this.splitContainer1.SplitterWidth = 6;
            this.splitContainer1.TabIndex = 0;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 219);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(759, 635);
            this.flowLayoutPanel1.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.PowderBlue;
            this.panel1.Controls.Add(this.lblDestination);
            this.panel1.Controls.Add(this.lblStarting);
            this.panel1.Controls.Add(this.cbDestination);
            this.panel1.Controls.Add(this.cbStarting);
            this.panel1.Controls.Add(this.txtKeyword);
            this.panel1.Controls.Add(this.btnSearch);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 135);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(759, 84);
            this.panel1.TabIndex = 1;
            // 
            // lblDestination
            // 
            this.lblDestination.AutoSize = true;
            this.lblDestination.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblDestination.Location = new System.Drawing.Point(223, 29);
            this.lblDestination.Name = "lblDestination";
            this.lblDestination.Size = new System.Drawing.Size(62, 31);
            this.lblDestination.TabIndex = 9;
            this.lblDestination.Text = "目的";
            // 
            // lblStarting
            // 
            this.lblStarting.AutoSize = true;
            this.lblStarting.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblStarting.Location = new System.Drawing.Point(12, 31);
            this.lblStarting.Name = "lblStarting";
            this.lblStarting.Size = new System.Drawing.Size(62, 31);
            this.lblStarting.TabIndex = 8;
            this.lblStarting.Text = "出發";
            // 
            // cbDestination
            // 
            this.cbDestination.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.port港口BindingSource1, "PortID港口ID", true));
            this.cbDestination.DataSource = this.port港口BindingSource1;
            this.cbDestination.DisplayMember = "PortName港口名稱";
            this.cbDestination.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.cbDestination.FormattingEnabled = true;
            this.cbDestination.Location = new System.Drawing.Point(292, 21);
            this.cbDestination.Margin = new System.Windows.Forms.Padding(4);
            this.cbDestination.Name = "cbDestination";
            this.cbDestination.Size = new System.Drawing.Size(130, 44);
            this.cbDestination.TabIndex = 7;
            this.cbDestination.ValueMember = "PortID港口ID";
            // 
            // port港口BindingSource1
            // 
            this.port港口BindingSource1.DataMember = "Port港口";
            this.port港口BindingSource1.DataSource = this.japanTravelDataSet;
            // 
            // japanTravelDataSet
            // 
            this.japanTravelDataSet.DataSetName = "JapanTravelDataSet";
            this.japanTravelDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cbStarting
            // 
            this.cbStarting.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.port港口BindingSource, "PortID港口ID", true));
            this.cbStarting.DataSource = this.port港口BindingSource;
            this.cbStarting.DisplayMember = "PortName港口名稱";
            this.cbStarting.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.cbStarting.FormattingEnabled = true;
            this.cbStarting.Location = new System.Drawing.Point(79, 21);
            this.cbStarting.Margin = new System.Windows.Forms.Padding(4);
            this.cbStarting.Name = "cbStarting";
            this.cbStarting.Size = new System.Drawing.Size(130, 44);
            this.cbStarting.TabIndex = 6;
            this.cbStarting.ValueMember = "PortID港口ID";
            // 
            // port港口BindingSource
            // 
            this.port港口BindingSource.DataMember = "Port港口";
            this.port港口BindingSource.DataSource = this.japanTravelDataSet;
            // 
            // txtKeyword
            // 
            this.txtKeyword.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtKeyword.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtKeyword.Location = new System.Drawing.Point(457, 20);
            this.txtKeyword.Margin = new System.Windows.Forms.Padding(4);
            this.txtKeyword.Name = "txtKeyword";
            this.txtKeyword.Size = new System.Drawing.Size(209, 45);
            this.txtKeyword.TabIndex = 1;
            this.txtKeyword.Text = "關鍵字";
            this.txtKeyword.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtKeyword.Click += new System.EventHandler(this.txtKeyword_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSearch.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnSearch.Image = ((System.Drawing.Image)(resources.GetObject("btnSearch.Image")));
            this.btnSearch.Location = new System.Drawing.Point(674, 11);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(4);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(63, 63);
            this.btnSearch.TabIndex = 0;
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.SkyBlue;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(759, 135);
            this.label1.TabIndex = 0;
            this.label1.Text = "購物車";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.button4);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 748);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(654, 106);
            this.panel3.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("微軟正黑體", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(537, 106);
            this.label2.TabIndex = 0;
            this.label2.Text = "$0";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // button4
            // 
            this.button4.Dock = System.Windows.Forms.DockStyle.Right;
            this.button4.Font = new System.Drawing.Font("微軟正黑體", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button4.Location = new System.Drawing.Point(537, 0);
            this.button4.Margin = new System.Windows.Forms.Padding(4);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(117, 106);
            this.button4.TabIndex = 1;
            this.button4.Text = "結帳";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 264);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(654, 590);
            this.dataGridView1.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.PowderBlue;
            this.panel2.Controls.Add(this.cbPaymentMethods);
            this.panel2.Controls.Add(this.lblPaymentMethod);
            this.panel2.Controls.Add(this.btnDelete);
            this.panel2.Controls.Add(this.btnAdd);
            this.panel2.Controls.Add(this.fbQuantity);
            this.panel2.Controls.Add(this.fbMemberId);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 120);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(654, 144);
            this.panel2.TabIndex = 1;
            // 
            // cbPaymentMethods
            // 
            this.cbPaymentMethods.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbPaymentMethods.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.c付款方式BindingSource, "付款方式編號", true));
            this.cbPaymentMethods.DataSource = this.付款方式BindingSource;
            this.cbPaymentMethods.DisplayMember = "付款方式";
            this.cbPaymentMethods.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPaymentMethods.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.cbPaymentMethods.FormattingEnabled = true;
            this.cbPaymentMethods.Location = new System.Drawing.Point(96, 90);
            this.cbPaymentMethods.Margin = new System.Windows.Forms.Padding(4);
            this.cbPaymentMethods.Name = "cbPaymentMethods";
            this.cbPaymentMethods.Size = new System.Drawing.Size(296, 38);
            this.cbPaymentMethods.TabIndex = 5;
            this.cbPaymentMethods.ValueMember = "付款方式編號";
            // 
            // c付款方式BindingSource
            // 
            this.c付款方式BindingSource.DataSource = typeof(slnJapanTravel.Model.C付款方式);
            // 
            // 付款方式BindingSource
            // 
            this.付款方式BindingSource.DataMember = "付款方式";
            this.付款方式BindingSource.DataSource = this.japanTravelDataSet;
            // 
            // lblPaymentMethod
            // 
            this.lblPaymentMethod.AutoSize = true;
            this.lblPaymentMethod.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblPaymentMethod.Location = new System.Drawing.Point(7, 95);
            this.lblPaymentMethod.Name = "lblPaymentMethod";
            this.lblPaymentMethod.Size = new System.Drawing.Size(109, 30);
            this.lblPaymentMethod.TabIndex = 7;
            this.lblPaymentMethod.Text = "付款方式";
            // 
            // btnDelete
            // 
            this.btnDelete.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnDelete.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnDelete.Location = new System.Drawing.Point(402, 76);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(126, 68);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "刪除";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            this.btnAdd.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnAdd.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnAdd.Location = new System.Drawing.Point(528, 76);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(126, 68);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "新增";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // fbQuantity
            // 
            this.fbQuantity.Dock = System.Windows.Forms.DockStyle.Top;
            this.fbQuantity.fieldName = "數　　量";
            this.fbQuantity.fieldValue = "1";
            this.fbQuantity.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.fbQuantity.Location = new System.Drawing.Point(0, 38);
            this.fbQuantity.Margin = new System.Windows.Forms.Padding(8);
            this.fbQuantity.Name = "fbQuantity";
            this.fbQuantity.Size = new System.Drawing.Size(654, 38);
            this.fbQuantity.TabIndex = 4;
            // 
            // fbMemberId
            // 
            this.fbMemberId.Dock = System.Windows.Forms.DockStyle.Top;
            this.fbMemberId.fieldName = "會員編號";
            this.fbMemberId.fieldValue = "";
            this.fbMemberId.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.fbMemberId.Location = new System.Drawing.Point(0, 0);
            this.fbMemberId.Margin = new System.Windows.Forms.Padding(8);
            this.fbMemberId.Name = "fbMemberId";
            this.fbMemberId.Size = new System.Drawing.Size(654, 38);
            this.fbMemberId.TabIndex = 0;
            // 
            // lblTicket
            // 
            this.lblTicket.BackColor = System.Drawing.Color.PowderBlue;
            this.lblTicket.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTicket.Font = new System.Drawing.Font("微軟正黑體", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblTicket.Location = new System.Drawing.Point(0, 0);
            this.lblTicket.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTicket.Name = "lblTicket";
            this.lblTicket.Size = new System.Drawing.Size(654, 120);
            this.lblTicket.TabIndex = 0;
            this.lblTicket.Text = "商品名稱";
            this.lblTicket.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // port港口TableAdapter
            // 
            this.port港口TableAdapter.ClearBeforeFill = true;
            // 
            // 付款方式TableAdapter
            // 
            this.付款方式TableAdapter.ClearBeforeFill = true;
            // 
            // FrmTicketCart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1419, 854);
            this.Controls.Add(this.splitContainer1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmTicketCart";
            this.Text = "船票購物車";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmTicketCart_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.port港口BindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.japanTravelDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.port港口BindingSource)).EndInit();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.c付款方式BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.付款方式BindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtKeyword;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label lblTicket;
        private System.Windows.Forms.Panel panel2;
        private prjCustomerSystem.FieldBox fbMemberId;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbPaymentMethods;
        private prjCustomerSystem.FieldBox fbQuantity;
        private System.Windows.Forms.BindingSource c付款方式BindingSource;
        private System.Windows.Forms.Label lblDestination;
        private System.Windows.Forms.Label lblStarting;
        private System.Windows.Forms.ComboBox cbDestination;
        private System.Windows.Forms.ComboBox cbStarting;
        private System.Windows.Forms.Label lblPaymentMethod;
        private JapanTravelDataSet japanTravelDataSet;
        private System.Windows.Forms.BindingSource port港口BindingSource;
        private JapanTravelDataSetTableAdapters.Port港口TableAdapter port港口TableAdapter;
        private System.Windows.Forms.BindingSource port港口BindingSource1;
        private System.Windows.Forms.BindingSource 付款方式BindingSource;
        private JapanTravelDataSetTableAdapters.付款方式TableAdapter 付款方式TableAdapter;
    }
}