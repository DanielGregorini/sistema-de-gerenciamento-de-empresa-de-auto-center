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
    [Table("tb_funcionario")]
    public class Funcionario
    {
        [Key]
        int FuncionarioId { get; set; }
        Empresa Empresa { get; set; }
        string Nome { get; set; }
        string Cpf { get; set; }
        string Login { get; set; }
        string Senha { get; set; }  
    }
}
