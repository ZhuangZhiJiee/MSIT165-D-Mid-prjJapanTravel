using slnJapanTravel.Model.Blog;
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

namespace slnJapanTravel.Component.Blog
{
    public partial class Phototext : UserControl
    {
        private Carticlepic _pic;
        public Carticlepic pic

        {
            get { return _pic; }
            set 
            {
                _pic = value;
                txtphoto.Text = _pic.文章圖片說明;
                //if (_pic.文章圖片 != null)
                //{
                //    Stream streamImage = new MemoryStream(_pic.文章圖片);
                //    pictureBox1.Image = Bitmap.FromStream(streamImage);
                //}
            } 
        }

        public Phototext()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_DoubleClick(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "電影海報|*.png|電影海報|*.jpg|電影海報|*.bmp";  //過濾檔案格式
            if (openFileDialog1.ShowDialog() != DialogResult.OK)
                return;
            Image img = Bitmap.FromFile(openFileDialog1.FileName);
            pictureBox1.Image = img;
            FileStream imgStram = new FileStream(openFileDialog1.FileName,
               FileMode.Open, FileAccess.Read);
            BinaryReader reader = new BinaryReader(imgStram);
            //this..文章圖片 = reader.ReadBytes((int)imgStram.Length);
            reader.Close();
            imgStram.Close();
        }
    }
}
