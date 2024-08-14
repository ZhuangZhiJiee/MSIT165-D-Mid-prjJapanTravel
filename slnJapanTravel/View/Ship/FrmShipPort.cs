using slnJapanTravel.Model;
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

namespace slnJapanTravel.View.Ship
{
    public partial class FrmShipPort : Form
    {
        public FrmShipPort()
        {
            InitializeComponent();
        }
        public string CS =
        //本機
        //"Data Source =.; Initial Catalog = JapanTravel; Integrated Security = True; Encrypt = False";
        //連線
        "Data Source = 192.168.35.188; Initial Catalog = JapanTravel;Persist Security Info = True; User ID = jojo; Password = 0000; Encrypt = False;";


        private SqlDataAdapter _adapter;
        private int _position = -1;
        private SqlCommandBuilder _builder;
        private void btnCreate_Click(object sender, EventArgs e)
        {
            FrmShipPortEdit f = new FrmShipPortEdit();
            f.titleIcon = btnCreate.Image;
            f.title = "新增港口資料";
            f.ShowDialog();
            if (f.isOk == DialogResult.OK)
            {
                DataTable dt = dataGridView1.DataSource as DataTable;
                DataRow dr = dt.NewRow();
                dr["PortID港口ID"] = f.port.PortID港口ID;
                dr["PortName港口名稱"] = f.port.PortName港口名稱;
                dr["City城市名稱"] = f.port.City城市名稱;
               
                dt.Rows.Add(dr);
            }
        }

        private void FrmShipPort_Load(object sender, EventArgs e)
        {
            displaysql(@"SELECT * FROM Port港口");
        }

        private void displaysql(string sql)
        {
            SqlConnection con = new SqlConnection(CS);
            con.Open();
            _adapter = new SqlDataAdapter(sql, con);

            _builder = new SqlCommandBuilder(_adapter);
            _adapter.SelectCommand.Parameters.Add(
                new SqlParameter("K_KEYWORD", "%" + (object)txtKeyword.Text + "%"));

            DataSet ds = new DataSet();
            _adapter.Fill(ds);
            con.Close();
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dataGridView1_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            _position = e.RowIndex;
        }

        private void FrmShipPort_FormClosed(object sender, FormClosedEventArgs e)
        {
            _adapter.Update(dataGridView1.DataSource as DataTable);

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            DataTable dt = dataGridView1.DataSource as DataTable;
            DataRow dr = dt.Rows[_position];
            CPort p = new CPort();
if (dr["PortID港口ID"] != DBNull.Value)
            p.PortID港口ID = (int)dr["PortID港口ID"];
            p.PortName港口名稱 = dr["PortName港口名稱"].ToString();
            p.City城市名稱 = dr["City城市名稱"].ToString();
            
             ;

            FrmShipPortEdit f = new FrmShipPortEdit();
            f.titleIcon = btnCreate.Image;
            f.title = "編輯港口資料";
            f.port = p;
            f.ShowDialog();
            if (f.isOk == DialogResult.OK)
            {
                dr["PortID港口IDPortID港口"] = f.port.PortID港口ID;
                dr["PortName港口名稱"] = f.port.PortName港口名稱;
                dr["City城市名稱"] = f.port.City城市名稱;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DataTable dt = dataGridView1.DataSource as DataTable;
            DataRow dr = dt.Rows[_position];
            dr.Delete();
            _adapter.Update(dataGridView1.DataSource as DataTable);
        }

        private void btnCopy_Click(object sender, EventArgs e)
        {

        }
    }
}
