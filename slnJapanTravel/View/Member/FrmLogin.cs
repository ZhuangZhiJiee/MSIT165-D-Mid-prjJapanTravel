using slnJapanTravel.Model.Member;
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
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }
        string _constr = "Data Source=.;Initial Catalog=JapanTravel;Integrated Security=True;Encrypt=False";
        public DialogResult _isok;
        private CLoginAdmin _loginAdmin;
        public CLoginAdmin loginAdmin
        {
            get
            {
                return _loginAdmin;
            }
            set { _loginAdmin = value; }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(_constr);
            con.Open();
            SqlCommand cmd = new SqlCommand("Login", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@account", (object)txtAccount.Text));
            cmd.Parameters.Add(new SqlParameter("@password", (object)txtPassword.Text));
            SqlDataReader reader = cmd.ExecuteReader();

            if (reader.Read())
            {
                _isok = DialogResult.OK;
                this.Close();
                _loginAdmin = new CLoginAdmin();
                _loginAdmin.管理員ID = Convert.ToInt32(reader["管理員ID"]);
                _loginAdmin.管理員姓名 = reader["管理員姓名"].ToString();
                _loginAdmin.管理員帳號 = reader["帳號"].ToString();
                _loginAdmin.管理員密碼 = reader["密碼"].ToString();
                _loginAdmin.管理員信箱 = reader["Email"].ToString();
                if(reader["照片"]!=DBNull.Value)
                    _loginAdmin.管理員照片 = (byte[])(reader["照片"]);
                _loginAdmin.會員管理權限 = Convert.ToBoolean(reader["會員管理權限"]);
                _loginAdmin.管理員管理權限 = Convert.ToBoolean(reader["管理員管理權限"]);
                _loginAdmin.行程管理權限 = Convert.ToBoolean(reader["行程管理權限"]);
                _loginAdmin.訂單管理權限 = Convert.ToBoolean(reader["訂單管理權限"]);
                _loginAdmin.航班管理權限 = Convert.ToBoolean(reader["航班管理權限"]);
                _loginAdmin.部落格管理權限 = Convert.ToBoolean(reader["部落格管理權限"]);
                _loginAdmin.評論管理權限 = Convert.ToBoolean(reader["評論管理權限"]);
                _loginAdmin.優惠券管理權限 = Convert.ToBoolean(reader["優惠券管理權限"]);
            }
            else 
            {
                MessageBox.Show("登入失敗");
            }
        }
    }
}
