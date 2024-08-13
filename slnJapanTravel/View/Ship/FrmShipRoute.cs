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
   
    public partial class FrmShipRoute : Form
    {
        string CS =
            //本機
            "Data Source =.; Initial Catalog = JapanTravel; Integrated Security = True; Encrypt = False";
            //連線
            //"Data Source = 192.168.35.188; Initial Catalog = JapanTravel;Persist Security Info = True; User ID = jojo; Password = 0000; Encrypt = False;";
        
        
            
        private SqlDataAdapter _adapter;
        private int _position = -1;
        private SqlCommandBuilder _builder;
        public FrmShipRoute()
        {
            InitializeComponent();
        }

        private void FrmShip_Resize(object sender, EventArgs e)
        {
            txtKeyword.Width = this.Width * 230 / 816;

        }
        private void FrmShip_Load(object sender, EventArgs e)
        {
            displaysql(@"SELECT r.RouteID渡輪航線ID AS 渡輪航線, o.PortName港口名稱 AS 出發港, d.PortName港口名稱 AS 目的地, r.RouteDescription航線敘述 AS 航線敘述
                FROM 渡輪航線 r
                JOIN Port港口 o ON r.OriginPortID出發港ID = o.PortID港口ID
                JOIN Port港口 d ON r.DestinationPortID目的地ID = d.PortID港口ID");

        }

        public void displaysql(string sql)
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

       

        private void btnCreate_Click(object sender, EventArgs e)
        {
            FrmShipREdit f = new FrmShipREdit();
            f.titleIcon = btnCreate.Image;
            f.title = "新增航線作業";
            f.ShowDialog();
            if (f.isOk == DialogResult.OK)
            {
                DataTable dt = dataGridView1.DataSource as DataTable;
                DataRow dr = dt.NewRow();
                dr["RouteID渡輪航線ID"] = f.cRoute.RouteID渡輪航線ID;
                //dr["OriginPortID出發港ID"] = f.cRoute.OriginPortID出發港ID;
                //dr["DestinationPortID目的地ID"] = f.cRoute.DestinationPortID目的地ID;
                //dr["RouteDescription航線敘述"] = f.cRoute.RouteDescription航線敘述;

                dt.Rows.Add(dr);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
