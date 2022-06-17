using Microsoft.EntityFrameworkCore;
using WebApplication4MVCPractice.Models;

namespace WebApplication4MVCPractice.DataAccess;

public class ApplicationDBContext : DbContext
{
    public DbSet<Students> student { get; set; }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer(@"Data Source=WAIANGDESK14\MSSQLSERVER01;Initial Catalog=Student_Performance_Management;Integrated Security=True;TrustServerCertificate=True;Connection Timeout = 90");
    }
    public DbSet<WebApplication4MVCPractice.Models.Course> Course { get; set; }
}


