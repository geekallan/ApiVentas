using System.ComponentModel.DataAnnotations;

namespace ApiVentas.Models;

public class Usuarios
{
    [Key]
    public Int32 Id_usuario { get; set; }
    public string? nombre_usuario { get; set; }
    public string? contrasena { get; set; }
    public Rol rol { get; set; }
    public DateTime fecha_creacion { get; set; }
}