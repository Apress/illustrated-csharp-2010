using System;

namespace Examples
{
   struct MyStruct // Declare a struct.
   {
      public int X; // Field
      public int Y; // Field

      public MyStruct( int xVal, int yVal ) // Constructor
      {
         X = xVal; Y = yVal;
      }
   }

   class Program
   {
      static void Main()
      {
         MyStruct mSStruct = new MyStruct( 6, 11 ); // Variable of struct
         MyStruct? mSNull  = new MyStruct( 5, 10 ); // Variable of nullable type

         Console.WriteLine( "mSStruct.X: {0}", mSStruct.X );
         Console.WriteLine( "mSStruct.Y: {0}", mSStruct.Y );

         Console.WriteLine( "mSNull.X: {0}",   mSNull.Value.X );
         Console.WriteLine( "mSNull.Y: {0}",   mSNull.Value.Y );
      }
   }
}
