using System;

namespace Examples
{
   class Program
   {
      static void Main()
      {
         bool success;
         string parseResultSummary;

         string stringFirst = "28";
         int intFirst;

         success = int.TryParse( stringFirst, out intFirst );
         parseResultSummary = success
                                 ? "was successfully parsed"
                                 : "was not successfully parsed";
         Console.WriteLine( "String {0} {1}", stringFirst, parseResultSummary );

         string stringSecond = "vt750";
         int intSecond;

         success = int.TryParse( stringSecond, out intSecond );

         parseResultSummary = success
                                 ? "was successfully parsed"
                                 : "was not successfully parsed";
         Console.WriteLine( "String {0} {1}", stringSecond, parseResultSummary );
      }
   }
}
