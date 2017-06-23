using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ChuyenDeVersion1_6_6
{
    public partial class FormBackUpRestore : DevExpress.XtraEditors.XtraForm
    {
        public FormBackUpRestore()
        {
            InitializeComponent();
        }

        private void FormBackUpRestore_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qL_THUVIENDataSet.SP_ListBackup' table. You can move, or remove it, as needed.
            this.sP_ListBackupTableAdapter.Fill(this.qL_THUVIENDataSet.SP_ListBackup);

        }

        private void buttonBackUp_Click(object sender, EventArgs e)
        {
            String exec = "Exec SP_BackUp";
            Program.conn.Close();
            Program.ExecSqlDataReader(exec);
            progressBar1.Minimum = 0;
            progressBar1.Maximum = 200;
            progressBar1.Value = 1;
            progressBar1.Step = 3;
            for (int i = 0; i <= 200; i++)
            {
                progressBar1.PerformStep();
            }
            this.sP_ListBackupTableAdapter.Fill(this.qL_THUVIENDataSet.SP_ListBackup);
        }   

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            String exec = "Exec SP_Refresh";
            Program.conn.Close();
            Program.ExecSqlDataReader(exec);
            progressBar1.Minimum = 0;
            progressBar1.Maximum = 200;
            progressBar1.Value = 1;
            progressBar1.Step = 3;
            for (int i = 0; i <= 200; i++)
            {
                progressBar1.PerformStep();
            }
            this.sP_ListBackupTableAdapter.Fill(this.qL_THUVIENDataSet.SP_ListBackup);
        }

        private void buttonRestore_Click(object sender, EventArgs e)
        {
            
            String setId = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "position").ToString();
            
            String exec = "Exec SP_Restore '" + setId + "'";
            Program.conn.Close();
            
            Program.database = "master";
            Program.KetNoi();
            Program.ExecSqlDataReader(exec);
            Program.database = "QL_THUVIEN";
            Program.KetNoi();

            progressBar1.Minimum = 0;
            progressBar1.Maximum = 200;
            progressBar1.Value = 1;
            progressBar1.Step = 3;
            for (int i = 0; i <= 200; i++)
            {
                progressBar1.PerformStep();
            }
            this.sP_ListBackupTableAdapter.Fill(this.qL_THUVIENDataSet.SP_ListBackup);
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
