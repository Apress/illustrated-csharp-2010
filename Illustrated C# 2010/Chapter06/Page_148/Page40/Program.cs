using System;

namespace Page40
{
   class Employee
   {
      public string LastName;
      public string FirstName;
      public string CityOfBirth;
   }

   class Program
   {
      static void Main()
      {
         Employee emp1 = new Employee();
         emp1.LastName    = "Doe";
         emp1.FirstName   = "Jane";
         emp1.CityOfBirth = "Dallas";

         Console.WriteLine( "{0}", emp1.LastName );
         Console.WriteLine( "{0}", emp1.FirstName );
         Console.WriteLine( "{0}", emp1.CityOfBirth );
      }
   }
}
