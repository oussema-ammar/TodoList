using Todo_List.Models;
using Microsoft.EntityFrameworkCore;

namespace Todo_List.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }
        public DbSet<User> Users { get; set; }
        public DbSet<Tache> Taches { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>()
                .HasMany(u => u.Taches);
            modelBuilder.Entity<Tache>()
                .HasOne(t => t.User)
                .WithMany(u => u.Taches)
                .HasForeignKey(t => t.UserId);
        }
    }
}
