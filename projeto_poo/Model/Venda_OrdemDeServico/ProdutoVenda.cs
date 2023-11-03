﻿using System;
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using Pomelo.EntityFrameworkCore.MySql.Infrastructure;
using System.ComponentModel.DataAnnotations.Schema;
using System.Numerics;

namespace AutoCenter.Model
{
    [Table("tb_produto_venda")]
    public class ProdutoVenda
    {
        [Key]
        public int ProdutoVendaId { get; set; }
        public int ProdutoId { get; set; }
        public Produto Produto { get; set; }
        public int VendaId { get; set; }
        public Venda Venda { get; set; }
        public double Quantidade { get; set; }
    }
}