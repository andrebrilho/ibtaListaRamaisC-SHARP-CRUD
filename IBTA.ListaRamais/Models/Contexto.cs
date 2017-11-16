using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace IBTA.ListaRamais.Models
{
    public class Contexto : DbContext
    {
        public DbSet<Funcionário> Funcionarios { get; set; }
    }
}