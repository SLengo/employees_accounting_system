using System.Data.Entity;
namespace DBConnect 
{
    public class ApplicationContext : DbContext
    {
        public ApplicationContext() : base("ConnectionSQLite")
        {
        }
        public DbSet<Models.Employee> Employees { get; set; }
    }
}
