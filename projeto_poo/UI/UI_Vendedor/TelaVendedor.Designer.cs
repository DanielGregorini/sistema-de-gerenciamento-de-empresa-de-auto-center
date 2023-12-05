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
            NomeVendedor.Location = new Point(19, 12);
            NomeVendedor.Name = "NomeVendedor";
            NomeVendedor.Size = new Size(240, 37);
            NomeVendedor.TabIndex = 0;
            NomeVendedor.Text = "NomeDoVendedor";
            // 
            // CadastrarCliente
            // 
            CadastrarCliente.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            CadastrarCliente.Location = new Point(37, 135);
            CadastrarCliente.Name = "CadastrarCliente";
            CadastrarCliente.Size = new Size(275, 63);
            CadastrarCliente.TabIndex = 1;
            CadastrarCliente.Text = "Cadastrar cliente";
            CadastrarCliente.UseVisualStyleBackColor = true;
            CadastrarCliente.Click += CadastrarCliente_Click;
            // 
            // NovaVendaButton
            // 
            NovaVendaButton.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            NovaVendaButton.Location = new Point(37, 241);
            NovaVendaButton.Name = "NovaVendaButton";
            NovaVendaButton.Size = new Size(275, 63);
            NovaVendaButton.TabIndex = 2;
            NovaVendaButton.Text = "Nova venda";
            NovaVendaButton.UseVisualStyleBackColor = true;
            NovaVendaButton.Click += NovaVendaButton_Click;
            // 
            // NovaODSButton
            // 
            NovaODSButton.Font = new Font("Segoe UI", 17F, FontStyle.Regular, GraphicsUnit.Point);
            NovaODSButton.Location = new Point(37, 324);
            NovaODSButton.Name = "NovaODSButton";
            NovaODSButton.Size = new Size(275, 63);
            NovaODSButton.TabIndex = 3;
            NovaODSButton.Text = "Nova ordem de serviço";
            NovaODSButton.UseVisualStyleBackColor = true;
            NovaODSButton.Click += NovaODSButton_Click;
            // 
            // EditarVenda
            // 
            EditarVenda.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            EditarVenda.Location = new Point(370, 241);
            EditarVenda.Name = "EditarVenda";
            EditarVenda.Size = new Size(275, 63);
            EditarVenda.TabIndex = 4;
            EditarVenda.Text = "Editar venda";
            EditarVenda.UseVisualStyleBackColor = true;
            EditarVenda.Click += EditarVenda_Click;
            // 
            // EditarODSBox
            // 
            EditarODSBox.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            EditarODSBox.Location = new Point(370, 324);
            EditarODSBox.Name = "EditarODSBox";
            EditarODSBox.Size = new Size(275, 63);
            EditarODSBox.TabIndex = 5;
            EditarODSBox.Text = "Editar ordem de serviço";
            EditarODSBox.UseVisualStyleBackColor = true;
            // 
            // TelaVendedor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1318, 791);
            Controls.Add(EditarODSBox);
            Controls.Add(EditarVenda);
            Controls.Add(NovaODSButton);
            Controls.Add(NovaVendaButton);
            Controls.Add(CadastrarCliente);
            Controls.Add(NomeVendedor);
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