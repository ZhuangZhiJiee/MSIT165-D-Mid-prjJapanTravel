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
        private void ControllerDisable()
        {
            txtName.Enabled = false;
            txtEmail.Enabled = false;
            txtAccount.Enabled = false;
            txtPassword.Enabled = false;
            picAdmin.Enabled = false;
            clbStatus.Enabled = false;
            btnSave.Enabled = false;
            btnCancel.Enabled = false;
            txtName.Text = "";
            txtEmail.Text = "";
            txtAccount.Text = "";
            txtPassword.Text = "";
        }
        private void displayonDatagridview()
        {
            SqlConnection con = new SqlConnection(_constr);
            con.Open();
            SqlDataAdapter adapter = new SqlDataAdapter(_seladm, con);
            DataSet dt = new DataSet();
            adapter.Fill(dt, "管理員資料表");
            dgvAdmin.DataSource = dt.Tables["管理員資料表"];
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
            clbStatus.Enabled = true;
            for (int i = 0; i < clbStatus.Items.Count - 1; i++) 
            {
                clbStatus.SetItemChecked(i, false);
            }
            btnSave.Enabled = true;
            btnCancel.Enabled = true;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            ControllerDisable();
        }
    }
}
