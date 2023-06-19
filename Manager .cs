using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_Tasks
{
    internal class Manager : Employee
    {
        string Department;
        double Salary;
        public Manager(string Name, string EmployeeId, string Department, double Salary) : base(Name, EmployeeId)
        {
            this.Department = Department;
            this.Salary = Salary;
        }
    }
}
