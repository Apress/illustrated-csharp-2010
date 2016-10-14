using System;

namespace Examples
{
   class Employee : Person
   {
   }

   class Person
   {
      public string Name = "Anonymous";
      public int Age     = 25;
   }

   class Program
   {
      static void Main()
      {
         Employee bill = new Employee();
         Person p;

         p = bill as Person;
         if ( p != null )
         {
            Console.WriteLine( "Person Info: {0}, {1}", p.Name, p.Age );
         }
      }
   }
}
