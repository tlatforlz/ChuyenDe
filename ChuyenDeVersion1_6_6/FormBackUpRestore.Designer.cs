namespace ChuyenDeVersion1_6_6
{
    partial class FormBackUpRestore
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
            this.qL_THUVIENDataSet = new ChuyenDeVersion1_6_6.QL_THUVIENDataSet();
            this.sP_ListBackupBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sP_ListBackupTableAdapter = new ChuyenDeVersion1_6_6.QL_THUVIENDataSetTableAdapters.SP_ListBackupTableAdapter();
            this.tableAdapterManager = new ChuyenDeVersion1_6_6.QL_THUVIENDataSetTableAdapters.TableAdapterManager();
            this.sP_ListBackupGridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumnBackupSetId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnPosition = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnBackUpStartDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.buttonBackUp = new System.Windows.Forms.Button();
            this.buttonRestore = new System.Windows.Forms.Button();
            this.buttonRefresh = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            ((System.ComponentModel.ISupportInitialize)(this.qL_THUVIENDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sP_ListBackupBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sP_ListBackupGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // qL_THUVIENDataSet
            // 
            this.qL_THUVIENDataSet.DataSetName = "QL_THUVIENDataSet";
            this.qL_THUVIENDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sP_ListBackupBindingSource
            // 
            this.sP_ListBackupBindingSource.DataMember = "SP_ListBackup";
            this.sP_ListBackupBindingSource.DataSource = this.qL_THUVIENDataSet;
            // 
            // sP_ListBackupTableAdapter
            // 
            this.sP_ListBackupTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Connection = null;
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
            this.tableAdapterManager.THELOAITableAdapter = null;
            this.tableAdapterManager.UpdateOrder = ChuyenDeVersion1_6_6.QL_THUVIENDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // sP_ListBackupGridControl
            // 
            this.sP_ListBackupGridControl.DataSource = this.sP_ListBackupBindingSource;
            this.sP_ListBackupGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sP_ListBackupGridControl.Location = new System.Drawing.Point(0, 0);
            this.sP_ListBackupGridControl.MainView = this.gridView1;
            this.sP_ListBackupGridControl.Name = "sP_ListBackupGridControl";
            this.sP_ListBackupGridControl.Size = new System.Drawing.Size(665, 377);
            this.sP_ListBackupGridControl.TabIndex = 1;
            this.sP_ListBackupGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumnBackupSetId,
            this.gridColumnPosition,
            this.gridColumnBackUpStartDate});
            this.gridView1.GridControl = this.sP_ListBackupGridControl;
            this.gridView1.Name = "gridView1";
            // 
            // gridColumnBackupSetId
            // 
            this.gridColumnBackupSetId.Caption = "Backup_Set_Id";
            this.gridColumnBackupSetId.DisplayFormat.FormatString = "d";
            this.gridColumnBackupSetId.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.gridColumnBackupSetId.FieldName = "backup_set_id";
            this.gridColumnBackupSetId.Name = "gridColumnBackupSetId";
            this.gridColumnBackupSetId.OptionsColumn.AllowEdit = false;
            this.gridColumnBackupSetId.Visible = true;
            this.gridColumnBackupSetId.VisibleIndex = 0;
            // 
            // gridColumnPosition
            // 
            this.gridColumnPosition.Caption = "Positon";
            this.gridColumnPosition.FieldName = "position";
            this.gridColumnPosition.Name = "gridColumnPosition";
            this.gridColumnPosition.OptionsColumn.AllowEdit = false;
            this.gridColumnPosition.Visible = true;
            this.gridColumnPosition.VisibleIndex = 1;
            // 
            // gridColumnBackUpStartDate
            // 
            this.gridColumnBackUpStartDate.Caption = "Start Date";
            this.gridColumnBackUpStartDate.DisplayFormat.FormatString = "G";
            this.gridColumnBackUpStartDate.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.gridColumnBackUpStartDate.FieldName = "backup_start_date";
            this.gridColumnBackUpStartDate.Name = "gridColumnBackUpStartDate";
            this.gridColumnBackUpStartDate.OptionsColumn.AllowEdit = false;
            this.gridColumnBackUpStartDate.Visible = true;
            this.gridColumnBackUpStartDate.VisibleIndex = 2;
            // 
            // buttonBackUp
            // 
            this.buttonBackUp.Location = new System.Drawing.Point(97, 56);
            this.buttonBackUp.Name = "buttonBackUp";
            this.buttonBackUp.Size = new System.Drawing.Size(75, 23);
            this.buttonBackUp.TabIndex = 2;
            this.buttonBackUp.Text = "BackUp";
            this.buttonBackUp.UseVisualStyleBackColor = true;
            this.buttonBackUp.Click += new System.EventHandler(this.buttonBackUp_Click);
            // 
            // buttonRestore
            // 
            this.buttonRestore.Location = new System.Drawing.Point(548, 56);
            this.buttonRestore.Name = "buttonRestore";
            this.buttonRestore.Size = new System.Drawing.Size(75, 23);
            this.buttonRestore.TabIndex = 3;
            this.buttonRestore.Text = "Restore";
            this.buttonRestore.UseVisualStyleBackColor = true;
            this.buttonRestore.Click += new System.EventHandler(this.buttonRestore_Click);
            // 
            // buttonRefresh
            // 
            this.buttonRefresh.Location = new System.Drawing.Point(328, 56);
            this.buttonRefresh.Name = "buttonRefresh";
            this.buttonRefresh.Size = new System.Drawing.Size(75, 23);
            this.buttonRefresh.TabIndex = 4;
            this.buttonRefresh.Text = "Reset";
            this.buttonRefresh.UseVisualStyleBackColor = true;
            this.buttonRefresh.Click += new System.EventHandler(this.buttonRefresh_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.sP_ListBackupGridControl);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(665, 377);
            this.panel1.TabIndex = 5;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.progressBar1);
            this.panel2.Controls.Add(this.buttonBackUp);
            this.panel2.Controls.Add(this.buttonRefresh);
            this.panel2.Controls.Add(this.buttonRestore);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 277);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(665, 100);
            this.panel2.TabIndex = 6;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(97, 14);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(526, 23);
            this.progressBar1.TabIndex = 5;
            // 
            // FormBackUpRestore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(665, 377);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormBackUpRestore";
            this.Text = "FormBackUpRestore";
            this.Load += new System.EventHandler(this.FormBackUpRestore_Load);
            ((System.ComponentModel.ISupportInitialize)(this.qL_THUVIENDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sP_ListBackupBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sP_ListBackupGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private QL_THUVIENDataSet qL_THUVIENDataSet;
        private System.Windows.Forms.BindingSource sP_ListBackupBindingSource;
        private QL_THUVIENDataSetTableAdapters.SP_ListBackupTableAdapter sP_ListBackupTableAdapter;
        private QL_THUVIENDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraGrid.GridControl sP_ListBackupGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnBackupSetId;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnPosition;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnBackUpStartDate;
        private System.Windows.Forms.Button buttonBackUp;
        private System.Windows.Forms.Button buttonRestore;
        private System.Windows.Forms.Button buttonRefresh;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ProgressBar progressBar1;
    }
}