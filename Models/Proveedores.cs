using System.ComponentModel.DataAnnotations;

namespace ApiVentas.Models;

public class Proveedores
{
    [Key]
    public Int32 id_Proveedor { get; set; }
    public string? proveedor { get; set; }
    public string? nit { get; set; }
    public string? direccion { get; set; }
    public string? telefono { get; set; }
    
}