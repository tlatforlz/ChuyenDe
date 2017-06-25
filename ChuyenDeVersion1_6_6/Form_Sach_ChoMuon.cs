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
    public partial class Form_Sach_ChoMuon : Form
    {
        public Form_Sach_ChoMuon()
        {
            InitializeComponent();
        }

        private void Form_Sach_ChoMuon_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qL_THUVIENDataSet.SP_DS_ISBN' table. You can move, or remove it, as needed.
            // this.sP_DS_ISBNTableAdapter.Fill(this.qL_THUVIENDataSet.SP_DS_ISBN);
            this.fillToolStripButton.PerformClick();
            sP_DS_ISBNBindingNavigator.Visible = false;
            fillToolStrip.Visible = false;
            fillToolStrip1.Visible = false;
            if (qL_THUVIENDataSet.Tables["CT_PHIEUMUON"].Rows.Count <= 0)
            {
                //contextMenuStrip1.Items[0].Enabled = false;
               // contextMenuStrip1.Items[1].Enabled = false;
                contextMenuStrip2.Items[0].Enabled = false;
            }
        }

        private void mượnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Program.mlogin = "2";
            string strLenh = "exec Sp_Them_CT_PhieuMuon '" + Program.maPhieu + "','"+Program.maISBN+"','"+Program.username+"'";
            Program.ExecSqlNonQuery(strLenh);
           
            sP_DS_ISBNDataGridView.Update();
            sP_DS_ISBNDataGridView.Refresh();
        }

        private void sP_DS_ISBNDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = (DataGridViewRow)sP_DS_ISBNDataGridView.Rows[e.RowIndex];
                Program.maISBN = row.Cells[0].Value.ToString();
                // maphieuToolStripTextBox.Text = row.Cells[0].Value.ToString();
                // Program.maPhieu = row.Cells[0].Value.ToString();
            }
        }

        private void fillToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.sP_DS_ISBNTableAdapter.Fill(this.qL_THUVIENDataSet.SP_DS_ISBN, testToolStripTextBox.Text);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }
        int dem = 0;
        String maISBN = "";

        private void mượnSáchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
               
                if (dem >= 3)
                {
                    MessageBox.Show("Bạn chỉ được mượn tối đa 3 cuốn trong 1 phiếu.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (maISBN.Contains(Program.maISBN))
                {

                    MessageBox.Show("Bạn đã mượn sách này nên không thể mượn thêm nữa. ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    //MessageBox.Show(maISBN);
                    return;
                }
                // Program.mlogin = "2";
                Program.KetNoi();
                string strLenh = "exec Sp_Them_CT_PhieuMuon '" + Program.maPhieu + "','" + Program.maISBN + "','" + Program.username + "'";
                Program.ExecSqlNonQuery(strLenh);
                dem++;
                //MessageBox.Show("isbn sap them " + Program.maISBN);
                maISBN += " " + Program.maISBN+" ";
                //MessageBox.Show("mang isbn sau them " +maISBN);
                this.tableAdapterManager.UpdateAll(this.qL_THUVIENDataSet);
                maphieuToolStripTextBox.Text = Program.maPhieu;
                this.fillToolStripButton.PerformClick();
                this.fillToolStripButton1.PerformClick();
               
            }
            catch(Exception ex)
            {
                MessageBox.Show("Mã Lỗi  : " + ex.Message + "\nThao Tác Không Thành Công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void sP_DS_ISBNDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void sP_DS_ISBNDataGridView_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = (DataGridViewRow)sP_DS_ISBNDataGridView.Rows[e.RowIndex];
                Program.maISBN = row.Cells[0].Value.ToString();
                // maphieuToolStripTextBox.Text = row.Cells[0].Value.ToString();
                // Program.maPhieu = row.Cells[0].Value.ToString();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Bạn đã mượn xong sách chưa?", "Thông báo", MessageBoxButtons.YesNo))
            {
                this.Close();
            }
           
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            this.txtTimKiem.Text = this.txtTimKiem.Text.Trim();
            
            this.sP_DS_ISBNBindingSource.Filter = "ISBN LIKE '%" + this.txtTimKiem.Text + "%'" 
                                                + " OR TENSACH LIKE '%" + this.txtTimKiem.Text + "%'";
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
        String maSach = "";
        private void huyrToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Program.conn.Close();
                Program.KetNoi();
                String strLenh1 = "exec Sp_Xoa_CT_PhieuMuon '" + Program.maPhieu + "','" + maSach + "','" + Program.username + "'";
                Program.ExecSqlNonQuery(strLenh1);
                this.fillToolStripButton.PerformClick();
                maphieuToolStripTextBox.Text = Program.maPhieu;
                this.fillToolStripButton1.PerformClick();
                dem--;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Mã Lỗi  : " + ex.Message + "\nThao Tác Không Thành Công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            SqlDataReader myReader = null;
                Program.conn.Close();
                Program.KetNoi();
                String strLenh = "SELECT ISBN  FROM SACH WHERE MASACH= '" + maSach + "'";
                
                myReader = Program.ExecSqlDataReader(strLenh);
                if (myReader != null)
                {
                   while (myReader.Read())
                    {
                        //Program.username = myReader.GetString(0).ToString();     // Lay username
                        Program.maISBN = myReader["ISBN"].ToString();
                       // MessageBox.Show("ma isbn data " + Program.maISBN);
                    }
                }
               // MessageBox.Show("isbn sap huy" + Program.maISBN+ "\ntruoc huy" + maISBN);
                //MessageBox.Show("truoc huy" + maISBN);
                maISBN = maISBN.Replace(Program.maISBN, " ");
                //MessageBox.Show("sau huy" + maISBN);
                //MessageBox.Show(maISBN);
                //program.mais
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show("Mã Lỗi  : " + ex.Message + "\nThao Tác Không Thành Công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
        }

        private void cT_PhieuMuon_PhieuMuonDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (qL_THUVIENDataSet.Tables["CT_PhieuMuon_PhieuMuon"].Rows.Count > 0)
                {
                    contextMenuStrip2.Items[0].Enabled = true;
                }
                else
                {
                    contextMenuStrip2.Items[0].Enabled = false;
                }
                DataGridViewRow row = (DataGridViewRow)cT_PhieuMuon_PhieuMuonDataGridView.Rows[e.RowIndex];
                maSach = row.Cells[1].Value.ToString();
                //Program.maISBN= row.Cells[5].Value.ToString();
                // maphieuToolStripTextBox.Text = row.Cells[0].Value.ToString();
                // Program.maPhieu = row.Cells[0].Value.ToString();
            }
        }

        private void cT_PhieuMuon_PhieuMuonDataGridView_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (qL_THUVIENDataSet.Tables["CT_PhieuMuon_PhieuMuon"].Rows.Count > 0)
                {
                    contextMenuStrip2.Items[0].Enabled = true;
                }
                else
                {
                    contextMenuStrip2.Items[0].Enabled = false;
                }
                DataGridViewRow row = (DataGridViewRow)cT_PhieuMuon_PhieuMuonDataGridView.Rows[e.RowIndex];
                maSach = row.Cells[1].Value.ToString();
                //Program.maISBN= row.Cells[5].Value.ToString();
                // maphieuToolStripTextBox.Text = row.Cells[0].Value.ToString();
                // Program.maPhieu = row.Cells[0].Value.ToString();
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            String maSach = "";
            if (qL_THUVIENDataSet.Tables["CT_PhieuMuon_PhieuMuon"].Rows.Count > 0)
            {
                foreach (DataRow dr in qL_THUVIENDataSet.Tables["CT_PhieuMuon_PhieuMuon"].Rows)
                {
                    maSach = (dr["MASACH"].ToString());
                    Program.conn.Close();
                    Program.KetNoi();
                    String strLenh1 = "exec Sp_Xoa_CT_PhieuMuon '" + Program.maPhieu + "','" + maSach + "','" + Program.username + "'";
                    Program.ExecSqlNonQuery(strLenh1);
                    
                }
            }
            if (DialogResult.Yes == MessageBox.Show("Bạn có chắc muốn thoát không?", "Thông báo", MessageBoxButtons.YesNo))
            {
                this.Close();
            }
        }
    }
}
