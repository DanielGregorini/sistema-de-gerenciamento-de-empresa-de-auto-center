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
using AutoCenter.Model;
using AutoCenter.Repository;

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
        public DbSet<OrdemDeServico> OrdemDeServicos { get; set; }

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
            /*
            modelBuilder.Entity<ParticipanteEvento>()
                .HasKey(pe => new { pe.IdParticipante, pe.IdEvento });

            modelBuilder.Entity<ParticipanteEvento>()
                .HasOne(pe => pe.Participante)
                .WithMany(p => p.EventosInscritos)
                .HasForeignKey(pe => pe.IdParticipante);

            modelBuilder.Entity<ParticipanteEvento>()
                .HasOne(pe => pe.Evento)
                .WithMany(e => e.ParticipantesInscritos)
                .HasForeignKey(pe => pe.IdEvento);
            
            */
        }
     
    }
}