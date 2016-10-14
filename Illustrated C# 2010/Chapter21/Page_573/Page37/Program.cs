﻿using System;
using System.Linq;

namespace Examples
{
   class Program
   {
      static void Main()
      {
         int[] intArray = new int[] { 3, 4, 5, 6, 7, 9 };

         var countOdd = intArray.Count( x => x % 2 == 1 );

         Console.WriteLine( "Count of odd numbers: {0}", countOdd );
      }
   }
}