using AutoCenter.Data;
using AutoCenter.Model;
using Microsoft.VisualBasic.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoCenter.Repository
{
    public class CaixaRepository
    {
        static public void AdicionarCaixa(Caixa caixa, string loginGerente, string senhaGerente)
        {
            using (var context = new AutoCenterContext())
            {

                if (GerenteRepository.LoginGerente(loginGerente, senhaGerente))
                {
                    context.Caixas.Add(caixa);
                    context.SaveChanges();
                }
                else
                {
                    throw new ArgumentException("Apenas gerentes podem criar novos caixas");
                }
            }
        }

        static public void ExcluirCaixa(Caixa caixa, string loginGerente, string senhaGerente)
        {
            using (var context = new AutoCenterContext())
            {
                if (GerenteRepository.LoginGerente(loginGerente, senhaGerente))
                {
                    context.Caixas.Remove(caixa);
                    context.SaveChanges();
                }
                else
                {
                    throw new ArgumentException("Apenas gerentes podem deletar caixas");
                }            
            }
        }

        static public List<Caixa> ListarCaixas()
        {
            using (var context = new AutoCenterContext())
            {
                var caixas = context.Caixas.ToList();
                return caixas;
            }
        }
         
        static public Caixa CaixaPorId(int id)
        {
            using (var context = new AutoCenterContext())
            {
                //procura o caixa pelo id
                var caixa = context.Caixas.Find(id);

                if (caixa == null)
                {
                    throw new ArgumentException("ID não encontrado");
                }

                return caixa;
            }
        }

        static public bool LoginCaixa(string login, string senha)
        {
            using (var context = new AutoCenterContext())
            {
                var caixa = context.Caixas.FirstOrDefault(c => c.Login == login);

                if (caixa != null && caixa.Senha == senha)
                {
                   
                    return true;
                }

                return false;
            }
        }
    }
}
