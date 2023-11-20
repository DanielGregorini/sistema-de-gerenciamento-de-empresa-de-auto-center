﻿using AutoCenter.Data;
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

        static public void ExcluirVenda(OrdemDeServico ordemDeServico)
        {
            using (var context = new AutoCenterContext())
            {
                context.OrdensDeServico.Remove(ordemDeServico);
                context.SaveChanges();
            }
        }

        static public void MudarEstadoOrdemDeServico(OrdemDeServico ordemDeServico)
        {
            using (var context = new AutoCenterContext())
            {
                ordemDeServico.Estado = "Pago";
                context.SaveChanges();
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