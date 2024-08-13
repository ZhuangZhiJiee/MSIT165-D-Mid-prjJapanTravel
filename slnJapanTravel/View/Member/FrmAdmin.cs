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
        private CAdmin _newadmin;
        private DataSet _ds;
        private SqlConnection _con;
        private SqlDataAdapter _adapter;
        private SqlCommandBuilder _builder;
        private void ControllerEnable()
        {
            txtName.Enabled = true;
            txtEmail.Enabled = true;
            txtAccount.Enabled = true;
            txtPassword.Enabled = true;

            picAdmin.Enabled = true;

            cbMember.Enabled = true;
            cbAdmin.Enabled = true;
            cbItinerary.Enabled = true;
            cbShip.Enabled = true;
            cbOrder.Enabled = true;
            cbBlog.Enabled = true;
            cbComment.Enabled = true;
            cbCoupon.Enabled = true;
        }
        private void ControllerDisable()
        {
            txtName.Enabled = false;
            txtEmail.Enabled = false;
            txtAccount.Enabled = false;
            txtPassword.Enabled = false;

            picAdmin.Enabled = false;

            cbMember.Enabled = false;
            cbAdmin.Enabled = false;
            cbItinerary.Enabled = false;
            cbShip.Enabled = false;
            cbOrder.Enabled = false;
            cbBlog.Enabled = false;
            cbComment.Enabled = false;
            cbCoupon.Enabled = false;
        }
        private void Empty()
        {
            txtName.Text = "";
            txtEmail.Text = "";
            txtAccount.Text = "";
            txtPassword.Text = "";
            picAdmin.Image = null;
            cbAdmin.Checked = false;
            cbMember.Checked = false;
            cbItinerary.Checked = false;
            cbOrder.Checked = false;
            cbShip.Checked = false;
            cbBlog.Checked = false;
            cbComment.Checked = false;
            cbCoupon.Checked = false;
        }
        private void displayonDatagridview()
        {
            _con = new SqlConnection(_constr);
            SqlDataAdapter adapter = new SqlDataAdapter(_seladm, _con);
            _con.Open();
            _ds = new DataSet();
            adapter.Fill(_ds, "管理員資料表");

            lblID.DataBindings.Clear();
            txtName.DataBindings.Clear();
            txtEmail.DataBindings.Clear();
            txtAccount.DataBindings.Clear();
            txtPassword.DataBindings.Clear();
            cbAdmin.DataBindings.Clear();
            cbMember.DataBindings.Clear();
            cbItinerary.DataBindings.Clear();
            cbShip.DataBindings.Clear();
            cbOrder.DataBindings.Clear();
            cbBlog.DataBindings.Clear();
            cbComment.DataBindings.Clear();
            cbCoupon.DataBindings.Clear();

            lblID.DataBindings.Add("Text", _ds, "管理員資料表.管理員ID");
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
        private void dgvAdmin_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            ControllerDisable();
        }
        private void tsbInsert_Click(object sender, EventArgs e)
        {
            ControllerEnable();
            Empty();
            this.btnSave.Click += new System.EventHandler(this.btnInsertSave_Click);
        }
        private void btnInsertSave_Click(object sender, EventArgs e)
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

            string Insertstr = "insert into Admin管理員 (管理員姓名, 帳號, 密碼, Email, 會員管理權限, 管理員管理權限, 行程管理權限, 訂單管理權限, " +
                "航線管理權限, 部落格管理權限, 評論管理權限, 優惠券管理權限)";
            Insertstr += " values ( @管理員姓名, @帳號, @密碼, @Email, @會員管理權限, @管理員管理權限, @行程管理權限, @訂單管理權限, @航線管理權限, @部落格管理權限, @評論管理權限, @優惠券管理權限 )";

            SqlCommand cmd = new SqlCommand(Insertstr, _con);
            cmd.Parameters.Add(new SqlParameter("管理員姓名", (object)_newadmin.管理員姓名));
            cmd.Parameters.Add(new SqlParameter("帳號", (object)_newadmin.管理員信箱));
            cmd.Parameters.Add(new SqlParameter("密碼", (object)_newadmin.管理員帳號));
            cmd.Parameters.Add(new SqlParameter("Email", (object)_newadmin.管理員密碼));
            cmd.Parameters.Add(new SqlParameter("會員管理權限", _newadmin.會員管理權限 ? 1 : 0));
            cmd.Parameters.Add(new SqlParameter("管理員管理權限", _newadmin.管理員管理權限 ? 1 : 0));
            cmd.Parameters.Add(new SqlParameter("行程管理權限", _newadmin.行程管理權限 ? 1 : 0));
            cmd.Parameters.Add(new SqlParameter("訂單管理權限", _newadmin.訂單管理權限 ? 1 : 0));
            cmd.Parameters.Add(new SqlParameter("航線管理權限", _newadmin.航線管理權限 ? 1 : 0));
            cmd.Parameters.Add(new SqlParameter("部落格管理權限", _newadmin.部落格管理權限 ? 1 : 0));
            cmd.Parameters.Add(new SqlParameter("評論管理權限", _newadmin.評論管理權限 ? 1 : 0));
            cmd.Parameters.Add(new SqlParameter("優惠券管理權限", _newadmin.優惠券管理權限 ? 1 : 0));
            cmd.ExecuteNonQuery();

            displayonDatagridview();
            ControllerDisable();

            this.btnSave.Click -= new System.EventHandler(this.btnInsertSave_Click);
        }
        private void tsbUpdate_Click(object sender, EventArgs e)
        {
            ControllerEnable();
            _newadmin = new CAdmin();
            _newadmin.管理員ID = int.Parse(lblID.Text);
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
            this.btnSave.Click += new System.EventHandler(this.btnUpdateSave_Click);
        }
        private void btnUpdateSave_Click(object sender, EventArgs e)
        {
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

            string Updatestr = "Update Admin管理員 set 管理員姓名 = @管理員姓名, 帳號 =  @帳號, 密碼 = @密碼, Email = @Email," +
                " 會員管理權限 = @會員管理權限, 管理員管理權限= @管理員管理權限, 行程管理權限 = @行程管理權限, 訂單管理權限 = @訂單管理權限, " +
                "航線管理權限 = @航線管理權限, 部落格管理權限 = @部落格管理權限, 評論管理權限 = @評論管理權限, 優惠券管理權限 =@優惠券管理權限";
            Updatestr += " where 管理員ID = @管理員ID";


            SqlCommand cmd = new SqlCommand(Updatestr, _con);
            cmd.Parameters.Add(new SqlParameter("管理員ID", (object)_newadmin.管理員ID));
            cmd.Parameters.Add(new SqlParameter("管理員姓名", (object)_newadmin.管理員姓名));
            cmd.Parameters.Add(new SqlParameter("帳號", (object)_newadmin.管理員信箱));
            cmd.Parameters.Add(new SqlParameter("密碼", (object)_newadmin.管理員帳號));
            cmd.Parameters.Add(new SqlParameter("Email", (object)_newadmin.管理員密碼));
            cmd.Parameters.Add(new SqlParameter("會員管理權限", _newadmin.會員管理權限 ? 1 : 0));
            cmd.Parameters.Add(new SqlParameter("管理員管理權限", _newadmin.管理員管理權限 ? 1 : 0));
            cmd.Parameters.Add(new SqlParameter("行程管理權限", _newadmin.行程管理權限 ? 1 : 0));
            cmd.Parameters.Add(new SqlParameter("訂單管理權限", _newadmin.訂單管理權限 ? 1 : 0));
            cmd.Parameters.Add(new SqlParameter("航線管理權限", _newadmin.航線管理權限 ? 1 : 0));
            cmd.Parameters.Add(new SqlParameter("部落格管理權限", _newadmin.部落格管理權限 ? 1 : 0));
            cmd.Parameters.Add(new SqlParameter("評論管理權限", _newadmin.評論管理權限 ? 1 : 0));
            cmd.Parameters.Add(new SqlParameter("優惠券管理權限", _newadmin.優惠券管理權限 ? 1 : 0));
            cmd.ExecuteNonQuery();

            displayonDatagridview();
            ControllerDisable();

            this.btnSave.Click -= new System.EventHandler(this.btnUpdateSave_Click);
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            ControllerDisable();
            this.btnSave.Click -= new System.EventHandler(this.btnInsertSave_Click);
            this.btnSave.Click -= new System.EventHandler(this.btnUpdateSave_Click);
        }
    }
}
