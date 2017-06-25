using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace ChuyenDeVersion1_6_6
{
    public partial class FormDoiMatKhau : DevExpress.XtraEditors.XtraForm
    {
        public FormDoiMatKhau()
        {
            InitializeComponent();
        }

        private void FormDoiMatKhau_Load(object sender, EventArgs e)
        {
            this.textBoxUserName.Text = Program.mlogin;
            this.textBoxUserName.Enabled = false;
        }

        private void buttonLuu_Click(object sender, EventArgs e)
        {
            String makhaucu = this.textBoxMauKhauCu.Text;
            String matkhaumoi = this.textBoxMauKhauMoi.Text;
            if(makhaucu == "")
            {
                MessageBox.Show("Vui Lòng Điền Mật Khẩu Cũ","Thông báo", MessageBoxButtons.OK);
                return;
            }
            if(matkhaumoi == "")
            {
                MessageBox.Show("Vui Lòng Điền Mật Khẩu Mới", "Thông báo", MessageBoxButtons.OK);
                return;
            }
            if(makhaucu != Program.password)
            {
                MessageBox.Show("Mật Khẩu Cũ Không Đúng", "Thông báo", MessageBoxButtons.OK);
                return;
            }
            Program.KetNoi();
            string strLenh = "exec sp_password NULL, '" + matkhaumoi + "', '" +  this.textBoxUserName.Text   + "'";
            int kq = Program.ExecSqlNonQuery(strLenh);
            MessageBox.Show("Đổi mật khẩu thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            textBoxMauKhauCu.Text = "";
            textBoxMauKhauMoi.Text = "";
            Program.password = matkhaumoi;
            return;
        }

        private void buttonHuy_Click(object sender, EventArgs e)
        {
            this.Close();
            for (int i = 0; i < Program.xtratabcontrol.TabPages.Count; i++)
            {
                if (Program.xtratabcontrol.TabPages[i].Text == "Đổi Mật Khẩu")
                {
                    Program.xtratabcontrol.TabPages.RemoveAt(i);
                }
            }
        }
    }
}