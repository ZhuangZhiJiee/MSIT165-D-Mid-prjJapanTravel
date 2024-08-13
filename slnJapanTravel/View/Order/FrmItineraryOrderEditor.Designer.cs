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
            this.btnOk = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.fbPaymentStatusId = new prjCustomerSystem.FieldBox();
            this.fbPaymentTime = new prjCustomerSystem.FieldBox();
            this.fbPaymentMethodId = new prjCustomerSystem.FieldBox();
            this.fbQuantity = new prjCustomerSystem.FieldBox();
            this.fbItineraryId = new prjCustomerSystem.FieldBox();
            this.fbMemberId = new prjCustomerSystem.FieldBox();
            this.fbCouponId = new prjCustomerSystem.FieldBox();
            this.fbAmount = new prjCustomerSystem.FieldBox();
            this.fbRemark = new prjCustomerSystem.FieldBox();
            this.fbCommentContent = new prjCustomerSystem.FieldBox();
            this.fbCommentStar = new prjCustomerSystem.FieldBox();
            this.fbCommentDate = new prjCustomerSystem.FieldBox();
            this.fbCommentStatus = new prjCustomerSystem.FieldBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnOk
            // 
            this.btnOk.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnOk.Location = new System.Drawing.Point(682, 572);
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
            this.btnCancel.Location = new System.Drawing.Point(417, 572);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(212, 66);
            this.btnCancel.TabIndex = 15;
            this.btnCancel.Text = "取消";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // fbPaymentStatusId
            // 
            this.fbPaymentStatusId.fieldName = "付款狀態編號";
            this.fbPaymentStatusId.fieldValue = "";
            this.fbPaymentStatusId.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.fbPaymentStatusId.Location = new System.Drawing.Point(69, 421);
            this.fbPaymentStatusId.Margin = new System.Windows.Forms.Padding(8);
            this.fbPaymentStatusId.Name = "fbPaymentStatusId";
            this.fbPaymentStatusId.Size = new System.Drawing.Size(385, 44);
            this.fbPaymentStatusId.TabIndex = 5;
            // 
            // fbPaymentTime
            // 
            this.fbPaymentTime.fieldName = "付款時間";
            this.fbPaymentTime.fieldValue = "";
            this.fbPaymentTime.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.fbPaymentTime.Location = new System.Drawing.Point(69, 271);
            this.fbPaymentTime.Margin = new System.Windows.Forms.Padding(8);
            this.fbPaymentTime.Name = "fbPaymentTime";
            this.fbPaymentTime.Size = new System.Drawing.Size(385, 44);
            this.fbPaymentTime.TabIndex = 3;
            // 
            // fbPaymentMethodId
            // 
            this.fbPaymentMethodId.fieldName = "付款方式編號";
            this.fbPaymentMethodId.fieldValue = "";
            this.fbPaymentMethodId.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.fbPaymentMethodId.Location = new System.Drawing.Point(69, 346);
            this.fbPaymentMethodId.Margin = new System.Windows.Forms.Padding(8);
            this.fbPaymentMethodId.Name = "fbPaymentMethodId";
            this.fbPaymentMethodId.Size = new System.Drawing.Size(385, 44);
            this.fbPaymentMethodId.TabIndex = 4;
            // 
            // fbQuantity
            // 
            this.fbQuantity.fieldName = "數量";
            this.fbQuantity.fieldValue = "";
            this.fbQuantity.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.fbQuantity.Location = new System.Drawing.Point(69, 196);
            this.fbQuantity.Margin = new System.Windows.Forms.Padding(8);
            this.fbQuantity.Name = "fbQuantity";
            this.fbQuantity.Size = new System.Drawing.Size(385, 44);
            this.fbQuantity.TabIndex = 2;
            // 
            // fbItineraryId
            // 
            this.fbItineraryId.fieldName = "行程批次編號";
            this.fbItineraryId.fieldValue = "";
            this.fbItineraryId.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.fbItineraryId.Location = new System.Drawing.Point(69, 121);
            this.fbItineraryId.Margin = new System.Windows.Forms.Padding(8);
            this.fbItineraryId.Name = "fbItineraryId";
            this.fbItineraryId.Size = new System.Drawing.Size(385, 44);
            this.fbItineraryId.TabIndex = 1;
            // 
            // fbMemberId
            // 
            this.fbMemberId.fieldName = "會員ID";
            this.fbMemberId.fieldValue = "";
            this.fbMemberId.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.fbMemberId.Location = new System.Drawing.Point(383, 48);
            this.fbMemberId.Margin = new System.Windows.Forms.Padding(8);
            this.fbMemberId.Name = "fbMemberId";
            this.fbMemberId.Size = new System.Drawing.Size(498, 44);
            this.fbMemberId.TabIndex = 0;
            // 
            // fbCouponId
            // 
            this.fbCouponId.fieldName = "優惠券ID";
            this.fbCouponId.fieldValue = "";
            this.fbCouponId.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.fbCouponId.Location = new System.Drawing.Point(69, 496);
            this.fbCouponId.Margin = new System.Windows.Forms.Padding(8);
            this.fbCouponId.Name = "fbCouponId";
            this.fbCouponId.Size = new System.Drawing.Size(385, 44);
            this.fbCouponId.TabIndex = 6;
            // 
            // fbAmount
            // 
            this.fbAmount.fieldName = "總金額";
            this.fbAmount.fieldValue = "";
            this.fbAmount.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.fbAmount.Location = new System.Drawing.Point(496, 121);
            this.fbAmount.Margin = new System.Windows.Forms.Padding(8);
            this.fbAmount.Name = "fbAmount";
            this.fbAmount.Size = new System.Drawing.Size(385, 44);
            this.fbAmount.TabIndex = 7;
            // 
            // fbRemark
            // 
            this.fbRemark.fieldName = "備註";
            this.fbRemark.fieldValue = "";
            this.fbRemark.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.fbRemark.Location = new System.Drawing.Point(496, 196);
            this.fbRemark.Margin = new System.Windows.Forms.Padding(8);
            this.fbRemark.Name = "fbRemark";
            this.fbRemark.Size = new System.Drawing.Size(385, 44);
            this.fbRemark.TabIndex = 8;
            // 
            // fbCommentContent
            // 
            this.fbCommentContent.fieldName = "評論內容";
            this.fbCommentContent.fieldValue = "";
            this.fbCommentContent.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.fbCommentContent.Location = new System.Drawing.Point(496, 346);
            this.fbCommentContent.Margin = new System.Windows.Forms.Padding(8);
            this.fbCommentContent.Name = "fbCommentContent";
            this.fbCommentContent.Size = new System.Drawing.Size(385, 44);
            this.fbCommentContent.TabIndex = 10;
            // 
            // fbCommentStar
            // 
            this.fbCommentStar.fieldName = "評論星級";
            this.fbCommentStar.fieldValue = "";
            this.fbCommentStar.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.fbCommentStar.Location = new System.Drawing.Point(496, 271);
            this.fbCommentStar.Margin = new System.Windows.Forms.Padding(8);
            this.fbCommentStar.Name = "fbCommentStar";
            this.fbCommentStar.Size = new System.Drawing.Size(385, 44);
            this.fbCommentStar.TabIndex = 9;
            // 
            // fbCommentDate
            // 
            this.fbCommentDate.fieldName = "評論日期";
            this.fbCommentDate.fieldValue = "";
            this.fbCommentDate.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.fbCommentDate.Location = new System.Drawing.Point(496, 421);
            this.fbCommentDate.Margin = new System.Windows.Forms.Padding(8);
            this.fbCommentDate.Name = "fbCommentDate";
            this.fbCommentDate.Size = new System.Drawing.Size(385, 44);
            this.fbCommentDate.TabIndex = 11;
            // 
            // fbCommentStatus
            // 
            this.fbCommentStatus.fieldName = "評論狀態";
            this.fbCommentStatus.fieldValue = "";
            this.fbCommentStatus.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.fbCommentStatus.Location = new System.Drawing.Point(496, 496);
            this.fbCommentStatus.Margin = new System.Windows.Forms.Padding(8);
            this.fbCommentStatus.Name = "fbCommentStatus";
            this.fbCommentStatus.Size = new System.Drawing.Size(385, 44);
            this.fbCommentStatus.TabIndex = 12;
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
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(462, 121);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(25, 31);
            this.label6.TabIndex = 20;
            this.label6.Text = "*";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(42, 346);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(25, 31);
            this.label5.TabIndex = 21;
            this.label5.Text = "*";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(42, 196);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(25, 31);
            this.label4.TabIndex = 22;
            this.label4.Text = "*";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(42, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(25, 31);
            this.label3.TabIndex = 23;
            this.label3.Text = "*";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(359, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 31);
            this.label2.TabIndex = 19;
            this.label2.Text = "*";
            // 
            // FrmOrderItineraryEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(978, 694);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
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
            this.Controls.Add(this.fbItineraryId);
            this.Controls.Add(this.fbCouponId);
            this.Controls.Add(this.fbMemberId);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmOrderItineraryEditor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "行程訂單";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private prjCustomerSystem.FieldBox fbMemberId;
        private prjCustomerSystem.FieldBox fbItineraryId;
        private prjCustomerSystem.FieldBox fbQuantity;
        private prjCustomerSystem.FieldBox fbPaymentTime;
        private prjCustomerSystem.FieldBox fbPaymentMethodId;
        private prjCustomerSystem.FieldBox fbPaymentStatusId;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnCancel;
        private prjCustomerSystem.FieldBox fbCouponId;
        private prjCustomerSystem.FieldBox fbAmount;
        private prjCustomerSystem.FieldBox fbRemark;
        private prjCustomerSystem.FieldBox fbCommentContent;
        private prjCustomerSystem.FieldBox fbCommentStar;
        private prjCustomerSystem.FieldBox fbCommentDate;
        private prjCustomerSystem.FieldBox fbCommentStatus;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}