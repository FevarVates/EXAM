using Microsoft.EntityFrameworkCore;
using TouristAgent.Models;

namespace TouristAgent.DateBase;

public class DbConnectionContext : DbContext
{
    public DbSet<Client> Clients { get; set; }
    public DbSet<Master> Masters { get; set; }
    public DbSet<RecordOfService> RecordOfServicess { get; set; }
    public DbSet<Service> Servicess { get; set; }
    
    public DbSet<Back> Backs { get; set; }
    
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        base.OnConfiguring(optionsBuilder);
        optionsBuilder.UseSqlite("Data Source=TouristAgent.db");
    }
}