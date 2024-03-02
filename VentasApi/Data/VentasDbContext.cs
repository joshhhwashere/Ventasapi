using Microsoft.EntityFrameworkCore;
using VentasApi.Models;

namespace VentasApi.Data
{
    public class VentasDbContext : DbContext
    {
        public VentasDbContext(DbContextOptions<VentasDbContext> options)
            : base(options)
        {
        }
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Pedido> Pedidos { get; set; }
        public DbSet<DetallePedido> DetalleDelPedido { get; set; }
        public DbSet<Producto> Productos { get; set; }

    }
}
