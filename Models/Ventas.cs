using System.ComponentModel.DataAnnotations;

namespace ApiVentas.Models;

public class Ventas
{
    [Key]
    public Int32 id_Venta { get; set; }
    public Int32 no_factura { get; set; }
    public string? serie { get; set; }
    public DateOnly fecha_factura { get; set; }
    public Int32 id_Cliente { get; set; }
    public Int32 id_Empleado { get; set; }
    public DateTime fecha_ingreso { get; set; }

}