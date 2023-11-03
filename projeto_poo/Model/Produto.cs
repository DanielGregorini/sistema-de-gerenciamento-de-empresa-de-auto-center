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
    [Table("tb_produto")]
    public class Produto
    {
        [Key]
        int ProdutoId { get; set; }
        string Nome { get; set; }
        string Descricao { get; set; }
        double Preco { get; set; }
        double Quantidade { get; set; }
        double CustoMedio { get; set; }
        double CustoUltimaEntrada{ get; set; }
    }
}
