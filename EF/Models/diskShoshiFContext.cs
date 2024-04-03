using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace EF.Models
{
    public partial class diskShoshiFContext : DbContext
    {
        public diskShoshiFContext()
        {
        }

        public diskShoshiFContext(DbContextOptions<diskShoshiFContext> options)
            : base(options)
        {
        }

        public virtual DbSet<DiskInShop> DiskInShops { get; set; } = null!;
        public virtual DbSet<Diskk> Diskks { get; set; } = null!;
        public virtual DbSet<Shop> Shops { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Data Source=DESKTOP-MPAV2G5;Initial Catalog=diskShoshiF;Integrated Security=True");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<DiskInShop>(entity =>
            {
                entity.HasKey(e => e.DiDDiskId);

                entity.ToTable("DiskInShop");

                entity.Property(e => e.DiDDiskId)
                    .ValueGeneratedNever()
                    .HasColumnName("di_d_diskId");

                entity.Property(e => e.DiCost).HasColumnName("di_cost");

                entity.Property(e => e.DiShopId).HasColumnName("di_shopId");

                entity.HasOne(d => d.DiDDisk)
                    .WithOne(p => p.DiskInShop)
                    .HasForeignKey<DiskInShop>(d => d.DiDDiskId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__DiskInSho__di_d___29572725");

                entity.HasOne(d => d.DiShop)
                    .WithMany(p => p.DiskInShops)
                    .HasForeignKey(d => d.DiShopId)
                    .HasConstraintName("FK__DiskInSho__di_sh__2A4B4B5E");
            });

            modelBuilder.Entity<Diskk>(entity =>
            {
                entity.HasKey(e => e.DiDiskId)
                    .HasName("PK__Diskk__72D77D085D2594D7");

                entity.ToTable("Diskk");

                entity.Property(e => e.DiDiskId).HasColumnName("di_diskId");

                entity.Property(e => e.DiDiskName)
                    .HasMaxLength(30)
                    .HasColumnName("di_DiskName");
            });

            modelBuilder.Entity<Shop>(entity =>
            {
                entity.HasKey(e => e.SShopId)
                    .HasName("PK__Shop__970BAB4B7157872A");

                entity.ToTable("Shop");

                entity.Property(e => e.SShopId).HasColumnName("s_shopId");

                entity.Property(e => e.SShopName)
                    .HasMaxLength(30)
                    .HasColumnName("s_shopName");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
