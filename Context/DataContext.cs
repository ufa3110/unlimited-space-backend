using Microsoft.EntityFrameworkCore;
using UnlimitedSpaceService.ChatSection.Model;

namespace UnlimitedSpaceService.Context
{
    public class DataContext : DbContext
    {
        protected readonly IConfiguration Configuration;

        public DataContext(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            // connect to postgres with connection string from app settings
            options.UseNpgsql(Configuration.GetConnectionString("Back4appDB"));
        }

        public DbSet<ChatMessage> Messages { get; set; }
    }
}
