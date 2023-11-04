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
    [Table("tb_cliente")]
    public class Cliente
    {
        public int ClienteId { get; set; }
        public string Nome { get; set; }
        public string? Rg { get; set; }
        public string? Cpf_Cnpj { get; set; }
        public string? Endereco { get; set; }
        public string? Telefone { get; set; }
        public List<Veiculo>? Veiculos { get; set; }
        public List<Venda>? Vendas { get; set; }
    }
}
