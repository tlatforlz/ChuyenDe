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

            //if (Program.mGroup == "USER")
            //{
            //    this.ribbonPageGroupNV.Visible = false;
            //    this.ribbonPageGroupTaoTaiKhoan.Visible = false;
            //}
            //else
            //{
            //    this.ribbonPageGroupNV.Visible = true;
            //    this.ribbonPageGroupTaoTaiKhoan.Visible = true;
            //}

            barButtonItemDangNhap.Links[0].Visible = false; // Tắt button Đăng nhập trên form chính
            //this.ribbonPageDanhMuc.Visible = true;
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
    }
}
