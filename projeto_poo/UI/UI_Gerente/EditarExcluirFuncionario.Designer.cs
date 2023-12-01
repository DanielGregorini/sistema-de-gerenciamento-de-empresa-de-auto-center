namespace AutoCenter;

partial class EditarExcluirFuncionario
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
        label1 = new Label();
        NomeGerenteLabel = new Label();
        ListaFuncionarios = new ComboBox();
        CaixaButton = new RadioButton();
        VendedorButton = new RadioButton();
        GerenteButton = new RadioButton();
        NomeLabel = new Label();
        CpfLabel = new Label();
        LoginLabel = new Label();
        SenhaLabel = new Label();
        NomeBox = new TextBox();
        CpfBox = new TextBox();
        LoginBox = new TextBox();
        SenhaBox = new TextBox();
        ConfirmarEdicao = new Button();
        SuspendLayout();
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Location = new Point(131, 26);
        label1.Name = "label1";
        label1.Size = new Size(0, 20);
        label1.TabIndex = 0;
        // 
        // NomeGerenteLabel
        // 
        NomeGerenteLabel.AutoSize = true;
        NomeGerenteLabel.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
        NomeGerenteLabel.Location = new Point(12, 9);
        NomeGerenteLabel.Name = "NomeGerenteLabel";
        NomeGerenteLabel.Size = new Size(241, 46);
        NomeGerenteLabel.TabIndex = 1;
        NomeGerenteLabel.Text = "Nome Gerente";
        // 
        // ListaFuncionarios
        // 
        ListaFuncionarios.FormattingEnabled = true;
        ListaFuncionarios.Location = new Point(220, 176);
        ListaFuncionarios.Name = "ListaFuncionarios";
        ListaFuncionarios.Size = new Size(151, 28);
        ListaFuncionarios.TabIndex = 2;
        ListaFuncionarios.SelectedIndexChanged += ListaFuncionarios_SelectedIndexChanged;
        // 
        // CaixaButton
        // 
        CaixaButton.AutoSize = true;
        CaixaButton.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
        CaixaButton.Location = new Point(483, 176);
        CaixaButton.Name = "CaixaButton";
        CaixaButton.Size = new Size(72, 27);
        CaixaButton.TabIndex = 3;
        CaixaButton.TabStop = true;
        CaixaButton.Text = "Caixa";
        CaixaButton.UseVisualStyleBackColor = true;
        CaixaButton.CheckedChanged += CaixaButton_CheckedChanged;
        // 
        // VendedorButton
        // 
        VendedorButton.AutoSize = true;
        VendedorButton.Location = new Point(609, 177);
        VendedorButton.Name = "VendedorButton";
        VendedorButton.Size = new Size(94, 24);
        VendedorButton.TabIndex = 4;
        VendedorButton.TabStop = true;
        VendedorButton.Text = "Vendedor";
        VendedorButton.UseVisualStyleBackColor = true;
        VendedorButton.CheckedChanged += VendedorButton_CheckedChanged;
        // 
        // GerenteButton
        // 
        GerenteButton.AutoSize = true;
        GerenteButton.Location = new Point(746, 178);
        GerenteButton.Name = "GerenteButton";
        GerenteButton.Size = new Size(82, 24);
        GerenteButton.TabIndex = 5;
        GerenteButton.TabStop = true;
        GerenteButton.Text = "Gerente";
        GerenteButton.UseVisualStyleBackColor = true;
        GerenteButton.CheckedChanged += GerenteButton_CheckedChanged;
        // 
        // NomeLabel
        // 
        NomeLabel.AutoSize = true;
        NomeLabel.Font = new Font("Segoe UI", 25F, FontStyle.Regular, GraphicsUnit.Point);
        NomeLabel.Location = new Point(459, 261);
        NomeLabel.Name = "NomeLabel";
        NomeLabel.Size = new Size(139, 57);
        NomeLabel.TabIndex = 6;
        NomeLabel.Text = "Nome";
        // 
        // CpfLabel
        // 
        CpfLabel.AutoSize = true;
        CpfLabel.Font = new Font("Segoe UI", 25F, FontStyle.Regular, GraphicsUnit.Point);
        CpfLabel.Location = new Point(459, 344);
        CpfLabel.Name = "CpfLabel";
        CpfLabel.Size = new Size(96, 57);
        CpfLabel.TabIndex = 7;
        CpfLabel.Text = "CPF";
        // 
        // LoginLabel
        // 
        LoginLabel.AutoSize = true;
        LoginLabel.Font = new Font("Segoe UI", 25F, FontStyle.Regular, GraphicsUnit.Point);
        LoginLabel.Location = new Point(459, 426);
        LoginLabel.Name = "LoginLabel";
        LoginLabel.Size = new Size(129, 57);
        LoginLabel.TabIndex = 8;
        LoginLabel.Text = "Login";
        // 
        // SenhaLabel
        // 
        SenhaLabel.AutoSize = true;
        SenhaLabel.Font = new Font("Segoe UI", 25F, FontStyle.Regular, GraphicsUnit.Point);
        SenhaLabel.Location = new Point(459, 507);
        SenhaLabel.Name = "SenhaLabel";
        SenhaLabel.Size = new Size(138, 57);
        SenhaLabel.TabIndex = 9;
        SenhaLabel.Text = "Senha";
        // 
        // NomeBox
        // 
        NomeBox.Location = new Point(609, 288);
        NomeBox.Name = "NomeBox";
        NomeBox.Size = new Size(229, 27);
        NomeBox.TabIndex = 10;
        // 
        // CpfBox
        // 
        CpfBox.Location = new Point(609, 371);
        CpfBox.Name = "CpfBox";
        CpfBox.Size = new Size(229, 27);
        CpfBox.TabIndex = 11;
        // 
        // LoginBox
        // 
        LoginBox.Location = new Point(609, 453);
        LoginBox.Name = "LoginBox";
        LoginBox.Size = new Size(229, 27);
        LoginBox.TabIndex = 12;
        // 
        // SenhaBox
        // 
        SenhaBox.Location = new Point(609, 534);
        SenhaBox.Name = "SenhaBox";
        SenhaBox.Size = new Size(229, 27);
        SenhaBox.TabIndex = 13;
        // 
        // ConfirmarEdicao
        // 
        ConfirmarEdicao.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
        ConfirmarEdicao.Location = new Point(552, 600);
        ConfirmarEdicao.Name = "ConfirmarEdicao";
        ConfirmarEdicao.Size = new Size(218, 67);
        ConfirmarEdicao.TabIndex = 14;
        ConfirmarEdicao.Text = "Confirmar Edição";
        ConfirmarEdicao.UseVisualStyleBackColor = true;
        ConfirmarEdicao.Click += ConfirmarEdicao_Click;
        // 
        // EditarExcluirFuncionario
        // 
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(1260, 738);
        Controls.Add(ConfirmarEdicao);
        Controls.Add(SenhaBox);
        Controls.Add(LoginBox);
        Controls.Add(CpfBox);
        Controls.Add(NomeBox);
        Controls.Add(SenhaLabel);
        Controls.Add(LoginLabel);
        Controls.Add(CpfLabel);
        Controls.Add(NomeLabel);
        Controls.Add(GerenteButton);
        Controls.Add(VendedorButton);
        Controls.Add(CaixaButton);
        Controls.Add(ListaFuncionarios);
        Controls.Add(NomeGerenteLabel);
        Controls.Add(label1);
        Name = "EditarExcluirFuncionario";
        Text = "EditarExcluirFuncionario";
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Label label1;
    private Label NomeGerenteLabel;
    private ComboBox ListaFuncionarios;
    private RadioButton CaixaButton;
    private RadioButton VendedorButton;
    private RadioButton GerenteButton;
    private Label NomeLabel;
    private Label CpfLabel;
    private Label LoginLabel;
    private Label SenhaLabel;
    private TextBox NomeBox;
    private TextBox CpfBox;
    private TextBox LoginBox;
    private TextBox SenhaBox;
    private Button ConfirmarEdicao;
}