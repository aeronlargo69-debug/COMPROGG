using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Text;
using System.Windows.Forms;                                                                             

namespace calcu
{
    public partial class Form2 : Form

    {
        Dictionary<string, string> users = new Dictionary<string, string>();

        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            string name = enterntb.Text;
            string age = enteratb.Text;
            string gen = entergtb.Text;
            string message = " you are ";
            if (gen == "Male")
            {
                outputtb.Text = name + message + gen;
                outputtb.BackColor = Color.LightBlue;

                if (gen == "Female")
                {
                    outputtb.Text = name + message + gen;
                    outputtb.BackColor = Color.HotPink;
                }
                Form2 f2 = new Form2();
                f2.Show();
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (ShowCB.Checked == true)
            {
                outputtb.UseSystemPasswordChar = false;

            }
            else
            {
                outputtb.UseSystemPasswordChar = true;
            }
        }

        private void Enterptb_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            string name = enterntb.Text;
            string age = enteratb.Text;
            string gender = entergtb.Text;
            string username = Enterutb.Text;
            string password = Enterptb.Text;

            outputtb.Text =
    "Name: " + textBox1.Text +
    "\nAge: " + textBox2.Text +
    "\nGender: " + textBox3.Text +
    "\nUsername: " + textBox4.Text +
    "\nPassword: " + textBox5.Text;

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void NAMETB_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnShowForm2_Click(object sender, EventArgs e)
        {

        }

        private void ShowCB_CheckedChanged_1(object sender, EventArgs e)
        {
            if (ShowCB.Checked)
            {
                textBox5.UseSystemPasswordChar = false;

            }
            else
            {
                textBox5.UseSystemPasswordChar = true;
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            string username = textBox4.Text;
            string password = textBox5.Text;

            if (username == "" || password == "")
            {
                MessageBox.Show("Please enter username and password");
                return;
            }

            if (Class1.users.ContainsKey(username))
            {
                MessageBox.Show("Username already exists!");
            }
            else
            {
                Class1.users.Add(username, password);
                MessageBox.Show("Account Created Successfully!");
            }
        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            string username = textBox8.Text;
            string password = textBox9.Text;

            if (!Class1.users.ContainsKey(username))
            {
                MessageBox.Show("Account does not exist");
                return;
            }

            if (Class1.users[username] != password) 
            {
                MessageBox.Show("Incorrect Password");
                return;
            }

            MessageBox.Show("Login Successful!");
        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }
    }
}






