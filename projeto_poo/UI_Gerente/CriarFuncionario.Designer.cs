namespace AutoCenter.UI_Gerente
{
    partial class CriarFuncionario
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            TituloPaginaLabel = new Label();
            Nome = new Label();
            NomeBox = new TextBox();
            Cpf = new Label();
            CpfBox = new TextBox();
            Login = new Label();
            LoginBox = new TextBox();
            Senha = new Label();
            SenhaBox = new TextBox();
            ButtonCriar = new Button();
            ButtonCaixa = new RadioButton();
            ButtonVendedor = new RadioButton();
            ButtonGerente = new RadioButton();
            SuspendLayout();
            // 
            // TituloPaginaLabel
            // 
            TituloPaginaLabel.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            TituloPaginaLabel.AutoSize = true;
            TituloPaginaLabel.Font = new Font("Segoe UI", 45F, FontStyle.Regular, GraphicsUnit.Point);
            TituloPaginaLabel.Location = new Point(381, 9);
            TituloPaginaLabel.Name = "TituloPaginaLabel";
            TituloPaginaLabel.Size = new Size(626, 81);
            TituloPaginaLabel.TabIndex = 0;
            TituloPaginaLabel.Text = "Criar novo funcionário";
            // 
            // Nome
            // 
            Nome.AutoSize = true;
            Nome.Font = new Font("Segoe UI", 25F, FontStyle.Regular, GraphicsUnit.Point);
            Nome.Location = new Point(506, 280);
            Nome.Name = "Nome";
            Nome.Size = new Size(119, 46);
            Nome.TabIndex = 1;
            Nome.Text = "Nome:";
            // 
            // NomeBox
            // 
            NomeBox.Location = new Point(631, 291);
            NomeBox.Name = "NomeBox";
            NomeBox.Size = new Size(207, 23);
            NomeBox.TabIndex = 2;
            // 
            // Cpf
            // 
            Cpf.AutoSize = true;
            Cpf.Font = new Font("Segoe UI", 25F, FontStyle.Regular, GraphicsUnit.Point);
            Cpf.Location = new Point(506, 352);
            Cpf.Name = "Cpf";
            Cpf.Size = new Size(84, 46);
            Cpf.TabIndex = 3;
            Cpf.Text = "CPF:";
            // 
            // CpfBox
            // 
            CpfBox.Location = new Point(631, 364);
            CpfBox.Name = "CpfBox";
            CpfBox.Size = new Size(207, 23);
            CpfBox.TabIndex = 4;
            // 
            // Login
            // 
            Login.AutoSize = true;
            Login.Font = new Font("Segoe UI", 25F, FontStyle.Regular, GraphicsUnit.Point);
            Login.Location = new Point(506, 417);
            Login.Name = "Login";
            Login.Size = new Size(110, 46);
            Login.TabIndex = 5;
            Login.Text = "Login:";
            // 
            // LoginBox
            // 
            LoginBox.Location = new Point(631, 438);
            LoginBox.Name = "LoginBox";
            LoginBox.Size = new Size(207, 23);
            LoginBox.TabIndex = 6;
            // 
            // Senha
            // 
            Senha.AutoSize = true;
            Senha.Font = new Font("Segoe UI", 25F, FontStyle.Regular, GraphicsUnit.Point);
            Senha.Location = new Point(506, 483);
            Senha.Name = "Senha";
            Senha.Size = new Size(118, 46);
            Senha.TabIndex = 7;
            Senha.Text = "Senha:";
            // 
            // SenhaBox
            // 
            SenhaBox.Location = new Point(631, 504);
            SenhaBox.Name = "SenhaBox";
            SenhaBox.Size = new Size(207, 23);
            SenhaBox.TabIndex = 8;
            // 
            // ButtonCriar
            // 
            ButtonCriar.Font = new Font("Segoe UI", 40F, FontStyle.Regular, GraphicsUnit.Point);
            ButtonCriar.Location = new Point(596, 619);
            ButtonCriar.Name = "ButtonCriar";
            ButtonCriar.Size = new Size(193, 72);
            ButtonCriar.TabIndex = 9;
            ButtonCriar.Text = "Criar";
            ButtonCriar.UseVisualStyleBackColor = true;
            ButtonCriar.Click += ButtonCriar_Click;
            // 
            // ButtonCaixa
            // 
            ButtonCaixa.AutoSize = true;
            ButtonCaixa.Location = new Point(631, 560);
            ButtonCaixa.Name = "ButtonCaixa";
            ButtonCaixa.Size = new Size(54, 19);
            ButtonCaixa.TabIndex = 11;
            ButtonCaixa.TabStop = true;
            ButtonCaixa.Text = "Caixa";
            ButtonCaixa.UseVisualStyleBackColor = true;
            // 
            // ButtonVendedor
            // 
            ButtonVendedor.AutoSize = true;
            ButtonVendedor.BackColor = SystemColors.Control;
            ButtonVendedor.Location = new Point(518, 560);
            ButtonVendedor.Name = "ButtonVendedor";
            ButtonVendedor.Size = new Size(75, 19);
            ButtonVendedor.TabIndex = 12;
            ButtonVendedor.TabStop = true;
            ButtonVendedor.Text = "Vendedor";
            ButtonVendedor.UseVisualStyleBackColor = false;
            // 
            // ButtonGerente
            // 
            ButtonGerente.AutoSize = true;
            ButtonGerente.Location = new Point(718, 560);
            ButtonGerente.Name = "ButtonGerente";
            ButtonGerente.Size = new Size(66, 19);
            ButtonGerente.TabIndex = 13;
            ButtonGerente.TabStop = true;
            ButtonGerente.Text = "Gerente";
            ButtonGerente.UseVisualStyleBackColor = true;
            // 
            // CriarFuncionario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1400, 821);
            Controls.Add(ButtonGerente);
            Controls.Add(ButtonVendedor);
            Controls.Add(ButtonCaixa);
            Controls.Add(ButtonCriar);
            Controls.Add(SenhaBox);
            Controls.Add(Senha);
            Controls.Add(LoginBox);
            Controls.Add(Login);
            Controls.Add(CpfBox);
            Controls.Add(Cpf);
            Controls.Add(NomeBox);
            Controls.Add(Nome);
            Controls.Add(TituloPaginaLabel);
            Name = "CriarFuncionario";
            Text = "CriarFuncionario";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label TituloPaginaLabel;
        private Label Nome;
        private TextBox NomeBox;
        private Label Cpf;
        private TextBox CpfBox;
        private Label Login;
        private TextBox LoginBox;
        private Label Senha;
        private TextBox SenhaBox;
        private Button ButtonCriar;
        private RadioButton ButtonCaixa;
        private RadioButton ButtonVendedor;
        private RadioButton ButtonGerente;
    }
}