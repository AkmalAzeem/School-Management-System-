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
    public partial class studentDetails : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\ASUS\documents\visual studio 2013\Projects\My School mangement sys\My School mangement sys\SchoolDB.mdf;Integrated Security=True");
        SqlCommand com;
        public studentDetails()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                string query2 = "Select* from Student where Admission_No = '" + textBox1.Text + "'";
                com = new SqlCommand(query2, con);
                SqlDataReader dr = com.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(dr);
                dataGridView2.DataSource = dt;
                textBox1.Clear();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);


            }
            con.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Students f7 = new Students();
            this.Hide();
            f7.Show();
        }
    }
}
