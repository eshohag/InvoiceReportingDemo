using System.Data.Entity;

namespace InvoiceReportingDemo.Models
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext() : base("InvoiceReportingDB")
        {

        }

        public DbSet<Customer> Customers { get; set; }
    }
}