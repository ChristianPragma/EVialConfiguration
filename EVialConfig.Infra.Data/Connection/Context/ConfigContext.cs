using EVialConfig.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace EVialConfig.Infra.Data.Connection
{
    public partial class ConfigContext : DbContext
    {
        public ConfigContext()
        {
        }

        public ConfigContext(DbContextOptions<ConfigContext> options)
            : base(options)
        {
        }

        public virtual DbSet<TypesTrafficViolation> TypesTrafficViolations { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("name=DbConnectionString");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TypesTrafficViolation>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasMaxLength(512)
                    .IsUnicode(false);

                entity.Property(e => e.Amount)
                    .HasColumnType("decimal(18, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.CodeFalta)
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.PreventiveMeasure)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Qualification)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Sanction)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Violation)
                    .HasMaxLength(300)
                    .IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
