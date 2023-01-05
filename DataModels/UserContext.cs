using Microsoft.EntityFrameworkCore;
using ric_avi_iskfu19.Models;

namespace ric_avi_iskfu19.DataModels;

public class HelmetContext : DbContext
{
    public HelmetContext(DbContextOptions options) : base(options)
    {
    }

    public DbSet<Helmet> Helmets => Set<Helmet>();

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Helmet>()
            .HasKey(b => b.HelmetId);

        modelBuilder.Entity<Helmet>().ToTable("helmets", schema: "public");

        modelBuilder.Entity<HelmetMaker>().ToTable("helmetMaker", schema: "public");
    }
}