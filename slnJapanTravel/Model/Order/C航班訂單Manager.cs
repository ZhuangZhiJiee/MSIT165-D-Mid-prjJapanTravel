using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace slnJapanTravel.Model
{

    public class C航班訂單Manager
    {
        //string _s = "Data Source=192.168.35.188,1433;Initial Catalog=JapanTravel;User ID=Luke;Password=0000;Encrypt=False";  //SQL ConnectionString
        string _s = "Data Source=.;Initial Catalog=JapanTravel;Integrated Security=True;Encrypt=False";  //本機ConnectionString

        public void delete(int 航班訂單編號)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = _s;
            con.Open();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "DELETE FROM 航班訂單資料 WHERE 航班訂單編號=@K_航班訂單編號";
            cmd.Parameters.Add(new SqlParameter("K_航班訂單編號", (object)航班訂單編號));
            cmd.ExecuteNonQuery();

            con.Close();
        }

        public void create(C航班訂單資料 p)
        {
            //新增資料至航班訂單資料
            string sql = "INSERT INTO 航班訂單資料(";
            sql += "會員ID,";
            sql += "下單時間,";
            sql += "付款方式編號,";
            sql += "付款狀態編號,";
            sql += "付款時間,";
            sql += "訂單狀態編號,";
            sql += "優惠券ID,";
            sql += "總金額,";
            sql += "備註,";
            sql += "評論星級,";
            sql += "評論內容,";
            sql += "評論日期,";
            sql += "評論狀態";
            sql += ")VALUES(";
            sql += "@K_會員ID,";
            sql += "@K_下單時間,";
            sql += "@K_付款方式編號,";
            sql += "@K_付款狀態編號,";
            sql += "@K_付款時間,";
            sql += "@K_訂單狀態編號,";
            sql += "@K_優惠券ID,";
            sql += "@K_總金額,";
            sql += "@K_備註,";
            sql += "@K_評論星級,";
            sql += "@K_評論內容,";
            sql += "@K_評論日期,";
            sql += "@K_評論狀態)";

            SqlConnection con = new SqlConnection();
            con.ConnectionString = _s;
            con.Open();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = sql;
            cmd.Parameters.Add(new SqlParameter("K_會員ID", (object)p.會員ID));
            cmd.Parameters.Add(new SqlParameter("K_下單時間", (object)p.下單時間));
            cmd.Parameters.Add(new SqlParameter("K_付款方式編號", (object)p.付款方式編號));
            cmd.Parameters.Add(new SqlParameter("K_付款狀態編號", (object)p.付款狀態編號));
            cmd.Parameters.Add(new SqlParameter("K_付款時間", (object)p.付款時間));
            cmd.Parameters.Add(new SqlParameter("K_訂單狀態編號", (object)p.訂單狀態編號));
            cmd.Parameters.Add(new SqlParameter("K_優惠券ID", (object)p.優惠券ID));
            cmd.Parameters.Add(new SqlParameter("K_總金額", (object)p.總金額));
            cmd.Parameters.Add(new SqlParameter("K_備註", (object)p.備註));
            cmd.Parameters.Add(new SqlParameter("K_評論星級", (object)p.評論星級));
            cmd.Parameters.Add(new SqlParameter("K_評論內容", (object)p.評論內容));
            cmd.Parameters.Add(new SqlParameter("K_評論日期", (object)p.評論日期));
            cmd.Parameters.Add(new SqlParameter("K_評論狀態", (object)p.評論狀態));
            cmd.ExecuteNonQuery();

            con.Close();


            //新增資料至航班訂單Detail
            string sql2 = "INSERT INTO 航班訂單資料(";
            sql2 += "會員ID,";
            sql2 += "下單時間,";
            sql2 += "付款方式編號,";
            sql2 += "付款狀態編號,";
            sql2 += "付款時間,";
            sql2 += "訂單狀態編號,";
            sql2 += "優惠券ID,";
            sql2 += "總金額,";
            sql2 += "備註,";
            sql2 += "評論星級,";
            sql2 += "評論內容,";
            sql2 += "評論日期,";
            sql2 += "評論狀態";
            sql2 += ")VALUES(";
            sql2 += "@K_會員ID,";
            sql2 += "@K_下單時間,";
            sql2 += "@K_付款方式編號,";
            sql2 += "@K_付款狀態編號,";
            sql2 += "@K_付款時間,";
            sql2 += "@K_訂單狀態編號,";
            sql2 += "@K_優惠券ID,";
            sql2 += "@K_總金額,";
            sql2 += "@K_備註,";
            sql2 += "@K_評論星級,";
            sql2 += "@K_評論內容,";
            sql2 += "@K_評論日期,";
            sql2 += "@K_評論狀態)";

            SqlConnection con2 = new SqlConnection();
            con2.ConnectionString = _s;
            con2.Open();

            SqlCommand cmd2 = new SqlCommand();
            cmd2.Connection = con2;
            cmd2.CommandText = sql2;
            cmd2.Parameters.Add(new SqlParameter("K_會員ID", (object)p.會員ID));
            cmd2.Parameters.Add(new SqlParameter("K_下單時間", (object)p.下單時間));
            cmd2.Parameters.Add(new SqlParameter("K_付款方式編號", (object)p.付款方式編號));
            cmd2.Parameters.Add(new SqlParameter("K_付款狀態編號", (object)p.付款狀態編號));
            cmd2.Parameters.Add(new SqlParameter("K_付款時間", (object)p.付款時間));
            cmd2.Parameters.Add(new SqlParameter("K_訂單狀態編號", (object)p.訂單狀態編號));
            cmd2.Parameters.Add(new SqlParameter("K_優惠券ID", (object)p.優惠券ID));
            cmd2.Parameters.Add(new SqlParameter("K_總金額", (object)p.總金額));
            cmd2.Parameters.Add(new SqlParameter("K_備註", (object)p.備註));
            cmd2.Parameters.Add(new SqlParameter("K_評論星級", (object)p.評論星級));
            cmd2.Parameters.Add(new SqlParameter("K_評論內容", (object)p.評論內容));
            cmd2.Parameters.Add(new SqlParameter("K_評論日期", (object)p.評論日期));
            cmd2.Parameters.Add(new SqlParameter("K_評論狀態", (object)p.評論狀態));
            cmd2.ExecuteNonQuery();

            con2.Close();

        }

        public void update(C航班訂單資料 p)
        {
            string sql = "UPDATE 航班訂單資料 SET";
            sql += " 會員ID=@K_會員ID, ";
            sql += " 下單時間=@K_下單時間, ";
            sql += " 付款方式編號=@K_付款方式編號, ";
            sql += " 付款狀態編號=@K_付款狀態編號, ";
            sql += " 付款時間=@K_付款時間, ";
            sql += " 訂單狀態編號=@K_訂單狀態編號, ";
            sql += " 優惠券ID=@K_優惠券ID, ";
            sql += " 總金額=@K_總金額, ";
            sql += " 備註=@K_備註, ";
            sql += " 評論星級=@K_評論星級, ";
            sql += " 評論內容=@K_評論內容, ";
            sql += " 評論日期=@K_評論日期, ";
            sql += " 評論狀態=@K_評論狀態 ";
            sql += " WHERE 航班訂單編號=@K_航班訂單編號 ";

            SqlConnection con = new SqlConnection();
            con.ConnectionString = _s;
            con.Open();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = sql;
            cmd.Parameters.Add(new SqlParameter("K_會員ID", (object)p.會員ID));
            cmd.Parameters.Add(new SqlParameter("K_下單時間", (object)p.下單時間));
            cmd.Parameters.Add(new SqlParameter("K_付款方式編號", (object)p.付款方式編號));
            cmd.Parameters.Add(new SqlParameter("K_付款狀態編號", (object)p.付款狀態編號));
            cmd.Parameters.Add(new SqlParameter("K_付款時間", (object)p.付款時間));
            cmd.Parameters.Add(new SqlParameter("K_訂單狀態編號", (object)p.訂單狀態編號));
            cmd.Parameters.Add(new SqlParameter("K_優惠券ID", (object)p.優惠券ID));
            cmd.Parameters.Add(new SqlParameter("K_總金額", (object)p.總金額));
            cmd.Parameters.Add(new SqlParameter("K_備註", (object)p.備註));
            cmd.Parameters.Add(new SqlParameter("K_評論星級", (object)p.評論星級));
            cmd.Parameters.Add(new SqlParameter("K_評論內容", (object)p.評論內容));
            cmd.Parameters.Add(new SqlParameter("K_評論日期", (object)p.評論日期));
            cmd.Parameters.Add(new SqlParameter("K_評論狀態", (object)p.評論狀態));
            cmd.Parameters.Add(new SqlParameter("K_航班訂單編號", (object)p.航班訂單編號));
            cmd.ExecuteNonQuery();

            con.Close();
        }

    }
}
