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
        public DbSet<Gerente> Gerentes { get; set; }

        //clientes e seus veiculos
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Veiculo> Veiculos { get; set; }

        //produtos
        public DbSet<Produto> Produtos { get; set; }

        //vendas
        public DbSet<ProdutoVenda> ProdutoVendas { get; set; }
        public DbSet<Venda> Vendas { get; set; }

        //ordem de serviço
        public DbSet<ProdutoOrdemDeServico> ProdutoOrdensDeServico { get; set; }
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
            // Configuração das entidades

            // Funcionários
            modelBuilder.Entity<Caixa>()
                .HasKey(pk => pk.CaixaId);

            //uma empresa muitos caixas
            modelBuilder.Entity<Caixa>()
                .HasOne(v => v.Empresa)
                .WithMany(e => e.Caixas)
                .HasForeignKey(v => v.EmpresaId);

            modelBuilder.Entity<Vendedor>()
                .HasKey(pk => pk.VendedorId);

            //uma empresa muitos vendedores
            modelBuilder.Entity<Vendedor>()
                .HasOne(v => v.Empresa)
                .WithMany(e => e.Vendedores)
                .HasForeignKey(v => v.EmpresaId);

            modelBuilder.Entity<Gerente>()
                .HasKey(pk => pk.GerenteId);

            //uma empresa muitos gerentes
            modelBuilder.Entity<Gerente>()
               .HasOne(v => v.Empresa)
                .WithMany(e => e.Gerentes)
                .HasForeignKey(v => v.EmpresaId);

            // Ordens de serviço

            modelBuilder.Entity<OrdemDeServico>()
                .HasKey(pk => pk.OrdemDeServicoId);

            // Relacionamento entre OrdemDeServico e Cliente
            modelBuilder.Entity<OrdemDeServico>()
                .HasOne(v => v.Cliente)
                .WithMany(c => c.OrdensDeServico) // Define o relacionamento (um-para-muitos)
                .HasForeignKey(v => v.ClienteId);

            // Relacionamento entre OrdemDeServico e Vendedor
            modelBuilder.Entity<OrdemDeServico>()
                .HasOne(v => v.Vendedor)
                .WithMany(c => c.OrdensDeServico) // Define o relacionamento (um-para-muitos)
                .HasForeignKey(v => v.VendedorId);

            // Produtos de OrdemDeServico
            modelBuilder.Entity<ProdutoOrdemDeServico>()
                .HasKey(pk => pk.ProdutoOrdemDeServicoId);

            modelBuilder.Entity<ProdutoOrdemDeServico>()
                .HasOne(po => po.OrdemDeServico) // Define a propriedade de navegação para a OrdemDeServico
                .WithMany(os => os.ProdutosUtilizados) // Define o relacionamento (um-para-muitos)
                .HasForeignKey(po => po.OrdemDeServicoId); // Define a chave estrangeira para OrdemDeServicoId

            // Vendas
            modelBuilder.Entity<Venda>()
                .HasKey(pk => pk.VendaId);

            // Relacionamento entre Venda e Cliente
            modelBuilder.Entity<Venda>()
                .HasOne(v => v.Cliente)
                .WithMany(c => c.Vendas)
                .HasForeignKey(v => v.ClienteId);

            // Relacionamento entre Venda e Vendedor
            modelBuilder.Entity<Venda>()
                .HasOne(v => v.Vendedor)
                .WithMany(c => c.Vendas) // Define o relacionamento (um-para-muitos)
                .HasForeignKey(v => v.VendedorId);

            // Produtos de Venda
            modelBuilder.Entity<ProdutoVenda>()
                .HasKey(pk => pk.ProdutoVendaId);

            modelBuilder.Entity<ProdutoVenda>()
                .HasOne(po => po.Venda) // Define a propriedade de navegação para a Venda
                .WithMany(os => os.ProdutosVendidos) // Define o relacionamento (um-para-muitos)
                .HasForeignKey(po => po.VendaId); // Define a chave estrangeira para VendaId

            // Produto
            modelBuilder.Entity<Produto>()
                .HasKey(pk => pk.ProdutoId);

            // Cliente, Veículos e Empresa
            modelBuilder.Entity<Cliente>()
                .HasKey(pk => pk.ClienteId);

            modelBuilder.Entity<Veiculo>()
                .HasKey(pk => pk.VeiculoId);

            // Relacionamento entre Veículo e Cliente
            modelBuilder.Entity<Veiculo>()
                .HasOne(v => v.Cliente)
                .WithMany(c => c.Veiculos)
                .HasForeignKey(v => v.ClienteId);

            modelBuilder.Entity<Empresa>()
                .HasKey(pk => pk.EmpresaId);
        }

    }
}