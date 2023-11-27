namespace AutoCenter
{
    partial class TelaCaixa
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
            caixa_nome = new Label();
            listaVendaEmAberto = new DataGridView();
            listaOrdemDeServicoEmAberto = new DataGridView();
            VendasLabel = new Label();
            OrdemDeServicoLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)listaVendaEmAberto).BeginInit();
            ((System.ComponentModel.ISupportInitialize)listaOrdemDeServicoEmAberto).BeginInit();
            SuspendLayout();
            // 
            // caixa_nome
            // 
            caixa_nome.AutoSize = true;
            caixa_nome.Font = new Font("Segoe UI", 25F, FontStyle.Regular, GraphicsUnit.Point);
            caixa_nome.Location = new Point(12, 9);
            caixa_nome.Name = "caixa_nome";
            caixa_nome.Size = new Size(200, 46);
            caixa_nome.TabIndex = 0;
            caixa_nome.Text = "Nome Caixa";
            // 
            // listaVendaEmAberto
            // 
            listaVendaEmAberto.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            listaVendaEmAberto.Location = new Point(12, 156);
            listaVendaEmAberto.Name = "listaVendaEmAberto";
            listaVendaEmAberto.RowTemplate.Height = 25;
            listaVendaEmAberto.Size = new Size(583, 590);
            listaVendaEmAberto.TabIndex = 1;
            listaVendaEmAberto.CellContentClick += ListaVendaEmAberto_CellContentClick;
            // 
            // listaOrdemDeServicoEmAberto
            // 
            listaOrdemDeServicoEmAberto.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            listaOrdemDeServicoEmAberto.Location = new Point(646, 156);
            listaOrdemDeServicoEmAberto.Name = "listaOrdemDeServicoEmAberto";
            listaOrdemDeServicoEmAberto.RowTemplate.Height = 25;
            listaOrdemDeServicoEmAberto.Size = new Size(868, 590);
            listaOrdemDeServicoEmAberto.TabIndex = 2;
            listaOrdemDeServicoEmAberto.CellContentClick += ListaOrdemDeServicoEmAberto_CellContentClick;
            // 
            // VendasLabel
            // 
            VendasLabel.AutoSize = true;
            VendasLabel.Font = new Font("Segoe UI", 35F, FontStyle.Regular, GraphicsUnit.Point);
            VendasLabel.Location = new Point(12, 91);
            VendasLabel.Name = "VendasLabel";
            VendasLabel.Size = new Size(177, 62);
            VendasLabel.TabIndex = 3;
            VendasLabel.Text = "Vendas";
            // 
            // OrdemDeServicoLabel
            // 
            OrdemDeServicoLabel.AutoSize = true;
            OrdemDeServicoLabel.Font = new Font("Segoe UI", 35F, FontStyle.Regular, GraphicsUnit.Point);
            OrdemDeServicoLabel.Location = new Point(646, 91);
            OrdemDeServicoLabel.Name = "OrdemDeServicoLabel";
            OrdemDeServicoLabel.Size = new Size(407, 62);
            OrdemDeServicoLabel.TabIndex = 4;
            OrdemDeServicoLabel.Text = "Ordens de Serviço";
            // 
            // TelaCaixa
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1526, 851);
            Controls.Add(OrdemDeServicoLabel);
            Controls.Add(VendasLabel);
            Controls.Add(listaOrdemDeServicoEmAberto);
            Controls.Add(listaVendaEmAberto);
            Controls.Add(caixa_nome);
            Name = "TelaCaixa";
            Text = "TelaCaixa";
            Load += TelaCaixa_Load;
            ((System.ComponentModel.ISupportInitialize)listaVendaEmAberto).EndInit();
            ((System.ComponentModel.ISupportInitialize)listaOrdemDeServicoEmAberto).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label caixa_nome;
        private DataGridView listaVendaEmAberto;
        private DataGridView listaOrdemDeServicoEmAberto;
        private Label VendasLabel;
        private Label OrdemDeServicoLabel;
    }
}