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
using System.Xml.Linq;

namespace slnJapanTravel.View.Ship
{
    public partial class FrmShipPhotoEdit : Form
    {
        public CImage _Image = null;
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
        public CImage image
        {
            get
            {
                if(_Image == null)
                    _Image = new CImage();
                //_Image.ImageID渡輪圖片ID = int.Parse(tbPhoytoID.Text);
                _Image.RouteID渡輪航線ID = Convert.ToInt32(tbRouteID.Text);                
                _Image.Description圖片描述 = tbDesc.Text;
                return _Image;
            }
            set
            {
                _Image = value;
                tbRouteID.Text=_Image.RouteID渡輪航線ID.ToString();
                tbPhoytoID.Text=image.ImageID渡輪圖片ID.ToString();
                tbDesc.Text = image.Description圖片描述;
                if(_Image.Image圖片 != null)
                {
                    Stream streamImage = new MemoryStream(_Image.Image圖片);
                    pictureBox2.Image = Bitmap.FromStream(streamImage);
                }
            }
        }
        public FrmShipPhotoEdit()
        {
            InitializeComponent();
            openFileDialog1 = new OpenFileDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string errMsg = "";
            if (string.IsNullOrEmpty(tbRouteID.Text))
                errMsg += "\r\n航線ID必須輸入";
            if (string.IsNullOrEmpty(tbPhoytoID.Text))
                errMsg += "\r\n圖片必須輸入";
            
            if (!string.IsNullOrEmpty(errMsg))
            {
                MessageBox.Show(errMsg);
                return;
            }
            this.isOk = DialogResult.OK;
            Close();
        }

        private void pictureBox2_DoubleClick(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "圖片|*.png|圖片|*.jpg|圖片|*.bmp";
            if (openFileDialog1.ShowDialog() != DialogResult.OK)
                return;
            Image img = Bitmap.FromFile(openFileDialog1.FileName);
            pictureBox2.Image = img;

            FileStream imgStream = new FileStream(openFileDialog1.FileName, FileMode.Open, FileAccess.Read);
            BinaryReader reader = new BinaryReader(imgStream);
            this.image.Image圖片 = reader.ReadBytes((int)imgStream.Length);
            reader.Close();
            imgStream.Close();
        }

        private void FrmShipPhotoEdit_FormClosed(object sender, FormClosedEventArgs e)
        {

        }
    }
}
