using Microsoft.EntityFrameworkCore;
using SGEstudante.ApplicationCore.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace SGEstudante.Infrastructure.Data
{
    public class EstudanteContext : DbContext
    {
        public EstudanteContext(DbContextOptions<EstudanteContext> options) : base(options)
        {
                
        }

        public DbSet <Estudante> Estudantes { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Estudante>().ToTable("Estudante");
        }
    }
}
