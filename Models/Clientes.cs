using System.ComponentModel.DataAnnotations;

namespace ApiVentas.Models;

public class Clientes
{
    [Key]
    public Int32 Id_Cliente { get; set; }
    public string? nombres { get; set; }
    public string? apellidos { get; set; }
    public string? NIT { get; set; }
    public bool genero { get; set; }
    public string? telefono { get; set; }
    public string? correo_electronico { get; set; }
    public DateTime? fecha_ingreso { get; set; }
}