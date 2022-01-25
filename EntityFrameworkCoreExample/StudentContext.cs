using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkCoreExample
{
    // EF core getting started 
    // https://docs.microsoft.com/en-us/ef/core/get-started/overview/install
    public class StudentContext : DbContext
    {
        public StudentContext()
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            // Database = the desired name of the database
            // Server = The server we are connecting to, localDB os included with VS
            // Trusted_Connection - indicates that our windows account should be used
            options.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=EFCoreExample;Trusted_Connection=True;");
        }
    }
}
