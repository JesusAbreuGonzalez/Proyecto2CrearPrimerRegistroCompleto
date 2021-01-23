using Microsoft.EntityFrameworkCore;
using Proyecto2CrearPrimerRegistroCompleto.Entidades;
using System;
using System.Collections.Generic;
using System.Text;

namespace Proyecto2CrearPrimerRegistroCompleto.DAL
{
    public class Contexto : DbContext
    {
        public DbSet<Roles> Roles { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source = GestionPersonas.Db");
        }
    }
}
