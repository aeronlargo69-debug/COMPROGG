using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace calcu
{
    public partial class Form3 : Form
    {
        string num = "";
        int num1 = 0;
        int num2 = 0;
        string op = "";

        public Form3()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

            Form2 form2 = new Form2();
            form2.Show();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void APPENDTOCALCULATIONSTRING(object sender, EventArgs e)
        {
            Button invokedbtn = sender as Button;
            if (invokedbtn != null)
            {
                RESULTBOX.Text += invokedbtn.Text;
            }
        }

        private void CLEARENTRY_Click(object sender, EventArgs e)
        {
            RESULTBOX.Text = string.Empty;
        }

        private void button4_Click(object sender, EventArgs e) //EVALUATION
        {
            string expression = RESULTBOX.Text;
            var result = new DataTable();
            try
            {
                double evalresult1 = Convert.ToDouble(result.Compute(expression, null));
                if (double.IsInfinity(evalresult1) || double.IsNaN(evalresult1))
                {
                    MessageBox.Show("Expression was evaluated to be undefined.", "Evaluation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    RESULTBOX.Text = string.Empty;
                    return;
                }
                RESULTBOX.Text = evalresult1.ToString();
            }
            catch (System.Data.SyntaxErrorException)
            {
                MessageBox.Show("Expression was not valid.", "Syntax Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                RESULTBOX.Text = string.Empty;
            }
        }

    }

}

