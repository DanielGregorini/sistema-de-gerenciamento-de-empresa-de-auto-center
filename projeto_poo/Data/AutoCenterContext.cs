using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using Pomelo.EntityFrameworkCore.MySql.Infrastructure;
using AutoCenter.Model;
using AutoCenter.Data;
using Microsoft.Extensions.Logging;
using System.Diagnostics;
using AutoCenter.Repository;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace AutoCenter.Data
{
    class AutoCenterContext : DbContext
    {
        //empresa
        public DbSet<Empresa> Empresas { get; set; }

        //funcionarios
        public DbSet<Vendedor> Vendedores { get; set; }
        public DbSet<Caixa> Caixas { get; set; }
        public DbSet<Vendedor> Gerentes { get; set; }

        //clientes e seus veiculos
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Veiculo> Veiculos { get; set; }

        //produtos
        public DbSet<Produto> Produtos { get; set; }

        //vendas
        public DbSet<ProdutoVenda> ProdutoVendas { get; set; }
        public DbSet<Venda> Vendas { get; set; }

        //ordem de serviço
        public DbSet<ProdutoOrdemDeServico> ProdutoOrdemDeServicos { get; set; }
        public DbSet<OrdemDeServico> OrdensDeServico { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                //ver os log do efcore
                //optionsBuilder.LogTo(Console.WriteLine, LogLevel.Information);

                string connectionString = "Server=localhost;Database=db_autocenter;User=root;Password=admin;";

                optionsBuilder.UseMySql(connectionString, new MySqlServerVersion(new Version(8, 0, 25)));
            }
        }
       
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //funcionarios
            modelBuilder.Entity<Caixa>()
                .HasKey(pk => pk.CaixaId);

            modelBuilder.Entity<Vendedor>()
                .HasKey(pk => pk.VendedorId);

            modelBuilder.Entity<Gerente>()
                .HasKey(pk => pk.GerenteId);

            //ordens de serviço
            modelBuilder.Entity<OrdemDeServico>()
                .HasKey(pk => pk.OrdemDeServicoId);

            modelBuilder.Entity<ProdutoOrdemDeServico>()
                .HasKey(pk => pk.ProdutoOrdemDeServicoId);

            modelBuilder.Entity<ProdutoOrdemDeServico>()
                .HasOne(po => po.OrdemDeServico) // Define a propriedade de navegação para a OrdemDeServico
                .WithMany(os => os.ProdutosUtilizados) // Define o tipo de relacionamento (um-para-muitos)
                .HasForeignKey(po => po.OrdemDeServicoId); // Define a chave estrangeira para OrdemDeServicoId

            //venda
            modelBuilder.Entity<Venda>()
                .HasKey(pk => pk.VendaId);

            modelBuilder.Entity<Venda>()
                .HasOne(v => v.Cliente)
                .WithMany(c => c.Vendas)
                .HasForeignKey(v => v.ClienteId);

            modelBuilder.Entity<ProdutoVenda>()
                .HasKey(pk => pk.ProdutoVendaId);

            modelBuilder.Entity<ProdutoVenda>()
                .HasOne(po => po.Venda) // Define a propriedade de navegação para a OrdemDeServico
                .WithMany(os => os.ProdutosVendidos) // Define o tipo de relacionamento (um-para-muitos)
                .HasForeignKey(po => po.VendaId); // Define a chave estrangeira para OrdemDeServicoId

            //Produto
            modelBuilder.Entity<Produto>()
                .HasKey(pk => pk.ProdutoId);

            //Cliente, veiculos e empresa
            modelBuilder.Entity<Cliente>()
                .HasKey(pk => pk.ClienteId);

            modelBuilder.Entity<Veiculo>()
                .HasKey(pk => pk.VeiculoId);
            
            modelBuilder.Entity<Veiculo>()
                .HasOne(v => v.Cliente)
                .WithMany(c => c.Veiculos)
                .HasForeignKey(v => v.ClienteId);

            modelBuilder.Entity<Empresa>()
                .HasKey(pk => pk.EmpresaId);

        }
    }
}