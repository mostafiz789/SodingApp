using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

using SodingSampleApp.Models;

namespace SodingSampleApp.DataAccess
{
    public class DataContext : DbContext
    {
        public DataContext() : base("DataContext")
        {
        }

        public DbSet<Task> Tasks { get; set; }
    }
}