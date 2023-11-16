using HR_ManagementApp.enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR_ManagementApp.classes
{
    public abstract class User
    {
        public abstract int Id { get; }
        public abstract string Name { get; }
        public abstract string LastName { get; }
        public abstract decimal Salary { get; }
        public abstract AccessLevel AccessLevel { get; }
        public abstract string Position { get; }
        public abstract string Login { get; set; }
        public abstract string Password { get; }
    }
}
