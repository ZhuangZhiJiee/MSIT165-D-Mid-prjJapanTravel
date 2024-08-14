using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace slnJapanTravel.View.Blog
{
    public partial class Frmarticleedit : Form
    {
        
        private DialogResult _isOk;
        public DialogResult isOK
        {
            get { return _isOk; }
        }
        string str = "Data Source = 192.168.35.188,1433; Initial Catalog = JapanTravel; User ID = song; Password = 0000; Encrypt = False";

        public Frmarticleedit()
        {
            InitializeComponent();
        }

        private void lblstatus_Click(object sender, EventArgs e)
        {

        }

        private void lbllaunchtime1_Click(object sender, EventArgs e)
        {
            this.Text=DateTime.Now.ToShortDateString();
        }

        private void Frmarticleedit_Load(object sender, EventArgs e)
        {

        }
        private void displayPhototextBySql(string sql)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = str;
            con.Open();

            SqlDataAdapter adapter = new SqlDataAdapter(sql, con);

            //adapter.SelectCommand.Parameters.Add
              //  (new SqlParameter("K_KEYWORD", "%" + (object)txtKeyword.Text + "%"));

           // DataSet ds = new DataSet();  //水桶
           // adapter.Fill(ds);
            con.Close();
            flowLayoutPanel1.Controls.Clear(); //把舊的clear掉

            //foreach (DataRow r in ds.Tables[0].Rows)
            {
                //CMovie m = new CMovie();
                //m.fCost = (decimal)r["fCost"];
                //m.fPrice = (decimal)r["fPrice"];
                //m.fQty = (int)r["fQty"];
                //m.fName = r["fName"].ToString();
                //m.fId = (int)r["fId"];
                //if (r["fImage"] != DBNull.Value)
                //    m.fImage = (byte[])r["fImage"];


                //MovieBox b = new MovieBox();
                //b.movie = m;
                //b.buyMe += this.moveClick;
                //flowLayoutPanel1.Controls.Add(b);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            _isOk = DialogResult.OK;
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
