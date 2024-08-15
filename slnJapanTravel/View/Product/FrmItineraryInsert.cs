using slnJapanTravel.Component.Product;
using slnJapanTravel.Model;
using slnJapanTravel.Model.Product;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace slnJapanTravel.View
{
    public partial class FrmItineraryInsert : Form
    {
        string _s = "Data Source=192.168.35.188;Initial Catalog=JapanTravel;User ID=Ting;Password=0000;Encrypt=False";
        //string _s = "Data Source=.;Initial Catalog=JapanTravel;Integrated Security=True;Encrypt=False";
        public DialogResult isOK { get; set; }
        private CItineraryMain _main = null;
        private CPic _pic;
        private ImageList _imageList = new ImageList();
        public FrmItineraryInsert()
        {
            InitializeComponent();
        }

        public CItineraryMain main
        {
            get
            {
                if (_main == null)
                    _main = new CItineraryMain(); //若類別為null，要用的話要new

                _main.行程編號 = txtItineraryId.Text;
                _main.行程名稱 = txtItineraryName.Text;
                _main.體驗名稱 = txtActivitySearch.Text;
                if (txtItinerarySpace.Text != "")
                    _main.總團位 = Convert.ToInt32(txtItinerarySpace.Text);
                if (txtItineraryPrice.Text != "")
                    _main.價格 = Convert.ToInt32(txtItineraryPrice.Text);
                _main.date.出發日期 = txtDateTimeInsert.Text;
                _main.pic.圖片名稱 = txtPictureName.Text;
                _main.pic.圖片描述 = txtPictureDescription.Text;
                _main.地區名稱 = cbAreaInsert.Text;
                //_main.圖片 =Bitmap.FromStream(picbItinerary.Image);

                return _main;
            }
            set
            {
                _main = value;
                txtItineraryId.Text = _main.行程編號;
                txtItineraryName.Text = _main.行程名稱;
                txtActivitySearch.Text = _main.體驗名稱;
                txtItinerarySpace.Text = _main.總團位.ToString();
                txtItineraryPrice.Text = _main.價格.ToString();
                txtDateTimeInsert.Text = _main.date.出發日期;
                txtPictureName.Text = _main.pic.圖片名稱;
                txtPictureDescription.Text = _main.pic.圖片描述;
                cbAreaInsert.Text = _main.地區名稱;

                //if (_pic.圖片系統編號 != 0)
                //{
                //    Stream streamImage = new MemoryStream(_pic.圖片系統編號);
                //    picbItinerary.Image = Bitmap.FromStream(streamImage);
                //}
            }
        }

        private int GetActivityIdByName(string activityName)
        {
            int activityId = 0;
            using (SqlConnection con = new SqlConnection(_s))
            {
                con.Open();
                string query = "SELECT 體驗編號 FROM Activity體驗 WHERE 體驗名稱 = @ActivityName";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@ActivityName", activityName);
                object result = cmd.ExecuteScalar();
                if (result != null)
                {
                    activityId = Convert.ToInt32(result);
                }
            }
            return activityId;
        }
        private int GeAreaIdByName(string areaName)
        {
            int areaId = 0;
            using (SqlConnection con = new SqlConnection(_s))
            {
                con.Open();
                string query = "SELECT 地區編號 FROM Area地區 WHERE 地區名稱 = @AreaName";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@AreaName", areaName);
                object result = cmd.ExecuteScalar();
                if (result != null)
                {
                    areaId = Convert.ToInt32(result);
                }
            }
            return areaId;
        }
        private void btnInsertMain_Click(object sender, EventArgs e)
        {
            string errMsg = "";
            if (string.IsNullOrEmpty(txtItineraryId.Text))
                errMsg += "\r\n 請輸入行程ID";
            if (string.IsNullOrEmpty(txtItineraryName.Text))
                errMsg += " \r\n 請輸入行程名稱";
            if (string.IsNullOrEmpty(txtItineraryPrice.Text))
                errMsg = " \r\n 請輸入價格";
            if (!CNumberUtility.isNumber(txtItinerarySpace.Text))
                errMsg += " \r\n 請輸入團位數量";
            if (!CNumberUtility.isNumber(txtItineraryPrice.Text))
                errMsg += "\r\n 請輸入價格數字";
            if (!string.IsNullOrEmpty(errMsg))
            {
                MessageBox.Show(errMsg);
                return;
            }
            main.體驗 = GetActivityIdByName(main.體驗名稱);
            main.地區 = GeAreaIdByName(main.地區名稱);



            isOK = DialogResult.OK;
            this.Close();
        }
        private void FrmItineraryInsert_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = _s;
            con.Open();

            string sql = "SELECT *  FROM Area地區";
            SqlDataAdapter adapter = new SqlDataAdapter(sql, con);
            DataSet ds = new DataSet();
            adapter.Fill(ds, "Area地區");

            cbAreaInsert.Items.Clear();
            foreach (DataRow r in ds.Tables["Area地區"].Rows)
            {
                CArea area = new CArea();
                area.地區名稱 = r["地區名稱"].ToString();

                cbAreaInsert.Items.Add(area.地區名稱);
            }

            string sqlTime = "SELECT 出發日期 FROM ItineraryTime行程批次 WHERE 行程系統編號=@K_FSID";
            SqlDataAdapter adapterTime = new SqlDataAdapter(sqlTime, con);
            adapterTime.SelectCommand.Parameters.Add(new SqlParameter("K_FSID", main.行程系統編號));

            DataSet dsTime = new DataSet();
            adapterTime.Fill(dsTime, "ItineraryTime行程批次");

            if (main != null || main.date != null)
                // 將查詢到的出發日期添加到集合中
                foreach (DataRow row in dsTime.Tables["ItineraryTime行程批次"].Rows)
                {
                    CProductManager.DepartureDate.Add(row["出發日期"].ToString());
                }

            // 將集合中的出發日期填充到ListBox
            DatelistBox.Items.Clear();
            foreach (string date in CProductManager.DepartureDate)
            {
                DatelistBox.Items.Add(date);
            }

            con.Close();
        }
        
        private void displaySpot(string sql)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString =_s;
            con.Open();

            SqlDataAdapter adapter = new SqlDataAdapter(sql, con);
            DataSet ds = new DataSet();
            SqlCommandBuilder builder = new SqlCommandBuilder();
            adapter.SelectCommand.Parameters.Add(new SqlParameter("K_KEYWORD", "%" + txtActivitySearch.Text + "%"));
            adapter.Fill(ds);
            ActivitydataGridView.DataSource = ds.Tables[0];
            con.Close();
            ActivitydataGridView.Controls.Clear();
        }

        private void btnActivitySearch_Click(object sender, EventArgs e)
        {
            
            string sql = "SELECT 體驗名稱, 體驗內容 FROM Activity體驗";
            sql += " WHERE 體驗名稱 LIKE @K_KEYWORD ";
            displaySpot(sql);
        }

        private void ActivitydataGridView_DoubleClick(object sender, EventArgs e)
        {
            if (ActivitydataGridView.CurrentRow != null)
            {
                txtActivitySearch.Text = ActivitydataGridView.CurrentRow.Cells["體驗名稱"].Value.ToString();
            }
        }

        

        private void btnDateAdd_Click(object sender, EventArgs e)
        {
            DateTime parsedDate;
            if (DateTime.TryParse(txtDateTimeInsert.Text, out parsedDate))
            {
                
                CProductManager.DepartureDate.Add(parsedDate.ToString("yyyy-MM-dd"));
                DatelistBox.Items.Add(parsedDate);
                txtDateTimeInsert.Clear();
            }
            else
            {
                MessageBox.Show("請輸入有效的日期格式。");
            }
        }

        private void btnDateDelete_Click(object sender, EventArgs e)
        {
            if (DatelistBox.SelectedItem != null)
            {
                string selectedDate = DatelistBox.SelectedItem.ToString();
                // 從 DataList 中移除選中的項目
                DatelistBox.Items.Remove(DatelistBox.SelectedItem);
                if (CProductManager.DepartureDate.Contains(selectedDate))
                {
                    CProductManager.DepartureDate.Remove(selectedDate);
                }
            }
            else
            {
                MessageBox.Show("請選擇要刪除的日期");
            }
        }

        private void picbItinerary_DoubleClick_1(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "體驗圖片(*.jpg)|*.jpg|體驗圖片(*.png)|*.png"; //用過濾器 用|隔開，左邊給人看右邊給電腦看
            if (openFileDialog1.ShowDialog() != DialogResult.OK)
                return;

            Image img = Bitmap.FromFile(openFileDialog1.FileName); //圖片繼承Bitmap
            picbItinerary.Image = img;

            FileStream imgstream = new FileStream(openFileDialog1.FileName, FileMode.Open, FileAccess.Read); //先把檔案變成串流
            BinaryReader reader = new BinaryReader(imgstream); //串流放到讀取器
            main.pic.圖片 = reader.ReadBytes /*轉成byte陣列的方法叫做ReadBytes*/((int)imgstream.Length); //轉成byte陣列，因為是陣列所以用Length
            CProductManager.Picture.Add(main.pic.圖片);

            if (_imageList.Images.Count == 0)
            {
                _imageList.ImageSize = new Size(32, 32); // 設置圖片大小
                PiclistView.LargeImageList = _imageList;
            }

            // 新增圖片到 ImageList 和 ListView
            _imageList.Images.Add(img);
            PiclistView.Items.Add(new ListViewItem { ImageIndex = _imageList.Images.Count - 1 });

            // 清空 PictureBox
            picbItinerary.Image = null;

            reader.Close();//讀完的東西會占掉記憶體所以要關閉，釋放記憶體
            imgstream.Close();
        }

        private void btnCancelMain_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDEMO_Click(object sender, EventArgs e)
        {
            txtItineraryId.Text = "24CAR0924";
            txtItineraryName.Text = "倉敷~人力車導覽江戶時代城鎮";
            txtItineraryPrice.Text = "7000";
            txtItinerarySpace.Text = "10";
            txtDateTimeInsert.Text = "2024-09-24";
            txtPictureName.Text = "人力車";
            txtPictureDescription.Text = "人力車的力與美";
        }
    }
}
