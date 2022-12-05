namespace Pyroskateshop_Inventory_System.Modelo.Entidad
{
    /// <summary>
    /// Modelo del Usuario
    /// </summary>
    public class Usuario
    {
        public int Id { get; set; }
        public string NombreUsuario { get; set; }
        public string Contraseña { get; set; }
        public string FechaAlta { get; set; }
        public string PreguntaRecup { get; set; }
        public string RespuestaRecup { get; set; }
        public string TipoUsuario { get; set; }
    }
}
