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
            ProdutosNaVenda.Location = new Point(779, 56);
            ProdutosNaVenda.Margin = new Padding(3, 2, 3, 2);
            ProdutosNaVenda.Name = "ProdutosNaVenda";
            ProdutosNaVenda.RowHeadersWidth = 51;
            ProdutosNaVenda.RowTemplate.Height = 29;
            ProdutosNaVenda.Size = new Size(610, 559);
            ProdutosNaVenda.TabIndex = 0;
            ProdutosNaVenda.CellContentClick += ProdutosNaVenda_CellContentClick;
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
            // BuscarProdutoBox
            // 
            BuscarProdutoBox.Location = new Point(12, 366);
            BuscarProdutoBox.Margin = new Padding(3, 2, 3, 2);
            BuscarProdutoBox.Name = "BuscarProdutoBox";
            BuscarProdutoBox.Size = new Size(268, 23);
            BuscarProdutoBox.TabIndex = 1;
            // 
            // BuscarProdutoButton
            // 
            BuscarProdutoButton.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            BuscarProdutoButton.Location = new Point(286, 366);
            BuscarProdutoButton.Margin = new Padding(3, 2, 3, 2);
            BuscarProdutoButton.Name = "BuscarProdutoButton";
            BuscarProdutoButton.Size = new Size(79, 28);
            BuscarProdutoButton.TabIndex = 2;
            BuscarProdutoButton.Text = "Pesquisar";
            BuscarProdutoButton.UseVisualStyleBackColor = true;
            BuscarProdutoButton.Click += BuscarProdutoButton_Click;
            // 
            // ListaProdutos
            // 
            ListaProdutos.FormattingEnabled = true;
            ListaProdutos.Location = new Point(12, 416);
            ListaProdutos.Margin = new Padding(3, 2, 3, 2);
            ListaProdutos.Name = "ListaProdutos";
            ListaProdutos.Size = new Size(353, 23);
            ListaProdutos.TabIndex = 29;
            ListaProdutos.SelectedIndexChanged += ListaProdutos_SelectedIndexChanged;
            // 
            // TelefoneClienteLabel
            // 
            TelefoneClienteLabel.AutoSize = true;
            TelefoneClienteLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            TelefoneClienteLabel.Location = new Point(417, 207);
            TelefoneClienteLabel.Name = "TelefoneClienteLabel";
            TelefoneClienteLabel.Size = new Size(67, 21);
            TelefoneClienteLabel.TabIndex = 30;
            TelefoneClienteLabel.Text = "Telefone";
            // 
            // QuantidadeDisponivelLabel
            // 
            QuantidadeDisponivelLabel.AutoSize = true;
            QuantidadeDisponivelLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            QuantidadeDisponivelLabel.Location = new Point(404, 473);
            QuantidadeDisponivelLabel.Name = "QuantidadeDisponivelLabel";
            QuantidadeDisponivelLabel.Size = new Size(166, 21);
            QuantidadeDisponivelLabel.TabIndex = 31;
            QuantidadeDisponivelLabel.Text = "Quantidade disponivel";
            // 
            // PrecoLabel
            // 
            PrecoLabel.AutoSize = true;
            PrecoLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            PrecoLabel.Location = new Point(404, 444);
            PrecoLabel.Name = "PrecoLabel";
            PrecoLabel.Size = new Size(49, 21);
            PrecoLabel.TabIndex = 32;
            PrecoLabel.Text = "Preço";
            // 
            // Descricao
            // 
            Descricao.AutoSize = true;
            Descricao.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Descricao.Location = new Point(404, 401);
            Descricao.MaximumSize = new Size(262, 0);
            Descricao.Name = "Descricao";
            Descricao.Size = new Size(77, 21);
            Descricao.TabIndex = 33;
            Descricao.Text = "Descrição";
            // 
            // CustoMedioLabel
            // 
            CustoMedioLabel.AutoSize = true;
            CustoMedioLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            CustoMedioLabel.Location = new Point(404, 502);
            CustoMedioLabel.Name = "CustoMedioLabel";
            CustoMedioLabel.Size = new Size(98, 21);
            CustoMedioLabel.TabIndex = 34;
            CustoMedioLabel.Text = "Custo Medio";
            // 
            // QuantidadeVendidaLabel
            // 
            QuantidadeVendidaLabel.AutoSize = true;
            QuantidadeVendidaLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            QuantidadeVendidaLabel.Location = new Point(404, 531);
            QuantidadeVendidaLabel.Name = "QuantidadeVendidaLabel";
            QuantidadeVendidaLabel.Size = new Size(94, 21);
            QuantidadeVendidaLabel.TabIndex = 35;
            QuantidadeVendidaLabel.Text = "Quantidade:";
            // 
            // QuantidadeVendidaBox
            // 
            QuantidadeVendidaBox.Location = new Point(515, 533);
            QuantidadeVendidaBox.Margin = new Padding(3, 2, 3, 2);
            QuantidadeVendidaBox.Name = "QuantidadeVendidaBox";
            QuantidadeVendidaBox.Size = new Size(92, 23);
            QuantidadeVendidaBox.TabIndex = 36;
            QuantidadeVendidaBox.KeyPress += QuantidadeVendidaBox_KeyPress;
            // 
            // AdicionarProdutoBox
            // 
            AdicionarProdutoBox.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            AdicionarProdutoBox.Location = new Point(404, 567);
            AdicionarProdutoBox.Margin = new Padding(3, 2, 3, 2);
            AdicionarProdutoBox.Name = "AdicionarProdutoBox";
            AdicionarProdutoBox.Size = new Size(174, 38);
            AdicionarProdutoBox.TabIndex = 37;
            AdicionarProdutoBox.Text = "Adicionar Produto";
            AdicionarProdutoBox.UseVisualStyleBackColor = true;
            AdicionarProdutoBox.Click += AdicionarProdutoBox_Click;
            // 
            // ClienteBox
            // 
            ClienteBox.Location = new Point(10, 70);
            ClienteBox.Margin = new Padding(3, 2, 3, 2);
            ClienteBox.Name = "ClienteBox";
            ClienteBox.Size = new Size(287, 23);
            ClienteBox.TabIndex = 38;
            // 
            // PesquisarCliente
            // 
            PesquisarCliente.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            PesquisarCliente.Location = new Point(303, 70);
            PesquisarCliente.Margin = new Padding(3, 2, 3, 2);
            PesquisarCliente.Name = "PesquisarCliente";
            PesquisarCliente.Size = new Size(79, 28);
            PesquisarCliente.TabIndex = 39;
            PesquisarCliente.Text = "Pesquisar";
            PesquisarCliente.UseVisualStyleBackColor = true;
            PesquisarCliente.Click += PesquisarCliente_Click;
            // 
            // ListaClientes
            // 
            ListaClientes.FormattingEnabled = true;
            ListaClientes.Location = new Point(10, 120);
            ListaClientes.Margin = new Padding(3, 2, 3, 2);
            ListaClientes.Name = "ListaClientes";
            ListaClientes.Size = new Size(372, 23);
            ListaClientes.TabIndex = 40;
            ListaClientes.SelectedIndexChanged += ListaClientes_SelectedIndexChanged;
            // 
            // PesquisarClienteLabel
            // 
            PesquisarClienteLabel.AutoSize = true;
            PesquisarClienteLabel.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            PesquisarClienteLabel.Location = new Point(10, 26);
            PesquisarClienteLabel.Name = "PesquisarClienteLabel";
            PesquisarClienteLabel.Size = new Size(158, 28);
            PesquisarClienteLabel.TabIndex = 41;
            PesquisarClienteLabel.Text = "Pesquisar Cliente";
            // 
            // PesquisarProdutoLabel
            // 
            PesquisarProdutoLabel.AutoSize = true;
            PesquisarProdutoLabel.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            PesquisarProdutoLabel.Location = new Point(12, 326);
            PesquisarProdutoLabel.Name = "PesquisarProdutoLabel";
            PesquisarProdutoLabel.Size = new Size(170, 28);
            PesquisarProdutoLabel.TabIndex = 42;
            PesquisarProdutoLabel.Text = "Pesquisar Produto";
            // 
            // NomeClienteLabel
            // 
            NomeClienteLabel.AutoSize = true;
            NomeClienteLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            NomeClienteLabel.Location = new Point(417, 82);
            NomeClienteLabel.Name = "NomeClienteLabel";
            NomeClienteLabel.Size = new Size(105, 21);
            NomeClienteLabel.TabIndex = 43;
            NomeClienteLabel.Text = "Nome Cliente";
            // 
            // RgClienteLabel
            // 
            RgClienteLabel.AutoSize = true;
            RgClienteLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            RgClienteLabel.Location = new Point(417, 119);
            RgClienteLabel.Name = "RgClienteLabel";
            RgClienteLabel.Size = new Size(29, 21);
            RgClienteLabel.TabIndex = 44;
            RgClienteLabel.Text = "Rg";
            // 
            // CpfCnpjClienteLabel
            // 
            CpfCnpjClienteLabel.AutoSize = true;
            CpfCnpjClienteLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            CpfCnpjClienteLabel.Location = new Point(417, 141);
            CpfCnpjClienteLabel.Name = "CpfCnpjClienteLabel";
            CpfCnpjClienteLabel.Size = new Size(66, 21);
            CpfCnpjClienteLabel.TabIndex = 45;
            CpfCnpjClienteLabel.Text = "CpfCnpj";
            // 
            // EnderecoClienteLabel
            // 
            EnderecoClienteLabel.AutoSize = true;
            EnderecoClienteLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            EnderecoClienteLabel.Location = new Point(417, 168);
            EnderecoClienteLabel.Name = "EnderecoClienteLabel";
            EnderecoClienteLabel.Size = new Size(74, 21);
            EnderecoClienteLabel.TabIndex = 46;
            EnderecoClienteLabel.Text = "Endereço";
            // 
            // NomeProdutoLabel
            // 
            NomeProdutoLabel.AutoSize = true;
            NomeProdutoLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            NomeProdutoLabel.Location = new Point(404, 369);
            NomeProdutoLabel.Name = "NomeProdutoLabel";
            NomeProdutoLabel.Size = new Size(116, 21);
            NomeProdutoLabel.TabIndex = 47;
            NomeProdutoLabel.Text = "Nome Produto:";
            // 
            // ProdutoAdicionadosNaVendaLabel
            // 
            ProdutoAdicionadosNaVendaLabel.AutoSize = true;
            ProdutoAdicionadosNaVendaLabel.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            ProdutoAdicionadosNaVendaLabel.Location = new Point(798, 17);
            ProdutoAdicionadosNaVendaLabel.Name = "ProdutoAdicionadosNaVendaLabel";
            ProdutoAdicionadosNaVendaLabel.Size = new Size(379, 37);
            ProdutoAdicionadosNaVendaLabel.TabIndex = 48;
            ProdutoAdicionadosNaVendaLabel.Text = "Produtos adicionado na venda";
            // 
            // ConcluirVenda
            // 
            ConcluirVenda.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            ConcluirVenda.Location = new Point(1041, 633);
            ConcluirVenda.Margin = new Padding(3, 2, 3, 2);
            ConcluirVenda.Name = "ConcluirVenda";
            ConcluirVenda.Size = new Size(205, 44);
            ConcluirVenda.TabIndex = 49;
            ConcluirVenda.Text = "Concluir Venda";
            ConcluirVenda.UseVisualStyleBackColor = true;
            ConcluirVenda.Click += ConcluirVenda_Click;
            // 
            // ProdutoLabel
            // 
            ProdutoLabel.AutoSize = true;
            ProdutoLabel.Font = new Font("Segoe UI", 30F, FontStyle.Regular, GraphicsUnit.Point);
            ProdutoLabel.Location = new Point(395, 306);
            ProdutoLabel.Name = "ProdutoLabel";
            ProdutoLabel.Size = new Size(175, 54);
            ProdutoLabel.TabIndex = 50;
            ProdutoLabel.Text = "Produto:";
            // 
            // ClienteLabel
            // 
            ClienteLabel.AutoSize = true;
            ClienteLabel.Font = new Font("Segoe UI", 30F, FontStyle.Regular, GraphicsUnit.Point);
            ClienteLabel.Location = new Point(404, 26);
            ClienteLabel.Name = "ClienteLabel";
            ClienteLabel.Size = new Size(156, 54);
            ClienteLabel.TabIndex = 51;
            ClienteLabel.Text = "Cliente:";
            // 
            // PrecoTotalVendaLabel
            // 
            PrecoTotalVendaLabel.AutoSize = true;
            PrecoTotalVendaLabel.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            PrecoTotalVendaLabel.Location = new Point(779, 633);
            PrecoTotalVendaLabel.Name = "PrecoTotalVendaLabel";
            PrecoTotalVendaLabel.Size = new Size(112, 28);
            PrecoTotalVendaLabel.TabIndex = 52;
            PrecoTotalVendaLabel.Text = "Preço Total:";
            // 
            // CriarVenda
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1401, 692);
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
            Margin = new Padding(3, 2, 3, 2);
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