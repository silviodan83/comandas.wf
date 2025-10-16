using Comandas.Wf.Modelos;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comandas.Wf
{
    public class ComandasDbContext:DbContext
    {
        public DbSet<Mesa>  Mesas { get; set; }
        public DbSet<CardapioItem> CardapioItems { get; set; }
        public DbSet<Comanda> Comandas { get; set; }
        public DbSet<ComandaItens> ComandaItens { get; set; }
        public DbSet<PedidoCozinha> PedidoCozinhas { get; set; }
        public DbSet<PedidoCozinhaItem> PedidoCozinhaItems { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=localhost\\SQLEXPRESS;Database=ComandasDb;Trusted_Connection=True;TrustServerCertificate=True;");
            base.OnConfiguring(optionsBuilder);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {// Define a chave estrangeira de PedidoCozinhaItem e desativa o Delete em cascata
            modelBuilder.Entity<PedidoCozinha>()
                .HasMany(pc=>pc.itens)
                .WithOne(pci => pci.PedidoCozinha)
                .HasForeignKey(pci => pci.PedidoCozinhaId)
                .OnDelete(DeleteBehavior.NoAction);
            modelBuilder.Entity<PedidoCozinhaItem>()
                .HasOne(pci=>pci.PedidoCozinha)
                .WithMany(pc=>pc.itens)
                .HasForeignKey(pc=>pc.PedidoCozinhaId)
                .OnDelete(DeleteBehavior.NoAction);
            modelBuilder.Entity<CardapioItem>()
                .Property(ci => ci.Preco)
                .HasColumnType("decimal(10,2)");
            base.OnModelCreating(modelBuilder);
        }
    }
}
