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

namespace slnJapanTravel.View.Blog
{
    public partial class Frmhashtag : Form
    {
        private SqlDataAdapter _adapter;
        private SqlCommandBuilder _bulider;
        private int _position;

        public Frmhashtag()
        {
            InitializeComponent();
        }
        string str = "Data Source = 192.168.35.188,1433; Initial Catalog = JapanTravel; User ID = song; Password = 0000; Encrypt = False";
        private void btnhtclose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnhtadd_Click(object sender, EventArgs e)
        {
            Frmhashtagedit h = new Frmhashtagedit();
            h.ShowDialog();
            if
               (h.isOK == DialogResult.OK)
            {
                DataTable dt = dataGridView1.DataSource as DataTable;
                DataRow dr = dt.NewRow();
                dr["hashtag名稱"] = h.Cht.fHashtag;
                dt.Rows.Add(dr);

            }
        }
        private void Frmhashtag_Load(object sender, EventArgs e)
        {
            displaybySQL("SELECT * FROM hashtag");
        }

        private void displaybySQL(string sql)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = str;
;
            con.Open();

            _adapter = new SqlDataAdapter(sql, con);
            _bulider = new SqlCommandBuilder(_adapter);

            _adapter.SelectCommand.Parameters.Add
                (new SqlParameter("K_KEYWORD", "%" + (object)txthtsearch.Text + "%"));

            DataSet ds = new DataSet();  //水桶
            _adapter.Fill(ds);
            con.Close();
            dataGridView1.DataSource = ds.Tables[0]; //DataTable

        }

        private void Frmhashtag_FormClosed(object sender, FormClosedEventArgs e)
        {
            _adapter.Update(dataGridView1.DataSource as DataTable);
        }

        private void dataGridView1_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            _position = e.RowIndex;
        }

        private void btnhtdelete_Click(object sender, EventArgs e)
        {
            DataTable dt = dataGridView1.DataSource as DataTable;
            DataRow dr = dt.Rows[_position];
            dr.Delete();
            _adapter.Update(dataGridView1.DataSource as DataTable); //刪除一筆完後馬上更新
        }

        private void btnhtedit_Click(object sender, EventArgs e)
        {
            DataTable dt = dataGridView1.DataSource as DataTable;
            DataRow dr = dt.Rows[_position];
            Chashtag h = new Chashtag();

            if (dr["hashtag編號"] != DBNull.Value)  
            h.fId = (int)dr["hashtag編號"];
            //if (dr["hashtag名稱"] != DBNull.Value)  
            h.fHashtag = dr["hashtag名稱"].ToString();

            Frmhashtagedit he = new Frmhashtagedit();
            he.Cht = h;
            he.ShowDialog();
            if
               (he.isOK == DialogResult.OK)
            {
                dr["hashtag名稱"] = he.Cht.fHashtag;
            }
        }

        private void dataGridView1_Paint(object sender, PaintEventArgs e)
        {
            resetGridstyle();
        }

        private void resetGridstyle()
        {
            bool isColorChanged = false;
            foreach (DataGridViewRow r in dataGridView1.Rows)
            {
                isColorChanged = !isColorChanged; //改每格顏色
                r.DefaultCellStyle.BackColor = Color.White; //改每格顏色
                if (isColorChanged)
                    r.DefaultCellStyle.BackColor = Color.FromArgb(240, 240, 240);

                r.Height = 50;
            }
        }

        private void btnhtsearch_Click(object sender, EventArgs e)
        {
            string sql = "SELECT * FROM hashtag";
            sql += " WHERE hashtag名稱 LIKE @K_KEYWORD";

            displaybySQL(sql);
        }
    }
}