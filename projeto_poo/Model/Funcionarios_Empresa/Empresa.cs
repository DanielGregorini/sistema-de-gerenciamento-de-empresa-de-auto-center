﻿using System;
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using Pomelo.EntityFrameworkCore.MySql.Infrastructure;
using System.ComponentModel.DataAnnotations.Schema;

namespace AutoCenter.Model
{
    [Table("tb_empresa")]
    public class Empresa
    {
        public int EmpresaId { get; set; }
        public string Nome { get; set; }
        public string RazaoSocial { get; set; }
        public string CNPJ { get; set; }
        public string Endereco { get; set; }
        public string? Telefone { get; set; }
        public List<Caixa>? Caixas { get; set; }
        public List<Vendedor>? Vendedores { get; set; }
        public List<Gerente>? Gerentes{ get; set; }
    }
}
