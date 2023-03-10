using Microsoft.EntityFrameworkCore;
using NewProject.Models;

namespace NewProject.DAL
{
    public class AppDbContext:DbContext
    {
        public AppDbContext _context { get; set; }

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<Person> Persons { get; set; }
    }
}
