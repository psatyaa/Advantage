using Advantage.Domain.Model;
using Advantage.Schema.Interface;
using Microsoft.EntityFrameworkCore;

namespace Advantage.Data.Context
{
    public class AppDbContext : DbContext
    {
        public DbSet<Application> Applications { get; set; }
        public DbSet<ApplicationContact> Contacts { get; set; }

        public IApplicationSchema _applicationSchema { get; set; }

        public AppDbContext(DbContextOptions<AppDbContext> options, IApplicationSchema applicationSchema) : base(options)
        {
            _applicationSchema = applicationSchema;
        }

       protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            //TODO :Creates Application and Contact Schema.
            _applicationSchema.CreateTable(modelBuilder);

        }

      
    }
}
