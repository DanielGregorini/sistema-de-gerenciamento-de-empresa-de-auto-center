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
    [Table("tb_vendedor")]
    public class Vendedor : Funcionario
    {
        [Key]
        public int VendedorId { get; set; }
    }
}
