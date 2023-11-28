using AutoCenter.Data;
using AutoCenter.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoCenter.Repository
{
    public class VendedorRepository
    {
        static public void AdicionarVendedor(Vendedor vendedor, string loginGerente, string senhaGerente)
        {
            using (var context = new AutoCenterContext())
            {
                if (GerenteRepository.LoginGerente(vendedor.Login, vendedor.Senha) ||
                    LoginVendedor(vendedor.Login, vendedor.Senha) ||
                    CaixaRepository.LoginCaixa(vendedor.Login, vendedor.Senha))
                {
                    throw new ArgumentException("Já existe esse login");
                    return;
                }
                if (GerenteRepository.LoginGerente(loginGerente, senhaGerente))
                {
                    vendedor.EmpresaId = 1;
                    context.Vendedores.Add(vendedor);
                    context.SaveChanges();
                }
                else
                {
                    throw new ArgumentException("Apenas gerentes podem criar novos vendedores");
                }
            }
        }

        static public void ExcluirVendedor(Vendedor vendedor, string loginGerente, string senhaGerente)
        {

            using (var context = new AutoCenterContext())
            {
                if (GerenteRepository.LoginGerente(loginGerente, senhaGerente))
                {
                    context.Vendedores.Remove(vendedor);
                    context.SaveChanges();
                }
                else
                {
                    throw new ArgumentException("Apenas gerentes podem deletar vendedores");
                }
                
            }
        }

        static public List<Vendedor> ListarVendedores()
        {
            using (var context = new AutoCenterContext())
            {
                var vendedores = context.Vendedores.ToList();
                return vendedores;
            }
        }

        static public void EditarVendedor(int id, string? novoNome, string? novoCpf, 
            string? novoLogin, string? novaSenha)
        {
            using (var context = new AutoCenterContext())
            {
                var  vendedorParaEditar = context.Vendedores.Find(id);

                if (vendedorParaEditar == null)
                {
                    throw new ArgumentException("ID não encontrado");
                    return;
                }

                if (!string.IsNullOrWhiteSpace(novoNome))
                {
                    vendedorParaEditar.Nome = novoNome;
                }


                if (!string.IsNullOrWhiteSpace(novoCpf))
                {
                    vendedorParaEditar.Cpf = novoCpf;
                }

                if (!string.IsNullOrWhiteSpace(novoLogin))
                {
                    vendedorParaEditar.Login = novoLogin;
                }

                if (!string.IsNullOrWhiteSpace(novaSenha))
                {
                    vendedorParaEditar.Senha = novaSenha;
                }

                context.SaveChanges();
            }
        }

        static public Vendedor VendedorPorId(int id)
        {
            using (var context = new AutoCenterContext())
            {
                //procura o vendedor pelo id
                var vendedor = context.Vendedores.Find(id);

                if (vendedor == null)
                {
                    throw new ArgumentException("ID não encontrado");
                }

                return vendedor;
            }  
        }

        static public bool LoginVendedor(string login, string senha)
        {
            using (var context = new AutoCenterContext())
            {
                var vendedor = context.Vendedores.FirstOrDefault(c => c.Login == login);

                if (vendedor != null && vendedor.Senha == senha)
                {

                    return true;
                }

                return false;
            }
        }

        static public Vendedor RetornarVendedorPorLogin(string login, string senha)
        {
            using (var context = new AutoCenterContext())
            {
                var vendedor = context.Vendedores.FirstOrDefault(c => c.Login == login);

                if (vendedor != null && vendedor.Senha == senha)
                {

                    return vendedor;
                }

                return null;
            }
        }
    }
}
