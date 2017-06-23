namespace ChuyenDeVersion1_6_6
{
    partial class FormTheLoai
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
            System.Windows.Forms.Label mATLLabel;
            System.Windows.Forms.Label tHELOAILabel;
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.mATLDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tHELOAIDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.sửaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xóaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tHELOAIBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qL_THUVIENDataSet = new ChuyenDeVersion1_6_6.QL_THUVIENDataSet();
            this.tHELOAITableAdapter = new ChuyenDeVersion1_6_6.QL_THUVIENDataSetTableAdapters.THELOAITableAdapter();
            this.tableAdapterManager = new ChuyenDeVersion1_6_6.QL_THUVIENDataSetTableAdapters.TableAdapterManager();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnThem = new System.Windows.Forms.Button();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.btnHuy = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.txtMaTheLoai = new DevExpress.XtraEditors.TextEdit();
            this.txtTenTheLoai = new DevExpress.XtraEditors.TextEdit();
            this.label2 = new System.Windows.Forms.Label();
            mATLLabel = new System.Windows.Forms.Label();
            tHELOAILabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tHELOAIBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qL_THUVIENDataSet)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaTheLoai.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenTheLoai.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // mATLLabel
            // 
            mATLLabel.AutoSize = true;
            mATLLabel.Location = new System.Drawing.Point(14, 27);
            mATLLabel.Name = "mATLLabel";
            mATLLabel.Size = new System.Drawing.Size(70, 13);
            mATLLabel.TabIndex = 0;
            mATLLabel.Text = "Mã Thể Loại:";
            mATLLabel.Click += new System.EventHandler(this.mATLLabel_Click);
            // 
            // tHELOAILabel
            // 
            tHELOAILabel.AutoSize = true;
            tHELOAILabel.Location = new System.Drawing.Point(14, 53);
            tHELOAILabel.Name = "tHELOAILabel";
            tHELOAILabel.Size = new System.Drawing.Size(74, 13);
            tHELOAILabel.TabIndex = 2;
            tHELOAILabel.Text = "Tên Thể Loại:";
            tHELOAILabel.Click += new System.EventHandler(this.tHELOAILabel_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.mATLDataGridViewTextBoxColumn,
            this.tHELOAIDataGridViewTextBoxColumn});
            this.dataGridView1.ContextMenuStrip = this.contextMenuStrip1;
            this.dataGridView1.DataSource = this.tHELOAIBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(387, 26);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(293, 305);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // mATLDataGridViewTextBoxColumn
            // 
            this.mATLDataGridViewTextBoxColumn.DataPropertyName = "MATL";
            this.mATLDataGridViewTextBoxColumn.HeaderText = "MATL";
            this.mATLDataGridViewTextBoxColumn.Name = "mATLDataGridViewTextBoxColumn";
            this.mATLDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tHELOAIDataGridViewTextBoxColumn
            // 
            this.tHELOAIDataGridViewTextBoxColumn.DataPropertyName = "THELOAI";
            this.tHELOAIDataGridViewTextBoxColumn.HeaderText = "THELOAI";
            this.tHELOAIDataGridViewTextBoxColumn.Name = "tHELOAIDataGridViewTextBoxColumn";
            this.tHELOAIDataGridViewTextBoxColumn.ReadOnly = true;
            this.tHELOAIDataGridViewTextBoxColumn.Width = 150;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sửaToolStripMenuItem,
            this.xóaToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(95, 48);
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
            // tHELOAIBindingSource
            // 
            this.tHELOAIBindingSource.DataMember = "THELOAI";
            this.tHELOAIBindingSource.DataSource = this.qL_THUVIENDataSet;
            // 
            // qL_THUVIENDataSet
            // 
            this.qL_THUVIENDataSet.DataSetName = "QL_THUVIENDataSet";
            this.qL_THUVIENDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tHELOAITableAdapter
            // 
            this.tHELOAITableAdapter.ClearBeforeFill = true;
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
            this.tableAdapterManager.SACHTableAdapter = null;
            this.tableAdapterManager.TACGIA_SACHTableAdapter = null;
            this.tableAdapterManager.TACGIATableAdapter = null;
            this.tableAdapterManager.THELOAITableAdapter = this.tHELOAITableAdapter;
            this.tableAdapterManager.UpdateOrder = ChuyenDeVersion1_6_6.QL_THUVIENDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.btnThem);
            this.panel1.Controls.Add(this.txtTimKiem);
            this.panel1.Controls.Add(this.btnHuy);
            this.panel1.Controls.Add(this.btnLuu);
            this.panel1.Controls.Add(mATLLabel);
            this.panel1.Controls.Add(this.txtMaTheLoai);
            this.panel1.Controls.Add(tHELOAILabel);
            this.panel1.Controls.Add(this.txtTenTheLoai);
            this.panel1.Location = new System.Drawing.Point(12, 26);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(358, 305);
            this.panel1.TabIndex = 1;
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(17, 91);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 23);
            this.btnThem.TabIndex = 18;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Location = new System.Drawing.Point(101, 136);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(132, 20);
            this.txtTimKiem.TabIndex = 16;
            this.txtTimKiem.TextChanged += new System.EventHandler(this.txtTimKiem_TextChanged);
            // 
            // btnHuy
            // 
            this.btnHuy.Location = new System.Drawing.Point(221, 91);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(75, 23);
            this.btnHuy.TabIndex = 12;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.UseVisualStyleBackColor = true;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(114, 91);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(75, 23);
            this.btnLuu.TabIndex = 11;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // txtMaTheLoai
            // 
            this.txtMaTheLoai.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.tHELOAIBindingSource, "MATL", true));
            this.txtMaTheLoai.Location = new System.Drawing.Point(101, 24);
            this.txtMaTheLoai.Name = "txtMaTheLoai";
            this.txtMaTheLoai.Size = new System.Drawing.Size(132, 20);
            this.txtMaTheLoai.TabIndex = 1;
            this.txtMaTheLoai.EditValueChanged += new System.EventHandler(this.mATLTextEdit_EditValueChanged);
            // 
            // txtTenTheLoai
            // 
            this.txtTenTheLoai.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.tHELOAIBindingSource, "THELOAI", true));
            this.txtTenTheLoai.Location = new System.Drawing.Point(101, 50);
            this.txtTenTheLoai.Name = "txtTenTheLoai";
            this.txtTenTheLoai.Size = new System.Drawing.Size(132, 20);
            this.txtTenTheLoai.TabIndex = 3;
            this.txtTenTheLoai.EditValueChanged += new System.EventHandler(this.tHELOAITextEdit_EditValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 143);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 20;
            this.label2.Text = "Tìm Kiếm";
            // 
            // FormTheLoai
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(681, 331);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormTheLoai";
            this.Text = "FormTheLoai";
            this.Load += new System.EventHandler(this.FormTheLoai_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tHELOAIBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qL_THUVIENDataSet)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaTheLoai.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenTheLoai.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private QL_THUVIENDataSet qL_THUVIENDataSet;
        private System.Windows.Forms.BindingSource tHELOAIBindingSource;
        private QL_THUVIENDataSetTableAdapters.THELOAITableAdapter tHELOAITableAdapter;
        private QL_THUVIENDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridViewTextBoxColumn mATLDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tHELOAIDataGridViewTextBoxColumn;
        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraEditors.TextEdit txtMaTheLoai;
        private DevExpress.XtraEditors.TextEdit txtTenTheLoai;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem sửaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem xóaToolStripMenuItem;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Label label2;
    }
}