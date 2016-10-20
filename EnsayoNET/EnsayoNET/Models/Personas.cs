using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Web;


namespace EnsayoNET.Models
{
    public class Personas
    {

        public int id { get; set; }

       
        public string nombre { get; set; }

        public string apellido { get; set; }

        public int dni { get; set; }

        public DateTime fechaAlta { get; set; }

    }

    public class PersonasDBContext : DbContext
    {
        public DbSet<Personas> Personas { get; set; }
    }
}