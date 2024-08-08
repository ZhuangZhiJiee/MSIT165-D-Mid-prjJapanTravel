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
        public DialogResult isOK { get; set; }
        private CItineraryMain _main;

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
                _main.總團位 = Convert.ToInt32(txtItinerarySpace.Text);
                _main.價格 = Convert.ToInt32(txtItineraryPrice.Text);

                return _main;
            }
            set
            {
                _main = value;
                txtItineraryId.Text = _main.行程編號;
                txtItineraryName.Text = _main.行程名稱;
                txtItinerarySpace.Text = _main.總團位.ToString();
                txtItineraryPrice.Text = _main.價格.ToString();  
                //if (_main.fImage != null)
                //{
                //    Stream streamImage = new MemoryStream(_travel.fImage);
                //    TravelPic.Image = Bitmap.FromStream(streamImage);
                //}
            }
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

            isOK = DialogResult.OK;
            this.Close();
        }
        private void FrmItineraryInsert_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = @"Data Source=192.168.35.188;Initial Catalog=JapanTravel;User ID=Ting;Password=0000;Encrypt=False";
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
            con.ConnectionString = @"Data Source=192.168.35.188;Initial Catalog=JapanTravel;User ID=Ting;Password=0000;Encrypt=False";
            con.Open();

            SqlDataAdapter adapter = new SqlDataAdapter(sql, con);
            DataSet ds = new DataSet();
            SqlCommandBuilder builder = new SqlCommandBuilder();
            adapter.SelectCommand.Parameters.Add(new SqlParameter("K_KEYWORD", "%" + txtSpotSearch.Text + "%"));
            adapter.Fill(ds);
            SpotdataGridView.DataSource = ds.Tables[0];
            con.Close();
            SpotdataGridView.Controls.Clear();
        }

        private void btnSpotSearch_Click(object sender, EventArgs e)
        {
            
            string sql = "SELECT 景點名稱, 景點內容 FROM Spot景點";
            sql += " WHERE 景點名稱 LIKE @K_KEYWORD ";
            displaySpot(sql);
        }

        private void SpotdataGridView_DoubleClick(object sender, EventArgs e)
        {
            if (SpotdataGridView.CurrentRow != null)
            {
                txtSpotSearch.Text = SpotdataGridView.CurrentRow.Cells["景點名稱"].Value.ToString();
            }
        }

        private void displayHotel(string sql)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = @"Data Source=192.168.35.188;Initial Catalog=JapanTravel;User ID=Ting;Password=0000;Encrypt=False";
            con.Open();

            SqlDataAdapter adapter = new SqlDataAdapter(sql, con);
            DataSet ds = new DataSet();
            SqlCommandBuilder builder = new SqlCommandBuilder();
            adapter.SelectCommand.Parameters.Add(new SqlParameter("K_KEYWORD", "%" + txtHotelSearch.Text + "%"));
            adapter.Fill(ds);
            HoteldataGridView.DataSource = ds.Tables[0];
            con.Close();
        }
        private void btnHotelSearchDetail_Click_1(object sender, EventArgs e)
        {
            string sql = "SELECT 飯店名稱, 飯店星級 FROM Hotel飯店";
            sql += " WHERE 飯店名稱 LIKE @K_KEYWORD ";
            displayHotel(sql);
        }
        private void HoteldataGridView_DoubleClick_1(object sender, EventArgs e)
        {
            if (HoteldataGridView.CurrentRow != null)
            {
                txtHotelSearch.Text = HoteldataGridView.CurrentRow.Cells["飯店名稱"].Value.ToString();
            }
        }
        private void displaySpotDetail(string sql)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = @"Data Source=192.168.35.188;Initial Catalog=JapanTravel;User ID=Ting;Password=0000;Encrypt=False";
            con.Open();

            SqlDataAdapter adapter = new SqlDataAdapter(sql, con);
            DataSet ds = new DataSet();
            SqlCommandBuilder builder = new SqlCommandBuilder();
            adapter.SelectCommand.Parameters.Add(new SqlParameter("K_KEYWORD", "%" + txtSpotDetailSearch.Text + "%"));
            adapter.Fill(ds);
            SpotDetaildataGridView.DataSource = ds.Tables[0];
            con.Close();
            SpotDetaildataGridView.Controls.Clear();
        }
        private void btnSpotSearchDetail_Click(object sender, EventArgs e)
        {
            string sql = "SELECT 景點名稱 FROM Spot景點";
            sql += " WHERE 景點名稱 LIKE @K_KEYWORD ";
            displaySpotDetail(sql);
        }
        private void SpotDetaildataGridView_DoubleClick(object sender, EventArgs e)
        {
         if (SpotDetaildataGridView.CurrentRow != null)
            {
                txtSpotDetailSearch.Text = SpotDetaildataGridView.CurrentRow.Cells["景點名稱"].Value.ToString();
             }
        }

        private void btnCancelMain_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
