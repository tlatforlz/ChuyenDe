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
    public partial class FormDocGia_PhieuMuon : Form
    {
        public FormDocGia_PhieuMuon()
        {
            InitializeComponent();

            //SqlDataAdapter da1;
            //DataTable dt1 = new DataTable();
            //MessageBox.Show(contextMenuStrip1.Items[0].ToString());
            mAPHIEUSpinEdit.Enabled = false;
            contextMenuStrip1.Items[0].Enabled = false;
            contextMenuStrip1.Items[1].Enabled = false;
            contextMenuStrip2.Items[0].Enabled = false;
            fillToolStrip.Visible = false;
            fillToolStrip1.Visible = false;
            panel1.Enabled = false;
           // sP_DocGia_PhieuMuonBindingNavigator.Visible = false; ////// ??????????????????
            Program.KetNoi();
            if (Program.mGroup == "DOCGIA")
            {
                Program.maDG = Program.mlogin;
            }
            //Program.maDG = "4";
            maDocGiaToolStripTextBox.Text = Program.maDG;
            this.fillToolStripButton.PerformClick();
            if (Program.muonSach == false)
            {
                btnThem.Enabled = false;


            }
            //string strLenh = "exec SP_DocGia_PhieuMuon '" + Program.ml + "'";
            //da1 = new SqlDataAdapter("exec SP_DocGia_PhieuMuon '" + Program.maDG + "'", Program.conn);
            //da1.Fill(dt1);
            //dataGridView1.DataSource = dt1;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {

                DataGridViewRow row = (DataGridViewRow)sP_DocGia_PhieuMuonDataGridView.Rows[e.RowIndex];
                maphieuToolStripTextBox.Text = row.Cells[0].Value.ToString();
                this.fillToolStripButton1.PerformClick();
               // SqlDataAdapter da2;
               // DataTable dt2 = new DataTable();
                //
                //da2 = new SqlDataAdapter("SELECT * FROM SACH WHERE ISBN = '" + row.Cells[0].Value.ToString() + "'", Program.conn);
               // da2 = new SqlDataAdapter("exec CT_PhieuMuon_PhieuMuon '" + row.Cells[0].Value.ToString() + "'", Program.conn);
               // da2.Fill(dt2);
               // dataGridView2.DataSource = dt2;
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void fillToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.sP_DocGia_PhieuMuonTableAdapter.Fill(this.qL_THUVIENDataSet.SP_DocGia_PhieuMuon, maDocGiaToolStripTextBox.Text);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void fillToolStripButton1_Click(object sender, EventArgs e)
        {
            try
            {
                this.cT_PhieuMuon_PhieuMuonTableAdapter.Fill(this.qL_THUVIENDataSet.CT_PhieuMuon_PhieuMuon, maphieuToolStripTextBox.Text);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void fillToolStrip_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void FormDocGia_PhieuMuon_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qL_THUVIENDataSet.PHIEUMUON' table. You can move, or remove it, as needed.
            this.pHIEUMUONTableAdapter.Fill(this.qL_THUVIENDataSet.PHIEUMUON);
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            
           // this.tableAdapterManager.UpdateAll(this.qL_THUVIENDataSet);
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            
            if (mAPHIEUSpinEdit.Value <= 0)
            {
                MessageBox.Show("Vui Lòng Nhập Mã Phiếu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    if (hINHTHUCCheckEdit.Checked == false)
                    {
                        hINHTHUCCheckEdit.EditValue = 0;
                    }
                    this.Validate();
                    this.pHIEUMUONBindingSource.EndEdit();
                    this.tableAdapterManager.UpdateAll(this.qL_THUVIENDataSet);
                    panel1.Enabled = false;
                    sP_DocGia_PhieuMuonDataGridView.Enabled = true;
                    cT_PhieuMuon_PhieuMuonDataGridView.Enabled = true;
                    this.fillToolStripButton.PerformClick();
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Mã Lỗi  : " + ex.Message + "\nThao tác không thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            
        }

        private void fillToolStripButton_Click_1(object sender, EventArgs e)
        {
            try
            {
                this.sP_DocGia_PhieuMuonTableAdapter.Fill(this.qL_THUVIENDataSet.SP_DocGia_PhieuMuon, maDocGiaToolStripTextBox.Text);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void fillToolStripButton1_Click_1(object sender, EventArgs e)
        {
            try
            {
                this.cT_PhieuMuon_PhieuMuonTableAdapter.Fill(this.qL_THUVIENDataSet.CT_PhieuMuon_PhieuMuon, maphieuToolStripTextBox.Text);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void btnThem_Click_1(object sender, EventArgs e)
        {
            panel1.Enabled = true;
            sP_DocGia_PhieuMuonDataGridView.Enabled = false;
            cT_PhieuMuon_PhieuMuonDataGridView.Enabled = false;
            mADGSpinEdit.Enabled = false;
            mANVSpinEdit.Enabled = false;
            nGAYMUONDateEdit.Enabled = false;
            mAPHIEUSpinEdit.Focus();
            this.pHIEUMUONBindingSource.CancelEdit();
            this.pHIEUMUONBindingSource.AddNew();
            this.tableAdapterManager.UpdateAll(this.qL_THUVIENDataSet);
            mADGSpinEdit.Value = Int32.Parse(Program.maDG);
            mANVSpinEdit.Value = 2;
            // mANVSpinEdit.Value = Int32.Parse(Program.mlogin);
            DateTime now = DateTime.Now;
            nGAYMUONDateEdit.DateTime = now;
        }

        private void btnHuy_Click_1(object sender, EventArgs e)
        {
            panel1.Enabled = false;
            sP_DocGia_PhieuMuonDataGridView.Enabled = true;
            cT_PhieuMuon_PhieuMuonDataGridView.Enabled = true;
            this.pHIEUMUONBindingSource.CancelEdit();
        }

        private void sP_DocGia_PhieuMuonDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = (DataGridViewRow)sP_DocGia_PhieuMuonDataGridView.Rows[e.RowIndex];
                maphieuToolStripTextBox.Text = row.Cells[0].Value.ToString();
                Program.maPhieu= row.Cells[0].Value.ToString();
                this.fillToolStripButton1.PerformClick();
                //foreach (DataTable table in qL_THUVIENDataSet.Tables)
                //    if (table.Rows.Count != 0)
                //    {
                //        //MessageBox.Show("x= " + qL_THUVIENDataSet.Tables.Count);
                //        //MessageBox.Show("x= " + table.TableName);
                //        //MessageBox.Show("x= " + table.Rows.Count);
                //    }
                if (Program.muonSach == false)
                {
                    contextMenuStrip1.Items[0].Enabled = false;
                    btnThem.Enabled = false;
                }
                
                if (qL_THUVIENDataSet.Tables["CT_PhieuMuon_PhieuMuon"].Rows.Count > 0)
                {
                    contextMenuStrip1.Items[0].Enabled = false;
                    contextMenuStrip1.Items[1].Enabled = false;
                }
                else
                {
                    contextMenuStrip1.Items[1].Enabled = true;
                    contextMenuStrip1.Items[0].Enabled = true;
                }
               // MessageBox.Show("x= " + qL_THUVIENDataSet.Tables["NHANVIEN"].Rows.Count);
                //MessageBox.Show("x= " + qL_THUVIENDataSet.Tables.ToString());
                //MessageBox.Show("x= " +qL_THUVIENDataSet.Tables["CT_PHIEUMUONDataTable"].Rows.Count);

                //MessageBox.Show("x= " + qL_THUVIENDataSet.Tables[1].Rows.Count);
                //cT_PhieuMuon_PhieuMuonDataGridView.;
                // SqlDataAdapter da2;
                // DataTable dt2 = new DataTable();
                //
                //da2 = new SqlDataAdapter("SELECT * FROM SACH WHERE ISBN = '" + row.Cells[0].Value.ToString() + "'", Program.conn);
                // da2 = new SqlDataAdapter("exec CT_PhieuMuon_PhieuMuon '" + row.Cells[0].Value.ToString() + "'", Program.conn);
                // da2.Fill(dt2);
                // dataGridView2.DataSource = dt2;
            }
        }

        private void thêmSáchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_Sach_ChoMuon fm = new Form_Sach_ChoMuon();
            fm.ShowDialog();
            //this.Hide();    
        }

        private void cT_PhieuMuon_PhieuMuonDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Bạn có chắc muốn thoát không?", "Thông báo", MessageBoxButtons.YesNo))
            {
                this.Close();
            }
        }

        private void xóaPhiếuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            try
            {
                if (DialogResult.Yes == MessageBox.Show("Bạn có chắc muốn xóa hay không?", "Thông báo", MessageBoxButtons.YesNo))
                {
                    String strLenh = "Delete from PHIEUMUON  where MAPHIEU = " + Program.maPhieu;
                    Program.ExecSqlDataReader(strLenh);
                    this.fillToolStripButton.PerformClick();
                }
                
            }
            catch(Exception ex)
            {
                MessageBox.Show("Mã Lỗi  : " + ex.Message + "\nThao tác không thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        String maPhieu = "";
        String maSach = "";
        private void cT_PhieuMuon_PhieuMuonDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = (DataGridViewRow)cT_PhieuMuon_PhieuMuonDataGridView.Rows[e.RowIndex];
                String Tra = row.Cells[5].Value.ToString();
                maPhieu = row.Cells[0].Value.ToString();
                maSach = row.Cells[1].Value.ToString();
                if (Tra == "False")
                {
                    contextMenuStrip2.Items[0].Enabled = true;
                }
                else
                {
                    contextMenuStrip2.Items[0].Enabled = false;
                }
                //MessageBox.Show("tra = " + Tra);
            }
        }

        private void trảSáchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                
                    String strLenh = "Update CT_PHIEUMUON SET TRA=1  where MAPHIEU = " + maPhieu +" and MASACH = '" + maSach+"'"
                                     +"Update SACH SET CHOMUON = 0 where MASACH = '"+maSach+"'";
                    Program.ExecSqlNonQuery(strLenh);
                    this.fillToolStripButton1.PerformClick();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Mã Lỗi  : " + ex.Message + "\nThao tác không thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            this.txtTimKiem.Text = this.txtTimKiem.Text.Trim();
            if (this.txtTimKiem.Text.Trim() == "")
            {
                this.sP_DocGia_PhieuMuonBindingSource.Filter = "MAPHIEU > 0 ";
                //this.fillToolStripButton.PerformClick();
                //this.tableAdapterManager.UpdateAll(qL_THUVIENDataSet);
                //return;
            }
            else
            {
                this.sP_DocGia_PhieuMuonBindingSource.Filter = "MAPHIEU = " + this.txtTimKiem.Text
                                                + " OR MADG = " + this.txtTimKiem.Text;
            }
            
        }
    }
}
