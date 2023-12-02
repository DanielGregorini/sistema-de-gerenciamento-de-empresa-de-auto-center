namespace AutoCenter
{
    partial class EditarProduto
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
            EditarProdutoButton = new Button();
            CustoNovaEntredaBox = new TextBox();
            CustoLabel = new Label();
            QuantidadeBox = new TextBox();
            Quantidade = new Label();
            PrecoBox = new TextBox();
            PrecoLabel = new Label();
            DescricaoBox = new TextBox();
            DescricaoLabel = new Label();
            NomeBox = new TextBox();
            NomeLabel = new Label();
            NovaEntreda = new Label();
            QuantidadeNovaEntredaBox = new TextBox();
            FiltroProduto = new TextBox();
            FiltrarProdutoButton = new Button();
            ListaProdutos = new ComboBox();
            SuspendLayout();
            // 
            // EditarProdutoButton
            // 
            EditarProdutoButton.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            EditarProdutoButton.Location = new Point(596, 682);
            EditarProdutoButton.Name = "EditarProdutoButton";
            EditarProdutoButton.Size = new Size(216, 64);
            EditarProdutoButton.TabIndex = 23;
            EditarProdutoButton.Text = "Editar produto";
            EditarProdutoButton.UseVisualStyleBackColor = true;
            EditarProdutoButton.Click += CadastrarProduto_Click;
            // 
            // CustoNovaEntredaBox
            // 
            CustoNovaEntredaBox.Location = new Point(556, 619);
            CustoNovaEntredaBox.Name = "CustoNovaEntredaBox";
            CustoNovaEntredaBox.Size = new Size(85, 23);
            CustoNovaEntredaBox.TabIndex = 22;
            CustoNovaEntredaBox.KeyPress += CustoNovaEntredaBox_KeyPress;
            // 
            // CustoLabel
            // 
            CustoLabel.AutoSize = true;
            CustoLabel.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            CustoLabel.Location = new Point(556, 584);
            CustoLabel.Name = "CustoLabel";
            CustoLabel.Size = new Size(256, 32);
            CustoLabel.TabIndex = 21;
            CustoLabel.Text = "Custo da nova entreda";
            // 
            // QuantidadeBox
            // 
            QuantidadeBox.Location = new Point(556, 439);
            QuantidadeBox.Name = "QuantidadeBox";
            QuantidadeBox.Size = new Size(116, 23);
            QuantidadeBox.TabIndex = 20;
            QuantidadeBox.KeyPress += QuantidadeBox_KeyPress;
            // 
            // Quantidade
            // 
            Quantidade.AutoSize = true;
            Quantidade.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            Quantidade.Location = new Point(556, 395);
            Quantidade.Name = "Quantidade";
            Quantidade.Size = new Size(219, 32);
            Quantidade.TabIndex = 19;
            Quantidade.Text = "Ajustar Quantidade";
            // 
            // PrecoBox
            // 
            PrecoBox.Location = new Point(556, 357);
            PrecoBox.Name = "PrecoBox";
            PrecoBox.Size = new Size(107, 23);
            PrecoBox.TabIndex = 18;
            PrecoBox.KeyPress += PrecoBox_KeyPress;
            // 
            // PrecoLabel
            // 
            PrecoLabel.AutoSize = true;
            PrecoLabel.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            PrecoLabel.Location = new Point(556, 322);
            PrecoLabel.Name = "PrecoLabel";
            PrecoLabel.Size = new Size(179, 32);
            PrecoLabel.TabIndex = 17;
            PrecoLabel.Text = "Preço de venda";
            // 
            // DescricaoBox
            // 
            DescricaoBox.Location = new Point(556, 280);
            DescricaoBox.Multiline = true;
            DescricaoBox.Name = "DescricaoBox";
            DescricaoBox.Size = new Size(315, 30);
            DescricaoBox.TabIndex = 16;
            // 
            // DescricaoLabel
            // 
            DescricaoLabel.AutoSize = true;
            DescricaoLabel.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            DescricaoLabel.Location = new Point(556, 245);
            DescricaoLabel.Name = "DescricaoLabel";
            DescricaoLabel.Size = new Size(116, 32);
            DescricaoLabel.TabIndex = 15;
            DescricaoLabel.Text = "Descrição";
            // 
            // NomeBox
            // 
            NomeBox.Location = new Point(556, 200);
            NomeBox.Multiline = true;
            NomeBox.Name = "NomeBox";
            NomeBox.Size = new Size(315, 31);
            NomeBox.TabIndex = 14;
            // 
            // NomeLabel
            // 
            NomeLabel.AutoSize = true;
            NomeLabel.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            NomeLabel.Location = new Point(556, 165);
            NomeLabel.Name = "NomeLabel";
            NomeLabel.Size = new Size(80, 32);
            NomeLabel.TabIndex = 13;
            NomeLabel.Text = "Nome";
            // 
            // NovaEntreda
            // 
            NovaEntreda.AutoSize = true;
            NovaEntreda.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            NovaEntreda.Location = new Point(556, 514);
            NovaEntreda.Name = "NovaEntreda";
            NovaEntreda.Size = new Size(286, 32);
            NovaEntreda.TabIndex = 24;
            NovaEntreda.Text = "Quantidade nova entrada";
            // 
            // QuantidadeNovaEntredaBox
            // 
            QuantidadeNovaEntredaBox.Location = new Point(556, 549);
            QuantidadeNovaEntredaBox.Name = "QuantidadeNovaEntredaBox";
            QuantidadeNovaEntredaBox.Size = new Size(85, 23);
            QuantidadeNovaEntredaBox.TabIndex = 25;
            QuantidadeNovaEntredaBox.KeyPress += QuantidadeNovaEntredaBox_KeyPress;
            // 
            // FiltroProduto
            // 
            FiltroProduto.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            FiltroProduto.Location = new Point(38, 45);
            FiltroProduto.Multiline = true;
            FiltroProduto.Name = "FiltroProduto";
            FiltroProduto.Size = new Size(1030, 31);
            FiltroProduto.TabIndex = 26;
            // 
            // FiltrarProdutoButton
            // 
            FiltrarProdutoButton.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            FiltrarProdutoButton.Location = new Point(1098, 23);
            FiltrarProdutoButton.Name = "FiltrarProdutoButton";
            FiltrarProdutoButton.Size = new Size(216, 64);
            FiltrarProdutoButton.TabIndex = 27;
            FiltrarProdutoButton.Text = "Filtrar";
            FiltrarProdutoButton.UseVisualStyleBackColor = true;
            FiltrarProdutoButton.Click += FiltrarProdutoButton_Click;
            // 
            // ListaProdutos
            // 
            ListaProdutos.FormattingEnabled = true;
            ListaProdutos.Location = new Point(97, 165);
            ListaProdutos.Margin = new Padding(3, 2, 3, 2);
            ListaProdutos.Name = "ListaProdutos";
            ListaProdutos.Size = new Size(312, 23);
            ListaProdutos.TabIndex = 28;
            ListaProdutos.SelectedIndexChanged += ListaProdutos_SelectedIndexChanged;
            // 
            // EditarProduto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1373, 829);
            Controls.Add(ListaProdutos);
            Controls.Add(FiltrarProdutoButton);
            Controls.Add(FiltroProduto);
            Controls.Add(QuantidadeNovaEntredaBox);
            Controls.Add(NovaEntreda);
            Controls.Add(EditarProdutoButton);
            Controls.Add(CustoNovaEntredaBox);
            Controls.Add(CustoLabel);
            Controls.Add(QuantidadeBox);
            Controls.Add(Quantidade);
            Controls.Add(PrecoBox);
            Controls.Add(PrecoLabel);
            Controls.Add(DescricaoBox);
            Controls.Add(DescricaoLabel);
            Controls.Add(NomeBox);
            Controls.Add(NomeLabel);
            Name = "EditarProduto";
            Text = "EditarProduto";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button EditarProdutoButton;
        private TextBox CustoNovaEntredaBox;
        private Label CustoLabel;
        private TextBox QuantidadeBox;
        private Label Quantidade;
        private TextBox PrecoBox;
        private Label PrecoLabel;
        private TextBox DescricaoBox;
        private Label DescricaoLabel;
        private TextBox NomeBox;
        private Label NomeLabel;
        private Label NovaEntreda;
        private TextBox QuantidadeNovaEntredaBox;
        private TextBox FiltroProduto;
        private Button FiltrarProdutoButton;
        private ComboBox ListaProdutos;
    }
}