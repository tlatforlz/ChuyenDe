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
        }

        private void mượnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Program.mlogin = "2";
            string strLenh = "exec Sp_Them_CT_PhieuMuon '" + Program.maPhieu + "','"+Program.maISBN+"','"+Program.mlogin+"'";
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
                    return;
                }
                Program.mlogin = "2";

                string strLenh = "exec Sp_Them_CT_PhieuMuon '" + Program.maPhieu + "','" + Program.maISBN + "','" + Program.mlogin + "'";
                Program.ExecSqlNonQuery(strLenh);
                dem++;
                maISBN += " " + Program.maISBN;
                this.tableAdapterManager.UpdateAll(this.qL_THUVIENDataSet);
               
                this.fillToolStripButton.PerformClick();
               
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
            if (DialogResult.Yes == MessageBox.Show("Bạn đã mượn song sách chưa?", "Thông báo", MessageBoxButtons.YesNo))
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
    }
}
