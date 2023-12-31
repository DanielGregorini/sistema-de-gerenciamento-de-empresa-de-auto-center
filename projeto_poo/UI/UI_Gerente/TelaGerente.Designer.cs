﻿namespace AutoCenter
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
            NomeGerente = new Label();
            Funcionarios = new Label();
            ListarVendas = new Button();
            ProdutosLabel = new Label();
            CadastrarNovoProdutoButton = new Button();
            ListarProdutosButton = new Button();
            ListarV = new Button();
            EditarProduto = new Button();
            SuspendLayout();
            // 
            // CriarFuncionarioButton
            // 
            CriarFuncionarioButton.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            CriarFuncionarioButton.Location = new Point(33, 218);
            CriarFuncionarioButton.Name = "CriarFuncionarioButton";
            CriarFuncionarioButton.Size = new Size(193, 64);
            CriarFuncionarioButton.TabIndex = 0;
            CriarFuncionarioButton.Text = "Criar Funcionario";
            CriarFuncionarioButton.UseVisualStyleBackColor = true;
            CriarFuncionarioButton.Click += CriarFuncionarioButton_Click;
            // 
            // NomeGerente
            // 
            NomeGerente.AutoSize = true;
            NomeGerente.Font = new Font("Segoe UI", 35F, FontStyle.Regular, GraphicsUnit.Point);
            NomeGerente.Location = new Point(12, 9);
            NomeGerente.Name = "NomeGerente";
            NomeGerente.Size = new Size(334, 62);
            NomeGerente.TabIndex = 1;
            NomeGerente.Text = "Nome Gerente";
            // 
            // Funcionarios
            // 
            Funcionarios.AutoSize = true;
            Funcionarios.Font = new Font("Segoe UI", 30F, FontStyle.Regular, GraphicsUnit.Point);
            Funcionarios.Location = new Point(12, 155);
            Funcionarios.Name = "Funcionarios";
            Funcionarios.Size = new Size(247, 54);
            Funcionarios.TabIndex = 2;
            Funcionarios.Text = "Funcionários";
            // 
            // ListarVendas
            // 
            ListarVendas.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            ListarVendas.Location = new Point(33, 288);
            ListarVendas.Name = "ListarVendas";
            ListarVendas.Size = new Size(193, 64);
            ListarVendas.TabIndex = 3;
            ListarVendas.Text = "Editar/Excluir Funcionario";
            ListarVendas.UseVisualStyleBackColor = true;
            ListarVendas.Click += ListarVendas_Click;
            // 
            // ProdutosLabel
            // 
            ProdutosLabel.AutoSize = true;
            ProdutosLabel.Font = new Font("Segoe UI", 30F, FontStyle.Regular, GraphicsUnit.Point);
            ProdutosLabel.Location = new Point(597, 155);
            ProdutosLabel.Name = "ProdutosLabel";
            ProdutosLabel.Size = new Size(183, 54);
            ProdutosLabel.TabIndex = 5;
            ProdutosLabel.Text = "Produtos";
            // 
            // CadastrarNovoProdutoButton
            // 
            CadastrarNovoProdutoButton.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            CadastrarNovoProdutoButton.Location = new Point(587, 289);
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
            ListarProdutosButton.Location = new Point(587, 359);
            ListarProdutosButton.Name = "ListarProdutosButton";
            ListarProdutosButton.Size = new Size(193, 64);
            ListarProdutosButton.TabIndex = 7;
            ListarProdutosButton.Text = "Listar Produtos\r\n";
            ListarProdutosButton.UseVisualStyleBackColor = true;
            ListarProdutosButton.Click += ListarProdutosButton_Click;
            // 
            // ListarV
            // 
            ListarV.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            ListarV.Location = new Point(587, 429);
            ListarV.Name = "ListarV";
            ListarV.Size = new Size(193, 64);
            ListarV.TabIndex = 9;
            ListarV.Text = "Listar Vendas/ODS";
            ListarV.UseVisualStyleBackColor = true;
            ListarV.Click += ListarV_Click;
            // 
            // EditarProduto
            // 
            EditarProduto.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            EditarProduto.Location = new Point(587, 219);
            EditarProduto.Name = "EditarProduto";
            EditarProduto.Size = new Size(193, 64);
            EditarProduto.TabIndex = 12;
            EditarProduto.Text = "Editar Produto";
            EditarProduto.UseVisualStyleBackColor = true;
            EditarProduto.Click += EditarProduto_Click;
            // 
            // TelaGerente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(823, 540);
            Controls.Add(EditarProduto);
            Controls.Add(ListarV);
            Controls.Add(ListarProdutosButton);
            Controls.Add(CadastrarNovoProdutoButton);
            Controls.Add(ProdutosLabel);
            Controls.Add(ListarVendas);
            Controls.Add(Funcionarios);
            Controls.Add(NomeGerente);
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
        private Label NomeGerente;
        private Label Funcionarios;
        private Button ListarVendas;
        private Label Produtos;
        private Label label;
        private Label ProdutosLabel;
        private Button CadastrarNovoProdutoButton;
        private Button ListarProdutosButton;
        private Button ListarV;
        private Button EditarProduto;
    }
}