using AutoCenter.Model;
using AutoCenter.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoCenter
{
    public partial class CadastrarNovoProduto : Form
    {
        public CadastrarNovoProduto(Gerente gerente)
        {
            InitializeComponent();
        }

        private void CadastrarProduto_Click(object sender, EventArgs e)
        {
            string nomeProduto = NomeBox.Text;
            string descricaoProduto = DescricaoBox.Text;

            if (decimal.TryParse(PrecoBox.Text, NumberStyles.AllowDecimalPoint, CultureInfo.InvariantCulture, out decimal precoProduto_))
            {
                // O preço foi convertido com sucesso
            }
            else
            {
                MessageBox.Show("Preço não está formatado de uma forma correta");
                LimparDadosProduto();
                return;
            }

            if (decimal.TryParse(QuantidadeBox.Text, NumberStyles.AllowDecimalPoint, CultureInfo.InvariantCulture, out decimal quantidadeProduto_) &&
                quantidadeProduto_ >= 0)
            {
                // A quantidade foi convertida com sucesso
            }
            else
            {
                MessageBox.Show("A quantidade não está formatada de uma forma correta");
                LimparDadosProduto();
                return;
            }

            if (decimal.TryParse(CustoBox.Text, NumberStyles.AllowDecimalPoint, CultureInfo.InvariantCulture, out decimal custoProduto_) &&
                custoProduto_ >= 0)
            {
                // O custo foi convertido com sucesso
            }
            else
            {
                MessageBox.Show("O custo não está formatado de uma forma correta");
                LimparDadosProduto();
                return;
            }

            Produto produto = new Produto
            {
                Nome = nomeProduto,
                Descricao = descricaoProduto,
                Preco = (double)precoProduto_,
                Quantidade = (double)quantidadeProduto_,
                CustoUltimaEntrada = (double)custoProduto_
            };

            ProdutoRepository.AdicionarProduto(produto);
            MessageBox.Show("Produto Adicionado");
            LimparDadosProduto();
        }

        private void LimparDadosProduto()
        {
            NomeBox.Text = "";
            DescricaoBox.Text = "";
            PrecoBox.Text = "";
            QuantidadeBox.Text = "";
            CustoBox.Text = "";
        }

        private void PrecoBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permite apenas números, o ponto decimal e a tecla Backspace
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }

            // Permite apenas um ponto decimal
            if (e.KeyChar == '.' && (sender as TextBox).Text.IndexOf('.') > -1)
            {
                e.Handled = true;
            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permite apenas números, o ponto decimal e a tecla Backspace
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }

            // Permite apenas um ponto decimal
            if (e.KeyChar == '.' && (sender as TextBox).Text.IndexOf('.') > -1)
            {
                e.Handled = true;
            }
        }

        private void CustoBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permite apenas números, o ponto decimal e a tecla Backspace
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }

            // Permite apenas um ponto decimal
            if (e.KeyChar == '.' && (sender as TextBox).Text.IndexOf('.') > -1)
            {
                e.Handled = true;
            }
        }

    }
}
