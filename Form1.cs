namespace calcu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
      

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void TB2_TextChanged(object sender, EventArgs e)
        {

        }

        private void ADD_Click(object sender, EventArgs e)
        {
            double v1 = Convert.ToDouble(TB1.Text);
            double v2 = Convert.ToDouble(TB2.Text);
            double ans = v1 + v2;
            TB3.Text = Convert.ToString(ans);
        }

        private void SUBTRACT_Click(object sender, EventArgs e)
        {
            double v1 = Convert.ToDouble(TB1.Text);
            double v2 = Convert.ToDouble(TB2.Text);
            double ans = v1 - v2;
            TB3.Text = Convert.ToString(ans);
        }

        private void MULTIPLY_Click(object sender, EventArgs e)
        {
            double v1 = Convert.ToDouble(TB1.Text);
            double v2 = Convert.ToDouble(TB2.Text);
            double ans = v1 * v2;
            TB3.Text = Convert.ToString(ans);
        }

        private void DIVIDE_Click(object sender, EventArgs e)
        {
            double v1 = Convert.ToDouble(TB1.Text);
            double v2 = Convert.ToDouble(TB2.Text);

            if (v2 == 0)
            {
                MessageBox.Show("Error: Cannot divide by zero!", "Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            double ans = v1 / v2;
            TB3.Text = Convert.ToString(ans);
        }

        private void MODULUS_Click(object sender, EventArgs e)
        {
            int v1 = Convert.ToInt32(TB1.Text);
            int v2 = Convert.ToInt32(TB2.Text);

            if (v2 == 0)
            {
                MessageBox.Show("Error: Cannot mod by zero!", "Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int ans = v1 % v2;
            TB3.Text = Convert.ToString(ans);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Show();
        }

        private void btnShowForm2_Click(object sender, EventArgs e)
        {
            // hide form 1 
            this.Hide();
            Form2? f2 = new Form2();
            f2.ShowDialog();
            f2 = null;
            this.Show();
        }
    }
}
