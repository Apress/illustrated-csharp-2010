using System;

namespace Page32
{
   class MyClass
   {
      public int Calc( int a, int b, int c )
      {
         return ( a + b ) * c;
      }

      static void Main()
      {
         MyClass mc = new MyClass();

         int result = mc.Calc( c: 2, a: 4, b: 3 );

         Console.WriteLine( "{0}", result );
      }
   }
}
