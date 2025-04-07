namespace ProyectoInventario.Data.Entities
{
    public class Categoria: Base<int>
    {
        public String Nombre { get; set; }
        public String Descripcion { get; set; }
    }
}
