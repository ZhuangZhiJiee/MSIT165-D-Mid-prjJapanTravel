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
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.fbPaymentStatusId = new prjCustomerSystem.FieldBox();
            this.fbPaymentTime = new prjCustomerSystem.FieldBox();
            this.fbPaymentMethodId = new prjCustomerSystem.FieldBox();
            this.fbRemark = new prjCustomerSystem.FieldBox();
            this.fbAmount = new prjCustomerSystem.FieldBox();
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(416, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 31);
            this.label2.TabIndex = 33;
            this.label2.Text = "*";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(38, 211);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(25, 31);
            this.label4.TabIndex = 33;
            this.label4.Text = "*";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(491, 211);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(25, 31);
            this.label5.TabIndex = 33;
            this.label5.Text = "*";
            // 
            // fbPaymentStatusId
            // 
            this.fbPaymentStatusId.fieldName = "付款狀態編號";
            this.fbPaymentStatusId.fieldValue = "";
            this.fbPaymentStatusId.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.fbPaymentStatusId.Location = new System.Drawing.Point(17, 485);
            this.fbPaymentStatusId.Margin = new System.Windows.Forms.Padding(8);
            this.fbPaymentStatusId.Name = "fbPaymentStatusId";
            this.fbPaymentStatusId.Size = new System.Drawing.Size(385, 44);
            this.fbPaymentStatusId.TabIndex = 22;
            this.fbPaymentStatusId.Visible = false;
            // 
            // fbPaymentTime
            // 
            this.fbPaymentTime.fieldName = "付款時間";
            this.fbPaymentTime.fieldValue = "";
            this.fbPaymentTime.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.fbPaymentTime.Location = new System.Drawing.Point(17, 427);
            this.fbPaymentTime.Margin = new System.Windows.Forms.Padding(8);
            this.fbPaymentTime.Name = "fbPaymentTime";
            this.fbPaymentTime.Size = new System.Drawing.Size(385, 44);
            this.fbPaymentTime.TabIndex = 20;
            this.fbPaymentTime.Visible = false;
            // 
            // fbPaymentMethodId
            // 
            this.fbPaymentMethodId.fieldName = "付款方式編號";
            this.fbPaymentMethodId.fieldValue = "";
            this.fbPaymentMethodId.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.fbPaymentMethodId.Location = new System.Drawing.Point(74, 210);
            this.fbPaymentMethodId.Margin = new System.Windows.Forms.Padding(8);
            this.fbPaymentMethodId.Name = "fbPaymentMethodId";
            this.fbPaymentMethodId.Size = new System.Drawing.Size(385, 44);
            this.fbPaymentMethodId.TabIndex = 21;
            // 
            // fbRemark
            // 
            this.fbRemark.fieldName = " 備  註 ";
            this.fbRemark.fieldValue = "";
            this.fbRemark.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.fbRemark.Location = new System.Drawing.Point(514, 308);
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
            this.fbAmount.Location = new System.Drawing.Point(514, 207);
            this.fbAmount.Margin = new System.Windows.Forms.Padding(8);
            this.fbAmount.Name = "fbAmount";
            this.fbAmount.Size = new System.Drawing.Size(385, 44);
            this.fbAmount.TabIndex = 24;
            // 
            // fbCouponId
            // 
            this.fbCouponId.fieldName = "  優  惠  券  ID";
            this.fbCouponId.fieldValue = "";
            this.fbCouponId.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.fbCouponId.Location = new System.Drawing.Point(74, 310);
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
            this.fbMemberId.Location = new System.Drawing.Point(435, 64);
            this.fbMemberId.Margin = new System.Windows.Forms.Padding(8);
            this.fbMemberId.Name = "fbMemberId";
            this.fbMemberId.Size = new System.Drawing.Size(464, 44);
            this.fbMemberId.TabIndex = 17;
            // 
            // FrmTicketOrderEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(978, 596);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.fbPaymentStatusId);
            this.Controls.Add(this.fbPaymentTime);
            this.Controls.Add(this.fbPaymentMethodId);
            this.Controls.Add(this.fbRemark);
            this.Controls.Add(this.fbAmount);
            this.Controls.Add(this.fbCouponId);
            this.Controls.Add(this.fbMemberId);
            this.Name = "FrmTicketOrderEditor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "船票訂單";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOk;
        private prjCustomerSystem.FieldBox fbPaymentStatusId;
        private prjCustomerSystem.FieldBox fbPaymentTime;
        private prjCustomerSystem.FieldBox fbPaymentMethodId;
        private prjCustomerSystem.FieldBox fbRemark;
        private prjCustomerSystem.FieldBox fbAmount;
        private prjCustomerSystem.FieldBox fbCouponId;
        private prjCustomerSystem.FieldBox fbMemberId;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}