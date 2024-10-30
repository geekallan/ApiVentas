using System.ComponentModel.DataAnnotations;

namespace ApiVentas.Models;

public class Ventas_detalle
{
    [Key]
    public long Id_venta_detalle { get; set; }
    public Int32 Id_Venta { get; set; }
    public Int32 Id_Producto { get; set; }
    public Int32 cantidad { get; set; }
    public decimal precio_unitario { get; set; }
}