using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using copySystem.Models;
using Microsoft.EntityFrameworkCore;

namespace copySystem.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) {}

        public DbSet<Usuario> Usuarios => Set<Usuario>();
        public DbSet<Produto> Produtos => Set<Produto>();

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Usuario>(entidadeUsuario =>
            {
                entidadeUsuario.ToTable("Usuarios");
                entidadeUsuario.HasKey(u => u.Id);

                entidadeUsuario.Property(u => u.Nome).HasMaxLength(100).IsRequired();

                entidadeUsuario.HasIndex(u => u.Email).IsUnique();

                entidadeUsuario.Property(u => u.SenhaHash).HasMaxLength(255).IsRequired();
            });
            
            modelBuilder.Entity<Produto>(entidadeProduto =>
            {
                entidadeProduto.ToTable("Produtos");
                entidadeProduto.HasKey(p => p.Id);
                entidadeProduto.Property(p => p.Nome).HasMaxLength(100).IsRequired();
            });       
        }
    }
}