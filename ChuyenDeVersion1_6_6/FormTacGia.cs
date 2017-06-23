using System;
using System.Collections;
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
    public partial class FormTacGia : Form
    {
        public FormTacGia()
        {
            InitializeComponent();
        }

        int choose;
        public Stack st = new Stack();
        public class ObjectUndo
        {
            int type;
            String lenh;

            public ObjectUndo(int t, String l)
            {
                this.type = t;
                this.lenh = l;
            }

            public int getType()
            {
                return type;
            }
            public String getLenh()
            {
                return lenh;
            }
        }
        private void iSBNBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.iSBNBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.qL_THUVIENDataSet);

        }

        private void FormTacGia_Load(object sender, EventArgs e)
        {
            this.tACGIATableAdapter.Connection.ConnectionString = Program.connstr;
            // MessageBox.Show(Program.connstr);
            // TODO: This line of code loads data into the 'qL_THUVIENDataSet.TACGIA' table. You can move, or remove it, as needed.
            this.tACGIATableAdapter.FillByTinhTrang(this.qL_THUVIENDataSet.TACGIA);
            // TODO: This line of code loads data into the 'qL_THUVIENDataSet.ISBN' table. You can move, or remove it, as needed.
            this.iSBNTableAdapter.Fill(this.qL_THUVIENDataSet.ISBN);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }


        public void textBoxThongTin(bool choose)
        {
            this.hOTENTGTextEdit.Enabled = choose;
            this.dIACHITGTextEdit.Enabled = choose;
            this.dIENTHOAITGTextEdit.Enabled = choose;
        }

        public void buttonChucNang()
        {
            toolStripButtonThem.Enabled = true;
            toolStripButtonHieuChinh.Enabled = true;
            toolStripButtonUndo.Enabled = true;
            toolStripButtonXoa.Enabled = true;
            toolStripButtonThoat.Enabled = true;
            toolStripButtonHuy.Enabled = false;
            toolStripButtonLuu.Enabled = false;
            toolStripButtonReload.Enabled = true;
        }

        private void toolStripButtonThem_Click(object sender, EventArgs e)
        {
            this.choose = 0;
            textBoxThongTin(true);
            toolStripButtonThem.Enabled = false;
            toolStripButtonHieuChinh.Enabled = false;
            toolStripButtonXoa.Enabled = false;

            toolStripButtonHuy.Enabled = true;
            toolStripButtonUndo.Enabled = false;
            toolStripButtonThoat.Enabled = true;
            toolStripButtonLuu.Enabled = true;
            toolStripButtonReload.Enabled = false;

            this.tACGIABindingSource.AddNew();

            if (Program.conn.State == ConnectionState.Closed)
                Program.conn.Open();
            String strLenh = "dbo.SP_MaTacGia";
            Program.sqlcmd = Program.conn.CreateCommand();
            Program.sqlcmd.CommandType = CommandType.StoredProcedure;
            Program.sqlcmd.CommandText = strLenh;
            Program.sqlcmd.Parameters.Add("@Ret", SqlDbType.Int).Direction = ParameterDirection.ReturnValue;
            Program.sqlcmd.ExecuteNonQuery();
            Program.conn.Close();
            String Ret = Program.sqlcmd.Parameters["@Ret"].Value.ToString();
            this.mATACGIASpinEdit.Text = Ret;
        }


        public string hoTenTacGia;
        public string diaChiTacGia;
        public string soDienThoai;
        private void toolStripButtonHieuChinh_Click(object sender, EventArgs e)
        {
            choose = 1;
            hoTenTacGia = hOTENTGTextEdit.Text;
            diaChiTacGia = dIACHITGTextEdit.Text;
            soDienThoai = dIENTHOAITGTextEdit.Text;
            textBoxThongTin(true);
            toolStripButtonThem.Enabled = false;
            toolStripButtonHieuChinh.Enabled = false;
            toolStripButtonXoa.Enabled = false;
            toolStripButtonHuy.Enabled = true;

            toolStripButtonUndo.Enabled = false;
            toolStripButtonThoat.Enabled = true;
            toolStripButtonLuu.Enabled = true;
            toolStripButtonReload.Enabled = false;
        }

        private void toolStripButtonXoa_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Bạn có muốn xóa hay không ?", "THÔNG BÁO", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                if (Program.conn.State == ConnectionState.Closed)
                    Program.conn.Open();
                String strLenh = "dbo.SP_KiemTraMaTacGia";
                Program.sqlcmd = Program.conn.CreateCommand();
                Program.sqlcmd.CommandType = CommandType.StoredProcedure;
                Program.sqlcmd.CommandText = strLenh;
                Program.sqlcmd.Parameters.Add("@MATACGIA", SqlDbType.VarChar).Value = mATACGIASpinEdit.Text;
                Program.sqlcmd.Parameters.Add("@Ret", SqlDbType.Int).Direction = ParameterDirection.ReturnValue;
                Program.sqlcmd.ExecuteNonQuery();
                Program.conn.Close();
                String Ret = Program.sqlcmd.Parameters["@Ret"].Value.ToString();
                String maTacGia = "";
                if (Ret != "0")
                {
                    MessageBox.Show("Không thể xóa !", "THÔNG BÁO LỖI", MessageBoxButtons.OK);
                    return;
                }

                maTacGia = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "MATACGIA").ToString();
                int type = 2;
                String mATacGiaUndo = mATACGIASpinEdit.Text;
                String tenTacGia = hOTENTGTextEdit.Text;
                String diaChi = dIACHITGTextEdit.Text;
                String soDienThoai = dIENTHOAITGTextEdit.Text;

                String strlenUndo = "exec SP_UndoDeleteTacGia '" + mATacGiaUndo + "'";
                ObjectUndo ob = new ObjectUndo(type, strlenUndo);
                st.Push(ob);

                String strlen = "exec SP_UndoThemTacGia '" + maTacGia + "'";
                Program.ExecSqlNonQuery(strlen);
                this.tACGIATableAdapter.FillByTinhTrang(this.qL_THUVIENDataSet.TACGIA);
            }

            buttonChucNang();
            return;
        }

        private void toolStripButtonUndo_Click(object sender, EventArgs e)
        {
            try
            {
                ObjectUndo ob = (ObjectUndo)st.Pop();
                if (ob.getType() == 1)
                {
                    MessageBox.Show("Khôi phục sau khi thêm " + ob.getLenh());
                    Program.ExecSqlDataReader(ob.getLenh());
                    this.tACGIATableAdapter.FillByTinhTrang(this.qL_THUVIENDataSet.TACGIA);
                    return;
                }
                if (ob.getType() == 2)
                {
                    MessageBox.Show("Khôi phục sau khi xóa " + ob.getLenh());
                    Program.ExecSqlDataReader(ob.getLenh());
                    this.tACGIATableAdapter.FillByTinhTrang(this.qL_THUVIENDataSet.TACGIA);
                    return;
                }
                if (ob.getType() == 3)
                {
                    MessageBox.Show("Khôi phục sau khi sửa " + ob.getLenh());
                    Program.ExecSqlDataReader(ob.getLenh());
                    this.tACGIATableAdapter.FillByTinhTrang(this.qL_THUVIENDataSet.TACGIA);
                    return;
                }
            }
            catch (Exception r)
            {
                MessageBox.Show("Không có gì để Undo", "THÔNG BÁO", MessageBoxButtons.OK);
            }
        }

        private void toolStripButtonReload_Click(object sender, EventArgs e)
        {
            this.tACGIATableAdapter.FillByTinhTrang(this.qL_THUVIENDataSet.TACGIA);
        }

        private void toolStripButtonThoat_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < Program.xtratabcontrol.TabPages.Count; i++)
            {
                if (Program.xtratabcontrol.TabPages[i].Text == "Tác Giả")
                {
                    Program.xtratabcontrol.TabPages.RemoveAt(i);
                }
            }
        }

        private void toolStripButtonLuu_Click(object sender, EventArgs e)
        {
            if (choose == 0)
            {
                string hoTenTacGia = this.hOTENTGTextEdit.Text;
                string diaChiTacGia = this.dIACHITGTextEdit.Text;
                string soDienThoai = this.dIENTHOAITGTextEdit.Text;

                if (hoTenTacGia == "")
                {
                    MessageBox.Show("Vui lòng nhập họ tên tác giả ! ", "Thông báo", MessageBoxButtons.OK);
                    return;
                }

                if (diaChiTacGia == "")
                {
                    MessageBox.Show("Vui lòng nhập địa chỉ tác giả ! ", "Thông báo", MessageBoxButtons.OK);
                    return;
                }
                if (soDienThoai == "")
                {
                    MessageBox.Show("Vui lòng nhập số điện thoại !", "Thông báo", MessageBoxButtons.OK);
                    return;
                }

                String exec = "Exec SP_ThemTacGia '" + hoTenTacGia + "','" + diaChiTacGia + "','" + soDienThoai + "'";
                Program.ExecSqlDataReader(exec);
               
                MessageBox.Show("Thêm Tác giả Thành Công ! ", "THÔNG BÁO", MessageBoxButtons.OK);
             
                int type = 1; // XOA
                String strlenhUndo = "exec SP_UndoThemTacGia '" + mATACGIASpinEdit.Text + "'";
                ObjectUndo ob = new ObjectUndo(type, strlenhUndo);
                st.Push(ob);

                textBoxThongTin(false);
                buttonChucNang();
                this.tACGIATableAdapter.FillByTinhTrang(this.qL_THUVIENDataSet.TACGIA);
                return;
            }
            if (choose == 1)
            {
                    //public string hoTenTacGia;
                    //public string diaChiTacGia;
                    //public string soDienThoai;
                String maTacGia = mATACGIASpinEdit.Text;
                int type = 3;
                String strlenUndo = "exec SP_UndoChinhSuaTacGia '" + maTacGia + "','" + hoTenTacGia + "','" + diaChiTacGia + "','" + soDienThoai + "'";
                ObjectUndo ob = new ObjectUndo(type, strlenUndo);
                st.Push(ob);

                this.Validate();
                this.tACGIABindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(qL_THUVIENDataSet);
                MessageBox.Show("Chỉnh Sửa Tác Giả Thành công", "THÔNG BÁO", MessageBoxButtons.OK);
                textBoxThongTin(false);
                buttonChucNang();
                return;
            }
        }

        private void toolStripButtonHuy_Click(object sender, EventArgs e)
        {
            textBoxThongTin(false);
            buttonChucNang();
            this.tACGIABindingSource.CancelEdit();
        }
    }
}
