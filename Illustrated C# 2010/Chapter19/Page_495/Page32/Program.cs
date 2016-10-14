using System;

namespace Examples
{
   class Animal                        // Base class
   {
      public int Legs = 4;
   }

   class Dog : Animal                  // Derived class
   {
   }

   delegate T Factory<out T>();

   class Program
   {
      static Dog MakeDog()
      {
         return new Dog();
      }

      static void Main()
      {
         Factory<Dog>    dogMaker    = MakeDog;
         Factory<Animal> animalMaker = dogMaker;

         Console.WriteLine( animalMaker().Legs.ToString() );
      }
   }
}
