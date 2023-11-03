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
    [Table("tb_produto_ordemdeservico")]
    public class ProdutoOrdemDeServico
    {
        [Key]
        public int ProdutoOrdemDeServicoId { get; set; }
        public int ProdutoId { get; set; }
        public Produto Produto { get; set; }
        public int OrdemDeServicoId { get; set; }
        public OrdemDeServico OrdemDeServico { get; set; }
        public double Quantidade { get; set; }
    }
}
