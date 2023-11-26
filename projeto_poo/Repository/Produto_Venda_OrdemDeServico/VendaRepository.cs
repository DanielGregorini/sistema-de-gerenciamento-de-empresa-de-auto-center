using AutoCenter.Data;
using AutoCenter.Model;
using AutoCenter.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoCenter.Repository
{
    public class VendaRepository
    {
        static public void AdicionarVenda(Venda venda)
        {
            using (var context = new AutoCenterContext())
            {
                double valorTotal = 0;

                venda.Estado = "NãoPago";

                var protudoVendas = ProdutoVendaRepository.ListarProdutoVendasPorVenda(venda.VendaId);

                foreach (var p in protudoVendas)
                {
                    var produto = ProdutoRepository.ProdutoPorId(p.ProdutoId);

                    if (produto != null)
                    {
                        valorTotal = valorTotal + produto.Preco * p.Quantidade;
                    }
                }

                venda.HorioRealizacao = DateTime.Now;
                venda.ValorTotal = valorTotal;

                context.Vendas.Add(venda);
                context.SaveChanges();
            }
        }

        static public void ExcluirVenda(Venda venda)
        {
            //no futuro adicionar um metodo para adicionar os produtos de volta
            using (var context = new AutoCenterContext())
            {
                context.Vendas.Remove(venda);
                context.SaveChanges();
            }
        }

        static public void MudarEstadoVenda(int vendaId)
        {
            using (var context = new AutoCenterContext())
            {
                // Buscar a venda pelo ID
                var venda = context.Vendas.Find(vendaId);

                // Verificar se a venda foi encontrada
                if (venda != null)
                {
                    // Atualizar o estado da venda
                    venda.Estado = "Pago";
                    context.SaveChanges();
                }
                else
                {
                    // Lidar com o caso em que a venda não foi encontrada
                    return;
                }
            }
        }

        static public void AtualizarVenda(int IdVenda)
        {
            using (var context = new AutoCenterContext())
            {
                double valorTotal = 0;

                var venda = VendaPorId(IdVenda);
                var produtoVendas = ProdutoVendaRepository.ListarProdutoVendasPorVenda(venda.VendaId);

                foreach (var p in produtoVendas)
                {
                    var produto = ProdutoRepository.ProdutoPorId(p.ProdutoId);

                    if (produto != null)
                    {
                        valorTotal = valorTotal + produto.Preco * p.Quantidade;
                    }
                }

                venda.ValorTotal = valorTotal;

                context.Vendas.Update(venda);
                context.SaveChanges();
            }
        }
        
        static public List<Venda> ListarVendasDeCliente(int clienteId)
        {
            using (var context = new AutoCenterContext())
            {
                var vendasCliente = context.Vendas.Where(veiculo => veiculo.ClienteId == clienteId).ToList();

                return vendasCliente;
            }
        }
        
        static public List<Venda> ListarVendaDeVendedor(int vendedorId)
        {
            using (var context = new AutoCenterContext())
            {

                var vendasVendedor = context.Vendas.Where(veiculo => veiculo.VendedorId == vendedorId).ToList();

                return vendasVendedor;
            }
        }

        static public List<Venda> ListarVendas()
        {
            using (var context = new AutoCenterContext())
            {
                var vendas = context.Vendas.ToList();
                return vendas;
            }
        }

        static public Venda VendaPorId(int id)
        {
            using (var context = new AutoCenterContext())
            {
                //procura o venda pelo id
                var venda = context.Vendas.Find(id);

                if (venda == null)
                {
                    throw new ArgumentException("ID não encontrado");
                    return null;
                }

                return venda;
            }
        }
    }
}
