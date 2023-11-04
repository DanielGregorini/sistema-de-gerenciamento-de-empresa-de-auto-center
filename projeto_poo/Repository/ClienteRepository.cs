using System;
using AutoCenter.Data;
using AutoCenter.Model;

namespace AutoCenter.Repository
{
    public class ClienteRepository
    {
        static public void AdicionarCliente(Cliente cliente)
        {
            using (var context = new AutoCenterContext())
            {
                context.Clientes.Add(cliente);
                context.SaveChanges();
            }
        }

        static public void ExcluirCliente(Cliente cliente)
        {

            using (var context = new AutoCenterContext())
            {
                context.Clientes.Remove(cliente);
                context.SaveChanges();
            }
        }

        static public void EditarCliente(int id, string? novoNome, string? novoRg, 
            string? novoCpf_Cnpj, string? novoEndereco, string? novoTelefone)
        {
            using (var context = new AutoCenterContext())
            {
                var clienteParaEditar = context.Clientes.Find(id);

                if (clienteParaEditar == null)
                {
                    throw new ArgumentException("ID não encontrado");
                    return;
                }

                if (!string.IsNullOrWhiteSpace(novoNome))
                {
                    clienteParaEditar.Nome = novoNome;
                }

                if (!string.IsNullOrWhiteSpace(novoRg))
                {
                    clienteParaEditar.Rg = novoRg;
                }

                if (!string.IsNullOrWhiteSpace(novoCpf_Cnpj))
                {
                    clienteParaEditar.Cpf_Cnpj = novoCpf_Cnpj; 
                }

                if (!string.IsNullOrWhiteSpace(novoEndereco))
                {
                    clienteParaEditar.Endereco = novoEndereco;
                }

                if (!string.IsNullOrWhiteSpace(novoTelefone))
                {
                    clienteParaEditar.Telefone = novoTelefone;
                }

                context.SaveChanges();
            }
        }

        static public List<Cliente> ListarParticipantes()
        {
            using (var context = new AutoCenterContext())
            {
                var clientes = context.Clientes.ToList();
                return clientes;
            }
        }

        static public Cliente ClientePorId(int id)
        {
            using (var context = new AutoCenterContext())
            {
                //procura o cliente pela id
                var cliente = context.Clientes.Find(id);

                if (cliente == null)
                {
                    throw new ArgumentException("ID não encontrado");
                }

                return cliente;
            }
        }
    }
}
