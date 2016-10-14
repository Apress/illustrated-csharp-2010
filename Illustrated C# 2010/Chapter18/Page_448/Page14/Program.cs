using System;

namespace Examples
{
   class A
   {
      public int Field1;
   }

   class B : A
   {
      public int Field2;
   }

   class Program
   {
      static void Main()
      {
         B myVar1 = new B();

         A myVar2 = (A) myVar1;

         Console.WriteLine( "{0}", myVar2.Field1 );            // Fine
         //Console.WriteLine("{0}", myVar2.Field2);            // Compile error!
      }
   }
}
