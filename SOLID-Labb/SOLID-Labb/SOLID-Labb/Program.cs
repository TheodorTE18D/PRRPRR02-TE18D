using System;

namespace SOLID_Labb
{
    class Program
    {
        static void Main(string[] args)
        {
            AnimalColor[] animalColor = {new Dog("Black"),
                            new Hedgehog("Pink"),
                            new Bird("Yellow")};
            AnimalActions[] animalActions = { new DogActions(), new HedgehogActions(), new BirdActions()};

            Console.WriteLine("###############");
            Console.WriteLine();
            for (var i = 0; i < animalColor.Length; i++)
            {
                if (animalActions[i] is DogActions dog)
                {
                    dog.TransferOwnership("Niklas");
                }
                
                animalActions[i].Eat();
                animalActions[i].Sleep();
                animalActions[i].Speak();
                animalColor[i]._color = "Grey";
                Console.WriteLine(animalColor[i].GetType().Name + " is " + animalColor[i]._color);
                Console.WriteLine();

                Console.WriteLine("###############");
                Console.WriteLine();
            }
        }
   
    }
}
