using slnJapanTravel.Model;
using slnJapanTravel.Model.Ship;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net;
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
        
        private SqlDataAdapter _adapter;
        private int _position = -1;
        private SqlCommandBuilder _builder;
        private void btnCreate_Click(object sender, EventArgs e)
        {
            FrmShipPortEdit f = new FrmShipPortEdit();
            f.titleIcon = btnCreate.Image;
            f.title = "新增港口資料";
            f.port = new CPort();
            f.port.PortID港口ID = GetMaxPortID() + 1; // 自動生成新 PortID
            f.Controls["tbPortID"].Visible = false;
            f.Controls["lbPortID"].Visible = false;

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
        private int GetMaxPortID()
        {
            int maxPortID = 0;
            string sql = "SELECT MAX(PortID港口ID) FROM Port港口";
            using (SqlConnection con = new SqlConnection(DbConfig.GetConnectionString()))
            {
                SqlCommand cmd = new SqlCommand(sql, con);
                con.Open();
                object result = cmd.ExecuteScalar();
                if (result != DBNull.Value)
                {
                    maxPortID = Convert.ToInt32(result);
                }
            }
            return maxPortID;
        }


        private void FrmShipPort_Load(object sender, EventArgs e)
        {
            displaysql(@"SELECT * FROM Port港口");
        }

        private void displaysql(string sql)
        {
            SqlConnection con = new SqlConnection(DbConfig.GetConnectionString());
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
            
            FrmShipPortEdit f = new FrmShipPortEdit();
            f.titleIcon = btnCreate.Image;
            f.title = "編輯港口資料";
            f.port = p;
            f.ShowDialog();
            if (f.isOk == DialogResult.OK)
            {
                dr["PortID港口"] = f.port.PortID港口ID;
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
            DataTable dt = dataGridView1.DataSource as DataTable;
            DataRow dr = dt.Rows[_position];
            CPort p = new CPort();
            p.PortID港口ID = GetMaxPortID() + 1; // 自動生成新 PortID
            p.PortName港口名稱 = dr["PortName港口名稱"].ToString() + " (複製)";
            p.City城市名稱 = dr["City城市名稱"].ToString() + " (複製)";

            FrmShipPortEdit f = new FrmShipPortEdit();
            f.titleIcon = btnCreate.Image;
            f.title = "編輯港口資料";
            f.port = p;
            f.ShowDialog();
            if (f.isOk == DialogResult.OK)
            {
                dr = dt.NewRow();
                dr["PortID港口ID"] = f.port.PortID港口ID;
                dr["PortName港口名稱"] = f.port.PortName港口名稱;
                dr["City城市名稱"] = f.port.City城市名稱;

                dt.Rows.Add(dr);
            }
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            string sql = "SELECT * FROM Port港口";
            sql += " WHERE PortName港口名稱 LIKE @K_KEYWORD";
            sql += " OR City城市名稱 LIKE @K_KEYWORD";
            sql += " OR PortID港口ID LIKE @K_KEYWORD";

            displaysql(sql);
        }
    }
}
