namespace ChuyenDeVersion1_6_6
{
    partial class FormTacGia
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
            System.Windows.Forms.Label mATACGIALabel;
            System.Windows.Forms.Label hOTENTGLabel;
            System.Windows.Forms.Label dIACHITGLabel;
            System.Windows.Forms.Label dIENTHOAITGLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormTacGia));
            this.qL_THUVIENDataSet = new ChuyenDeVersion1_6_6.QL_THUVIENDataSet();
            this.iSBNBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.iSBNTableAdapter = new ChuyenDeVersion1_6_6.QL_THUVIENDataSetTableAdapters.ISBNTableAdapter();
            this.tableAdapterManager = new ChuyenDeVersion1_6_6.QL_THUVIENDataSetTableAdapters.TableAdapterManager();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonThem = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonHieuChinh = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonXoa = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonLuu = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonHuy = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonUndo = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonReload = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonThoat = new System.Windows.Forms.ToolStripButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.hOTENTGTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.tACGIABindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dIACHITGTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.dIENTHOAITGTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.mATACGIASpinEdit = new DevExpress.XtraEditors.TextEdit();
            this.tACGIATableAdapter = new ChuyenDeVersion1_6_6.QL_THUVIENDataSetTableAdapters.TACGIATableAdapter();
            this.tACGIAGridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumnMaTacGia = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnHoTacGia = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnDiaChi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnSoDienThoai = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            mATACGIALabel = new System.Windows.Forms.Label();
            hOTENTGLabel = new System.Windows.Forms.Label();
            dIACHITGLabel = new System.Windows.Forms.Label();
            dIENTHOAITGLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.qL_THUVIENDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iSBNBindingSource)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hOTENTGTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tACGIABindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dIACHITGTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dIENTHOAITGTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mATACGIASpinEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tACGIAGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // mATACGIALabel
            // 
            mATACGIALabel.AutoSize = true;
            mATACGIALabel.Enabled = false;
            mATACGIALabel.Location = new System.Drawing.Point(117, 15);
            mATACGIALabel.Name = "mATACGIALabel";
            mATACGIALabel.Size = new System.Drawing.Size(65, 13);
            mATACGIALabel.TabIndex = 0;
            mATACGIALabel.Text = "MATACGIA:";
            // 
            // hOTENTGLabel
            // 
            hOTENTGLabel.AutoSize = true;
            hOTENTGLabel.Enabled = false;
            hOTENTGLabel.Location = new System.Drawing.Point(364, 15);
            hOTENTGLabel.Name = "hOTENTGLabel";
            hOTENTGLabel.Size = new System.Drawing.Size(63, 13);
            hOTENTGLabel.TabIndex = 2;
            hOTENTGLabel.Text = "HOTENTG:";
            // 
            // dIACHITGLabel
            // 
            dIACHITGLabel.AutoSize = true;
            dIACHITGLabel.Enabled = false;
            dIACHITGLabel.Location = new System.Drawing.Point(364, 60);
            dIACHITGLabel.Name = "dIACHITGLabel";
            dIACHITGLabel.Size = new System.Drawing.Size(61, 13);
            dIACHITGLabel.TabIndex = 4;
            dIACHITGLabel.Text = "DIACHITG:";
            // 
            // dIENTHOAITGLabel
            // 
            dIENTHOAITGLabel.AutoSize = true;
            dIENTHOAITGLabel.Enabled = false;
            dIENTHOAITGLabel.Location = new System.Drawing.Point(364, 99);
            dIENTHOAITGLabel.Name = "dIENTHOAITGLabel";
            dIENTHOAITGLabel.Size = new System.Drawing.Size(84, 13);
            dIENTHOAITGLabel.TabIndex = 6;
            dIENTHOAITGLabel.Text = "DIENTHOAITG:";
            // 
            // qL_THUVIENDataSet
            // 
            this.qL_THUVIENDataSet.DataSetName = "QL_THUVIENDataSet";
            this.qL_THUVIENDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // iSBNBindingSource
            // 
            this.iSBNBindingSource.DataMember = "ISBN";
            this.iSBNBindingSource.DataSource = this.qL_THUVIENDataSet;
            // 
            // iSBNTableAdapter
            // 
            this.iSBNTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CT_PHIEUMUONTableAdapter = null;
            this.tableAdapterManager.DOCGIATableAdapter = null;
            this.tableAdapterManager.ISBNTableAdapter = this.iSBNTableAdapter;
            this.tableAdapterManager.NGANTUTableAdapter = null;
            this.tableAdapterManager.NGONNGUTableAdapter = null;
            this.tableAdapterManager.NHANVIENTableAdapter = null;
            this.tableAdapterManager.PHIEUMUONTableAdapter = null;
            this.tableAdapterManager.SACH_DIENTUTableAdapter = null;
            this.tableAdapterManager.SACHTableAdapter = null;
            this.tableAdapterManager.TACGIA_SACHTableAdapter = null;
            this.tableAdapterManager.TACGIATableAdapter = null;
            this.tableAdapterManager.THELOAITableAdapter = null;
            this.tableAdapterManager.UpdateOrder = ChuyenDeVersion1_6_6.QL_THUVIENDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonThem,
            this.toolStripButtonHieuChinh,
            this.toolStripButtonXoa,
            this.toolStripButtonLuu,
            this.toolStripButtonHuy,
            this.toolStripButtonUndo,
            this.toolStripButtonReload,
            this.toolStripButtonThoat});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(898, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButtonThem
            // 
            this.toolStripButtonThem.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonThem.Image")));
            this.toolStripButtonThem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonThem.Name = "toolStripButtonThem";
            this.toolStripButtonThem.Size = new System.Drawing.Size(58, 22);
            this.toolStripButtonThem.Text = "Thêm";
            this.toolStripButtonThem.Click += new System.EventHandler(this.toolStripButtonThem_Click);
            // 
            // toolStripButtonHieuChinh
            // 
            this.toolStripButtonHieuChinh.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonHieuChinh.Image")));
            this.toolStripButtonHieuChinh.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonHieuChinh.Name = "toolStripButtonHieuChinh";
            this.toolStripButtonHieuChinh.Size = new System.Drawing.Size(87, 22);
            this.toolStripButtonHieuChinh.Text = "Hiệu Chỉnh";
            this.toolStripButtonHieuChinh.Click += new System.EventHandler(this.toolStripButtonHieuChinh_Click);
            // 
            // toolStripButtonXoa
            // 
            this.toolStripButtonXoa.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonXoa.Image")));
            this.toolStripButtonXoa.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonXoa.Name = "toolStripButtonXoa";
            this.toolStripButtonXoa.Size = new System.Drawing.Size(47, 22);
            this.toolStripButtonXoa.Text = "Xóa";
            this.toolStripButtonXoa.Click += new System.EventHandler(this.toolStripButtonXoa_Click);
            // 
            // toolStripButtonLuu
            // 
            this.toolStripButtonLuu.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonLuu.Image")));
            this.toolStripButtonLuu.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonLuu.Name = "toolStripButtonLuu";
            this.toolStripButtonLuu.Size = new System.Drawing.Size(47, 22);
            this.toolStripButtonLuu.Text = "Lưu";
            this.toolStripButtonLuu.Click += new System.EventHandler(this.toolStripButtonLuu_Click);
            // 
            // toolStripButtonHuy
            // 
            this.toolStripButtonHuy.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonHuy.Image")));
            this.toolStripButtonHuy.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonHuy.Name = "toolStripButtonHuy";
            this.toolStripButtonHuy.Size = new System.Drawing.Size(49, 22);
            this.toolStripButtonHuy.Text = "Hủy";
            this.toolStripButtonHuy.Click += new System.EventHandler(this.toolStripButtonHuy_Click);
            // 
            // toolStripButtonUndo
            // 
            this.toolStripButtonUndo.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonUndo.Image")));
            this.toolStripButtonUndo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonUndo.Name = "toolStripButtonUndo";
            this.toolStripButtonUndo.Size = new System.Drawing.Size(56, 22);
            this.toolStripButtonUndo.Text = "Undo";
            this.toolStripButtonUndo.Click += new System.EventHandler(this.toolStripButtonUndo_Click);
            // 
            // toolStripButtonReload
            // 
            this.toolStripButtonReload.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonReload.Image")));
            this.toolStripButtonReload.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonReload.Name = "toolStripButtonReload";
            this.toolStripButtonReload.Size = new System.Drawing.Size(63, 22);
            this.toolStripButtonReload.Text = "Reload";
            this.toolStripButtonReload.Click += new System.EventHandler(this.toolStripButtonReload_Click);
            // 
            // toolStripButtonThoat
            // 
            this.toolStripButtonThoat.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonThoat.Image")));
            this.toolStripButtonThoat.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonThoat.Name = "toolStripButtonThoat";
            this.toolStripButtonThoat.Size = new System.Drawing.Size(58, 22);
            this.toolStripButtonThoat.Text = "Thoát";
            this.toolStripButtonThoat.Click += new System.EventHandler(this.toolStripButtonThoat_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(mATACGIALabel);
            this.panel1.Controls.Add(hOTENTGLabel);
            this.panel1.Controls.Add(this.hOTENTGTextEdit);
            this.panel1.Controls.Add(dIACHITGLabel);
            this.panel1.Controls.Add(this.dIACHITGTextEdit);
            this.panel1.Controls.Add(dIENTHOAITGLabel);
            this.panel1.Controls.Add(this.dIENTHOAITGTextEdit);
            this.panel1.Controls.Add(this.mATACGIASpinEdit);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 311);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(898, 139);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // hOTENTGTextEdit
            // 
            this.hOTENTGTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.tACGIABindingSource, "HOTENTG", true));
            this.hOTENTGTextEdit.Enabled = false;
            this.hOTENTGTextEdit.Location = new System.Drawing.Point(500, 8);
            this.hOTENTGTextEdit.Name = "hOTENTGTextEdit";
            this.hOTENTGTextEdit.Size = new System.Drawing.Size(100, 20);
            this.hOTENTGTextEdit.TabIndex = 3;
            // 
            // tACGIABindingSource
            // 
            this.tACGIABindingSource.DataMember = "TACGIA";
            this.tACGIABindingSource.DataSource = this.qL_THUVIENDataSet;
            // 
            // dIACHITGTextEdit
            // 
            this.dIACHITGTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.tACGIABindingSource, "DIACHITG", true));
            this.dIACHITGTextEdit.Enabled = false;
            this.dIACHITGTextEdit.Location = new System.Drawing.Point(500, 53);
            this.dIACHITGTextEdit.Name = "dIACHITGTextEdit";
            this.dIACHITGTextEdit.Size = new System.Drawing.Size(100, 20);
            this.dIACHITGTextEdit.TabIndex = 5;
            // 
            // dIENTHOAITGTextEdit
            // 
            this.dIENTHOAITGTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.tACGIABindingSource, "DIENTHOAITG", true));
            this.dIENTHOAITGTextEdit.Enabled = false;
            this.dIENTHOAITGTextEdit.Location = new System.Drawing.Point(500, 92);
            this.dIENTHOAITGTextEdit.Name = "dIENTHOAITGTextEdit";
            this.dIENTHOAITGTextEdit.Size = new System.Drawing.Size(100, 20);
            this.dIENTHOAITGTextEdit.TabIndex = 7;
            // 
            // mATACGIASpinEdit
            // 
            this.mATACGIASpinEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.tACGIABindingSource, "MATACGIA", true));
            this.mATACGIASpinEdit.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.mATACGIASpinEdit.Enabled = false;
            this.mATACGIASpinEdit.Location = new System.Drawing.Point(198, 8);
            this.mATACGIASpinEdit.Name = "mATACGIASpinEdit";
            this.mATACGIASpinEdit.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.Buffered;
            this.mATACGIASpinEdit.Properties.Mask.EditMask = "d";
            this.mATACGIASpinEdit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.mATACGIASpinEdit.Size = new System.Drawing.Size(100, 20);
            this.mATACGIASpinEdit.TabIndex = 1;
            // 
            // tACGIATableAdapter
            // 
            this.tACGIATableAdapter.ClearBeforeFill = true;
            // 
            // tACGIAGridControl
            // 
            this.tACGIAGridControl.DataSource = this.tACGIABindingSource;
            this.tACGIAGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tACGIAGridControl.Location = new System.Drawing.Point(0, 0);
            this.tACGIAGridControl.MainView = this.gridView1;
            this.tACGIAGridControl.Name = "tACGIAGridControl";
            this.tACGIAGridControl.Size = new System.Drawing.Size(898, 286);
            this.tACGIAGridControl.TabIndex = 0;
            this.tACGIAGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumnMaTacGia,
            this.gridColumnHoTacGia,
            this.gridColumnDiaChi,
            this.gridColumnSoDienThoai});
            this.gridView1.GridControl = this.tACGIAGridControl;
            this.gridView1.Name = "gridView1";
            // 
            // gridColumnMaTacGia
            // 
            this.gridColumnMaTacGia.Caption = "Mã Tác Giả";
            this.gridColumnMaTacGia.FieldName = "MATACGIA";
            this.gridColumnMaTacGia.Name = "gridColumnMaTacGia";
            this.gridColumnMaTacGia.OptionsColumn.AllowEdit = false;
            this.gridColumnMaTacGia.OptionsColumn.ReadOnly = true;
            this.gridColumnMaTacGia.Visible = true;
            this.gridColumnMaTacGia.VisibleIndex = 0;
            // 
            // gridColumnHoTacGia
            // 
            this.gridColumnHoTacGia.Caption = "Họ Tên Tác Giả";
            this.gridColumnHoTacGia.FieldName = "HOTENTG";
            this.gridColumnHoTacGia.Name = "gridColumnHoTacGia";
            this.gridColumnHoTacGia.OptionsColumn.AllowEdit = false;
            this.gridColumnHoTacGia.OptionsColumn.ReadOnly = true;
            this.gridColumnHoTacGia.Visible = true;
            this.gridColumnHoTacGia.VisibleIndex = 1;
            // 
            // gridColumnDiaChi
            // 
            this.gridColumnDiaChi.Caption = "Địa Chỉ";
            this.gridColumnDiaChi.FieldName = "DIACHITG";
            this.gridColumnDiaChi.Name = "gridColumnDiaChi";
            this.gridColumnDiaChi.OptionsColumn.AllowEdit = false;
            this.gridColumnDiaChi.OptionsColumn.ReadOnly = true;
            this.gridColumnDiaChi.Visible = true;
            this.gridColumnDiaChi.VisibleIndex = 2;
            // 
            // gridColumnSoDienThoai
            // 
            this.gridColumnSoDienThoai.Caption = "Số Điện Thoại";
            this.gridColumnSoDienThoai.FieldName = "DIENTHOAITG";
            this.gridColumnSoDienThoai.Name = "gridColumnSoDienThoai";
            this.gridColumnSoDienThoai.OptionsColumn.AllowEdit = false;
            this.gridColumnSoDienThoai.OptionsColumn.ReadOnly = true;
            this.gridColumnSoDienThoai.Visible = true;
            this.gridColumnSoDienThoai.VisibleIndex = 3;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.tACGIAGridControl);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 25);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(898, 286);
            this.panel2.TabIndex = 2;
            // 
            // FormTacGia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(898, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.toolStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormTacGia";
            this.Text = "FormTacGia";
            this.Load += new System.EventHandler(this.FormTacGia_Load);
            ((System.ComponentModel.ISupportInitialize)(this.qL_THUVIENDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iSBNBindingSource)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hOTENTGTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tACGIABindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dIACHITGTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dIENTHOAITGTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mATACGIASpinEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tACGIAGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private QL_THUVIENDataSet qL_THUVIENDataSet;
        private System.Windows.Forms.BindingSource iSBNBindingSource;
        private QL_THUVIENDataSetTableAdapters.ISBNTableAdapter iSBNTableAdapter;
        private QL_THUVIENDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButtonThem;
        private System.Windows.Forms.ToolStripButton toolStripButtonHieuChinh;
        private System.Windows.Forms.ToolStripButton toolStripButtonXoa;
        private System.Windows.Forms.ToolStripButton toolStripButtonLuu;
        private System.Windows.Forms.ToolStripButton toolStripButtonUndo;
        private System.Windows.Forms.ToolStripButton toolStripButtonReload;
        private System.Windows.Forms.ToolStripButton toolStripButtonThoat;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.BindingSource tACGIABindingSource;
        private QL_THUVIENDataSetTableAdapters.TACGIATableAdapter tACGIATableAdapter;
        private DevExpress.XtraEditors.TextEdit hOTENTGTextEdit;
        private DevExpress.XtraEditors.TextEdit dIACHITGTextEdit;
        private DevExpress.XtraEditors.TextEdit dIENTHOAITGTextEdit;
        private DevExpress.XtraGrid.GridControl tACGIAGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnMaTacGia;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnHoTacGia;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnDiaChi;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnSoDienThoai;
        private System.Windows.Forms.Panel panel2;
        private DevExpress.XtraEditors.TextEdit mATACGIASpinEdit;
        private System.Windows.Forms.ToolStripButton toolStripButtonHuy;
    }
}