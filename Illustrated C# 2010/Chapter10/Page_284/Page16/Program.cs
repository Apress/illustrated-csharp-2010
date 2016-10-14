using Syst = System;          // using alias directive
using SC = System.Console;    // using alias directive

namespace Examples
{
   class SomeClass
   {
      static void Main()
      {
         Syst.Console.WriteLine( "Using the namespace alias." );
         System.Console.WriteLine( "Using fully qualified name." );
         SC.WriteLine( "Using the type alias" );
      }
   }
}
