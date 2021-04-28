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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            txtUsername.Text = "";
        }


        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                username_check(sender, e);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (txtPassword.UseSystemPasswordChar == false)
            {
                txtPassword.UseSystemPasswordChar = true;
            }
            else
            {
                txtPassword.UseSystemPasswordChar = false;
            }
        }

        private void txtUsername_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                username_check(sender, e);
            }
        }

        private void txtUsername_Click(object sender, EventArgs e)
        {
            
        }

        private void txtUsername_MouseClick(object sender, MouseEventArgs e)
        {
                        
        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {
                                 
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
        private void username_check(object sender, EventArgs e)
        {
            label4.Visible = false;
            label5.Visible = false;
            if (txtUsername.Text != "vjayasinghe291")
            {
                label4.Visible = true;
            }
            if (txtPassword.Text != "vissrawa")
            {
                label5.Visible = true;
            }
            if (txtUsername.Text == "vjayasinghe291" && txtPassword.Text == "vissrawa")
            {
                this.Hide();
                LoadingScreen MM = new LoadingScreen();
                MM.Show();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
