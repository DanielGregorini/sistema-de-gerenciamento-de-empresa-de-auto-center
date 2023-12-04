namespace AutoCenter
{
    partial class TelaVendedor
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
            NomeVendedor = new Label();
            CadastrarCliente = new Button();
            NovaVendaButton = new Button();
            NovaODSButton = new Button();
            EditarVenda = new Button();
            EditarODSBox = new Button();
            SuspendLayout();
            // 
            // NomeVendedor
            // 
            NomeVendedor.AutoSize = true;
            NomeVendedor.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            NomeVendedor.Location = new Point(22, 16);
            NomeVendedor.Name = "NomeVendedor";
            NomeVendedor.Size = new Size(302, 46);
            NomeVendedor.TabIndex = 0;
            NomeVendedor.Text = "NomeDoVendedor";
            // 
            // CadastrarCliente
            // 
            CadastrarCliente.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            CadastrarCliente.Location = new Point(42, 180);
            CadastrarCliente.Margin = new Padding(3, 4, 3, 4);
            CadastrarCliente.Name = "CadastrarCliente";
            CadastrarCliente.Size = new Size(314, 84);
            CadastrarCliente.TabIndex = 1;
            CadastrarCliente.Text = "Cadastrar cliente";
            CadastrarCliente.UseVisualStyleBackColor = true;
            CadastrarCliente.Click += CadastrarCliente_Click;
            // 
            // NovaVendaButton
            // 
            NovaVendaButton.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            NovaVendaButton.Location = new Point(42, 321);
            NovaVendaButton.Margin = new Padding(3, 4, 3, 4);
            NovaVendaButton.Name = "NovaVendaButton";
            NovaVendaButton.Size = new Size(314, 84);
            NovaVendaButton.TabIndex = 2;
            NovaVendaButton.Text = "Nova venda";
            NovaVendaButton.UseVisualStyleBackColor = true;
            NovaVendaButton.Click += NovaVendaButton_Click;
            // 
            // NovaODSButton
            // 
            NovaODSButton.Font = new Font("Segoe UI", 17F, FontStyle.Regular, GraphicsUnit.Point);
            NovaODSButton.Location = new Point(42, 432);
            NovaODSButton.Margin = new Padding(3, 4, 3, 4);
            NovaODSButton.Name = "NovaODSButton";
            NovaODSButton.Size = new Size(314, 84);
            NovaODSButton.TabIndex = 3;
            NovaODSButton.Text = "Nova ordem de serviço";
            NovaODSButton.UseVisualStyleBackColor = true;
            // 
            // EditarVenda
            // 
            EditarVenda.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            EditarVenda.Location = new Point(423, 321);
            EditarVenda.Margin = new Padding(3, 4, 3, 4);
            EditarVenda.Name = "EditarVenda";
            EditarVenda.Size = new Size(314, 84);
            EditarVenda.TabIndex = 4;
            EditarVenda.Text = "Editar venda";
            EditarVenda.UseVisualStyleBackColor = true;
            // 
            // EditarODSBox
            // 
            EditarODSBox.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            EditarODSBox.Location = new Point(423, 432);
            EditarODSBox.Margin = new Padding(3, 4, 3, 4);
            EditarODSBox.Name = "EditarODSBox";
            EditarODSBox.Size = new Size(314, 84);
            EditarODSBox.TabIndex = 5;
            EditarODSBox.Text = "Editar ordem de serviço";
            EditarODSBox.UseVisualStyleBackColor = true;
            // 
            // TelaVendedor
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1506, 1055);
            Controls.Add(EditarODSBox);
            Controls.Add(EditarVenda);
            Controls.Add(NovaODSButton);
            Controls.Add(NovaVendaButton);
            Controls.Add(CadastrarCliente);
            Controls.Add(NomeVendedor);
            Margin = new Padding(3, 4, 3, 4);
            Name = "TelaVendedor";
            Text = "TelaVendedor";
            Load += TelaVendedor_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label NomeVendedor;
        private Button CadastrarCliente;
        private Button NovaVendaButton;
        private Button NovaODSButton;
        private Button EditarVenda;
        private Button EditarODSBox;
    }
}