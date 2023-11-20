﻿using AutoCenter.Data;
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

                if (GerenteRepository.LoginGerente(loginGerente, senhaGerente))
                {
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
    }
}