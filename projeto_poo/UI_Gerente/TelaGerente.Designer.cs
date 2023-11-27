namespace AutoCenter
{
    partial class TelaGerente
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
            CriarFuncionarioButton = new Button();
            label1 = new Label();
            Funcionarios = new Label();
            ListarVendas = new Button();
            ProdutosLabel = new Label();
            CadastrarNovoProdutoButton = new Button();
            ListarProdutosButton = new Button();
            CaixaVendaLabel = new Label();
            ListarV = new Button();
            TelaCaixa = new Button();
            CriarUmNovaVenda = new Button();
            SuspendLayout();
            // 
            // CriarFuncionarioButton
            // 
            CriarFuncionarioButton.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            CriarFuncionarioButton.Location = new Point(34, 225);
            CriarFuncionarioButton.Name = "CriarFuncionarioButton";
            CriarFuncionarioButton.Size = new Size(193, 64);
            CriarFuncionarioButton.TabIndex = 0;
            CriarFuncionarioButton.Text = "Criar Funcionario";
            CriarFuncionarioButton.UseVisualStyleBackColor = true;
            CriarFuncionarioButton.Click += CriarFuncionarioButton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 35F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(334, 62);
            label1.TabIndex = 1;
            label1.Text = "Nome Gerente";
            // 
            // Funcionarios
            // 
            Funcionarios.AutoSize = true;
            Funcionarios.Font = new Font("Segoe UI", 30F, FontStyle.Regular, GraphicsUnit.Point);
            Funcionarios.Location = new Point(12, 149);
            Funcionarios.Name = "Funcionarios";
            Funcionarios.Size = new Size(247, 54);
            Funcionarios.TabIndex = 2;
            Funcionarios.Text = "Funcionários";
            Funcionarios.Click += label2_Click;
            // 
            // ListarVendas
            // 
            ListarVendas.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            ListarVendas.Location = new Point(34, 295);
            ListarVendas.Name = "ListarVendas";
            ListarVendas.Size = new Size(193, 64);
            ListarVendas.TabIndex = 3;
            ListarVendas.Text = "Editar/Excluir Funcionario";
            ListarVendas.UseVisualStyleBackColor = true;
            // 
            // ProdutosLabel
            // 
            ProdutosLabel.AutoSize = true;
            ProdutosLabel.Font = new Font("Segoe UI", 30F, FontStyle.Regular, GraphicsUnit.Point);
            ProdutosLabel.Location = new Point(595, 149);
            ProdutosLabel.Name = "ProdutosLabel";
            ProdutosLabel.Size = new Size(183, 54);
            ProdutosLabel.TabIndex = 5;
            ProdutosLabel.Text = "Produtos";
            ProdutosLabel.Click += ProdutosLabel_Click;
            // 
            // CadastrarNovoProdutoButton
            // 
            CadastrarNovoProdutoButton.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            CadastrarNovoProdutoButton.Location = new Point(595, 225);
            CadastrarNovoProdutoButton.Name = "CadastrarNovoProdutoButton";
            CadastrarNovoProdutoButton.Size = new Size(193, 64);
            CadastrarNovoProdutoButton.TabIndex = 6;
            CadastrarNovoProdutoButton.Text = "Cadastrar Produto";
            CadastrarNovoProdutoButton.UseVisualStyleBackColor = true;
            CadastrarNovoProdutoButton.Click += CadastrarNovoProdutoButton_Click;
            // 
            // ListarProdutosButton
            // 
            ListarProdutosButton.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            ListarProdutosButton.Location = new Point(595, 295);
            ListarProdutosButton.Name = "ListarProdutosButton";
            ListarProdutosButton.Size = new Size(193, 64);
            ListarProdutosButton.TabIndex = 7;
            ListarProdutosButton.Text = "Listar Produtos\r\n";
            ListarProdutosButton.UseVisualStyleBackColor = true;
            // 
            // CaixaVendaLabel
            // 
            CaixaVendaLabel.AutoSize = true;
            CaixaVendaLabel.Font = new Font("Segoe UI", 30F, FontStyle.Regular, GraphicsUnit.Point);
            CaixaVendaLabel.Location = new Point(1105, 149);
            CaixaVendaLabel.Name = "CaixaVendaLabel";
            CaixaVendaLabel.Size = new Size(242, 54);
            CaixaVendaLabel.TabIndex = 8;
            CaixaVendaLabel.Text = "Caixa/Venda";
            // 
            // ListarV
            // 
            ListarV.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            ListarV.Location = new Point(595, 365);
            ListarV.Name = "ListarV";
            ListarV.Size = new Size(193, 64);
            ListarV.TabIndex = 9;
            ListarV.Text = "Listar Vendas";
            ListarV.UseVisualStyleBackColor = true;
            // 
            // TelaCaixa
            // 
            TelaCaixa.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            TelaCaixa.Location = new Point(1129, 225);
            TelaCaixa.Name = "TelaCaixa";
            TelaCaixa.Size = new Size(193, 64);
            TelaCaixa.TabIndex = 10;
            TelaCaixa.Text = "Vendas e Ordem de Servço em aberto";
            TelaCaixa.UseVisualStyleBackColor = true;
            // 
            // CriarUmNovaVenda
            // 
            CriarUmNovaVenda.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            CriarUmNovaVenda.Location = new Point(1129, 352);
            CriarUmNovaVenda.Name = "CriarUmNovaVenda";
            CriarUmNovaVenda.Size = new Size(193, 64);
            CriarUmNovaVenda.TabIndex = 11;
            CriarUmNovaVenda.Text = "Vendas";
            CriarUmNovaVenda.UseVisualStyleBackColor = true;
            // 
            // TelaGerente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1372, 745);
            Controls.Add(CriarUmNovaVenda);
            Controls.Add(TelaCaixa);
            Controls.Add(ListarV);
            Controls.Add(CaixaVendaLabel);
            Controls.Add(ListarProdutosButton);
            Controls.Add(CadastrarNovoProdutoButton);
            Controls.Add(ProdutosLabel);
            Controls.Add(ListarVendas);
            Controls.Add(Funcionarios);
            Controls.Add(label1);
            Controls.Add(CriarFuncionarioButton);
            Name = "TelaGerente";
            StartPosition = FormStartPosition.Manual;
            Text = "TelaGerente";
            Load += TelaGerente_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button CriarFuncionarioButton;
        private Label label1;
        private Label Funcionarios;
        private Button ListarVendas;
        private Label Produtos;
        private Label label;
        private Label ProdutosLabel;
        private Button CadastrarNovoProdutoButton;
        private Button ListarProdutosButton;
        private Label CaixaVendaLabel;
        private Button ListarV;
        private Button TelaCaixa;
        private Button CriarUmNovaVenda;
    }
}