using slnJapanTravel.Model;
using slnJapanTravel.Model.Member;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace slnJapanTravel.View
{
    public partial class FrmMember : Form
    {
        public FrmMember()
        {
            InitializeComponent();
        }
        private byte[] _selectimg;
        CMember _Member;
        SqlConnection _con;
        DataSet _ds;
        string _constr = "Data Source=.;Initial Catalog=JapanTravel;Integrated Security=True;Encrypt=False;";
        string _selMem = "select * from Member會員";
        string _defimg = @"C:\D組圖片\會員.png";
        FileStream _imgstream;
        BinaryReader _reader;
        private void ControllerEnable()
        {
            txtName.Enabled = true;
            cbbGender.Enabled = true;
            dtpBirthday.Enabled = true;
            txtPhone.Enabled = true;
            txtEmail.Enabled = true;
            txtAccount.Enabled = true;
            txtPassword.Enabled = true;
            cbbCity.Enabled = true;
            txtAddress.Enabled = true;
            cbbStatus.Enabled = true;

            picMember.Enabled = true;

        }
        private void ControllerDisable()
        {
            txtName.Enabled = false;
            cbbGender.Enabled = false;
            dtpBirthday.Enabled = false;
            txtPhone.Enabled = false;
            txtEmail.Enabled = false;
            txtAccount.Enabled = false;
            txtPassword.Enabled = false;
            cbbCity.Enabled = false;
            txtAddress.Enabled = false;
            cbbStatus.Enabled = false;

            picMember.Enabled = false;
        }
        private void Empty()
        {
            txtID.Text = "";
            txtName.Text = "";
            cbbGender.Text="男";
            dtpBirthday.Value = new DateTime(2000, 1, 1);
            txtPhone.Text="";
            txtEmail.Text = "";
            txtAccount.Text = "";
            txtPassword.Text = "";
            cbbCity.Text = "台北";
            txtAddress.Text = "";
            cbbStatus.Checked= true;

            picMember.Image = Bitmap.FromFile(_defimg); ;
        }
        private void displayonDatagridview()
        {
            _con = new SqlConnection(_constr);
            SqlDataAdapter adapter = new SqlDataAdapter(_selMem, _con);
            _con.Open();
            _ds = new DataSet();
            adapter.Fill(_ds, "會員資料表");
            dgvMember.DataSource = _ds;
            dgvMember.DataMember = "會員資料表";

            txtID.DataBindings.Clear();
            txtName.DataBindings.Clear();
            cbbGender.DataBindings.Clear();
            dtpBirthday.DataBindings.Clear();
            txtPhone.DataBindings.Clear();
            txtEmail.DataBindings.Clear();
            txtAccount.DataBindings.Clear();
            txtPassword.DataBindings.Clear();
            cbbCity.DataBindings.Clear();
            txtAddress.DataBindings.Clear();
            picMember.DataBindings.Clear();
            cbbStatus.DataBindings.Clear();

            txtID.DataBindings.Add("Text", _ds, "會員資料表.會員ID");
            txtName.DataBindings.Add("Text", _ds, "會員資料表.會員名稱");
            cbbGender.DataBindings.Add("Text", _ds, "會員資料表.性別");
            dtpBirthday.DataBindings.Add("Value", _ds, "會員資料表.生日");
            txtPhone.DataBindings.Add("Text", _ds, "會員資料表.手機號碼");
            txtEmail.DataBindings.Add("Text", _ds, "會員資料表.Email");
            txtAccount.DataBindings.Add("Text", _ds, "會員資料表.帳號");
            txtPassword.DataBindings.Add("Text", _ds, "會員資料表.密碼");
            cbbCity.DataBindings.Add("Text", _ds, "會員資料表.城市");
            txtAddress.DataBindings.Add("Text", _ds, "會員資料表.地址");
            cbbStatus.DataBindings.Add("Checked", _ds, "會員資料表.會員狀態");

            Binding imgbinding = new Binding("Image", _ds, "會員資料表.會員照片");
            imgbinding.Format += (sender2, e2) =>
            {
                if (e2.Value != null && e2.Value is byte[])
                {
                    byte[] imgdata = (byte[])e2.Value;
                    _selectimg = imgdata;
                    MemoryStream ms = new MemoryStream(imgdata);

                    e2.Value = Image.FromStream(ms);

                }
            };
            picMember.DataBindings.Add(imgbinding);

            dgvMember.Columns[0].Visible = false;
            dgvMember.Columns[10].Visible = false;
        }
        private void SearchandDisplayonDatagridview()
        {
            string searchstr = "select * from Member會員 where 會員名稱 like @keyword or 性別 like @keyword or 生日 like @keyword " +
                "or 手機號碼 like @keyword or 帳號 like @keyword or Email like @keyword or 城市 like @keyword or 地址 like @keyword";
            _con = new SqlConnection(_constr);
            _con.Open();
            _ds = new DataSet();
            SqlDataAdapter adapter = new SqlDataAdapter(searchstr, _con);
            adapter.SelectCommand.Parameters.Add(new SqlParameter("keyword", (object)"%" + txtKeyword.Text + "%"));
            adapter.Fill(_ds, "會員資料表");
            dgvMember.DataSource = _ds;
            dgvMember.DataMember = "會員資料表";

            txtID.DataBindings.Clear();
            txtName.DataBindings.Clear();
            cbbGender.DataBindings.Clear();
            dtpBirthday.DataBindings.Clear();
            txtPhone.DataBindings.Clear();
            txtEmail.DataBindings.Clear();
            txtAccount.DataBindings.Clear();
            txtPassword.DataBindings.Clear();
            cbbCity.DataBindings.Clear();
            txtAddress.DataBindings.Clear();
            picMember.DataBindings.Clear();
            cbbStatus.DataBindings.Clear();

            txtID.DataBindings.Add("Text", _ds, "會員資料表.會員ID");
            txtName.DataBindings.Add("Text", _ds, "會員資料表.會員名稱");
            cbbGender.DataBindings.Add("Text", _ds, "會員資料表.性別");
            dtpBirthday.DataBindings.Add("Value", _ds, "會員資料表.生日");
            txtPhone.DataBindings.Add("Text", _ds, "會員資料表.手機號碼");
            txtEmail.DataBindings.Add("Text", _ds, "會員資料表.Email");
            txtAccount.DataBindings.Add("Text", _ds, "會員資料表.帳號");
            txtPassword.DataBindings.Add("Text", _ds, "會員資料表.密碼");
            cbbCity.DataBindings.Add("Text", _ds, "會員資料表.城市");
            txtAddress.DataBindings.Add("Text", _ds, "會員資料表.地址");
            cbbStatus.DataBindings.Add("Checked", _ds, "會員資料表.會員狀態");

            Binding imgbinding = new Binding("Image", _ds, "會員資料表.會員照片");
            imgbinding.Format += (sender2, e2) =>
            {
                if (e2.Value != null && e2.Value is byte[])
                {
                    byte[] imgdata = (byte[])e2.Value;
                    _selectimg = imgdata;
                    MemoryStream ms = new MemoryStream(imgdata);

                    e2.Value = Image.FromStream(ms);

                }
            };
            picMember.DataBindings.Add(imgbinding);

            dgvMember.Columns[0].Visible = false;
            dgvMember.Columns[10].Visible = false;
        }

        private void FrmMember_Load(object sender, EventArgs e)
        {
            ControllerDisable();
            displayonDatagridview();
        }

        private void tsbInsert_Click(object sender, EventArgs e)
        {
            dgvMember.CurrentCell = dgvMember.Rows[dgvMember.Rows.Count - 1].Cells[1];
            ControllerEnable();
            Empty();
            this.btnSave.Click += new System.EventHandler(this.btnInsertSave_Click);
            _Member = new CMember();
        }

        private void btnInsertSave_Click(object sender, EventArgs e)
        {
            _Member.會員名稱 = txtName.Text;
            _Member.性別 = cbbGender.Text;
            _Member.生日 = dtpBirthday.Value;
            _Member.電話 = txtPhone.Text;
            _Member.Email = txtEmail.Text;
            _Member.會員帳號 = txtAccount.Text;
            _Member.會員密碼 = txtPassword.Text;
            _Member.城市  = cbbCity.Text;
            _Member.地址 = txtAddress.Text;
            _Member.會員狀態 = cbbStatus.Checked;
            try
            {
                string Insertstr = "insert into Member會員 (會員名稱, 性別, 生日, 手機號碼, Email, 帳號, 密碼, 城市, 地址, 會員照片, 會員狀態";
                Insertstr += " ) values ( @會員姓名, @性別, @生日, @手機號碼, @Email, @帳號, @密碼, @城市, @地址 ,@會員照片 , @會員狀態 )";
                SqlCommand cmd = new SqlCommand(Insertstr, _con);
                cmd.Parameters.Add(new SqlParameter("會員姓名", (object)_Member.會員名稱));
                cmd.Parameters.Add(new SqlParameter("性別", (object)_Member.性別));
                cmd.Parameters.Add(new SqlParameter("生日", (object)_Member.生日));
                cmd.Parameters.Add(new SqlParameter("手機號碼", (object)_Member.電話));
                cmd.Parameters.Add(new SqlParameter("Email", (object)_Member.Email));
                cmd.Parameters.Add(new SqlParameter("帳號", _Member.會員帳號));
                cmd.Parameters.Add(new SqlParameter("密碼", _Member.會員密碼));
                cmd.Parameters.Add(new SqlParameter("城市", _Member.性別));
                cmd.Parameters.Add(new SqlParameter("地址", _Member.地址));
                cmd.Parameters.Add(new SqlParameter("會員照片", _Member.會員照片));
                cmd.Parameters.Add(new SqlParameter("會員狀態", _Member.會員狀態 ? 1 : 0));
                cmd.ExecuteNonQuery();
            }
            catch { }

            displayonDatagridview();
            ControllerDisable();



            this.btnSave.Click -= new System.EventHandler(this.btnInsertSave_Click);
        }

        private void tsbUpdate_Click(object sender, EventArgs e)
        {
            ControllerEnable();
            _Member = new CMember();
            _Member.會員ID = int.Parse(txtID.Text);
            _Member.會員名稱 = txtName.Text;
            _Member.性別 = cbbGender.Text;
            _Member.生日 = dtpBirthday.Value;
            _Member.電話 = txtPhone.Text;
            _Member.Email = txtEmail.Text;
            _Member.會員帳號 = txtAccount.Text;
            _Member.會員密碼 = txtPassword.Text;
            _Member.城市 = cbbCity.Text;
            _Member.地址 = txtAddress.Text;
            _Member.會員狀態 = cbbStatus.Checked;
            _Member.會員照片 = _selectimg;
           
            this.btnSave.Click += new System.EventHandler(this.btnUpdateSave_Click);
        }

        private void btnUpdateSave_Click(object sender, EventArgs e)
        {
            _Member = new CMember();
            _Member.會員ID = int.Parse(txtID.Text);
            _Member.會員名稱 = txtName.Text;
            _Member.性別 = cbbGender.Text;
            _Member.生日 = dtpBirthday.Value;
            _Member.電話 = txtPhone.Text;
            _Member.Email = txtEmail.Text;
            _Member.會員帳號 = txtAccount.Text;
            _Member.會員密碼 = txtPassword.Text;
            _Member.城市 = cbbCity.Text;
            _Member.地址 = txtAddress.Text;
            _Member.會員狀態 = cbbStatus.Checked;
            _Member.會員照片 = _selectimg;

            string Updatestr = "Update Member會員 set 會員名稱 = @會員姓名, 性別 =  @性別, 生日 = @生日, 手機號碼 = @手機號碼, Email= @Email," +
                " 帳號 = @帳號, 密碼= @密碼, 城市 = @城市, 地址 = @地址, 會員照片 =@會員照片 , 會員狀態 = @會員狀態";
            Updatestr += " where 會員ID = @會員ID";


            SqlCommand cmd = new SqlCommand(Updatestr, _con);
            cmd.Parameters.Add(new SqlParameter("會員ID", (object)_Member.會員ID));
            cmd.Parameters.Add(new SqlParameter("會員姓名", (object)_Member.會員名稱));
            cmd.Parameters.Add(new SqlParameter("性別", (object)_Member.性別));
            cmd.Parameters.Add(new SqlParameter("生日", (object)_Member.生日));
            cmd.Parameters.Add(new SqlParameter("手機號碼", (object)_Member.電話));
            cmd.Parameters.Add(new SqlParameter("Email", (object)_Member.Email));
            cmd.Parameters.Add(new SqlParameter("帳號", (object)_Member.會員帳號));
            cmd.Parameters.Add(new SqlParameter("密碼", (object)_Member.會員密碼));
            cmd.Parameters.Add(new SqlParameter("城市", (object)_Member.城市));
            cmd.Parameters.Add(new SqlParameter("地址", (object)_Member.地址));
            cmd.Parameters.Add(new SqlParameter("會員照片", (object)_Member.會員照片));
            cmd.Parameters.Add(new SqlParameter("會員狀態", (object)_Member.會員狀態));
            cmd.ExecuteNonQuery();

            displayonDatagridview();
            ControllerDisable();

            this.btnSave.Click -= new System.EventHandler(this.btnUpdateSave_Click);
        }

        private void tsbDelete_Click(object sender, EventArgs e)
        {
            DialogResult _isOK = MessageBox.Show("確定要刪除此筆資料", "刪除確認", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (_isOK == DialogResult.Yes)
            {
                string deletestr = "delete from Member會員 where 會員ID = @會員ID";
                SqlCommand cmd = new SqlCommand(deletestr, _con);
                cmd.Parameters.Add(new SqlParameter("會員ID", int.Parse(txtID.Text)));
                cmd.ExecuteNonQuery();
                displayonDatagridview();
            }
        }

        private void picMember_DoubleClick(object sender, EventArgs e)
        {
            ofdMemberPicture.Filter = "照片|*.jpg|照片|*.png|照片|*.bmp";
            if (ofdMemberPicture.ShowDialog() == DialogResult.OK)
            {
                Image img = Bitmap.FromFile(ofdMemberPicture.FileName);
                picMember.Image = img;

                _imgstream = new FileStream(ofdMemberPicture.FileName, FileMode.Open, FileAccess.Read);
                _reader = new BinaryReader(_imgstream);
                _Member.會員照片 = _reader.ReadBytes((int)_imgstream.Length);
                _selectimg = _Member.會員照片;
            }
            _reader.Close();
            _imgstream.Close();
        }


        private void btnSearch_Click(object sender, EventArgs e)
        {
            SearchandDisplayonDatagridview();
        }

        private void txtKeyword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                SearchandDisplayonDatagridview();
            }
        }
        private void txtKeyword_TextChanged(object sender, EventArgs e)
        {
            if (txtKeyword.Text == "")
            {
                displayonDatagridview();
            }
        }
        private void txtKeyword_MouseEnter(object sender, EventArgs e)
        {
            txtKeyword.Text = "";
        }

        private void txtKeyword_Leave(object sender, EventArgs e)
        {
            txtKeyword.Text = "關鍵字查詢";
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            ControllerDisable();
            this.btnSave.Click -= new System.EventHandler(this.btnInsertSave_Click);
            this.btnSave.Click -= new System.EventHandler(this.btnUpdateSave_Click);
        }
    }    
}
