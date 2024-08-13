using slnJapanTravel.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace slnJapanTravel.Component.Product
{
    public class CProductManager
    {
        string _s = "Data Source=192.168.35.188;Initial Catalog=JapanTravel;User ID=Ting;Password=0000;Encrypt=False";
        public void create(CItineraryMain main)
        {
            string sq = "INSERT INTO Itinerary行程 (";
            sq += "行程編號, ";
            sq += "行程名稱, ";
            sq += "體驗, ";
            sq += "總團位, ";
            sq += "價格, ";
            sq += "地區) ";
            sq += "VALUES (";
            sq += "@K_FID,";
            sq += "@K_FNAME,";
            sq += "@K_FACT,";
            sq += "@K_FSPACE,";
            sq += "@K_FPRICE,";
            sq += "@K_FAREA)";


            SqlConnection con = new SqlConnection(); //new類別
            con.ConnectionString = _s; //連接自來水廠
            con.Open();

            SqlCommand cmd = new SqlCommand(sq, con);
            cmd.Parameters.Add(new SqlParameter("K_FID", main.行程編號));
            cmd.Parameters.Add(new SqlParameter("K_FNAME", main.行程名稱));
            cmd.Parameters.Add(new SqlParameter("K_FACT", main.體驗));
            cmd.Parameters.Add(new SqlParameter("K_FSPACE", main.總團位));
            cmd.Parameters.Add(new SqlParameter("K_FPRICE", main.價格));
            cmd.Parameters.Add(new SqlParameter("K_FAREA", main.地區));
            //cmd.Parameters.Add(new SqlParameter("K_FPS", main.出團備註));
            cmd.ExecuteNonQuery();
            con.Close();
        }
    }
}
