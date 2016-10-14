using System;

namespace Examples
{
   class Program
   {
      static void Main( )
      {
         int myInt = 500;
         Console.WriteLine( "|{0, 10}|", myInt ); // Aligned right
         Console.WriteLine( "|{0,-10}|", myInt ); // Aligned left
      }
   }
}
