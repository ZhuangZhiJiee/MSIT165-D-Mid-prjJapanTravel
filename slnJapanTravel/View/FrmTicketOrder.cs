using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace slnJapanTravel.View
{
    public partial class FrmTicketOrder : Form
    {
        public FrmTicketOrder()
        {
            InitializeComponent();
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            FrmTicketOrderEditor f = new FrmTicketOrderEditor();
            f.ShowDialog();
        }
    }
}
