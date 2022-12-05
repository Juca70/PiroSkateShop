
namespace Pyroskateshop_Inventory_System.Modelo.Entidad
{
    /// <summary>
    /// Modelo del Articulo
    /// </summary>
    public class Articulo
    {
        public int Id { get; set; }
        public Categoria Categoria { get; set; }
        public string Descripcion { get; set; } 
        public string Marca { get; set; }
        public string Medida { get; set; }
        public int CantExistencia { get; set; }
        public decimal CostoCompra { get; set; }
        public decimal CostoDolares { get; set; }
        public decimal PrecioVenta { get; set; }
        public string Estado { get; set; }
    }
}
