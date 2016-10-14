using System;
using System.Linq;

namespace Examples
{
   class Program
   {
      static void Main()
      {
         var numbers = new int[] { 2, 6, 4, 8, 10 };

         int howMany = ( from n in numbers
                         where n < 7
                         select n ).Count();

         Console.WriteLine( "Count: {0}", howMany );
      }
   }
}
