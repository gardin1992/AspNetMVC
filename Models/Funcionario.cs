using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication2.Models
{
    [Table("Funcionarios")]
    public class Funcionario
    {
        [Key]
        public int FuncionarioId { get; set; }

        [Required]
        public string Nome { get; set; }

        [Required]
        public string Cidade { get; set; }

        [Required]
        public string Departamento { get; set; }

        [Required]
        public string Sexo { get; set; }
    }
}
