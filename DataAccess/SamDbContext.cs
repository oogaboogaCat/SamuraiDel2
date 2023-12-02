using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Domain.Entities;

namespace DataAccess
{
    public class SamDbContext : DbContext
    {
        public DbSet<Samurai> Samurai => Set<Samurai>();
        public DbSet<Sitat>Sitat  => Set<Sitat>();
        public DbSet<SecretIdentity> SecretIdentity => Set<SecretIdentity>();
        public DbSet<BattleSamurai>BattleSamurai => Set<BattleSamurai>();
        public DbSet<BattleLog>BattleLogs => Set<BattleLog>();
        public DbSet<BattleEvent>BattleEvents => Set<BattleEvent>();

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
            @"Server = (localdb)\MSSQLLocalDB; " +
            "Database = EFSamurai; " +
            "Trusted_Connection = True;");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<BattleSamurai>().HasKey(b => new { b.SamuraiId, b.BattleId });
        }
    }


}
