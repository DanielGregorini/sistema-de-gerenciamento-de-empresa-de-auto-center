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
    [Table("tb_veiculo")]
    public class Veiculo
    {
        public int VeiculoId { get; set; }
        public string? Tipo { get; set; } //carro, moto, barco...
        public string Modelo { get; set; }
        public int ClienteId { get; set; }
        public Cliente Cliente { get; set; }
        public string? Placa { get; set; }
        //public List<OrdemDeServico>? OrdensDeServico { get; set; }

    }
}
