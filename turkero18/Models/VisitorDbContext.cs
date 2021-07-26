using Microsoft.EntityFrameworkCore;

namespace turkero18.Models
{ 
    public class VisitorDbContext: DbContext
    {
        public VisitorDbContext(DbContextOptions<VisitorDbContext> options) : base(options)
        {

        }
        public DbSet<Visitor> Visitors { get; set; }
    }
}