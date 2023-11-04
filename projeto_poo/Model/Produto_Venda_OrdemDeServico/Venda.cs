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
    [Table("tb_venda")]
    public class Venda
    {
        public int VendaId { get; set; }
        public List<ProdutoVenda> ProdutosVendidos { get; set; }
        public int ClienteId { get; set; }
        public Cliente Cliente { get; set; }
        public double ValorTotal { get; set; }
        public string Estado { get; set; }
        public DateTime HorioRealizacao { get; set; }
    }
}
