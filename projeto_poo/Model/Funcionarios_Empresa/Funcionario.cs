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
    public class Funcionario
    {
        public int EmpresaId { get; set; }
        public Empresa Empresa { get; set; }
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public string Login { get; set; }
        public string Senha { get; set; }
    }
}
