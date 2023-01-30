using Microsoft.EntityFrameworkCore;
using NewWebBook.Models;

namespace NewWebBook.Data
{
    public class ApplicationDbContext :DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext>options) : base(options)
        {

        }
        public DbSet<Category> Categories { get; set; }

    }
}
