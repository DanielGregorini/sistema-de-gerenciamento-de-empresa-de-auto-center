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
    [Table("tb_venda")]
    public class Venda
    {
        [Key]
        int VendaId { get; set; }
        List<ProdutoVenda> ProdutosVendidos { get; set; }
        int ClienteId { get; set; }
        Cliente Cliente { get; set; }
        double ValorTotal { get; set; }
        string Estado { get; set; }
        DateTime HorioRealizacao { get; set; }
        
    }
}
