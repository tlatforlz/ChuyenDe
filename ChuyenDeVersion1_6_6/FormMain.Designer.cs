namespace ChuyenDeVersion1_6_6
{
    partial class FormMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.barButtonItemDangNhap = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItemDangXuat = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItemNhanVien = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItemDocGia = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItemTaoTaiKhoan = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItemISBN = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItemSach = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup5 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPage2 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup3 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup4 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.defaultLookAndFeel1 = new DevExpress.LookAndFeel.DefaultLookAndFeel(this.components);
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabelMaNV = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabelTen = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabelNhom = new System.Windows.Forms.ToolStripStatusLabel();
            this.xtraTabControl = new DevExpress.XtraTab.XtraTabControl();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.barButtonItemDangNhap,
            this.barButtonItemDangXuat,
            this.barButtonItemNhanVien,
            this.barButtonItemDocGia,
            this.barButtonItemTaoTaiKhoan,
            this.barButtonItemISBN,
            this.barButtonItemSach});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.MaxItemId = 8;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1,
            this.ribbonPage2});
            this.ribbonControl1.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.Office2010;
            this.ribbonControl1.Size = new System.Drawing.Size(758, 143);
            // 
            // barButtonItemDangNhap
            // 
            this.barButtonItemDangNhap.Caption = "ĐĂNG NHẬP";
            this.barButtonItemDangNhap.Id = 1;
            this.barButtonItemDangNhap.Name = "barButtonItemDangNhap";
            this.barButtonItemDangNhap.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItemDangNhap_ItemClick);
            // 
            // barButtonItemDangXuat
            // 
            this.barButtonItemDangXuat.Caption = "ĐĂNG XUẤT";
            this.barButtonItemDangXuat.Id = 2;
            this.barButtonItemDangXuat.Name = "barButtonItemDangXuat";
            // 
            // barButtonItemNhanVien
            // 
            this.barButtonItemNhanVien.Caption = "NHÂN VIÊN";
            this.barButtonItemNhanVien.Id = 3;
            this.barButtonItemNhanVien.Name = "barButtonItemNhanVien";
            // 
            // barButtonItemDocGia
            // 
            this.barButtonItemDocGia.Caption = "ĐỘC GIẢ";
            this.barButtonItemDocGia.Id = 4;
            this.barButtonItemDocGia.Name = "barButtonItemDocGia";
            // 
            // barButtonItemTaoTaiKhoan
            // 
            this.barButtonItemTaoTaiKhoan.Caption = "TẠO TÀI KHOẢN";
            this.barButtonItemTaoTaiKhoan.Id = 5;
            this.barButtonItemTaoTaiKhoan.Name = "barButtonItemTaoTaiKhoan";
            // 
            // barButtonItemISBN
            // 
            this.barButtonItemISBN.Caption = "ISBN";
            this.barButtonItemISBN.Id = 6;
            this.barButtonItemISBN.Name = "barButtonItemISBN";
            // 
            // barButtonItemSach
            // 
            this.barButtonItemSach.Caption = "SÁCH";
            this.barButtonItemSach.Id = 7;
            this.barButtonItemSach.Name = "barButtonItemSach";
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1,
            this.ribbonPageGroup5});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "HỆ THỐNG";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.barButtonItemDangNhap);
            this.ribbonPageGroup1.ItemLinks.Add(this.barButtonItemDangXuat);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "ribbonPageGroup1";
            // 
            // ribbonPageGroup5
            // 
            this.ribbonPageGroup5.ItemLinks.Add(this.barButtonItemTaoTaiKhoan);
            this.ribbonPageGroup5.Name = "ribbonPageGroup5";
            this.ribbonPageGroup5.Text = "ribbonPageGroup5";
            // 
            // ribbonPage2
            // 
            this.ribbonPage2.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup2,
            this.ribbonPageGroup3,
            this.ribbonPageGroup4,
            this.ribbonPageGroup});
            this.ribbonPage2.Name = "ribbonPage2";
            this.ribbonPage2.Text = "DANH MỤC";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.ItemLinks.Add(this.barButtonItemNhanVien);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            // 
            // ribbonPageGroup3
            // 
            this.ribbonPageGroup3.ItemLinks.Add(this.barButtonItemDocGia);
            this.ribbonPageGroup3.Name = "ribbonPageGroup3";
            // 
            // ribbonPageGroup4
            // 
            this.ribbonPageGroup4.ItemLinks.Add(this.barButtonItemISBN);
            this.ribbonPageGroup4.Name = "ribbonPageGroup4";
            // 
            // ribbonPageGroup
            // 
            this.ribbonPageGroup.ItemLinks.Add(this.barButtonItemSach);
            this.ribbonPageGroup.Name = "ribbonPageGroup";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabelMaNV,
            this.toolStripStatusLabelTen,
            this.toolStripStatusLabelNhom});
            this.statusStrip1.Location = new System.Drawing.Point(0, 338);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(758, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabelMaNV
            // 
            this.toolStripStatusLabelMaNV.Name = "toolStripStatusLabelMaNV";
            this.toolStripStatusLabelMaNV.Size = new System.Drawing.Size(42, 17);
            this.toolStripStatusLabelMaNV.Text = "MANV";
            // 
            // toolStripStatusLabelTen
            // 
            this.toolStripStatusLabelTen.Name = "toolStripStatusLabelTen";
            this.toolStripStatusLabelTen.Size = new System.Drawing.Size(29, 17);
            this.toolStripStatusLabelTen.Text = "TEN";
            // 
            // toolStripStatusLabelNhom
            // 
            this.toolStripStatusLabelNhom.Name = "toolStripStatusLabelNhom";
            this.toolStripStatusLabelNhom.Size = new System.Drawing.Size(45, 17);
            this.toolStripStatusLabelNhom.Text = "NHOM";
            // 
            // xtraTabControl
            // 
            this.xtraTabControl.ClosePageButtonShowMode = DevExpress.XtraTab.ClosePageButtonShowMode.InActiveTabPageAndTabControlHeader;
            this.xtraTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xtraTabControl.Location = new System.Drawing.Point(0, 143);
            this.xtraTabControl.Name = "xtraTabControl";
            this.xtraTabControl.Size = new System.Drawing.Size(758, 195);
            this.xtraTabControl.TabIndex = 3;
            this.xtraTabControl.CloseButtonClick += new System.EventHandler(this.xtraTabControl_CloseButtonClick);
            this.xtraTabControl.Click += new System.EventHandler(this.FormMain_Load);
            // 
            // FormMain
            // 
            this.AllowFormGlass = DevExpress.Utils.DefaultBoolean.False;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(758, 360);
            this.Controls.Add(this.xtraTabControl);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.ribbonControl1);
            this.Name = "FormMain";
            this.Ribbon = this.ribbonControl1;
            this.Text = "QUẢN LÝ THƯ VIỆN";
            this.Load += new System.EventHandler(this.FormMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.LookAndFeel.DefaultLookAndFeel defaultLookAndFeel1;
        private DevExpress.XtraBars.BarButtonItem barButtonItemDangNhap;
        private DevExpress.XtraBars.BarButtonItem barButtonItemDangXuat;
        private DevExpress.XtraBars.BarButtonItem barButtonItemNhanVien;
        private DevExpress.XtraBars.BarButtonItem barButtonItemDocGia;
        private DevExpress.XtraBars.BarButtonItem barButtonItemTaoTaiKhoan;
        private DevExpress.XtraBars.BarButtonItem barButtonItemISBN;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup5;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage2;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup3;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup4;
        private DevExpress.XtraBars.BarButtonItem barButtonItemSach;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelMaNV;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelTen;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelNhom;
        private DevExpress.XtraTab.XtraTabControl xtraTabControl;
    }
}

