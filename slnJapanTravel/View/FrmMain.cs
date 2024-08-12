using slnJapanTravel.Model.Member;
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


        private void Buttondisable()
        {
            tsbAdmin.Enabled = false;
            tsbMember.Enabled = false;
            tsbItinerary.Enabled = false;
            tsbShip.Enabled = false;
            tsbOrder.Enabled = false;
            tsbCart.Enabled = false;
            tsbBlog.Enabled = false;
        }
        private void ButtonEnable()
        {
            if(CLoginAdmin.管理員管理權限 == true)
                tsbAdmin.Enabled = true;
            if (CLoginAdmin.會員管理權限 == true)
                tsbMember.Enabled = true;
            if (CLoginAdmin.行程管理權限 == true)
                tsbItinerary.Enabled = true;
            if (CLoginAdmin.航班管理權限 == true)
                tsbShip.Enabled = true;
            if (CLoginAdmin.訂單管理權限 == true)
                tsbOrder.Enabled = true;
                tsbCart.Enabled = true;
            if (CLoginAdmin.會員管理權限 == true)
                tsbBlog.Enabled = true;
            tslLogin.Text = CLoginAdmin.管理員姓名;
        }

        private void tsAdmin_Click(object sender, EventArgs e)
        {

            while (this.ActiveMdiChild != null)
                this.ActiveMdiChild.Close();

            FrmAdmin fa = new FrmAdmin();
            fa.MdiParent = this;
            fa.Show();
        }

        private void tsbMember_Click(object sender, EventArgs e)
        {
            while (this.ActiveMdiChild != null)
                this.ActiveMdiChild.Close();

            FrmMember fm = new FrmMember();
            fm.MdiParent = this;
            fm.Show();
        }

        private void tsbLtinerary_Click(object sender, EventArgs e)
        {
            while (this.ActiveMdiChild != null)
                this.ActiveMdiChild.Close();

            FrmItinerary fi = new FrmItinerary();
            fi.MdiParent = this;
            fi.Show();
        }

        private void tsbShip_Click(object sender, EventArgs e)
        {
            while (this.ActiveMdiChild != null)
                this.ActiveMdiChild.Close();

            FrmShip fs = new FrmShip();
            fs.MdiParent = this;
            fs.Show();
        }


        private void tsbBlog_Click(object sender, EventArgs e)
        {
            while (this.ActiveMdiChild != null)
                this.ActiveMdiChild.Close();

            FrmBlog fb = new FrmBlog();
            fb.MdiParent = this;
            fb.Show();
        }

        private void 船票ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            while (this.ActiveMdiChild != null)
                this.ActiveMdiChild.Close();

            FrmTicketCart fb = new FrmTicketCart();
            fb.MdiParent = this;
            fb.Show();
        }

        private void 行程ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            while (this.ActiveMdiChild != null)
                this.ActiveMdiChild.Close();

            FrmItineraryCart fb = new FrmItineraryCart();
            fb.MdiParent = this;
            fb.Show();

        }

        private void 行程ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            while (this.ActiveMdiChild != null)
                this.ActiveMdiChild.Close();

            FrmItineraryOrder fb = new FrmItineraryOrder();
            fb.MdiParent = this;
            fb.Show();
        }

        private void 船票ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            while (this.ActiveMdiChild != null)
                this.ActiveMdiChild.Close();

            FrmTicketOrder fb = new FrmTicketOrder();
            fb.MdiParent = this;
            fb.Show();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            Buttondisable();
            FrmLogin fl = new FrmLogin();
            fl.ShowDialog();
            if (fl._isok == DialogResult.OK)
            {
                ButtonEnable();
            }
        }
    }
}