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
    [Table("tb_veiculo")]
    public class ProdutoVenda
    {
        [Key]
        int IdProdutoVenda { get; set; }
        int ProdutoId { get; set; }
        Produto Produto { get; set; }
        double Quantidade { get; set; }
    }
}