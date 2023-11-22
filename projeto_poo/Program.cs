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
                 Gerente gerente = new Gerente
                 {
                     Nome = "gerente2",
                     EmpresaId = 1,
                     Cpf = "111.111.111-11",
                     Login = "gerente2",
                     Senha = "gerente2"
                 };
                 context.Gerentes.Add(gerente);
                 context.SaveChanges();
             }
            */


            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());

        }
    }
}