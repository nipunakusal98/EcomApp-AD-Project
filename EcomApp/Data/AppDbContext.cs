using EcomApp.Models;
using Microsoft.EntityFrameworkCore;

namespace EcomApp.Data
{
    public class AppDbContext:DbContext

    {
        public DbSet<Customer> Customers { get; set; }
        public DbSet<ComputerCategory> ComputerCategories { get; set; }
        public DbSet<ComputerSeries> ComputerSeries { get; set; }
        public DbSet<ComputerModel> ComputerModels { get; set; }
        public DbSet<ComputerProcessor> ComputerProcessors { get; set; }
        public DbSet<ComputerRAM> ComputerRAMs { get; set; }
        public DbSet<ComputerVGA> ComputerVGAs { get; set; }
        public DbSet<ConfigurationItem> ConfigurationItems { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Payment> Payments { get; set; }
        public DbSet<ProcessorBrand> ProcessorBrands { get; set; }
        public DbSet<RAMBrand> RAMBrands { get; set; }
        public DbSet<VGABrand> VGABrands { get; set; }
        public AppDbContext(DbContextOptions<AppDbContext> options):base(options) 
        {

        }
       
    }
}
