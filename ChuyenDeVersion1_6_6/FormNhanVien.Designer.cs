namespace ChuyenDeVersion1_6_6
{
    partial class FormNhanVien
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
            System.Windows.Forms.Label eMAILLabel;
            System.Windows.Forms.Label dIENTHOAILabel;
            System.Windows.Forms.Label dIACHILabel;
            System.Windows.Forms.Label gIOITINHLabel;
            System.Windows.Forms.Label tENNVLabel;
            System.Windows.Forms.Label hONVLabel;
            System.Windows.Forms.Label mANVLabel;
            System.Windows.Forms.Label label2;
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.mANVDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hONVDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tENNVDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gIOITINHDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dIACHIDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dIENTHOAIDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eMAILDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tRANGTHAIDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.sửaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xóaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nHANVIENBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qL_THUVIENDataSet = new ChuyenDeVersion1_6_6.QL_THUVIENDataSet();
            this.label4 = new System.Windows.Forms.Label();
            this.btnThemTaiKhoan = new System.Windows.Forms.Button();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.btnThemNhanVien = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTaiKhoan = new System.Windows.Forms.TextBox();
            this.btnLuu = new System.Windows.Forms.Button();
            this.txtMatKhau = new System.Windows.Forms.TextBox();
            this.btnHuy = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnDoiMatKhau = new System.Windows.Forms.Button();
            this.eMAILTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.dIENTHOAITextEdit = new DevExpress.XtraEditors.TextEdit();
            this.dIACHITextEdit = new DevExpress.XtraEditors.TextEdit();
            this.gIOITINHCheckEdit = new DevExpress.XtraEditors.CheckEdit();
            this.btnLuu2 = new System.Windows.Forms.Button();
            this.btnHuy2 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtMaNhanVien = new DevExpress.XtraEditors.SpinEdit();
            this.hONVTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.tENNVTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.tRANGTHAISpinEdit = new DevExpress.XtraEditors.TextEdit();
            this.nHANVIENTableAdapter = new ChuyenDeVersion1_6_6.QL_THUVIENDataSetTableAdapters.NHANVIENTableAdapter();
            this.tableAdapterManager = new ChuyenDeVersion1_6_6.QL_THUVIENDataSetTableAdapters.TableAdapterManager();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.radioADMIN = new System.Windows.Forms.RadioButton();
            this.radioNHANVIEN = new System.Windows.Forms.RadioButton();
            eMAILLabel = new System.Windows.Forms.Label();
            dIENTHOAILabel = new System.Windows.Forms.Label();
            dIACHILabel = new System.Windows.Forms.Label();
            gIOITINHLabel = new System.Windows.Forms.Label();
            tENNVLabel = new System.Windows.Forms.Label();
            hONVLabel = new System.Windows.Forms.Label();
            mANVLabel = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nHANVIENBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qL_THUVIENDataSet)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.eMAILTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dIENTHOAITextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dIACHITextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gIOITINHCheckEdit.Properties)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaNhanVien.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hONVTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tENNVTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tRANGTHAISpinEdit.Properties)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // eMAILLabel
            // 
            eMAILLabel.AutoSize = true;
            eMAILLabel.Location = new System.Drawing.Point(296, 66);
            eMAILLabel.Name = "eMAILLabel";
            eMAILLabel.Size = new System.Drawing.Size(35, 13);
            eMAILLabel.TabIndex = 12;
            eMAILLabel.Text = "Email:";
            eMAILLabel.Click += new System.EventHandler(this.eMAILLabel_Click);
            // 
            // dIENTHOAILabel
            // 
            dIENTHOAILabel.AutoSize = true;
            dIENTHOAILabel.Location = new System.Drawing.Point(296, 40);
            dIENTHOAILabel.Name = "dIENTHOAILabel";
            dIENTHOAILabel.Size = new System.Drawing.Size(62, 13);
            dIENTHOAILabel.TabIndex = 10;
            dIENTHOAILabel.Text = "Điện Thoại:";
            dIENTHOAILabel.Click += new System.EventHandler(this.dIENTHOAILabel_Click);
            // 
            // dIACHILabel
            // 
            dIACHILabel.AutoSize = true;
            dIACHILabel.Location = new System.Drawing.Point(296, 14);
            dIACHILabel.Name = "dIACHILabel";
            dIACHILabel.Size = new System.Drawing.Size(44, 13);
            dIACHILabel.TabIndex = 8;
            dIACHILabel.Text = "Địa Chỉ:";
            dIACHILabel.Click += new System.EventHandler(this.dIACHILabel_Click);
            // 
            // gIOITINHLabel
            // 
            gIOITINHLabel.AutoSize = true;
            gIOITINHLabel.Location = new System.Drawing.Point(27, 96);
            gIOITINHLabel.Name = "gIOITINHLabel";
            gIOITINHLabel.Size = new System.Drawing.Size(54, 13);
            gIOITINHLabel.TabIndex = 6;
            gIOITINHLabel.Text = "Giới Tính:";
            gIOITINHLabel.Click += new System.EventHandler(this.gIOITINHLabel_Click);
            // 
            // tENNVLabel
            // 
            tENNVLabel.AutoSize = true;
            tENNVLabel.Location = new System.Drawing.Point(27, 70);
            tENNVLabel.Name = "tENNVLabel";
            tENNVLabel.Size = new System.Drawing.Size(29, 13);
            tENNVLabel.TabIndex = 4;
            tENNVLabel.Text = "Tên:";
            tENNVLabel.Click += new System.EventHandler(this.tENNVLabel_Click);
            // 
            // hONVLabel
            // 
            hONVLabel.AutoSize = true;
            hONVLabel.Location = new System.Drawing.Point(27, 44);
            hONVLabel.Name = "hONVLabel";
            hONVLabel.Size = new System.Drawing.Size(24, 13);
            hONVLabel.TabIndex = 2;
            hONVLabel.Text = "Họ:";
            hONVLabel.Click += new System.EventHandler(this.hONVLabel_Click);
            // 
            // mANVLabel
            // 
            mANVLabel.AutoSize = true;
            mANVLabel.Location = new System.Drawing.Point(27, 14);
            mANVLabel.Name = "mANVLabel";
            mANVLabel.Size = new System.Drawing.Size(41, 13);
            mANVLabel.TabIndex = 31;
            mANVLabel.Text = "MANV:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.mANVDataGridViewTextBoxColumn,
            this.hONVDataGridViewTextBoxColumn,
            this.tENNVDataGridViewTextBoxColumn,
            this.gIOITINHDataGridViewCheckBoxColumn,
            this.dIACHIDataGridViewTextBoxColumn,
            this.dIENTHOAIDataGridViewTextBoxColumn,
            this.eMAILDataGridViewTextBoxColumn,
            this.tRANGTHAIDataGridViewTextBoxColumn});
            this.dataGridView1.ContextMenuStrip = this.contextMenuStrip1;
            this.dataGridView1.DataSource = this.nHANVIENBindingSource;
            this.dataGridView1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dataGridView1.Location = new System.Drawing.Point(13, 24);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(845, 268);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dataGridView1_MouseClick);
            // 
            // mANVDataGridViewTextBoxColumn
            // 
            this.mANVDataGridViewTextBoxColumn.DataPropertyName = "MANV";
            this.mANVDataGridViewTextBoxColumn.HeaderText = "Mã Nhân Viên";
            this.mANVDataGridViewTextBoxColumn.Name = "mANVDataGridViewTextBoxColumn";
            this.mANVDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // hONVDataGridViewTextBoxColumn
            // 
            this.hONVDataGridViewTextBoxColumn.DataPropertyName = "HONV";
            this.hONVDataGridViewTextBoxColumn.HeaderText = "HỌ";
            this.hONVDataGridViewTextBoxColumn.Name = "hONVDataGridViewTextBoxColumn";
            this.hONVDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tENNVDataGridViewTextBoxColumn
            // 
            this.tENNVDataGridViewTextBoxColumn.DataPropertyName = "TENNV";
            this.tENNVDataGridViewTextBoxColumn.HeaderText = "Tên";
            this.tENNVDataGridViewTextBoxColumn.Name = "tENNVDataGridViewTextBoxColumn";
            this.tENNVDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // gIOITINHDataGridViewCheckBoxColumn
            // 
            this.gIOITINHDataGridViewCheckBoxColumn.DataPropertyName = "GIOITINH";
            this.gIOITINHDataGridViewCheckBoxColumn.HeaderText = "Giới Tính";
            this.gIOITINHDataGridViewCheckBoxColumn.Name = "gIOITINHDataGridViewCheckBoxColumn";
            this.gIOITINHDataGridViewCheckBoxColumn.ReadOnly = true;
            // 
            // dIACHIDataGridViewTextBoxColumn
            // 
            this.dIACHIDataGridViewTextBoxColumn.DataPropertyName = "DIACHI";
            this.dIACHIDataGridViewTextBoxColumn.HeaderText = "Địa Chỉ";
            this.dIACHIDataGridViewTextBoxColumn.Name = "dIACHIDataGridViewTextBoxColumn";
            this.dIACHIDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dIENTHOAIDataGridViewTextBoxColumn
            // 
            this.dIENTHOAIDataGridViewTextBoxColumn.DataPropertyName = "DIENTHOAI";
            this.dIENTHOAIDataGridViewTextBoxColumn.HeaderText = "Điện Thoại";
            this.dIENTHOAIDataGridViewTextBoxColumn.Name = "dIENTHOAIDataGridViewTextBoxColumn";
            this.dIENTHOAIDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // eMAILDataGridViewTextBoxColumn
            // 
            this.eMAILDataGridViewTextBoxColumn.DataPropertyName = "EMAIL";
            this.eMAILDataGridViewTextBoxColumn.HeaderText = "Email";
            this.eMAILDataGridViewTextBoxColumn.Name = "eMAILDataGridViewTextBoxColumn";
            this.eMAILDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tRANGTHAIDataGridViewTextBoxColumn
            // 
            this.tRANGTHAIDataGridViewTextBoxColumn.DataPropertyName = "TRANGTHAI";
            this.tRANGTHAIDataGridViewTextBoxColumn.HeaderText = "Trạng Thái";
            this.tRANGTHAIDataGridViewTextBoxColumn.Name = "tRANGTHAIDataGridViewTextBoxColumn";
            this.tRANGTHAIDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sửaToolStripMenuItem,
            this.xóaToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(95, 48);
            this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            // 
            // sửaToolStripMenuItem
            // 
            this.sửaToolStripMenuItem.Name = "sửaToolStripMenuItem";
            this.sửaToolStripMenuItem.Size = new System.Drawing.Size(94, 22);
            this.sửaToolStripMenuItem.Text = "Sửa";
            this.sửaToolStripMenuItem.Click += new System.EventHandler(this.sửaToolStripMenuItem_Click);
            // 
            // xóaToolStripMenuItem
            // 
            this.xóaToolStripMenuItem.Name = "xóaToolStripMenuItem";
            this.xóaToolStripMenuItem.Size = new System.Drawing.Size(94, 22);
            this.xóaToolStripMenuItem.Text = "Xóa";
            this.xóaToolStripMenuItem.Click += new System.EventHandler(this.xóaToolStripMenuItem_Click);
            // 
            // nHANVIENBindingSource
            // 
            this.nHANVIENBindingSource.DataMember = "NHANVIEN";
            this.nHANVIENBindingSource.DataSource = this.qL_THUVIENDataSet;
            this.nHANVIENBindingSource.CurrentChanged += new System.EventHandler(this.nHANVIENBindingSource_CurrentChanged);
            // 
            // qL_THUVIENDataSet
            // 
            this.qL_THUVIENDataSet.DataSetName = "QL_THUVIENDataSet";
            this.qL_THUVIENDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(668, 317);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 13);
            this.label4.TabIndex = 24;
            this.label4.Text = "Tìm Kiếm";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // btnThemTaiKhoan
            // 
            this.btnThemTaiKhoan.Location = new System.Drawing.Point(518, 351);
            this.btnThemTaiKhoan.Name = "btnThemTaiKhoan";
            this.btnThemTaiKhoan.Size = new System.Drawing.Size(125, 23);
            this.btnThemTaiKhoan.TabIndex = 26;
            this.btnThemTaiKhoan.Text = "Thêm Tài Khoản";
            this.btnThemTaiKhoan.UseVisualStyleBackColor = true;
            this.btnThemTaiKhoan.Click += new System.EventHandler(this.btnThemTaiKhoan_Click);
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Location = new System.Drawing.Point(731, 310);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(125, 20);
            this.txtTimKiem.TabIndex = 20;
            this.txtTimKiem.TextChanged += new System.EventHandler(this.txtTimKiem_TextChanged);
            // 
            // btnThemNhanVien
            // 
            this.btnThemNhanVien.Location = new System.Drawing.Point(518, 308);
            this.btnThemNhanVien.Name = "btnThemNhanVien";
            this.btnThemNhanVien.Size = new System.Drawing.Size(125, 23);
            this.btnThemNhanVien.TabIndex = 29;
            this.btnThemNhanVien.Text = "Thêm Nhân Viên";
            this.btnThemNhanVien.UseVisualStyleBackColor = true;
            this.btnThemNhanVien.Click += new System.EventHandler(this.btnThemNhanVien_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 21;
            this.label1.Text = "Tên Tài Khoản";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 22;
            this.label3.Text = "Mật Khẩu";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // txtTaiKhoan
            // 
            this.txtTaiKhoan.Location = new System.Drawing.Point(97, 7);
            this.txtTaiKhoan.Name = "txtTaiKhoan";
            this.txtTaiKhoan.Size = new System.Drawing.Size(169, 20);
            this.txtTaiKhoan.TabIndex = 23;
            this.txtTaiKhoan.TextChanged += new System.EventHandler(this.txtTaiKhoan_TextChanged);
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(314, 45);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(75, 23);
            this.btnLuu.TabIndex = 27;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // txtMatKhau
            // 
            this.txtMatKhau.Location = new System.Drawing.Point(97, 43);
            this.txtMatKhau.Name = "txtMatKhau";
            this.txtMatKhau.Size = new System.Drawing.Size(169, 20);
            this.txtMatKhau.TabIndex = 25;
            this.txtMatKhau.TextChanged += new System.EventHandler(this.txtMatKhau_TextChanged);
            // 
            // btnHuy
            // 
            this.btnHuy.Location = new System.Drawing.Point(314, 5);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(75, 23);
            this.btnHuy.TabIndex = 28;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.UseVisualStyleBackColor = true;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnHuy);
            this.panel1.Controls.Add(this.txtMatKhau);
            this.panel1.Controls.Add(this.btnLuu);
            this.panel1.Controls.Add(this.txtTaiKhoan);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(13, 308);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(465, 84);
            this.panel1.TabIndex = 21;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // btnDoiMatKhau
            // 
            this.btnDoiMatKhau.Location = new System.Drawing.Point(518, 396);
            this.btnDoiMatKhau.Name = "btnDoiMatKhau";
            this.btnDoiMatKhau.Size = new System.Drawing.Size(125, 23);
            this.btnDoiMatKhau.TabIndex = 30;
            this.btnDoiMatKhau.Text = "Đổi Mật Khẩu";
            this.btnDoiMatKhau.UseVisualStyleBackColor = true;
            this.btnDoiMatKhau.Click += new System.EventHandler(this.btnDoiMatKhau_Click);
            // 
            // eMAILTextEdit
            // 
            this.eMAILTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.nHANVIENBindingSource, "EMAIL", true));
            this.eMAILTextEdit.Location = new System.Drawing.Point(375, 63);
            this.eMAILTextEdit.Name = "eMAILTextEdit";
            this.eMAILTextEdit.Size = new System.Drawing.Size(155, 20);
            this.eMAILTextEdit.TabIndex = 13;
            this.eMAILTextEdit.EditValueChanged += new System.EventHandler(this.eMAILTextEdit_EditValueChanged);
            // 
            // dIENTHOAITextEdit
            // 
            this.dIENTHOAITextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.nHANVIENBindingSource, "DIENTHOAI", true));
            this.dIENTHOAITextEdit.Location = new System.Drawing.Point(375, 37);
            this.dIENTHOAITextEdit.Name = "dIENTHOAITextEdit";
            this.dIENTHOAITextEdit.Size = new System.Drawing.Size(155, 20);
            this.dIENTHOAITextEdit.TabIndex = 11;
            this.dIENTHOAITextEdit.EditValueChanged += new System.EventHandler(this.dIENTHOAITextEdit_EditValueChanged);
            this.dIENTHOAITextEdit.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.dIENTHOAITextEdit_KeyPress);
            // 
            // dIACHITextEdit
            // 
            this.dIACHITextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.nHANVIENBindingSource, "DIACHI", true));
            this.dIACHITextEdit.Location = new System.Drawing.Point(375, 11);
            this.dIACHITextEdit.Name = "dIACHITextEdit";
            this.dIACHITextEdit.Size = new System.Drawing.Size(155, 20);
            this.dIACHITextEdit.TabIndex = 9;
            this.dIACHITextEdit.EditValueChanged += new System.EventHandler(this.dIACHITextEdit_EditValueChanged);
            // 
            // gIOITINHCheckEdit
            // 
            this.gIOITINHCheckEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.nHANVIENBindingSource, "GIOITINH", true));
            this.gIOITINHCheckEdit.Location = new System.Drawing.Point(106, 93);
            this.gIOITINHCheckEdit.Name = "gIOITINHCheckEdit";
            this.gIOITINHCheckEdit.Properties.Caption = "Nam";
            this.gIOITINHCheckEdit.Size = new System.Drawing.Size(145, 19);
            this.gIOITINHCheckEdit.TabIndex = 7;
            this.gIOITINHCheckEdit.CheckedChanged += new System.EventHandler(this.gIOITINHCheckEdit_CheckedChanged);
            // 
            // btnLuu2
            // 
            this.btnLuu2.Location = new System.Drawing.Point(572, 9);
            this.btnLuu2.Name = "btnLuu2";
            this.btnLuu2.Size = new System.Drawing.Size(75, 23);
            this.btnLuu2.TabIndex = 30;
            this.btnLuu2.Text = "Lưu";
            this.btnLuu2.UseVisualStyleBackColor = true;
            this.btnLuu2.Click += new System.EventHandler(this.btnLuu2_Click);
            // 
            // btnHuy2
            // 
            this.btnHuy2.Location = new System.Drawing.Point(572, 66);
            this.btnHuy2.Name = "btnHuy2";
            this.btnHuy2.Size = new System.Drawing.Size(75, 23);
            this.btnHuy2.TabIndex = 31;
            this.btnHuy2.Text = "Hủy";
            this.btnHuy2.UseVisualStyleBackColor = true;
            this.btnHuy2.Click += new System.EventHandler(this.btnHuy2_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(label2);
            this.panel2.Controls.Add(this.groupBox1);
            this.panel2.Controls.Add(mANVLabel);
            this.panel2.Controls.Add(this.txtMaNhanVien);
            this.panel2.Controls.Add(this.btnHuy2);
            this.panel2.Controls.Add(this.hONVTextEdit);
            this.panel2.Controls.Add(this.btnLuu2);
            this.panel2.Controls.Add(this.tENNVTextEdit);
            this.panel2.Controls.Add(hONVLabel);
            this.panel2.Controls.Add(tENNVLabel);
            this.panel2.Controls.Add(gIOITINHLabel);
            this.panel2.Controls.Add(this.gIOITINHCheckEdit);
            this.panel2.Controls.Add(dIACHILabel);
            this.panel2.Controls.Add(this.dIACHITextEdit);
            this.panel2.Controls.Add(dIENTHOAILabel);
            this.panel2.Controls.Add(this.dIENTHOAITextEdit);
            this.panel2.Controls.Add(eMAILLabel);
            this.panel2.Controls.Add(this.eMAILTextEdit);
            this.panel2.Controls.Add(this.tRANGTHAISpinEdit);
            this.panel2.Location = new System.Drawing.Point(12, 159);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(667, 136);
            this.panel2.TabIndex = 22;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // txtMaNhanVien
            // 
            this.txtMaNhanVien.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.nHANVIENBindingSource, "MANV", true));
            this.txtMaNhanVien.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.txtMaNhanVien.Location = new System.Drawing.Point(106, 11);
            this.txtMaNhanVien.Name = "txtMaNhanVien";
            this.txtMaNhanVien.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtMaNhanVien.Size = new System.Drawing.Size(145, 20);
            this.txtMaNhanVien.TabIndex = 32;
            // 
            // hONVTextEdit
            // 
            this.hONVTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.nHANVIENBindingSource, "HONV", true));
            this.hONVTextEdit.Location = new System.Drawing.Point(106, 41);
            this.hONVTextEdit.Name = "hONVTextEdit";
            this.hONVTextEdit.Size = new System.Drawing.Size(145, 20);
            this.hONVTextEdit.TabIndex = 17;
            // 
            // tENNVTextEdit
            // 
            this.tENNVTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.nHANVIENBindingSource, "TENNV", true));
            this.tENNVTextEdit.Location = new System.Drawing.Point(106, 67);
            this.tENNVTextEdit.Name = "tENNVTextEdit";
            this.tENNVTextEdit.Size = new System.Drawing.Size(145, 20);
            this.tENNVTextEdit.TabIndex = 19;
            // 
            // tRANGTHAISpinEdit
            // 
            this.tRANGTHAISpinEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.nHANVIENBindingSource, "TRANGTHAI", true));
            this.tRANGTHAISpinEdit.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.tRANGTHAISpinEdit.Location = new System.Drawing.Point(375, 96);
            this.tRANGTHAISpinEdit.Name = "tRANGTHAISpinEdit";
            this.tRANGTHAISpinEdit.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.Buffered;
            this.tRANGTHAISpinEdit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.tRANGTHAISpinEdit.Size = new System.Drawing.Size(155, 20);
            this.tRANGTHAISpinEdit.TabIndex = 29;
            // 
            // nHANVIENTableAdapter
            // 
            this.nHANVIENTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CT_PHIEUMUONTableAdapter = null;
            this.tableAdapterManager.DOCGIATableAdapter = null;
            this.tableAdapterManager.ISBNTableAdapter = null;
            this.tableAdapterManager.NGANTUTableAdapter = null;
            this.tableAdapterManager.NGONNGUTableAdapter = null;
            this.tableAdapterManager.NHANVIENTableAdapter = this.nHANVIENTableAdapter;
            this.tableAdapterManager.PHIEUMUONTableAdapter = null;
            this.tableAdapterManager.SACH_DIENTUTableAdapter = null;
            this.tableAdapterManager.SACHTableAdapter = null;
            this.tableAdapterManager.TACGIA_SACHTableAdapter = null;
            this.tableAdapterManager.TACGIATableAdapter = null;
            this.tableAdapterManager.THELOAITableAdapter = null;
            this.tableAdapterManager.UpdateOrder = ChuyenDeVersion1_6_6.QL_THUVIENDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioNHANVIEN);
            this.groupBox1.Controls.Add(this.radioADMIN);
            this.groupBox1.Location = new System.Drawing.Point(375, 89);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(179, 44);
            this.groupBox1.TabIndex = 33;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(296, 103);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(38, 13);
            label2.TabIndex = 34;
            label2.Text = "Quyền";
            // 
            // radioADMIN
            // 
            this.radioADMIN.AutoSize = true;
            this.radioADMIN.Location = new System.Drawing.Point(6, 8);
            this.radioADMIN.Name = "radioADMIN";
            this.radioADMIN.Size = new System.Drawing.Size(60, 17);
            this.radioADMIN.TabIndex = 0;
            this.radioADMIN.TabStop = true;
            this.radioADMIN.Text = "ADMIN";
            this.radioADMIN.UseVisualStyleBackColor = true;
            // 
            // radioNHANVIEN
            // 
            this.radioNHANVIEN.AutoSize = true;
            this.radioNHANVIEN.Location = new System.Drawing.Point(95, 8);
            this.radioNHANVIEN.Name = "radioNHANVIEN";
            this.radioNHANVIEN.Size = new System.Drawing.Size(81, 17);
            this.radioNHANVIEN.TabIndex = 1;
            this.radioNHANVIEN.TabStop = true;
            this.radioNHANVIEN.Text = "NHANVIEN";
            this.radioNHANVIEN.UseVisualStyleBackColor = true;
            // 
            // FormNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(870, 451);
            this.Controls.Add(this.btnDoiMatKhau);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btnThemNhanVien);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnThemTaiKhoan);
            this.Controls.Add(this.txtTimKiem);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormNhanVien";
            this.Text = "FormNhanVien";
            this.Load += new System.EventHandler(this.FormNhanVien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nHANVIENBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qL_THUVIENDataSet)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.eMAILTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dIENTHOAITextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dIACHITextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gIOITINHCheckEdit.Properties)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaNhanVien.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hONVTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tENNVTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tRANGTHAISpinEdit.Properties)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private QL_THUVIENDataSet qL_THUVIENDataSet;
        private System.Windows.Forms.BindingSource nHANVIENBindingSource;
        private QL_THUVIENDataSetTableAdapters.NHANVIENTableAdapter nHANVIENTableAdapter;
        private QL_THUVIENDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridViewTextBoxColumn mANVDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hONVDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tENNVDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn gIOITINHDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dIACHIDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dIENTHOAIDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eMAILDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tRANGTHAIDataGridViewTextBoxColumn;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnThemTaiKhoan;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.Button btnThemNhanVien;
        private System.Windows.Forms.ToolStripMenuItem sửaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem xóaToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTaiKhoan;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.TextBox txtMatKhau;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnDoiMatKhau;
        private DevExpress.XtraEditors.TextEdit eMAILTextEdit;
        private DevExpress.XtraEditors.TextEdit dIENTHOAITextEdit;
        private DevExpress.XtraEditors.TextEdit dIACHITextEdit;
        private DevExpress.XtraEditors.CheckEdit gIOITINHCheckEdit;
        private System.Windows.Forms.Button btnLuu2;
        private System.Windows.Forms.Button btnHuy2;
        private System.Windows.Forms.Panel panel2;
        private DevExpress.XtraEditors.TextEdit hONVTextEdit;
        private DevExpress.XtraEditors.TextEdit tENNVTextEdit;
        private DevExpress.XtraEditors.TextEdit tRANGTHAISpinEdit;
        private DevExpress.XtraEditors.SpinEdit txtMaNhanVien;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioNHANVIEN;
        private System.Windows.Forms.RadioButton radioADMIN;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}