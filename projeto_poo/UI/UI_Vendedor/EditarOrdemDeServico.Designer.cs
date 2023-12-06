namespace AutoCenter
{
    partial class EditarOrdemDeServico
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
            TelefoneClienteLabel = new Label();
            ListaODSEmAberto = new ComboBox();
            ProdutoAdicionadosNaODSLabel = new Label();
            ProdutosNaOrdemDeServico = new DataGridView();
            DeletarButton = new Button();
            PrecoTotalVendaLabel = new Label();
            ConcluirODS = new Button();
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
            VeiculoLabel = new Label();
            PlacaVeiculoLabel = new Label();
            ModeloVeiculoLabel = new Label();
            TipoVeiculoLabel = new Label();
            CriarVeiculoButton = new Button();
            PlacaCarroLabel = new Label();
            ModelVeiculoLabel = new Label();
            TipoVeiculoBoxLabel = new Label();
            PlacaVeiculoBox = new TextBox();
            ModeloVeiculoBox = new TextBox();
            TipoVeiculoBox = new TextBox();
            CriarNovoVeiculoLabel = new Label();
            SelecionarVeiculoLabel = new Label();
            ListaDeVeiculos = new ComboBox();
            HorarioDeEntregaLabel = new Label();
            DataDeEntregaServicoBox = new DateTimePicker();
            DescricaoServicoBox = new TextBox();
            DescricaoServicoLabel = new Label();
            TipoDeServicoLabel = new Label();
            TipoDeServicoBox = new TextBox();
            OrdemDeServicoInfoLabel = new Label();
            IdProduto = new DataGridViewTextBoxColumn();
            Nome = new DataGridViewTextBoxColumn();
            Quantidade = new DataGridViewTextBoxColumn();
            Preco = new DataGridViewTextBoxColumn();
            ValorTotalProduto = new DataGridViewTextBoxColumn();
            RemoverProduto = new DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)ProdutosNaOrdemDeServico).BeginInit();
            SuspendLayout();
            // 
            // ClienteLabel
            // 
            ClienteLabel.AutoSize = true;
            ClienteLabel.Font = new Font("Segoe UI", 30F, FontStyle.Regular, GraphicsUnit.Point);
            ClienteLabel.Location = new Point(401, 10);
            ClienteLabel.Name = "ClienteLabel";
            ClienteLabel.Size = new Size(156, 54);
            ClienteLabel.TabIndex = 85;
            ClienteLabel.Text = "Cliente:";
            // 
            // EnderecoClienteLabel
            // 
            EnderecoClienteLabel.AutoSize = true;
            EnderecoClienteLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            EnderecoClienteLabel.Location = new Point(414, 152);
            EnderecoClienteLabel.Name = "EnderecoClienteLabel";
            EnderecoClienteLabel.Size = new Size(74, 21);
            EnderecoClienteLabel.TabIndex = 84;
            EnderecoClienteLabel.Text = "Endereço";
            // 
            // CpfCnpjClienteLabel
            // 
            CpfCnpjClienteLabel.AutoSize = true;
            CpfCnpjClienteLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            CpfCnpjClienteLabel.Location = new Point(414, 125);
            CpfCnpjClienteLabel.Name = "CpfCnpjClienteLabel";
            CpfCnpjClienteLabel.Size = new Size(66, 21);
            CpfCnpjClienteLabel.TabIndex = 83;
            CpfCnpjClienteLabel.Text = "CpfCnpj";
            // 
            // RgClienteLabel
            // 
            RgClienteLabel.AutoSize = true;
            RgClienteLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            RgClienteLabel.Location = new Point(414, 103);
            RgClienteLabel.Name = "RgClienteLabel";
            RgClienteLabel.Size = new Size(29, 21);
            RgClienteLabel.TabIndex = 82;
            RgClienteLabel.Text = "Rg";
            // 
            // NomeClienteLabel
            // 
            NomeClienteLabel.AutoSize = true;
            NomeClienteLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            NomeClienteLabel.Location = new Point(414, 66);
            NomeClienteLabel.Name = "NomeClienteLabel";
            NomeClienteLabel.Size = new Size(105, 21);
            NomeClienteLabel.TabIndex = 81;
            NomeClienteLabel.Text = "Nome Cliente";
            // 
            // TelefoneClienteLabel
            // 
            TelefoneClienteLabel.AutoSize = true;
            TelefoneClienteLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            TelefoneClienteLabel.Location = new Point(414, 191);
            TelefoneClienteLabel.Name = "TelefoneClienteLabel";
            TelefoneClienteLabel.Size = new Size(67, 21);
            TelefoneClienteLabel.TabIndex = 80;
            TelefoneClienteLabel.Text = "Telefone";
            // 
            // ListaODSEmAberto
            // 
            ListaODSEmAberto.FormattingEnabled = true;
            ListaODSEmAberto.Location = new Point(12, 53);
            ListaODSEmAberto.Margin = new Padding(3, 2, 3, 2);
            ListaODSEmAberto.Name = "ListaODSEmAberto";
            ListaODSEmAberto.Size = new Size(372, 23);
            ListaODSEmAberto.TabIndex = 79;
            ListaODSEmAberto.SelectedIndexChanged += ListaODSEmAberto_SelectedIndexChanged;
            // 
            // ProdutoAdicionadosNaODSLabel
            // 
            ProdutoAdicionadosNaODSLabel.AutoSize = true;
            ProdutoAdicionadosNaODSLabel.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            ProdutoAdicionadosNaODSLabel.Location = new Point(668, 15);
            ProdutoAdicionadosNaODSLabel.Name = "ProdutoAdicionadosNaODSLabel";
            ProdutoAdicionadosNaODSLabel.Size = new Size(536, 37);
            ProdutoAdicionadosNaODSLabel.TabIndex = 95;
            ProdutoAdicionadosNaODSLabel.Text = "Produtos adicionados na Oridem de Serviço";
            // 
            // ProdutosNaOrdemDeServico
            // 
            ProdutosNaOrdemDeServico.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ProdutosNaOrdemDeServico.Columns.AddRange(new DataGridViewColumn[] { IdProduto, Nome, Quantidade, Preco, ValorTotalProduto, RemoverProduto });
            ProdutosNaOrdemDeServico.Location = new Point(668, 53);
            ProdutosNaOrdemDeServico.Margin = new Padding(3, 2, 3, 2);
            ProdutosNaOrdemDeServico.Name = "ProdutosNaOrdemDeServico";
            ProdutosNaOrdemDeServico.RowHeadersWidth = 51;
            ProdutosNaOrdemDeServico.RowTemplate.Height = 29;
            ProdutosNaOrdemDeServico.Size = new Size(659, 655);
            ProdutosNaOrdemDeServico.TabIndex = 94;
            ProdutosNaOrdemDeServico.CellContentClick += ProdutosNaOrdemDeServico_CellContentClick;
            // 
            // DeletarButton
            // 
            DeletarButton.BackColor = Color.IndianRed;
            DeletarButton.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            DeletarButton.Location = new Point(1234, 727);
            DeletarButton.Margin = new Padding(3, 2, 3, 2);
            DeletarButton.Name = "DeletarButton";
            DeletarButton.Size = new Size(93, 27);
            DeletarButton.TabIndex = 98;
            DeletarButton.Text = "Deletar";
            DeletarButton.UseVisualStyleBackColor = false;
            DeletarButton.Click += DeletarButton_Click;
            // 
            // PrecoTotalVendaLabel
            // 
            PrecoTotalVendaLabel.AutoSize = true;
            PrecoTotalVendaLabel.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            PrecoTotalVendaLabel.Location = new Point(668, 727);
            PrecoTotalVendaLabel.Name = "PrecoTotalVendaLabel";
            PrecoTotalVendaLabel.Size = new Size(112, 28);
            PrecoTotalVendaLabel.TabIndex = 97;
            PrecoTotalVendaLabel.Text = "Preço Total:";
            // 
            // ConcluirODS
            // 
            ConcluirODS.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            ConcluirODS.Location = new Point(900, 727);
            ConcluirODS.Margin = new Padding(3, 2, 3, 2);
            ConcluirODS.Name = "ConcluirODS";
            ConcluirODS.Size = new Size(205, 44);
            ConcluirODS.TabIndex = 96;
            ConcluirODS.Text = "Concluir ODS";
            ConcluirODS.UseVisualStyleBackColor = true;
            ConcluirODS.Click += ConcluirODS_Click;
            // 
            // ProdutoLabel
            // 
            ProdutoLabel.AutoSize = true;
            ProdutoLabel.Font = new Font("Segoe UI", 30F, FontStyle.Regular, GraphicsUnit.Point);
            ProdutoLabel.Location = new Point(395, 495);
            ProdutoLabel.Name = "ProdutoLabel";
            ProdutoLabel.Size = new Size(175, 54);
            ProdutoLabel.TabIndex = 111;
            ProdutoLabel.Text = "Produto:";
            // 
            // NomeProdutoLabel
            // 
            NomeProdutoLabel.AutoSize = true;
            NomeProdutoLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            NomeProdutoLabel.Location = new Point(404, 558);
            NomeProdutoLabel.Name = "NomeProdutoLabel";
            NomeProdutoLabel.Size = new Size(116, 21);
            NomeProdutoLabel.TabIndex = 110;
            NomeProdutoLabel.Text = "Nome Produto:";
            // 
            // PesquisarProdutoLabel
            // 
            PesquisarProdutoLabel.AutoSize = true;
            PesquisarProdutoLabel.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            PesquisarProdutoLabel.Location = new Point(12, 446);
            PesquisarProdutoLabel.Name = "PesquisarProdutoLabel";
            PesquisarProdutoLabel.Size = new Size(170, 28);
            PesquisarProdutoLabel.TabIndex = 109;
            PesquisarProdutoLabel.Text = "Pesquisar Produto";
            // 
            // AdicionarProdutoBox
            // 
            AdicionarProdutoBox.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            AdicionarProdutoBox.Location = new Point(414, 756);
            AdicionarProdutoBox.Margin = new Padding(3, 2, 3, 2);
            AdicionarProdutoBox.Name = "AdicionarProdutoBox";
            AdicionarProdutoBox.Size = new Size(174, 38);
            AdicionarProdutoBox.TabIndex = 108;
            AdicionarProdutoBox.Text = "Adicionar Produto";
            AdicionarProdutoBox.UseVisualStyleBackColor = true;
            AdicionarProdutoBox.Click += AdicionarProdutoBox_Click;
            // 
            // QuantidadeVendidaBox
            // 
            QuantidadeVendidaBox.Location = new Point(515, 722);
            QuantidadeVendidaBox.Margin = new Padding(3, 2, 3, 2);
            QuantidadeVendidaBox.Name = "QuantidadeVendidaBox";
            QuantidadeVendidaBox.Size = new Size(92, 23);
            QuantidadeVendidaBox.TabIndex = 107;
            QuantidadeVendidaBox.KeyPress += QuantidadeVendidaBox_KeyPress;
            // 
            // QuantidadeVendidaLabel
            // 
            QuantidadeVendidaLabel.AutoSize = true;
            QuantidadeVendidaLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            QuantidadeVendidaLabel.Location = new Point(404, 720);
            QuantidadeVendidaLabel.Name = "QuantidadeVendidaLabel";
            QuantidadeVendidaLabel.Size = new Size(94, 21);
            QuantidadeVendidaLabel.TabIndex = 106;
            QuantidadeVendidaLabel.Text = "Quantidade:";
            // 
            // CustoMedioLabel
            // 
            CustoMedioLabel.AutoSize = true;
            CustoMedioLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            CustoMedioLabel.Location = new Point(404, 691);
            CustoMedioLabel.Name = "CustoMedioLabel";
            CustoMedioLabel.Size = new Size(98, 21);
            CustoMedioLabel.TabIndex = 105;
            CustoMedioLabel.Text = "Custo Medio";
            // 
            // Descricao
            // 
            Descricao.AutoSize = true;
            Descricao.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Descricao.Location = new Point(404, 590);
            Descricao.MaximumSize = new Size(262, 0);
            Descricao.Name = "Descricao";
            Descricao.Size = new Size(77, 21);
            Descricao.TabIndex = 104;
            Descricao.Text = "Descrição";
            // 
            // PrecoLabel
            // 
            PrecoLabel.AutoSize = true;
            PrecoLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            PrecoLabel.Location = new Point(404, 633);
            PrecoLabel.Name = "PrecoLabel";
            PrecoLabel.Size = new Size(49, 21);
            PrecoLabel.TabIndex = 103;
            PrecoLabel.Text = "Preço";
            // 
            // QuantidadeDisponivelLabel
            // 
            QuantidadeDisponivelLabel.AutoSize = true;
            QuantidadeDisponivelLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            QuantidadeDisponivelLabel.Location = new Point(404, 662);
            QuantidadeDisponivelLabel.Name = "QuantidadeDisponivelLabel";
            QuantidadeDisponivelLabel.Size = new Size(166, 21);
            QuantidadeDisponivelLabel.TabIndex = 102;
            QuantidadeDisponivelLabel.Text = "Quantidade disponivel";
            // 
            // ListaProdutos
            // 
            ListaProdutos.FormattingEnabled = true;
            ListaProdutos.Location = new Point(12, 545);
            ListaProdutos.Margin = new Padding(3, 2, 3, 2);
            ListaProdutos.Name = "ListaProdutos";
            ListaProdutos.Size = new Size(353, 23);
            ListaProdutos.TabIndex = 101;
            ListaProdutos.SelectedIndexChanged += ListaProdutos_SelectedIndexChanged;
            // 
            // BuscarProdutoButton
            // 
            BuscarProdutoButton.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            BuscarProdutoButton.Location = new Point(286, 495);
            BuscarProdutoButton.Margin = new Padding(3, 2, 3, 2);
            BuscarProdutoButton.Name = "BuscarProdutoButton";
            BuscarProdutoButton.Size = new Size(79, 28);
            BuscarProdutoButton.TabIndex = 100;
            BuscarProdutoButton.Text = "Pesquisar";
            BuscarProdutoButton.UseVisualStyleBackColor = true;
            BuscarProdutoButton.Click += BuscarProdutoButton_Click;
            // 
            // BuscarProdutoBox
            // 
            BuscarProdutoBox.Location = new Point(12, 495);
            BuscarProdutoBox.Margin = new Padding(3, 2, 3, 2);
            BuscarProdutoBox.Name = "BuscarProdutoBox";
            BuscarProdutoBox.Size = new Size(268, 23);
            BuscarProdutoBox.TabIndex = 99;
            // 
            // VeiculoLabel
            // 
            VeiculoLabel.AutoSize = true;
            VeiculoLabel.Font = new Font("Segoe UI", 30F, FontStyle.Regular, GraphicsUnit.Point);
            VeiculoLabel.Location = new Point(414, 270);
            VeiculoLabel.Name = "VeiculoLabel";
            VeiculoLabel.Size = new Size(159, 54);
            VeiculoLabel.TabIndex = 115;
            VeiculoLabel.Text = "Veículo:";
            // 
            // PlacaVeiculoLabel
            // 
            PlacaVeiculoLabel.AutoSize = true;
            PlacaVeiculoLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            PlacaVeiculoLabel.Location = new Point(414, 376);
            PlacaVeiculoLabel.Name = "PlacaVeiculoLabel";
            PlacaVeiculoLabel.Size = new Size(49, 21);
            PlacaVeiculoLabel.TabIndex = 114;
            PlacaVeiculoLabel.Text = "Placa:";
            // 
            // ModeloVeiculoLabel
            // 
            ModeloVeiculoLabel.AutoSize = true;
            ModeloVeiculoLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            ModeloVeiculoLabel.Location = new Point(414, 355);
            ModeloVeiculoLabel.Name = "ModeloVeiculoLabel";
            ModeloVeiculoLabel.Size = new Size(63, 21);
            ModeloVeiculoLabel.TabIndex = 113;
            ModeloVeiculoLabel.Text = "Modelo";
            // 
            // TipoVeiculoLabel
            // 
            TipoVeiculoLabel.AutoSize = true;
            TipoVeiculoLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            TipoVeiculoLabel.Location = new Point(414, 334);
            TipoVeiculoLabel.Name = "TipoVeiculoLabel";
            TipoVeiculoLabel.Size = new Size(43, 21);
            TipoVeiculoLabel.TabIndex = 112;
            TipoVeiculoLabel.Text = "Tipo:";
            // 
            // CriarVeiculoButton
            // 
            CriarVeiculoButton.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            CriarVeiculoButton.Location = new Point(54, 371);
            CriarVeiculoButton.Name = "CriarVeiculoButton";
            CriarVeiculoButton.Size = new Size(128, 33);
            CriarVeiculoButton.TabIndex = 125;
            CriarVeiculoButton.Text = "Criar veículo";
            CriarVeiculoButton.UseVisualStyleBackColor = true;
            CriarVeiculoButton.Click += CriarVeiculoButton_Click;
            // 
            // PlacaCarroLabel
            // 
            PlacaCarroLabel.AutoSize = true;
            PlacaCarroLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            PlacaCarroLabel.Location = new Point(24, 338);
            PlacaCarroLabel.Name = "PlacaCarroLabel";
            PlacaCarroLabel.Size = new Size(49, 21);
            PlacaCarroLabel.TabIndex = 124;
            PlacaCarroLabel.Text = "Placa:";
            // 
            // ModelVeiculoLabel
            // 
            ModelVeiculoLabel.AutoSize = true;
            ModelVeiculoLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            ModelVeiculoLabel.Location = new Point(13, 298);
            ModelVeiculoLabel.Name = "ModelVeiculoLabel";
            ModelVeiculoLabel.Size = new Size(63, 21);
            ModelVeiculoLabel.TabIndex = 123;
            ModelVeiculoLabel.Text = "Modelo";
            // 
            // TipoVeiculoBoxLabel
            // 
            TipoVeiculoBoxLabel.AutoSize = true;
            TipoVeiculoBoxLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            TipoVeiculoBoxLabel.Location = new Point(30, 265);
            TipoVeiculoBoxLabel.Name = "TipoVeiculoBoxLabel";
            TipoVeiculoBoxLabel.Size = new Size(43, 21);
            TipoVeiculoBoxLabel.TabIndex = 122;
            TipoVeiculoBoxLabel.Text = "Tipo:";
            // 
            // PlacaVeiculoBox
            // 
            PlacaVeiculoBox.Location = new Point(82, 336);
            PlacaVeiculoBox.Name = "PlacaVeiculoBox";
            PlacaVeiculoBox.Size = new Size(100, 23);
            PlacaVeiculoBox.TabIndex = 121;
            // 
            // ModeloVeiculoBox
            // 
            ModeloVeiculoBox.Location = new Point(82, 296);
            ModeloVeiculoBox.Name = "ModeloVeiculoBox";
            ModeloVeiculoBox.Size = new Size(140, 23);
            ModeloVeiculoBox.TabIndex = 120;
            // 
            // TipoVeiculoBox
            // 
            TipoVeiculoBox.Location = new Point(82, 267);
            TipoVeiculoBox.Name = "TipoVeiculoBox";
            TipoVeiculoBox.Size = new Size(140, 23);
            TipoVeiculoBox.TabIndex = 119;
            // 
            // CriarNovoVeiculoLabel
            // 
            CriarNovoVeiculoLabel.AutoSize = true;
            CriarNovoVeiculoLabel.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            CriarNovoVeiculoLabel.Location = new Point(12, 213);
            CriarNovoVeiculoLabel.Name = "CriarNovoVeiculoLabel";
            CriarNovoVeiculoLabel.Size = new Size(237, 37);
            CriarNovoVeiculoLabel.TabIndex = 118;
            CriarNovoVeiculoLabel.Text = "Criar novo veÍculo:";
            // 
            // SelecionarVeiculoLabel
            // 
            SelecionarVeiculoLabel.AutoSize = true;
            SelecionarVeiculoLabel.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            SelecionarVeiculoLabel.Location = new Point(12, 125);
            SelecionarVeiculoLabel.Name = "SelecionarVeiculoLabel";
            SelecionarVeiculoLabel.Size = new Size(170, 28);
            SelecionarVeiculoLabel.TabIndex = 117;
            SelecionarVeiculoLabel.Text = "Selecionar Veículo";
            // 
            // ListaDeVeiculos
            // 
            ListaDeVeiculos.FormattingEnabled = true;
            ListaDeVeiculos.Location = new Point(12, 169);
            ListaDeVeiculos.Margin = new Padding(3, 2, 3, 2);
            ListaDeVeiculos.Name = "ListaDeVeiculos";
            ListaDeVeiculos.Size = new Size(372, 23);
            ListaDeVeiculos.TabIndex = 116;
            ListaDeVeiculos.SelectedIndexChanged += ListaDeVeiculos_SelectedIndexChanged;
            // 
            // HorarioDeEntregaLabel
            // 
            HorarioDeEntregaLabel.AutoSize = true;
            HorarioDeEntregaLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            HorarioDeEntregaLabel.Location = new Point(12, 773);
            HorarioDeEntregaLabel.Name = "HorarioDeEntregaLabel";
            HorarioDeEntregaLabel.Size = new Size(144, 21);
            HorarioDeEntregaLabel.TabIndex = 132;
            HorarioDeEntregaLabel.Text = "Horário de entrega:";
            // 
            // DataDeEntregaServicoBox
            // 
            DataDeEntregaServicoBox.Location = new Point(162, 771);
            DataDeEntregaServicoBox.Name = "DataDeEntregaServicoBox";
            DataDeEntregaServicoBox.Size = new Size(226, 23);
            DataDeEntregaServicoBox.TabIndex = 131;
            // 
            // DescricaoServicoBox
            // 
            DescricaoServicoBox.Location = new Point(167, 705);
            DescricaoServicoBox.Multiline = true;
            DescricaoServicoBox.Name = "DescricaoServicoBox";
            DescricaoServicoBox.Size = new Size(216, 41);
            DescricaoServicoBox.TabIndex = 130;
            // 
            // DescricaoServicoLabel
            // 
            DescricaoServicoLabel.AutoSize = true;
            DescricaoServicoLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            DescricaoServicoLabel.Location = new Point(23, 721);
            DescricaoServicoLabel.Name = "DescricaoServicoLabel";
            DescricaoServicoLabel.Size = new Size(133, 21);
            DescricaoServicoLabel.TabIndex = 129;
            DescricaoServicoLabel.Text = "Descrição serviço:";
            // 
            // TipoDeServicoLabel
            // 
            TipoDeServicoLabel.AutoSize = true;
            TipoDeServicoLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            TipoDeServicoLabel.Location = new Point(24, 664);
            TipoDeServicoLabel.Name = "TipoDeServicoLabel";
            TipoDeServicoLabel.Size = new Size(119, 21);
            TipoDeServicoLabel.TabIndex = 128;
            TipoDeServicoLabel.Text = "Tipo de Serviço:";
            // 
            // TipoDeServicoBox
            // 
            TipoDeServicoBox.Location = new Point(167, 664);
            TipoDeServicoBox.Multiline = true;
            TipoDeServicoBox.Name = "TipoDeServicoBox";
            TipoDeServicoBox.Size = new Size(221, 35);
            TipoDeServicoBox.TabIndex = 127;
            // 
            // OrdemDeServicoInfoLabel
            // 
            OrdemDeServicoInfoLabel.AutoSize = true;
            OrdemDeServicoInfoLabel.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            OrdemDeServicoInfoLabel.Location = new Point(9, 622);
            OrdemDeServicoInfoLabel.Name = "OrdemDeServicoInfoLabel";
            OrdemDeServicoInfoLabel.Size = new Size(173, 28);
            OrdemDeServicoInfoLabel.TabIndex = 126;
            OrdemDeServicoInfoLabel.Text = "Ordem de Serviço:";
            // 
            // IdProduto
            // 
            IdProduto.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
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
            // EditarOrdemDeServico
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1339, 803);
            Controls.Add(HorarioDeEntregaLabel);
            Controls.Add(DataDeEntregaServicoBox);
            Controls.Add(DescricaoServicoBox);
            Controls.Add(DescricaoServicoLabel);
            Controls.Add(TipoDeServicoLabel);
            Controls.Add(TipoDeServicoBox);
            Controls.Add(OrdemDeServicoInfoLabel);
            Controls.Add(CriarVeiculoButton);
            Controls.Add(PlacaCarroLabel);
            Controls.Add(ModelVeiculoLabel);
            Controls.Add(TipoVeiculoBoxLabel);
            Controls.Add(PlacaVeiculoBox);
            Controls.Add(ModeloVeiculoBox);
            Controls.Add(TipoVeiculoBox);
            Controls.Add(CriarNovoVeiculoLabel);
            Controls.Add(SelecionarVeiculoLabel);
            Controls.Add(ListaDeVeiculos);
            Controls.Add(VeiculoLabel);
            Controls.Add(PlacaVeiculoLabel);
            Controls.Add(ModeloVeiculoLabel);
            Controls.Add(TipoVeiculoLabel);
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
            Controls.Add(DeletarButton);
            Controls.Add(PrecoTotalVendaLabel);
            Controls.Add(ConcluirODS);
            Controls.Add(ProdutoAdicionadosNaODSLabel);
            Controls.Add(ProdutosNaOrdemDeServico);
            Controls.Add(ClienteLabel);
            Controls.Add(EnderecoClienteLabel);
            Controls.Add(CpfCnpjClienteLabel);
            Controls.Add(RgClienteLabel);
            Controls.Add(NomeClienteLabel);
            Controls.Add(TelefoneClienteLabel);
            Controls.Add(ListaODSEmAberto);
            Name = "EditarOrdemDeServico";
            Text = "EditarOrdemDeServico";
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
        private Label TelefoneClienteLabel;
        private ComboBox ListaODSEmAberto;
        private Label ProdutoAdicionadosNaODSLabel;
        private DataGridView ProdutosNaOrdemDeServico;
        private Button DeletarButton;
        private Label PrecoTotalVendaLabel;
        private Button ConcluirODS;
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
        private Label VeiculoLabel;
        private Label PlacaVeiculoLabel;
        private Label ModeloVeiculoLabel;
        private Label TipoVeiculoLabel;
        private Button CriarVeiculoButton;
        private Label PlacaCarroLabel;
        private Label ModelVeiculoLabel;
        private Label TipoVeiculoBoxLabel;
        private TextBox PlacaVeiculoBox;
        private TextBox ModeloVeiculoBox;
        private TextBox TipoVeiculoBox;
        private Label CriarNovoVeiculoLabel;
        private Label SelecionarVeiculoLabel;
        private ComboBox ListaDeVeiculos;
        private Label HorarioDeEntregaLabel;
        private DateTimePicker DataDeEntregaServicoBox;
        private TextBox DescricaoServicoBox;
        private Label DescricaoServicoLabel;
        private Label TipoDeServicoLabel;
        private TextBox TipoDeServicoBox;
        private Label OrdemDeServicoInfoLabel;
        private DataGridViewTextBoxColumn IdProduto;
        private DataGridViewTextBoxColumn Nome;
        private DataGridViewTextBoxColumn Quantidade;
        private DataGridViewTextBoxColumn Preco;
        private DataGridViewTextBoxColumn ValorTotalProduto;
        private DataGridViewButtonColumn RemoverProduto;
    }
}