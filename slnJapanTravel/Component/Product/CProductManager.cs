using slnJapanTravel.Model;
using slnJapanTravel.Model.Product;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace slnJapanTravel.Component.Product
{
    public class CProductManager
    {
        //string _s = "Data Source=192.168.35.188;Initial Catalog=JapanTravel;User ID=Ting;Password=0000;Encrypt=False";
        string _s = "Data Source=.;Initial Catalog=JapanTravel;Integrated Security=True;Encrypt=False";
        public void create(CItineraryMain main)
        {
            string sqlItinerary = "INSERT INTO Itinerary行程 (";
            sqlItinerary += "行程編號, ";
            sqlItinerary += "行程名稱, ";
            sqlItinerary += "體驗, ";
            sqlItinerary += "總團位, ";
            sqlItinerary += "價格, ";
            sqlItinerary += "地區) ";
            sqlItinerary += "VALUES (";
            sqlItinerary += "@K_FID,";
            sqlItinerary += "@K_FNAME,";
            sqlItinerary += "@K_FACT,";
            sqlItinerary += "@K_FSPACE,";
            sqlItinerary += "@K_FPRICE,";
            sqlItinerary += "@K_FAREA)";

            sqlItinerary += "SELECT SCOPE_IDENTITY();";
            // 這行會返回剛插入行程的系統編號，函數是返回當前作用域中最近插入的自動增量值。也就是說，它只會返回當前執行 INSERT 陳述式時所產生的自動增量值，並不會受到任何觸發器所產生的自動增量值的影響。

            string sqlTime = "INSERT INTO ItineraryTime行程批次 (";
            sqlTime += "行程系統編號, ";
            sqlTime += "出發日期) ";
            sqlTime += "VALUES (";
            sqlTime += "@K_FSID,";
            sqlTime += "@K_DATE)";

            SqlConnection con = new SqlConnection(); //new類別
            con.ConnectionString = _s; //連接自來水廠
            con.Open();

            SqlCommand cmdItinerary = new SqlCommand(sqlItinerary, con);
            cmdItinerary.Parameters.Add(new SqlParameter("K_FID", main.行程編號));
            cmdItinerary.Parameters.Add(new SqlParameter("K_FNAME", main.行程名稱));
            cmdItinerary.Parameters.Add(new SqlParameter("K_FACT", main.體驗));
            cmdItinerary.Parameters.Add(new SqlParameter("K_FSPACE", main.總團位));
            cmdItinerary.Parameters.Add(new SqlParameter("K_FPRICE", main.價格));
            cmdItinerary.Parameters.Add(new SqlParameter("K_FAREA", main.地區));
            //cmd.Parameters.Add(new SqlParameter("K_FPS", main.出團備註));

            object result = cmdItinerary.ExecuteScalar();
            if (result != null)
            {
                main.行程系統編號 = Convert.ToInt32(result);
            }
            //SqlCommand cmdTime = new SqlCommand(sqlTime, con);
            //cmdTime.Parameters.Add(new SqlParameter("K_FSID", main.行程系統編號));
            //cmdTime.Parameters.Add(new SqlParameter("K_DATE", main.date.出發日期));
            //cmdTime.ExecuteNonQuery();

            foreach (var date in main.date.行程系統編號.ToString())
            {
                SqlCommand cmdTime = new SqlCommand(sqlTime, con);
                cmdTime.Parameters.Add(new SqlParameter("K_FSID", main.行程系統編號));  // 假設行程系統編號存在
                cmdTime.Parameters.Add(new SqlParameter("K_DATE", main.date.出發日期));
                cmdTime.ExecuteNonQuery();
            }

            con.Close();
        }

        public void delete(CItineraryMain main)
        {
            if (main.date == null)
                main.date = new CItineraryDate();

            string sqlDeleteTime = "DELETE FROM ItineraryTime行程批次 WHERE 行程系統編號 = @K_FSID";
            string sqlDeleteItinerary = "DELETE FROM Itinerary行程 WHERE 行程編號 = @K_FID";

            SqlConnection con = new SqlConnection();
            con.ConnectionString = _s;
            con.Open();

            // 刪除 Itinerary行程表的資料
            SqlCommand cmdItinerary = new SqlCommand(sqlDeleteItinerary, con);
            cmdItinerary.Parameters.Add(new SqlParameter("K_FID", main.行程編號));
            cmdItinerary.ExecuteNonQuery();
            // 刪除 ItineraryTime行程批次表的資料
            SqlCommand cmdTime = new SqlCommand(sqlDeleteTime, con);
            cmdTime.Parameters.Add(new SqlParameter("K_FSID", main.date.行程系統編號));
            cmdTime.ExecuteNonQuery();

            con.Close();
        }

    }
}
