using System.ComponentModel.DataAnnotations;

namespace ApiVentas.Models;

public class Ventas
{
    [Key]
    public Int32 Id_Venta { get; set; }
    public Int32 no_factura { get; set; }
    public string? serie { get; set; }
    public DateOnly fecha_factura { get; set; }
    public Int32 Id_Cliente { get; set; }
    public Int32 Id_Empleado { get; set; }
    public DateTime fecha_ingreso { get; set; }

}