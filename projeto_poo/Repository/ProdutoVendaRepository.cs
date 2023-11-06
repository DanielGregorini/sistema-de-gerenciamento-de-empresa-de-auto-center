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
                context.ProdutoVendas.Add(produtoVenda);
                context.SaveChanges();
            }
        }

        static public void ExcluirProduto(ProdutoVenda produtoVenda)
        {

            using (var context = new AutoCenterContext())
            {
                context.ProdutoVendas.Remove(produtoVenda);
                context.SaveChanges();
            }
        }






    }
}
