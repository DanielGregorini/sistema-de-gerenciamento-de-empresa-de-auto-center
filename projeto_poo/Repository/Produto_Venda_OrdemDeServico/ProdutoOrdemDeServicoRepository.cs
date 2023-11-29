using AutoCenter.Data;
using AutoCenter.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoCenter.Repository
{
    class ProdutoOrdemDeServicoRepository
    {
        static public void AdicionarProdutoOrdemDeServico(ProdutoOrdemDeServico produtoOrdemDeServico)
        {
            using (var context = new AutoCenterContext())
            {

                var produto = ProdutoRepository.ProdutoPorId(produtoOrdemDeServico.ProdutoId);

                if (produto.Quantidade < produtoOrdemDeServico.Quantidade)
                {

                    throw new Exception("Não pode vender mais que tem em estoque");
                    return;
                }
                else
                {
                    context.ProdutoOrdensDeServico.Add(produtoOrdemDeServico);
                    var ordemDeServico = OrdemDeServicoRepository.OrdemDeServicoPorId(produtoOrdemDeServico.OrdemDeServicoId);
                    OrdemDeServicoRepository.AtualizarOrdemDeServico(ordemDeServico.OrdemDeServicoId);
                    ProdutoRepository.EditarProduto(produto.ProdutoId, null, null, null, produto.Quantidade - produtoOrdemDeServico.Quantidade);
                }

                context.SaveChanges();
            }
        }

        static public void ExcluirProdutoOrdemDeServico(ProdutoOrdemDeServico produtoOrdemDeServico)
        {
            //no futuro adicionar um metodo para adicionar os produtos de volta
            using (var context = new AutoCenterContext())
            {
                context.ProdutoOrdensDeServico.Remove(produtoOrdemDeServico);
                context.SaveChanges();
            }
        }

        static public List<ProdutoOrdemDeServico> ListarProdutoOrdensDeServicoPorOrdemDeServico(int ordemDeServicoId)
        {
            using (var context = new AutoCenterContext())
            {
                var produtosOrdemDeServico = context.ProdutoOrdensDeServico
                                                    .Where(po => po.OrdemDeServicoId == ordemDeServicoId)
                                                    .ToList();

                return produtosOrdemDeServico;
            }
        }


        static public List<ProdutoOrdemDeServico> ListarProdutoOrdemDeServico()
        {
            using (var context = new AutoCenterContext())
            {
                var produtoOrdemDeServico = context.ProdutoOrdensDeServico.ToList();
                return produtoOrdemDeServico;
            }
        }

        static public ProdutoOrdemDeServico ProdutoOrdemDeServicoPorId(int id)
        {
            using (var context = new AutoCenterContext())
            {
                //procura o produto pelo id
                var produtoOrdemDeServico = context.ProdutoOrdensDeServico.Find(id);

                if (produtoOrdemDeServico == null)
                {
                    throw new ArgumentException("ID não encontrado");
                    return null;
                }

                return produtoOrdemDeServico;
            }
        }
    }
}
