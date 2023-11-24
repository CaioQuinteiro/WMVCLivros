using Microsoft.EntityFrameworkCore;
using WMVCLivros.Models;

namespace WMVCLivros.Models
{
    public class Contexto : DbContext
    {
        public Contexto(DbContextOptions<Contexto> options) : base(options) { }

        public DbSet<Autores> Autores { get; set; }
        public DbSet<Editoras> Editoras { get; set; }
        public DbSet<Livros> Livros { get; set; }
        public DbSet<Clientes> Clientes { get; set; }
        public DbSet<Vendas> Vendas { get; set; }

    }
}
