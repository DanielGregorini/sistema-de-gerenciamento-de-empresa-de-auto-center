namespace AutoCenter
{
    partial class EditarVenda
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
            PrecoTotalVendaLabel = new Label();
            ConcluirVenda = new Button();
            ProdutoAdicionadosNaVendaLabel = new Label();
            ProdutosNaVenda = new DataGridView();
            IdProduto = new DataGridViewTextBoxColumn();
            Nome = new DataGridViewTextBoxColumn();
            Quantidade = new DataGridViewTextBoxColumn();
            Preco = new DataGridViewTextBoxColumn();
            ValorTotalProduto = new DataGridViewTextBoxColumn();
            RemoverProduto = new DataGridViewButtonColumn();
            ProdutoLabel = new Label();
            NomeProdutoLabel = new Label();
            PesquisarProdutoLabel = new Label();
            AdicionarProdutoBox = new Button();
            QuantidadeVendidaBox = new TextBox();
            QuantidadeVendidaLabel = new Label();
            CustoMedioLabel = new Label();
            Descricao = new Label();
            PrecoLabel = new Label();
            QuantidadeDisponivelLabel = new Label();
            ListaProdutos = new ComboBox();
            BuscarProdutoButton = new Button();
            BuscarProdutoBox = new TextBox();
            ListaVendasEmAberto = new ComboBox();
            ClienteLabel = new Label();
            EnderecoClienteLabel = new Label();
            CpfCnpjClienteLabel = new Label();
            RgClienteLabel = new Label();
            NomeClienteLabel = new Label();
            TelefoneClienteLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)ProdutosNaVenda).BeginInit();
            SuspendLayout();
            // 
            // PrecoTotalVendaLabel
            // 
            PrecoTotalVendaLabel.AutoSize = true;
            PrecoTotalVendaLabel.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            PrecoTotalVendaLabel.Location = new Point(725, 677);
            PrecoTotalVendaLabel.Name = "PrecoTotalVendaLabel";
            PrecoTotalVendaLabel.Size = new Size(112, 28);
            PrecoTotalVendaLabel.TabIndex = 56;
            PrecoTotalVendaLabel.Text = "Preço Total:";
            // 
            // ConcluirVenda
            // 
            ConcluirVenda.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            ConcluirVenda.Location = new Point(987, 677);
            ConcluirVenda.Margin = new Padding(3, 2, 3, 2);
            ConcluirVenda.Name = "ConcluirVenda";
            ConcluirVenda.Size = new Size(205, 44);
            ConcluirVenda.TabIndex = 55;
            ConcluirVenda.Text = "Concluir Venda";
            ConcluirVenda.UseVisualStyleBackColor = true;
            ConcluirVenda.Click += ConcluirVenda_Click;
            // 
            // ProdutoAdicionadosNaVendaLabel
            // 
            ProdutoAdicionadosNaVendaLabel.AutoSize = true;
            ProdutoAdicionadosNaVendaLabel.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            ProdutoAdicionadosNaVendaLabel.Location = new Point(725, 26);
            ProdutoAdicionadosNaVendaLabel.Name = "ProdutoAdicionadosNaVendaLabel";
            ProdutoAdicionadosNaVendaLabel.Size = new Size(379, 37);
            ProdutoAdicionadosNaVendaLabel.TabIndex = 54;
            ProdutoAdicionadosNaVendaLabel.Text = "Produtos adicionado na venda";
            // 
            // ProdutosNaVenda
            // 
            ProdutosNaVenda.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ProdutosNaVenda.Columns.AddRange(new DataGridViewColumn[] { IdProduto, Nome, Quantidade, Preco, ValorTotalProduto, RemoverProduto });
            ProdutosNaVenda.Location = new Point(707, 81);
            ProdutosNaVenda.Margin = new Padding(3, 2, 3, 2);
            ProdutosNaVenda.Name = "ProdutosNaVenda";
            ProdutosNaVenda.RowHeadersWidth = 51;
            ProdutosNaVenda.RowTemplate.Height = 29;
            ProdutosNaVenda.Size = new Size(610, 577);
            ProdutosNaVenda.TabIndex = 53;
            ProdutosNaVenda.CellClick += ProdutosNaVenda_CellClick;
            // 
            // IdProduto
            // 
            IdProduto.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            IdProduto.HeaderText = "ID";
            IdProduto.MinimumWidth = 26;
            IdProduto.Name = "IdProduto";
            IdProduto.Width = 43;
            // 
            // Nome
            // 
            Nome.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            Nome.HeaderText = "Nome";
            Nome.MinimumWidth = 35;
            Nome.Name = "Nome";
            Nome.Width = 65;
            // 
            // Quantidade
            // 
            Quantidade.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            Quantidade.HeaderText = "Quantidade";
            Quantidade.MinimumWidth = 6;
            Quantidade.Name = "Quantidade";
            Quantidade.Width = 94;
            // 
            // Preco
            // 
            Preco.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            Preco.HeaderText = "Preço";
            Preco.MinimumWidth = 6;
            Preco.Name = "Preco";
            Preco.Width = 62;
            // 
            // ValorTotalProduto
            // 
            ValorTotalProduto.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            ValorTotalProduto.HeaderText = "Valor Total / Produto";
            ValorTotalProduto.MinimumWidth = 6;
            ValorTotalProduto.Name = "ValorTotalProduto";
            ValorTotalProduto.Width = 89;
            // 
            // RemoverProduto
            // 
            RemoverProduto.HeaderText = "Remover Produto";
            RemoverProduto.MinimumWidth = 6;
            RemoverProduto.Name = "RemoverProduto";
            RemoverProduto.Width = 125;
            // 
            // ProdutoLabel
            // 
            ProdutoLabel.AutoSize = true;
            ProdutoLabel.Font = new Font("Segoe UI", 30F, FontStyle.Regular, GraphicsUnit.Point);
            ProdutoLabel.Location = new Point(395, 441);
            ProdutoLabel.Name = "ProdutoLabel";
            ProdutoLabel.Size = new Size(175, 54);
            ProdutoLabel.TabIndex = 69;
            ProdutoLabel.Text = "Produto:";
            // 
            // NomeProdutoLabel
            // 
            NomeProdutoLabel.AutoSize = true;
            NomeProdutoLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            NomeProdutoLabel.Location = new Point(404, 504);
            NomeProdutoLabel.Name = "NomeProdutoLabel";
            NomeProdutoLabel.Size = new Size(116, 21);
            NomeProdutoLabel.TabIndex = 68;
            NomeProdutoLabel.Text = "Nome Produto:";
            // 
            // PesquisarProdutoLabel
            // 
            PesquisarProdutoLabel.AutoSize = true;
            PesquisarProdutoLabel.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            PesquisarProdutoLabel.Location = new Point(12, 452);
            PesquisarProdutoLabel.Name = "PesquisarProdutoLabel";
            PesquisarProdutoLabel.Size = new Size(170, 28);
            PesquisarProdutoLabel.TabIndex = 67;
            PesquisarProdutoLabel.Text = "Pesquisar Produto";
            // 
            // AdicionarProdutoBox
            // 
            AdicionarProdutoBox.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            AdicionarProdutoBox.Location = new Point(404, 702);
            AdicionarProdutoBox.Margin = new Padding(3, 2, 3, 2);
            AdicionarProdutoBox.Name = "AdicionarProdutoBox";
            AdicionarProdutoBox.Size = new Size(174, 38);
            AdicionarProdutoBox.TabIndex = 66;
            AdicionarProdutoBox.Text = "Adicionar Produto";
            AdicionarProdutoBox.UseVisualStyleBackColor = true;
            AdicionarProdutoBox.Click += AdicionarProdutoBox_Click;
            // 
            // QuantidadeVendidaBox
            // 
            QuantidadeVendidaBox.Location = new Point(515, 668);
            QuantidadeVendidaBox.Margin = new Padding(3, 2, 3, 2);
            QuantidadeVendidaBox.Name = "QuantidadeVendidaBox";
            QuantidadeVendidaBox.Size = new Size(92, 23);
            QuantidadeVendidaBox.TabIndex = 65;
            QuantidadeVendidaBox.KeyPress += QuantidadeVendidaBox_KeyPress;
            // 
            // QuantidadeVendidaLabel
            // 
            QuantidadeVendidaLabel.AutoSize = true;
            QuantidadeVendidaLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            QuantidadeVendidaLabel.Location = new Point(404, 666);
            QuantidadeVendidaLabel.Name = "QuantidadeVendidaLabel";
            QuantidadeVendidaLabel.Size = new Size(94, 21);
            QuantidadeVendidaLabel.TabIndex = 64;
            QuantidadeVendidaLabel.Text = "Quantidade:";
            // 
            // CustoMedioLabel
            // 
            CustoMedioLabel.AutoSize = true;
            CustoMedioLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            CustoMedioLabel.Location = new Point(404, 637);
            CustoMedioLabel.Name = "CustoMedioLabel";
            CustoMedioLabel.Size = new Size(98, 21);
            CustoMedioLabel.TabIndex = 63;
            CustoMedioLabel.Text = "Custo Medio";
            // 
            // Descricao
            // 
            Descricao.AutoSize = true;
            Descricao.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Descricao.Location = new Point(404, 536);
            Descricao.MaximumSize = new Size(262, 0);
            Descricao.Name = "Descricao";
            Descricao.Size = new Size(77, 21);
            Descricao.TabIndex = 62;
            Descricao.Text = "Descrição";
            // 
            // PrecoLabel
            // 
            PrecoLabel.AutoSize = true;
            PrecoLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            PrecoLabel.Location = new Point(404, 579);
            PrecoLabel.Name = "PrecoLabel";
            PrecoLabel.Size = new Size(49, 21);
            PrecoLabel.TabIndex = 61;
            PrecoLabel.Text = "Preço";
            // 
            // QuantidadeDisponivelLabel
            // 
            QuantidadeDisponivelLabel.AutoSize = true;
            QuantidadeDisponivelLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            QuantidadeDisponivelLabel.Location = new Point(404, 608);
            QuantidadeDisponivelLabel.Name = "QuantidadeDisponivelLabel";
            QuantidadeDisponivelLabel.Size = new Size(166, 21);
            QuantidadeDisponivelLabel.TabIndex = 60;
            QuantidadeDisponivelLabel.Text = "Quantidade disponivel";
            // 
            // ListaProdutos
            // 
            ListaProdutos.FormattingEnabled = true;
            ListaProdutos.Location = new Point(12, 551);
            ListaProdutos.Margin = new Padding(3, 2, 3, 2);
            ListaProdutos.Name = "ListaProdutos";
            ListaProdutos.Size = new Size(353, 23);
            ListaProdutos.TabIndex = 59;
            ListaProdutos.SelectedIndexChanged += ListaProdutos_SelectedIndexChanged;
            // 
            // BuscarProdutoButton
            // 
            BuscarProdutoButton.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            BuscarProdutoButton.Location = new Point(286, 501);
            BuscarProdutoButton.Margin = new Padding(3, 2, 3, 2);
            BuscarProdutoButton.Name = "BuscarProdutoButton";
            BuscarProdutoButton.Size = new Size(79, 28);
            BuscarProdutoButton.TabIndex = 58;
            BuscarProdutoButton.Text = "Pesquisar";
            BuscarProdutoButton.UseVisualStyleBackColor = true;
            BuscarProdutoButton.Click += BuscarProdutoButton_Click;
            // 
            // BuscarProdutoBox
            // 
            BuscarProdutoBox.Location = new Point(12, 501);
            BuscarProdutoBox.Margin = new Padding(3, 2, 3, 2);
            BuscarProdutoBox.Name = "BuscarProdutoBox";
            BuscarProdutoBox.Size = new Size(268, 23);
            BuscarProdutoBox.TabIndex = 57;
            // 
            // ListaVendasEmAberto
            // 
            ListaVendasEmAberto.FormattingEnabled = true;
            ListaVendasEmAberto.Location = new Point(12, 40);
            ListaVendasEmAberto.Margin = new Padding(3, 2, 3, 2);
            ListaVendasEmAberto.Name = "ListaVendasEmAberto";
            ListaVendasEmAberto.Size = new Size(372, 23);
            ListaVendasEmAberto.TabIndex = 72;
            ListaVendasEmAberto.SelectedIndexChanged += ListaVendasEmAberto_SelectedIndexChanged;
            // 
            // ClienteLabel
            // 
            ClienteLabel.AutoSize = true;
            ClienteLabel.Font = new Font("Segoe UI", 30F, FontStyle.Regular, GraphicsUnit.Point);
            ClienteLabel.Location = new Point(401, 39);
            ClienteLabel.Name = "ClienteLabel";
            ClienteLabel.Size = new Size(156, 54);
            ClienteLabel.TabIndex = 78;
            ClienteLabel.Text = "Cliente:";
            // 
            // EnderecoClienteLabel
            // 
            EnderecoClienteLabel.AutoSize = true;
            EnderecoClienteLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            EnderecoClienteLabel.Location = new Point(414, 181);
            EnderecoClienteLabel.Name = "EnderecoClienteLabel";
            EnderecoClienteLabel.Size = new Size(74, 21);
            EnderecoClienteLabel.TabIndex = 77;
            EnderecoClienteLabel.Text = "Endereço";
            // 
            // CpfCnpjClienteLabel
            // 
            CpfCnpjClienteLabel.AutoSize = true;
            CpfCnpjClienteLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            CpfCnpjClienteLabel.Location = new Point(414, 154);
            CpfCnpjClienteLabel.Name = "CpfCnpjClienteLabel";
            CpfCnpjClienteLabel.Size = new Size(66, 21);
            CpfCnpjClienteLabel.TabIndex = 76;
            CpfCnpjClienteLabel.Text = "CpfCnpj";
            // 
            // RgClienteLabel
            // 
            RgClienteLabel.AutoSize = true;
            RgClienteLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            RgClienteLabel.Location = new Point(414, 132);
            RgClienteLabel.Name = "RgClienteLabel";
            RgClienteLabel.Size = new Size(29, 21);
            RgClienteLabel.TabIndex = 75;
            RgClienteLabel.Text = "Rg";
            // 
            // NomeClienteLabel
            // 
            NomeClienteLabel.AutoSize = true;
            NomeClienteLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            NomeClienteLabel.Location = new Point(414, 95);
            NomeClienteLabel.Name = "NomeClienteLabel";
            NomeClienteLabel.Size = new Size(105, 21);
            NomeClienteLabel.TabIndex = 74;
            NomeClienteLabel.Text = "Nome Cliente";
            // 
            // TelefoneClienteLabel
            // 
            TelefoneClienteLabel.AutoSize = true;
            TelefoneClienteLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            TelefoneClienteLabel.Location = new Point(414, 220);
            TelefoneClienteLabel.Name = "TelefoneClienteLabel";
            TelefoneClienteLabel.Size = new Size(67, 21);
            TelefoneClienteLabel.TabIndex = 73;
            TelefoneClienteLabel.Text = "Telefone";
            // 
            // EditarVenda
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1329, 749);
            Controls.Add(ClienteLabel);
            Controls.Add(EnderecoClienteLabel);
            Controls.Add(CpfCnpjClienteLabel);
            Controls.Add(RgClienteLabel);
            Controls.Add(NomeClienteLabel);
            Controls.Add(TelefoneClienteLabel);
            Controls.Add(ListaVendasEmAberto);
            Controls.Add(ProdutoLabel);
            Controls.Add(NomeProdutoLabel);
            Controls.Add(PesquisarProdutoLabel);
            Controls.Add(AdicionarProdutoBox);
            Controls.Add(QuantidadeVendidaBox);
            Controls.Add(QuantidadeVendidaLabel);
            Controls.Add(CustoMedioLabel);
            Controls.Add(Descricao);
            Controls.Add(PrecoLabel);
            Controls.Add(QuantidadeDisponivelLabel);
            Controls.Add(ListaProdutos);
            Controls.Add(BuscarProdutoButton);
            Controls.Add(BuscarProdutoBox);
            Controls.Add(PrecoTotalVendaLabel);
            Controls.Add(ConcluirVenda);
            Controls.Add(ProdutoAdicionadosNaVendaLabel);
            Controls.Add(ProdutosNaVenda);
            Name = "EditarVenda";
            Text = "EditarVenda";
            ((System.ComponentModel.ISupportInitialize)ProdutosNaVenda).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label PrecoTotalVendaLabel;
        private Button ConcluirVenda;
        private Label ProdutoAdicionadosNaVendaLabel;
        private DataGridView ProdutosNaVenda;
        private DataGridViewTextBoxColumn IdProduto;
        private DataGridViewTextBoxColumn Nome;
        private DataGridViewTextBoxColumn Quantidade;
        private DataGridViewTextBoxColumn Preco;
        private DataGridViewTextBoxColumn ValorTotalProduto;
        private DataGridViewButtonColumn RemoverProduto;
        private Label ProdutoLabel;
        private Label NomeProdutoLabel;
        private Label PesquisarProdutoLabel;
        private Button AdicionarProdutoBox;
        private TextBox QuantidadeVendidaBox;
        private Label QuantidadeVendidaLabel;
        private Label CustoMedioLabel;
        private Label Descricao;
        private Label PrecoLabel;
        private Label QuantidadeDisponivelLabel;
        private ComboBox ListaProdutos;
        private Button BuscarProdutoButton;
        private TextBox BuscarProdutoBox;
        private ComboBox ListaVendasEmAberto;
        private Label ClienteLabel;
        private Label EnderecoClienteLabel;
        private Label CpfCnpjClienteLabel;
        private Label RgClienteLabel;
        private Label NomeClienteLabel;
        private Label TelefoneClienteLabel;
    }
}