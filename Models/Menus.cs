using System.ComponentModel.DataAnnotations;

namespace ApiVentas.Models
{
    public class Menus
    {
        [Key]
        public Int32 id_menu { get; set; }
        public string? nombre_menu { get; set; }
        public string? url { get; set; }
        public Int32 id_padre { get; set; }
        public short orden { get; set; }
        public Rol rol { get; set; }  // Cambiado a tipo enum Rol
        public byte es_visible { get; set; }
    }

    public enum Rol
    {
        Administrador,
        Usuario
    }
}