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
                context.ProdutoOrdensDeServico.Add(produtoOrdemDeServico);
                context.SaveChanges();
            }
        }

        static public void ExcluirProdutoOrdemDeServico(ProdutoOrdemDeServico produtoOrdemDeServico)
        {

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
                var produtoOrdemDeServico = context.ProdutoOrdensDeServico.Where(produtoOrdemDeServico =>
                    produtoOrdemDeServico.OrdemDeServicoId == ordemDeServicoId).ToList();

                return produtoOrdemDeServico;
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
