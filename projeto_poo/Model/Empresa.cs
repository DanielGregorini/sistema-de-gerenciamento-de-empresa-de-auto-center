using System;
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using Pomelo.EntityFrameworkCore.MySql.Infrastructure;
using System.ComponentModel.DataAnnotations.Schema;

namespace projeto_poo.Model
{
    [Table("tb_empresa")]
    public class Empresa
    {
        [Key]
        int EmpresaId { get; set; }
        string Nome { get; set; }
        string RazaoSocial { get; set; }
        string CNPJ { get; set; }
        string Endereco { get; set; }
        string Telefone { get; set; }
    }
}
