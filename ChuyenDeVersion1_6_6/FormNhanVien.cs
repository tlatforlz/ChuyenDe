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
    public partial class FormNhanVien : Form
    {
        public FormNhanVien()
        {
            InitializeComponent();
        }
        private void xuLyButton(Boolean show)
        {
            panel2.Visible= show;
            btnThemNhanVien.Enabled = dataGridView1.Enabled= !show;
        }
        private void xuLyButton2(Boolean show)
        {
            panel1.Enabled =btnThemTaiKhoan.Enabled=btnDoiMatKhau.Enabled= show;
            btnLuu.Enabled = btnHuy.Enabled = !show;
        }

        private void FormNhanVien_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qL_THUVIENDataSet.NHANVIEN' table. You can move, or remove it, as needed.
            this.nHANVIENTableAdapter.Fill(this.qL_THUVIENDataSet.NHANVIEN);
            //panel1.Visible = false;
            btnThemTaiKhoan.Enabled = false;
            btnDoiMatKhau.Enabled = false;
            txtMaNhanVien.Enabled = false;
            //btnThemTaiKhoan.Visible = false;
            panel2.Visible = false;
            panel1.Enabled = false;
            panel1.Visible = false;
            xuLyButton(false);
            dataGridView1.Enabled = true;
            tRANGTHAISpinEdit.Visible = false;
            if (qL_THUVIENDataSet.Tables["NHANVIEN"].Rows.Count <= 0)
            {
                contextMenuStrip1.Items[0].Enabled = false;
                contextMenuStrip1.Items[1].Enabled = false;
            }
        }

        private void sửaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            xuLyButton(true);
            //txtMaNhanVien.Enabled = false;
            dataGridView1.Enabled = true;
            hONVTextEdit.Focus();
        }
        Boolean themNhanVien = false;
        private void btnThemNhanVien_Click(object sender, EventArgs e)
        {
            themNhanVien = true;
            xuLyButton(true);
            //txtMaNhanVien.Enabled = true;
            hONVTextEdit.Focus();
            this.nHANVIENBindingSource.CancelEdit();
            this.nHANVIENBindingSource.AddNew();
            this.tableAdapterManager.UpdateAll(this.qL_THUVIENDataSet);
        }

        private void btnHuy2_Click(object sender, EventArgs e)
        {
            this.nHANVIENBindingSource.CancelEdit();
            xuLyButton(false);

        }
        private void xóaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Bạn có chắc muốn xóa hay không?", "Thông báo", MessageBoxButtons.YesNo))
            {
                Program.KetNoi();
                string strLenh = "sp_droplogin '" + txtTaiKhoan.Text +"'";
                int kq = Program.ExecSqlNonQuery(strLenh);
                if (kq != 0)
                {
                    return;
                }
                strLenh = "Update  NHANVIEN set TRANGTHAI = 0 where MANV = "+manv;
                 kq = Program.ExecSqlNonQuery(strLenh);

                //this.nHANVIENBindingSource.RemoveCurrent();
                this.nHANVIENTableAdapter.Fill(this.qL_THUVIENDataSet.NHANVIEN);
            }
        }
        public bool IsNumber(string pValue)
        {
            foreach (Char c in pValue)
            {
                if (!Char.IsDigit(c))
                    return false;
            }
            return true;
        }
        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            // this.nHANVIENBindingSource.Filter = "MANV = " + this.txtTimKiem.Text
            //                                                    + " OR TENNV LIKE '%" + this.txtTimKiem.Text + "%'";
            this.txtTimKiem.Text = this.txtTimKiem.Text.Trim();
            if(this.txtTimKiem.Text != "")
            {
                if (IsNumber(this.txtTimKiem.Text))
                {
                    this.nHANVIENBindingSource.Filter = "MANV = " + this.txtTimKiem.Text;
                }
                else
                {
                    this.nHANVIENBindingSource.Filter = "TENNV LIKE '%" + this.txtTimKiem.Text + "%'";
                }
            }else
            {
                this.nHANVIENBindingSource.Filter = "TENNV LIKE '%" + this.txtTimKiem.Text + "%'";
               
            }
            
        }

        private void btnLuu2_Click(object sender, EventArgs e)
        {

            if (hONVTextEdit.Text == "" || tENNVTextEdit.Text == "" || dIACHITextEdit.Text == ""
               || dIENTHOAITextEdit.Text == "" || eMAILTextEdit.Text == "")
            {
                MessageBox.Show("Bạn vui lòng điền đầy đủ các ô", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                hONVTextEdit.Focus();
                return;
            }
            if (dIENTHOAITextEdit.Text.Length > 11)
            {
                MessageBox.Show("Số điện thoại dưới 11 số. Bạn đã nhập " + dIENTHOAITextEdit.Text.Length + " số", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dIENTHOAITextEdit.Focus();
                return;
            }
            if (dIENTHOAITextEdit.Text.Length < 10)
            {
                MessageBox.Show("Số điện thoại trên 10 số. Bạn đã nhập " + dIENTHOAITextEdit.Text.Length + " số", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dIENTHOAITextEdit.Focus();
                return;
            }
            //if (txtMaNhanVien.Value <= 0)
            //{
            //    MessageBox.Show("Vui Lòng Nhập Mã Nhân Viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
            else
            {
                try
                {
                   
                    if (gIOITINHCheckEdit.Checked == false)
                    {
                        gIOITINHCheckEdit.EditValue = 0;
                    }
                    // trạng thái của tài khoản cho nhân viên đó, tao nhan vien tao tai khoan luon
                    tRANGTHAISpinEdit.Text = "1";
                    this.Validate();
                    // lay ra ma nhan vien moi them
                    //String a= ((DataRowView)nHANVIENBindingSource.Current).Row.ItemArray[0].ToString();
                    //MessageBox.Show("a = " + a);
                    manv = txtMaNhanVien.Text.ToString();
                   // txtMaNhanVien.Value =Int32.Parse(a);
                   // MessageBox.Show(current["CustomerID"])
                   // this.nHANVIENBindingSource.EndEdit();
                   // this.tableAdapterManager.UpdateAll(this.qL_THUVIENDataSet);
                   // this.nHANVIENTableAdapter.Fill(this.qL_THUVIENDataSet.NHANVIEN);
                    xuLyButton(false);
                   // return;
                    if (themNhanVien == true)
                    {
                        themNhanVien = false;
                        Program.KetNoi();
                        string strLenh = "exec TAO_LOGIN '" + ("NV" + manv) + "','" + "123" + "','" + manv + "','" + "NHANVIEN" + "'";
                        int kq = Program.ExecSqlNonQuery(strLenh);
                        if (kq == 0)
                        {
                            MessageBox.Show("Tạo tài khoản thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                           
                            panel1.Visible = false;
                            panel1.Visible = false;
                            btnThemTaiKhoan.Enabled = false;
                        }
                        else if (kq == 1)
                        {
                            tRANGTHAISpinEdit.Text = "0";
                            MessageBox.Show("Tên tài khoản đã tồn tại, vui lòng chọn tên khác", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                            
                        }
                        else
                        {
                            tRANGTHAISpinEdit.Text = "0";
                            MessageBox.Show("Tạo tài khoản không thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        }
                       
                    }
                    this.nHANVIENBindingSource.EndEdit();
                    this.tableAdapterManager.UpdateAll(this.qL_THUVIENDataSet);
                    this.nHANVIENTableAdapter.Fill(this.qL_THUVIENDataSet.NHANVIEN);
                    contextMenuStrip1.Items[0].Enabled = true;
                    contextMenuStrip1.Items[1].Enabled = true;
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Mã Lỗi  : "+ ex.Message + "\nThao tác không thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    //xuLyButton(false);
                   // MessageBox.Show("Thao tác không thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    //this.tableAdapterManager.UpdateAll(this.qL_THUVIENDataSet);
       
                }
               
            }

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
        string manv;
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           
            if (e.RowIndex >= 0)
            {
                contextMenuStrip1.Items[0].Enabled = true;
                contextMenuStrip1.Items[1].Enabled = true;
                DataGridViewRow row = (DataGridViewRow)dataGridView1.Rows[e.RowIndex];
                if (row.Cells[7].Value.ToString() == "0")
                {
                    contextMenuStrip1.Items[1].Enabled = false;
                    manv = row.Cells[0].Value.ToString();
                    txtTaiKhoan.Text = "";
                    panel1.Visible = false ;
                    btnThemTaiKhoan.Enabled = true;
                    btnDoiMatKhau.Enabled = false;
                }
                else
                {
                    contextMenuStrip1.Items[1].Enabled = true;
                    panel1.Visible = true;
                    manv = row.Cells[0].Value.ToString();
                    SqlDataReader myReader;
                    Program.KetNoi();
                    string strLenh = "exec sp_User_Login '" + manv + "'";
                    myReader = Program.ExecSqlDataReader(strLenh);
                    //myReader.Read();
                    if (myReader.Read())
                    {
                       // myReader.Read();
                        string tenTaiKhoan = myReader["name"].ToString();
                        txtTaiKhoan.Text = tenTaiKhoan;
                        btnDoiMatKhau.Enabled = true;
                        btnThemTaiKhoan.Enabled = false;
                    }
                    
                    
                }
               
            }
        }

        private void btnThemTaiKhoan_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            panel1.Enabled = true;
            txtTaiKhoan.Text = "";
            txtMatKhau.Text = "";
            btnThemTaiKhoan.Enabled = false;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (txtTaiKhoan.Enabled == true)
            {
                string tenTK = txtTaiKhoan.Text.Trim();
                string mk = txtMatKhau.Text.Trim();
                if (tenTK == "" || mk == "")
                {
                    MessageBox.Show("Vui lòng điền đầy đủ tên tài khoản và mật khẩu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                {
                    Program.KetNoi();
                    string strLenh = "exec TAO_LOGIN '" + tenTK + "','" + mk + "','" + manv + "','" + "NHANVIEN" +"'";
                    int kq= Program.ExecSqlNonQuery(strLenh);
                    if (kq == 0)
                    {
                        MessageBox.Show("Tạo tài khoản thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.tableAdapterManager.UpdateAll(this.qL_THUVIENDataSet);
                        this.nHANVIENTableAdapter.Fill(this.qL_THUVIENDataSet.NHANVIEN);
                        panel1.Visible = false;
                        //try
                        //{

                        //    String strLenh1 = "Update NHANVIEN SET TRA=1  where MAPHIEU = " + maPhieu + " and MASACH = '" + maSach + "'"
                        //                     + "Update SACH SET CHOMUON = 0 where MASACH = '" + maSach + "'";
                        //    Program.ExecSqlNonQuery(strLenh);
                        //    this.fillToolStripButton1.PerformClick();
                        //}
                        //catch (Exception ex)
                        //{
                        //    MessageBox.Show("Mã Lỗi  : " + ex.Message + "\nThao tác không thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        //}
                        panel1.Visible = false;
                        btnThemTaiKhoan.Enabled = false;
                    }
                    else if (kq == 1)
                    {
                        MessageBox.Show("Tên tài khoản đã tồn tại, vui lòng chọn tên khác", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    }
                    else
                    {
                        MessageBox.Show("Tạo tài khoản không thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    }

                }

            }
            else
            {
                string mk = txtMatKhau.Text.Trim();
                if (mk == "")
                {
                    MessageBox.Show("Vui lòng điền mật khẩu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    Program.KetNoi();
                    string strLenh = "exec sp_password NULL, '" + mk +  "', '" + txtTaiKhoan.Text + "'";
                    int kq = Program.ExecSqlNonQuery(strLenh);
                    MessageBox.Show("Đổi mật khẩu thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    panel1.Visible = false;
                    panel1.Enabled = false;
                    btnDoiMatKhau.Enabled = true;
                    txtMatKhau.Text = "";

                }
            }
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (qL_THUVIENDataSet.Tables["NHANVIEN"].Rows.Count <= 0)
            {
                contextMenuStrip1.Items[0].Enabled = false;
                contextMenuStrip1.Items[1].Enabled = false;
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            if (txtTaiKhoan.Enabled == true)
            {
                btnThemTaiKhoan.Enabled = true;
            }
            else
            {
                btnDoiMatKhau.Enabled = true;
            }
            panel1.Visible = false;
            panel1.Enabled = false;
        }

        private void btnDoiMatKhau_Click(object sender, EventArgs e)
        {
            txtMatKhau.Text = "";
            panel1.Visible = true;
            panel1.Enabled = true;
            txtTaiKhoan.Enabled = false;
            btnDoiMatKhau.Enabled = false;
        }

        private void dIACHITextEdit_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void nHANVIENBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txtTaiKhoan_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtMatKhau_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void eMAILTextEdit_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void eMAILLabel_Click(object sender, EventArgs e)
        {

        }

        private void dIENTHOAITextEdit_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void dIENTHOAILabel_Click(object sender, EventArgs e)
        {

        }

        private void dIACHILabel_Click(object sender, EventArgs e)
        {

        }

        private void gIOITINHCheckEdit_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void gIOITINHLabel_Click(object sender, EventArgs e)
        {

        }

        private void tENNVTextEdit_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void tENNVLabel_Click(object sender, EventArgs e)
        {

        }

        private void hONVTextEdit_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void hONVLabel_Click(object sender, EventArgs e)
        {

        }

        private void txtMaNhanVien_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void mANVLabel_Click(object sender, EventArgs e)
        {

        }

        private void dIENTHOAITextEdit_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void dataGridView1_MouseClick(object sender, MouseEventArgs e)
        {
            
        }
    }
}
