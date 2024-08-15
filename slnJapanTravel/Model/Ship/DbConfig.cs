using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace slnJapanTravel.Model.Ship
{
    public static class DbConfig
    {
        private static readonly string LocalConnectionString =
        "Data Source =.; Initial Catalog = JapanTravel; Integrated Security = True; Encrypt = False";

        private static readonly string RemoteConnectionString =
        "Data Source = 192.168.35.188; Initial Catalog = JapanTravel;Persist Security Info = True; User ID = jojo; Password = 0000; Encrypt = False;";

        private static string _connectionString;

        static DbConfig()
        {
            // 嘗試使用本機資料庫連接字串
            if (TestConnection(LocalConnectionString))
            {
                _connectionString = LocalConnectionString;
            }
            else if (TestConnection(RemoteConnectionString))
            {
                // 如果本機資料庫連接失敗，則使用遠端資料庫連接字串
                _connectionString = RemoteConnectionString;
            }
            else
            {
                throw new Exception("無法連接到任何資料庫。");
            }
        }

        public static string GetConnectionString()
        {
            return _connectionString;
        }

        private static bool TestConnection(string connectionString)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();
                    return true;
                }
            }
            catch
            {
                return false;
            }
        }
    }
}
