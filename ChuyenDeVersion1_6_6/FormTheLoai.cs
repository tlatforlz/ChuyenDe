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
    public partial class FormTheLoai : Form
    {
        public FormTheLoai()
        {
            InitializeComponent();
        }

        private void FormTheLoai_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qL_THUVIENDataSet.THELOAI' table. You can move, or remove it, as needed.
            this.tHELOAITableAdapter.Fill(this.qL_THUVIENDataSet.THELOAI);
            xuLyButton(false);

        }

        private void mATLLabel_Click(object sender, EventArgs e)
        {

        }

        private void mATLTextEdit_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void tHELOAILabel_Click(object sender, EventArgs e)
        {

        }

        private void tHELOAITextEdit_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void xuLyButton(Boolean show)
        {
            txtMaTheLoai.Enabled = txtTenTheLoai.Enabled = btnLuu.Enabled = btnHuy.Enabled = show;
            btnThem.Enabled = dataGridView1.Enabled = !show;
        }
        private void thêmToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            this.txtMaTheLoai.Text=this.txtMaTheLoai.Text.Trim();
            this.txtTenTheLoai.Text=this.txtTenTheLoai.Text.Trim();
            string maTT = this.txtMaTheLoai.Text;
            string tenTT = this.txtTenTheLoai.Text;
            if(maTT.Length == 0)
            {
                MessageBox.Show("Mã Thể Loại Không Được Để Trống","Thông Báo",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
            else if (tenTT.Length == 0)
            {
                MessageBox.Show("Tên Thể Loại Không Được Để Trống", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if(maTT.Length > 5)
            {
                MessageBox.Show("Mã Thể Loại Chứa Tối Đa 5 Ký Tự", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (tenTT.Length > 50)
            {
                MessageBox.Show("Tên Thể Loại Chứa Tối Đa 50 Ký Tự", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                try
                {
                    this.Validate();
                    this.tHELOAIBindingSource.EndEdit();
                    //this.tHELOAITableAdapter.Fill(this.qL_THUVIENDataSet.THELOAI);
                    this.tableAdapterManager.UpdateAll(this.qL_THUVIENDataSet);
                    xuLyButton(false);
                }
                catch
                {
                    MessageBox.Show("Mã thể loại " + maTT + " đã tồn tại !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    
                }
            }
            txtTimKiem.Enabled = true;
        }

        private void sửaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            xuLyButton(true);
            txtMaTheLoai.Enabled = false;
            dataGridView1.Enabled = true;
            txtMaTheLoai.Focus();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            txtTimKiem.Enabled = false;
            xuLyButton(true);
            txtMaTheLoai.Text = "";
            txtTenTheLoai.Text = "";
            txtMaTheLoai.Focus();
            this.tHELOAIBindingSource.CancelEdit();
            this.tHELOAIBindingSource.AddNew();
            this.tableAdapterManager.UpdateAll(this.qL_THUVIENDataSet);
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            txtTimKiem.Enabled = true;
            this.tHELOAIBindingSource.CancelEdit();
            xuLyButton(false);
        }

        private void xóaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Bạn có chắc muốn xóa hay không?", "Thông báo", MessageBoxButtons.YesNo))
            {
                this.tHELOAIBindingSource.RemoveCurrent();
                this.tableAdapterManager.UpdateAll(this.qL_THUVIENDataSet);
            }
        }
        

        private void btnTimKiem_Click(object sender, EventArgs e)
        {

            
        }
        //private void txbtimkiem_TextChanged(object sender, EventArgs e)
        //{
        //    this.mONHOCBindingSource.Filter = "MAMH LIKE '%" + this.txbtimkiem.Text + "%'" + " OR TENMH LIKE '%" + this.txbtimkiem.Text + "%'";
        //}

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
                this.tHELOAIBindingSource.Filter = "MATL LIKE '%" + this.txtTimKiem + "%'" + " OR THELOAI LIKE '%" + this.txtTimKiem.Text + "%'";
        }
    }
}
