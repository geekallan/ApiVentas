using System.ComponentModel.DataAnnotations;

namespace ApiVentas.Models;

public class Puestos
{
    [Key]
    public short id_Puesto { get; set; }
    public string? puesto { get; set; }
   
}