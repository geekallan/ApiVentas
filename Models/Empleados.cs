using System.ComponentModel.DataAnnotations;

namespace ApiVentas.Models;

public class Empleados
{
    [Key]
    public Int32 id_Empleado { get; set; }
    public string? nombres { get; set; }
    public string? apellidos { get; set; }
    public string? direccion { get; set; }
    public string? telefono { get; set; }
    public string? DPI { get; set; }
    public bool genero { get; set; }
    public DateOnly fecha_nacimiento { get; set; }
    public short id_Puesto { get; set; }
    public DateOnly fecha_inicio_labores { get; set; }
    public DateTime fecha_ingreso { get; set; }
    
   
}