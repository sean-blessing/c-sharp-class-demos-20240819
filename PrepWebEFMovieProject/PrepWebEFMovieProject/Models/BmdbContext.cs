﻿using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace PrepWebEFMovieProject.Models;

public partial class BmdbContext : DbContext
{

    public BmdbContext(DbContextOptions<BmdbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Actor> Actors { get; set; }

    public virtual DbSet<Credit> Credits { get; set; }

    public virtual DbSet<Movie> Movies { get; set; }

//    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
//#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
//        => optionsBuilder.UseSqlServer("Server=localhost;Database=bmdb;Integrated Security=True;TrustServerCertificate=True;");

    //protected override void OnModelCreating(ModelBuilder modelBuilder)
    //{
    //    modelBuilder.Entity<Actor>(entity =>
    //    {
    //        entity.HasKey(e => e.Id).HasName("PK__Actor__3214EC0703E78BD6");
    //    });

    //    modelBuilder.Entity<Credit>(entity =>
    //    {
    //        entity.HasKey(e => e.Id).HasName("PK__Credit__3214EC079F9B626D");

    //        entity.HasOne(d => d.Actor).WithMany(p => p.Credits)
    //            .OnDelete(DeleteBehavior.ClientSetNull)
    //            .HasConstraintName("FK__Credit__ActorId__2C3393D0");

    //        entity.HasOne(d => d.Movie).WithMany(p => p.Credits)
    //            .OnDelete(DeleteBehavior.ClientSetNull)
    //            .HasConstraintName("FK__Credit__MovieId__2B3F6F97");
    //    });

    //    modelBuilder.Entity<Movie>(entity =>
    //    {
    //        entity.HasKey(e => e.Id).HasName("PK__Movie__3214EC076095706F");
    //    });

    //    OnModelCreatingPartial(modelBuilder);
    //}

    //partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
