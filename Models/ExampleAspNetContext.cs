using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace CRUD_ASPNET.Models
{
    public partial class ExampleAspNetContext : DbContext
    {
        public ExampleAspNetContext()
        {
        }

        public ExampleAspNetContext(DbContextOptions<ExampleAspNetContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Beer> Beers { get; set; } = null!;
        public virtual DbSet<Brand> Brands { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
//#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
//                optionsBuilder.UseSqlServer("server=localhost; database=ExampleAspNet; integrated security=true;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Beer>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Beer");

                entity.Property(e => e.Beerld)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Brandld)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.NameBe)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.HasOne(d => d.BrandldNavigation)
                    .WithMany()
                    .HasForeignKey(d => d.Brandld)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_Brandld");
            });

            modelBuilder.Entity<Brand>(entity =>
            {
                entity.HasKey(e => e.Brandld)
                    .HasName("PK__Brand__DAD651BE8B252C77");

                entity.ToTable("Brand");

                entity.Property(e => e.Brandld)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.NameB)
                    .HasMaxLength(1)
                    .IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
