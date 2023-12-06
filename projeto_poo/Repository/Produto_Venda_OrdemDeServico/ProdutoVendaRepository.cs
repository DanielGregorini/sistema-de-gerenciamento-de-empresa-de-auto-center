using AutoCenter.Data;
using AutoCenter.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoCenter.Repository
{
    public class ProdutoVendaRepository
    {
        static public void AdicionarProdutoVenda(ProdutoVenda produtoVenda)
        {
            using (var context = new AutoCenterContext())
            {
                
                
                var produto = ProdutoRepository.ProdutoPorId(produtoVenda.ProdutoId);

                if (produto.Quantidade < produtoVenda.Quantidade) {

                    throw new Exception("Não pode vender mais que tem em estoque");
                    return;
                }
                else
                {
                    context.ProdutoVendas.Add(produtoVenda);
                    var venda = VendaRepository.VendaPorId(produtoVenda.VendaId);
                    VendaRepository.AtualizarVenda(venda.VendaId);
                    ProdutoRepository.EditarProduto(produto.ProdutoId, null, null, null, produto.Quantidade - produtoVenda.Quantidade);
                }

                context.SaveChanges();
            }
        }

        static public void ExcluirProdutoVenda(ProdutoVenda produtoVenda)
        {
            //no futuro adicionar um metodo para adicionar os produtos de volta
            using (var context = new AutoCenterContext())
            {
                var produto = ProdutoRepository.ProdutoPorId(produtoVenda.ProdutoId);

                produto.Quantidade += produtoVenda.Quantidade;

                context.Produtos.Update(produto);

                context.ProdutoVendas.Remove(produtoVenda);
                context.SaveChanges();
            }
        }

        static public void AtualizarProdutoVenda(ProdutoVenda produtoVenda)
        {
            using (var context = new AutoCenterContext())
            {
                var ProdutoVenda_ = ProdutoVendaPorId(produtoVenda.ProdutoVendaId);

                double diferencaQuantidade = produtoVenda.Quantidade - ProdutoVenda_.Quantidade;

                Produto produto = ProdutoRepository.ProdutoPorId(produtoVenda.ProdutoId);

                ProdutoRepository.EditarProduto(produtoVenda.ProdutoId, null, null, null, produto.Quantidade + diferencaQuantidade);

                context.ProdutoVendas.Update(produtoVenda);

                context.SaveChanges();
            }
        }

        static public List<ProdutoVenda> ListarProdutoVendasPorVenda(int vendaId)
        {
            using (var context = new AutoCenterContext())
            {
                var produtosVenda = context.ProdutoVendas.Where(p => p.VendaId == vendaId).ToList();

                return produtosVenda;
            }
        }

        static public List<ProdutoVenda> ListarProdutoVendas()
        {
            using (var context = new AutoCenterContext())
            {
                var produtosVenda = context.ProdutoVendas.ToList();
                return produtosVenda;
            }
        }

        static public ProdutoVenda ProdutoVendaPorId(int id)
        {
            using (var context = new AutoCenterContext())
            {

                //procura o produto pelo id
                var produtoVenda = context.ProdutoVendas.Find(id);

                if (produtoVenda == null)
                {
                    //throw new ArgumentException("ID não encontrado");
                    return null;
                }

                return produtoVenda;
            }
        }
    }
}
