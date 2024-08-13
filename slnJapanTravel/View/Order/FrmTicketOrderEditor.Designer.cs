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
            this.label1 = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOk = new System.Windows.Forms.Button();
            this.fbCommentDate = new prjCustomerSystem.FieldBox();
            this.fbPaymentStatusId = new prjCustomerSystem.FieldBox();
            this.fbCommentStar = new prjCustomerSystem.FieldBox();
            this.fbPaymentTime = new prjCustomerSystem.FieldBox();
            this.fbCommentStatus = new prjCustomerSystem.FieldBox();
            this.fbCommentContent = new prjCustomerSystem.FieldBox();
            this.fbPaymentMethodId = new prjCustomerSystem.FieldBox();
            this.fbRemark = new prjCustomerSystem.FieldBox();
            this.fbQuantity = new prjCustomerSystem.FieldBox();
            this.fbAmount = new prjCustomerSystem.FieldBox();
            this.fieldBox2 = new prjCustomerSystem.FieldBox();
            this.fbCouponId = new prjCustomerSystem.FieldBox();
            this.fbMemberId = new prjCustomerSystem.FieldBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(63, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(284, 76);
            this.label1.TabIndex = 32;
            this.label1.Text = "訂單管理";
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnCancel.Location = new System.Drawing.Point(422, 588);
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
            this.btnOk.Location = new System.Drawing.Point(687, 588);
            this.btnOk.Margin = new System.Windows.Forms.Padding(4);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(212, 66);
            this.btnOk.TabIndex = 30;
            this.btnOk.Text = "新增";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.button1_Click);
            // 
            // fbCommentDate
            // 
            this.fbCommentDate.fieldName = "評論日期";
            this.fbCommentDate.fieldValue = "";
            this.fbCommentDate.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.fbCommentDate.Location = new System.Drawing.Point(501, 437);
            this.fbCommentDate.Margin = new System.Windows.Forms.Padding(8);
            this.fbCommentDate.Name = "fbCommentDate";
            this.fbCommentDate.Size = new System.Drawing.Size(385, 44);
            this.fbCommentDate.TabIndex = 28;
            // 
            // fbPaymentStatusId
            // 
            this.fbPaymentStatusId.fieldName = "付款狀態編號";
            this.fbPaymentStatusId.fieldValue = "";
            this.fbPaymentStatusId.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.fbPaymentStatusId.Location = new System.Drawing.Point(74, 437);
            this.fbPaymentStatusId.Margin = new System.Windows.Forms.Padding(8);
            this.fbPaymentStatusId.Name = "fbPaymentStatusId";
            this.fbPaymentStatusId.Size = new System.Drawing.Size(385, 44);
            this.fbPaymentStatusId.TabIndex = 22;
            // 
            // fbCommentStar
            // 
            this.fbCommentStar.fieldName = "評論星級";
            this.fbCommentStar.fieldValue = "";
            this.fbCommentStar.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.fbCommentStar.Location = new System.Drawing.Point(501, 287);
            this.fbCommentStar.Margin = new System.Windows.Forms.Padding(8);
            this.fbCommentStar.Name = "fbCommentStar";
            this.fbCommentStar.Size = new System.Drawing.Size(385, 44);
            this.fbCommentStar.TabIndex = 26;
            // 
            // fbPaymentTime
            // 
            this.fbPaymentTime.fieldName = "付款時間";
            this.fbPaymentTime.fieldValue = "";
            this.fbPaymentTime.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.fbPaymentTime.Location = new System.Drawing.Point(74, 287);
            this.fbPaymentTime.Margin = new System.Windows.Forms.Padding(8);
            this.fbPaymentTime.Name = "fbPaymentTime";
            this.fbPaymentTime.Size = new System.Drawing.Size(385, 44);
            this.fbPaymentTime.TabIndex = 20;
            // 
            // fbCommentStatus
            // 
            this.fbCommentStatus.fieldName = "評論狀態";
            this.fbCommentStatus.fieldValue = "";
            this.fbCommentStatus.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.fbCommentStatus.Location = new System.Drawing.Point(501, 512);
            this.fbCommentStatus.Margin = new System.Windows.Forms.Padding(8);
            this.fbCommentStatus.Name = "fbCommentStatus";
            this.fbCommentStatus.Size = new System.Drawing.Size(385, 44);
            this.fbCommentStatus.TabIndex = 29;
            // 
            // fbCommentContent
            // 
            this.fbCommentContent.fieldName = "評論內容";
            this.fbCommentContent.fieldValue = "";
            this.fbCommentContent.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.fbCommentContent.Location = new System.Drawing.Point(501, 362);
            this.fbCommentContent.Margin = new System.Windows.Forms.Padding(8);
            this.fbCommentContent.Name = "fbCommentContent";
            this.fbCommentContent.Size = new System.Drawing.Size(385, 44);
            this.fbCommentContent.TabIndex = 27;
            // 
            // fbPaymentMethodId
            // 
            this.fbPaymentMethodId.fieldName = "付款方式編號";
            this.fbPaymentMethodId.fieldValue = "";
            this.fbPaymentMethodId.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.fbPaymentMethodId.Location = new System.Drawing.Point(74, 362);
            this.fbPaymentMethodId.Margin = new System.Windows.Forms.Padding(8);
            this.fbPaymentMethodId.Name = "fbPaymentMethodId";
            this.fbPaymentMethodId.Size = new System.Drawing.Size(385, 44);
            this.fbPaymentMethodId.TabIndex = 21;
            // 
            // fbRemark
            // 
            this.fbRemark.fieldName = "備註";
            this.fbRemark.fieldValue = "";
            this.fbRemark.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.fbRemark.Location = new System.Drawing.Point(501, 212);
            this.fbRemark.Margin = new System.Windows.Forms.Padding(8);
            this.fbRemark.Name = "fbRemark";
            this.fbRemark.Size = new System.Drawing.Size(385, 44);
            this.fbRemark.TabIndex = 25;
            // 
            // fbQuantity
            // 
            this.fbQuantity.fieldName = "數量";
            this.fbQuantity.fieldValue = "";
            this.fbQuantity.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.fbQuantity.Location = new System.Drawing.Point(74, 212);
            this.fbQuantity.Margin = new System.Windows.Forms.Padding(8);
            this.fbQuantity.Name = "fbQuantity";
            this.fbQuantity.Size = new System.Drawing.Size(385, 44);
            this.fbQuantity.TabIndex = 19;
            // 
            // fbAmount
            // 
            this.fbAmount.fieldName = "總金額";
            this.fbAmount.fieldValue = "";
            this.fbAmount.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.fbAmount.Location = new System.Drawing.Point(501, 137);
            this.fbAmount.Margin = new System.Windows.Forms.Padding(8);
            this.fbAmount.Name = "fbAmount";
            this.fbAmount.Size = new System.Drawing.Size(385, 44);
            this.fbAmount.TabIndex = 24;
            // 
            // fieldBox2
            // 
            this.fieldBox2.fieldName = "航班編號";
            this.fieldBox2.fieldValue = "";
            this.fieldBox2.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.fieldBox2.Location = new System.Drawing.Point(74, 137);
            this.fieldBox2.Margin = new System.Windows.Forms.Padding(8);
            this.fieldBox2.Name = "fieldBox2";
            this.fieldBox2.Size = new System.Drawing.Size(385, 44);
            this.fieldBox2.TabIndex = 18;
            // 
            // fbCouponId
            // 
            this.fbCouponId.fieldName = "優惠券ID";
            this.fbCouponId.fieldValue = "";
            this.fbCouponId.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.fbCouponId.Location = new System.Drawing.Point(74, 512);
            this.fbCouponId.Margin = new System.Windows.Forms.Padding(8);
            this.fbCouponId.Name = "fbCouponId";
            this.fbCouponId.Size = new System.Drawing.Size(385, 44);
            this.fbCouponId.TabIndex = 23;
            // 
            // fbMemberId
            // 
            this.fbMemberId.fieldName = "會員ID";
            this.fbMemberId.fieldValue = "";
            this.fbMemberId.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.fbMemberId.Location = new System.Drawing.Point(388, 64);
            this.fbMemberId.Margin = new System.Windows.Forms.Padding(8);
            this.fbMemberId.Name = "fbMemberId";
            this.fbMemberId.Size = new System.Drawing.Size(498, 44);
            this.fbMemberId.TabIndex = 17;
            // 
            // FrmTicketOrderEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(978, 694);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.fbCommentDate);
            this.Controls.Add(this.fbPaymentStatusId);
            this.Controls.Add(this.fbCommentStar);
            this.Controls.Add(this.fbPaymentTime);
            this.Controls.Add(this.fbCommentStatus);
            this.Controls.Add(this.fbCommentContent);
            this.Controls.Add(this.fbPaymentMethodId);
            this.Controls.Add(this.fbRemark);
            this.Controls.Add(this.fbQuantity);
            this.Controls.Add(this.fbAmount);
            this.Controls.Add(this.fieldBox2);
            this.Controls.Add(this.fbCouponId);
            this.Controls.Add(this.fbMemberId);
            this.Name = "FrmTicketOrderEditor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "船票訂單";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOk;
        private prjCustomerSystem.FieldBox fbCommentDate;
        private prjCustomerSystem.FieldBox fbPaymentStatusId;
        private prjCustomerSystem.FieldBox fbCommentStar;
        private prjCustomerSystem.FieldBox fbPaymentTime;
        private prjCustomerSystem.FieldBox fbCommentStatus;
        private prjCustomerSystem.FieldBox fbCommentContent;
        private prjCustomerSystem.FieldBox fbPaymentMethodId;
        private prjCustomerSystem.FieldBox fbRemark;
        private prjCustomerSystem.FieldBox fbQuantity;
        private prjCustomerSystem.FieldBox fbAmount;
        private prjCustomerSystem.FieldBox fieldBox2;
        private prjCustomerSystem.FieldBox fbCouponId;
        private prjCustomerSystem.FieldBox fbMemberId;
    }
}