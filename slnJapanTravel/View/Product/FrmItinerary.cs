using slnJapanTravel.Component.Product;
using slnJapanTravel.Model;
using slnJapanTravel.Model.Product;
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
    public partial class FrmItinerary : Form
    {
        SqlDataAdapter _adapter;
        private SqlCommandBuilder _builder;
        CItineraryDate _date;
        private int _position;
        

        string _s = "Data Source=.;Initial Catalog = JapanTravel; Integrated Security = True; Encrypt=False";
        //string _s = "Data Source=192.168.35.188;Initial Catalog=JapanTravel;User ID=Ting;Password=0000;Encrypt=False";

        public FrmItinerary()
        {
            InitializeComponent();
        }
        private void FrmItinerary_Load(object sender, EventArgs e)
        {
            DataGridRefresh();
            MaindataGridView.CellClick += MaindataGridView_CellClick; // 註冊事件

        }

        private void DataGridRefresh()
        {
            displayBySql("SELECT [行程編號], [行程名稱], [體驗名稱], [總團位], [價格], [主題], [地區名稱]"
                            + "\r\nFROM [Itinerary行程]"
                            + "\r\nJOIN [Activity體驗]\r\nON[體驗編號]=[體驗]"
                            + "\r\nJOIN [Area地區]\r\nON[地區編號]=[地區]");

            SqlConnection con = new SqlConnection();
            con.ConnectionString = _s;
            con.Open();

            string sql = "SELECT *  FROM Area地區";
            SqlDataAdapter adapter = new SqlDataAdapter(sql, con);
            DataSet ds = new DataSet();
            adapter.Fill(ds, "Area地區");

            cbArea.Items.Clear();
            foreach (DataRow r in ds.Tables["Area地區"].Rows)
            {
                CArea area = new CArea();
                area.地區名稱 = r["地區名稱"].ToString();

                cbArea.Items.Add(area.地區名稱);
            }

            con.Close();
        }

        private void displayBySql(string sql)
        {

            SqlConnection con = new SqlConnection(); //new類別
            con.ConnectionString = _s; //連接自來水廠
            con.Open();

            _adapter = new SqlDataAdapter(sql, con);
            _builder = new SqlCommandBuilder(_adapter);
            _adapter.SelectCommand.Parameters.Add(new SqlParameter("K_IDWORD", "%" + txtItineraryId.Text + "%"));
            _adapter.SelectCommand.Parameters.Add(new SqlParameter("K_NAMEWORD", "%" + txtItineraryName.Text + "%"));
            DataSet ds = new DataSet();
            _adapter.Fill(ds);
            MaindataGridView.DataSource = ds.Tables[0];
            con.Close();
        }
        private void MaindataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataRow selectedRow = ((DataTable)MaindataGridView.DataSource).Rows[e.RowIndex];
                string ItineraryId = selectedRow["行程編號"].ToString();  // 使用行程編號來篩選

                SqlConnection con = new SqlConnection(_s);
                con.Open();

                string sql = "SELECT 出發日期 FROM ItineraryTime行程批次 WHERE 行程系統編號 = (SELECT 行程系統編號 FROM Itinerary行程 WHERE 行程編號 = @K_FID)";
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.Parameters.Add(new SqlParameter("K_FID", ItineraryId));
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                adapter.Fill(ds);
                TimedataGridView.DataSource = ds.Tables[0];
                con.Close();
            }
        }
        

        private void btnInsert_Click(object sender, EventArgs e)
        {

        FrmItineraryInsert f = new FrmItineraryInsert();
        f.ShowDialog();
        if (f.isOK == DialogResult.OK)
        {
            if (f.main.date == null)
            {
                f.main.date = new CItineraryDate();
            }
            CProductManager p = new CProductManager();
            p.create(f.main);

            DataTable maindt = MaindataGridView.DataSource as DataTable;
            DataRow dr = maindt.NewRow();
            dr["行程編號"] = f.main.行程編號;
            dr["體驗名稱"] = GetActivityNameById(f.main.體驗);
            dr["行程名稱"] = f.main.行程名稱;
            dr["總團位"] = f.main.總團位.ToString();
            dr["價格"] = f.main.價格.ToString();
            dr["地區名稱"] = GetAreaNameById(f.main.地區);
           
            maindt.Rows.Add(dr);

            DataTable dtTime = TimedataGridView.DataSource as DataTable;
            foreach (var date in f.main.date.行程系統編號.ToString())
            {
                DataRow drTime = dtTime.NewRow();
                drTime["出發日期"] = f.main.date.出發日期;
                dtTime.Rows.Add(drTime);
            }

            DataGridRefresh();
        }
    }
    private string GetActivityNameById(int activityId)
    {
    string activityName = string.Empty;

    using (SqlConnection con = new SqlConnection(_s))
    {
        con.Open();
        string sql = "SELECT 體驗名稱 FROM Activity體驗 WHERE 體驗編號 = @ActivityId";
        using (SqlCommand cmd = new SqlCommand(sql, con))
        {
            cmd.Parameters.AddWithValue("@ActivityId", activityId);
            using (SqlDataReader reader = cmd.ExecuteReader())
            {
                if (reader.Read())
                {
                    activityName = reader["體驗名稱"].ToString();
                }
            }
        }
    }

    return activityName;
    }
    private string GetAreaNameById(int areaId)
    {
        string areaName = string.Empty;

        using (SqlConnection con = new SqlConnection(_s))
        {
            con.Open();
            string sql = "SELECT 地區名稱 FROM Area地區 WHERE 地區編號 = @AreaId";
            using (SqlCommand cmd = new SqlCommand(sql, con))
            {
                cmd.Parameters.AddWithValue("@AreaId", areaId);
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        areaName = reader["地區名稱"].ToString();
                    }
                }
            }
        }

        return areaName;
    }

        private void btnMainSearch_Click(object sender, EventArgs e)
        {
            string sql = "SELECT * FROM [Itinerary行程]";
            sql += " WHERE 行程編號 LIKE @K_IDWORD ";
            sql += " OR 行程名稱 LIKE @K_NAMEWORD ";
            //sql += " OR 地區 LIKE " + cbArea + " ";

            displayBySql(sql);
        }

        private void btnMainDelete_Click(object sender, EventArgs e)
        {
            DataTable dt = MaindataGridView.DataSource as DataTable;  //建立一個資料表，來源為畫面輸入的資料
            if (dt != null && _position >= 0 && _position < dt.Rows.Count)
            {
                DataRow dr = dt.Rows[_position];
                CItineraryMain main = new CItineraryMain();
                main.行程編號 = dr["行程編號"].ToString(); // 假設行程編號可以轉為字串

                dr.Delete();

                CProductManager p = new CProductManager();
                p.delete(main);
                DataGridRefresh();
            }
        }

        private void btnCopy_Click(object sender, EventArgs e)
        {
            DataTable dt = MaindataGridView.DataSource as DataTable;
            DataRow dr = dt.Rows[_position];
            CItineraryMain main = new CItineraryMain();
            main.行程編號 = dr["行程編號"].ToString();
            main.行程名稱 = dr["行程名稱"].ToString() + "(複製)";
            main.體驗名稱 = dr["體驗名稱"].ToString();
            main.總團位 = (int)dr["總團位"];
            main.價格 = Convert.ToInt32(dr["價格"]);

            FrmItineraryInsert f = new FrmItineraryInsert();
            f.ShowDialog();
            CProductManager p = new CProductManager();
            p.copy(f.main);

            if (f.isOK == DialogResult.OK)
            {
                DataRow dr1 = dt.NewRow();
                dr1["行程編號"] = f.main.行程編號;
                dr1["體驗名稱"] = GetActivityNameById(f.main.體驗);
                dr1["行程名稱"] = f.main.行程名稱;
                dr1["總團位"] = f.main.總團位.ToString();
                dr1["價格"] = f.main.價格.ToString();
                dr1["地區名稱"] = GetAreaNameById(f.main.地區);
                dt.Rows.Add(dr1);
            }

            DataGridRefresh();
        }
        private void btnMainUpdate_Click(object sender, EventArgs e)
        {
            DataTable dt = MaindataGridView.DataSource as DataTable;
            DataRow dr = dt.Rows[_position];
            
            CItineraryMain main = new CItineraryMain();
            main.行程編號 = dr["行程編號"].ToString();
            main.行程名稱 = dr["行程名稱"].ToString();
            main.體驗名稱 = dr["體驗名稱"].ToString();
            main.總團位 = (int)dr["總團位"];
            main.價格 = Convert.ToInt32(dr["價格"]);


            FrmItineraryInsert f = new FrmItineraryInsert();
            f.main = main;
            f.ShowDialog();
            CProductManager p = new CProductManager();
            p.update(f.main);

            DataGridRefresh();
        }


        private void resetMainGridStyle()
        {
            MaindataGridView.ColumnHeadersDefaultCellStyle.Font = new Font("Meiryo UI", 11);
            MaindataGridView.Columns[0].Width = 150;
            MaindataGridView.Columns[1].Width = 800;
            MaindataGridView.Columns[2].Width = 150;
            MaindataGridView.Columns[3].Width = 50;
            MaindataGridView.Columns[4].Width = 100;
            MaindataGridView.Columns[5].Width = 100;
            MaindataGridView.Columns[6].Width = 100;
            


            foreach (DataGridViewRow r in MaindataGridView.Rows)
            {
                
                r.DefaultCellStyle.Font = new Font("Meiryo UI", 11);
                r.Height = 40;
                
            }
        }
        private void MaindataGridView_Paint_1(object sender, PaintEventArgs e)
        {
            resetMainGridStyle();
        }

        private void resetTimeGridStyle()
        {
            TimedataGridView.ColumnHeadersDefaultCellStyle.Font = new Font("Meiryo UI", 11);
            if (TimedataGridView.Rows.Count > 0)
            {
                TimedataGridView.Columns[0].DefaultCellStyle.Font = new Font("Meiryo UI", 11);
                TimedataGridView.Columns[0].Width = this.Width;
            }
        }

        private void TimedataGridView_Paint(object sender, PaintEventArgs e)
        {
            resetTimeGridStyle();
        }

        private void MaindataGridView_RowEnter_1(object sender, DataGridViewCellEventArgs e)
        {
            _position = e.RowIndex;
        }
        
    }
    

}
