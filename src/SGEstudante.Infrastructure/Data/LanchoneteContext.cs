using Microsoft.EntityFrameworkCore;
using SGL.ApplicationCore.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace SGL.Infrastructure.Data
{
    public class LanchoneteContext : DbContext
    {
        private object e;

        public LanchoneteContext(DbContextOptions<LanchoneteContext> options) : base(options)
        {
                
        }

        public DbSet <Pedido> Pedidos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Pedido>().ToTable("Pedido");

            #region Configuração de Pedido

            modelBuilder.Entity<Pedido>().Property(e => e.Nome)
            .HasColumnType("varchar(11)")
            .IsRequired();

            modelBuilder.Entity<Pedido>().Property(e => e.Valor)
            .HasColumnType("varchar(200)")
            .IsRequired();

            modelBuilder.Entity<Pedido>().Property(e => e.TipoLanche)
            .HasColumnType("varchar(200)")
            .IsRequired();

            #endregion
        }
    }
}
    

