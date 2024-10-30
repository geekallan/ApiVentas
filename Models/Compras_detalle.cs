using System.ComponentModel.DataAnnotations;

namespace ApiVentas.Models;

public class Compras_detalle
{
    [Key]
    public long id_compra_detalle { get; set; }
    public Int32 id_compra { get; set; }
    public Int32 id_Producto { get; set; }
    public Int32 cantidad { get; set; }
    public decimal precio_costo_unitario { get; set; }
}