namespace projeto_poo
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
            Login = new Label();
            Senha = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            button1 = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // Login
            // 
            Login.AutoSize = true;
            Login.BackColor = SystemColors.Control;
            Login.Font = new Font("Segoe UI", 30F, FontStyle.Regular, GraphicsUnit.Point);
            Login.Location = new Point(517, 325);
            Login.Name = "Login";
            Login.Size = new Size(139, 54);
            Login.TabIndex = 0;
            Login.Text = "LOGIN";
            Login.Click += label1_Click;
            // 
            // Senha
            // 
            Senha.AutoSize = true;
            Senha.Font = new Font("Segoe UI", 30F, FontStyle.Regular, GraphicsUnit.Point);
            Senha.Location = new Point(508, 420);
            Senha.Name = "Senha";
            Senha.Size = new Size(148, 54);
            Senha.TabIndex = 1;
            Senha.Text = "SENHA";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(466, 382);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(252, 23);
            textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(466, 491);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(252, 23);
            textBox2.TabIndex = 3;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(508, 540);
            button1.Name = "button1";
            button1.Size = new Size(149, 63);
            button1.TabIndex = 4;
            button1.Text = "Logar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(358, 73);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(445, 249);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1179, 659);
            Controls.Add(pictureBox1);
            Controls.Add(button1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(Senha);
            Controls.Add(Login);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Login;
        private Label Senha;
        private TextBox textBox1;
        private TextBox textBox2;
        private Button button1;
        private PictureBox pictureBox1;
    }
}