using Microsoft.EntityFrameworkCore;
namespace login_api.Models
{
    public class Logincontext : DbContext
    {
        public Logincontext(DbContextOptions<Logincontext> options) : base(options)
        {
        }
        public DbSet<User> Logins { get; set; }
    }
}
