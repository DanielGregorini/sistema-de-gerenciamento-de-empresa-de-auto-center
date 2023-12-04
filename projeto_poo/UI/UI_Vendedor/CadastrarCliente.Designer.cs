namespace AutoCenter
{
    partial class CadastrarCliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CadastrarCliente));
            FotoPerfil = new PictureBox();
            NovoClienteLabel = new Label();
            NomeLabel = new Label();
            NomeBox = new TextBox();
            label1 = new Label();
            RgBox = new TextBox();
            CpfCpnjLabel = new Label();
            CpfCpnjLabelBox = new TextBox();
            EnderecoLabel = new Label();
            EnderecoBox = new TextBox();
            TelefoneLabel = new Label();
            TelefoneBox = new TextBox();
            CadastrarClienteButton = new Button();
            ((System.ComponentModel.ISupportInitialize)FotoPerfil).BeginInit();
            SuspendLayout();
            // 
            // FotoPerfil
            // 
            FotoPerfil.BackColor = SystemColors.ButtonHighlight;
            FotoPerfil.Image = (Image)resources.GetObject("FotoPerfil.Image");
            FotoPerfil.Location = new Point(320, 62);
            FotoPerfil.Name = "FotoPerfil";
            FotoPerfil.Size = new Size(74, 70);
            FotoPerfil.SizeMode = PictureBoxSizeMode.StretchImage;
            FotoPerfil.TabIndex = 0;
            FotoPerfil.TabStop = false;
            // 
            // NovoClienteLabel
            // 
            NovoClienteLabel.AutoSize = true;
            NovoClienteLabel.Font = new Font("Segoe UI", 30F, FontStyle.Regular, GraphicsUnit.Point);
            NovoClienteLabel.Location = new Point(415, 62);
            NovoClienteLabel.Name = "NovoClienteLabel";
            NovoClienteLabel.Size = new Size(432, 54);
            NovoClienteLabel.TabIndex = 1;
            NovoClienteLabel.Text = "Cadastrar Novo Cliente";
            // 
            // NomeLabel
            // 
            NomeLabel.AutoSize = true;
            NomeLabel.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            NomeLabel.Location = new Point(415, 209);
            NomeLabel.Name = "NomeLabel";
            NomeLabel.Size = new Size(96, 37);
            NomeLabel.TabIndex = 2;
            NomeLabel.Text = "Nome:";
            // 
            // NomeBox
            // 
            NomeBox.Location = new Point(528, 223);
            NomeBox.Name = "NomeBox";
            NomeBox.Size = new Size(215, 23);
            NomeBox.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(453, 273);
            label1.Name = "label1";
            label1.Size = new Size(58, 37);
            label1.TabIndex = 4;
            label1.Text = "RG:";
            // 
            // RgBox
            // 
            RgBox.Location = new Point(528, 287);
            RgBox.Name = "RgBox";
            RgBox.Size = new Size(215, 23);
            RgBox.TabIndex = 5;
            // 
            // CpfCpnjLabel
            // 
            CpfCpnjLabel.AutoSize = true;
            CpfCpnjLabel.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            CpfCpnjLabel.Location = new Point(381, 335);
            CpfCpnjLabel.Name = "CpfCpnjLabel";
            CpfCpnjLabel.Size = new Size(141, 37);
            CpfCpnjLabel.TabIndex = 6;
            CpfCpnjLabel.Text = "CPF/CPNJ:";
            // 
            // CpfCpnjLabelBox
            // 
            CpfCpnjLabelBox.Location = new Point(528, 350);
            CpfCpnjLabelBox.Name = "CpfCpnjLabelBox";
            CpfCpnjLabelBox.Size = new Size(215, 23);
            CpfCpnjLabelBox.TabIndex = 7;
            // 
            // EnderecoLabel
            // 
            EnderecoLabel.AutoSize = true;
            EnderecoLabel.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            EnderecoLabel.Location = new Point(389, 401);
            EnderecoLabel.Name = "EnderecoLabel";
            EnderecoLabel.Size = new Size(133, 37);
            EnderecoLabel.TabIndex = 8;
            EnderecoLabel.Text = "Endereço:";
            // 
            // EnderecoBox
            // 
            EnderecoBox.Location = new Point(528, 415);
            EnderecoBox.Name = "EnderecoBox";
            EnderecoBox.Size = new Size(215, 23);
            EnderecoBox.TabIndex = 9;
            // 
            // TelefoneLabel
            // 
            TelefoneLabel.AutoSize = true;
            TelefoneLabel.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            TelefoneLabel.Location = new Point(389, 464);
            TelefoneLabel.Name = "TelefoneLabel";
            TelefoneLabel.Size = new Size(122, 37);
            TelefoneLabel.TabIndex = 10;
            TelefoneLabel.Text = "Telefone:";
            // 
            // TelefoneBox
            // 
            TelefoneBox.Location = new Point(528, 478);
            TelefoneBox.Name = "TelefoneBox";
            TelefoneBox.Size = new Size(215, 23);
            TelefoneBox.TabIndex = 11;
            // 
            // CadastrarClienteButton
            // 
            CadastrarClienteButton.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            CadastrarClienteButton.Location = new Point(503, 566);
            CadastrarClienteButton.Name = "CadastrarClienteButton";
            CadastrarClienteButton.Size = new Size(164, 59);
            CadastrarClienteButton.TabIndex = 12;
            CadastrarClienteButton.Text = "Cadastrar";
            CadastrarClienteButton.UseVisualStyleBackColor = true;
            CadastrarClienteButton.Click += CadastrarClienteButton_Click;
            // 
            // CadastrarCliente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1140, 722);
            Controls.Add(CadastrarClienteButton);
            Controls.Add(TelefoneBox);
            Controls.Add(TelefoneLabel);
            Controls.Add(EnderecoBox);
            Controls.Add(EnderecoLabel);
            Controls.Add(CpfCpnjLabelBox);
            Controls.Add(CpfCpnjLabel);
            Controls.Add(RgBox);
            Controls.Add(label1);
            Controls.Add(NomeBox);
            Controls.Add(NomeLabel);
            Controls.Add(NovoClienteLabel);
            Controls.Add(FotoPerfil);
            Name = "CadastrarCliente";
            Text = "CadastrarCliente";
            ((System.ComponentModel.ISupportInitialize)FotoPerfil).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox FotoPerfil;
        private Label NovoClienteLabel;
        private Label NomeLabel;
        private TextBox NomeBox;
        private Label label1;
        private TextBox RgBox;
        private Label CpfCpnjLabel;
        private TextBox CpfCpnjLabelBox;
        private Label EnderecoLabel;
        private TextBox EnderecoBox;
        private Label TelefoneLabel;
        private TextBox TelefoneBox;
        private Button CadastrarClienteButton;
    }
}