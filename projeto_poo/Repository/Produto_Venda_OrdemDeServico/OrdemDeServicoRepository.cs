using AutoCenter.Data;
using AutoCenter.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoCenter.Repository
{
    public class OrdemDeServicoRepository
    {
        static public void AdicionarOrdemDeServico(OrdemDeServico ordemDeServico)
        {
            using (var context = new AutoCenterContext())
            {
                double valorTotal = 0;

                ordemDeServico.Estado = "NãoPago";

                var protudoOrdensDeServico = ProdutoOrdemDeServicoRepository
                    .ListarProdutoOrdensDeServicoPorOrdemDeServico(ordemDeServico.OrdemDeServicoId);

                foreach (var p in protudoOrdensDeServico)
                {
                    var produto = ProdutoRepository.ProdutoPorId(p.ProdutoId);

                    if (produto != null)
                    {
                        valorTotal = valorTotal + produto.Preco * p.Quantidade;
                    }
                }
                ordemDeServico.ValorTotal = valorTotal;

              
                context.OrdensDeServico.Add(ordemDeServico);
                context.SaveChanges();
            }
        }

        static public void AtualizarOrdemDeServico(int idOrdemDeServico, string? novaDescricao, string? novoTipoServico)
        {
            using (var context = new AutoCenterContext())
            {
                double valorTotal = 0;

                var ordemDeServico = OrdemDeServicoPorId(idOrdemDeServico);
                var ProdutoOrdensDeServico = ProdutoOrdemDeServicoRepository.ListarProdutoOrdensDeServicoPorOrdemDeServico(ordemDeServico.OrdemDeServicoId);
                
                if (novaDescricao != null)
                {
                    ordemDeServico.Descricao = novaDescricao;
                }

                if (novoTipoServico != null)
                {
                    ordemDeServico.TipoDeServico = novoTipoServico;
                }

                foreach (var p in ProdutoOrdensDeServico)
                {
                    var produto = ProdutoRepository.ProdutoPorId(p.ProdutoId);

                    if (produto != null)
                    {
                        valorTotal = valorTotal + produto.Preco * p.Quantidade;
                    }
                }

                ordemDeServico.ValorTotal = valorTotal;
                context.OrdensDeServico.Update(ordemDeServico);
                context.SaveChanges();

            }
        }

        static public void ExcluirOrdemDeServico(OrdemDeServico ordemDeServico)
        {
            using (var context = new AutoCenterContext())
            {
                var produtoOrdensDeServico = ProdutoOrdemDeServicoRepository.
                    ListarProdutoOrdensDeServicoPorOrdemDeServico(ordemDeServico.OrdemDeServicoId);

                foreach (var produtoOrdemDeServico in produtoOrdensDeServico)
                {
                    ProdutoOrdemDeServicoRepository.ExcluirProdutoOrdemDeServico(produtoOrdemDeServico);
                }

               context.OrdensDeServico.Remove(ordemDeServico);
                context.SaveChanges();
            }
        }

        static public void MudarEstadoOrdemDeServico(int ordemDeServicoId)
        {
            using (var context = new AutoCenterContext())
            {
                // Buscar a venda pelo ID
                var ordemDeServico = context.OrdensDeServico.Find(ordemDeServicoId);

                // Verificar se a venda foi encontrada
                if (ordemDeServico != null)
                {
                    // Atualizar o estado da ordem de servico
                    ordemDeServico.Estado = "Pago";
                    context.SaveChanges();
                }
                else
                {
                    
                    return;
                }
            }
        }

        static public List<OrdemDeServico> ListarOrdemDeServicoDeCliente(int clienteId)
        {
            using (var context = new AutoCenterContext())
            {
                var ordensDeServicoCliente = context.OrdensDeServico.
                     Where(veiculo => veiculo.ClienteId == clienteId).ToList();

                return ordensDeServicoCliente;
            }
        }

        static public List<OrdemDeServico> ListarOrdemDeServicoDeVendedor(int vendedorId)
        {
            using (var context = new AutoCenterContext())
            {
                var ordensDeServicoVendedor = context.OrdensDeServico.
                    Where(veiculo => veiculo.VendedorId == vendedorId).ToList();
            
                return ordensDeServicoVendedor;
            }
        }

        static public List<OrdemDeServico> ListarOrdemDeServico()
        {
            using (var context = new AutoCenterContext())
            {
                var ordensDeServico = context.OrdensDeServico.ToList();
                return ordensDeServico;
            }
        }

        static public OrdemDeServico OrdemDeServicoPorId(int id)
        {
            using (var context = new AutoCenterContext())
            {
                //procura o venda pelo id
                var ordemDeServico = context.OrdensDeServico.Find(id);

                if (ordemDeServico == null)
                {
                    throw new ArgumentException("ID não encontrado");
                    return null;
                }

                return ordemDeServico;
            }
        }
    }
}
