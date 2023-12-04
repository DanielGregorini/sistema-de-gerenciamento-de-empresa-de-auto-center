using AutoCenter.Model;
using AutoCenter.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoCenter
{
    public partial class TelaVendedor : Form
    {
        Vendedor vendedor { get; set; }

        public TelaVendedor(Vendedor vendedor_)
        {
            InitializeComponent();
            this.vendedor = vendedor_;
            this.Text = "Sistema de Gerenciamento de empresa Auto Center";
            NomeVendedor.Text = vendedor.Nome;
        }

        private void TelaVendedor_Load(object sender, EventArgs e)
        {

        }

        private void CadastrarCliente_Click(object sender, EventArgs e)
        {
            CadastrarCliente cadastrarCliente = new CadastrarCliente(vendedor);

            cadastrarCliente.Show();
        }

        private void NovaVendaButton_Click(object sender, EventArgs e)
        {
            CriarVenda criarVenda = new CriarVenda(vendedor);
            criarVenda.Show();
        }
    }
}
