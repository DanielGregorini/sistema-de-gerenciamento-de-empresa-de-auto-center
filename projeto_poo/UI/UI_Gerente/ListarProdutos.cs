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
    public partial class ListarProdutos : Form
    {
        public ListarProdutos(Gerente gerente)
        {
            InitializeComponent();
        }

        private void PesquisarButton_Click(object sender, EventArgs e)
        {
            string filtroPesquisa = FiltroBox.Text;

            //limpar os dados
            ListaProdutos.Rows.Clear();

            //adicionar os dados filtrados
            ListarProdutosPorFiltro(filtroPesquisa);
           
        }

        private void ListarProdutosPorFiltro(string filtroPesquisa) { 
        
            var listaProdutos = ProdutoRepository.ListarProdutos();

            foreach(var produto in listaProdutos) {

                if (ContemFiltroProduto(filtroPesquisa, produto))
                {
                    DataGridViewRow novaLinha = new DataGridViewRow();
                    novaLinha.Cells.Add(new DataGridViewTextBoxCell { Value = produto.ProdutoId });
                    novaLinha.Cells.Add(new DataGridViewTextBoxCell { Value = produto.Nome });
                    novaLinha.Cells.Add(new DataGridViewTextBoxCell { Value = produto.Descricao });
                    novaLinha.Cells.Add(new DataGridViewTextBoxCell { Value = produto.Preco });
                    novaLinha.Cells.Add(new DataGridViewTextBoxCell { Value = produto.Quantidade });
                    novaLinha.Cells.Add(new DataGridViewTextBoxCell { Value = produto.CustoUltimaEntrada });

                    double QuantidaProdutoVendida = 0;

                    var produtoVendas = ProdutoVendaRepository.ListarProdutoVendas();

                    foreach(var produtoVenda in produtoVendas)
                    {
                        if(produtoVenda.ProdutoVendaId == produto.ProdutoId)
                        {
                            QuantidaProdutoVendida = QuantidaProdutoVendida + (produtoVenda.Quantidade);
                        }
                    }

                    double QuantidaProdutoVendidaValor = QuantidaProdutoVendida * produto.Preco;
                    novaLinha.Cells.Add(new DataGridViewTextBoxCell { Value = QuantidaProdutoVendida });
                    novaLinha.Cells.Add(new DataGridViewTextBoxCell { Value = QuantidaProdutoVendidaValor });
                    novaLinha.Cells.Add(new DataGridViewTextBoxCell { Value = produto.Quantidade * produto.Preco});

                    ListaProdutos.Rows.Add(novaLinha);
                }
            }
        }

        private bool ContemFiltroProduto(string filtro, Produto produto)
        {
            if (produto.Nome.ToLower().Contains(filtro.ToLower()) || produto.Descricao.ToLower().Contains(filtro.ToLower()) )
            {
                return true;
            }

            return false;
        }

    }
}
