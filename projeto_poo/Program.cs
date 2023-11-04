using AutoCenter.Data;
using AutoCenter.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            */


            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());

        }
    }
}