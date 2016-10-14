using System;
using System.Linq;

namespace Examples
{
   class Program
   {
      static void Main()
      {
         int[] intArray = new int[] { 3, 4, 5, 6, 7, 9 };

         var count1    = Enumerable.Count( intArray );   // Called directly
         var firstNum1 = Enumerable.First( intArray );   // Called directly

         var count2    = intArray.Count();             // Called as extension
         var firstNum2 = intArray.First();             // Called as extension

         Console.WriteLine( "Count: {0}, FirstNumber: {1}", count1, firstNum1 );
         Console.WriteLine( "Count: {0}, FirstNumber: {1}", count2, firstNum2 );
      }
   }
}
