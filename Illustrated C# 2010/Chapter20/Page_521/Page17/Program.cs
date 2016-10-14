using System;
using System.Collections;
using System.Collections.Generic;

namespace Examples
{
   class ColorEnumerator : IEnumerator<string>
   {
      string[] Colors;
      int Position = -1;

      public string Current                          // Current--generic
      {
         get { return Colors[Position]; }
      }

      object IEnumerator.Current                     // Current--non-generic
      {
         get { return Colors[Position]; }
      }
   
      public bool MoveNext()                         // MoveNext
      {
         if (Position < Colors.Length - 1)
         {
            Position++;
            return true;
         }
         else
            return false;
      }
   
      public void Reset()                            // Reset
      {
         Position = -1;
      }
   
      public void Dispose() { }
   
      public ColorEnumerator(string[] colors)        // Constructor
      {
         Colors = new string[colors.Length];

         for (int i = 0; i < colors.Length; i++)
            Colors[i] = colors[i];
      }
   }

   class MyColors : IEnumerable
   {
      string[] Colors = { "Red", "Yellow", "Blue" };

      public IEnumerator GetEnumerator()
      {
         return new ColorEnumerator( Colors );
      }
   }

   class Program
   {
      static void Main()
      {
         MyColors mc = new MyColors();
         foreach ( string color in mc )
            Console.WriteLine( color );
      }
   }
}
