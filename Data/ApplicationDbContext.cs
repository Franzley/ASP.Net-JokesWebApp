using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using ASP.NetJokesWebApp.Models;

namespace ASP.NetJokesWebApp.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<ASP.NetJokesWebApp.Models.Joke>? Joke { get; set; }
    }
}