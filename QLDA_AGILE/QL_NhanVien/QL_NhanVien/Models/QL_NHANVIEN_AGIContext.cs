using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace QL_NhanVien.Models
{
    public partial class QL_NHANVIEN_AGIContext : DbContext
    {
        public QL_NHANVIEN_AGIContext()
        {
        }

        public QL_NHANVIEN_AGIContext(DbContextOptions<QL_NHANVIEN_AGIContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Nhanvien> Nhanviens { get; set; } = null!;
        public virtual DbSet<Phongban> Phongbans { get; set; } = null!;
        public virtual DbSet<Taikhoan> Taikhoans { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Data Source=PHAMHIEU\\SQLEXPRESS;Initial Catalog=QL_NHANVIEN_AGI;Integrated Security = True;Trust Server Certificate=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Nhanvien>(entity =>
            {
                entity.ToTable("NHANVIEN");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Chucvu)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("chucvu");

                entity.Property(e => e.Diachi)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("diachi");

                entity.Property(e => e.Email)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("email");

                entity.Property(e => e.IdCn).HasColumnName("idCN");

                entity.Property(e => e.Sodienthoai)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("sodienthoai");

                entity.Property(e => e.Ten)
                    .HasMaxLength(50)
                    .HasColumnName("ten");

                entity.HasOne(d => d.IdCnNavigation)
                    .WithMany(p => p.Nhanviens)
                    .HasForeignKey(d => d.IdCn)
                    .HasConstraintName("FKNV_CT");
            });

            modelBuilder.Entity<Phongban>(entity =>
            {
                entity.ToTable("Phongban");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Ten)
                    .HasMaxLength(50)
                    .HasColumnName("ten");
            });

            modelBuilder.Entity<Taikhoan>(entity =>
            {
                entity.ToTable("taikhoan");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.Matkhau)
                    .HasMaxLength(50)
                    .HasColumnName("matkhau");

                entity.Property(e => e.Rolelogin).HasColumnName("rolelogin");

                entity.Property(e => e.Tendangnhap).HasMaxLength(50);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
