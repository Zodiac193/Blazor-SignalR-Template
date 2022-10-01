using Blazor_Server_App.Models;
using Microsoft.EntityFrameworkCore;

namespace Blazor_Server_App.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<Order> Orders { get; set; }  

    }

}
