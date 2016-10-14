using System;

namespace Examples
{
   class Program
   {
      static void Main()
      {
         int? myI4 = null;
         Console.WriteLine( "myI4: {0}", myI4 ?? -1 );

         myI4 = 10;
         Console.WriteLine( "myI4: {0}", myI4 ?? -1 );
      }
   }
}
