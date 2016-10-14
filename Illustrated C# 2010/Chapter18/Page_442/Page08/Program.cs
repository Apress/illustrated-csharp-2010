using System;

namespace Examples
{
   class Program
   {
      static void Main( )
      {
         ushort sh = 2000;
         byte   sb;

         sb = unchecked( (byte) sh );         // Most significant bits lost
         Console.WriteLine( "sb: {0}", sb );

         sb = checked( (byte) sh );         // OverflowException raised
         Console.WriteLine( "sb: {0}", sb );
      }
   }
}
