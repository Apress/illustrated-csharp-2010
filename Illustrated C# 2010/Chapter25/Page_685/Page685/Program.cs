using System;

namespace Examples
{
   class MyClass
   {
      class MyCounter // Nested class
      {
         private int _Count = 0;

         public int Count                 // Read-only property
         {
            get { return _Count; }
         }

         public static MyCounter operator ++( MyCounter current )
         {
            current._Count++;
            return current;
         }
      }

      private MyCounter counter;          // Field of nested class

      public MyClass()                    // Constructor
      {
         counter = new MyCounter();
      }

      public int Incr()                   // Increment method
      {
         return ( counter++ ).Count;
      }

      public int GetValue()
      {
         return counter.Count;            // Get counter value
      }
   }

   class Program
   {
      static void Main()
      {
         MyClass mc = new MyClass(); // Create object

         mc.Incr(); // Increment it.
         mc.Incr(); // Increment it.
         mc.Incr(); // Increment it.
         mc.Incr(); // Increment it.
         mc.Incr(); // Increment it.
         mc.Incr(); // Increment it.

         Console.WriteLine( "Total: {0}", mc.GetValue() ); // Print its value.
      }
   }
}
