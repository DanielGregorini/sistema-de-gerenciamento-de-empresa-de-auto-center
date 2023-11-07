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
    [Table("tb_ordemdeservico")]
    public class OrdemDeServico
    {
        public int OrdemDeServicoId { get; set; }
        public string TipoDeServico { get; set; }
        public string Descricao { get; set; }
        public int ClienteId { get; set; }
        public Cliente Cliente { get; set; }
        public int VendedorId { get; set; }
        public Vendedor Vendedor { get; set; }
        public List<ProdutoOrdemDeServico> ProdutosUtilizados { get; set; }
        public string Estado { get; set; }
        public double ValorTotal { get; set; }
        public DateTime HorarioDeEntrega { get; set; }
    }
}
