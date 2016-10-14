using System;
using System.Linq;

namespace Examples
{
   class Program
   {
      static void Main( )
      {
         int[] intArray = new int[] { 3, 4, 5, 6, 7, 9 };

         Func<int, bool> myDel = delegate(int x)
                                 {
                                    return x % 2 == 1;
                                 };
         var countOdd = intArray.Count(myDel);
   
         Console.WriteLine("Count of odd numbers: {0}", countOdd);
      }
   }
}
