using Microsoft.EntityFrameworkCore;
using FutebolApi;

namespace FutebolApi;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

    public DbSet<Time> Times => Set<Time>();
}