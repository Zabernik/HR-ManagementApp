using HR_ManagementApp.enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR_ManagementApp.DataBase
{
    public class DbEntities
    {
        public class Employee
        {
            [Key]
            public int Id { get; set; }
            public string Name { get; set; }
            public string Surname { get; set; }
        }
        public class EmployeeData
        {
        }
        public class AccessEmployeeLevel
        {
            [Key]
            public AccessLevel AccessLevel { get; set; }
        }
        public class Login
        {            
        }
        public class SalaryList
        {
        }
    }
}
