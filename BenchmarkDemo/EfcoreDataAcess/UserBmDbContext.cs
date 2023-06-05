using BenchmarkDemo.Models;
using Microsoft.EntityFrameworkCore;

namespace BenchmarkDemo.EfcoreDataAcess
{
    public class UserBmDbContext:DbContext
    {
        //public UserBmDbContext(DbContextOptions<UserBmDbContext> options):base(options)
        //{
        //}
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=.;Initial Catalog=BenchmarkDb;Integrated Security=True; Encrypt=False");
        }

        public DbSet<User> User { get; set; }
        public DbSet<UserMaxProp> UserMaxProp { get; set; }
    }
}
