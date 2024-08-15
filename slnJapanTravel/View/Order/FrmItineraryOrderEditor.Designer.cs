namespace slnJapanTravel.View
{
    partial class FrmOrderItineraryEditor
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
            this.btnOk = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblOrderStatusId = new System.Windows.Forms.Label();
            this.cbOrderStatusId = new System.Windows.Forms.ComboBox();
            this.訂單狀態BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.japanTravelDataSet3 = new slnJapanTravel.JapanTravelDataSet3();
            this.lblPaymentStatusId = new System.Windows.Forms.Label();
            this.cbPaymentStatusId = new System.Windows.Forms.ComboBox();
            this.付款狀態BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lblPaymentMethodId = new System.Windows.Forms.Label();
            this.cbPaymentMethodId = new System.Windows.Forms.ComboBox();
            this.付款方式BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cbItineraryId = new System.Windows.Forms.ComboBox();
            this.itineraryTime行程批次BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.japanTravelDataSet4 = new slnJapanTravel.JapanTravelDataSet4();
            this.lblItineraryId = new System.Windows.Forms.Label();
            this.付款方式TableAdapter = new slnJapanTravel.JapanTravelDataSet3TableAdapters.付款方式TableAdapter();
            this.付款狀態TableAdapter = new slnJapanTravel.JapanTravelDataSet3TableAdapters.付款狀態TableAdapter();
            this.訂單狀態TableAdapter = new slnJapanTravel.JapanTravelDataSet3TableAdapters.訂單狀態TableAdapter();
            this.itineraryTime行程批次TableAdapter = new slnJapanTravel.JapanTravelDataSet4TableAdapters.ItineraryTime行程批次TableAdapter();
            this.fbRemark = new prjCustomerSystem.FieldBox();
            this.fbQuantity = new prjCustomerSystem.FieldBox();
            this.fbAmount = new prjCustomerSystem.FieldBox();
            this.cbMember = new System.Windows.Forms.ComboBox();
            this.member會員BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.memberDataset = new slnJapanTravel.MemberDataset();
            this.lblMember = new System.Windows.Forms.Label();
            this.member會員TableAdapter = new slnJapanTravel.MemberDatasetTableAdapters.Member會員TableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.訂單狀態BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.japanTravelDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.付款狀態BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.付款方式BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itineraryTime行程批次BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.japanTravelDataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.member會員BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.memberDataset)).BeginInit();
            this.SuspendLayout();
            // 
            // btnOk
            // 
            this.btnOk.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnOk.Location = new System.Drawing.Point(516, 497);
            this.btnOk.Margin = new System.Windows.Forms.Padding(4);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(212, 66);
            this.btnOk.TabIndex = 14;
            this.btnOk.Text = "新增";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnCancel.Location = new System.Drawing.Point(251, 497);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(212, 66);
            this.btnCancel.TabIndex = 15;
            this.btnCancel.Text = "取消";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(58, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(284, 76);
            this.label1.TabIndex = 16;
            this.label1.Text = "訂單管理";
            // 
            // lblOrderStatusId
            // 
            this.lblOrderStatusId.AutoSize = true;
            this.lblOrderStatusId.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblOrderStatusId.Location = new System.Drawing.Point(33, 422);
            this.lblOrderStatusId.Name = "lblOrderStatusId";
            this.lblOrderStatusId.Size = new System.Drawing.Size(157, 30);
            this.lblOrderStatusId.TabIndex = 37;
            this.lblOrderStatusId.Text = "　訂單狀態　";
            // 
            // cbOrderStatusId
            // 
            this.cbOrderStatusId.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.訂單狀態BindingSource, "訂單狀態編號", true));
            this.cbOrderStatusId.DataSource = this.訂單狀態BindingSource;
            this.cbOrderStatusId.DisplayMember = "訂單狀態";
            this.cbOrderStatusId.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbOrderStatusId.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.cbOrderStatusId.FormattingEnabled = true;
            this.cbOrderStatusId.Location = new System.Drawing.Point(196, 419);
            this.cbOrderStatusId.Name = "cbOrderStatusId";
            this.cbOrderStatusId.Size = new System.Drawing.Size(289, 38);
            this.cbOrderStatusId.TabIndex = 36;
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
            // lblPaymentStatusId
            // 
            this.lblPaymentStatusId.AutoSize = true;
            this.lblPaymentStatusId.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblPaymentStatusId.Location = new System.Drawing.Point(33, 359);
            this.lblPaymentStatusId.Name = "lblPaymentStatusId";
            this.lblPaymentStatusId.Size = new System.Drawing.Size(157, 30);
            this.lblPaymentStatusId.TabIndex = 39;
            this.lblPaymentStatusId.Text = "　付款狀態　";
            // 
            // cbPaymentStatusId
            // 
            this.cbPaymentStatusId.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.付款狀態BindingSource, "付款狀態編號", true));
            this.cbPaymentStatusId.DataSource = this.付款狀態BindingSource;
            this.cbPaymentStatusId.DisplayMember = "付款狀態";
            this.cbPaymentStatusId.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPaymentStatusId.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.cbPaymentStatusId.FormattingEnabled = true;
            this.cbPaymentStatusId.Location = new System.Drawing.Point(196, 354);
            this.cbPaymentStatusId.Name = "cbPaymentStatusId";
            this.cbPaymentStatusId.Size = new System.Drawing.Size(289, 38);
            this.cbPaymentStatusId.TabIndex = 38;
            this.cbPaymentStatusId.ValueMember = "付款狀態編號";
            // 
            // 付款狀態BindingSource
            // 
            this.付款狀態BindingSource.DataMember = "付款狀態";
            this.付款狀態BindingSource.DataSource = this.japanTravelDataSet3;
            // 
            // lblPaymentMethodId
            // 
            this.lblPaymentMethodId.AutoSize = true;
            this.lblPaymentMethodId.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblPaymentMethodId.Location = new System.Drawing.Point(33, 296);
            this.lblPaymentMethodId.Name = "lblPaymentMethodId";
            this.lblPaymentMethodId.Size = new System.Drawing.Size(157, 30);
            this.lblPaymentMethodId.TabIndex = 41;
            this.lblPaymentMethodId.Text = "　付款方式　";
            // 
            // cbPaymentMethodId
            // 
            this.cbPaymentMethodId.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.付款方式BindingSource, "付款方式編號", true));
            this.cbPaymentMethodId.DataSource = this.付款方式BindingSource;
            this.cbPaymentMethodId.DisplayMember = "付款方式";
            this.cbPaymentMethodId.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPaymentMethodId.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.cbPaymentMethodId.FormattingEnabled = true;
            this.cbPaymentMethodId.Location = new System.Drawing.Point(196, 289);
            this.cbPaymentMethodId.Name = "cbPaymentMethodId";
            this.cbPaymentMethodId.Size = new System.Drawing.Size(289, 38);
            this.cbPaymentMethodId.TabIndex = 40;
            this.cbPaymentMethodId.ValueMember = "付款方式編號";
            // 
            // 付款方式BindingSource
            // 
            this.付款方式BindingSource.DataMember = "付款方式";
            this.付款方式BindingSource.DataSource = this.japanTravelDataSet3;
            // 
            // cbItineraryId
            // 
            this.cbItineraryId.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.itineraryTime行程批次BindingSource, "行程批次編號", true));
            this.cbItineraryId.DataSource = this.itineraryTime行程批次BindingSource;
            this.cbItineraryId.DisplayMember = "行程批次編號";
            this.cbItineraryId.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbItineraryId.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.cbItineraryId.FormattingEnabled = true;
            this.cbItineraryId.Location = new System.Drawing.Point(196, 153);
            this.cbItineraryId.Name = "cbItineraryId";
            this.cbItineraryId.Size = new System.Drawing.Size(289, 38);
            this.cbItineraryId.TabIndex = 40;
            this.cbItineraryId.ValueMember = "行程批次編號";
            // 
            // itineraryTime行程批次BindingSource
            // 
            this.itineraryTime行程批次BindingSource.DataMember = "ItineraryTime行程批次";
            this.itineraryTime行程批次BindingSource.DataSource = this.japanTravelDataSet4;
            // 
            // japanTravelDataSet4
            // 
            this.japanTravelDataSet4.DataSetName = "JapanTravelDataSet4";
            this.japanTravelDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lblItineraryId
            // 
            this.lblItineraryId.AutoSize = true;
            this.lblItineraryId.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblItineraryId.Location = new System.Drawing.Point(33, 156);
            this.lblItineraryId.Name = "lblItineraryId";
            this.lblItineraryId.Size = new System.Drawing.Size(157, 30);
            this.lblItineraryId.TabIndex = 41;
            this.lblItineraryId.Text = "行程批次編號";
            // 
            // 付款方式TableAdapter
            // 
            this.付款方式TableAdapter.ClearBeforeFill = true;
            // 
            // 付款狀態TableAdapter
            // 
            this.付款狀態TableAdapter.ClearBeforeFill = true;
            // 
            // 訂單狀態TableAdapter
            // 
            this.訂單狀態TableAdapter.ClearBeforeFill = true;
            // 
            // itineraryTime行程批次TableAdapter
            // 
            this.itineraryTime行程批次TableAdapter.ClearBeforeFill = true;
            // 
            // fbRemark
            // 
            this.fbRemark.fieldName = "備　註";
            this.fbRemark.fieldValue = "";
            this.fbRemark.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.fbRemark.Location = new System.Drawing.Point(534, 287);
            this.fbRemark.Margin = new System.Windows.Forms.Padding(8);
            this.fbRemark.Name = "fbRemark";
            this.fbRemark.Size = new System.Drawing.Size(385, 44);
            this.fbRemark.TabIndex = 8;
            // 
            // fbQuantity
            // 
            this.fbQuantity.fieldName = "　數　　量　";
            this.fbQuantity.fieldValue = "";
            this.fbQuantity.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.fbQuantity.Location = new System.Drawing.Point(38, 219);
            this.fbQuantity.Margin = new System.Windows.Forms.Padding(8);
            this.fbQuantity.Name = "fbQuantity";
            this.fbQuantity.Size = new System.Drawing.Size(447, 44);
            this.fbQuantity.TabIndex = 2;
            // 
            // fbAmount
            // 
            this.fbAmount.fieldName = "總金額";
            this.fbAmount.fieldValue = "";
            this.fbAmount.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.fbAmount.Location = new System.Drawing.Point(534, 219);
            this.fbAmount.Margin = new System.Windows.Forms.Padding(8);
            this.fbAmount.Name = "fbAmount";
            this.fbAmount.Size = new System.Drawing.Size(385, 44);
            this.fbAmount.TabIndex = 7;
            // 
            // cbMember
            // 
            this.cbMember.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.member會員BindingSource, "會員ID", true));
            this.cbMember.DataSource = this.member會員BindingSource;
            this.cbMember.DisplayMember = "會員名稱";
            this.cbMember.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMember.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.cbMember.FormattingEnabled = true;
            this.cbMember.Location = new System.Drawing.Point(617, 62);
            this.cbMember.Name = "cbMember";
            this.cbMember.Size = new System.Drawing.Size(302, 38);
            this.cbMember.TabIndex = 40;
            this.cbMember.ValueMember = "會員ID";
            // 
            // member會員BindingSource
            // 
            this.member會員BindingSource.DataMember = "Member會員";
            this.member會員BindingSource.DataSource = this.memberDataset;
            // 
            // memberDataset
            // 
            this.memberDataset.DataSetName = "MemberDataset";
            this.memberDataset.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lblMember
            // 
            this.lblMember.AutoSize = true;
            this.lblMember.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblMember.Location = new System.Drawing.Point(525, 62);
            this.lblMember.Name = "lblMember";
            this.lblMember.Size = new System.Drawing.Size(86, 30);
            this.lblMember.TabIndex = 41;
            this.lblMember.Text = "會員ID";
            // 
            // member會員TableAdapter
            // 
            this.member會員TableAdapter.ClearBeforeFill = true;
            // 
            // FrmOrderItineraryEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(978, 612);
            this.Controls.Add(this.lblItineraryId);
            this.Controls.Add(this.lblMember);
            this.Controls.Add(this.lblPaymentMethodId);
            this.Controls.Add(this.cbItineraryId);
            this.Controls.Add(this.cbMember);
            this.Controls.Add(this.cbPaymentMethodId);
            this.Controls.Add(this.lblPaymentStatusId);
            this.Controls.Add(this.cbPaymentStatusId);
            this.Controls.Add(this.lblOrderStatusId);
            this.Controls.Add(this.cbOrderStatusId);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.fbRemark);
            this.Controls.Add(this.fbQuantity);
            this.Controls.Add(this.fbAmount);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmOrderItineraryEditor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "行程訂單";
            this.Load += new System.EventHandler(this.FrmOrderItineraryEditor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.訂單狀態BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.japanTravelDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.付款狀態BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.付款方式BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itineraryTime行程批次BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.japanTravelDataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.member會員BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.memberDataset)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private prjCustomerSystem.FieldBox fbQuantity;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnCancel;
        private prjCustomerSystem.FieldBox fbAmount;
        private prjCustomerSystem.FieldBox fbRemark;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblOrderStatusId;
        private System.Windows.Forms.ComboBox cbOrderStatusId;
        private System.Windows.Forms.Label lblPaymentStatusId;
        private System.Windows.Forms.ComboBox cbPaymentStatusId;
        private System.Windows.Forms.Label lblPaymentMethodId;
        private System.Windows.Forms.ComboBox cbPaymentMethodId;
        private System.Windows.Forms.ComboBox cbItineraryId;
        private System.Windows.Forms.Label lblItineraryId;
        private JapanTravelDataSet3 japanTravelDataSet3;
        private System.Windows.Forms.BindingSource 付款方式BindingSource;
        private JapanTravelDataSet3TableAdapters.付款方式TableAdapter 付款方式TableAdapter;
        private System.Windows.Forms.BindingSource 付款狀態BindingSource;
        private JapanTravelDataSet3TableAdapters.付款狀態TableAdapter 付款狀態TableAdapter;
        private System.Windows.Forms.BindingSource 訂單狀態BindingSource;
        private JapanTravelDataSet3TableAdapters.訂單狀態TableAdapter 訂單狀態TableAdapter;
        private JapanTravelDataSet4 japanTravelDataSet4;
        private System.Windows.Forms.BindingSource itineraryTime行程批次BindingSource;
        private JapanTravelDataSet4TableAdapters.ItineraryTime行程批次TableAdapter itineraryTime行程批次TableAdapter;
        private System.Windows.Forms.ComboBox cbMember;
        private System.Windows.Forms.Label lblMember;
        private MemberDataset memberDataset;
        private System.Windows.Forms.BindingSource member會員BindingSource;
        private MemberDatasetTableAdapters.Member會員TableAdapter member會員TableAdapter;
    }
}