using System;

namespace Page26
{
   public delegate TR Func<T1, T2, TR>(T1 p1, T2 p2);  // Generic delegate

   class Simple
   {
      static public string PrintString(int p1, int p2) // Method matches delegate
      {
         int total = p1 + p2;
         return total.ToString();
      }
   }

   class Program
   {
      static void Main()
      {
         var myDel =                                   // Create inst of delegate
            new Func<int, int, string>(Simple.PrintString);

         Console.WriteLine("Total: {0}", myDel(15, 13));  // Call delegate
      }
   }
}
