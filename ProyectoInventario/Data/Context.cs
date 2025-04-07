using ProyectoInventario.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace ProyectoInventario.Data;

public class Context : DbContext
{
    public virtual DbSet<Producto> Productos { get; set; }
    public virtual DbSet<Categoria> Categorias { get; set; }

    public Context(DbContextOptions<Context> context) : base(context)
        { }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Producto>().HasQueryFilter(a => !a.IsDeleted);
        modelBuilder.Entity<Categoria>().HasQueryFilter(a => !a.IsDeleted);
    }
}