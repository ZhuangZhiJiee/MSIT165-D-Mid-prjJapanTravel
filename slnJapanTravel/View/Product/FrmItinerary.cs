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
    {   string sq = "INSERT INTO Itinerary行程 (體驗) values ('24SUP0922')";
        SqlDataAdapter _adapter;
        private SqlCommandBuilder _builder;
        //string _s = "Data Source=192.168.35.188;Initial Catalog=JapanTravel;User ID=Ting;Password=0000;Encrypt=False";
        string _s = "Data Source=.;Initial Catalog=JapanTravel;Integrated Security=True;Encrypt=False";
        public FrmItinerary()
        {
            InitializeComponent();
        }
        private void FrmItinerary_Load(object sender, EventArgs e)
        {
            displayBySql("SELECT [行程編號], [行程名稱], [體驗], [體驗名稱],[可預約人數], [總團位], [價格], [主題], [地區], [出團備註]" 
                +"\r\nFROM [dbo].[Itinerary行程]\r\nJOIN [dbo].[Activity體驗]\r\nON[體驗編號]=[體驗]");
        }

        private void displayBySql(string sql)
        {
            SqlConnection con = new SqlConnection(); //new類別
            con.ConnectionString = _s; //連接自來水廠
            con.Open();

            _adapter = new SqlDataAdapter(sql, con); 
            _builder = new SqlCommandBuilder(_adapter); 
            //SqlCommand cmd = new SqlCommand(sq, con);
            //cmd.ExecuteNonQuery();
            DataSet ds = new DataSet(); 
            _adapter.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            con.Close();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            FrmItineraryInsert f = new FrmItineraryInsert();
            f.ShowDialog();

            if (f.isOK == DialogResult.OK)
            {
                DataTable dt = dataGridView1.DataSource as DataTable;
                DataRow dr = dt.NewRow();
                dr["行程編號 (分類)"] = f.main.行程編號;
                dr["體驗"] = f.main.體驗;
                dr["行程名稱"] = f.main.行程名稱;
                dr["總團位"] = f.main.總團位.ToString();
                dr["價格"] = f.main.價格.ToString();
                dr["地區"] = f.main.地區.ToString();
                dt.Rows.Add(dr); 
            }
        }
    }
}
