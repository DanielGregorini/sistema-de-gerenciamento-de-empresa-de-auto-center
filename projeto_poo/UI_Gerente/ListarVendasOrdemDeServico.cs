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

namespace AutoCenter.UI_Gerente
{
    public partial class ListarVendasOrdemDeServico : Form
    {
        public ListarVendasOrdemDeServico(Gerente gerente)
        {
            InitializeComponent();
        }

        private void PesquisarButton_Click(object sender, EventArgs e)
        {
            string filtroPesquisa = FiltroBox.Text;

            //limpar os dados
            VendasLista.Rows.Clear();
            OrdemDeServicoLista.Rows.Clear();

            //adicionar os dados filtrados
            ListarVendas(filtroPesquisa);
            ListarOrdemDeServico(filtroPesquisa);
        }

        private void ListarVendas(string filtro)
        {
            var listaVendas = VendaRepository.ListarVendas();


            foreach (var venda in listaVendas)
            {

                var cliente = ClienteRepository.ClientePorId(venda.ClienteId);

                if (ContemFiltroVenda(filtro, venda))
                {
                    DataGridViewRow novaLinha = new DataGridViewRow();

                    novaLinha.Cells.Add(new DataGridViewTextBoxCell { Value = venda.VendaId });
                    novaLinha.Cells.Add(new DataGridViewTextBoxCell { Value = venda.ClienteId });
                    novaLinha.Cells.Add(new DataGridViewTextBoxCell { Value = cliente.Nome });
                    novaLinha.Cells.Add(new DataGridViewTextBoxCell { Value = venda.VendedorId });
                    novaLinha.Cells.Add(new DataGridViewTextBoxCell { Value = venda.Estado });
                    novaLinha.Cells.Add(new DataGridViewTextBoxCell { Value = venda.ValorTotal });
                    novaLinha.Cells.Add(new DataGridViewTextBoxCell { Value = venda.HorarioRealizacao });

                    VendasLista.Rows.Add(novaLinha);

                }
            }
        }

        private bool ContemFiltroVenda(string filtro, Venda venda)
        {
            var cliente = ClienteRepository.ClientePorId(venda.ClienteId);
            var vendedor = VendedorRepository.VendedorPorId(venda.VendedorId);

            if (cliente.Nome.ToLower().Contains(filtro.ToLower()) || venda.Estado.ToLower().Contains(filtro.ToLower()) ||
                vendedor.Nome.ToLower().Contains(filtro.ToLower()))
            {
                return true;

            }

            var produtoVendas = ProdutoVendaRepository.ListarProdutoVendasPorVenda(venda.VendaId);

            foreach (var produtoVenda in produtoVendas)
            {

                var produto = ProdutoRepository.ProdutoPorId(produtoVenda.ProdutoId);

                if (produto.Nome.ToLower().Contains(filtro.ToLower()) || venda.VendaId == produtoVenda.VendaId)
                {
                    MessageBox.Show($"{produto.Nome}");
                    return true;
                }
            }

            return false;
        }

        private void ListarOrdemDeServico(string filtro)
        {
            var listaODS = OrdemDeServicoRepository.ListarOrdemDeServico();

            foreach (var OrdemDeServico in listaODS)
            {
                var cliente = ClienteRepository.ClientePorId(OrdemDeServico.ClienteId);

                if (ContemFiltroODS(filtro, OrdemDeServico))
                {
                    DataGridViewRow novaLinha = new DataGridViewRow();

                    novaLinha.Cells.Add(new DataGridViewTextBoxCell { Value = OrdemDeServico.OrdemDeServicoId });
                    novaLinha.Cells.Add(new DataGridViewTextBoxCell { Value = OrdemDeServico.TipoDeServico });
                    novaLinha.Cells.Add(new DataGridViewTextBoxCell { Value = OrdemDeServico.Descricao });
                    novaLinha.Cells.Add(new DataGridViewTextBoxCell { Value = OrdemDeServico.ClienteId });
                    novaLinha.Cells.Add(new DataGridViewTextBoxCell { Value = cliente.Nome });
                    novaLinha.Cells.Add(new DataGridViewTextBoxCell { Value = OrdemDeServico.VendedorId });
                    novaLinha.Cells.Add(new DataGridViewTextBoxCell { Value = OrdemDeServico.Estado });
                    novaLinha.Cells.Add(new DataGridViewTextBoxCell { Value = OrdemDeServico.ValorTotal });
                    novaLinha.Cells.Add(new DataGridViewTextBoxCell { Value = OrdemDeServico.HorarioDeEntrega });

                    OrdemDeServicoLista.Rows.Add(novaLinha);
                }
            }


        }

        private bool ContemFiltroODS(string filtro, OrdemDeServico OrdemDeServico)
        {
            var cliente = ClienteRepository.ClientePorId(OrdemDeServico.ClienteId);
            var vendedor = VendedorRepository.VendedorPorId(OrdemDeServico.VendedorId);

            if (cliente.Nome.ToLower().Contains(filtro.ToLower()) || OrdemDeServico.Estado.ToLower().Contains(filtro.ToLower()) ||
                vendedor.Nome.ToLower().Contains(filtro.ToLower()))
            {
                return true;
            }

            var OrdensDeServicoProduto = ProdutoOrdemDeServicoRepository.ListarProdutoOrdensDeServicoPorOrdemDeServico(OrdemDeServico.OrdemDeServicoId);

            foreach (var OrdemDeServicoProduto in OrdensDeServicoProduto)
            {
                var produto = ProdutoRepository.ProdutoPorId(OrdemDeServicoProduto.ProdutoId);

                if (produto.Nome.ToLower().Contains(filtro.ToLower()) || OrdemDeServico.OrdemDeServicoId == OrdemDeServicoProduto.OrdemDeServicoId)
                {
                    MessageBox.Show($"{produto.Nome}");
                    return true;
                }
            }

            return false;
        }
    }
}
