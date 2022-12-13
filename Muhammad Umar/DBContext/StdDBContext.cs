using Microsoft.EntityFrameworkCore;
using Muhammad_Umar.Models;

namespace Muhammad_Umar.DBContext
{
    public class StdDBContext : DbContext
    {
        public StdDBContext(DbContextOptions options) : base(options)
        {

        }
        public DbSet<formData> formData { get; set; }
    }
    
}
