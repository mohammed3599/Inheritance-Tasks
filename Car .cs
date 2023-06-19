using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_Tasks
{
    internal class Car : Vehicle
    {
        string Model;
        int NumberOfDoors;
        public Car(string Manufacturer, int Year, string Model, int NumberOfDoors) : base(Manufacturer, Year)
        {
            this.Model = Model;
            this.NumberOfDoors = NumberOfDoors;
        }
    }
}
