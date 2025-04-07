using Microsoft.EntityFrameworkCore;

namespace ProyectoInventario.Data.Repositories;

public interface IUnitOfWork : IDisposable
{

}

public class UnitOfWork : IUnitOfWork
{
    private readonly Context _context;

    public async Task<int> Save()
    {
        try
        {
            await _context.SaveChangesAsync();
        }
        catch (DbUpdateConcurrencyException concurrencyException)
        {
            Console.WriteLine("Error en la concurrencia");
        }
        return 0;
    }

    public void Dispose()
    {
        _context.Dispose();
    }
}
