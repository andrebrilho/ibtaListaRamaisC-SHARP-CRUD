using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace IBTA.ListaRamais.Models
{
    public class Funcionário
    {
        [Key]
        public int CodigoFuncionario { get; set; }
        public int CodigoDepartamento { get; set; }
        public string Nome { get; set; }
        public string Departamento { get; set; }
        public string Email { get; set; }
        public int Ramal { get; set; }
        public string Cargo { get; set; }
    }
}