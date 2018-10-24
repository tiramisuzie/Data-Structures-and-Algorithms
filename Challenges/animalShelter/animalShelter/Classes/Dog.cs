using System;
using System.Collections.Generic;
using System.Text;

namespace AnimalShelter.Classes
{
    // create dog class
    public class Dog : Animal
    {
        public Dog()
        {
            // used later for pref in dequeue
            type = "dog";
        }
    }
}
