using System;
using System.Threading.Tasks;         // Must use this namespace

namespace Examples
{
   class Program
   {
      static void Main()
      {
         Parallel.For( 0, 15, i =>
            Console.WriteLine( "The square of {0} is {1}", i, i * i ) );
      }
   }
}
