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
    public class Veiculo
    {
        [Key]
        int VeiculoId { get; set; } 
        string? Tipo { get; set; } //carro, moto, barco...
        string Modelo { get; set; }
        int ClienteId { get; set; }
        Cliente Cliente { get; set; }
        string? Placa { get; set; }
    }
}
