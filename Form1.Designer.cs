namespace calcu
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            TB1 = new TextBox();
            TB2 = new TextBox();
            TB3 = new TextBox();
            ADD = new Button();
            SUBTRACT = new Button();
            DIVIDE = new Button();
            MULTIPLY = new Button();
            MODULUS = new Button();
            btnShowForm2 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(444, 280);
            label1.Name = "label1";
            label1.Size = new Size(44, 15);
            label1.TabIndex = 0;
            label1.Text = "NUM1:";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(435, 187);
            label2.Name = "label2";
            label2.Size = new Size(0, 15);
            label2.TabIndex = 0;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(482, 380);
            label3.Name = "label3";
            label3.Size = new Size(33, 15);
            label3.TabIndex = 1;
            label3.Text = "ANS:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(471, 332);
            label4.Name = "label4";
            label4.Size = new Size(44, 15);
            label4.TabIndex = 2;
            label4.Text = "NUM2:";
            // 
            // TB1
            // 
            TB1.Location = new Point(512, 272);
            TB1.Name = "TB1";
            TB1.Size = new Size(147, 23);
            TB1.TabIndex = 3;
            // 
            // TB2
            // 
            TB2.Location = new Point(549, 324);
            TB2.Name = "TB2";
            TB2.Size = new Size(100, 23);
            TB2.TabIndex = 4;
            TB2.TextChanged += TB2_TextChanged;
            // 
            // TB3
            // 
            TB3.Location = new Point(549, 372);
            TB3.Name = "TB3";
            TB3.Size = new Size(100, 23);
            TB3.TabIndex = 5;
            // 
            // ADD
            // 
            ADD.Location = new Point(722, 261);
            ADD.Name = "ADD";
            ADD.Size = new Size(75, 23);
            ADD.TabIndex = 6;
            ADD.Text = "ADD";
            ADD.UseVisualStyleBackColor = true;
            ADD.Click += ADD_Click;
            // 
            // SUBTRACT
            // 
            SUBTRACT.Location = new Point(812, 261);
            SUBTRACT.Name = "SUBTRACT";
            SUBTRACT.Size = new Size(75, 23);
            SUBTRACT.TabIndex = 7;
            SUBTRACT.Text = "SUBTRACT";
            SUBTRACT.UseVisualStyleBackColor = true;
            SUBTRACT.Click += SUBTRACT_Click;
            // 
            // DIVIDE
            // 
            DIVIDE.Location = new Point(722, 307);
            DIVIDE.Name = "DIVIDE";
            DIVIDE.Size = new Size(75, 23);
            DIVIDE.TabIndex = 8;
            DIVIDE.Text = "DIVIDE";
            DIVIDE.UseVisualStyleBackColor = true;
            DIVIDE.Click += DIVIDE_Click;
            // 
            // MULTIPLY
            // 
            MULTIPLY.Location = new Point(812, 307);
            MULTIPLY.Name = "MULTIPLY";
            MULTIPLY.Size = new Size(75, 23);
            MULTIPLY.TabIndex = 9;
            MULTIPLY.Text = "MULTIPLY";
            MULTIPLY.UseVisualStyleBackColor = true;
            MULTIPLY.Click += MULTIPLY_Click;
            // 
            // MODULUS
            // 
            MODULUS.Location = new Point(768, 352);
            MODULUS.Name = "MODULUS";
            MODULUS.Size = new Size(75, 23);
            MODULUS.TabIndex = 10;
            MODULUS.Text = "MODULUS";
            MODULUS.UseVisualStyleBackColor = true;
            MODULUS.Click += MODULUS_Click;
            // 
            // btnShowForm2
            // 
            btnShowForm2.Location = new Point(170, 215);
            btnShowForm2.Name = "btnShowForm2";
            btnShowForm2.Size = new Size(75, 23);
            btnShowForm2.TabIndex = 11;
            btnShowForm2.Text = "Form 2";
            btnShowForm2.UseVisualStyleBackColor = true;
            btnShowForm2.Click += btnShowForm2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1518, 657);
            Controls.Add(btnShowForm2);
            Controls.Add(MODULUS);
            Controls.Add(MULTIPLY);
            Controls.Add(DIVIDE);
            Controls.Add(SUBTRACT);
            Controls.Add(ADD);
            Controls.Add(TB3);
            Controls.Add(TB2);
            Controls.Add(TB1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox TB1;
        private TextBox TB2;
        private TextBox TB3;
        private Button ADD;
        private Button SUBTRACT;
        private Button DIVIDE;
        private Button MULTIPLY;
        private Button MODULUS;
        private Button btnShowForm2;
    }
}
