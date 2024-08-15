namespace slnJapanTravel.View
{
    partial class FrmTicketOrderEditor
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOk = new System.Windows.Forms.Button();
            this.cbOrderStatusId = new System.Windows.Forms.ComboBox();
            this.訂單狀態BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.japanTravelDataSet3 = new slnJapanTravel.JapanTravelDataSet3();
            this.lblOrderStatusId = new System.Windows.Forms.Label();
            this.cbPaymentStatusId = new System.Windows.Forms.ComboBox();
            this.付款狀態BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lblPaymentStatusId = new System.Windows.Forms.Label();
            this.cbPaymentMethodId = new System.Windows.Forms.ComboBox();
            this.付款方式BindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.lblPaymentMethodId = new System.Windows.Forms.Label();
            this.fbRemark = new prjCustomerSystem.FieldBox();
            this.fbAmount = new prjCustomerSystem.FieldBox();
            this.fbMemberId = new prjCustomerSystem.FieldBox();
            this.japanTravelDataSet = new slnJapanTravel.JapanTravelDataSet();
            this.付款方式BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.付款方式TableAdapter = new slnJapanTravel.JapanTravelDataSetTableAdapters.付款方式TableAdapter();
            this.付款方式TableAdapter1 = new slnJapanTravel.JapanTravelDataSet3TableAdapters.付款方式TableAdapter();
            this.付款狀態TableAdapter = new slnJapanTravel.JapanTravelDataSet3TableAdapters.付款狀態TableAdapter();
            this.付款狀態BindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.訂單狀態TableAdapter = new slnJapanTravel.JapanTravelDataSet3TableAdapters.訂單狀態TableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.訂單狀態BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.japanTravelDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.付款狀態BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.付款方式BindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.japanTravelDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.付款方式BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.付款狀態BindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(69, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(284, 76);
            this.label1.TabIndex = 32;
            this.label1.Text = "訂單管理";
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnCancel.Location = new System.Drawing.Point(251, 463);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(212, 66);
            this.btnCancel.TabIndex = 31;
            this.btnCancel.Text = "取消";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnOk
            // 
            this.btnOk.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnOk.Location = new System.Drawing.Point(516, 463);
            this.btnOk.Margin = new System.Windows.Forms.Padding(4);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(212, 66);
            this.btnOk.TabIndex = 30;
            this.btnOk.Text = "新增";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // cbOrderStatusId
            // 
            this.cbOrderStatusId.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.訂單狀態BindingSource, "訂單狀態編號", true));
            this.cbOrderStatusId.DataSource = this.訂單狀態BindingSource;
            this.cbOrderStatusId.DisplayMember = "訂單狀態";
            this.cbOrderStatusId.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbOrderStatusId.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.cbOrderStatusId.FormattingEnabled = true;
            this.cbOrderStatusId.Location = new System.Drawing.Point(185, 322);
            this.cbOrderStatusId.Name = "cbOrderStatusId";
            this.cbOrderStatusId.Size = new System.Drawing.Size(289, 38);
            this.cbOrderStatusId.TabIndex = 34;
            this.cbOrderStatusId.ValueMember = "訂單狀態編號";
            // 
            // 訂單狀態BindingSource
            // 
            this.訂單狀態BindingSource.DataMember = "訂單狀態";
            this.訂單狀態BindingSource.DataSource = this.japanTravelDataSet3;
            // 
            // japanTravelDataSet3
            // 
            this.japanTravelDataSet3.DataSetName = "JapanTravelDataSet3";
            this.japanTravelDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lblOrderStatusId
            // 
            this.lblOrderStatusId.AutoSize = true;
            this.lblOrderStatusId.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblOrderStatusId.Location = new System.Drawing.Point(70, 325);
            this.lblOrderStatusId.Name = "lblOrderStatusId";
            this.lblOrderStatusId.Size = new System.Drawing.Size(109, 30);
            this.lblOrderStatusId.TabIndex = 35;
            this.lblOrderStatusId.Text = "訂單狀態";
            // 
            // cbPaymentStatusId
            // 
            this.cbPaymentStatusId.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.付款狀態BindingSource, "付款狀態編號", true));
            this.cbPaymentStatusId.DataSource = this.付款狀態BindingSource;
            this.cbPaymentStatusId.DisplayMember = "付款狀態";
            this.cbPaymentStatusId.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPaymentStatusId.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.cbPaymentStatusId.FormattingEnabled = true;
            this.cbPaymentStatusId.Location = new System.Drawing.Point(185, 247);
            this.cbPaymentStatusId.Name = "cbPaymentStatusId";
            this.cbPaymentStatusId.Size = new System.Drawing.Size(289, 38);
            this.cbPaymentStatusId.TabIndex = 34;
            this.cbPaymentStatusId.ValueMember = "付款狀態編號";
            // 
            // 付款狀態BindingSource
            // 
            this.付款狀態BindingSource.DataMember = "付款狀態";
            this.付款狀態BindingSource.DataSource = this.japanTravelDataSet3;
            // 
            // lblPaymentStatusId
            // 
            this.lblPaymentStatusId.AutoSize = true;
            this.lblPaymentStatusId.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblPaymentStatusId.Location = new System.Drawing.Point(70, 250);
            this.lblPaymentStatusId.Name = "lblPaymentStatusId";
            this.lblPaymentStatusId.Size = new System.Drawing.Size(109, 30);
            this.lblPaymentStatusId.TabIndex = 35;
            this.lblPaymentStatusId.Text = "付款狀態";
            // 
            // cbPaymentMethodId
            // 
            this.cbPaymentMethodId.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.付款方式BindingSource1, "付款方式編號", true));
            this.cbPaymentMethodId.DataSource = this.付款方式BindingSource1;
            this.cbPaymentMethodId.DisplayMember = "付款方式";
            this.cbPaymentMethodId.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPaymentMethodId.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.cbPaymentMethodId.FormattingEnabled = true;
            this.cbPaymentMethodId.Location = new System.Drawing.Point(185, 172);
            this.cbPaymentMethodId.Name = "cbPaymentMethodId";
            this.cbPaymentMethodId.Size = new System.Drawing.Size(289, 38);
            this.cbPaymentMethodId.TabIndex = 34;
            this.cbPaymentMethodId.ValueMember = "付款方式編號";
            // 
            // 付款方式BindingSource1
            // 
            this.付款方式BindingSource1.DataMember = "付款方式";
            this.付款方式BindingSource1.DataSource = this.japanTravelDataSet3;
            // 
            // lblPaymentMethodId
            // 
            this.lblPaymentMethodId.AutoSize = true;
            this.lblPaymentMethodId.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblPaymentMethodId.Location = new System.Drawing.Point(70, 175);
            this.lblPaymentMethodId.Name = "lblPaymentMethodId";
            this.lblPaymentMethodId.Size = new System.Drawing.Size(109, 30);
            this.lblPaymentMethodId.TabIndex = 35;
            this.lblPaymentMethodId.Text = "付款方式";
            // 
            // fbRemark
            // 
            this.fbRemark.fieldName = " 備  註 ";
            this.fbRemark.fieldValue = "";
            this.fbRemark.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.fbRemark.Location = new System.Drawing.Point(514, 250);
            this.fbRemark.Margin = new System.Windows.Forms.Padding(8);
            this.fbRemark.Name = "fbRemark";
            this.fbRemark.Size = new System.Drawing.Size(385, 44);
            this.fbRemark.TabIndex = 25;
            // 
            // fbAmount
            // 
            this.fbAmount.fieldName = "總金額";
            this.fbAmount.fieldValue = "";
            this.fbAmount.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.fbAmount.Location = new System.Drawing.Point(514, 172);
            this.fbAmount.Margin = new System.Windows.Forms.Padding(8);
            this.fbAmount.Name = "fbAmount";
            this.fbAmount.Size = new System.Drawing.Size(385, 44);
            this.fbAmount.TabIndex = 24;
            // 
            // fbMemberId
            // 
            this.fbMemberId.fieldName = "會員ID";
            this.fbMemberId.fieldValue = "";
            this.fbMemberId.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.fbMemberId.Location = new System.Drawing.Point(514, 64);
            this.fbMemberId.Margin = new System.Windows.Forms.Padding(8);
            this.fbMemberId.Name = "fbMemberId";
            this.fbMemberId.Size = new System.Drawing.Size(385, 44);
            this.fbMemberId.TabIndex = 17;
            // 
            // japanTravelDataSet
            // 
            this.japanTravelDataSet.DataSetName = "JapanTravelDataSet";
            this.japanTravelDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // 付款方式BindingSource
            // 
            this.付款方式BindingSource.DataMember = "付款方式";
            this.付款方式BindingSource.DataSource = this.japanTravelDataSet;
            // 
            // 付款方式TableAdapter
            // 
            this.付款方式TableAdapter.ClearBeforeFill = true;
            // 
            // 付款方式TableAdapter1
            // 
            this.付款方式TableAdapter1.ClearBeforeFill = true;
            // 
            // 付款狀態TableAdapter
            // 
            this.付款狀態TableAdapter.ClearBeforeFill = true;
            // 
            // 付款狀態BindingSource1
            // 
            this.付款狀態BindingSource1.DataMember = "付款狀態";
            this.付款狀態BindingSource1.DataSource = this.japanTravelDataSet3;
            // 
            // 訂單狀態TableAdapter
            // 
            this.訂單狀態TableAdapter.ClearBeforeFill = true;
            // 
            // FrmTicketOrderEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(978, 596);
            this.Controls.Add(this.lblPaymentMethodId);
            this.Controls.Add(this.lblPaymentStatusId);
            this.Controls.Add(this.lblOrderStatusId);
            this.Controls.Add(this.cbPaymentMethodId);
            this.Controls.Add(this.cbPaymentStatusId);
            this.Controls.Add(this.cbOrderStatusId);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.fbRemark);
            this.Controls.Add(this.fbAmount);
            this.Controls.Add(this.fbMemberId);
            this.Name = "FrmTicketOrderEditor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "船票訂單";
            this.Load += new System.EventHandler(this.FrmTicketOrderEditor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.訂單狀態BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.japanTravelDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.付款狀態BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.付款方式BindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.japanTravelDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.付款方式BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.付款狀態BindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOk;
        private prjCustomerSystem.FieldBox fbRemark;
        private prjCustomerSystem.FieldBox fbAmount;
        private prjCustomerSystem.FieldBox fbMemberId;
        private System.Windows.Forms.ComboBox cbOrderStatusId;
        private System.Windows.Forms.Label lblOrderStatusId;
        private System.Windows.Forms.ComboBox cbPaymentStatusId;
        private System.Windows.Forms.Label lblPaymentStatusId;
        private System.Windows.Forms.ComboBox cbPaymentMethodId;
        private System.Windows.Forms.Label lblPaymentMethodId;
        private JapanTravelDataSet japanTravelDataSet;
        private System.Windows.Forms.BindingSource 付款方式BindingSource;
        private JapanTravelDataSetTableAdapters.付款方式TableAdapter 付款方式TableAdapter;
        private JapanTravelDataSet3 japanTravelDataSet3;
        private System.Windows.Forms.BindingSource 付款方式BindingSource1;
        private JapanTravelDataSet3TableAdapters.付款方式TableAdapter 付款方式TableAdapter1;
        private System.Windows.Forms.BindingSource 付款狀態BindingSource;
        private JapanTravelDataSet3TableAdapters.付款狀態TableAdapter 付款狀態TableAdapter;
        private System.Windows.Forms.BindingSource 付款狀態BindingSource1;
        private System.Windows.Forms.BindingSource 訂單狀態BindingSource;
        private JapanTravelDataSet3TableAdapters.訂單狀態TableAdapter 訂單狀態TableAdapter;
    }
}