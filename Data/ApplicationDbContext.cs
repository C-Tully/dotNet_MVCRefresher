using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using Refresher;

namespace MVCRefresher {

  public class ApplicationDbContext : DbContext {
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    {
      
    }

    public DbSet<TestUser> TestUsers { get; set; }
  }

}