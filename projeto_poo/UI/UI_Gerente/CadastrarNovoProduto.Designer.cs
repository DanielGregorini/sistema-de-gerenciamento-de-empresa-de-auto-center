namespace AutoCenter
{
    partial class CadastrarNovoProduto
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
            NomeLabel = new Label();
            NomeBox = new TextBox();
            DescricaoLabel = new Label();
            DescricaoBox = new TextBox();
            PrecoLabel = new Label();
            PrecoBox = new TextBox();
            Quantidade = new Label();
            QuantidadeBox = new TextBox();
            CustoLabel = new Label();
            CustoBox = new TextBox();
            CadastrarProduto = new Button();
            SuspendLayout();
            // 
            // NomeLabel
            // 
            NomeLabel.AutoSize = true;
            NomeLabel.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            NomeLabel.Location = new Point(553, 233);
            NomeLabel.Name = "NomeLabel";
            NomeLabel.Size = new Size(80, 32);
            NomeLabel.TabIndex = 0;
            NomeLabel.Text = "Nome";
            // 
            // NomeBox
            // 
            NomeBox.Location = new Point(639, 233);
            NomeBox.Multiline = true;
            NomeBox.Name = "NomeBox";
            NomeBox.Size = new Size(229, 31);
            NomeBox.TabIndex = 1;
            // 
            // DescricaoLabel
            // 
            DescricaoLabel.AutoSize = true;
            DescricaoLabel.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            DescricaoLabel.Location = new Point(553, 296);
            DescricaoLabel.Name = "DescricaoLabel";
            DescricaoLabel.Size = new Size(116, 32);
            DescricaoLabel.TabIndex = 2;
            DescricaoLabel.Text = "Descrição";
            // 
            // DescricaoBox
            // 
            DescricaoBox.Location = new Point(675, 298);
            DescricaoBox.Multiline = true;
            DescricaoBox.Name = "DescricaoBox";
            DescricaoBox.Size = new Size(229, 30);
            DescricaoBox.TabIndex = 3;
            // 
            // PrecoLabel
            // 
            PrecoLabel.AutoSize = true;
            PrecoLabel.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            PrecoLabel.Location = new Point(553, 355);
            PrecoLabel.Name = "PrecoLabel";
            PrecoLabel.Size = new Size(73, 32);
            PrecoLabel.TabIndex = 4;
            PrecoLabel.Text = "Preço";
            // 
            // PrecoBox
            // 
            PrecoBox.Location = new Point(632, 364);
            PrecoBox.Name = "PrecoBox";
            PrecoBox.Size = new Size(85, 23);
            PrecoBox.TabIndex = 5;
            PrecoBox.KeyPress += PrecoBox_KeyPress;
            // 
            // Quantidade
            // 
            Quantidade.AutoSize = true;
            Quantidade.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            Quantidade.Location = new Point(553, 413);
            Quantidade.Name = "Quantidade";
            Quantidade.Size = new Size(139, 32);
            Quantidade.TabIndex = 6;
            Quantidade.Text = "Quantidade";
            // 
            // QuantidadeBox
            // 
            QuantidadeBox.Location = new Point(698, 422);
            QuantidadeBox.Name = "QuantidadeBox";
            QuantidadeBox.Size = new Size(85, 23);
            QuantidadeBox.TabIndex = 7;
            QuantidadeBox.KeyPress += textBox2_KeyPress;
            // 
            // CustoLabel
            // 
            CustoLabel.AutoSize = true;
            CustoLabel.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            CustoLabel.Location = new Point(553, 475);
            CustoLabel.Name = "CustoLabel";
            CustoLabel.Size = new Size(75, 32);
            CustoLabel.TabIndex = 8;
            CustoLabel.Text = "Custo";
            // 
            // CustoBox
            // 
            CustoBox.Location = new Point(637, 484);
            CustoBox.Name = "CustoBox";
            CustoBox.Size = new Size(85, 23);
            CustoBox.TabIndex = 9;
            CustoBox.KeyPress += CustoBox_KeyPress;
            // 
            // CadastrarProduto
            // 
            CadastrarProduto.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            CadastrarProduto.Location = new Point(585, 545);
            CadastrarProduto.Name = "CadastrarProduto";
            CadastrarProduto.Size = new Size(216, 64);
            CadastrarProduto.TabIndex = 12;
            CadastrarProduto.Text = "Cadastrar produto";
            CadastrarProduto.UseVisualStyleBackColor = true;
            CadastrarProduto.Click += CadastrarProduto_Click;
            // 
            // CadastrarNovoProduto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1375, 798);
            Controls.Add(CadastrarProduto);
            Controls.Add(CustoBox);
            Controls.Add(CustoLabel);
            Controls.Add(QuantidadeBox);
            Controls.Add(Quantidade);
            Controls.Add(PrecoBox);
            Controls.Add(PrecoLabel);
            Controls.Add(DescricaoBox);
            Controls.Add(DescricaoLabel);
            Controls.Add(NomeBox);
            Controls.Add(NomeLabel);
            Name = "CadastrarNovoProduto";
            Text = "CadastrarNovoProduto";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label NomeLabel;
        private TextBox NomeBox;
        private Label DescricaoLabel;
        private TextBox DescricaoBox;
        private Label PrecoLabel;
        private TextBox PrecoBox;
        private Label Quantidade;
        private TextBox QuantidadeBox;
        private Label CustoLabel;
        private TextBox CustoBox;
        private CheckBox checkBox1;
        private CheckBox checkBox2;
        private Button CadastrarProduto;
    }
}