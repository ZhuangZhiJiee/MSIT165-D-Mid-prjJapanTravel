using Microsoft.SqlServer.Server;
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
        public static List<string> DepartureDate { get; set; } = new List<string>();
        public static List<byte[]> Picture { get; set; } = new List<byte[]>();
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

            string sqlPic = "INSERT INTO Picture圖片 (";
            sqlPic += "行程系統編號, ";
            sqlPic += "圖片, ";
            sqlPic += "圖片名稱, ";
            sqlPic += "圖片描述) ";
            sqlPic += "VALUES (";
            sqlPic += "@K_FSID,";
            sqlPic += "@K_PIC,";
            sqlPic += "@K_PNAME,";
            sqlPic += "@K_PDES)";

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

            foreach (string date in CProductManager.DepartureDate)
            {
                SqlCommand cmdTime = new SqlCommand(sqlTime, con);
                cmdTime.Parameters.Add(new SqlParameter("K_FSID", main.行程系統編號));
                cmdTime.Parameters.Add(new SqlParameter("K_DATE", date));
                cmdTime.ExecuteNonQuery();

            }
            foreach (byte[] pic in CProductManager.Picture)
            {
                SqlCommand cmdPic = new SqlCommand(sqlPic, con);
                cmdPic.Parameters.Add(new SqlParameter("K_FSID", main.行程系統編號));
                cmdPic.Parameters.Add(new SqlParameter("K_PIC",main.pic.圖片));
                cmdPic.Parameters.Add(new SqlParameter("K_PNAME", main.pic.圖片名稱));
                cmdPic.Parameters.Add(new SqlParameter("K_PDES", main.pic.圖片描述));
                cmdPic.ExecuteNonQuery();
            }
            

            con.Close();
        }

        public void delete(CItineraryMain main)
        {
            int itinerarySystemId = -1; // 初始化為 -1
            string sqlSelectSystemId = "SELECT 行程系統編號 FROM Itinerary行程 WHERE 行程編號 = @K_FID";
            SqlConnection con = new SqlConnection(_s);
            SqlCommand cmdSelect = new SqlCommand(sqlSelectSystemId, con);
            cmdSelect.Parameters.Add(new SqlParameter("K_FID", main.行程編號));

            con.Open();
            object result = cmdSelect.ExecuteScalar();
            if (result != null)
            {
                itinerarySystemId = Convert.ToInt32(result);
            }

            if (itinerarySystemId > 0) // 檢查是否成功獲取行程系統編號
            {
                // 刪除 ItineraryTime行程批次表的資料
                string sqlDeleteTime = "DELETE FROM ItineraryTime行程批次 WHERE 行程系統編號 = @K_FSID";
                SqlCommand cmdTime = new SqlCommand(sqlDeleteTime, con);
                cmdTime.Parameters.Add(new SqlParameter("K_FSID", itinerarySystemId));
                cmdTime.ExecuteNonQuery();

                // 刪除 Itinerary行程表的資料
                string sqlDeleteItinerary = "DELETE FROM Itinerary行程 WHERE 行程編號 = @K_FID";
                SqlCommand cmdItinerary = new SqlCommand(sqlDeleteItinerary, con);
                cmdItinerary.Parameters.Add(new SqlParameter("K_FID", main.行程編號));
                cmdItinerary.ExecuteNonQuery();
            }

            con.Close();
        }

        public void copy(CItineraryMain main)
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

            SqlConnection con = new SqlConnection(_s);
            con.Open();

            SqlCommand cmdItinerary = new SqlCommand(sqlItinerary, con);
            cmdItinerary.Parameters.Add(new SqlParameter("K_FID", main.行程編號));
            cmdItinerary.Parameters.Add(new SqlParameter("K_FNAME", main.行程名稱));
            cmdItinerary.Parameters.Add(new SqlParameter("K_FACT", main.體驗));
            cmdItinerary.Parameters.Add(new SqlParameter("K_FSPACE", main.總團位));
            cmdItinerary.Parameters.Add(new SqlParameter("K_FPRICE", main.價格));
            cmdItinerary.Parameters.Add(new SqlParameter("K_FAREA", main.地區));


            object result = cmdItinerary.ExecuteScalar();
            if (result != null)
            {
                main.行程系統編號 = Convert.ToInt32(result);
            }


            foreach (var date in main.date.行程系統編號.ToString())
            {
                SqlCommand cmdTime = new SqlCommand(sqlTime, con);
                cmdTime.Parameters.Add(new SqlParameter("K_FSID", main.行程系統編號));
                cmdTime.Parameters.Add(new SqlParameter("K_DATE", main.date.出發日期));
                cmdTime.ExecuteNonQuery();
            }

            con.Close();
        }
        public void update(CItineraryMain main)
        {
            string sqlItinerary = "UPDATE Itinerary行程 SET";
            sqlItinerary += " 行程名稱=@K_FNAME, ";
            sqlItinerary += " 體驗=@K_FACT, ";
            sqlItinerary += " 總團位=@K_FSPACE, ";
            sqlItinerary += " 價格=@K_FPRICE, ";
            sqlItinerary += " 地區=@K_FAREA ";
            sqlItinerary += " WHERE 行程編號=@K_FID ";

            string sqlTimeDelete = "DELETE FROM ItineraryTime行程批次 WHERE 行程系統編號 = @K_FSID";
            string sqlTimeInsert = "INSERT INTO ItineraryTime行程批次 (";
            sqlTimeInsert += "行程系統編號, ";
            sqlTimeInsert += "出發日期) ";
            sqlTimeInsert += "VALUES (";
            sqlTimeInsert += "@K_FSID,";
            sqlTimeInsert += "@K_DATE)";

            string sqlPicDelete = "DELETE FROM Picture圖片 WHERE 行程系統編號 = @K_FSID";
            string sqlPicInsert = "INSERT INTO Picture圖片 (";
            sqlPicInsert += "行程系統編號, ";
            sqlPicInsert += "圖片, ";
            sqlPicInsert += "圖片名稱, ";
            sqlPicInsert += "圖片描述) ";
            sqlPicInsert += "VALUES (";
            sqlPicInsert += "@K_FSID,";
            sqlPicInsert += "@K_PIC,";
            sqlPicInsert += "@K_PNAME,";
            sqlPicInsert += "@K_PDES)";

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
            // 插入新的出發日期
            if (main.行程系統編號 > 0)
            {
                // 刪除舊的出發日期
                using (SqlCommand cmdTimeDelete = new SqlCommand(sqlTimeDelete, con))
                {
                    cmdTimeDelete.Parameters.Add(new SqlParameter("K_FSID", main.行程系統編號));
                    cmdTimeDelete.ExecuteNonQuery();
                }

                // 插入新的出發日期
                foreach (string date in CProductManager.DepartureDate)
                {
                    using (SqlCommand cmdTimeInsert = new SqlCommand(sqlTimeInsert, con))
                    {
                        cmdTimeInsert.Parameters.Add(new SqlParameter("K_FSID", main.行程系統編號));
                        cmdTimeInsert.Parameters.Add(new SqlParameter("K_DATE", date));
                        cmdTimeInsert.ExecuteNonQuery();
                    }
                }
                using (SqlCommand cmdPicDelete = new SqlCommand(sqlPicDelete, con))
                {
                    cmdPicDelete.Parameters.Add(new SqlParameter("K_FSID", main.行程系統編號));
                    cmdPicDelete.ExecuteNonQuery();
                }

                // 插入新的圖片
                foreach (byte[] pic in CProductManager.Picture)
                {
                    using (SqlCommand cmdPicInsert = new SqlCommand(sqlPicInsert, con))
                    {
                        cmdPicInsert.Parameters.Add(new SqlParameter("K_FSID", main.行程系統編號));
                        cmdPicInsert.Parameters.Add(new SqlParameter("K_PIC", main.pic.圖片));
                        cmdPicInsert.Parameters.Add(new SqlParameter("K_PNAME", main.pic.圖片名稱));
                        cmdPicInsert.Parameters.Add(new SqlParameter("K_PDES", main.pic.圖片描述));
                        cmdPicInsert.ExecuteNonQuery();
                    }
                }
            }
        }

    }
}
