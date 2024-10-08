﻿namespace slnJapanTravel.View
{
    partial class FrmItinerary
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmItinerary));
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnInsert = new System.Windows.Forms.Button();
            this.lblProduct = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnMainSearch = new System.Windows.Forms.Button();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.cbArea = new System.Windows.Forms.ComboBox();
            this.txtItineraryAct = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtItineraryId = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtItineraryName = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.MaindataGridView = new System.Windows.Forms.DataGridView();
            this.TimedataGridView = new System.Windows.Forms.DataGridView();
            this.btnCopy = new System.Windows.Forms.Button();
            this.btnMainUpdate = new System.Windows.Forms.Button();
            this.btnMainDelete = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MaindataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TimedataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnInsert);
            this.panel2.Controls.Add(this.lblProduct);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1208, 30);
            this.panel2.TabIndex = 13;
            // 
            // btnInsert
            // 
            this.btnInsert.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnInsert.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInsert.Location = new System.Drawing.Point(1120, 1);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(85, 27);
            this.btnInsert.TabIndex = 16;
            this.btnInsert.Text = "新增行程";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // lblProduct
            // 
            this.lblProduct.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblProduct.BackColor = System.Drawing.Color.MintCream;
            this.lblProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProduct.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblProduct.Location = new System.Drawing.Point(0, 0);
            this.lblProduct.Name = "lblProduct";
            this.lblProduct.Size = new System.Drawing.Size(1208, 30);
            this.lblProduct.TabIndex = 17;
            this.lblProduct.Text = "行程管理";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnCopy);
            this.panel3.Controls.Add(this.btnMainUpdate);
            this.panel3.Controls.Add(this.btnMainDelete);
            this.panel3.Controls.Add(this.btnMainSearch);
            this.panel3.Controls.Add(this.monthCalendar1);
            this.panel3.Controls.Add(this.cbArea);
            this.panel3.Controls.Add(this.txtItineraryAct);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.txtItineraryId);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Controls.Add(this.txtItineraryName);
            this.panel3.Controls.Add(this.label10);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 30);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1208, 227);
            this.panel3.TabIndex = 14;
            // 
            // btnMainSearch
            // 
            this.btnMainSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMainSearch.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnMainSearch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMainSearch.Location = new System.Drawing.Point(1138, 142);
            this.btnMainSearch.Name = "btnMainSearch";
            this.btnMainSearch.Size = new System.Drawing.Size(49, 35);
            this.btnMainSearch.TabIndex = 28;
            this.btnMainSearch.Text = "查詢";
            this.btnMainSearch.UseVisualStyleBackColor = true;
            this.btnMainSearch.Click += new System.EventHandler(this.btnMainSearch_Click);
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.monthCalendar1.Location = new System.Drawing.Point(862, 15);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 27;
            this.monthCalendar1.Visible = false;
            // 
            // cbArea
            // 
            this.cbArea.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbArea.FormattingEnabled = true;
            this.cbArea.Location = new System.Drawing.Point(428, 24);
            this.cbArea.Name = "cbArea";
            this.cbArea.Size = new System.Drawing.Size(183, 20);
            this.cbArea.TabIndex = 26;
            // 
            // txtItineraryAct
            // 
            this.txtItineraryAct.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtItineraryAct.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtItineraryAct.Location = new System.Drawing.Point(101, 132);
            this.txtItineraryAct.Name = "txtItineraryAct";
            this.txtItineraryAct.Size = new System.Drawing.Size(229, 17);
            this.txtItineraryAct.TabIndex = 21;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(777, 20);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 20);
            this.label6.TabIndex = 18;
            this.label6.Text = "出發時間";
            this.label6.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(22, 131);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 20);
            this.label7.TabIndex = 19;
            this.label7.Text = "體驗名稱";
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(369, 24);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(41, 20);
            this.label8.TabIndex = 16;
            this.label8.Text = "地區";
            // 
            // txtItineraryId
            // 
            this.txtItineraryId.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtItineraryId.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtItineraryId.Location = new System.Drawing.Point(101, 25);
            this.txtItineraryId.Name = "txtItineraryId";
            this.txtItineraryId.Size = new System.Drawing.Size(220, 17);
            this.txtItineraryId.TabIndex = 14;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(22, 25);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(73, 20);
            this.label9.TabIndex = 12;
            this.label9.Text = "行程編號";
            // 
            // txtItineraryName
            // 
            this.txtItineraryName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtItineraryName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtItineraryName.Location = new System.Drawing.Point(101, 77);
            this.txtItineraryName.Name = "txtItineraryName";
            this.txtItineraryName.Size = new System.Drawing.Size(588, 17);
            this.txtItineraryName.TabIndex = 15;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(22, 77);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(73, 20);
            this.label10.TabIndex = 13;
            this.label10.Text = "行程名稱";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer1.Location = new System.Drawing.Point(0, 276);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.MaindataGridView);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.TimedataGridView);
            this.splitContainer1.Size = new System.Drawing.Size(1208, 506);
            this.splitContainer1.SplitterDistance = 949;
            this.splitContainer1.TabIndex = 17;
            // 
            // MaindataGridView
            // 
            this.MaindataGridView.AllowUserToAddRows = false;
            this.MaindataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MaindataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MaindataGridView.Location = new System.Drawing.Point(0, 3);
            this.MaindataGridView.Name = "MaindataGridView";
            this.MaindataGridView.RowTemplate.Height = 24;
            this.MaindataGridView.Size = new System.Drawing.Size(949, 503);
            this.MaindataGridView.TabIndex = 0;
            this.MaindataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.MaindataGridView_CellClick);
            this.MaindataGridView.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.MaindataGridView_RowEnter_1);
            this.MaindataGridView.Paint += new System.Windows.Forms.PaintEventHandler(this.MaindataGridView_Paint_1);
            // 
            // TimedataGridView
            // 
            this.TimedataGridView.AllowUserToAddRows = false;
            this.TimedataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TimedataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TimedataGridView.Location = new System.Drawing.Point(0, 3);
            this.TimedataGridView.Name = "TimedataGridView";
            this.TimedataGridView.RowTemplate.Height = 24;
            this.TimedataGridView.Size = new System.Drawing.Size(255, 503);
            this.TimedataGridView.TabIndex = 0;
            this.TimedataGridView.Paint += new System.Windows.Forms.PaintEventHandler(this.TimedataGridView_Paint);
            // 
            // btnCopy
            // 
            this.btnCopy.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnCopy.Image = ((System.Drawing.Image)(resources.GetObject("btnCopy.Image")));
            this.btnCopy.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCopy.Location = new System.Drawing.Point(166, 179);
            this.btnCopy.Name = "btnCopy";
            this.btnCopy.Size = new System.Drawing.Size(71, 37);
            this.btnCopy.TabIndex = 29;
            this.btnCopy.Text = "複製";
            this.btnCopy.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCopy.UseVisualStyleBackColor = true;
            this.btnCopy.Visible = false;
            // 
            // btnMainUpdate
            // 
            this.btnMainUpdate.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnMainUpdate.Image = ((System.Drawing.Image)(resources.GetObject("btnMainUpdate.Image")));
            this.btnMainUpdate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMainUpdate.Location = new System.Drawing.Point(89, 178);
            this.btnMainUpdate.Name = "btnMainUpdate";
            this.btnMainUpdate.Size = new System.Drawing.Size(71, 37);
            this.btnMainUpdate.TabIndex = 30;
            this.btnMainUpdate.Text = "修改";
            this.btnMainUpdate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnMainUpdate.UseVisualStyleBackColor = true;
            // 
            // btnMainDelete
            // 
            this.btnMainDelete.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnMainDelete.Image = ((System.Drawing.Image)(resources.GetObject("btnMainDelete.Image")));
            this.btnMainDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMainDelete.Location = new System.Drawing.Point(12, 178);
            this.btnMainDelete.Name = "btnMainDelete";
            this.btnMainDelete.Size = new System.Drawing.Size(71, 38);
            this.btnMainDelete.TabIndex = 31;
            this.btnMainDelete.Text = "刪除";
            this.btnMainDelete.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnMainDelete.UseVisualStyleBackColor = true;
            // 
            // FrmItinerary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1208, 782);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Name = "FrmItinerary";
            this.Text = "旅遊行程系統";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmItinerary_Load);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.MaindataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TimedataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Label lblProduct;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txtItineraryAct;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtItineraryId;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtItineraryName;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cbArea;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.Button btnMainSearch;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.DataGridView MaindataGridView;
        private System.Windows.Forms.DataGridView TimedataGridView;
        private System.Windows.Forms.Button btnCopy;
        private System.Windows.Forms.Button btnMainUpdate;
        private System.Windows.Forms.Button btnMainDelete;
    }
}