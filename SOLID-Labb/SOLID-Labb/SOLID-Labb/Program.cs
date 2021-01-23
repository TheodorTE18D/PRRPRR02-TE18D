using System;

namespace SOLID_Labb
{
    class Program
    {
        static void Main(string[] args)
        {
            AnimalProperties[] animalProperties = {new DogProperties("Black"),
                            new HedgehogProperties("Pink"),
                            new BirdProperties("Yellow")};
            AnimalActions[] animalActions = { new DogActions(), new HedgehogActions(), new BirdActions()};

            Console.WriteLine("###############");
            Console.WriteLine();
            for (var i = 0; i < animalProperties.Length; i++)
            {
                if (animalProperties[i] is DogProperties dog)
                {
                    dog.TransferOwnership("Niklas");
                }
                
                animalActions[i].Eat();
                animalActions[i].Sleep();
                animalActions[i].Speak();
                animalProperties[i]._color = "Grey";
                Console.WriteLine(animalProperties[i].GetType().Name + " is " + animalProperties[i]._color);
                Console.WriteLine();

                Console.WriteLine("###############");
                Console.WriteLine();
            }
        }
   
    }
}
