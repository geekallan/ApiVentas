using Microsoft.EntityFrameworkCore;

namespace ApiVentas.Models;

public class Conexiones : DbContext
{
    public Conexiones(DbContextOptions<Conexiones> options)
        : base(options)
    {
    }

    public DbSet<Clientes> Clientes { get; set; } = null!;
    public DbSet<Compras_detalle> Compras_detalle { get; set; } = null!;
    public DbSet<Compras> Compras { get; set; } = null!;
    public DbSet<Empleados> Empleados { get; set; } = null!;
    public DbSet<Marcas> Marcas { get; set; } = null!;
    public DbSet<Menus> Menus { get; set; } = null!;
    public DbSet<Productos> Productos { get; set; } = null!;
    public DbSet<Proveedores> Proveedores { get; set; } = null!;
    public DbSet<Puestos> Puestos { get; set; } = null!;
    public DbSet<Usuarios> Usuarios { get; set; } = null!;
    public DbSet<Ventas_detalle> Ventas_detalle { get; set; } = null!;
    public DbSet<Ventas> Ventas { get; set; } = null!;

}