using Microsoft.EntityFrameworkCore;

namespace WMVCLivros.Models
{
    public class Contexto : DbContext
    {
        public Contexto(DbContextOptions<Contexto> options) : base(options) { }

        public DbSet<Autores> Autores { get; set; }
        public DbSet<Editoras> Editoras { get; set; }
        public DbSet<Livros> Livros { get; set; }
    }
}
