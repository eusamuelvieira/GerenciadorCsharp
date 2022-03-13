using GerenciadorDeCursos.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GerenciadorDeCursos.Data
{
    public class CursosContexto : DbContext
    {
        private readonly ModelBuilder modelBuilder;

        public CursosContexto(DbContextOptions<CursosContexto> options) : base(options)
        {

        }
        public DbSet<Cursos> Curso { get; set; }

        public DbSet<Cursos> Usuarios { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(this.modelBuilder);

            this.modelBuilder.Entity<Cursos>(entity =>
            
            {
                entity.ToTable("Cursos");
                entity.HasKey(prop => prop.Id);
                entity.Property(p => p.Titulo).HasColumnType("Varchar(40)").IsRequired();
            });
        }
        
    }
}
