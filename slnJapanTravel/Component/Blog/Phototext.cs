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
    }
}
