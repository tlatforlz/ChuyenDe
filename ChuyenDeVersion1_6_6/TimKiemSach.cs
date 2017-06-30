using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChuyenDeVersion1_6_6
{
    public partial class TimKiemSach : Form
    {
       
        public TimKiemSach()
        {
            InitializeComponent();
            this.cbbtimkiem.SelectedIndex = 0;
        }

        private void txbtimkiem_TextChanged(object sender, EventArgs e)
        {

            DataTable dt = new DataTable();
            Program.conn.Close();
            Program.KetNoi();
            String strLenh = "dbo.sp_TimKiemSach";
            Program.sqlcmd = Program.conn.CreateCommand();
            Program.sqlcmd.CommandType = CommandType.StoredProcedure;
            Program.sqlcmd.CommandText = strLenh;
            SqlDataReader myReader;

            if (this.cbbtimkiem.Text == "TÊN SÁCH")
            {
                Program.sqlcmd.Parameters.Add("@CHECK", SqlDbType.Int).Value = 1;
                Program.sqlcmd.Parameters.Add("@STR", SqlDbType.NVarChar).Value = this.txbtimkiem.Text;
             
                myReader = Program.sqlcmd.ExecuteReader();


                dt.Load(myReader);
                this.dataGridView1.DataSource = dt;
                myReader.Close();

            }
            else if (this.cbbtimkiem.Text == "TÊN TÁC GIẢ")
            {
                Program.sqlcmd.Parameters.Add("@CHECK", SqlDbType.Int).Value = 2;
                Program.sqlcmd.Parameters.Add("@STR", SqlDbType.NVarChar).Value = this.txbtimkiem.Text;

                myReader = Program.sqlcmd.ExecuteReader();


                dt.Load(myReader);
                this.dataGridView1.DataSource = dt;
                myReader.Close();
            }
            else if (this.cbbtimkiem.Text == "TÊN THỂ LOẠI")
            {
                Program.sqlcmd.Parameters.Add("@CHECK", SqlDbType.Int).Value = 3;
                Program.sqlcmd.Parameters.Add("@STR", SqlDbType.NVarChar).Value = this.txbtimkiem.Text;

                myReader = Program.sqlcmd.ExecuteReader();


                dt.Load(myReader);
                this.dataGridView1.DataSource = dt;
                myReader.Close();
            }
            else 
            {
                Program.sqlcmd.Parameters.Add("@CHECK", SqlDbType.Int).Value = 4;
                Program.sqlcmd.Parameters.Add("@STR", SqlDbType.NVarChar).Value = this.txbtimkiem.Text;

                myReader = Program.sqlcmd.ExecuteReader();

                dt.Load(myReader);
                this.dataGridView1.DataSource = dt;
                myReader.Close();
            }

            Program.conn.Close();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
    }
}
