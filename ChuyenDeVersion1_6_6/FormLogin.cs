using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChuyenDeVersion1_6_6
{
    public partial class FormLogin : DevExpress.XtraEditors.XtraForm
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void buttonDangNhap_Click(object sender, EventArgs e)
        {
            //if (textBoxTaiKhoan.Text.Trim() == "")
            //{
            //    MessageBox.Show("Tên tài khoản không được để trống", "Lỗi", MessageBoxButtons.OK);
            //    return;
            //}
            //if (textBoxMatKhau.Text.Trim() == "")
            //{
            //    MessageBox.Show("Mật khẩu không được để tróng", "Lỗi", MessageBoxButtons.OK);
            //    return;
            //}
            //Program.mlogin = textBoxTaiKhoan.Text.Trim();
            //Program.password = textBoxMatKhau.Text;
            //if (Program.KetNoi() == 0)
            //    return;
            //Program.mChinhanh = comboBoxChiNhanh.SelectedIndex; // xd chi nhanh
            //Program.tenChiNhanh = comboBoxChiNhanh.Text;
            //if (Program.tenChiNhanh == "CHI NHÁNH 1")
            //{
            //    Program.maCN = "CN1";
            //}
            //else
            //{
            //    if (Program.tenChiNhanh == "CHI NHÁNH 2")
            //    {
            //        Program.maCN = "CN2";
            //    }
            //}

            //SqlDataReader myReader;
            //Program.mloginDN = Program.mlogin;
            //Program.passwordDN = Program.password;
            //String strLenh = "exec SP_DANGNHAP '" + Program.mlogin + "'";
            //myReader = Program.ExecSqlDataReader(strLenh);
            //if (myReader == null) return;
            //myReader.Read();
            //Program.username = myReader.GetString(0);     // Lay user name
            //if (Convert.IsDBNull(Program.username))
            //{
            //    MessageBox.Show("Login bạn nhập không có quyền truy cập dữ liệu\n Bạn xem lại username của cơ sở dữ liệu", "", MessageBoxButtons.OK);
            //    return;
            //}
            //Program.mHoten = myReader.GetString(1);
            //Program.mGroup = myReader.GetString(2);

            //Program.frmMain.HienThiMenu();


            //myReader.Close();
            //Program.conn.Close();
        }
    }
}
