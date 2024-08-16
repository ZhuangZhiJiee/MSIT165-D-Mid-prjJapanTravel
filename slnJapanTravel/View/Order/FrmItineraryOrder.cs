using slnJapanTravel.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace slnJapanTravel.View
{
    public partial class FrmItineraryOrder : Form
    {
        //string _s = "Data Source=192.168.35.188,1433;Initial Catalog=JapanTravel;User ID=Luke;Password=0000;Encrypt=False";  //SQL ConnectionString
        string _s = "Data Source=.;Initial Catalog=JapanTravel;Integrated Security=True;Encrypt=False";  //本機ConnectionString
        private SqlDataAdapter _adapter;
        private SqlCommandBuilder _builder;
        private int _position;
        List<int> _list = null;

        public FrmItineraryOrder()
        {
            InitializeComponent();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            FrmOrderItineraryEditor f = new FrmOrderItineraryEditor();
            f.ShowDialog();

            if (f.isOk == DialogResult.OK)
            {
                DataTable dt = dataGridView1.DataSource as DataTable;
                DataRow dr = dt.NewRow();
                dr["會員ID"] = f.itineraryorder.會員ID;
                dr["行程批次編號"] = f.itineraryorder.行程批次編號;
                dr["數量"] = f.itineraryorder.數量;
                dr["下單時間"] = f.itineraryorder.下單時間;
                dr["付款方式編號"] = f.itineraryorder.付款方式編號;
                dr["付款狀態編號"] = f.itineraryorder.付款狀態編號;
                dr["訂單狀態編號"] = f.itineraryorder.訂單狀態編號;
                //if (f.itineraryorder.優惠券ID == 0)
                //{
                //    dr["優惠券ID"] = DBNull.Value;
                //}
                //else
                //{
                //    dr["優惠券ID"] = f.itineraryorder.優惠券ID;
                //}
                dr["總金額"] = f.itineraryorder.總金額;
                dr["備註"] = f.itineraryorder.備註;
                //dr["評論星級"] = DBNull.Value;
                //dr["評論內容"] = DBNull.Value;
                //dr["評論日期"] = DBNull.Value;
                //dr["評論狀態"] = f.itineraryorder.評論狀態;
                dt.Rows.Add(dr);
            }
        }

        private void FrmItineraryOrder_Load(object sender, EventArgs e)
        {
            displayLoad();
        }

        private void displayLoad()
        {
            //displayBySql("SELECT 行程訂單編號, main.會員ID, 行程批次編號, 數量, 下單時間, 付款方式, 付款狀態, 總金額, 備註 " +
            //    "FROM 行程訂單資料 main " +
            //    "join Member會員 m " +
            //    "on main.會員ID = m.會員ID " +
            //    "join 付款方式 method " +
            //    "on main.付款方式編號 = method.付款方式編號 " +
            //    "join 付款狀態 Pstatus " +
            //    "on main.付款狀態編號 = Pstatus.付款狀態編號");

            displayBySql("SELECT 行程訂單編號, 會員ID, 行程批次編號, 數量, 下單時間, 付款方式編號, 付款狀態編號, 訂單狀態編號, 總金額, 備註 " +
                "FROM 行程訂單資料");

        }

        private void displayBySql(string sql)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = _s;
            con.Open();

            _adapter = new SqlDataAdapter(sql, con);
            _builder = new SqlCommandBuilder(_adapter);

            _adapter.SelectCommand.Parameters.Add(
                new SqlParameter("K_KEYWORD", "%" + (object)txtKeyword.Text + "%"));

            DataSet ds = new DataSet();
            _adapter.Fill(ds);
            con.Close();
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void FrmItineraryOrder_FormClosed(object sender, FormClosedEventArgs e)
        {
            _adapter.Update(dataGridView1.DataSource as DataTable);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DataTable dt = dataGridView1.DataSource as DataTable;
            DataRow dr = dt.Rows[_position];
            dr.Delete();
            _adapter.Update(dataGridView1.DataSource as DataTable);
        }

        private void dataGridView1_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            _position = e.RowIndex;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            //displayBySql("SELECT 行程訂單編號, 會員名稱, 行程批次編號, 數量, 下單時間, 付款方式, 付款狀態, 總金額, 備註 " +
            //    "FROM 行程訂單資料 main " +
            //    "join Member會員 m " +
            //    "on main.會員ID = m.會員ID " +
            //    "join 付款方式 method " +
            //    "on main.付款方式編號 = method.付款方式編號 " +
            //    "join 付款狀態 Pstatus " +
            //    "on main.付款狀態編號 = Pstatus.付款狀態編號" +
            //    " WHERE 行程訂單編號 LIKE " +
            //    "'%" + txtKeyword.Text + "%'" +
            //    "OR 會員名稱 LIKE '%" + txtKeyword.Text + "%'");


            displayBySql("SELECT 行程訂單編號, 會員ID, 行程批次編號, 數量, 下單時間, 付款方式編號, " +
                "付款狀態編號, 付款狀態編號, 總金額, 備註 FROM 行程訂單資料 WHERE 行程訂單編號 LIKE " +
                "'%" + txtKeyword.Text + "%'" +
                "OR 會員Id LIKE '%" + txtKeyword.Text + "%'");
        }

        private void txtKeyword_Click(object sender, EventArgs e)
        {
            if (txtKeyword.Text == "查詢訂單編號 or 會員Id")
                txtKeyword.Clear();
        }

        private void btnUpload_Click(object sender, EventArgs e)
        {
            _adapter.Update(dataGridView1.DataSource as DataTable);
            displayLoad();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            DataTable dt = dataGridView1.DataSource as DataTable;
            DataRow dr = dt.Rows[_position];
            C行程訂單資料 i = new C行程訂單資料();

            i.會員ID = (int)dr["會員ID"];
            i.行程批次編號 = (int)dr["行程批次編號"];
            i.數量 = (int)dr["數量"];
            i.下單時間 = (DateTime)dr["下單時間"];
            i.付款方式編號 = (int)dr["付款方式編號"];
            i.付款狀態編號 = (int)dr["付款狀態編號"];
            if (dr["訂單狀態編號"] != DBNull.Value)
            { 
                i.訂單狀態編號 = (int)dr["訂單狀態編號"]; 
            }
            //if(dr["優惠券ID"] != DBNull.Value)
            //    i.優惠券ID = (int)dr["優惠券ID"];
            i.總金額 = (decimal)dr["總金額"];
            i.備註 = dr["備註"].ToString();
            //if(dr["評論星級"] != DBNull.Value)
            //    i.評論星級 = (int)dr["評論星級"];
            //i.評論內容 = dr["評論內容"].ToString();
            //if(dr["評論日期"] != DBNull.Value)
            //    i.評論日期 = (DateTime)dr["評論日期"];
            //i.評論狀態 = (Boolean)dr["評論狀態"];

            FrmOrderItineraryEditor f = new FrmOrderItineraryEditor();
            f.itineraryorder = i;
            f.btnText = "確定修改";
            f.ShowDialog();
            if (f.isOk == DialogResult.OK)
            {
            dr["會員ID"] = f.itineraryorder.會員ID;
            dr["行程批次編號"] = f.itineraryorder.行程批次編號;
            dr["數量"] = f.itineraryorder.數量;
            dr["下單時間"] = f.itineraryorder.下單時間;
            dr["付款方式編號"] = f.itineraryorder.付款方式編號;
            dr["付款狀態編號"] = f.itineraryorder.付款狀態編號;
            dr["訂單狀態編號"] = f.itineraryorder.訂單狀態編號;
            //if (f.itineraryorder.優惠券ID == 0)
            //{
            //    dr["優惠券ID"] = DBNull.Value;
            //}
            //else
            //{
            //    dr["優惠券ID"] = f.itineraryorder.優惠券ID;
            //}
            dr["總金額"] = f.itineraryorder.總金額;
            dr["備註"] = f.itineraryorder.備註;
            //dr["評論星級"] = DBNull.Value;
            //dr["評論內容"] = DBNull.Value;
            //dr["評論日期"] = DBNull.Value;
            //dr["評論狀態"] = f.itineraryorder.評論狀態;
            }
        }

        private void FrmItineraryOrder_Paint(object sender, PaintEventArgs e)
        {
            resetGridStyle();
        }

        private void resetGridStyle()
        {
            dataGridView1.Columns[0].Width = 100;
            dataGridView1.Columns[1].Width = 100;
            dataGridView1.Columns[2].Width = 100;
            dataGridView1.Columns[3].Width = 75;
            dataGridView1.Columns[4].Width = 200;
            dataGridView1.Columns[5].Width = 100;
            dataGridView1.Columns[6].Width = 100;
            dataGridView1.Columns[7].Width = 100;
            dataGridView1.Columns[8].Width = 150;
            dataGridView1.Columns[9].Width = this.Width - 100 - 100 - 100 - 75 - 200 - 100 - 100 - 150 - 100 - 85;
            dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("微軟正黑體", 14);

            bool isColorChanged = false;
            int count = 0;
            foreach (DataGridViewRow r in dataGridView1.Rows )
            {
                count++;
                isColorChanged = !isColorChanged;
                r.DefaultCellStyle.BackColor = Color.White;
                if (isColorChanged) 
                    r.DefaultCellStyle.BackColor = Color.FromArgb(240, 240, 240);
                r.DefaultCellStyle.Font = new Font("微軟正黑體", 13);
                r.Height = 40;
                r.HeaderCell.Value = count.ToString();
            }

        }
    }
}
