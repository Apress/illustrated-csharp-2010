using System;

namespace Examples
{
   class Program
   {
      static void Main()
      {
         var student = new { LName = "Jones", FName = "Mary", Age = 19, Major = "History" };

         Console.WriteLine( "{0} {1}, Age {2}, Major: {3}",
            student.FName, student.LName, student.Age, student.Major );
      }
   }
}
