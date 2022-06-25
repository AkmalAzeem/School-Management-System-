using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace My_School_mangement_sys
{
    public partial class School_Main3 : Form
    {
        public School_Main3()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Teacher f4 = new Teacher();
            this.Hide();
            f4.Show();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Students f1 = new Students();
            this.Hide();
            f1.Show();
        }
    }
}
