using CSharpCornerApi.Models;
//using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;



namespace CSharpCornerApi.Data
{
    public class AppDbContext : DbContext
        //IdentityDbContext<ApplicationUser>
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<CSharpCornerArticle> Articles { get; set; }
    }
}
