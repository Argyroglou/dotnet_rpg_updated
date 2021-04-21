using dotnet_rpg_updated.Models;
using Microsoft.EntityFrameworkCore;

namespace dotnet_rpg_updated.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

        public DbSet<Character> Characters { get; set; }
        public DbSet<User> Users { get; set; }
    }
}