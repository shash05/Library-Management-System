using System;
using DTO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace Database.Models
{
    public partial class LibraryManagementContext : DbContext
    {
        public LibraryManagementContext()
        {
        }

        public LibraryManagementContext(DbContextOptions<LibraryManagementContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Books> Books { get; set; }
        public virtual DbSet<Login> Logins { get; set; }
        public virtual DbSet<Orders> Orders { get; set; }
        public virtual DbSet<Roles> Roles { get; set; }
        public virtual DbSet<Students> Students { get; set; }
        public virtual DbSet<Books> BookLists { get; set; }
        public virtual DbSet<OrderDetails> OrderDetails { get; set; }
        public virtual DbSet<SpResponse> PlaceAndReturn { get; set; }
        public virtual DbSet<AdminOrderDetails> AdminOrderDetails { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=DESK00088\\SQLEXPRESS17;Database=LibraryManagement;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<Books>(entity =>
            {
                entity.Property(e => e.AuthorName)
                    .IsRequired()
                    .IsUnicode(false);

                entity.Property(e => e.BookTitle)
                    .IsRequired()
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Login>(entity =>
            {
                entity.ToTable("Login");

                entity.HasIndex(e => e.StudentId, "UQ__Login__32C52B98F5B5855B")
                    .IsUnique();

                entity.Property(e => e.Password)
                    .IsRequired()
                    .IsUnicode(false);

                entity.HasOne(d => d.Student)
                    .WithOne(p => p.Login)
                    .HasForeignKey<Login>(d => d.StudentId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_StudentIdInRoles");
            });

            modelBuilder.Entity<Orders>(entity =>
            {
                entity.Property(e => e.OrderDate).HasColumnType("date");

                entity.Property(e => e.ReturnDate).HasColumnType("date");

                entity.HasOne(d => d.Book)
                    .WithMany(p => p.Orders)
                    .HasForeignKey(d => d.BookId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_BookId");

                entity.HasOne(d => d.Student)
                    .WithMany(p => p.Orders)
                    .HasForeignKey(d => d.StudentId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_StudentId");
            });

            modelBuilder.Entity<Roles>(entity =>
            {
                entity.Property(e => e.RoleName)
                    .IsRequired()
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Students>(entity =>
            {
                entity.HasIndex(e => e.StudentName, "UQ__Students__68AEF93FC97EFDCD")
                    .IsUnique();

                entity.Property(e => e.StudentName)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Usn)
                    .IsRequired()
                    .IsUnicode(false)
                    .HasColumnName("USN");

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.Students)
                    .HasForeignKey(d => d.RoleId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_RoleId");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
