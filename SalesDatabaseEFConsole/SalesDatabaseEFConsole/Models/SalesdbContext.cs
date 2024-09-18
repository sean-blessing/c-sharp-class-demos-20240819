using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace SalesDatabaseEFConsole.Models;

public partial class SalesdbContext : DbContext
{
    public SalesdbContext()
    {
    }

    public SalesdbContext(DbContextOptions<SalesdbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Customer> Customers { get; set; }

    public virtual DbSet<Region> Regions { get; set; }

    public virtual DbSet<Sale> Sales { get; set; }

    public virtual DbSet<SalesDenormalized> SalesDenormalizeds { get; set; }

    public virtual DbSet<SalesPerson> SalesPeople { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=localhost;Database=salesdb;Integrated Security=True;TrustServerCertificate=True;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Customer>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Customer__3214EC07BFA87AFB");
        });

        modelBuilder.Entity<Region>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Region__3214EC07CC7BEF74");
        });

        modelBuilder.Entity<Sale>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Sales__3214EC0791B51506");

            entity.HasOne(d => d.Customer).WithMany(p => p.Sales)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Sales__CustomerI__300424B4");

            entity.HasOne(d => d.SalesPerson).WithMany(p => p.Sales)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Sales__SalesPers__2F10007B");
        });

        modelBuilder.Entity<SalesDenormalized>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Sales_De__3214EC0764A2060F");
        });

        modelBuilder.Entity<SalesPerson>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__SalesPer__3214EC0773032837");

            entity.HasOne(d => d.Region).WithMany(p => p.SalesPeople)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__SalesPers__Regio__2C3393D0");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
