using Microsoft.EntityFrameworkCore;

namespace EcomApp.Data
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options):base(options) 
        {

        }
       
    }
}
