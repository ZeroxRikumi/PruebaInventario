using ProyectoInventario.Data.Entities;

namespace ProyectoInventario.Data.Repositories;

public interface ICategoriaRepository 
{
    Task Insert(List<Categoria> categorias);
}
public class CategoriaRepository : ICategoriaRepository
{
    private readonly Context _context;

    public CategoriaRepository(Context Context)
    {
        _context = Context;
    }

    public async Task Insert(List<Categoria> categorias)
        => await _context.Categorias.AddRangeAsync(categorias);
}
