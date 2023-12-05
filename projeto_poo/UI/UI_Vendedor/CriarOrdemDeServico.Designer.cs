namespace AutoCenter
{ 
    partial class CriarOrdemDeServico
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
            ClienteLabel = new Label();
            EnderecoClienteLabel = new Label();
            CpfCnpjClienteLabel = new Label();
            RgClienteLabel = new Label();
            NomeClienteLabel = new Label();
            PesquisarClienteLabel = new Label();
            ListaClientes = new ComboBox();
            PesquisarCliente = new Button();
            ClienteBox = new TextBox();
            TelefoneClienteLabel = new Label();
            ListaDeVeiculos = new ComboBox();
            SelecionarVeiculoLabel = new Label();
            TipoVeiculoLabel = new Label();
            ModeloVeiculoLabel = new Label();
            PlacaVeiculoLabel = new Label();
            CriarNovoVeiculoLabel = new Label();
            VeiculoLabel = new Label();
            TipoVeiculoBox = new TextBox();
            ModeloVeiculoBox = new TextBox();
            PlacaVeiculoBox = new TextBox();
            PlacaCarroLabel = new Label();
            ModelVeiculoLabel = new Label();
            TipoVeiculoBoxLabel = new Label();
            CriarVeiculoButton = new Button();
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
            ProdutosNaOrdemDeServico = new DataGridView();
            IdProduto = new DataGridViewTextBoxColumn();
            Nome = new DataGridViewTextBoxColumn();
            Quantidade = new DataGridViewTextBoxColumn();
            Preco = new DataGridViewTextBoxColumn();
            ValorTotalProduto = new DataGridViewTextBoxColumn();
            RemoverProduto = new DataGridViewButtonColumn();
            PrecoTotalVendaLabel = new Label();
            ConcluirVenda = new Button();
            ProdutoAdicionadosNaODSLabel = new Label();
            OrdemDeServicoInfoLabel = new Label();
            TipoDeServicoLabel = new Label();
            TipoDeServicoBox = new TextBox();
            DescricaoServicoLabel = new Label();
            DescricaoServicoBox = new TextBox();
            DataDeEntregaServicoBox = new DateTimePicker();
            HorarioDeEntregaLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)ProdutosNaOrdemDeServico).BeginInit();
            SuspendLayout();
            // 
            // ClienteLabel
            // 
            ClienteLabel.AutoSize = true;
            ClienteLabel.Font = new Font("Segoe UI", 30F, FontStyle.Regular, GraphicsUnit.Point);
            ClienteLabel.Location = new Point(406, 9);
            ClienteLabel.Name = "ClienteLabel";
            ClienteLabel.Size = new Size(156, 54);
            ClienteLabel.TabIndex = 61;
            ClienteLabel.Text = "Cliente:";
            // 
            // EnderecoClienteLabel
            // 
            EnderecoClienteLabel.AutoSize = true;
            EnderecoClienteLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            EnderecoClienteLabel.Location = new Point(419, 151);
            EnderecoClienteLabel.Name = "EnderecoClienteLabel";
            EnderecoClienteLabel.Size = new Size(74, 21);
            EnderecoClienteLabel.TabIndex = 60;
            EnderecoClienteLabel.Text = "Endereço";
            // 
            // CpfCnpjClienteLabel
            // 
            CpfCnpjClienteLabel.AutoSize = true;
            CpfCnpjClienteLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            CpfCnpjClienteLabel.Location = new Point(419, 124);
            CpfCnpjClienteLabel.Name = "CpfCnpjClienteLabel";
            CpfCnpjClienteLabel.Size = new Size(66, 21);
            CpfCnpjClienteLabel.TabIndex = 59;
            CpfCnpjClienteLabel.Text = "CpfCnpj";
            // 
            // RgClienteLabel
            // 
            RgClienteLabel.AutoSize = true;
            RgClienteLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            RgClienteLabel.Location = new Point(419, 102);
            RgClienteLabel.Name = "RgClienteLabel";
            RgClienteLabel.Size = new Size(29, 21);
            RgClienteLabel.TabIndex = 58;
            RgClienteLabel.Text = "Rg";
            // 
            // NomeClienteLabel
            // 
            NomeClienteLabel.AutoSize = true;
            NomeClienteLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            NomeClienteLabel.Location = new Point(419, 65);
            NomeClienteLabel.Name = "NomeClienteLabel";
            NomeClienteLabel.Size = new Size(105, 21);
            NomeClienteLabel.TabIndex = 57;
            NomeClienteLabel.Text = "Nome Cliente";
            // 
            // PesquisarClienteLabel
            // 
            PesquisarClienteLabel.AutoSize = true;
            PesquisarClienteLabel.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            PesquisarClienteLabel.Location = new Point(13, 23);
            PesquisarClienteLabel.Name = "PesquisarClienteLabel";
            PesquisarClienteLabel.Size = new Size(158, 28);
            PesquisarClienteLabel.TabIndex = 56;
            PesquisarClienteLabel.Text = "Pesquisar Cliente";
            // 
            // ListaClientes
            // 
            ListaClientes.FormattingEnabled = true;
            ListaClientes.Location = new Point(12, 103);
            ListaClientes.Margin = new Padding(3, 2, 3, 2);
            ListaClientes.Name = "ListaClientes";
            ListaClientes.Size = new Size(372, 23);
            ListaClientes.TabIndex = 55;
            ListaClientes.SelectedIndexChanged += ListaClientes_SelectedIndexChanged;
            // 
            // PesquisarCliente
            // 
            PesquisarCliente.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            PesquisarCliente.Location = new Point(305, 53);
            PesquisarCliente.Margin = new Padding(3, 2, 3, 2);
            PesquisarCliente.Name = "PesquisarCliente";
            PesquisarCliente.Size = new Size(79, 28);
            PesquisarCliente.TabIndex = 54;
            PesquisarCliente.Text = "Pesquisar";
            PesquisarCliente.UseVisualStyleBackColor = true;
            PesquisarCliente.Click += PesquisarCliente_Click;
            // 
            // ClienteBox
            // 
            ClienteBox.Location = new Point(12, 53);
            ClienteBox.Margin = new Padding(3, 2, 3, 2);
            ClienteBox.Name = "ClienteBox";
            ClienteBox.Size = new Size(287, 23);
            ClienteBox.TabIndex = 53;
            // 
            // TelefoneClienteLabel
            // 
            TelefoneClienteLabel.AutoSize = true;
            TelefoneClienteLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            TelefoneClienteLabel.Location = new Point(419, 190);
            TelefoneClienteLabel.Name = "TelefoneClienteLabel";
            TelefoneClienteLabel.Size = new Size(67, 21);
            TelefoneClienteLabel.TabIndex = 52;
            TelefoneClienteLabel.Text = "Telefone";
            // 
            // ListaDeVeiculos
            // 
            ListaDeVeiculos.FormattingEnabled = true;
            ListaDeVeiculos.Location = new Point(12, 188);
            ListaDeVeiculos.Margin = new Padding(3, 2, 3, 2);
            ListaDeVeiculos.Name = "ListaDeVeiculos";
            ListaDeVeiculos.Size = new Size(372, 23);
            ListaDeVeiculos.TabIndex = 62;
            ListaDeVeiculos.SelectedIndexChanged += ListaDeVeiculos_SelectedIndexChanged;
            // 
            // SelecionarVeiculoLabel
            // 
            SelecionarVeiculoLabel.AutoSize = true;
            SelecionarVeiculoLabel.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            SelecionarVeiculoLabel.Location = new Point(12, 144);
            SelecionarVeiculoLabel.Name = "SelecionarVeiculoLabel";
            SelecionarVeiculoLabel.Size = new Size(170, 28);
            SelecionarVeiculoLabel.TabIndex = 63;
            SelecionarVeiculoLabel.Text = "Selecionar Veículo";
            // 
            // TipoVeiculoLabel
            // 
            TipoVeiculoLabel.AutoSize = true;
            TipoVeiculoLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            TipoVeiculoLabel.Location = new Point(419, 296);
            TipoVeiculoLabel.Name = "TipoVeiculoLabel";
            TipoVeiculoLabel.Size = new Size(43, 21);
            TipoVeiculoLabel.TabIndex = 64;
            TipoVeiculoLabel.Text = "Tipo:";
            // 
            // ModeloVeiculoLabel
            // 
            ModeloVeiculoLabel.AutoSize = true;
            ModeloVeiculoLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            ModeloVeiculoLabel.Location = new Point(419, 317);
            ModeloVeiculoLabel.Name = "ModeloVeiculoLabel";
            ModeloVeiculoLabel.Size = new Size(63, 21);
            ModeloVeiculoLabel.TabIndex = 65;
            ModeloVeiculoLabel.Text = "Modelo";
            // 
            // PlacaVeiculoLabel
            // 
            PlacaVeiculoLabel.AutoSize = true;
            PlacaVeiculoLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            PlacaVeiculoLabel.Location = new Point(419, 338);
            PlacaVeiculoLabel.Name = "PlacaVeiculoLabel";
            PlacaVeiculoLabel.Size = new Size(49, 21);
            PlacaVeiculoLabel.TabIndex = 66;
            PlacaVeiculoLabel.Text = "Placa:";
            // 
            // CriarNovoVeiculoLabel
            // 
            CriarNovoVeiculoLabel.AutoSize = true;
            CriarNovoVeiculoLabel.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            CriarNovoVeiculoLabel.Location = new Point(12, 232);
            CriarNovoVeiculoLabel.Name = "CriarNovoVeiculoLabel";
            CriarNovoVeiculoLabel.Size = new Size(237, 37);
            CriarNovoVeiculoLabel.TabIndex = 67;
            CriarNovoVeiculoLabel.Text = "Criar novo veiculo:";
            // 
            // VeiculoLabel
            // 
            VeiculoLabel.AutoSize = true;
            VeiculoLabel.Font = new Font("Segoe UI", 30F, FontStyle.Regular, GraphicsUnit.Point);
            VeiculoLabel.Location = new Point(419, 232);
            VeiculoLabel.Name = "VeiculoLabel";
            VeiculoLabel.Size = new Size(159, 54);
            VeiculoLabel.TabIndex = 68;
            VeiculoLabel.Text = "Veículo:";
            // 
            // TipoVeiculoBox
            // 
            TipoVeiculoBox.Location = new Point(82, 286);
            TipoVeiculoBox.Name = "TipoVeiculoBox";
            TipoVeiculoBox.Size = new Size(140, 23);
            TipoVeiculoBox.TabIndex = 70;
            // 
            // ModeloVeiculoBox
            // 
            ModeloVeiculoBox.Location = new Point(82, 315);
            ModeloVeiculoBox.Name = "ModeloVeiculoBox";
            ModeloVeiculoBox.Size = new Size(140, 23);
            ModeloVeiculoBox.TabIndex = 71;
            // 
            // PlacaVeiculoBox
            // 
            PlacaVeiculoBox.Location = new Point(82, 355);
            PlacaVeiculoBox.Name = "PlacaVeiculoBox";
            PlacaVeiculoBox.Size = new Size(100, 23);
            PlacaVeiculoBox.TabIndex = 72;
            // 
            // PlacaCarroLabel
            // 
            PlacaCarroLabel.AutoSize = true;
            PlacaCarroLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            PlacaCarroLabel.Location = new Point(24, 357);
            PlacaCarroLabel.Name = "PlacaCarroLabel";
            PlacaCarroLabel.Size = new Size(49, 21);
            PlacaCarroLabel.TabIndex = 75;
            PlacaCarroLabel.Text = "Placa:";
            // 
            // ModelVeiculoLabel
            // 
            ModelVeiculoLabel.AutoSize = true;
            ModelVeiculoLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            ModelVeiculoLabel.Location = new Point(13, 317);
            ModelVeiculoLabel.Name = "ModelVeiculoLabel";
            ModelVeiculoLabel.Size = new Size(63, 21);
            ModelVeiculoLabel.TabIndex = 74;
            ModelVeiculoLabel.Text = "Modelo";
            // 
            // TipoVeiculoBoxLabel
            // 
            TipoVeiculoBoxLabel.AutoSize = true;
            TipoVeiculoBoxLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            TipoVeiculoBoxLabel.Location = new Point(30, 284);
            TipoVeiculoBoxLabel.Name = "TipoVeiculoBoxLabel";
            TipoVeiculoBoxLabel.Size = new Size(43, 21);
            TipoVeiculoBoxLabel.TabIndex = 73;
            TipoVeiculoBoxLabel.Text = "Tipo:";
            // 
            // CriarVeiculoButton
            // 
            CriarVeiculoButton.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            CriarVeiculoButton.Location = new Point(54, 390);
            CriarVeiculoButton.Name = "CriarVeiculoButton";
            CriarVeiculoButton.Size = new Size(128, 33);
            CriarVeiculoButton.TabIndex = 76;
            CriarVeiculoButton.Text = "Criar veículo";
            CriarVeiculoButton.UseVisualStyleBackColor = true;
            CriarVeiculoButton.Click += CriarVeiculoButton_Click;
            // 
            // ProdutoLabel
            // 
            ProdutoLabel.AutoSize = true;
            ProdutoLabel.Font = new Font("Segoe UI", 30F, FontStyle.Regular, GraphicsUnit.Point);
            ProdutoLabel.Location = new Point(419, 390);
            ProdutoLabel.Name = "ProdutoLabel";
            ProdutoLabel.Size = new Size(175, 54);
            ProdutoLabel.TabIndex = 89;
            ProdutoLabel.Text = "Produto:";
            // 
            // NomeProdutoLabel
            // 
            NomeProdutoLabel.AutoSize = true;
            NomeProdutoLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            NomeProdutoLabel.Location = new Point(428, 453);
            NomeProdutoLabel.Name = "NomeProdutoLabel";
            NomeProdutoLabel.Size = new Size(116, 21);
            NomeProdutoLabel.TabIndex = 88;
            NomeProdutoLabel.Text = "Nome Produto:";
            // 
            // PesquisarProdutoLabel
            // 
            PesquisarProdutoLabel.AutoSize = true;
            PesquisarProdutoLabel.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            PesquisarProdutoLabel.Location = new Point(13, 446);
            PesquisarProdutoLabel.Name = "PesquisarProdutoLabel";
            PesquisarProdutoLabel.Size = new Size(170, 28);
            PesquisarProdutoLabel.TabIndex = 87;
            PesquisarProdutoLabel.Text = "Pesquisar Produto";
            // 
            // AdicionarProdutoBox
            // 
            AdicionarProdutoBox.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            AdicionarProdutoBox.Location = new Point(442, 654);
            AdicionarProdutoBox.Margin = new Padding(3, 2, 3, 2);
            AdicionarProdutoBox.Name = "AdicionarProdutoBox";
            AdicionarProdutoBox.Size = new Size(174, 38);
            AdicionarProdutoBox.TabIndex = 86;
            AdicionarProdutoBox.Text = "Adicionar Produto";
            AdicionarProdutoBox.UseVisualStyleBackColor = true;
            AdicionarProdutoBox.Click += AdicionarProdutoBox_Click;
            // 
            // QuantidadeVendidaBox
            // 
            QuantidadeVendidaBox.Location = new Point(539, 617);
            QuantidadeVendidaBox.Margin = new Padding(3, 2, 3, 2);
            QuantidadeVendidaBox.Name = "QuantidadeVendidaBox";
            QuantidadeVendidaBox.Size = new Size(92, 23);
            QuantidadeVendidaBox.TabIndex = 85;
            QuantidadeVendidaBox.KeyPress += QuantidadeVendidaBox_KeyPress;
            // 
            // QuantidadeVendidaLabel
            // 
            QuantidadeVendidaLabel.AutoSize = true;
            QuantidadeVendidaLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            QuantidadeVendidaLabel.Location = new Point(428, 615);
            QuantidadeVendidaLabel.Name = "QuantidadeVendidaLabel";
            QuantidadeVendidaLabel.Size = new Size(94, 21);
            QuantidadeVendidaLabel.TabIndex = 84;
            QuantidadeVendidaLabel.Text = "Quantidade:";
            // 
            // CustoMedioLabel
            // 
            CustoMedioLabel.AutoSize = true;
            CustoMedioLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            CustoMedioLabel.Location = new Point(428, 586);
            CustoMedioLabel.Name = "CustoMedioLabel";
            CustoMedioLabel.Size = new Size(98, 21);
            CustoMedioLabel.TabIndex = 83;
            CustoMedioLabel.Text = "Custo Medio";
            // 
            // Descricao
            // 
            Descricao.AutoSize = true;
            Descricao.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Descricao.Location = new Point(428, 485);
            Descricao.MaximumSize = new Size(262, 0);
            Descricao.Name = "Descricao";
            Descricao.Size = new Size(77, 21);
            Descricao.TabIndex = 82;
            Descricao.Text = "Descrição";
            // 
            // PrecoLabel
            // 
            PrecoLabel.AutoSize = true;
            PrecoLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            PrecoLabel.Location = new Point(428, 528);
            PrecoLabel.Name = "PrecoLabel";
            PrecoLabel.Size = new Size(49, 21);
            PrecoLabel.TabIndex = 81;
            PrecoLabel.Text = "Preço";
            // 
            // QuantidadeDisponivelLabel
            // 
            QuantidadeDisponivelLabel.AutoSize = true;
            QuantidadeDisponivelLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            QuantidadeDisponivelLabel.Location = new Point(428, 557);
            QuantidadeDisponivelLabel.Name = "QuantidadeDisponivelLabel";
            QuantidadeDisponivelLabel.Size = new Size(166, 21);
            QuantidadeDisponivelLabel.TabIndex = 80;
            QuantidadeDisponivelLabel.Text = "Quantidade disponivel";
            // 
            // ListaProdutos
            // 
            ListaProdutos.FormattingEnabled = true;
            ListaProdutos.Location = new Point(12, 526);
            ListaProdutos.Margin = new Padding(3, 2, 3, 2);
            ListaProdutos.Name = "ListaProdutos";
            ListaProdutos.Size = new Size(353, 23);
            ListaProdutos.TabIndex = 79;
            ListaProdutos.SelectedIndexChanged += ListaProdutos_SelectedIndexChanged;
            // 
            // BuscarProdutoButton
            // 
            BuscarProdutoButton.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            BuscarProdutoButton.Location = new Point(287, 486);
            BuscarProdutoButton.Margin = new Padding(3, 2, 3, 2);
            BuscarProdutoButton.Name = "BuscarProdutoButton";
            BuscarProdutoButton.Size = new Size(79, 28);
            BuscarProdutoButton.TabIndex = 78;
            BuscarProdutoButton.Text = "Pesquisar";
            BuscarProdutoButton.UseVisualStyleBackColor = true;
            BuscarProdutoButton.Click += BuscarProdutoButton_Click;
            // 
            // BuscarProdutoBox
            // 
            BuscarProdutoBox.Location = new Point(13, 486);
            BuscarProdutoBox.Margin = new Padding(3, 2, 3, 2);
            BuscarProdutoBox.Name = "BuscarProdutoBox";
            BuscarProdutoBox.Size = new Size(268, 23);
            BuscarProdutoBox.TabIndex = 77;
            // 
            // ProdutosNaOrdemDeServico
            // 
            ProdutosNaOrdemDeServico.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ProdutosNaOrdemDeServico.Columns.AddRange(new DataGridViewColumn[] { IdProduto, Nome, Quantidade, Preco, ValorTotalProduto, RemoverProduto });
            ProdutosNaOrdemDeServico.Location = new Point(759, 103);
            ProdutosNaOrdemDeServico.Margin = new Padding(3, 2, 3, 2);
            ProdutosNaOrdemDeServico.Name = "ProdutosNaOrdemDeServico";
            ProdutosNaOrdemDeServico.RowHeadersWidth = 51;
            ProdutosNaOrdemDeServico.RowTemplate.Height = 29;
            ProdutosNaOrdemDeServico.Size = new Size(659, 589);
            ProdutosNaOrdemDeServico.TabIndex = 90;
            ProdutosNaOrdemDeServico.CellContentClick += ProdutosNaOrdemDeServico_CellContentClick;
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
            // PrecoTotalVendaLabel
            // 
            PrecoTotalVendaLabel.AutoSize = true;
            PrecoTotalVendaLabel.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            PrecoTotalVendaLabel.Location = new Point(718, 707);
            PrecoTotalVendaLabel.Name = "PrecoTotalVendaLabel";
            PrecoTotalVendaLabel.Size = new Size(112, 28);
            PrecoTotalVendaLabel.TabIndex = 92;
            PrecoTotalVendaLabel.Text = "Preço Total:";
            // 
            // ConcluirVenda
            // 
            ConcluirVenda.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            ConcluirVenda.Location = new Point(987, 707);
            ConcluirVenda.Margin = new Padding(3, 2, 3, 2);
            ConcluirVenda.Name = "ConcluirVenda";
            ConcluirVenda.Size = new Size(205, 44);
            ConcluirVenda.TabIndex = 91;
            ConcluirVenda.Text = "Concluir ODS";
            ConcluirVenda.UseVisualStyleBackColor = true;
            ConcluirVenda.Click += ConcluirVenda_Click;
            // 
            // ProdutoAdicionadosNaODSLabel
            // 
            ProdutoAdicionadosNaODSLabel.AutoSize = true;
            ProdutoAdicionadosNaODSLabel.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            ProdutoAdicionadosNaODSLabel.Location = new Point(759, 65);
            ProdutoAdicionadosNaODSLabel.Name = "ProdutoAdicionadosNaODSLabel";
            ProdutoAdicionadosNaODSLabel.Size = new Size(536, 37);
            ProdutoAdicionadosNaODSLabel.TabIndex = 93;
            ProdutoAdicionadosNaODSLabel.Text = "Produtos adicionados na Oridem de Serviço";
            // 
            // OrdemDeServicoInfoLabel
            // 
            OrdemDeServicoInfoLabel.AutoSize = true;
            OrdemDeServicoInfoLabel.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            OrdemDeServicoInfoLabel.Location = new Point(10, 599);
            OrdemDeServicoInfoLabel.Name = "OrdemDeServicoInfoLabel";
            OrdemDeServicoInfoLabel.Size = new Size(173, 28);
            OrdemDeServicoInfoLabel.TabIndex = 94;
            OrdemDeServicoInfoLabel.Text = "Ordem de Serviço:";
            // 
            // TipoDeServicoLabel
            // 
            TipoDeServicoLabel.AutoSize = true;
            TipoDeServicoLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            TipoDeServicoLabel.Location = new Point(25, 641);
            TipoDeServicoLabel.Name = "TipoDeServicoLabel";
            TipoDeServicoLabel.Size = new Size(119, 21);
            TipoDeServicoLabel.TabIndex = 96;
            TipoDeServicoLabel.Text = "Tipo de Serviço:";
            // 
            // TipoDeServicoBox
            // 
            TipoDeServicoBox.Location = new Point(168, 641);
            TipoDeServicoBox.Multiline = true;
            TipoDeServicoBox.Name = "TipoDeServicoBox";
            TipoDeServicoBox.Size = new Size(221, 35);
            TipoDeServicoBox.TabIndex = 95;
            // 
            // DescricaoServicoLabel
            // 
            DescricaoServicoLabel.AutoSize = true;
            DescricaoServicoLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            DescricaoServicoLabel.Location = new Point(24, 698);
            DescricaoServicoLabel.Name = "DescricaoServicoLabel";
            DescricaoServicoLabel.Size = new Size(133, 21);
            DescricaoServicoLabel.TabIndex = 97;
            DescricaoServicoLabel.Text = "Descrição serviço:";
            // 
            // DescricaoServicoBox
            // 
            DescricaoServicoBox.Location = new Point(168, 682);
            DescricaoServicoBox.Multiline = true;
            DescricaoServicoBox.Name = "DescricaoServicoBox";
            DescricaoServicoBox.Size = new Size(216, 41);
            DescricaoServicoBox.TabIndex = 98;
            // 
            // DataDeEntregaServicoBox
            // 
            DataDeEntregaServicoBox.Location = new Point(163, 748);
            DataDeEntregaServicoBox.Name = "DataDeEntregaServicoBox";
            DataDeEntregaServicoBox.Size = new Size(236, 23);
            DataDeEntregaServicoBox.TabIndex = 99;
            // 
            // HorarioDeEntregaLabel
            // 
            HorarioDeEntregaLabel.AutoSize = true;
            HorarioDeEntregaLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            HorarioDeEntregaLabel.Location = new Point(13, 750);
            HorarioDeEntregaLabel.Name = "HorarioDeEntregaLabel";
            HorarioDeEntregaLabel.Size = new Size(144, 21);
            HorarioDeEntregaLabel.TabIndex = 100;
            HorarioDeEntregaLabel.Text = "Horário de entrega:";
            // 
            // CriarOrdemDeServico
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1430, 802);
            Controls.Add(HorarioDeEntregaLabel);
            Controls.Add(DataDeEntregaServicoBox);
            Controls.Add(DescricaoServicoBox);
            Controls.Add(DescricaoServicoLabel);
            Controls.Add(TipoDeServicoLabel);
            Controls.Add(TipoDeServicoBox);
            Controls.Add(OrdemDeServicoInfoLabel);
            Controls.Add(ProdutoAdicionadosNaODSLabel);
            Controls.Add(PrecoTotalVendaLabel);
            Controls.Add(ConcluirVenda);
            Controls.Add(ProdutosNaOrdemDeServico);
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
            Controls.Add(CriarVeiculoButton);
            Controls.Add(PlacaCarroLabel);
            Controls.Add(ModelVeiculoLabel);
            Controls.Add(TipoVeiculoBoxLabel);
            Controls.Add(PlacaVeiculoBox);
            Controls.Add(ModeloVeiculoBox);
            Controls.Add(TipoVeiculoBox);
            Controls.Add(VeiculoLabel);
            Controls.Add(CriarNovoVeiculoLabel);
            Controls.Add(PlacaVeiculoLabel);
            Controls.Add(ModeloVeiculoLabel);
            Controls.Add(TipoVeiculoLabel);
            Controls.Add(SelecionarVeiculoLabel);
            Controls.Add(ListaDeVeiculos);
            Controls.Add(ClienteLabel);
            Controls.Add(EnderecoClienteLabel);
            Controls.Add(CpfCnpjClienteLabel);
            Controls.Add(RgClienteLabel);
            Controls.Add(NomeClienteLabel);
            Controls.Add(PesquisarClienteLabel);
            Controls.Add(ListaClientes);
            Controls.Add(PesquisarCliente);
            Controls.Add(ClienteBox);
            Controls.Add(TelefoneClienteLabel);
            Name = "CriarOrdemDeServico";
            Text = "CriarOrdemDeServico";
            ((System.ComponentModel.ISupportInitialize)ProdutosNaOrdemDeServico).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label ClienteLabel;
        private Label EnderecoClienteLabel;
        private Label CpfCnpjClienteLabel;
        private Label RgClienteLabel;
        private Label NomeClienteLabel;
        private Label PesquisarClienteLabel;
        private ComboBox ListaClientes;
        private Button PesquisarCliente;
        private TextBox ClienteBox;
        private Label TelefoneClienteLabel;
        private ComboBox ListaDeVeiculos;
        private Label SelecionarVeiculoLabel;
        private Label TipoVeiculoLabel;
        private Label ModeloVeiculoLabel;
        private Label PlacaVeiculoLabel;
        private Label CriarNovoVeiculoLabel;
        private Label VeiculoLabel;
        private TextBox TipoVeiculoBox;
        private TextBox ModeloVeiculoBox;
        private TextBox PlacaVeiculoBox;
        private Label PlacaCarroLabel;
        private Label ModelVeiculoLabel;
        private Label TipoVeiculoBoxLabel;
        private Button CriarVeiculoButton;
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
        private DataGridView ProdutosNaOrdemDeServico;
        private DataGridViewTextBoxColumn IdProduto;
        private DataGridViewTextBoxColumn Nome;
        private DataGridViewTextBoxColumn Quantidade;
        private DataGridViewTextBoxColumn Preco;
        private DataGridViewTextBoxColumn ValorTotalProduto;
        private DataGridViewButtonColumn RemoverProduto;
        private Label PrecoTotalVendaLabel;
        private Button ConcluirVenda;
        private Label ProdutoAdicionadosNaODSLabel;
        private Label OrdemDeServicoInfoLabel;
        private Label TipoDeServicoLabel;
        private TextBox TipoDeServicoBox;
        private Label DescricaoServicoLabel;
        private TextBox DescricaoServicoBox;
        private DateTimePicker DataDeEntregaServicoBox;
        private Label HorarioDeEntregaLabel;
    }
}