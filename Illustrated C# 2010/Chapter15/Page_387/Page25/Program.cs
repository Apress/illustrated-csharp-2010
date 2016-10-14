using System;

namespace Examples
{
   class Program
   {
      delegate void MyDel();

      static void Main()
      {
         MyDel mDel;
         {
            int x = 5;
            mDel = delegate
            {
               Console.WriteLine( "Value of x: {0}", x );
            };
         }

         // Console.WriteLine("Value of x: {0}", x);

         if ( null != mDel )
            mDel();
      }
   }
}
