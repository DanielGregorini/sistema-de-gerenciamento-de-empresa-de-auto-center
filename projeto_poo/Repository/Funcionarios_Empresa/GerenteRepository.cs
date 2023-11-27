using AutoCenter.Data;
using AutoCenter.Model;
using Microsoft.VisualBasic.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoCenter.Repository
{
    public class GerenteRepository
    {
        static public void AdicionarGerente(Gerente novoGerente, string login, string senha)
        {
            using (var context = new AutoCenterContext())
            {
                if (LoginGerente(novoGerente.Login, novoGerente.Senha) || 
                    VendedorRepository.LoginVendedor(novoGerente.Login, novoGerente.Senha) || 
                    CaixaRepository.LoginCaixa(novoGerente.Login, novoGerente.Senha))
                {
                    throw new ArgumentException("Já existe esse login");
                    return;
                }
                if (LoginGerente(login, senha))
                {
                    context.Gerentes.Add(novoGerente);
                    context.SaveChanges();
                }
                else
                {
                    throw new ArgumentException("Apenas gerentes podem criar novos gerentes");
                }
            }
        }

        static public void ExcluirCliente(Gerente gerente, string login, string senha)
        {

            using (var context = new AutoCenterContext())
            {

                if (LoginGerente(login, senha))
                {
                    context.Gerentes.Remove(gerente);
                    context.SaveChanges();
                }
                else
                {
                    throw new ArgumentException("Apenas gerentes podem deletar gerentes");
                }
            }
        }

        static public List<Gerente> ListarGerentes()
        {
            using (var context = new AutoCenterContext())
            {
                var gerentes = context.Gerentes.ToList();
                return gerentes;
            }
        }

        static public Gerente GerentePorId(int id)
        {
            using (var context = new AutoCenterContext())
            {
                //procura o gerente pelo id
                var gerente = context.Gerentes.Find(id);

                if (gerente == null)
                {
                    throw new ArgumentException("ID não encontrado");
                }

                return gerente;
            }
        }

        static public bool LoginGerente(string login, string senha)
        {
            using (var context = new AutoCenterContext())
            {
                var gerente = context.Gerentes.FirstOrDefault(c => c.Login == login);

                if (gerente != null && gerente.Senha == senha)
                {

                    return true;
                }

                return false;
            }
        }

        static public Gerente RetornarGerentePorLogin(string login, string senha)
        {
            using (var context = new AutoCenterContext())
            {
                var gerente = context.Gerentes.FirstOrDefault(c => c.Login == login);

                if (gerente != null && gerente.Senha == senha)
                {

                    return gerente;
                }

                return null;
            }
        }
    }
}