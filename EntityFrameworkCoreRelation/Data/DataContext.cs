using EntityFrameworkCoreRelation.Entities;
using Microsoft.EntityFrameworkCore;

namespace EntityFrameworkCoreRelation.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) 
        {
        }

        public DbSet<Character> Characters { get; set; }
        public DbSet<Backpack> Backpacks { get; set; }

        //One to one Relationship 
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Character>()
                .HasOne(c => c.Backpack)
                .WithOne(b => b.Character)
                .HasForeignKey<Backpack>(b => b.CharacterId);
        }
    }
}
