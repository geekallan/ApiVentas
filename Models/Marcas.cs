using System.ComponentModel.DataAnnotations;

namespace ApiVentas.Models;

public class Marcas
{
    [Key]
    public Int32 id_Marca { get; set; }
    public string? marca { get; set; }
}