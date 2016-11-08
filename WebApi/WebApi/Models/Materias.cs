using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace WebApi.Models
{
    public class Materias
    {
        public int Id { get; set; }
        public string Materia { get; set; }
        public string Curso { get; set; }
    }

    class MateriasDbContext : DbContext {
        public DbSet<Materias> Materias { get; set; }
    }
}