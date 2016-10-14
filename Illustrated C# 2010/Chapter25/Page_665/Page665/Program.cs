using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Page665
{
   class Program
   {
      static void Main( )
      {
         string s = "Hi there.";
         Console.WriteLine( "{0}", s.ToUpper() );     // Print uppercase copy
         Console.WriteLine( "{0}", s );               // String is unchanged
      }
   }
}
