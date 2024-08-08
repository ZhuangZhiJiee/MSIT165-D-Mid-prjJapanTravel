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
    public partial class FrmItinerary : Form
    {
        SqlDataAdapter _adapter;
        private SqlCommandBuilder _builder;
        
        public FrmItinerary()
        {
            InitializeComponent();
        }
        private void FrmItinerary_Load(object sender, EventArgs e)
        {
            displayBySql("SELECT * FROM Itinerary行程");
        }

        private void displayBySql(string sql)
        {
            SqlConnection con = new SqlConnection(); //new類別
            con.ConnectionString = @"Data Source=192.168.35.188;Initial Catalog=JapanTravel;User ID=Ting;Password=0000;Encrypt=False"; //連接自來水廠
            con.Open();

            _adapter = new SqlDataAdapter(sql, con); 
            _builder = new SqlCommandBuilder(_adapter); 
            DataSet ds = new DataSet(); 
            _adapter.Fill(ds);
            ItinerarydataGridView.DataSource = ds.Tables[0];
            con.Close();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            FrmItineraryInsert f = new FrmItineraryInsert();
            f.ShowDialog();

            if (f.isOK == DialogResult.OK)
            {
                DataTable dt = ItinerarydataGridView.DataSource as DataTable;
                DataRow dr = dt.NewRow();
                dr["行程編號 (分類)"] = f.main.行程編號;
                dr["行程名稱"] = f.main.行程名稱;
                dr["總團位"] = f.main.總團位.ToString();
                dr["價格"] = f.main.價格.ToString();
                dt.Rows.Add(dr); 
            }
        }

        private void FrmItinerary_FormClosed(object sender, FormClosedEventArgs e)
        {
            _adapter.Update(ItinerarydataGridView.DataSource as DataTable);
        }
    }
}
