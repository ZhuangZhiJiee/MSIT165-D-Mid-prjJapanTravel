using slnJapanTravel.Model.Member;
using slnJapanTravel.View.Member;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace slnJapanTravel.View
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }
        string _constr = "Data Source=.;Initial Catalog=JapanTravel;Integrated Security=True;Encrypt=False";
        private CLoginAdmin _admin;
        private void Buttondisable()
        {
            _admin = null;
            tslLogin.Text ="未登入";
            tsbAdmin.Enabled = false;
            tsbMember.Enabled = false;
            tsbItinerary.Enabled = false;
            tsbShip.Enabled = false;
            tsbOrder.Enabled = false;
            //tsbCart.Enabled = false;
            tsbBlog.Enabled = false;
            tsbCopon.Enabled = false;
            tsbComment.Enabled = false;
        }
        private void ButtonEnable()
        {
            if(_admin.管理員管理權限 == true)
                tsbAdmin.Enabled = true;
            if (_admin.會員管理權限 == true)
                tsbMember.Enabled = true;
            if (_admin.行程管理權限 == true)
                tsbItinerary.Enabled = true;
            if (_admin.航線管理權限 == true)
                tsbShip.Enabled = true;
            if (_admin.訂單管理權限 == true)
                tsbOrder.Enabled = true;
                //tsbCart.Enabled = true;
            if (_admin.部落格管理權限 == true)
                tsbBlog.Enabled = true;
            if (_admin.優惠券管理權限 == true)
                tsbCopon.Enabled = true;
            if (_admin.評論管理權限 == true)
                tsbComment.Enabled = true;
            tslLogin.Text = _admin.管理員姓名;
            tslLogin.Image = FrmAdmin.bytetoimage(_admin.管理員照片);
            
        }
        private void FrmMain_Load(object sender, EventArgs e)
        {
            Buttondisable();
            FrmLogin flg = new FrmLogin();
            flg.ShowDialog();
            if (flg._isok == DialogResult.OK)
            {
                _admin = flg.loginAdmin;
               
                ButtonEnable();

            }
        }
        private void tsAdmin_Click(object sender, EventArgs e)
        {
            while (this.ActiveMdiChild != null)
                this.ActiveMdiChild.Close();

            FrmAdmin fa = new FrmAdmin();
            fa.MdiParent = this;
            fa.Show();
            tslTitle.Text = "管理員管理系統";
        }

        private void tsbMember_Click(object sender, EventArgs e)
        {
            
            while (this.ActiveMdiChild != null)
                this.ActiveMdiChild.Close();

            FrmMember fm = new FrmMember();
            fm.MdiParent = this;
            fm.Show();
            tslTitle.Text = "會員管理系統";
        }
        private void tsbLtinerary_Click(object sender, EventArgs e)
        {
            while (this.ActiveMdiChild != null)
                this.ActiveMdiChild.Close();

            FrmItinerary fi = new FrmItinerary();
            fi.MdiParent = this;
            fi.Show();
            tslTitle.Text = "行程管理系統";
        }

        private void tsbShip_Click(object sender, EventArgs e)
        {
            while (this.ActiveMdiChild != null)
                this.ActiveMdiChild.Close();

            FrmShip fs = new FrmShip();
            fs.MdiParent = this;
            fs.Show();
            tslTitle.Text = "航線管理系統";
        }
        private void tsbBlog_Click(object sender, EventArgs e)
        {
            while (this.ActiveMdiChild != null)
                this.ActiveMdiChild.Close();

            FrmBlog fb = new FrmBlog();
            fb.MdiParent = this;
            fb.Show();
            tslTitle.Text = "部落格管理系統";
        }

        private void 船票ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            while (this.ActiveMdiChild != null)
                this.ActiveMdiChild.Close();

            FrmTicketCart fb = new FrmTicketCart();
            fb.MdiParent = this;
            fb.Show();
            tslTitle.Text = "船票購買系統";
        }

        private void 行程ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            while (this.ActiveMdiChild != null)
                this.ActiveMdiChild.Close();

            FrmItineraryCart fb = new FrmItineraryCart();
            fb.MdiParent = this;
            fb.Show();
            tslTitle.Text = "行程購買系統";
        }
        private void 行程ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            while (this.ActiveMdiChild != null)
                this.ActiveMdiChild.Close();

            FrmItineraryOrder fb = new FrmItineraryOrder();
            fb.MdiParent = this;
            fb.Show();
            tslTitle.Text = "行程訂單管理系統";
        }

        private void 船票ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            while (this.ActiveMdiChild != null)
                this.ActiveMdiChild.Close();

            FrmTicketOrder fb = new FrmTicketOrder();
            fb.MdiParent = this;
            fb.Show();
            tslTitle.Text = "船票訂單管理系統";
        }
        private void tsbCopon_Click(object sender, EventArgs e)
        {
            while (this.ActiveMdiChild != null)
                this.ActiveMdiChild.Close();

            FrmCoupon fb = new FrmCoupon();
            fb.MdiParent = this;
            fb.Show();
            tslTitle.Text = "優惠券管理系統";
        }

        private void tsbLeave_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void tsbLogin_Click(object sender, EventArgs e)
        {
            if (_admin == null)
            {
                FrmLogin flg = new FrmLogin();
                flg.ShowDialog();
                if (flg._isok == DialogResult.OK)
                {
                    _admin = flg.loginAdmin;
                    ButtonEnable();
                }
            }
        }

        private void tsbLogout_Click(object sender, EventArgs e)
        {
            while (this.ActiveMdiChild != null)
                this.ActiveMdiChild.Close();
            Buttondisable();
        }
    }
}