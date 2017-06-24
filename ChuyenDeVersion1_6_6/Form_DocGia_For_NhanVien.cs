using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChuyenDeVersion1_6_6
{
    public partial class Form_DocGia_For_NhanVien : Form
    {
        public Form_DocGia_For_NhanVien()
        {
            InitializeComponent();
            if(Program.DocGiaPM == 0)
            {
                contextMenuStrip1.Items[2].Visible = false;
                contextMenuStrip1.Items[5].Visible = false;
                contextMenuStrip1.Items[0].Visible = true;
                contextMenuStrip1.Items[1].Visible = true;
                contextMenuStrip1.Items[3].Visible = true;
                contextMenuStrip1.Items[4].Visible = true;
            }
            else
            {
                contextMenuStrip1.Items[2].Visible = true;
                contextMenuStrip1.Items[5].Visible = true;
                contextMenuStrip1.Items[0].Visible = false;
                contextMenuStrip1.Items[1].Visible = false;
                contextMenuStrip1.Items[3].Visible = false;
                contextMenuStrip1.Items[4].Visible = false;
            }
        }

        private void xuLyButton( Boolean show)
        {
            panel1.Enabled = dataGridView1.Enabled = show;

        }

        private void Form_DocGia_For_NhanVien_Load(object sender, EventArgs e)
        {
            this.dOCGIATableAdapter.Fill(this.qL_THUVIENDataSet.DOCGIA);
            panel1.Enabled = false;
            tRANGTHAISpinEdit.Visible = false;
            panel2.Enabled = false;
            mADGSpinEdit.Enabled = false;
            nGAYLAMTHEDateEdit.Enabled = false;
            nGAYHETHANDateEdit.Enabled = false;
            if (qL_THUVIENDataSet.Tables["DOCGIA"].Rows.Count <= 0)
            {
                
                contextMenuStrip1.Items[1].Enabled = false;
                contextMenuStrip1.Items[2].Enabled = false;
                contextMenuStrip1.Items[3].Enabled = false;
                contextMenuStrip1.Items[4].Enabled = false;
                contextMenuStrip1.Items[5].Enabled = false;
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        Boolean themDocGia = false;
        private void thêmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            themDocGia = true;
            dataGridView1.Enabled = false;
            panel1.Enabled = true;
            hODGTextEdit.Text = tENDGTextEdit.Text = eMAILDGTextEdit.Text = sOCMNDTextEdit.Text = dIACHITextEdit.Text = dIENTHOAITextEdit.Text = "";
            hODGTextEdit.Focus();
            this.dOCGIABindingSource.CancelEdit();
            this.dOCGIABindingSource.AddNew();
            DateTime now = DateTime.Now;
            nGAYLAMTHEDateEdit.EditValue = now.ToString();
            nGAYHETHANDateEdit.EditValue = (now.AddYears(1)).ToString();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if ( hODGTextEdit.Text == "" || tENDGTextEdit.Text == "" || eMAILDGTextEdit.Text == "" || sOCMNDTextEdit.Text == "" || dIACHITextEdit.Text == "" || dIENTHOAITextEdit.Text == "")
            {
                MessageBox.Show("Bạn vui lòng điền đầy đủ các ô", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                hODGTextEdit.Focus();
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
            if (sOCMNDTextEdit.Text.Length != 9)
            {
                MessageBox.Show("Số CMND la 9 số. Bạn đã nhập "+sOCMNDTextEdit.Text.Length+" số", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                sOCMNDTextEdit.Focus();
                return;
            }
            
            else
            {
                try
                {
                    DateTime myDate1 = DateTime.Parse(nGAYLAMTHEDateEdit.Text);
                    DateTime myDate2 = DateTime.Parse(nGAYHETHANDateEdit.Text);
                    DateTime myDate3 = DateTime.Parse(nGAYSINHDateEdit.Text);
                    DateTime now = DateTime.Now;
                    if (now < myDate3)
                    {
                        MessageBox.Show("Ngày sinh phải nhỏ hơn ngày hiện tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    
                    if (gIOITINHCheckEdit.Checked == false)
                    {
                        gIOITINHCheckEdit.EditValue = 0;
                    }
                    if (hOATDONGCheckEdit.Checked == false)
                    {
                        hOATDONGCheckEdit.EditValue = 0;
                    }
                        tRANGTHAISpinEdit.Text = "1";
                    this.Validate();
                    maDG = mADGSpinEdit.Text;
                    panel1.Enabled = false;
                    dataGridView1.Enabled = true;
                    if (themDocGia == true)
                    {
                        themDocGia = false;
                        Program.KetNoi();
                        string strLenh = "exec TAO_LOGIN '" + ("DG" + maDG) + "','" + "123" + "','" + sOCMNDTextEdit.Text.Trim() + "','" + "DOCGIA" + "'";
                        int kq = 0;
                        try
                        {
                             kq = Program.ExecSqlNonQuery(strLenh);
                        }catch(Exception err)
                        {
                            MessageBox.Show(err.ToString());
                        }
                        if (kq == 0)
                        {
                            MessageBox.Show("Tạo tài khoản thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            panel1.Visible = false;
                            panel1.Visible = false;
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
                    this.dOCGIABindingSource.EndEdit();
                    this.tableAdapterManager.UpdateAll(this.qL_THUVIENDataSet);
                    this.dOCGIATableAdapter.Fill(this.qL_THUVIENDataSet.DOCGIA);
                    if(contextMenuStrip1.Items[4].Enabled != true)
                    {
                        contextMenuStrip1.Items[4].Enabled = true;
                        contextMenuStrip1.Items[1].Enabled = true;
                        contextMenuStrip1.Items[2].Enabled = true;
                        contextMenuStrip1.Items[3].Enabled = true;
                        contextMenuStrip1.Items[5].Enabled = true;
                    }
                    
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Mã Lỗi  : " + ex.Message + "\nThao tác không thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                  
                }
                
            }

        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.dOCGIABindingSource.CancelEdit();
            panel1.Enabled = false;
            dataGridView1.Enabled = true;
        }

        private void sửaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.Enabled = true;
            hODGTextEdit.Focus();
        }

        private void xóaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Bạn có chắc muốn xóa hay không?", "Thông báo", MessageBoxButtons.YesNo))
            {
                Program.KetNoi();
                
                    string strLenh = "sp_droplogin '" + txtTaiKhoan.Text + "'";
                    int kq = Program.ExecSqlNonQuery(strLenh);
                    if (kq != 0)
                    {
                        return;
                    }
                    
                 strLenh = "Update  DOCGIA set TRANGTHAI = 0 where MADG = " + maDG;
                 kq = Program.ExecSqlNonQuery(strLenh);
                this.dOCGIATableAdapter.Fill(this.qL_THUVIENDataSet.DOCGIA);
            }
        }
        string maDG;
        private void mượnTrảToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Program.maDG = maDG;
            FormDocGia_PhieuMuon fm = new FormDocGia_PhieuMuon();
            fm.ShowDialog();
        }
        String cmnd;
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = (DataGridViewRow)dataGridView1.Rows[e.RowIndex];
                if (row.Cells[12].Value.ToString() == "0")
                {
                    contextMenuStrip1.Items[4].Enabled = false;
                    contextMenuStrip1.Items[3].Enabled = false;
                }
                else
                {
                    contextMenuStrip1.Items[4].Enabled = true;
                    contextMenuStrip1.Items[3].Enabled = false;
                }
                maDG = row.Cells[0].Value.ToString();
                cmnd= row.Cells[4].Value.ToString();
                DateTime ngayHetHan = Convert.ToDateTime(row.Cells[10].Value.ToString());
                DateTime now = DateTime.Now;
                if (ngayHetHan < now)
                {
                    Program.muonSach = false;
                }
                else
                {
                    Program.muonSach = true;
                }
                Program.maDG = maDG;
                SqlDataReader myReader;
                Program.KetNoi();
                string strLenh = "exec sp_User_Login '" + cmnd + "'";
                myReader = Program.ExecSqlDataReader(strLenh);
                
                if (myReader.Read())
                {
                    string tenTaiKhoan = myReader["name"].ToString();
                    txtTaiKhoan.Text = tenTaiKhoan;
                }
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
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            this.txtTimKiem.Text = this.txtTimKiem.Text.Trim();
            if (this.txtTimKiem.Text != "")
            {
                if (IsNumber(this.txtTimKiem.Text))
                {
                    this.dOCGIABindingSource.Filter = "MADG = " + this.txtTimKiem.Text;
                }
                else
                {
                    this.dOCGIABindingSource.Filter = "TENDG LIKE '%" + this.txtTimKiem.Text + "%'";
                }
            }
            else
            {
                this.dOCGIABindingSource.Filter = "TENDG LIKE '%" + this.txtTimKiem.Text + "%'";

            }
        }

        private void thêmTàiKhoảnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel2.Enabled = true;
        }

        private void btnLuuTaiKhoan_Click(object sender, EventArgs e)
        {
            string mk = txtMatKhau.Text.Trim();
            if (mk == "")
            {
                MessageBox.Show("Vui lòng điền mật khẩu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Program.KetNoi();
                string strLenh = "exec sp_password NULL, '" + mk + "', '" + txtTaiKhoan.Text + "'";
                int kq = Program.ExecSqlNonQuery(strLenh);
                MessageBox.Show("Đổi mật khẩu thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                panel2.Enabled = false;
                txtMatKhau.Text = "";
            }
        }

        private void mADGSpinEdit_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void mADGLabel_Click(object sender, EventArgs e)
        {

        }

        private void sOCMNDTextEdit_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void dIENTHOAITextEdit_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void btnHuyTaiKhoan_Click(object sender, EventArgs e)
        {
            panel2.Enabled = false;
            txtMatKhau.Text = "";
        }

        private void giaHạnThẻToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DateTime now = DateTime.Now;
            nGAYHETHANDateEdit.EditValue = (now.AddYears(1)).ToString();
            try
            {
                this.dOCGIABindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.qL_THUVIENDataSet);
                this.dOCGIATableAdapter.Fill(this.qL_THUVIENDataSet.DOCGIA);
                MessageBox.Show("Gia Hạn Thẻ Thành Công");
            }
            catch(Exception ex)
            {
                MessageBox.Show("Mã Lỗi : " + ex.ToString());
            }
           

        }
    }
}
