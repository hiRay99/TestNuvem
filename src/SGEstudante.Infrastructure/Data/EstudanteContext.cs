﻿using Microsoft.EntityFrameworkCore;
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
        public DbSet<Contato> Contatos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Estudante>().ToTable("Estudante");
            modelBuilder.Entity<Contato>().ToTable("Contato");

            #region Configuração de Estudante

            modelBuilder.Entity<Estudante>().Property(e => e.CPF)
            .HasColumnType("varchar(11)")
            .IsRequired();

            modelBuilder.Entity<Estudante>().Property(e => e.Nome)
            .HasColumnType("varchar(200)")
            .IsRequired();

            #endregion

            #region Configuração de Contato

            modelBuilder.Entity<Contato>().Property(e => e.Nome)
            .HasColumnType("varchar(200)")
            .IsRequired();

            modelBuilder.Entity<Contato>().Property(e => e.Email)
            .HasColumnType("varchar(100)")
            .IsRequired();

            modelBuilder.Entity<Contato>().Property(e => e.Telefone)
            .HasColumnType("varchar(15)");

            #endregion
        }
    }
    }
    }
}
