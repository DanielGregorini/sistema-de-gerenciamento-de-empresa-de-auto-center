using AutoCenter.Data;
using AutoCenter.Model;
using Microsoft.VisualBasic.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoCenter.Repository.Funcionarios_Empresa
{
    public class EmpresaRepository
    {
        static public void EditarEmpresa(int id, string loginGerente, string senhaGerente, string novoNome, string novoRazaoSocial,
            string novoCNPJ, string novoEndereco, string novoTelefone)
        {
            using (var context = new AutoCenterContext())
            {

                if (!GerenteRepository.LoginGerente(loginGerente, senhaGerente))
                {
                    throw new ArgumentException("Login errado");
                    return;
                }

                var empresa = context.Empresas.Find(id);

                if (empresa == null)
                {
                    throw new ArgumentException("ID não encontrado");
                    return;
                }

                if (!string.IsNullOrWhiteSpace(novoNome))
                {
                    empresa.Nome = novoNome;
                }

                if (!string.IsNullOrWhiteSpace(novoRazaoSocial))
                {
                    empresa.RazaoSocial = novoRazaoSocial;
                }

                if (!string.IsNullOrWhiteSpace(novoCNPJ))
                {
                    empresa.CNPJ = novoCNPJ;
                }

                if (!string.IsNullOrWhiteSpace(novoEndereco))
                {
                    empresa.Endereco = novoEndereco;
                }

                if (!string.IsNullOrWhiteSpace(novoTelefone))
                {
                    empresa.Telefone = novoTelefone;
                }

                context.SaveChanges();

            }
        }
    }
}
