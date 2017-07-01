using DevExpress.XtraEditors;
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
    public partial class FormISBN : Form
    {
        private static bool KT_Them = false; // giả sử chưa chọn chức năng thêm

        public FormISBN()
        {
           
            InitializeComponent();
            this.iSBNTextEdit.Text = "";
            this.XuLiButton(true);
            this.XuLiTG_Sach(false);
            Lay_Ma_Ten_Tac_Gia();
            Lay_Ma_Ten_Ngon_Ngu();
            Lay_Ma_Ten_The_Loai();
            this.cbxmatheloai.Hide();
            this.cbxmangonngu.Hide();
        }

        private void iSBNBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.iSBNBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.qL_THUVIENDataSet);
           
        }

        // phương thức set trạng thái button
        private void XuLiButton(bool KT)
        {
            this.btnthem.Enabled = this.btnxoa.Enabled = this.btnsua.Enabled = this.txbtimkiem.Enabled = KT;
            this.iSBNTextEdit.Enabled = this.tENSACHTextEdit.Enabled = this.kHOSACHTextEdit.Enabled = this.txbnoidung.Enabled = this.hINHANHPATHTextEdit.Enabled = this.nGAYXUATBANDateEdit.Enabled  = 
            this.lANXUATBANSpinEdit.Enabled = this.sOTRANGSpinEdit.Enabled = this.gIASpinEdit.Enabled = this.nHAXBTextEdit.Enabled = 
            this.mANGONNGUSpinEdit.Enabled = this.mATLTextEdit.Enabled = this.btnluu.Enabled = this.btnhuy.Enabled = this.cbxtenngonngu.Enabled = this.cbxtentheloai.Enabled = !KT;
        }

        private void XuLiTG_Sach(bool KT)
        {
            this.cbxtentg.Enabled = KT;
            this.cbxmatg.Enabled = KT;
            this.buttonThemTG.Enabled = KT;
            this.buttonXoaTG.Enabled = KT;
        }

        private void Lay_Ma_Ten_Tac_Gia()
        {
            Program.KetNoi();
            String strLenh = "dbo.sp_LayMaTenTacGia";
            Program.sqlcmd = Program.conn.CreateCommand();
            Program.sqlcmd.CommandType = CommandType.StoredProcedure;
            Program.sqlcmd.CommandText = strLenh;
            SqlDataReader myReader;
            myReader = Program.ExecSqlDataReader(strLenh);

            while (myReader.Read() == true)
            {
                this.cbxmatg.Items.Add(myReader.GetInt32(0));
                this.cbxtentg.Items.Add(myReader.GetString(1));
            }
            myReader.Close();
            Program.conn.Close();
        }
        private void Lay_Ma_Ten_The_Loai()
        {
            Program.KetNoi();
            String strLenh = "dbo.sp_LayMaTenTheLoai";
            Program.sqlcmd = Program.conn.CreateCommand();
            Program.sqlcmd.CommandType = CommandType.StoredProcedure;
            Program.sqlcmd.CommandText = strLenh;
            SqlDataReader myReader;
            myReader = Program.ExecSqlDataReader(strLenh);

            while (myReader.Read() == true)
            {

                this.cbxmatheloai.Items.Add(myReader.GetString(0));
                this.cbxtentheloai.Items.Add(myReader.GetString(1));
            }
            myReader.Close();
            Program.conn.Close();
        }
        private void Lay_Ma_Ten_Ngon_Ngu()
        {
            Program.KetNoi();
            String strLenh = "dbo.sp_LayMaTenNgonNgu";
            Program.sqlcmd = Program.conn.CreateCommand();
            Program.sqlcmd.CommandType = CommandType.StoredProcedure;
            Program.sqlcmd.CommandText = strLenh;
            SqlDataReader myReader;
            myReader = Program.ExecSqlDataReader(strLenh);

            while (myReader.Read() == true)
            {
                this.cbxmangonngu.Items.Add(myReader.GetInt32(0));
                this.cbxtenngonngu.Items.Add(myReader.GetString(1));
            }
            myReader.Close();
            Program.conn.Close();
        }

        private void FormISBN_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qL_THUVIENDataSet.TACGIA_SACH' table. You can move, or remove it, as needed.
            this.tACGIA_SACHTableAdapter.Fill(this.qL_THUVIENDataSet.TACGIA_SACH, this.iSBNTextEdit.Text);
            // TODO: This line of code loads data into the 'qL_THUVIENDataSet.ISBN' table. You can move, or remove it, as needed.
            // this.iSBNTableAdapter.Fill(this.qL_THUVIENDataSet.ISBN);
            this.iSBNTableAdapter.FillByTrangThai(this.qL_THUVIENDataSet.ISBN);

            this.txbnoidung.Text = this.nOIDUNGTextEdit.Text;
            this.cbxmangonngu.Text = this.mANGONNGUSpinEdit.Text;
            this.cbxmatheloai.Text = this.mATLTextEdit.Text;
        }

        private void nOIDUNGLabel_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.iSBNBindingSource.MoveFirst();
            this.txbnoidung.Text = this.nOIDUNGTextEdit.Text;
            this.cbxmangonngu.Text = this.mANGONNGUSpinEdit.Text;
            this.cbxmatheloai.Text = this.mATLTextEdit.Text;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.iSBNBindingSource.MovePrevious();
            this.txbnoidung.Text = this.nOIDUNGTextEdit.Text;
            this.cbxmangonngu.Text = this.mANGONNGUSpinEdit.Text;
            this.cbxmatheloai.Text = this.mATLTextEdit.Text;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.iSBNBindingSource.MoveNext();
            this.txbnoidung.Text = this.nOIDUNGTextEdit.Text;
            this.cbxmangonngu.Text = this.mANGONNGUSpinEdit.Text;
            this.cbxmatheloai.Text = this.mATLTextEdit.Text;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.iSBNBindingSource.MoveLast();
            this.txbnoidung.Text = this.nOIDUNGTextEdit.Text;
            this.cbxmangonngu.Text = this.mANGONNGUSpinEdit.Text;
            this.cbxmatheloai.Text = this.mATLTextEdit.Text;
        }

        private void cbxisbn_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void iSBNGridControl_Click(object sender, EventArgs e)
        {
            
        }

        private void btnthem_Click(object sender, EventArgs e)
        {

            KT_Them = true;
            this.XuLiButton(false);
            this.XuLiTG_Sach(true);
            this.iSBNTextEdit.Focus();
   
            this.txbnoidung.Clear();
            this.cbxmatheloai.Show();
            this.cbxmangonngu.Show();
            
            this.iSBNBindingSource.AddNew();
           
            this.cbxmatheloai.SelectedIndex = 0;
            this.cbxmatg.SelectedIndex = 0;
            this.cbxmangonngu.SelectedIndex = 0;

        }

        private void cbxmatg_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.cbxtentg.SelectedIndex = this.cbxmatg.SelectedIndex;
        }

        private void cbxtentg_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.cbxmatg.SelectedIndex = this.cbxtentg.SelectedIndex;
        }

        private void btnluu_Click(object sender, EventArgs e)
        {
            Program.CheckEdit = 0;
            this.mANGONNGUSpinEdit.Text = this.cbxmangonngu.Text;
            this.mATLTextEdit.Text = this.cbxmatheloai.Text;
            

            string isbn = this.iSBNTextEdit.Text.ToString();
            string tensach = this.tENSACHTextEdit.Text;
            string khosach = this.kHOSACHTextEdit.Text;
            string noidung = this.nOIDUNGTextEdit.Text = this.txbnoidung.Text;
            string hinhanh = this.hINHANHPATHTextEdit.Text;
            string ngayxuatban = this.nGAYXUATBANDateEdit.Text;
            string lanxuatban = this.lANXUATBANSpinEdit.Text;
            string sotrang = this.sOTRANGSpinEdit.Text;
            string gia = this.gIASpinEdit.Text;
            string nhaxuatban = this.nHAXBTextEdit.Text;
            string mangonngu = this.mANGONNGUSpinEdit.Text;
            string matheloai = this.mATLTextEdit.Text;

            if (isbn.Length == 0 || tensach.Length == 0 || khosach.Length == 0 || noidung.Length == 0 || noidung.Length == 0 || hinhanh.Length == 0 || ngayxuatban.Length == 0 ||
                lanxuatban.Length == 0 || sotrang.Length == 0 || gia.Length == 0 || nhaxuatban.Length == 0 || mangonngu.Length == 0 || matheloai.Length == 0)
            {
                MessageBox.Show("Thong tin không được để trống !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (isbn.Length > 10)
                {
                    MessageBox.Show("Mã đầu sách chứa tối đa 10 kí tự !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (tensach.Length > 100)
                {
                    MessageBox.Show("Tên sách chứa tối đa 100 kí tự !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (khosach.Length > 10)
                {
                    MessageBox.Show("Khổ sách chứa tối đa 10 kí tự !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (noidung.Length > 300)
                {
                    MessageBox.Show("Nội dung chứa tối đa 300 kí tự !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (hinhanh.Length > 50)
                {
                    MessageBox.Show("Đường dẫn hình ảnh chứa tối đa 50 kí tự !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (nhaxuatban.Length > 100)
                {
                    MessageBox.Show("Nhà xuất bản chứa tối đa 100 kí tự !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    // người dùng chọn chức năng thêm
                    if (KT_Them == true)
                    {
                        try
                        {
                            Program.KetNoi();
                            String strLenh_1 = "dbo.sp_CapNhatTrangThai_ISBN";
                            Program.sqlcmd = Program.conn.CreateCommand();
                            Program.sqlcmd.CommandType = CommandType.StoredProcedure;
                            Program.sqlcmd.CommandText = strLenh_1;
                            Program.sqlcmd.Parameters.Add("@CHECK", SqlDbType.Int).Value = 1; // cập nhật trạng thái lại là 1 
                            Program.sqlcmd.Parameters.Add("@MAISBN", SqlDbType.NChar).Value = isbn;
                            Program.sqlcmd.Parameters.Add("@Ret", SqlDbType.VarChar).Direction = ParameterDirection.ReturnValue; // lệnh trả về giá trị của sp
                            Program.sqlcmd.ExecuteNonQuery();
                            Program.conn.Close();
                            String Ret = Program.sqlcmd.Parameters["@Ret"].Value.ToString(); // sp sẽ trả về giá trị 

                            // chưa tồn tại mã ISBN cũ ==> thêm mới
                            if (Ret == "0")
                            {
                                this.tRANGTHAISpinEdit.Value = 1; // mặc định thêm mới là trạng thái = 1
                                this.Validate();
                                this.iSBNBindingSource.EndEdit();// kết thúc quá trình hiệu chỉnh dữ liệu trên 1 dòng trong Dataset
                                this.iSBNTableAdapter.Update(this.qL_THUVIENDataSet); // cập nhật dữ liệu và database
                            }
                            else // đã tồn tại
                            {
                               
                                Program.KetNoi();
                                String strLenh_4 = "dbo.sp_XoaISBN_TonTai";
                                Program.sqlcmd = Program.conn.CreateCommand();
                                Program.sqlcmd.CommandType = CommandType.StoredProcedure;
                                Program.sqlcmd.CommandText = strLenh_4;
                                Program.sqlcmd.Parameters.Add("@MAISBN", SqlDbType.NChar).Value = isbn;
                                Program.sqlcmd.ExecuteNonQuery();
                                Program.conn.Close();

                                this.tRANGTHAISpinEdit.Value = 1; // mặc định thêm mới là trạng thái = 1
                                this.Validate();
                                this.iSBNBindingSource.EndEdit();// kết thúc quá trình hiệu chỉnh dữ liệu trên 1 dòng trong Dataset
                                this.iSBNTableAdapter.Update(this.qL_THUVIENDataSet); // cập nhật dữ liệu và database
                                this.iSBNTableAdapter.FillByTrangThai(this.qL_THUVIENDataSet.ISBN);
                            }

                            // thêm ISBN vào TACGIA_SACH
                            try
                            {
                                Program.KetNoi();
                                String strLenh_3= "dbo.sp_ThemISBN_TACGIA_SACH";
                                Program.sqlcmd = Program.conn.CreateCommand();
                                Program.sqlcmd.CommandType = CommandType.StoredProcedure;
                                Program.sqlcmd.CommandText = strLenh_3;
                                Program.sqlcmd.Parameters.Add("@MATG", SqlDbType.Int).Value = Int32.Parse( this.cbxmatg.Text); // cập nhật trạng thái lại là 1 
                                Program.sqlcmd.Parameters.Add("@MAISBN", SqlDbType.NChar).Value = isbn;
                                Program.sqlcmd.ExecuteNonQuery();
                                Program.conn.Close();
                            }
                            catch
                            {
                                MessageBox.Show("Thêm vào bảng TACGIA_SACH thất bại !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }

                        }
                        catch
                        {
                            this.iSBNBindingSource.RemoveCurrent(); // nếu thêm không thành công thì nó vẫn thêm vào dataset - xóa trên dataset 
                            MessageBox.Show("Mã ISBN " + isbn + " đã tồn tại !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            this.XuLiButton(true);
                        }
                    }
                    else
                    {
                        try
                        {
                            this.Validate();
                            this.iSBNBindingSource.EndEdit();// kết thúc quá trình hiệu chỉnh dữ liệu trên 1 dòng trong Dataset
                            this.iSBNTableAdapter.Update(this.qL_THUVIENDataSet); // cập nhật dữ liệu và database
                        }
                        catch
                        {
                            MessageBox.Show("Sửa không thành công !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        
                    }
                    this.XuLiButton(true);
                    this.cbxmatheloai.Hide();
                    this.cbxmangonngu.Hide();
                    this.cbxmatg.Enabled = false;
                    this.cbxtentg.Enabled = false;
                    KT_Them = false;
                }
            }
        }


        private void btnxoa_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Bạn chắc chắn muốn xóa ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {

                Program.KetNoi();
                String strLenh = "dbo.sp_KiemTraMaISBN_SACH";
                Program.sqlcmd = Program.conn.CreateCommand();
                Program.sqlcmd.CommandType = CommandType.StoredProcedure;
                Program.sqlcmd.CommandText = strLenh;
                Program.sqlcmd.Parameters.Add("@MAISBN", SqlDbType.NChar).Value = this.iSBNTextEdit.Text;
                Program.sqlcmd.Parameters.Add("@Ret", SqlDbType.VarChar).Direction = ParameterDirection.ReturnValue; // lệnh trả về giá trị của sp
                Program.sqlcmd.ExecuteNonQuery();
                Program.conn.Close();
                String Ret = Program.sqlcmd.Parameters["@Ret"].Value.ToString(); // sp sẽ trả về giá trị
                if (Ret == "1")
                {
                    MessageBox.Show("Khóa ngoại đang tồn tại mã đầu sách " + this.iSBNTextEdit.Text, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    try
                    {
                        string isbn = this.iSBNTextEdit.Text;
                        Program.KetNoi();
                        String strLenh_1 = "dbo.sp_CapNhatTrangThai_ISBN";
                        Program.sqlcmd = Program.conn.CreateCommand();
                        Program.sqlcmd.CommandType = CommandType.StoredProcedure;
                        Program.sqlcmd.CommandText = strLenh_1;
                        Program.sqlcmd.Parameters.Add("@CHECK", SqlDbType.Int).Value = 0;
                        Program.sqlcmd.Parameters.Add("@MAISBN", SqlDbType.NChar).Value = isbn;
                        Program.sqlcmd.Parameters.Add("@Ret", SqlDbType.VarChar).Direction = ParameterDirection.ReturnValue; // lệnh trả về giá trị của sp
                        Program.sqlcmd.ExecuteNonQuery();
                     
                        // String Ret = Program.sqlcmd.Parameters["@Ret"].Value.ToString(); // sp sẽ trả về giá trị 

                        this.iSBNTableAdapter.Update(this.qL_THUVIENDataSet);
                        this.iSBNTableAdapter.FillByTrangThai(this.qL_THUVIENDataSet.ISBN);

                        // xóa ISBN bên bảng TACGIA_SACH
                        String strLenh_2 = "dbo.sp_XoaISBN_TACGIA_SACH";
                        Program.sqlcmd = Program.conn.CreateCommand();
                        Program.sqlcmd.CommandType = CommandType.StoredProcedure;
                        Program.sqlcmd.CommandText = strLenh_2;
                        Program.sqlcmd.Parameters.Add("@MAISBN", SqlDbType.NChar).Value = isbn;
                        Program.sqlcmd.ExecuteNonQuery();
                        Program.conn.Close();
                    }
                    catch
                    {
                        MessageBox.Show("Xóa thông tin mã đầu sách thất bại !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
     
            }
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            this.XuLiButton(false);
            this.iSBNTextEdit.Enabled = false;
            this.cbxmatheloai.Show();
            this.cbxmangonngu.Show();
            XuLiTG_Sach(true);
        }

        private void btnhuy_Click(object sender, EventArgs e)
        {
            KT_Them = false;
            Program.CheckEdit = 0;  
            this.iSBNBindingSource.CancelEdit();
            
            this.XuLiButton(true);
            this.cbxmatg.Enabled = false;
            this.cbxtentg.Enabled = false;
            this.cbxmatheloai.Hide();
            this.cbxmangonngu.Hide();


            this.iSBNTableAdapter.FillByTrangThai(this.qL_THUVIENDataSet.ISBN);
            this.txbnoidung.Text = this.nOIDUNGTextEdit.Text;


            try
            {
                Program.conn.Close();
                Program.KetNoi();
                String strLenh_1 = "dbo.SP_HuyThemISBN";
                Program.sqlcmd = Program.conn.CreateCommand();
                Program.sqlcmd.CommandType = CommandType.StoredProcedure;
                Program.sqlcmd.CommandText = strLenh_1;
                Program.sqlcmd.Parameters.Add("@ISBN", SqlDbType.Int).Value = Int32.Parse(this.iSBNTextEdit.Text); // cập nhật trạng thái lại là 1 
                Program.sqlcmd.Parameters.Add("@Ret", SqlDbType.VarChar).Direction = ParameterDirection.ReturnValue; // lệnh trả về giá trị của sp
                Program.sqlcmd.ExecuteNonQuery();
                Program.conn.Close();
                this.tACGIA_SACHTableAdapter.Fill(this.qL_THUVIENDataSet.TACGIA_SACH, this.iSBNTextEdit.Text);
            }
            catch (Exception err)
            {

            }
        }

        private void txbnoidung_TextChanged(object sender, EventArgs e)
        {
            //this.nOIDUNGTextEdit.Text = this.txbnoidung.Text;
        }

        private void iSBNGridControl_MouseCaptureChanged(object sender, EventArgs e)
        {
            this.txbnoidung.Text = this.nOIDUNGTextEdit.Text;
            this.cbxmangonngu.Text = this.mANGONNGUSpinEdit.Text;
            this.cbxmatheloai.Text = this.mATLTextEdit.Text;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void cbxtenngonngu_SelectedIndexChanged(object sender, EventArgs e)
        {
           this.cbxmangonngu.SelectedIndex = this.cbxtenngonngu.SelectedIndex;
        }

        private void cbxmangonngu_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.cbxtenngonngu.SelectedIndex = this.cbxmangonngu.SelectedIndex;
            this.mANGONNGUSpinEdit.Text = this.cbxmangonngu.Text;
            
        }

        private void cbxmatheloai_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.cbxtentheloai.SelectedIndex = this.cbxmatheloai.SelectedIndex;
            this.mATLTextEdit.Text = this.cbxmatheloai.Text;
        }

        private void cbxtentheloai_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.cbxmatheloai.SelectedIndex = this.cbxtentheloai.SelectedIndex;
        }

        private void txbtimkiem_TextChanged(object sender, EventArgs e)
        {
            this.iSBNBindingSource.Filter = "ISBN LIKE '%" + this.txbtimkiem.Text + "%'" + " OR TENSACH LIKE '%" + this.txbtimkiem.Text + "%'" ;
        }

        private void iSBNGridControl_Click_1(object sender, EventArgs e)
        {
            this.tACGIA_SACHTableAdapter.Fill(this.qL_THUVIENDataSet.TACGIA_SACH, this.iSBNTextEdit.Text);
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void iSBNTextEdit_EditValueChanging(object sender, DevExpress.XtraEditors.Controls.ChangingEventArgs e)
        {

        }

        string newText = string.Empty;
       
        private void iSBNTextEdit_TextChanged(object sender, EventArgs e)
        {
            if(Program.CheckEdit == 1)
            {
                String oldText = newText;
                newText = iSBNTextEdit.Text;
                try
                {
                    Program.conn.Close();
                    Program.KetNoi();
                    String strLenh_1 = "dbo.SP_EditISBNChangeTacGia_Sach";
                    Program.sqlcmd = Program.conn.CreateCommand();
                    Program.sqlcmd.CommandType = CommandType.StoredProcedure;
                    Program.sqlcmd.CommandText = strLenh_1;
                    Program.sqlcmd.Parameters.Add("@ISBNOld", SqlDbType.Int).Value = Int32.Parse(oldText); // cập nhật trạng thái lại là 1 
                    Program.sqlcmd.Parameters.Add("@ISBNNew", SqlDbType.Int).Value = Int32.Parse(newText);
                    Program.sqlcmd.Parameters.Add("@Ret", SqlDbType.VarChar).Direction = ParameterDirection.ReturnValue; // lệnh trả về giá trị của sp
                    Program.sqlcmd.ExecuteNonQuery();
                    Program.conn.Close();
                    this.tACGIA_SACHTableAdapter.Fill(this.qL_THUVIENDataSet.TACGIA_SACH, newText);
                }
                catch (Exception er)
                {

                }
            }else
            {
                try
                {
                    this.tACGIA_SACHTableAdapter.Fill(this.qL_THUVIENDataSet.TACGIA_SACH, newText);
                }catch (Exception er)
                {

                }
            }
        }

        private void buttonThemTG_Click(object sender, EventArgs e)
        {
            //sp_KiemTraMaISBN_SACH
            //SP_KiemTraISBN

            String ISBN = this.iSBNTextEdit.Text;


            String MaTacGia = this.cbxmatg.Text;
           
            //"SP_ThemTacGia_Sach"
            Program.conn.Close();
            Program.KetNoi();
            String strLenh_1 = "dbo.SP_ThemTacGia_Sach";
            Program.sqlcmd = Program.conn.CreateCommand();
            Program.sqlcmd.CommandType = CommandType.StoredProcedure;
            Program.sqlcmd.CommandText = strLenh_1;
            Program.sqlcmd.Parameters.Add("@ISBN", SqlDbType.Int).Value = Int32.Parse(ISBN); // cập nhật trạng thái lại là 1 
            Program.sqlcmd.Parameters.Add("@MaTacGia", SqlDbType.Int).Value = Int32.Parse(MaTacGia);
            Program.sqlcmd.Parameters.Add("@Ret", SqlDbType.VarChar).Direction = ParameterDirection.ReturnValue; // lệnh trả về giá trị của sp
            Program.sqlcmd.ExecuteNonQuery();
            Program.conn.Close();
            String Ret = Program.sqlcmd.Parameters["@Ret"].Value.ToString();
            if(Ret == "0")
            {
                MessageBox.Show("Tác gỉa đã tồn tại trong sách","Thông báo", MessageBoxButtons.OK);
            }
            this.tACGIA_SACHTableAdapter.Fill(this.qL_THUVIENDataSet.TACGIA_SACH, this.iSBNTextEdit.Text);
        }

        private void buttonXoaTG_Click(object sender, EventArgs e)
        {
            String ISBN = gridView2.GetRowCellValue(gridView2.FocusedRowHandle, "ISBN").ToString();
            String MaTacGia = gridView2.GetRowCellValue(gridView2.FocusedRowHandle, "MATACGIA").ToString();
            //SP_XoaTacGiaSach
            Program.conn.Close();
            Program.KetNoi();
            String strLenh_1 = "dbo.SP_XoaTacGiaSach";
            Program.sqlcmd = Program.conn.CreateCommand();
            Program.sqlcmd.CommandType = CommandType.StoredProcedure;
            Program.sqlcmd.CommandText = strLenh_1;
            Program.sqlcmd.Parameters.Add("@ISBN", SqlDbType.Int).Value = Int32.Parse(ISBN); // cập nhật trạng thái lại là 1 
            Program.sqlcmd.Parameters.Add("@MaTacGia", SqlDbType.Int).Value = Int32.Parse(MaTacGia);
            Program.sqlcmd.Parameters.Add("@Ret", SqlDbType.VarChar).Direction = ParameterDirection.ReturnValue; // lệnh trả về giá trị của sp
            Program.sqlcmd.ExecuteNonQuery();
            Program.conn.Close();
            this.tACGIA_SACHTableAdapter.Fill(this.qL_THUVIENDataSet.TACGIA_SACH, this.iSBNTextEdit.Text);
        }

        private void iSBNTextEdit_EditValueChanged(object sender, EventArgs e)
        {
          //  MessageBox.Show("FUCK");
           
        }

        private void iSBNTextEdit_KeyPress(object sender, KeyPressEventArgs e)
        {
            
            Program.CheckEdit = 1;
        }
    }
}
