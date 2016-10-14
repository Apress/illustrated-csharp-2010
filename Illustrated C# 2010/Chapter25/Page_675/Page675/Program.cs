using System;

namespace Examples
{
   class Program
   {
      static void Main( )
      {
         int? myInt1 = 15;

         if ( myInt1.HasValue )
            Console.WriteLine( "{0}", myInt1.Value );

         // This is the preferred form.
         if ( myInt1 != null )
            Console.WriteLine( "{0}", myInt1 );
      }
   }
}
