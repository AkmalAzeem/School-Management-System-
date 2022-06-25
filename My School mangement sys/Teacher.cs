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
    public partial class Teacher : Form
    {
        SqlConnection con = new SqlConnection (@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\ASUS\documents\visual studio 2013\Projects\My School mangement sys\My School mangement sys\SchoolDB.mdf;Integrated Security=True");
        SqlCommand com;
        public Teacher()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            try
            {
                string Gender;
                if (radioButton1.Checked)
                {
                    Gender = "Male";
                }
                else
                {
                    Gender = "Female";
                }

                con.Open();
                string query = "insert into Teacher (ID, Name, Surname, Date_Of_Birth, NIC_No, Gender, Mobile_No, Address, Subject, Qualification, Salary) values('" + textBox1.Text + "', '" + textBox2.Text + "', '" + textBox3.Text + "', '" + textBox4.Text + "', '" + textBox5.Text + "', '" + Gender + "', '" + textBox6.Text + "', '" + textBox7.Text + "', '" + textBox8.Text + "', '" + textBox9.Text + "', '" + textBox10.Text + "')";
                com = new SqlCommand(query, con);
                com.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Data added");
                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
                textBox4.Clear();
                textBox5.Clear();
                radioButton1.Checked = false;
                radioButton2.Checked = false;
               
                textBox6.Clear();
                textBox7.Clear();
                textBox8.Clear();
                textBox9.Clear();
                textBox10.Clear();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
            con.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                string query = "Select * from Teacher where ID = '"+ textBox1.Text +"'";
                com = new SqlCommand(query, con);
                SqlDataReader dr = com.ExecuteReader();
                while (dr.Read())
                {
                    textBox2.Text = dr[1].ToString();
                    textBox3.Text = dr[2].ToString();
                    textBox4.Text = dr[3].ToString();
                    textBox5.Text = dr[4].ToString();
                    string Gender = dr[5].ToString();
                    if (Gender == "Male")
                    {
                        radioButton1.Checked = true;
                    }
                    else
                    {
                        radioButton2.Checked = true;
                    }

                    textBox6.Text = dr[6].ToString();
                    textBox7.Text = dr[7].ToString();
                    textBox8.Text = dr[8].ToString();
                    textBox9.Text = dr[9].ToString();
                    textBox10.Text = dr[10].ToString();
               




                }
                

               
               
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
       }
            con.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                string query = "Delete from Teacher where ID = '" + textBox1.Text + "'";
                SqlCommand com = new SqlCommand(query, con);
                com.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Deleted Successfully");
                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
                textBox4.Clear();
                textBox5.Clear();
                radioButton1.Checked = false;
                radioButton2.Checked = false;
                textBox6.Clear();
                textBox7.Clear();
                textBox8.Clear();
                textBox9.Clear();
                textBox10.Clear();
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);  
               
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {

            try
            {
                string Gender;
                if (radioButton1.Checked)
                {
                    Gender = "Male";
                }
                else
                {
                    Gender = "Female";
                }

                con.Open();
                string query = "Update Teacher set Name= '" + textBox2.Text + "', Surname= '" + textBox3.Text + "', Date_Of_Birth= '" + textBox4.Text + "', NIC_No= '" + textBox5.Text + "', Mobile_No= '" + textBox6.Text + "', Address= '" + textBox7.Text + "', Subject= '" + textBox8.Text + "', Qualification= '" + textBox9.Text + "', Salary= '" + textBox10.Text + "' where ID= '" + textBox1.Text + "'";
                com = new SqlCommand(query, con);
                com.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Successfully Updated");
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                textBox4.Text = "";

                textBox5.Text = "";
               
                textBox6.Text = "";
                textBox7.Text = "";
                textBox8.Text = "";
                textBox9.Text = "";
                textBox10.Text = "";

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
            con.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            TeacherDetails f5 = new TeacherDetails();
            this.Hide();
            f5.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            School_Main3 f2 = new School_Main3();
            this.Hide();
            f2.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            textBox6.Clear();
            textBox7.Clear();
            textBox8.Clear();
            textBox9.Clear();
            textBox10.Clear();
        }
    }
}
