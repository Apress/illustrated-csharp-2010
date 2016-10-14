using System;
using System.Collections;

namespace Examples
{
   class Program
   {
      static void Main()
      {
         int[] MyArray = { 10, 11, 12, 13 };           // Create an array.

         IEnumerator ie = MyArray.GetEnumerator();     // Get its enumerator.
         while ( ie.MoveNext() )                       // Move to the next item.
         {
            int i = (int) ie.Current;                  // Get the current item.
            Console.WriteLine( "{0}", i );             // Write it out.
         }
      }
   }
}
