
namespace ProyectoInventario.Data.Entities;

public abstract class Base<TId>
{
    public TId Id { get; set; } 
    public bool IsDeleted { get; set; }
}
