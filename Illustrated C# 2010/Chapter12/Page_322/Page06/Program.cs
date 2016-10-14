using System;

namespace Examples
{
   struct Simple
   {
      public int X;
      public int Y;
   }

   class Program
   {
      static void Main()
      {
         Simple s1, s2;
         //Console.WriteLine("{0},{1}", s1.X, s1.Y);           // Compiler error -- not yet assigned

         s2.X = 5;
         s2.Y = 10;
         Console.WriteLine("{0},{1}", s2.X, s2.Y);              // OK
      }
   }
}
