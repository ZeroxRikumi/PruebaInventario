namespace ProyectoInventario.Data.Entities
{
    public class Producto : Base<int>
    {
        public String Codigo { get; set; }
        public String Nombre { get; set; }
        public String Descripcion { get; set; }
        public int Precio { get; set; }
        public int Stock { get; set; }
        public int CategoriaId { get; set; }
        public virtual Categoria Categoria { get; set; }
    }
}
