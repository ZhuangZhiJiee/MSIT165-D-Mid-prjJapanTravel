using slnJapanTravel.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;


namespace slnJapanTravel.View
{
    public partial class FrmShipREdit : Form
    {
        public CRoute cRoute = null;
        public Image titleIcon
        {
            get { return pictureBox1.Image; }
            set { pictureBox1.Image = value; }
        }
        public string title
        {
            get { return lblTitle.Text; }
            set { lblTitle.Text = value; }
        }
        
        public DialogResult isOk { get; set; }
        public FrmShipREdit()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            string errMsg = "";
            if (string.IsNullOrEmpty(tbDep.Text))
                errMsg += "\r\n出發港必須輸入";
            if (string.IsNullOrEmpty(tbDest.Text))
                errMsg += "\r\n到達港必須輸入";
            //if (!CNumberUtility.isNumber(fbQty.fieldValue))
            //    errMsg += "\r\n庫存必須輸入數字";
            //if (!CNumberUtility.isNumber(fbCost.fieldValue))
            //    errMsg += "\r\n成本必須輸入數字";
            //if (!CNumberUtility.isNumber(fbPrice.fieldValue))
            //    errMsg += "\r\n價格必須輸入數字";
            if (!string.IsNullOrEmpty(errMsg))
            {
                MessageBox.Show(errMsg);
                return;
            }
            this.isOk = DialogResult.OK;
            Close();
        }
    }
}
