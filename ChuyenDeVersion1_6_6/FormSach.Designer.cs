namespace ChuyenDeVersion1_6_6
{
    partial class FormSach
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
            System.Windows.Forms.Label iSBNLabel;
            System.Windows.Forms.Label mASACHLabel;
            System.Windows.Forms.Label tINHTRANGLabel;
            System.Windows.Forms.Label mANGANTULabel;
            this.qL_THUVIENDataSet = new ChuyenDeVersion1_6_6.QL_THUVIENDataSet();
            this.sACHBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sACHTableAdapter = new ChuyenDeVersion1_6_6.QL_THUVIENDataSetTableAdapters.SACHTableAdapter();
            this.tableAdapterManager = new ChuyenDeVersion1_6_6.QL_THUVIENDataSetTableAdapters.TableAdapterManager();
            this.sACHGridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnthoat = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.btnxoa = new System.Windows.Forms.Button();
            this.btnhuy = new System.Windows.Forms.Button();
            this.btnsua = new System.Windows.Forms.Button();
            this.btnluu = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.btnthem = new System.Windows.Forms.Button();
            this.iSBNTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.mASACHTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.tINHTRANGCheckEdit = new DevExpress.XtraEditors.CheckEdit();
            this.cHOMUONCheckEdit = new DevExpress.XtraEditors.CheckEdit();
            this.mANGANTUSpinEdit = new DevExpress.XtraEditors.SpinEdit();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbxtensach = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbxmotaNT = new System.Windows.Forms.ComboBox();
            this.cbxmangantu = new System.Windows.Forms.ComboBox();
            this.cbxmaisbn = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txbtimkiem = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.docgiaTableAdapter1 = new ChuyenDeVersion1_6_6.QL_THUVIENDataSetTableAdapters.DOCGIATableAdapter();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            iSBNLabel = new System.Windows.Forms.Label();
            mASACHLabel = new System.Windows.Forms.Label();
            tINHTRANGLabel = new System.Windows.Forms.Label();
            mANGANTULabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.qL_THUVIENDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sACHBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sACHGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iSBNTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mASACHTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tINHTRANGCheckEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cHOMUONCheckEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mANGANTUSpinEdit.Properties)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // iSBNLabel
            // 
            iSBNLabel.AutoSize = true;
            iSBNLabel.Location = new System.Drawing.Point(11, 27);
            iSBNLabel.Name = "iSBNLabel";
            iSBNLabel.Size = new System.Drawing.Size(79, 15);
            iSBNLabel.TabIndex = 5;
            iSBNLabel.Text = "Mã đầu sách:";
            // 
            // mASACHLabel
            // 
            mASACHLabel.AutoSize = true;
            mASACHLabel.Location = new System.Drawing.Point(11, 84);
            mASACHLabel.Name = "mASACHLabel";
            mASACHLabel.Size = new System.Drawing.Size(56, 15);
            mASACHLabel.TabIndex = 7;
            mASACHLabel.Text = "Mã sách:";
            // 
            // tINHTRANGLabel
            // 
            tINHTRANGLabel.AutoSize = true;
            tINHTRANGLabel.Location = new System.Drawing.Point(11, 112);
            tINHTRANGLabel.Name = "tINHTRANGLabel";
            tINHTRANGLabel.Size = new System.Drawing.Size(66, 15);
            tINHTRANGLabel.TabIndex = 9;
            tINHTRANGLabel.Text = "Tình trạng:";
            // 
            // mANGANTULabel
            // 
            mANGANTULabel.AutoSize = true;
            mANGANTULabel.Location = new System.Drawing.Point(11, 56);
            mANGANTULabel.Name = "mANGANTULabel";
            mANGANTULabel.Size = new System.Drawing.Size(72, 15);
            mANGANTULabel.TabIndex = 13;
            mANGANTULabel.Text = "Mã ngăn tủ:";
            // 
            // qL_THUVIENDataSet
            // 
            this.qL_THUVIENDataSet.DataSetName = "QL_THUVIENDataSet";
            this.qL_THUVIENDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sACHBindingSource
            // 
            this.sACHBindingSource.DataMember = "SACH";
            this.sACHBindingSource.DataSource = this.qL_THUVIENDataSet;
            // 
            // sACHTableAdapter
            // 
            this.sACHTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CT_PHIEUMUONTableAdapter = null;
            this.tableAdapterManager.DOCGIATableAdapter = null;
            this.tableAdapterManager.ISBNTableAdapter = null;
            this.tableAdapterManager.NGANTUTableAdapter = null;
            this.tableAdapterManager.NGONNGUTableAdapter = null;
            this.tableAdapterManager.NHANVIENTableAdapter = null;
            this.tableAdapterManager.PHIEUMUONTableAdapter = null;
            this.tableAdapterManager.SACH_DIENTUTableAdapter = null;
            this.tableAdapterManager.SACHTableAdapter = this.sACHTableAdapter;
            this.tableAdapterManager.TACGIA_SACHTableAdapter = null;
            this.tableAdapterManager.TACGIATableAdapter = null;
            this.tableAdapterManager.THELOAITableAdapter = null;
            this.tableAdapterManager.UpdateOrder = ChuyenDeVersion1_6_6.QL_THUVIENDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // sACHGridControl
            // 
            this.sACHGridControl.DataSource = this.sACHBindingSource;
            this.sACHGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sACHGridControl.Location = new System.Drawing.Point(3, 18);
            this.sACHGridControl.MainView = this.gridView1;
            this.sACHGridControl.Name = "sACHGridControl";
            this.sACHGridControl.Size = new System.Drawing.Size(996, 260);
            this.sACHGridControl.TabIndex = 1;
            this.sACHGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.sACHGridControl.Click += new System.EventHandler(this.sACHGridControl_Click);
            this.sACHGridControl.MouseCaptureChanged += new System.EventHandler(this.sACHGridControl_MouseCaptureChanged);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3,
            this.gridColumn4,
            this.gridColumn5});
            this.gridView1.GridControl = this.sACHGridControl;
            this.gridView1.Name = "gridView1";
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "MÃ ĐẦU SÁCH";
            this.gridColumn1.FieldName = "ISBN";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "MÃ SÁCH";
            this.gridColumn2.FieldName = "MASACH";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 1;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "TÌNH TRẠNG";
            this.gridColumn3.FieldName = "TINHTRANG";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 2;
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "CHO MƯỢN";
            this.gridColumn4.FieldName = "CHOMUON";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 3;
            // 
            // gridColumn5
            // 
            this.gridColumn5.Caption = "MÃ NGĂN TỦ";
            this.gridColumn5.FieldName = "MANGANTU";
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 4;
            // 
            // btnthoat
            // 
            this.btnthoat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnthoat.Location = new System.Drawing.Point(890, 19);
            this.btnthoat.Name = "btnthoat";
            this.btnthoat.Size = new System.Drawing.Size(101, 26);
            this.btnthoat.TabIndex = 9;
            this.btnthoat.Text = "THOÁT";
            this.btnthoat.UseVisualStyleBackColor = true;
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(681, 18);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(101, 27);
            this.button9.TabIndex = 8;
            this.button9.Text = ">>";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(460, 18);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(101, 27);
            this.button8.TabIndex = 7;
            this.button8.Text = ">";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // btnxoa
            // 
            this.btnxoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnxoa.Location = new System.Drawing.Point(238, 66);
            this.btnxoa.Name = "btnxoa";
            this.btnxoa.Size = new System.Drawing.Size(101, 27);
            this.btnxoa.TabIndex = 1;
            this.btnxoa.Text = "XÓA";
            this.btnxoa.UseVisualStyleBackColor = true;
            this.btnxoa.Click += new System.EventHandler(this.btnxoa_Click);
            // 
            // btnhuy
            // 
            this.btnhuy.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnhuy.Location = new System.Drawing.Point(890, 67);
            this.btnhuy.Name = "btnhuy";
            this.btnhuy.Size = new System.Drawing.Size(101, 27);
            this.btnhuy.TabIndex = 4;
            this.btnhuy.Text = "HỦY";
            this.btnhuy.UseVisualStyleBackColor = true;
            this.btnhuy.Click += new System.EventHandler(this.btnhuy_Click);
            // 
            // btnsua
            // 
            this.btnsua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnsua.Location = new System.Drawing.Point(460, 66);
            this.btnsua.Name = "btnsua";
            this.btnsua.Size = new System.Drawing.Size(101, 27);
            this.btnsua.TabIndex = 2;
            this.btnsua.Text = "SỬA";
            this.btnsua.UseVisualStyleBackColor = true;
            this.btnsua.Click += new System.EventHandler(this.btnsua_Click);
            // 
            // btnluu
            // 
            this.btnluu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnluu.Location = new System.Drawing.Point(681, 66);
            this.btnluu.Name = "btnluu";
            this.btnluu.Size = new System.Drawing.Size(101, 27);
            this.btnluu.TabIndex = 3;
            this.btnluu.Text = "LƯU";
            this.btnluu.UseVisualStyleBackColor = true;
            this.btnluu.Click += new System.EventHandler(this.btnluu_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(238, 18);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(101, 27);
            this.button7.TabIndex = 6;
            this.button7.Text = "<";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(12, 19);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(101, 27);
            this.button6.TabIndex = 5;
            this.button6.Text = "<<";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // btnthem
            // 
            this.btnthem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnthem.Location = new System.Drawing.Point(12, 67);
            this.btnthem.Name = "btnthem";
            this.btnthem.Size = new System.Drawing.Size(101, 27);
            this.btnthem.TabIndex = 0;
            this.btnthem.Text = "THÊM";
            this.btnthem.UseVisualStyleBackColor = true;
            this.btnthem.Click += new System.EventHandler(this.btnthem_Click);
            // 
            // iSBNTextEdit
            // 
            this.iSBNTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.sACHBindingSource, "ISBN", true));
            this.iSBNTextEdit.Location = new System.Drawing.Point(91, 22);
            this.iSBNTextEdit.Name = "iSBNTextEdit";
            this.iSBNTextEdit.Size = new System.Drawing.Size(157, 20);
            this.iSBNTextEdit.TabIndex = 6;
            // 
            // mASACHTextEdit
            // 
            this.mASACHTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.sACHBindingSource, "MASACH", true));
            this.mASACHTextEdit.Location = new System.Drawing.Point(91, 81);
            this.mASACHTextEdit.Name = "mASACHTextEdit";
            this.mASACHTextEdit.Size = new System.Drawing.Size(157, 20);
            this.mASACHTextEdit.TabIndex = 8;
            // 
            // tINHTRANGCheckEdit
            // 
            this.tINHTRANGCheckEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.sACHBindingSource, "TINHTRANG", true));
            this.tINHTRANGCheckEdit.Location = new System.Drawing.Point(91, 109);
            this.tINHTRANGCheckEdit.Name = "tINHTRANGCheckEdit";
            this.tINHTRANGCheckEdit.Properties.Caption = "";
            this.tINHTRANGCheckEdit.Size = new System.Drawing.Size(100, 19);
            this.tINHTRANGCheckEdit.TabIndex = 10;
            // 
            // cHOMUONCheckEdit
            // 
            this.cHOMUONCheckEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.sACHBindingSource, "CHOMUON", true));
            this.cHOMUONCheckEdit.Location = new System.Drawing.Point(912, 25);
            this.cHOMUONCheckEdit.Name = "cHOMUONCheckEdit";
            this.cHOMUONCheckEdit.Properties.Caption = "";
            this.cHOMUONCheckEdit.Size = new System.Drawing.Size(40, 19);
            this.cHOMUONCheckEdit.TabIndex = 12;
            // 
            // mANGANTUSpinEdit
            // 
            this.mANGANTUSpinEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.sACHBindingSource, "MANGANTU", true));
            this.mANGANTUSpinEdit.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.mANGANTUSpinEdit.Location = new System.Drawing.Point(91, 54);
            this.mANGANTUSpinEdit.Name = "mANGANTUSpinEdit";
            this.mANGANTUSpinEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.mANGANTUSpinEdit.Size = new System.Drawing.Size(157, 20);
            this.mANGANTUSpinEdit.TabIndex = 14;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.cbxtensach);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cbxmotaNT);
            this.groupBox1.Controls.Add(this.cbxmangantu);
            this.groupBox1.Controls.Add(this.cbxmaisbn);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txbtimkiem);
            this.groupBox1.Controls.Add(this.iSBNTextEdit);
            this.groupBox1.Controls.Add(mANGANTULabel);
            this.groupBox1.Controls.Add(this.mANGANTUSpinEdit);
            this.groupBox1.Controls.Add(tINHTRANGLabel);
            this.groupBox1.Controls.Add(this.tINHTRANGCheckEdit);
            this.groupBox1.Controls.Add(iSBNLabel);
            this.groupBox1.Controls.Add(this.mASACHTextEdit);
            this.groupBox1.Controls.Add(this.cHOMUONCheckEdit);
            this.groupBox1.Controls.Add(mASACHLabel);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1002, 145);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin chi tiết sách";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(266, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 15);
            this.label3.TabIndex = 22;
            this.label3.Text = "Tên sách:";
            // 
            // cbxtensach
            // 
            this.cbxtensach.FormattingEnabled = true;
            this.cbxtensach.Location = new System.Drawing.Point(331, 19);
            this.cbxtensach.Name = "cbxtensach";
            this.cbxtensach.Size = new System.Drawing.Size(175, 23);
            this.cbxtensach.TabIndex = 21;
            this.cbxtensach.SelectedIndexChanged += new System.EventHandler(this.cbxtensach_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(266, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 15);
            this.label2.TabIndex = 20;
            this.label2.Text = "Mô tả:";
            // 
            // cbxmotaNT
            // 
            this.cbxmotaNT.FormattingEnabled = true;
            this.cbxmotaNT.Location = new System.Drawing.Point(331, 51);
            this.cbxmotaNT.Name = "cbxmotaNT";
            this.cbxmotaNT.Size = new System.Drawing.Size(175, 23);
            this.cbxmotaNT.TabIndex = 19;
            this.cbxmotaNT.SelectedIndexChanged += new System.EventHandler(this.cbxmotaNT_SelectedIndexChanged);
            // 
            // cbxmangantu
            // 
            this.cbxmangantu.FormattingEnabled = true;
            this.cbxmangantu.Location = new System.Drawing.Point(91, 52);
            this.cbxmangantu.Name = "cbxmangantu";
            this.cbxmangantu.Size = new System.Drawing.Size(157, 23);
            this.cbxmangantu.TabIndex = 18;
            this.cbxmangantu.SelectedIndexChanged += new System.EventHandler(this.cbxmangantu_SelectedIndexChanged);
            // 
            // cbxmaisbn
            // 
            this.cbxmaisbn.FormattingEnabled = true;
            this.cbxmaisbn.Location = new System.Drawing.Point(91, 21);
            this.cbxmaisbn.Name = "cbxmaisbn";
            this.cbxmaisbn.Size = new System.Drawing.Size(157, 23);
            this.cbxmaisbn.TabIndex = 17;
            this.cbxmaisbn.SelectedIndexChanged += new System.EventHandler(this.cbxmaisbn_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(701, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 15);
            this.label1.TabIndex = 16;
            this.label1.Text = "Tìm kiếm:";
            // 
            // txbtimkiem
            // 
            this.txbtimkiem.Location = new System.Drawing.Point(764, 21);
            this.txbtimkiem.Name = "txbtimkiem";
            this.txbtimkiem.Size = new System.Drawing.Size(223, 22);
            this.txbtimkiem.TabIndex = 15;
            this.txbtimkiem.TextChanged += new System.EventHandler(this.txbtimkiem_TextChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button6);
            this.groupBox2.Controls.Add(this.btnthoat);
            this.groupBox2.Controls.Add(this.btnluu);
            this.groupBox2.Controls.Add(this.btnsua);
            this.groupBox2.Controls.Add(this.button9);
            this.groupBox2.Controls.Add(this.btnthem);
            this.groupBox2.Controls.Add(this.button8);
            this.groupBox2.Controls.Add(this.btnhuy);
            this.groupBox2.Controls.Add(this.button7);
            this.groupBox2.Controls.Add(this.btnxoa);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox2.Location = new System.Drawing.Point(0, 145);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1002, 125);
            this.groupBox2.TabIndex = 16;
            this.groupBox2.TabStop = false;
            // 
            // docgiaTableAdapter1
            // 
            this.docgiaTableAdapter1.ClearBeforeFill = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.sACHGridControl);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox3.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(0, 270);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1002, 281);
            this.groupBox3.TabIndex = 17;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Danh sách sách";
            // 
            // FormSach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1002, 534);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormSach";
            this.Text = "FormSach";
            this.Load += new System.EventHandler(this.FormSach_Load);
            ((System.ComponentModel.ISupportInitialize)(this.qL_THUVIENDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sACHBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sACHGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iSBNTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mASACHTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tINHTRANGCheckEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cHOMUONCheckEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mANGANTUSpinEdit.Properties)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private QL_THUVIENDataSet qL_THUVIENDataSet;
        private System.Windows.Forms.BindingSource sACHBindingSource;
        private QL_THUVIENDataSetTableAdapters.SACHTableAdapter sACHTableAdapter;
        private QL_THUVIENDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraGrid.GridControl sACHGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.Button btnthoat;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button btnxoa;
        private System.Windows.Forms.Button btnhuy;
        private System.Windows.Forms.Button btnsua;
        private System.Windows.Forms.Button btnluu;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button btnthem;
        private DevExpress.XtraEditors.TextEdit iSBNTextEdit;
        private DevExpress.XtraEditors.TextEdit mASACHTextEdit;
        private DevExpress.XtraEditors.CheckEdit tINHTRANGCheckEdit;
        private DevExpress.XtraEditors.CheckEdit cHOMUONCheckEdit;
        private DevExpress.XtraEditors.SpinEdit mANGANTUSpinEdit;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private QL_THUVIENDataSetTableAdapters.DOCGIATableAdapter docgiaTableAdapter1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbtimkiem;
        private System.Windows.Forms.ComboBox cbxmaisbn;
        private System.Windows.Forms.ComboBox cbxmangantu;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbxmotaNT;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbxtensach;
    }
}