namespace AutoCenter;

partial class ListarVendasOrdemDeServico
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
        FiltroBox = new TextBox();
        PesquisarButton = new Button();
        VendasLista = new DataGridView();
        VendaId = new DataGridViewTextBoxColumn();
        ClienteId = new DataGridViewTextBoxColumn();
        NomeCliente = new DataGridViewTextBoxColumn();
        IdVendedor = new DataGridViewTextBoxColumn();
        Estado = new DataGridViewTextBoxColumn();
        ValorTotalVenda = new DataGridViewTextBoxColumn();
        Horario = new DataGridViewTextBoxColumn();
        OrdemDeServicoLista = new DataGridView();
        OrdemDeServicoId = new DataGridViewTextBoxColumn();
        TipoDoServico = new DataGridViewTextBoxColumn();
        DescricaoServico = new DataGridViewTextBoxColumn();
        ClienteIdODS = new DataGridViewTextBoxColumn();
        NomeClienteODS = new DataGridViewTextBoxColumn();
        VendedorIdODS = new DataGridViewTextBoxColumn();
        EstadoODS = new DataGridViewTextBoxColumn();
        ValorTotalODS = new DataGridViewTextBoxColumn();
        HorarioDeEntrega = new DataGridViewTextBoxColumn();
        ((System.ComponentModel.ISupportInitialize)VendasLista).BeginInit();
        ((System.ComponentModel.ISupportInitialize)OrdemDeServicoLista).BeginInit();
        SuspendLayout();
        // 
        // FiltroBox
        // 
        FiltroBox.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
        FiltroBox.Location = new Point(235, 67);
        FiltroBox.Multiline = true;
        FiltroBox.Name = "FiltroBox";
        FiltroBox.Size = new Size(801, 37);
        FiltroBox.TabIndex = 0;
        // 
        // PesquisarButton
        // 
        PesquisarButton.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
        PesquisarButton.Location = new Point(1058, 67);
        PesquisarButton.Name = "PesquisarButton";
        PesquisarButton.Size = new Size(112, 37);
        PesquisarButton.TabIndex = 1;
        PesquisarButton.Text = "Pesquisar";
        PesquisarButton.UseVisualStyleBackColor = true;
        PesquisarButton.Click += PesquisarButton_Click;
        // 
        // VendasLista
        // 
        VendasLista.AllowUserToOrderColumns = true;
        VendasLista.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        VendasLista.Columns.AddRange(new DataGridViewColumn[] { VendaId, ClienteId, NomeCliente, IdVendedor, Estado, ValorTotalVenda, Horario });
        VendasLista.Location = new Point(12, 186);
        VendasLista.Name = "VendasLista";
        VendasLista.RowTemplate.Height = 25;
        VendasLista.Size = new Size(624, 632);
        VendasLista.TabIndex = 2;
        // 
        // VendaId
        // 
        VendaId.HeaderText = "Venda Id";
        VendaId.Name = "VendaId";
        // 
        // ClienteId
        // 
        ClienteId.HeaderText = "Cliente Id";
        ClienteId.Name = "ClienteId";
        // 
        // NomeCliente
        // 
        NomeCliente.HeaderText = "Nome Cliente";
        NomeCliente.Name = "NomeCliente";
        // 
        // IdVendedor
        // 
        IdVendedor.HeaderText = "Id Vendedor";
        IdVendedor.Name = "IdVendedor";
        // 
        // Estado
        // 
        Estado.HeaderText = "Estado";
        Estado.Name = "Estado";
        // 
        // ValorTotalVenda
        // 
        ValorTotalVenda.HeaderText = "Valor Total";
        ValorTotalVenda.Name = "ValorTotalVenda";
        // 
        // Horario
        // 
        Horario.HeaderText = "Horario";
        Horario.Name = "Horario";
        // 
        // OrdemDeServicoLista
        // 
        OrdemDeServicoLista.AllowUserToOrderColumns = true;
        OrdemDeServicoLista.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        OrdemDeServicoLista.Columns.AddRange(new DataGridViewColumn[] { OrdemDeServicoId, TipoDoServico, DescricaoServico, ClienteIdODS, NomeClienteODS, VendedorIdODS, EstadoODS, ValorTotalODS, HorarioDeEntrega });
        OrdemDeServicoLista.Location = new Point(642, 186);
        OrdemDeServicoLista.Name = "OrdemDeServicoLista";
        OrdemDeServicoLista.RowTemplate.Height = 25;
        OrdemDeServicoLista.Size = new Size(732, 632);
        OrdemDeServicoLista.TabIndex = 3;
        // 
        // OrdemDeServicoId
        // 
        OrdemDeServicoId.HeaderText = "ODS Id";
        OrdemDeServicoId.Name = "OrdemDeServicoId";
        // 
        // TipoDoServico
        // 
        TipoDoServico.HeaderText = "Tipo Do Servico";
        TipoDoServico.Name = "TipoDoServico";
        // 
        // DescricaoServico
        // 
        DescricaoServico.HeaderText = "Descrição";
        DescricaoServico.Name = "DescricaoServico";
        // 
        // ClienteIdODS
        // 
        ClienteIdODS.HeaderText = "Cliente Id";
        ClienteIdODS.Name = "ClienteIdODS";
        // 
        // NomeClienteODS
        // 
        NomeClienteODS.HeaderText = "Nome Cliente";
        NomeClienteODS.Name = "NomeClienteODS";
        // 
        // VendedorIdODS
        // 
        VendedorIdODS.HeaderText = "Vendedor Id";
        VendedorIdODS.Name = "VendedorIdODS";
        // 
        // EstadoODS
        // 
        EstadoODS.HeaderText = "Estado";
        EstadoODS.Name = "EstadoODS";
        // 
        // ValorTotalODS
        // 
        ValorTotalODS.HeaderText = "Valor Total";
        ValorTotalODS.Name = "ValorTotalODS";
        // 
        // HorarioDeEntrega
        // 
        HorarioDeEntrega.HeaderText = "Horário De Entrega";
        HorarioDeEntrega.Name = "HorarioDeEntrega";
        // 
        // ListarVendasOrdemDeServico
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(1386, 830);
        Controls.Add(OrdemDeServicoLista);
        Controls.Add(VendasLista);
        Controls.Add(PesquisarButton);
        Controls.Add(FiltroBox);
        Name = "ListarVendasOrdemDeServico";
        Text = "ListarVendasOrdemDeServico";
        ((System.ComponentModel.ISupportInitialize)VendasLista).EndInit();
        ((System.ComponentModel.ISupportInitialize)OrdemDeServicoLista).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private TextBox FiltroBox;
    private Button PesquisarButton;
    private DataGridView VendasLista;
    private DataGridView OrdemDeServicoLista;
    private DataGridViewTextBoxColumn VendaId;
    private DataGridViewTextBoxColumn ClienteId;
    private DataGridViewTextBoxColumn NomeCliente;
    private DataGridViewTextBoxColumn IdVendedor;
    private DataGridViewTextBoxColumn Estado;
    private DataGridViewTextBoxColumn ValorTotalVenda;
    private DataGridViewTextBoxColumn Horario;
    private DataGridViewTextBoxColumn OrdemDeServicoId;
    private DataGridViewTextBoxColumn TipoDoServico;
    private DataGridViewTextBoxColumn DescricaoServico;
    private DataGridViewTextBoxColumn ClienteIdODS;
    private DataGridViewTextBoxColumn NomeClienteODS;
    private DataGridViewTextBoxColumn VendedorIdODS;
    private DataGridViewTextBoxColumn EstadoODS;
    private DataGridViewTextBoxColumn ValorTotalODS;
    private DataGridViewTextBoxColumn HorarioDeEntrega;
}