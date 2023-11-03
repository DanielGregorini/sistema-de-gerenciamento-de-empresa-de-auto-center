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
        int OrdemDeServicoId { get; set; }
        string TipoDeServico { get; set; }
        string Descricao { get; set; }
        int VendedorId { get; set; }
        Vendedor Vendedor { get; set; }
        List<ProdutoOrdemDeServico> ProdutosUtilizados { get; set; }
        string Estado { get; set; }
        DateTime HorarioDeEntrega { get; set; }
    }
}
