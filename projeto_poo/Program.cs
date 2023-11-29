using AutoCenter.Data;
using AutoCenter.Model;
using AutoCenter.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoCenter;


namespace projeto_poo
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {

            /*
             Empresa empresa = new Empresa();

             empresa.Nome = "Video Som AutoCenter";
             empresa.RazaoSocial = "Auto Center";
             empresa.CNPJ = "4444-44444-4444/1000";
             empresa.Endereco = "Rua Paraguai, 1039";
             empresa.Telefone = "3264-1000";

             using (var context = new AutoCenterContext())
             {
                 context.Empresas.Add(empresa);
                 context.SaveChanges();
             }
            

             using (var context = new AutoCenterContext())
             {
                    Vendedor vendedor1 = new Vendedor
                 {
                     Nome = "vendedor1",
                     EmpresaId = 1,
                     Cpf = "211.111.111-11",
                     Login = "vendedor1",
                     Senha = "vendedor"
                 };

                Vendedor vendedor2 = new Vendedor
                 {
                     Nome = "vendedor2",
                     EmpresaId = 1,
                     Cpf = "211.111.111-11",
                     Login = "vendedor2",
                     Senha = "vendedor"
                 };

                 context.Vendedores.Add(vendedor1);
                 context.Vendedores.Add(vendedor2);
                 context.SaveChanges();
             }
                 using (var context = new AutoCenterContext())
                {
                // public int ProdutoId { get; set; }
                //public string Nome { get; set; }
                // public string Descricao { get; set; }
                // public double Preco { get; set; }
                //  public double Quantidade { get; set; }
                //  public double CustoMedio { get; set; }
                //  public double CustoUltimaEntrada { get; set; }

                Produto produto1 = new Produto
                {
                    Nome = "Controle copiador 433",
                    Descricao = "Som muito Bom",
                    Preco = 45.99,
                    Quantidade = 45,
                    CustoUltimaEntrada = 9.83
                };

                Produto produto2 = new Produto
                {
                    Nome = "Pelicula de carro carbono",
                    Descricao = "deixa bem escuro",
                    Preco = 610.99,
                    Quantidade = 20,
                    CustoUltimaEntrada = 10
                };

                ProdutoRepository.AdicionarProduto(produto1);
                ProdutoRepository.AdicionarProduto(produto2);

                context.SaveChanges();
            }
            */
            /*
            public int VendaId { get; set; }
            public List<ProdutoVenda> ProdutosVendidos { get; set; }
            public int ClienteId { get; set; }
            public Cliente Cliente { get; set; }
            public int VendedorId { get; set; }
            public Vendedor Vendedor { get; set; }
            public double ValorTotal { get; set; }
            public string Estado { get; set; }
            public DateTime HorioRealizacao { get; set; }
            */

            /*
            public class ProdutoVenda
        {
            public int ProdutoVendaId { get; set; }
            public int ProdutoId { get; set; }
            public Produto Produto { get; set; }
            public int VendaId { get; set; }
            public Venda Venda { get; set; }
            public double Quantidade { get; set; }



            Cliente cliente = new Cliente
                {
                    Nome = "Luis",
                    Cpf_Cnpj = "233232323",
                    Rg = "32323-3",
                    Endereco = "Rua Argentina 293, centro",
                    Telefone = "4532321111"
                };
        }
            
            Venda venda1 = new Venda
                {
                    ClienteId = 1,
                    VendedorId = 5,
                    HorarioRealizacao = DateTime.Now,
                };

                VendaRepository.AdicionarVenda(venda1);
            
            ProdutoVenda produtovenda1 = new ProdutoVenda
                {
                    ProdutoId= 1,
                    VendaId = 1,
                    Quantidade = 5,

                };
               
                ProdutoVendaRepository.AdicionarProdutoVenda(produtovenda1);


            var ordemDeServico = new OrdemDeServico
            {
                TipoDeServico = $"Instalação de som",
                Descricao = $"Descrição do Serviço 5",
                ClienteId = 1, // Cliente com Id 1
                VendedorId = 5, // Vendedor com Id 1
                HorarioDeEntrega = DateTime.Now.AddDays(1),


            };
            */

            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());
        }
    }
}