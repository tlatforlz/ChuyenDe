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
    public partial class FormSach : Form
    {
        public FormSach()
        {
            InitializeComponent();
            this.LayMaISBN();
            this.LayMaTenNganTu();
            this.XuLiButton(true);
            this.cbxmaisbn.Hide();
            this.cbxmangantu.Hide();
            

        }
        // phương thức set trạng thái button
        private void XuLiButton(bool KT)
        {
            this.button6.Enabled = this.button7.Enabled = this.button8.Enabled = this.button9.Enabled = this.btnthem.Enabled = this.btnxoa.Enabled = this.btnsua.Enabled = this.txbtimkiem.Enabled = KT;
            this.cbxmotaNT.Enabled  = this.cbxtensach.Enabled = this.iSBNTextEdit.Enabled = this.mASACHTextEdit.Enabled = this.tINHTRANGCheckEdit.Enabled = this.cHOMUONCheckEdit.Enabled = this.mANGANTUSpinEdit.Enabled =  this.btnluu.Enabled = this.btnhuy.Enabled = !KT;
        }

        // phương thức lấy mã ISBN bỏ vào combobox
        private void LayMaISBN()
        {
            Program.KetNoi();
            String strLenh = "dbo.sp_LayMaTenDauSach";
            Program.sqlcmd = Program.conn.CreateCommand();
            Program.sqlcmd.CommandType = CommandType.StoredProcedure;
            Program.sqlcmd.CommandText = strLenh;
            SqlDataReader myReader;
            myReader = Program.ExecSqlDataReader(strLenh);

            while (myReader.Read() == true)
            {          
                this.cbxmaisbn.Items.Add(myReader.GetString(0));
                this.cbxtensach.Items.Add(myReader.GetString(1));
            }
            myReader.Close();
            Program.conn.Close();
        }

        // phương thức lấy mã ISBN bỏ vào combobox
        private void LayMaTenNganTu()
        {
            Program.KetNoi();
            String strLenh = "dbo.sp_LayMaTenNganTu";
            Program.sqlcmd = Program.conn.CreateCommand();
            Program.sqlcmd.CommandType = CommandType.StoredProcedure;
            Program.sqlcmd.CommandText = strLenh;
            SqlDataReader myReader;
            myReader = Program.ExecSqlDataReader(strLenh);

            while (myReader.Read() == true)
            {
                this.cbxmangantu.Items.Add(myReader.GetInt32(0));
                this.cbxmotaNT.Items.Add(myReader.GetString(1));
            }
            myReader.Close();
            Program.conn.Close();
        }

        private void sACHBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.sACHBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.qL_THUVIENDataSet);

        }

        private void FormSach_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qL_THUVIENDataSet.SACH' table. You can move, or remove it, as needed.
            this.sACHTableAdapter.Fill(this.qL_THUVIENDataSet.SACH);
            this.cbxmaisbn.Text = this.iSBNTextEdit.Text;
            this.cbxmangantu.Text = this.mANGANTUSpinEdit.Text;
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            this.XuLiButton(false);
            this.cbxmaisbn.Show();
            this.cbxmangantu.Show();

            this.iSBNTextEdit.Focus();// cho con trỏ chuột trỏ ngay ô textbox mã môn học
            this.sACHBindingSource.AddNew(); // thêm 1 sách vào dataset  
            this.cbxmaisbn.SelectedIndex = 0;
            this.cbxmangantu.SelectedIndex = 0;
            this.mASACHTextEdit.Focus();
        }

        private void btnluu_Click(object sender, EventArgs e)
        {
            this.iSBNTextEdit.Text = this.cbxmaisbn.Text;
            this.mANGANTUSpinEdit.Text = this.cbxmangantu.Text;

            string isbn = this.cbxmaisbn.SelectedItem.ToString();
            string masach = this.mASACHTextEdit.Text;
            string mangantu = this.cbxmangantu.SelectedItem.ToString();

            if (this.tINHTRANGCheckEdit.Checked == false)
            {
                this.tINHTRANGCheckEdit.Checked = false;
            }
            if (this.cHOMUONCheckEdit.Checked == false)
            {
                this.cHOMUONCheckEdit.Checked = false;
            }

            if (isbn.Length == 0 || masach.Length == 0 || mangantu.Length == 0)
            {
                MessageBox.Show("Thong tin không được để trống !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (isbn.Length > 10)
                {
                    MessageBox.Show("Mã đầu sách chứa tối đa 10 kí tự !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (masach.Length > 10)
                {
                    MessageBox.Show("Mã sách chứa tối đa 10 kí tự !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    try
                    {
                        this.Validate();
                        this.sACHBindingSource.EndEdit(); // kết thúc quá trình hiệu chỉnh dữ liệu trên 1 dòng trong Dataset
                        this.sACHTableAdapter.Update(this.qL_THUVIENDataSet); // cập nhật dữ liệu và database
                        this.XuLiButton(true);
                        this.cbxmaisbn.Hide();
                        this.cbxmangantu.Hide();
                    }
                    catch (Exception er)
                    {
                        this.sACHBindingSource.RemoveCurrent(); // nếu thêm không thành công thì nó vẫn thêm vào dataset - xóa trên dataset 
                        MessageBox.Show(er.ToString());
                        MessageBox.Show("Mã ISBN " + isbn +" chưa tồn tại hoặc mã sách "+ masach + " đã tồn tại !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        this.XuLiButton(true);
                        this.cbxmaisbn.Hide();
                        this.cbxmangantu.Hide();
                    }
                }
            }
        }

        private void sACHGridControl_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.sACHBindingSource.MoveFirst();
            this.cbxmaisbn.Text = this.iSBNTextEdit.Text;
            this.cbxmangantu.Text = this.mANGANTUSpinEdit.Text;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.sACHBindingSource.MovePrevious();
            this.cbxmaisbn.Text = this.iSBNTextEdit.Text;
            this.cbxmangantu.Text = this.mANGANTUSpinEdit.Text;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.sACHBindingSource.MoveNext();
            this.cbxmaisbn.Text = this.iSBNTextEdit.Text;
            this.cbxmangantu.Text = this.mANGANTUSpinEdit.Text;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.sACHBindingSource.MoveLast();
            this.cbxmaisbn.Text = this.iSBNTextEdit.Text;
            this.cbxmangantu.Text = this.mANGANTUSpinEdit.Text;
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Bạn chắc chắn muốn xóa ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                Program.KetNoi();
                String strLenh = "dbo.sp_KiemTraMaSach_CTPM";
                Program.sqlcmd = Program.conn.CreateCommand();
                Program.sqlcmd.CommandType = CommandType.StoredProcedure;
                Program.sqlcmd.CommandText = strLenh;
                Program.sqlcmd.Parameters.Add("@MASACH", SqlDbType.NVarChar).Value = this.mASACHTextEdit.Text;
                Program.sqlcmd.Parameters.Add("@Ret", SqlDbType.VarChar).Direction = ParameterDirection.ReturnValue; // lệnh trả về giá trị của sp
                Program.sqlcmd.ExecuteNonQuery();
                Program.conn.Close();
                String Ret = Program.sqlcmd.Parameters["@Ret"].Value.ToString(); // sp sẽ trả về giá trị
                if (Ret == "1")
                {
                    MessageBox.Show("Mã sách đang có độc giả mượn ! ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    this.sACHBindingSource.RemoveCurrent(); // xóa dòng dữ liệu hiện tại đang chọn
                    this.sACHTableAdapter.Update(this.qL_THUVIENDataSet); // cập nhật dữ liệu vào database
                }
                
            }
        }

        private void btnsua_Click(object sender, EventArgs e)
        {

            this.XuLiButton(false);
            this.cbxmaisbn.Show();
            this.cbxmangantu.Show();
            this.mASACHTextEdit.Enabled = false;
            this.iSBNTextEdit.Focus(); // cho con trỏ chuột trỏ ngay ô textbox mã môn học
        }

        private void btnhuy_Click(object sender, EventArgs e)
        {
            this.sACHBindingSource.CancelEdit(); // hủy bỏ việc hiệu chỉnh trên 1 dòng dữ liệu
            this.XuLiButton(true);
            this.cbxmaisbn.Hide();
            this.cbxmangantu.Hide();
        }

        private void txbtimkiem_TextChanged(object sender, EventArgs e)
        {
            this.sACHBindingSource.Filter = "ISBN LIKE '%" + this.txbtimkiem.Text + "%'" + " OR MASACH LIKE '%" + this.txbtimkiem.Text + "%'";
        }

        private void cbxmaisbn_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.iSBNTextEdit.Text = this.cbxmaisbn.SelectedItem.ToString();
            this.cbxtensach.SelectedIndex = this.cbxmaisbn.SelectedIndex;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void cbxtensach_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.cbxmaisbn.SelectedIndex = this.cbxtensach.SelectedIndex;
            this.iSBNTextEdit.Text = this.cbxmaisbn.SelectedItem.ToString();
        }

        private void cbxmangantu_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.mANGANTUSpinEdit.Text = this.cbxmangantu.SelectedItem.ToString();
            this.cbxmotaNT.SelectedIndex = this.cbxmangantu.SelectedIndex;
        }

        private void cbxmotaNT_SelectedIndexChanged(object sender, EventArgs e)
        {
             this.cbxmangantu.SelectedIndex = this.cbxmotaNT.SelectedIndex;
            this.mANGANTUSpinEdit.Text = this.cbxmangantu.SelectedItem.ToString();
        }

        private void sACHGridControl_MouseCaptureChanged(object sender, EventArgs e)
        {
            this.cbxmaisbn.Text = this.iSBNTextEdit.Text;
            this.cbxmangantu.Text = this.mANGANTUSpinEdit.Text;
        }
    }
}
