using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace calcu
{
    public partial class Form4 : Form
    {
        string num = "";
        int num1 = 0;
        int num2 = 0;
        string operation = "";

        public Form4()
        {
            InitializeComponent();
        }

        private void BTSquareRoot_Click(object sender, EventArgs e)
        {
            num1 = Convert.ToInt32(RESULTTB.Text);
            double result = Math.Sqrt(num1);
            RESULTTB.Text = result.ToString();
            num = result.ToString();
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void BT0_Click(object sender, EventArgs e)
        {
            num = num + BT1.Text;
            RESULTTB.Text = num;
        }

        private void BT1_Click(object sender, EventArgs e)
        {
            num = num + BT0.Text;
            RESULTTB.Text = num;
        }

        private void BT2_Click(object sender, EventArgs e)
        {
            num = num + BT2.Text;
            RESULTTB.Text = num;
        }

        private void BT3_Click(object sender, EventArgs e)
        {
            num = num + BT3.Text;
            RESULTTB.Text = num;
        }

        private void BT4_Click(object sender, EventArgs e)
        {
            num = num + BT4.Text;
            RESULTTB.Text = num;
        }

        private void BT5_Click(object sender, EventArgs e)
        {
            num = num + BT5.Text;
            RESULTTB.Text = num;
        }

        private void BT6_Click(object sender, EventArgs e)
        {
            num = num + BT6.Text;
            RESULTTB.Text = num;
        }

        private void BT7_Click(object sender, EventArgs e)
        {
            num = num + BT7.Text;
            RESULTTB.Text = num;
        }

        private void BT8_Click(object sender, EventArgs e)
        {
            num = num + BT8.Text;
            RESULTTB.Text = num;
        }

        private void BT9_Click(object sender, EventArgs e)
        {
            num = num + BT9.Text;
            RESULTTB.Text = num;
        }

        private void BTDot_Click(object sender, EventArgs e)
        {
            if (!num.Contains("."))
            {
                num = num + ".";
                RESULTTB.Text = num;
            }
        }

        private void BTDiv_Click(object sender, EventArgs e)
        {
            TB.Text = RESULTTB.Text + " /";
            num1 = Convert.ToInt32(RESULTTB.Text);
            RESULTTB.Text = "";
            num = "";
            operation = "/";
        }

        private void BTEquals_Click(object sender, EventArgs e)
        {
            num2 = Convert.ToInt32(RESULTTB.Text);
            int result = 0;

            if (operation == "+") result = num1 + num2;
            if (operation == "-") result = num1 - num2;
            if (operation == "*") result = num1 * num2;
            if (operation == "/") result = num1 / num2;
            if (operation == "%") result = num1 % num2;  // REMAINDER

            RESULTTB.Text = result.ToString();
            TB.Text = "";
            num1 = 0;
            num2 = 0;
            num = result.ToString();
            operation = "";
        }

        private void BTAdd_Click(object sender, EventArgs e)
        {
            TB.Text = RESULTTB.Text + " +";
            num1 = Convert.ToInt32(RESULTTB.Text);
            RESULTTB.Text = "";
            num = "";
            operation = "+";
        }

        private void BTSub_Click(object sender, EventArgs e)
        {
            TB.Text = RESULTTB.Text + " -";
            num1 = Convert.ToInt32(RESULTTB.Text);
            RESULTTB.Text = "";
            num = "";
            operation = "-";
        }

        private void BTMul_Click(object sender, EventArgs e)
        {
            TB.Text = RESULTTB.Text + " x";
            num1 = Convert.ToInt32(RESULTTB.Text);
            RESULTTB.Text = "";
            num = "";
            operation = "*";
        }

        private void BTRemainder_Click(object sender, EventArgs e)
        {
            TB.Text = RESULTTB.Text + " %";
            num1 = Convert.ToInt32(RESULTTB.Text);
            RESULTTB.Text = "";
            num = "";
            operation = "%";
        }

        private void BTBack_Click(object sender, EventArgs e)
        {
            if (num.Length > 0)
            {
                num = num.Substring(0, num.Length - 1);
                RESULTTB.Text = num;
            }
        }

        private void BTClear_Click(object sender, EventArgs e)
        {
            RESULTTB.Text = "";
            TB.Text = "";
            num = "";
            num1 = 0;
            num2 = 0;
            operation = "";
        }
    }

}
