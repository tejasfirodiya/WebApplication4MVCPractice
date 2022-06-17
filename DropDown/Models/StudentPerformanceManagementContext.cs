using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace DropDown.Models
{
    public partial class StudentPerformanceManagementContext : DbContext
    {
        public virtual DbSet<CountryMaster> CountryMasters { get; set; }
        public virtual DbSet<StateMaster> StateMasters { get; set; }

      

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(@"Data Source=WAIANGDESK14\MSSQLSERVER01;Initial Catalog=Student_Performance_Management;Integrated Security=True;Trust Server Certificate=True;Command Timeout=300");
            }
        }

      
    }
}
