using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_Tasks
{
    internal class Student : Person
    {
        int studentId;
        string major;

        public Student(string name, int age, int studentId, string major) : base(name, age)
        {
            this.studentId = studentId;
            this.major = major;
        }
    }
}
