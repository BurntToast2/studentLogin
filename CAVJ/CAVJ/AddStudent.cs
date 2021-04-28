using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CAVJ
{
    public partial class AddStudent : Form
    {
        public AddStudent()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void AddStudent_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Presence Check of textboxes
            if (textBox1.Text.Length < 1)
            {
                label8.Visible = true;
            }
            else if (textBox2.Text.Length < 1)
            {
                label10.Visible = true;
            }
            else if (textBox4.Text.Length < 1)
            {
                label12.Visible = true;
            }
            else if (textBox5.Text.Length < 1)
            {
                label13.Visible = true;
            }
            else
            {
                label8.Visible = false;
                label10.Visible = false;
                label12.Visible = false;
                label13.Visible = false;
            }
            //end
            comboBox1.SelectedIndex 










        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        
    }
}
