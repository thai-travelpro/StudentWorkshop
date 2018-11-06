using Microsoft.EntityFrameworkCore;

namespace ProOnline.Gds.WebServices.Logs.Web.Data
{
    public class LogsDbContext : DbContext
    {
        public DbSet<WebServiceLog> WebServiceLogs { get; set; }

        public LogsDbContext(DbContextOptions<LogsDbContext> options)
            : base(options)
        {

        }
    }
}
