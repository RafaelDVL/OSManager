using Microsoft.EntityFrameworkCore;
using OSManager.Model;

namespace OSManager.Data;

public class OSContext : DbContext
{
    public OSContext(DbContextOptions<OSContext> options) : base(options)
    {

    }

    public DbSet<Cliente> Clientes { get; set; }
    public DbSet<Tecnico> Tecnicos { get; set; }

    public DbSet<OrderService> OrderServices { get; set; }
}
