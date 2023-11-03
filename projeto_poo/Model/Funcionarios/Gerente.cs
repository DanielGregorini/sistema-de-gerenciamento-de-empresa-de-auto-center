using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using Pomelo.EntityFrameworkCore.MySql.Infrastructure;
using System.ComponentModel.DataAnnotations.Schema;

namespace AutoCenter.Model
{
    [Table("tb_gerente")]
    public class Gerente : Funcionario
    {
        [Key]
        int GerenteId { get; set; }
    }
}