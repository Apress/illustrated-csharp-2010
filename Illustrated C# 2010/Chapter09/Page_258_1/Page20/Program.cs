using System;

namespace Examples
{
   class Program
   {
      static void Main( string[] args )
      {
         for ( int x=0; x < 5; x++ )         // Execute loop five times
         {
            if ( x < 3 )                     // The first three times
               continue;                     // Go directly back to top of loop

            // This line is only reached when x is 3 or greater.
            Console.WriteLine( "Value of x is {0}", x );
         }
      }
   }
}
