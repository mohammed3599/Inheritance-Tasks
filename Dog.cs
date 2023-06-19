using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_Tasks
{
    internal class Dog : Animal
    {
        string Breed;
        string Sound;

        public Dog(string Name, int Age, string Breed, string Sound) : base(Name, Age)
        {
            this.Breed = Breed;
            this.Sound = Sound;
        }
    }
}
