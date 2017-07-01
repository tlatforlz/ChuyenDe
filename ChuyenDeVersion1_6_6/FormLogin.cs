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

namespace ChuyenDeVersion1_6_6
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
            XuLiButton(true);
        }
        public void XuLiButton(bool KT)
        {
            this.txttaikhoan.Enabled = KT;
            this.txtmatkhau.Enabled = KT;
            //this.btndangnhap.Enabled = KT;
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                String loginname = this.txttaikhoan.Text.Trim();
                String password = this.txtmatkhau.Text.Trim();
                if (txttaikhoan.Text.Trim() == "")
                {
                    MessageBox.Show("Tên tài khoản không được để trống");
                    txttaikhoan.Focus();
                    return;
                }

                
                // Program.mCoSo = cbxcoso.SelectedIndex;
                // Program.servername = cbxcoso.SelectedValue.ToString().Trim();

                // kết nối đến CSDL
                
                SqlDataReader myReader;
                
                String strLenh = "";

                
                    Program.mlogin = loginname;
                    Program.password = password;
               // MessageBox.Show(loginname + " " + password + " \n" + Program.connstr);
                    Program.KetNoi();
                    strLenh = "exec sp_DangNhap_NhanVien '" + Program.mlogin + "'";
              
                myReader = Program.ExecSqlDataReader(strLenh);
                if (myReader == null)
                {
                    return;
                }
                myReader.Read();

                //Program.username = myReader.GetString(0).ToString();     // Lay username
                Program.username = myReader["ma"].ToString();
                if (Convert.IsDBNull(Program.username))
                {
                    MessageBox.Show("Login bạn nhập không có quyền truy cập dữ liệu\n Bạn xem lại username của cơ sở dữ liệu", "", MessageBoxButtons.OK);
                    return;
                }
                Program.mHoten = myReader["ho"].ToString() + myReader["ten"].ToString(); // lấy họ tên 
                Program.mGroup = myReader["quyen"].ToString(); // lấy nhóm quyền   
               // MessageBox.Show("quyen = " + Program.mGroup+ "\n ten tk = "+Program.mlogin+"\n hoten "+Program.mHoten);
                Program.frmMain.HienThiMenu();

                myReader.Close();
                Program.conn.Close();


                this.Close(); // đóng form hiện tại
                // mở form dexfrmMain
              
            }
            catch
            {
                MessageBox.Show("Login bạn nhập không có quyền truy cập dữ liệu\n Bạn xem lại username của cơ sở dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
