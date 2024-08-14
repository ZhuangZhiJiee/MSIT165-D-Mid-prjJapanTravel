using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace slnJapanTravel.Model
{
    public class C行程訂單Manager
    {
        string _s = "Data Source=192.168.35.188,1433;Initial Catalog=JapanTravel;User ID=Luke;Password=0000;Encrypt=False";  //SQL ConnectionString
        //string _s = "Data Source=.;Initial Catalog=JapanTravel;Integrated Security=True;Encrypt=False";  //本機ConnectionString

        public void delete(int 行程訂單編號)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = _s;
            con.Open();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "DELETE FROM 行程訂單資料 WHERE 行程訂單編號=@K_行程訂單編號";
            cmd.Parameters.Add(new SqlParameter("K_行程訂單編號", (object)行程訂單編號));
            cmd.ExecuteNonQuery();

            con.Close();
        }

        public void create(C行程訂單資料 p)
        {
            string sql = "INSERT INTO 行程訂單資料(";
            sql += "會員ID,";
            sql += "行程批次編號,";
            sql += "數量,";
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
            sql += "@K_行程批次編號,";
            sql += "@K_數量,";
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
            cmd.Parameters.Add(new SqlParameter("K_行程批次編號", (object)p.行程批次編號));
            cmd.Parameters.Add(new SqlParameter("K_數量", (object)p.數量));
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
        }

        public void update(C行程訂單資料 p)
        {
            string sql = "UPDATE 行程訂單資料 SET";
            sql += " 會員ID=@K_會員ID, ";
            sql += " 行程批次編號=@K_行程批次編號, ";
            sql += " 數量=@K_數量, ";
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
            sql += " WHERE 行程訂單編號=@K_行程訂單編號 ";

            SqlConnection con = new SqlConnection();
            con.ConnectionString = _s;
            con.Open();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = sql;
            cmd.Parameters.Add(new SqlParameter("K_會員ID", (object)p.會員ID));
            cmd.Parameters.Add(new SqlParameter("K_行程批次編號", (object)p.行程批次編號));
            cmd.Parameters.Add(new SqlParameter("K_數量", (object)p.數量));
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
            cmd.Parameters.Add(new SqlParameter("K_行程訂單編號", (object)p.行程訂單編號));
            cmd.ExecuteNonQuery();

            con.Close();
        }

    }
}