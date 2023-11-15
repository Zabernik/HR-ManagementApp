using HR_ManagementApp.enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR_ManagementApp.classes
{
    public class Employee : User
    {
        public override int Id { get; }
        public override string Name { get; }
        public override string LastName { get; }
        public override decimal Salary { get; }
        public override AccessLevel AccessLevel { get; }
        public override string Login
        {
            get
            {
                return Login.ToString();
            }
            set
            {
                Login = Name.First() + LastName + Id;
            }
        }
        public override string Password
        { 
            get
            {
                return Password.ToString();
            }
        }
    }
}
