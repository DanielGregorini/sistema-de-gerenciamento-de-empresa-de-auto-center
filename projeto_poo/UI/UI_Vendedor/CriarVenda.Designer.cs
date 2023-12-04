namespace AutoCenter
{
    partial class CriarVenda
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
            ProdutosNaVenda = new DataGridView();
            IdProduto = new DataGridViewTextBoxColumn();
            Nome = new DataGridViewTextBoxColumn();
            Quantidade = new DataGridViewTextBoxColumn();
            Preco = new DataGridViewTextBoxColumn();
            ValorTotalProduto = new DataGridViewTextBoxColumn();
            RemoverProduto = new DataGridViewButtonColumn();
            BuscarProdutoBox = new TextBox();
            BuscarProdutoButton = new Button();
            ListaProdutos = new ComboBox();
            TelefoneClienteLabel = new Label();
            QuantidadeDisponivelLabel = new Label();
            PrecoLabel = new Label();
            Descricao = new Label();
            CustoMedioLabel = new Label();
            QuantidadeVendidaLabel = new Label();
            QuantidadeVendidaBox = new TextBox();
            AdicionarProdutoBox = new Button();
            ClienteBox = new TextBox();
            PesquisarCliente = new Button();
            ListaClientes = new ComboBox();
            PesquisarClienteLabel = new Label();
            PesquisarProdutoLabel = new Label();
            NomeClienteLabel = new Label();
            RgClienteLabel = new Label();
            CpfCnpjClienteLabel = new Label();
            EnderecoClienteLabel = new Label();
            NomeProdutoLabel = new Label();
            ProdutoAdicionadosNaVendaLabel = new Label();
            ConcluirVenda = new Button();
            ProdutoLabel = new Label();
            ClienteLabel = new Label();
            PrecoTotalVendaLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)ProdutosNaVenda).BeginInit();
            SuspendLayout();
            // 
            // ProdutosNaVenda
            // 
            ProdutosNaVenda.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ProdutosNaVenda.Columns.AddRange(new DataGridViewColumn[] { IdProduto, Nome, Quantidade, Preco, ValorTotalProduto, RemoverProduto });
            ProdutosNaVenda.Location = new Point(699, 77);
            ProdutosNaVenda.Name = "ProdutosNaVenda";
            ProdutosNaVenda.RowHeadersWidth = 51;
            ProdutosNaVenda.RowTemplate.Height = 29;
            ProdutosNaVenda.Size = new Size(625, 538);
            ProdutosNaVenda.TabIndex = 0;
            ProdutosNaVenda.CellContentClick += ProdutosNaVenda_CellContentClick;
            // 
            // IdProduto
            // 
            IdProduto.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            IdProduto.HeaderText = "ID";
            IdProduto.MinimumWidth = 26;
            IdProduto.Name = "IdProduto";
            IdProduto.Width = 53;
            // 
            // Nome
            // 
            Nome.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            Nome.HeaderText = "Nome";
            Nome.MinimumWidth = 35;
            Nome.Name = "Nome";
            Nome.Width = 79;
            // 
            // Quantidade
            // 
            Quantidade.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            Quantidade.HeaderText = "Quantidade";
            Quantidade.MinimumWidth = 6;
            Quantidade.Name = "Quantidade";
            Quantidade.Width = 116;
            // 
            // Preco
            // 
            Preco.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            Preco.HeaderText = "Preço";
            Preco.MinimumWidth = 6;
            Preco.Name = "Preco";
            Preco.Width = 75;
            // 
            // ValorTotalProduto
            // 
            ValorTotalProduto.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            ValorTotalProduto.HeaderText = "Valor Total / Produto";
            ValorTotalProduto.MinimumWidth = 6;
            ValorTotalProduto.Name = "ValorTotalProduto";
            ValorTotalProduto.Width = 113;
            // 
            // RemoverProduto
            // 
            RemoverProduto.HeaderText = "Remover Produto";
            RemoverProduto.MinimumWidth = 6;
            RemoverProduto.Name = "RemoverProduto";
            RemoverProduto.Width = 125;
            // 
            // BuscarProdutoBox
            // 
            BuscarProdutoBox.Location = new Point(23, 424);
            BuscarProdutoBox.Name = "BuscarProdutoBox";
            BuscarProdutoBox.Size = new Size(259, 27);
            BuscarProdutoBox.TabIndex = 1;
            // 
            // BuscarProdutoButton
            // 
            BuscarProdutoButton.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            BuscarProdutoButton.Location = new Point(288, 424);
            BuscarProdutoButton.Name = "BuscarProdutoButton";
            BuscarProdutoButton.Size = new Size(90, 38);
            BuscarProdutoButton.TabIndex = 2;
            BuscarProdutoButton.Text = "Pesquisar";
            BuscarProdutoButton.UseVisualStyleBackColor = true;
            BuscarProdutoButton.Click += BuscarProdutoButton_Click;
            // 
            // ListaProdutos
            // 
            ListaProdutos.FormattingEnabled = true;
            ListaProdutos.Location = new Point(23, 490);
            ListaProdutos.Name = "ListaProdutos";
            ListaProdutos.Size = new Size(352, 28);
            ListaProdutos.TabIndex = 29;
            ListaProdutos.SelectedIndexChanged += ListaProdutos_SelectedIndexChanged;
            // 
            // TelefoneClienteLabel
            // 
            TelefoneClienteLabel.AutoSize = true;
            TelefoneClienteLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            TelefoneClienteLabel.Location = new Point(426, 250);
            TelefoneClienteLabel.Name = "TelefoneClienteLabel";
            TelefoneClienteLabel.Size = new Size(84, 28);
            TelefoneClienteLabel.TabIndex = 30;
            TelefoneClienteLabel.Text = "Telefone";
            // 
            // QuantidadeDisponivelLabel
            // 
            QuantidadeDisponivelLabel.AutoSize = true;
            QuantidadeDisponivelLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            QuantidadeDisponivelLabel.Location = new Point(426, 503);
            QuantidadeDisponivelLabel.Name = "QuantidadeDisponivelLabel";
            QuantidadeDisponivelLabel.Size = new Size(210, 28);
            QuantidadeDisponivelLabel.TabIndex = 31;
            QuantidadeDisponivelLabel.Text = "Quantidade disponivel";
            // 
            // PrecoLabel
            // 
            PrecoLabel.AutoSize = true;
            PrecoLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            PrecoLabel.Location = new Point(426, 464);
            PrecoLabel.Name = "PrecoLabel";
            PrecoLabel.Size = new Size(61, 28);
            PrecoLabel.TabIndex = 32;
            PrecoLabel.Text = "Preço";
            // 
            // Descricao
            // 
            Descricao.AutoSize = true;
            Descricao.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Descricao.Location = new Point(426, 415);
            Descricao.MaximumSize = new Size(300, 0);
            Descricao.Name = "Descricao";
            Descricao.Size = new Size(96, 28);
            Descricao.TabIndex = 33;
            Descricao.Text = "Descrição";
            // 
            // CustoMedioLabel
            // 
            CustoMedioLabel.AutoSize = true;
            CustoMedioLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            CustoMedioLabel.Location = new Point(426, 542);
            CustoMedioLabel.Name = "CustoMedioLabel";
            CustoMedioLabel.Size = new Size(124, 28);
            CustoMedioLabel.TabIndex = 34;
            CustoMedioLabel.Text = "Custo Medio";
            // 
            // QuantidadeVendidaLabel
            // 
            QuantidadeVendidaLabel.AutoSize = true;
            QuantidadeVendidaLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            QuantidadeVendidaLabel.Location = new Point(428, 583);
            QuantidadeVendidaLabel.Name = "QuantidadeVendidaLabel";
            QuantidadeVendidaLabel.Size = new Size(119, 28);
            QuantidadeVendidaLabel.TabIndex = 35;
            QuantidadeVendidaLabel.Text = "Quantidade:";
            // 
            // QuantidadeVendidaBox
            // 
            QuantidadeVendidaBox.Location = new Point(553, 583);
            QuantidadeVendidaBox.Name = "QuantidadeVendidaBox";
            QuantidadeVendidaBox.Size = new Size(104, 27);
            QuantidadeVendidaBox.TabIndex = 36;
            QuantidadeVendidaBox.KeyPress += QuantidadeVendidaBox_KeyPress;
            // 
            // AdicionarProdutoBox
            // 
            AdicionarProdutoBox.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            AdicionarProdutoBox.Location = new Point(426, 628);
            AdicionarProdutoBox.Name = "AdicionarProdutoBox";
            AdicionarProdutoBox.Size = new Size(199, 50);
            AdicionarProdutoBox.TabIndex = 37;
            AdicionarProdutoBox.Text = "Adicionar Produto";
            AdicionarProdutoBox.UseVisualStyleBackColor = true;
            AdicionarProdutoBox.Click += AdicionarProdutoBox_Click;
            // 
            // ClienteBox
            // 
            ClienteBox.Location = new Point(12, 94);
            ClienteBox.Name = "ClienteBox";
            ClienteBox.Size = new Size(270, 27);
            ClienteBox.TabIndex = 38;
            // 
            // PesquisarCliente
            // 
            PesquisarCliente.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            PesquisarCliente.Location = new Point(288, 94);
            PesquisarCliente.Name = "PesquisarCliente";
            PesquisarCliente.Size = new Size(90, 38);
            PesquisarCliente.TabIndex = 39;
            PesquisarCliente.Text = "Pesquisar";
            PesquisarCliente.UseVisualStyleBackColor = true;
            PesquisarCliente.Click += PesquisarCliente_Click;
            // 
            // ListaClientes
            // 
            ListaClientes.FormattingEnabled = true;
            ListaClientes.Location = new Point(12, 160);
            ListaClientes.Name = "ListaClientes";
            ListaClientes.Size = new Size(363, 28);
            ListaClientes.TabIndex = 40;
            ListaClientes.SelectedIndexChanged += ListaClientes_SelectedIndexChanged;
            // 
            // PesquisarClienteLabel
            // 
            PesquisarClienteLabel.AutoSize = true;
            PesquisarClienteLabel.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            PesquisarClienteLabel.Location = new Point(12, 35);
            PesquisarClienteLabel.Name = "PesquisarClienteLabel";
            PesquisarClienteLabel.Size = new Size(202, 35);
            PesquisarClienteLabel.TabIndex = 41;
            PesquisarClienteLabel.Text = "Pesquisar Cliente";
            // 
            // PesquisarProdutoLabel
            // 
            PesquisarProdutoLabel.AutoSize = true;
            PesquisarProdutoLabel.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            PesquisarProdutoLabel.Location = new Point(23, 370);
            PesquisarProdutoLabel.Name = "PesquisarProdutoLabel";
            PesquisarProdutoLabel.Size = new Size(217, 35);
            PesquisarProdutoLabel.TabIndex = 42;
            PesquisarProdutoLabel.Text = "Pesquisar Produto";
            // 
            // NomeClienteLabel
            // 
            NomeClienteLabel.AutoSize = true;
            NomeClienteLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            NomeClienteLabel.Location = new Point(426, 84);
            NomeClienteLabel.Name = "NomeClienteLabel";
            NomeClienteLabel.Size = new Size(131, 28);
            NomeClienteLabel.TabIndex = 43;
            NomeClienteLabel.Text = "Nome Cliente";
            // 
            // RgClienteLabel
            // 
            RgClienteLabel.AutoSize = true;
            RgClienteLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            RgClienteLabel.Location = new Point(426, 134);
            RgClienteLabel.Name = "RgClienteLabel";
            RgClienteLabel.Size = new Size(35, 28);
            RgClienteLabel.TabIndex = 44;
            RgClienteLabel.Text = "Rg";
            // 
            // CpfCnpjClienteLabel
            // 
            CpfCnpjClienteLabel.AutoSize = true;
            CpfCnpjClienteLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            CpfCnpjClienteLabel.Location = new Point(426, 162);
            CpfCnpjClienteLabel.Name = "CpfCnpjClienteLabel";
            CpfCnpjClienteLabel.Size = new Size(82, 28);
            CpfCnpjClienteLabel.TabIndex = 45;
            CpfCnpjClienteLabel.Text = "CpfCnpj";
            // 
            // EnderecoClienteLabel
            // 
            EnderecoClienteLabel.AutoSize = true;
            EnderecoClienteLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            EnderecoClienteLabel.Location = new Point(426, 199);
            EnderecoClienteLabel.Name = "EnderecoClienteLabel";
            EnderecoClienteLabel.Size = new Size(93, 28);
            EnderecoClienteLabel.TabIndex = 46;
            EnderecoClienteLabel.Text = "Endereço";
            // 
            // NomeProdutoLabel
            // 
            NomeProdutoLabel.AutoSize = true;
            NomeProdutoLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            NomeProdutoLabel.Location = new Point(426, 370);
            NomeProdutoLabel.Name = "NomeProdutoLabel";
            NomeProdutoLabel.Size = new Size(147, 28);
            NomeProdutoLabel.TabIndex = 47;
            NomeProdutoLabel.Text = "Nome Produto:";
            // 
            // ProdutoAdicionadosNaVendaLabel
            // 
            ProdutoAdicionadosNaVendaLabel.AutoSize = true;
            ProdutoAdicionadosNaVendaLabel.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            ProdutoAdicionadosNaVendaLabel.Location = new Point(742, 24);
            ProdutoAdicionadosNaVendaLabel.Name = "ProdutoAdicionadosNaVendaLabel";
            ProdutoAdicionadosNaVendaLabel.Size = new Size(474, 46);
            ProdutoAdicionadosNaVendaLabel.TabIndex = 48;
            ProdutoAdicionadosNaVendaLabel.Text = "Produtos adicionado na venda";
            // 
            // ConcluirVenda
            // 
            ConcluirVenda.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            ConcluirVenda.Location = new Point(998, 628);
            ConcluirVenda.Name = "ConcluirVenda";
            ConcluirVenda.Size = new Size(234, 59);
            ConcluirVenda.TabIndex = 49;
            ConcluirVenda.Text = "Concluir Venda";
            ConcluirVenda.UseVisualStyleBackColor = true;
            ConcluirVenda.Click += ConcluirVenda_Click;
            // 
            // ProdutoLabel
            // 
            ProdutoLabel.AutoSize = true;
            ProdutoLabel.Font = new Font("Segoe UI", 30F, FontStyle.Regular, GraphicsUnit.Point);
            ProdutoLabel.Location = new Point(426, 303);
            ProdutoLabel.Name = "ProdutoLabel";
            ProdutoLabel.Size = new Size(217, 67);
            ProdutoLabel.TabIndex = 50;
            ProdutoLabel.Text = "Produto:";
            // 
            // ClienteLabel
            // 
            ClienteLabel.AutoSize = true;
            ClienteLabel.Font = new Font("Segoe UI", 30F, FontStyle.Regular, GraphicsUnit.Point);
            ClienteLabel.Location = new Point(412, 9);
            ClienteLabel.Name = "ClienteLabel";
            ClienteLabel.Size = new Size(192, 67);
            ClienteLabel.TabIndex = 51;
            ClienteLabel.Text = "Cliente:";
            // 
            // PrecoTotalVendaLabel
            // 
            PrecoTotalVendaLabel.AutoSize = true;
            PrecoTotalVendaLabel.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            PrecoTotalVendaLabel.Location = new Point(699, 644);
            PrecoTotalVendaLabel.Name = "PrecoTotalVendaLabel";
            PrecoTotalVendaLabel.Size = new Size(143, 35);
            PrecoTotalVendaLabel.TabIndex = 52;
            PrecoTotalVendaLabel.Text = "Preço Total:";
            // 
            // CriarVenda
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1336, 727);
            Controls.Add(PrecoTotalVendaLabel);
            Controls.Add(ClienteLabel);
            Controls.Add(ProdutoLabel);
            Controls.Add(ConcluirVenda);
            Controls.Add(ProdutoAdicionadosNaVendaLabel);
            Controls.Add(NomeProdutoLabel);
            Controls.Add(EnderecoClienteLabel);
            Controls.Add(CpfCnpjClienteLabel);
            Controls.Add(RgClienteLabel);
            Controls.Add(NomeClienteLabel);
            Controls.Add(PesquisarProdutoLabel);
            Controls.Add(PesquisarClienteLabel);
            Controls.Add(ListaClientes);
            Controls.Add(PesquisarCliente);
            Controls.Add(ClienteBox);
            Controls.Add(AdicionarProdutoBox);
            Controls.Add(QuantidadeVendidaBox);
            Controls.Add(QuantidadeVendidaLabel);
            Controls.Add(CustoMedioLabel);
            Controls.Add(Descricao);
            Controls.Add(PrecoLabel);
            Controls.Add(QuantidadeDisponivelLabel);
            Controls.Add(TelefoneClienteLabel);
            Controls.Add(ListaProdutos);
            Controls.Add(BuscarProdutoButton);
            Controls.Add(BuscarProdutoBox);
            Controls.Add(ProdutosNaVenda);
            Name = "CriarVenda";
            Text = "CriarVenda";
            ((System.ComponentModel.ISupportInitialize)ProdutosNaVenda).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView ProdutosNaVenda;
        private TextBox BuscarProdutoBox;
        private Button BuscarProdutoButton;
        private ComboBox ListaProdutos;
        private Label TelefoneClienteLabel;
        private Label QuantidadeDisponivelLabel;
        private Label PrecoLabel;
        private Label Descricao;
        private Label CustoMedioLabel;
        private Label QuantidadeVendidaLabel;
        private TextBox QuantidadeVendidaBox;
        private Button AdicionarProdutoBox;
        private TextBox ClienteBox;
        private Button PesquisarCliente;
        private ComboBox ListaClientes;
        private Label PesquisarClienteLabel;
        private Label PesquisarProdutoLabel;
        private Label NomeClienteLabel;
        private Label RgClienteLabel;
        private Label CpfCnpjClienteLabel;
        private Label EnderecoClienteLabel;
        private Label NomeProdutoLabel;
        private Label ProdutoAdicionadosNaVendaLabel;
        private Button ConcluirVenda;
        private Label ProdutoLabel;
        private Label ClienteLabel;
        private DataGridViewTextBoxColumn IdProduto;
        private DataGridViewTextBoxColumn Nome;
        private DataGridViewTextBoxColumn Quantidade;
        private DataGridViewTextBoxColumn Preco;
        private DataGridViewTextBoxColumn ValorTotalProduto;
        private Label PrecoTotalVendaLabel;
        private DataGridViewButtonColumn RemoverProduto;
    }
}