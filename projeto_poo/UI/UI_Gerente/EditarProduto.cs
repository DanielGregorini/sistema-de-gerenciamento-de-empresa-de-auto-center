using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Threading.Tasks;
using System.Windows.Forms;
using AutoCenter.Model;
using AutoCenter.Repository;
using System.Globalization;

namespace AutoCenter
{
    public partial class EditarProduto : Form
    {
        int produtoIdEditado { get; set; }

        public EditarProduto(Gerente gerente)
        {
            InitializeComponent();
        }

        private void FiltrarProdutoButton_Click(object sender, EventArgs e)
        {
            CriarListaProduto();
        }

        private void CriarListaProduto()
        {
            string filtro = FiltroProduto.Text;

            var produtos = ProdutoRepository.ListarProdutos();
            var produtosFiltrados = FiltrarProdutos(filtro);

            List<string> listaIdNomeProdutos = new List<string>();

            foreach (var produto in produtosFiltrados)
            {

                string idNomeProduto = "ID: " + produto.ProdutoId + "-" + produto.Nome;

                listaIdNomeProdutos.Add(idNomeProduto);
            }

            AtualizarListBox(listaIdNomeProdutos);
        }

        private List<Produto> FiltrarProdutos(string filtro)
        {
            var produtos = ProdutoRepository.ListarProdutos();
            List<Produto> produtosFiltrados = new List<Produto>();

            foreach (var produto in produtos)
            {
                if (produto.Nome.ToLower().Contains(filtro.ToLower()) ||
                    produto.Descricao.ToLower().Contains(filtro.ToLower()))
                {
                    produtosFiltrados.Add(produto);
                }
            }

            return produtosFiltrados;
        }

        private void AtualizarListBox(List<string> listaIdNomeProdutos)
        {
            // Atualiza a ListBox com os nomes dos funcionários
            ListaProdutos.Items.Clear();
            foreach (var IdNomeProduto in listaIdNomeProdutos)
            {
                ListaProdutos.Items.Add(IdNomeProduto);
            }
        }

        private void ListaProdutos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ListaProdutos.SelectedItem != null)
            {
                // Obter a string selecionada
                string dados = ListaProdutos.SelectedItem.ToString();

                // Separar a string pelo hífen
                string[] partes = dados.Split('-');

                // Verificar se há pelo menos duas partes (número e nome)
                if (partes.Length >= 2)
                {
                    // Extrair o número (primeira parte após a divisão)
                    string numeroString = partes[0].Substring(3); // Ignora os primeiros 3 caracteres ("ID:")

                    // Converter a string do número para um número (se necessário)
                    if (int.TryParse(numeroString, out int numeroExtraido))
                    {
                        produtoIdEditado = numeroExtraido;
                        InserirDadosCliente(numeroExtraido);

                        //MessageBox.Show("Número extraído: " + numeroExtraido);
                    }
                    else
                    {
                        MessageBox.Show("Não foi possível converter o número para um número inteiro.");
                        LimparDados();
                    }
                }
                else
                {
                    MessageBox.Show("String no formato esperado não encontrada.");
                    LimparDados();
                }
            }
        }

        private void InserirDadosCliente(int idProduto)
        {
            Produto produto = ProdutoRepository.ProdutoPorId(idProduto);

            NomeBox.Text = produto.Nome;
            DescricaoBox.Text = produto.Descricao;
            PrecoBox.Text = produto.Preco.ToString(CultureInfo.InvariantCulture);
            QuantidadeBox.Text = produto.Quantidade.ToString(CultureInfo.InvariantCulture);

            QuantidadeNovaEntredaBox.Text = "0";
            CustoNovaEntredaBox.Text = "0";
        }

        private void CadastrarProduto_Click(object sender, EventArgs e)
        {
            string nome = NomeBox.Text;
            string descricao = DescricaoBox.Text;
          
            if(produtoIdEditado == 0)
            {
                MessageBox.Show("Sem produto dminselecionado");
                LimparDados();
                return;
            }

            if (decimal.TryParse(PrecoBox.Text, NumberStyles.AllowDecimalPoint, CultureInfo.InvariantCulture, out decimal preco_))
            {
                // O preço foi convertido com sucesso
            }
            else
            {
                MessageBox.Show("Preço não está formatado de uma forma correta");
                LimparDados();
                return;
            }

            if (decimal.TryParse(QuantidadeBox.Text, NumberStyles.AllowDecimalPoint, CultureInfo.InvariantCulture, out decimal quantidade_))
            {
                // O preço foi convertido com sucesso
            }
            else
            {
                MessageBox.Show("quantidade ajustada não está formatado de uma forma correta");
                LimparDados();
                return;
            }

            if (decimal.TryParse(QuantidadeNovaEntredaBox.Text, NumberStyles.AllowDecimalPoint, CultureInfo.InvariantCulture, out decimal quantidadeNovaEntreda_))
            {
                // O preço foi convertido com sucesso
            }
            else
            {
                MessageBox.Show("A quantidade da nova entrada não está formatado de uma forma correta");
                LimparDados();
                return;
            }

            if (decimal.TryParse(CustoNovaEntredaBox.Text, NumberStyles.AllowDecimalPoint, CultureInfo.InvariantCulture, out decimal custoNovaEntreda_))
            {
                // O preço foi convertido com sucesso
            }
            else
            {
                MessageBox.Show("Cuso da Nova Entreda não está formatado de uma forma correta");
                LimparDados();
                return;
            }

            double precoDouble = Convert.ToDouble(preco_);
            double quantidadeDouble = Convert.ToDouble(quantidade_);

            double quantidadeNovaEntredaDouble = Convert.ToDouble(quantidadeNovaEntreda_);
            double custoNovaEntradaDouble = Convert.ToDouble(custoNovaEntreda_);

            ProdutoRepository.EditarProduto(produtoIdEditado, nome, descricao, precoDouble, quantidadeDouble + quantidadeNovaEntredaDouble);
            ProdutoRepository.AdicionarEntredaProduto(produtoIdEditado, quantidadeNovaEntredaDouble, custoNovaEntradaDouble);

            LimparDados();
        }

        private void LimparDados()
        {
            ListaProdutos.SelectedItem = null;
            NomeBox.Text = "";
            DescricaoBox.Text = "";
            PrecoBox.Text = "";
            QuantidadeBox.Text = "";
            QuantidadeNovaEntredaBox.Text = "";
            CustoNovaEntredaBox.Text = "";
            produtoIdEditado = 0;
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

        private void QuantidadeBox_KeyPress(object sender, KeyPressEventArgs e)
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

        private void QuantidadeNovaEntredaBox_KeyPress(object sender, KeyPressEventArgs e)
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

        private void CustoNovaEntredaBox_KeyPress(object sender, KeyPressEventArgs e)
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
