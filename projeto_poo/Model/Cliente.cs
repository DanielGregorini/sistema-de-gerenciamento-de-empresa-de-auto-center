using System;
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using Pomelo.EntityFrameworkCore.MySql.Infrastructure;
using System.ComponentModel.DataAnnotations.Schema;

namespace AutoCenter.Model
{
    [Table("tb_cliente")]
    public class Cliente
    {
        [Key]
        int ClienteId { get; set; }
        string Nome { get; set; }
        string? Rg { get; set; }
        string? Cpf_Cnpj { get; set; }
        string? Endereco { get; set; }
        string? Telefone { get; set; }
    }
}
