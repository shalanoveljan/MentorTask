using MentorTemplate.Models;
using Microsoft.EntityFrameworkCore;

namespace MentorTemplate.DataAccessLayer
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options):base(options) 
        { 
           
        }
       public DbSet<Category> Categories { get; set; }
       public DbSet<Trainer> Trainers { get; set; }
       public DbSet<Course> Courses { get; set; }
       public DbSet<Module> Modules { get; set; }
       public DbSet<Pricing> Pricings { get; set; }
        public DbSet<Service> Services { get; set; }    
        public DbSet<PricingService> PricingServices { get; set; }
    }
}
