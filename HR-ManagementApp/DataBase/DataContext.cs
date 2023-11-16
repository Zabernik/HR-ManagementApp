using HR_ManagementApp.classes;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR_ManagementApp.DataBase
{
    public class DataContext : DbContext
    {
        public DbSet<Employee> Employees { get; set; }

    }
}
