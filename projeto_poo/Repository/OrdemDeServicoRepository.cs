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
                ordemDeServico.Estado = "NãoPago";
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
                }

                return ordemDeServico;
            }
        }
    }
}
