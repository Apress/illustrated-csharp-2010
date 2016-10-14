using System;

namespace Examples
{
   delegate void MyDelegate<T>( T value );             // Generic delegate

   class Simple
   {
      static public void PrintString( string s )       // Method matches delegate
      {
         Console.WriteLine( s );
      }

      static public void PrintUpperString( string s )  // Method matches delegate
      {
         Console.WriteLine( "{0}", s.ToUpper() );
      }
   }

   class Program
   {
      static void Main()
      {
         var myDel =                                 // Create inst of delegate
            new MyDelegate<string>( Simple.PrintString );
         myDel += Simple.PrintUpperString;           // Add a method.

         myDel( "Hi There." );                         // Call delegate
      }
   }
}
