using Crud.Models.Map;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Crud.Models;

namespace Crud.Models
{
    public class CrudContext : DbContext
    {
        public CrudContext(DbContextOptions<CrudContext> options)
            : base(options)
        {

        }

        //public DbSet<Categoria> Categoria { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new CategoriaMap());
        }

        //public DbSet<Categoria> Categoria { get; set; }

        public DbSet<Crud.Models.Categoria> Categoria { get; set; }
    }
}
