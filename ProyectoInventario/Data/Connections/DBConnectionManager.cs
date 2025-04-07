namespace ProyectoInventario.Data.Connections;

public interface IDbConnectionManager
{
    string GetConnectionString();
}

public class DBConnectionManager : IDbConnectionManager
{
    private readonly IHttpContextAccessor _contextAccessor;
    public DBConnectionManager(IHttpContextAccessor contextAccessor)
    {
        _contextAccessor = contextAccessor;
    }

    public string GetConnectionString()
    {
        //_contextAccessor.GetTenant();
        //Calcular la url de la base de datos por tenant
        return "server=localhost;port=5432;database=InventarioDB;user=root;password=12345";
    }
}
