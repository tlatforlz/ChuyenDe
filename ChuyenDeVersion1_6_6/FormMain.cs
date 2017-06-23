using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraTab;

namespace ChuyenDeVersion1_6_6
{
    public partial class FormMain : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public FormMain()
        {
            InitializeComponent();
            Program.xtratabcontrol = this.xtraTabControl;
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            if(Program.username == "")
            {
                this.ribbonPageDanhMuc.Visible = false;
                this.ribbonPageGroupSaoLuu.Visible = false;
                this.ribbonPageGroupTaoTaiKhoan.Visible = false;
                barButtonItemDangXuat.Links[0].Visible = false;
            }
        }

        private void xtraTabControl_CloseButtonClick(object sender, EventArgs e)
        {
            try
            {
                XtraTabControl TabControl = (XtraTabControl)sender;
                int i = TabControl.SelectedTabPageIndex;
                TabControl.TabPages.RemoveAt(TabControl.SelectedTabPageIndex);
                TabControl.SelectedTabPageIndex = i - 1;
            }
            catch
            {

            }
        }

        static int KiemTraTonTai(XtraTabControl TabControlName, string TabName)
        {
            int temp = -1;
            for (int i = 0; i < TabControlName.TabPages.Count; i++)
            {
                if (TabControlName.TabPages[i].Text == TabName)
                {
                    temp = i;
                    break;
                }
            }
            return temp;
        }

        public void TabCreating(XtraTabControl TabControl, string Text, Form Form)
        {
            int Index = KiemTraTonTai(TabControl, Text);
            if (Index >= 0)
            {
                TabControl.SelectedTabPage = TabControl.TabPages[Index];
                TabControl.SelectedTabPage.Text = Text;
            }
            else
            {
                XtraTabPage TabPage = new XtraTabPage { Text = Text };
                TabControl.TabPages.Add(TabPage);
                TabControl.SelectedTabPage = TabPage;

                Form.TopLevel = false;
                Form.Parent = TabPage;
                //  Form.MdiParent = this;
                Form.Show();
                Form.Dock = DockStyle.Fill;
            }
        }

        public void HienThiMenu()
        {

            toolStripStatusLabelMaNV.Text = "Mã NV : " + Program.username;
            toolStripStatusLabelTen.Text = "Họ tên nhân viên : " + Program.mHoten;
            toolStripStatusLabelNhom.Text = "Nhóm : " + Program.mGroup;
            // Phân quyền

            if (Program.mGroup == "ADMIN")
            {
                // this.ribbonPageGroupNV.Visible = false;
                this.ribbonPageGroupTaoTaiKhoan.Visible = true;
                this.ribbonPageGroupSaoLuu.Visible = true;
            }
            if (Program.mGroup == "NHANVIEN")
            {   
               // this.ribbonPageGroupNV.Visible = true;
                this.ribbonPageGroupTaoTaiKhoan.Visible = true;
                this.ribbonPageGroupSaoLuu.Visible = false;
            }

            barButtonItemDangXuat.Links[0].Visible = true;
            barButtonItemDangNhap.Links[0].Visible = false; // Tắt button Đăng nhập trên form chính
            this.ribbonPageDanhMuc.Visible = true;
            for (int i = 0; i < Program.xtratabcontrol.TabPages.Count; i++)
            {
                if (Program.xtratabcontrol.TabPages[i].Text == "Đăng Nhập")
                {
                    Program.xtratabcontrol.TabPages.RemoveAt(i);
                }
            }
        }
        private void barButtonItemDangNhap_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FormLogin fm = new FormLogin();
            TabCreating(Program.xtratabcontrol, "Đăng Nhập", fm);
        }

        private void barButtonItemDocGia_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Program.DocGiaPM = 0;
            Form_DocGia_For_NhanVien fm = new Form_DocGia_For_NhanVien();
           
            TabCreating(Program.xtratabcontrol, "Độc Giả", fm);
        }

        private void barButtonItemSach_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FormSach fm = new FormSach();
            TabCreating(Program.xtratabcontrol, "Sách", fm);
        }

        private void barButtonItemTacGia_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FormTacGia fm = new FormTacGia();
            TabCreating(Program.xtratabcontrol, "Tác Giả", fm);
        }

        private void barButtonItemSaoLuu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FormBackUpRestore fm = new FormBackUpRestore();
            for (int i = 0; i < Program.xtratabcontrol.TabPages.Count; i++)
            {
                Program.xtratabcontrol.TabPages.RemoveAt(i);

            }
            TabCreating(Program.xtratabcontrol, "Phục Hồi", fm);

        }

        private void barButtonItemISBN_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FormISBN fm = new FormISBN();
            TabCreating(Program.xtratabcontrol, "ISBN", fm);
        }

        private void barButtonItemNhanVien_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FormNhanVien fm = new FormNhanVien();
            TabCreating(Program.xtratabcontrol, "ISBN", fm);
        }

        private void barButtonItemPhieuMuonTra_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Program.DocGiaPM = 1;
            Form_DocGia_For_NhanVien fm = new Form_DocGia_For_NhanVien();
            
            TabCreating(Program.xtratabcontrol, "Phiếu Mượn Trả", fm);
        }

        private void barButtonItemDangXuat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            toolStripStatusLabelMaNV.Text = "MANV";
            toolStripStatusLabelTen.Text = "HOTEN";
            toolStripStatusLabelNhom.Text = "NHOM";
            barButtonItemDangNhap.Links[0].Visible = true;

           
            xtraTabControl.TabPages.Clear();
            this.ribbonPageDanhMuc.Visible = false;
            this.ribbonPageGroupSaoLuu.Visible = false;
            this.ribbonPageGroupTaoTaiKhoan.Visible = false;
            barButtonItemDangNhap.Links[0].Visible = true;
            barButtonItemDangXuat.Links[0].Visible = false;
        }

        private void barButtonItemTaoTaiKhoan_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }
    }
}
