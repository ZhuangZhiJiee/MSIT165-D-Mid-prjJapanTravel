using slnJapanTravel.Model;
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
        //string _s = "";
        public DialogResult isOK { get; set; }
        private CItineraryMain _main;
        private CPic _pic;

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
                _main.總團位 = Convert.ToInt32(txtItinerarySpace.Text);
                _main.價格 = Convert.ToInt32(txtItineraryPrice.Text);
                _main.地區名稱 = cbAreaInsert.Text;

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
                cbAreaInsert.Text = _main.地區名稱;
                if (_pic.圖片系統編號 != 0)
                {
                    Stream streamImage = new MemoryStream(_pic.圖片系統編號);
                    picbItinerary.Image = Bitmap.FromStream(streamImage);
                }
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
                errMsg += " \r\n 請輸入剩餘團位數量";
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

            con.Close();
        }
        private void displaySpot(string sql)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = _s;
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

        private void btnCancelMain_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void picbItinerary_DoubleClick(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "體驗圖片(*.jpg)|*.jpg|體驗圖片(*.png)|*.png"; //用過濾器 用|隔開，左邊給人看右邊給電腦看
            if (openFileDialog1.ShowDialog() != DialogResult.OK)
                return;

            Image img = Bitmap.FromFile(openFileDialog1.FileName); //圖片繼承Bitmap
            picbItinerary.Image = img;

            FileStream imgstream = new FileStream(openFileDialog1.FileName, FileMode.Open, FileAccess.Read); //先把檔案變成串流
            BinaryReader reader = new BinaryReader(imgstream); //串流放到讀取器
            this.main.圖片 = reader.ReadBytes /*轉成byte陣列的方法叫做ReadBytes*/((int)imgstream.Length); //轉成byte陣列，因為是陣列所以用Length
            reader.Close(); //讀完的東西會占掉記憶體所以要關閉，釋放記憶體
            imgstream.Close();
        }
    }
}
