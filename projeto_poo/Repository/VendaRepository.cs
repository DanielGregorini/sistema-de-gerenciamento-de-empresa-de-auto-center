using AutoCenter.Data;
using AutoCenter.Model;
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
                venda.Estado = "NãoPago";
                context.Vendas.Add(venda);
                context.SaveChanges();
            }
        }

        static public void ExcluirVenda(Venda venda)
        {

            using (var context = new AutoCenterContext())
            {
                context.Vendas.Remove(venda);
                context.SaveChanges();
            }
        }

        static public void MudarEstadoVenda(Venda venda)
        {
            using (var context = new AutoCenterContext())
            {
                venda.Estado = "Pago";
                context.SaveChanges();
            }
        }

        //public int VendaId { get; set; }
        //public List<ProdutoVenda> ProdutosVendidos { get; set; }
        //public int ClienteId { get; set; }
        //public Cliente Cliente { get; set; }
        //public double ValorTotal { get; set; }
        //public string Estado { get; set; }
        //public DateTime HorioRealizacao { get; set; }
        /*
        static public void EditarVenda(int id, string? novoNome, string? novaDescricao,
            double? novoPreco, double? novaQuantidade)
        {
            using (var context = new AutoCenterContext())
            {
                var produtoParaEditar = context.Produtos.Find(id);


                context.SaveChanges();
            }
        }
        */
        static public List<Venda> VendasDeUmCliente(int clienteId)
        {
            using (var context = new AutoCenterContext())
            {
                var vendas = context.Vendas.ToList();
                List<Venda> vendasCliente = new List<Venda>();

                foreach (var venda in vendas) { 
                    venda.ClienteId = clienteId;
                    vendasCliente.Add(venda);
                }

                return vendasCliente;
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
                }

                return venda;
            }
        }
    }
}
