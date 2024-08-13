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
using System.Xml.Linq;

namespace slnJapanTravel.View
{
    public partial class FrmAdmin : Form
    {
        public FrmAdmin()
        {
            InitializeComponent();
        }
        string _constr = "Data Source=.;Initial Catalog=JapanTravel;Integrated Security=True;Encrypt=False";
        string _seladm = "select * from Admin管理員";
        DataSet _ds;
        CAdmin _newadmin;
        SqlConnection _con;
        SqlDataAdapter _adapter;
        private void ControllerDisable()
        {
            txtName.Enabled = false;
            txtEmail.Enabled = false;
            txtAccount.Enabled = false;
            txtPassword.Enabled = false;
            picAdmin.Enabled = false;
            btnSave.Enabled = false;
            btnCancel.Enabled = false;
            cbAdmin.Enabled = false;
            cbMember.Enabled = false;
            cbItinerary.Enabled = false;
            cbShip.Enabled = false;
            cbOrder.Enabled = false;
            cbBlog.Enabled = false;
            cbComment.Enabled = false;
            cbCoupon.Enabled = false;
            txtName.Text = "";
            txtEmail.Text = "";
            txtAccount.Text = "";
            txtPassword.Text = "";
        }
        private void EmptyAndEnable()
        {
            txtName.Enabled = true;
            txtName.Text = "";
            txtEmail.Enabled = true;
            txtEmail.Text = "";
            txtAccount.Enabled = true;
            txtAccount.Text = "";
            txtPassword.Enabled = true;
            txtPassword.Text = "";
            picAdmin.Enabled = true;
            picAdmin.Image = null;
            btnSave.Enabled = true;
            btnCancel.Enabled = true;
            cbAdmin.Enabled = true;
            cbAdmin.Checked = false;
            cbMember.Enabled = true;
            cbMember.Checked = false;
            cbItinerary.Enabled = true;
            cbItinerary.Checked = false;
            cbShip.Enabled = true;
            cbShip.Checked = false;
            cbOrder.Enabled = true;
            cbOrder.Checked = false;
            cbBlog.Enabled = true;
            cbBlog.Checked = false;
            cbComment.Enabled = true;
            cbComment.Checked = false;
            cbCoupon.Enabled = true;
            cbCoupon.Checked = false;
        }
        private void Enable()
        {
            txtName.Enabled = true;
            txtEmail.Enabled = true;
            txtAccount.Enabled = true;
            txtPassword.Enabled = true;
            picAdmin.Enabled = true;
            btnSave.Enabled = true;
            btnCancel.Enabled = true;
            cbAdmin.Enabled = true;
            cbMember.Enabled = true;
            cbItinerary.Enabled = true;
            cbShip.Enabled = true;
            cbOrder.Enabled = true;
            cbBlog.Enabled = true;
            cbComment.Enabled = true;
            cbCoupon.Enabled = true;
        }
        private void displayonDatagridview()
        {
            _con = new SqlConnection(_constr);
            SqlDataAdapter adapter = new SqlDataAdapter(_seladm, _con);
            _ds = new DataSet();
            adapter.Fill(_ds, "管理員資料表");

           
            txtName.DataBindings.Add("Text", _ds, "管理員資料表.管理員姓名");
            txtEmail.DataBindings.Add("Text", _ds, "管理員資料表.Email");
            txtAccount.DataBindings.Add("Text", _ds, "管理員資料表.帳號");
            txtPassword.DataBindings.Add("Text", _ds, "管理員資料表.密碼");
            cbAdmin.DataBindings.Add("Checked", _ds, "管理員資料表.管理員管理權限");
            cbMember.DataBindings.Add("Checked", _ds, "管理員資料表.會員管理權限");
            cbItinerary.DataBindings.Add("Checked", _ds, "管理員資料表.行程管理權限");
            cbShip.DataBindings.Add("Checked", _ds, "管理員資料表.航線管理權限");
            cbOrder.DataBindings.Add("Checked", _ds, "管理員資料表.訂單管理權限");
            cbBlog.DataBindings.Add("Checked", _ds, "管理員資料表.部落格管理權限");
            cbComment.DataBindings.Add("Checked", _ds, "管理員資料表.評論管理權限");
            cbCoupon.DataBindings.Add("Checked", _ds, "管理員資料表.優惠券管理權限");

            dgvAdmin.DataSource = _ds;
            dgvAdmin.DataMember = "管理員資料表";


            dgvAdmin.Columns[0].Visible = false;
            dgvAdmin.Columns[5].Visible = false;
        }
        private void FrmAdmin_Load(object sender, EventArgs e)
        {
            ControllerDisable();
            displayonDatagridview();
        }
        private void tsbInsert_Click(object sender, EventArgs e)
        {
            EmptyAndEnable();
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            ControllerDisable();
        }

        private void tsbAlter_Click(object sender, EventArgs e)
        {
            Enable();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            _newadmin = new CAdmin();
            _newadmin.管理員姓名 = txtName.Text;
            _newadmin.管理員信箱 = txtEmail.Text;
            _newadmin.管理員帳號 = txtAccount.Text;
            _newadmin.管理員密碼 = txtAccount.Text;
            _newadmin.管理員管理權限 = cbAdmin.Checked;
            _newadmin.會員管理權限 = cbMember.Checked;
            _newadmin.行程管理權限 = cbItinerary.Checked;
            _newadmin.航線管理權限 = cbShip.Checked;
            _newadmin.訂單管理權限 = cbOrder.Checked;
            _newadmin.部落格管理權限 = cbBlog.Checked;
            _newadmin.評論管理權限 = cbComment.Checked;
            _newadmin.優惠券管理權限 = cbCoupon.Checked;

            DataTable dt = _ds.Tables["管理員資料表"];
            DataRow dr = dt.NewRow();
            dr["管理員姓名"] = _newadmin.管理員姓名;
            dr["帳號"] = _newadmin.管理員帳號;
            dr["密碼"] = _newadmin.管理員密碼;
            dr["Email"] = _newadmin.管理員信箱;
            dr["會員管理權限"] = _newadmin.會員管理權限;
            dr["管理員管理權限"] = _newadmin.管理員管理權限;
            dr["行程管理權限"] = _newadmin.行程管理權限;
            dr["航線管理權限"] = _newadmin.航線管理權限;
            dr["部落格管理權限"] = _newadmin.部落格管理權限;
            dr["評論管理權限"] = _newadmin.評論管理權限;
            dr["優惠券管理權限"] = _newadmin.優惠券管理權限;
            dt.Rows.Add(dr);
            EmptyAndEnable();
            ControllerDisable();
            //dgvAdmin.DataSource = _ds;
            //dgvAdmin.DataMember = "管理員資料表";
            //string insSql = "insert into (管理員姓名, 帳號, 密碼, Email, 會員管理權限, 管理員管理權限, 行程管理權限, ";
            //_con = new SqlConnection(_constr);
            //SqlCommand insertcom = new SqlCommand();
        }
    }
}
