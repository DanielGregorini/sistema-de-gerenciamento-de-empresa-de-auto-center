namespace AutoCenter
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
            label_senha = new Label();
            text_login = new TextBox();
            text_senha = new TextBox();
            button_logar = new Button();
            pictureBox1 = new PictureBox();
            EmpresaLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // Login
            // 
            Login.AutoSize = true;
            Login.BackColor = SystemColors.Control;
            Login.Font = new Font("Segoe UI", 30F, FontStyle.Regular, GraphicsUnit.Point);
            Login.Location = new Point(253, 329);
            Login.Name = "Login";
            Login.Size = new Size(139, 54);
            Login.TabIndex = 0;
            Login.Text = "LOGIN";
            // 
            // label_senha
            // 
            label_senha.AutoSize = true;
            label_senha.Font = new Font("Segoe UI", 30F, FontStyle.Regular, GraphicsUnit.Point);
            label_senha.Location = new Point(244, 445);
            label_senha.Name = "label_senha";
            label_senha.Size = new Size(148, 54);
            label_senha.TabIndex = 1;
            label_senha.Text = "SENHA";
            // 
            // text_login
            // 
            text_login.Location = new Point(198, 398);
            text_login.Name = "text_login";
            text_login.Size = new Size(252, 23);
            text_login.TabIndex = 2;
            // 
            // text_senha
            // 
            text_senha.Location = new Point(198, 513);
            text_senha.Name = "text_senha";
            text_senha.Size = new Size(252, 23);
            text_senha.TabIndex = 3;
            // 
            // button_logar
            // 
            button_logar.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            button_logar.Location = new Point(243, 560);
            button_logar.Name = "button_logar";
            button_logar.Size = new Size(149, 63);
            button_logar.TabIndex = 4;
            button_logar.Text = "Logar";
            button_logar.UseVisualStyleBackColor = true;
            button_logar.Click += button_logar_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(153, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(359, 201);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // EmpresaLabel
            // 
            EmpresaLabel.AutoSize = true;
            EmpresaLabel.Font = new Font("Roboto", 40F, FontStyle.Regular, GraphicsUnit.Point);
            EmpresaLabel.Location = new Point(50, 216);
            EmpresaLabel.Name = "EmpresaLabel";
            EmpresaLabel.Size = new Size(586, 65);
            EmpresaLabel.TabIndex = 6;
            EmpresaLabel.Text = "Video Som Auto Center";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(664, 659);
            Controls.Add(EmpresaLabel);
            Controls.Add(pictureBox1);
            Controls.Add(button_logar);
            Controls.Add(text_senha);
            Controls.Add(text_login);
            Controls.Add(label_senha);
            Controls.Add(Login);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Login;
        private Label label_senha;
        private TextBox text_login;
        private TextBox text_senha;
        private Button button_logar;
        private PictureBox pictureBox1;
        private Label EmpresaLabel;
    }
}