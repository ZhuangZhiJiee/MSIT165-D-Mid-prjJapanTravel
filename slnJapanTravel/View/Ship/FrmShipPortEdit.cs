using slnJapanTravel.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace slnJapanTravel.View.Ship
{
    public partial class FrmShipPortEdit : Form
    {
        public System.Drawing.Image titleIcon
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
        public CPort _Port = null;
        public CPort port
        {
            get
            {
                if (_Port == null)
                    _Port = new CPort();
                _Port.PortName港口名稱 = tbPortName.Text;
                _Port.City城市名稱 = tbCity.Text;
                return _Port;
            }
            set
            {
                _Port = value;
                tbPortName.Text = _Port.PortName港口名稱;
                tbCity.Text = _Port.City城市名稱;
                tbPortID.Text = _Port.PortID港口ID.ToString();
                
            }
        }

        public FrmShipPortEdit()
        {
            InitializeComponent();
            tbPortID.ReadOnly = true;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string errMsg = "";
            if (string.IsNullOrEmpty(tbPortID.Text))
                errMsg += "\r\n港口ID必須輸入";
            if (string.IsNullOrEmpty(tbPortName.Text))
                errMsg += "\r\n港口名稱必須輸入";
            if (string.IsNullOrEmpty(tbCity.Text))
                errMsg += "\r\n城市名稱必須輸入";

            if (!string.IsNullOrEmpty(errMsg))
            {
                MessageBox.Show(errMsg);
                return;
            }
            this.isOk = DialogResult.OK;
            Close();
        }

        private void FrmShipPortEdit_Load(object sender, EventArgs e)
        {

        }
    }
}
