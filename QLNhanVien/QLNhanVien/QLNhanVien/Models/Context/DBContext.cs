using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using QLNhanVien.Models.DomainClass;

namespace QLNhanVien.Models.Context
{
    public partial class DBContext : DbContext
    {
        public DBContext()
        {
        }

        public DBContext(DbContextOptions<DBContext> options)
            : base(options)
        {
        }

        public virtual DbSet<NhanVien> NhanViens { get; set; } = null!;
        public virtual DbSet<Phongban> Phongbans { get; set; } = null!;
        public virtual DbSet<TaiKhoan> TaiKhoans { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Data Source=PHAMHIEU\\SQLEXPRESS;Initial Catalog=QLNVien;Integrated Security=True; TrustServerCertificate=true");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<NhanVien>(entity =>
            {
                entity.HasKey(e => e.IdnhanVien)
                    .HasName("PK__NhanVien__7AC2D9F756C6A7EA");

                entity.Property(e => e.IdnhanVien).ValueGeneratedNever();

                entity.HasOne(d => d.IdphongNavigation)
                    .WithMany(p => p.NhanViens)
                    .HasForeignKey(d => d.Idphong)
                    .HasConstraintName("FK__NhanVien__IDPhon__3C69FB99");

                entity.HasOne(d => d.IdtaiKhoanNavigation)
                    .WithMany(p => p.NhanViens)
                    .HasForeignKey(d => d.IdtaiKhoan)
                    .HasConstraintName("FK__NhanVien__IDTaiK__3B75D760");
            });

            modelBuilder.Entity<Phongban>(entity =>
            {
                entity.HasKey(e => e.Idphong)
                    .HasName("PK__Phongban__81CB11521FBD4DD2");

                entity.Property(e => e.Idphong).ValueGeneratedNever();
            });

            modelBuilder.Entity<TaiKhoan>(entity =>
            {
                entity.HasKey(e => e.IdtaiKhoan)
                    .HasName("PK__TaiKhoan__BC5F907C8349EA5A");

                entity.Property(e => e.IdtaiKhoan).ValueGeneratedNever();
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
