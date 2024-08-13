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
                dr["hashtag名稱"] = h.ht.fHashtag;
                dt.Rows.Add(dr);

            }
        }
        private void Frmhashtag_Load(object sender, EventArgs e)
        {
            displaybtSQL("SELECT * FROM hashtag");
        }

        private void displaybtSQL(string sql)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = str;
;
            con.Open();

            _adapter = new SqlDataAdapter(sql, con);
            _bulider = new SqlCommandBuilder(_adapter);

            _adapter.SelectCommand.Parameters.Add
                (new SqlParameter("K_KEYWORD", "%" + (object)txtsearch.Text + "%"));

            DataSet ds = new DataSet();  //水桶
            _adapter.Fill(ds);
            con.Close();
            dataGridView1.DataSource = ds.Tables[0]; //DataTable

        }

        private void Frmhashtag_FormClosed(object sender, FormClosedEventArgs e)
        {
            _adapter.Update(dataGridView1.DataSource as DataTable);
        }
    }
}