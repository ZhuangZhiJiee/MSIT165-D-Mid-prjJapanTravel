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

namespace slnJapanTravel.View.Blog
{
    public partial class Frmarticlelist : Form
    {
        private SqlDataAdapter _adapter;
        private SqlCommandBuilder _bulider;
        private int _position;
        string str = "Data Source = 192.168.35.188,1433; Initial Catalog = JapanTravel; User ID = song; Password = 0000; Encrypt = False";
        //string str = "";
        private void Frmarticlelist_Load(object sender, EventArgs e)
        {
            displayBySql("SELECT * FROM Article文章");
        }
        private void displayBySql(string sql)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = str;
            con.Open();

            _adapter = new SqlDataAdapter(sql, con);
            _bulider = new SqlCommandBuilder(_adapter);

            _adapter.SelectCommand.Parameters.Add
                (new SqlParameter("StartDate", dateTimePickerstart.Value.ToString("yyyy-MM-dd")));
            _adapter.SelectCommand.Parameters.Add
                (new SqlParameter("EndDate", dateTimePickerend.Value.ToString("yyyy-MM-dd")));

            DataSet ds = new DataSet();  //水桶
            _adapter.Fill(ds);
            con.Close();
            dataGridView1.DataSource = ds.Tables[0]; //DataTable

        }
        public Frmarticlelist()
        {
            InitializeComponent();
        }

        private void btnhtclose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lbldaystart_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void btnhtadd_Click(object sender, EventArgs e)
        {
            Frmarticleedit a = new Frmarticleedit();
            a.ShowDialog();
            if
               (a.isOK == DialogResult.OK)
            {
                DataTable dt = dataGridView1.DataSource as DataTable;
                DataRow dr = dt.NewRow();
                //dr["fName"] = a.movie.文章編號;
                //dr["fQty"] = a.movie.會員ID;
                //dr["fCost"] = a.movie.發布時間;
                //dr["fPrice"] = a.movie.文章狀態;
                //dr["fImage"] = a.movie.hashtag;
                //dt.Rows.Add(dr);

            }
        }

        

        private void Frmarticlelist_FormClosed(object sender, FormClosedEventArgs e)
        {
            _adapter.Update(dataGridView1.DataSource as DataTable);
        }

        private void dataGridView1_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            _position = e.RowIndex; // 目前點到的那筆位置
        }

        private void btnhtdelete_Click(object sender, EventArgs e)
        {
            DataTable dt = dataGridView1.DataSource as DataTable;
            DataRow dr = dt.Rows[_position];
            dr.Delete();
            _adapter.Update(dataGridView1.DataSource as DataTable); //刪除一筆完後馬上更新
        }

        private void btnkysearch_Click(object sender, EventArgs e)
        {
            
        }

        private void btndaysearch_Click(object sender, EventArgs e)
        {
            string sql = "SELECT * FROM Article文章 WHERE 發布時間 BETWEEN @StartDate AND @EndDate";

            displayBySql(sql);
        }
    }
}
