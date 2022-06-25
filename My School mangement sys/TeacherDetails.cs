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

namespace My_School_mangement_sys
{
    public partial class TeacherDetails : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\ASUS\documents\visual studio 2013\Projects\My School mangement sys\My School mangement sys\SchoolDB.mdf;Integrated Security=True");
        SqlCommand com;
        public TeacherDetails()
        {
            InitializeComponent();
        }

        private void TeacherDetails_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                string query2 = "Select* from Teacher where ID = '" + textBox1.Text + "'";
                com = new SqlCommand(query2, con);
                SqlDataReader dr = com.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(dr);
                dataGridView1.DataSource = dt;
                textBox1.Clear();
               

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            
              
            }
            con.Close();
          
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Teacher f6 = new Teacher();
            this.Hide();
            f6.Show();
        }
    }
}
