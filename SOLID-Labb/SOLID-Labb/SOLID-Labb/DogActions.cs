using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID_Labb
{
    class DogActions : AnimalActions
    {
     

        public override void Eat()
        {
            Console.WriteLine("Dog is barking!");
        }

        public override void Sleep()
        {
            Console.WriteLine("Dog is sleeping!");
        }

        public override void Speak()
        {
            Console.WriteLine("Dog is eating. " + _owner +" is happy!");
        }

       
    }
}
