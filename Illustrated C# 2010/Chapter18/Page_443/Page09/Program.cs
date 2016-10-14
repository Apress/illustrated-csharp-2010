using System;

namespace Examples
{
   class Program
   {
      static void Main( )
      {
         byte   sb;
         ushort sh = 2000;

         unchecked                                            // Set unchecked
         {
            sb = (byte) sh;
            Console.WriteLine( "sb: {0}", sb );

            checked                                           // Set checked
            {
               sb = (byte) sh;
               Console.WriteLine( "sb: {0}", sh );
            }
         }
      }
   }
}
