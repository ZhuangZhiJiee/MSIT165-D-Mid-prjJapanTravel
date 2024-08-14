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
    public partial class FrmItineraryCart : Form
    {
        string _s = "Data Source=192.168.35.188,1433;Initial Catalog=JapanTravel;User ID=Luke;Password=0000;Encrypt=False";  //SQL ConnectionString
        //string _s = "Data Source=.;Initial Catalog=JapanTravel;Integrated Security=True;Encrypt=False";  //本機ConnectionString

        public FrmItineraryCart()
        {
            InitializeComponent();
        }
        private void FrmItineraryCart_Load(object sender, EventArgs e)
        {
            //// TODO: 這行程式碼會將資料載入 'japanTravelDataSet.付款方式' 資料表。您可以視需要進行移動或移除。
            //this.付款方式TableAdapter.Fill(this.japanTravelDataSet.付款方式);
            //this.cbPaymentMethod.SelectedIndex = -1;
            //// TODO: 這行程式碼會將資料載入 'japanTravelDataSet.Area地區' 資料表。您可以視需要進行移動或移除。
            //this.area地區TableAdapter.Fill(this.japanTravelDataSet.Area地區);
            //this.cbArea.SelectedIndex = -1;
            //// TODO: 這行程式碼會將資料載入 'japanTravelDataSet.Theme主題' 資料表。您可以視需要進行移動或移除。
            //this.theme主題TableAdapter.Fill(this.japanTravelDataSet.Theme主題);
            //this.cbTheme.SelectedIndex = -1;


            displayShipBySql("SELECT * FROM Itinerary行程");
        }

        private void displayShipBySql(string sql)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = _s;
            con.Open();

            SqlDataAdapter adapter = new SqlDataAdapter(sql, con);
            adapter.SelectCommand.Parameters.Add(
                new SqlParameter("K_KEYWORD", "%" + (object)txtKeyword.Text + "%"));
            DataSet ds = new DataSet();
            adapter.Fill(ds);
            con.Close();

            flowLayoutPanel1.Controls.Clear();
            foreach (DataRow r in ds.Tables[0].Rows)
            {
                CRoute CRoute = new CRoute();
                CImage CImage = new CImage();
                CPort CPort = new CPort();
                CSchedule CSchedule = new CSchedule();


            }
        }

        private void txtKeyword_Click(object sender, EventArgs e)
        {
            if (txtKeyword.Text == "關鍵字")
                txtKeyword.Clear();
        }
    }
}