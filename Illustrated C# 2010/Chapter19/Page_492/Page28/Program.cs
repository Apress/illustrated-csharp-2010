﻿using System;

namespace Examples
{
   interface IMyIfc<T>                            // Generic interface
   {
      T ReturnIt(T inValue);
   }

   class Simple : IMyIfc<int>, IMyIfc<string>     // Non-generic class
   {
      public int ReturnIt(int inValue)            // Implement interface using int 
      {
         return inValue;
      }
   
      public string ReturnIt(string inValue)      // Implement interface using string 
      {
         return inValue;
      }
   }
   
   class Program
   {
      static void Main()
      {
         Simple trivial = new Simple();
   
         Console.WriteLine("{0}", trivial.ReturnIt(5));
         Console.WriteLine("{0}", trivial.ReturnIt("Hi there."));
      }
   }
}
