using slnJapanTravel.Model;
using slnJapanTravel.Model.Ship;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
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
                tbPhoytoID.Text= _Image.ImageID渡輪圖片ID.ToString();
                tbDesc.Text = _Image.Description圖片描述;
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
            tbPhoytoID.ReadOnly = true;
            openFileDialog1 = new OpenFileDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string errMsg = "";

            // 檢查是否輸入航線ID
            if (string.IsNullOrEmpty(tbRouteID.Text))
                errMsg += "\r\n航線ID必須輸入";

            // 檢查是否輸入圖片ID
            if (string.IsNullOrEmpty(tbPhoytoID.Text))
                errMsg += "\r\n圖片ID必須輸入";

            // 檢查航線ID是否存在於資料表中
            if (!CheckRouteIDExists(tbRouteID.Text))
                errMsg += "\r\n無效的航線ID，該航線ID不存在";

            // 如果有錯誤訊息，顯示並返回
            if (!string.IsNullOrEmpty(errMsg))
            {
                MessageBox.Show(errMsg);
                return;
            }

            // 如果一切正確，設置isOk為OK並關閉視窗
            this.isOk = DialogResult.OK;
            Close();
        }

        private bool CheckRouteIDExists(string routeID)
        {
            bool exists = false;

            try
            {
                using (SqlConnection con = new SqlConnection(DbConfig.GetConnectionString()))
                {
                    con.Open();
                    string query = "SELECT COUNT(*) FROM 渡輪航線 WHERE RouteID渡輪航線ID = @RouteID";
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@RouteID", routeID);
                        int count = (int)cmd.ExecuteScalar();
                        exists = count > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("檢查航線ID時發生錯誤: " + ex.Message);
            }

            return exists;
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

        private void FrmShipPhotoEdit_Load(object sender, EventArgs e)
        {
           
        }

        private void FrmShipPhotoEdit_Load_1(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbPhoytoID.Text)) // 確保只有在建立新記錄時才填入新ID
            {
                tbPhoytoID.Text = GetNextImageID().ToString();
            }
        }
        private int GetNextImageID()
        {
            int nextId = 1; // 默認為 1
            using (SqlConnection con = new SqlConnection(DbConfig.GetConnectionString()))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT MAX(ImageID渡輪圖片ID) FROM 渡輪圖片", con);
                var result = cmd.ExecuteScalar();
                if (result != DBNull.Value)
                {
                    nextId = Convert.ToInt32(result) + 1;
                }
            }
            return nextId;
        }
    }
}
