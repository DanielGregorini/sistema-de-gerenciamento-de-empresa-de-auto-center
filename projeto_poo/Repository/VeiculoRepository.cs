using AutoCenter.Data;
using AutoCenter.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoCenter.Repository
{
    public class VeiculoRepository
    {
        static public void AdicionarVeiculo(Veiculo veiculo)
        {
            using (var context = new AutoCenterContext())
            {
                context.Veiculos.Add(veiculo);
                context.SaveChanges();
            }
        }

        static public void ExcluirVeiculo(Veiculo veiculo)
        {

            using (var context = new AutoCenterContext())
            {
                context.Veiculos.Remove(veiculo);
                context.SaveChanges();
            }
        }
    
        static public void EditarVeiculo(int id, string? novoTipo, string? NovoModelo,
            int? novoClienteId, string? novaPlaca)
        {
            using (var context = new AutoCenterContext())
            {
                var veiculoParaEditar = context.Veiculos.Find(id);

                if (veiculoParaEditar == null)
                {
                    throw new ArgumentException("ID não encontrado");
                    return;
                }

                if (!string.IsNullOrWhiteSpace(novoTipo))
                {
                    veiculoParaEditar.Tipo = novoTipo;
                }

                if (!string.IsNullOrWhiteSpace(NovoModelo))
                {
                    veiculoParaEditar.Modelo = NovoModelo;
                }

                if (novoClienteId != null && novoClienteId > 0)
                {
                    veiculoParaEditar.ClienteId = novoClienteId.Value;
                }

                if (!string.IsNullOrWhiteSpace(novaPlaca))
                {
                    veiculoParaEditar.Placa = novaPlaca;
                }

                context.SaveChanges();
            }
        }

        static public List<Veiculo> ListarVeiculos()
        {
            using (var context = new AutoCenterContext())
            {
                var veiculos = context.Veiculos.ToList();
                return veiculos;
            }
        }

        static public Veiculo VeiculoPorId(int id)
        {
            using (var context = new AutoCenterContext())
            {
                //procura o cliente pelo id
                var veiculo = context.Veiculos.Find(id);

                if (veiculo == null)
                {
                    throw new ArgumentException("ID não encontrado");
                }

                return veiculo;
            }
        }
    }
}
