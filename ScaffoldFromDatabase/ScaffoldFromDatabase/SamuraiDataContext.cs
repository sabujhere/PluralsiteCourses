using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace ScaffoldFromDatabase
{
    public partial class SamuraiDataContext : DbContext
    {
        public SamuraiDataContext()
        {
        }

        public SamuraiDataContext(DbContextOptions<SamuraiDataContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Battle> Battles { get; set; }
        public virtual DbSet<Quote> Quotes { get; set; }
        public virtual DbSet<Samurai> Samurais { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server = (localdb)\\mssqllocaldb; Database = SamuraiData; Trusted_Connection = True; ");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Quote>(entity =>
            {
                entity.HasIndex(e => e.SamuraiId);

                entity.HasOne(d => d.Samurai)
                    .WithMany(p => p.Quotes)
                    .HasForeignKey(d => d.SamuraiId);
            });

            modelBuilder.Entity<Samurai>(entity =>
            {
                entity.HasIndex(e => e.BattleId);

                entity.HasOne(d => d.Battle)
                    .WithMany(p => p.Samurais)
                    .HasForeignKey(d => d.BattleId);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
