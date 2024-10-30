using System.ComponentModel.DataAnnotations;

namespace ApiVentas.Models;

public class Productos
{
    [Key]
    public Int32 Id_Producto { get; set; }
    public string? producto { get; set; }
    public short Id_Marca { get; set; }
    public string? descripcion { get; set; }
    public string? imagen { get; set; }
    public decimal precio_costo { get; set; }
    public decimal precio_venta { get; set; }
    public Int32 existencia { get; set; }
    public DateTime fecha_ingreso { get; set; }
}