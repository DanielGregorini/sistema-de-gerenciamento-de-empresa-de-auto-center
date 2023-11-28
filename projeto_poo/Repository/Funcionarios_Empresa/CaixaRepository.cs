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
                if(GerenteRepository.LoginGerente(caixa.Login, caixa.Senha) || 
                    VendedorRepository.LoginVendedor(caixa.Login, caixa.Senha) || LoginCaixa(caixa.Login, caixa.Senha))
                {
                    throw new ArgumentException("Já existe esse login");
                    return;
                }else if (GerenteRepository.LoginGerente(loginGerente, senhaGerente))
                {
                    caixa.EmpresaId = 1;
                    context.Caixas.Add(caixa);
                    context.SaveChanges();
                }
                else
                {
                    throw new ArgumentException("Apenas gerentes podem criar novos caixas");
                }
            }
        }

        static public void EditarCaixa(int id, string? novoNome, string? novoCpf,
            string? novoLogin, string? novaSenha)
        {
            using (var context = new AutoCenterContext())
            {
                var CaixaParaEditar = context.Caixas.Find(id);

                if (CaixaParaEditar == null)
                {
                    throw new ArgumentException("ID não encontrado");
                    return;
                }

                if (!string.IsNullOrWhiteSpace(novoNome))
                {
                    CaixaParaEditar.Nome = novoNome;
                }

                if (!string.IsNullOrWhiteSpace(novoCpf))
                {
                    CaixaParaEditar.Cpf = novoCpf;
                }

                if (!string.IsNullOrWhiteSpace(novoLogin))
                {
                    CaixaParaEditar.Login = novoLogin;
                }

                if (!string.IsNullOrWhiteSpace(novaSenha))
                {
                    CaixaParaEditar.Senha = novaSenha;
                }

                context.SaveChanges();
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

        static public Caixa RetornarCaixaPorLogin(string login, string senha)
        {
            using (var context = new AutoCenterContext())
            {
                var caixa = context.Caixas.FirstOrDefault(c => c.Login == login);

                if (caixa != null && caixa.Senha == senha)
                {

                    return caixa;
                }

                return null;
            }

        }
    }
}
