using AutoCenter.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AutoCenter.Model;
using AutoCenter.Repository;

namespace AutoCenter.UI.UI_Vendedor
{
    public partial class CadastrarCliente : Form
    {
        public CadastrarCliente(Vendedor vendedor)
        {
            InitializeComponent();
        }

        private void CadastrarClienteButton_Click(object sender, EventArgs e)
        {
            string nome = NomeBox.Text;
            string rg = RgBox.Text;
            string cpfCnpj = CpfCpnjLabelBox.Text;
            string endereco = EnderecoBox.Text;
            string telefone = TelefoneBox.Text;

            Cliente cliente = new Cliente
            {
                Nome = nome,
                Rg = rg,
                Cpf_Cnpj = cpfCnpj,
                Endereco = endereco,
                Telefone = telefone
            };

            ClienteRepository.AdicionarCliente(cliente);

            LimparDados();
        }

        private void LimparDados()
        {
            NomeBox.Text = "";
            RgBox.Text = "";
            CpfCpnjLabelBox.Text = "";
            EnderecoBox.Text = "";
            TelefoneBox.Text = "";
        }
    }
}
