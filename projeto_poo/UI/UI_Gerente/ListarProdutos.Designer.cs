namespace AutoCenter;

partial class ListarProdutos
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
        ListaProdutos = new DataGridView();
        IdProduto = new DataGridViewTextBoxColumn();
        NomeProduto = new DataGridViewTextBoxColumn();
        DescricaoProduto = new DataGridViewTextBoxColumn();
        PrecoProduto = new DataGridViewTextBoxColumn();
        QuantidadeDisponivel = new DataGridViewTextBoxColumn();
        CustoMedioProduto = new DataGridViewTextBoxColumn();
        CustoUltimaEntradaProduto = new DataGridViewTextBoxColumn();
        QuantidadeVendidaProduto = new DataGridViewTextBoxColumn();
        ValorVendidoProduto = new DataGridViewTextBoxColumn();
        ValorEmEstoqueProduto = new DataGridViewTextBoxColumn();
        FiltroBox = new TextBox();
        PesquisarButton = new Button();
        ((System.ComponentModel.ISupportInitialize)ListaProdutos).BeginInit();
        SuspendLayout();
        // 
        // ListaProdutos
        // 
        ListaProdutos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        ListaProdutos.Columns.AddRange(new DataGridViewColumn[] { IdProduto, NomeProduto, DescricaoProduto, PrecoProduto, QuantidadeDisponivel, CustoMedioProduto, CustoUltimaEntradaProduto, QuantidadeVendidaProduto, ValorVendidoProduto, ValorEmEstoqueProduto });
        ListaProdutos.Location = new Point(24, 82);
        ListaProdutos.Name = "ListaProdutos";
        ListaProdutos.RowTemplate.Height = 25;
        ListaProdutos.Size = new Size(1351, 734);
        ListaProdutos.TabIndex = 1;
        // 
        // IdProduto
        // 
        IdProduto.FillWeight = 50F;
        IdProduto.HeaderText = "Id";
        IdProduto.Name = "IdProduto";
        IdProduto.Width = 50;
        // 
        // NomeProduto
        // 
        NomeProduto.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
        NomeProduto.HeaderText = "Nome";
        NomeProduto.Name = "NomeProduto";
        NomeProduto.Width = 65;
        // 
        // DescricaoProduto
        // 
        DescricaoProduto.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
        DescricaoProduto.FillWeight = 500F;
        DescricaoProduto.HeaderText = "Descrição";
        DescricaoProduto.Name = "DescricaoProduto";
        DescricaoProduto.Width = 83;
        // 
        // PrecoProduto
        // 
        PrecoProduto.HeaderText = "Preço";
        PrecoProduto.Name = "PrecoProduto";
        // 
        // QuantidadeDisponivel
        // 
        QuantidadeDisponivel.HeaderText = "Quantidade disponível";
        QuantidadeDisponivel.Name = "QuantidadeDisponivel";
        // 
        // CustoMedioProduto
        // 
        CustoMedioProduto.HeaderText = " Custo médio";
        CustoMedioProduto.Name = "CustoMedioProduto";
        // 
        // CustoUltimaEntradaProduto
        // 
        CustoUltimaEntradaProduto.HeaderText = "Custo última entrada";
        CustoUltimaEntradaProduto.Name = "CustoUltimaEntradaProduto";
        // 
        // QuantidadeVendidaProduto
        // 
        QuantidadeVendidaProduto.HeaderText = "Quantidade vendida";
        QuantidadeVendidaProduto.Name = "QuantidadeVendidaProduto";
        // 
        // ValorVendidoProduto
        // 
        ValorVendidoProduto.HeaderText = "Valor vendido";
        ValorVendidoProduto.Name = "ValorVendidoProduto";
        // 
        // ValorEmEstoqueProduto
        // 
        ValorEmEstoqueProduto.HeaderText = "Valor em estoque";
        ValorEmEstoqueProduto.Name = "ValorEmEstoqueProduto";
        // 
        // FiltroBox
        // 
        FiltroBox.Location = new Point(24, 23);
        FiltroBox.Multiline = true;
        FiltroBox.Name = "FiltroBox";
        FiltroBox.Size = new Size(1210, 30);
        FiltroBox.TabIndex = 2;
        // 
        // PesquisarButton
        // 
        PesquisarButton.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
        PesquisarButton.Location = new Point(1252, 14);
        PesquisarButton.Name = "PesquisarButton";
        PesquisarButton.Size = new Size(123, 48);
        PesquisarButton.TabIndex = 3;
        PesquisarButton.Text = "Pesquisar";
        PesquisarButton.UseVisualStyleBackColor = true;
        PesquisarButton.Click += PesquisarButton_Click;
        // 
        // ListarProdutos
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(1399, 828);
        Controls.Add(PesquisarButton);
        Controls.Add(FiltroBox);
        Controls.Add(ListaProdutos);
        Name = "ListarProdutos";
        Text = "ListarProdutos";
        ((System.ComponentModel.ISupportInitialize)ListaProdutos).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private DataGridView ListaProdutos;
    private TextBox FiltroBox;
    private Button PesquisarButton;
    private DataGridViewTextBoxColumn IdProduto;
    private DataGridViewTextBoxColumn NomeProduto;
    private DataGridViewTextBoxColumn DescricaoProduto;
    private DataGridViewTextBoxColumn PrecoProduto;
    private DataGridViewTextBoxColumn QuantidadeDisponivel;
    private DataGridViewTextBoxColumn CustoMedioProduto;
    private DataGridViewTextBoxColumn CustoUltimaEntradaProduto;
    private DataGridViewTextBoxColumn QuantidadeVendidaProduto;
    private DataGridViewTextBoxColumn ValorVendidoProduto;
    private DataGridViewTextBoxColumn ValorEmEstoqueProduto;
}