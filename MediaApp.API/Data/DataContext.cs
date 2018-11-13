using MediaApp.API.Models;
using Microsoft.EntityFrameworkCore;

namespace MediaApp.API.Data
{
    public class DataContext : DbContext
    {
        public DataContext (DbContextOptions<DataContext> options) : base (options) {}

        public DbSet<Value> Values { get; set; }    
        public DbSet<User> Users { get; set; }
        public DbSet<Video> Videos {get; set; }
        public DbSet<Photo> Photos {get; set; }
    }
}