using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace SYSTEM.Models
{
    public partial class CodeAcademyBookingDBContext : DbContext
    {
        public CodeAcademyBookingDBContext()
        {
        }

        public CodeAcademyBookingDBContext(DbContextOptions<CodeAcademyBookingDBContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Booking> Bookings { get; set; } = null!;
        public virtual DbSet<Space> Spaces { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning   To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Data Source=LAPTOP-OH39326H\\MSSQLSERVER01;Initial Catalog= CodeAcademyBookingDB\n;Integrated Security=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Booking>(entity =>
            {
                entity.ToTable("Booking");

                entity.Property(e => e.BookingId)
                    .ValueGeneratedNever()
                    .HasColumnName("BookingID");

                entity.Property(e => e.EndTime).HasColumnType("datetime");

                entity.Property(e => e.SpaceId).HasColumnName("SpaceID");

                entity.Property(e => e.StartTime).HasColumnType("datetime");

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.HasOne(d => d.Space)
                    .WithMany(p => p.Bookings)
                    .HasForeignKey(d => d.SpaceId)
                    .HasConstraintName("FK__Booking__SpaceID__3B75D760");
            });

            modelBuilder.Entity<Space>(entity =>
            {
                entity.ToTable("Space");

                entity.Property(e => e.SpaceId)
                    .ValueGeneratedNever()
                    .HasColumnName("SpaceID");

                entity.Property(e => e.SpaceName).HasMaxLength(255);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
