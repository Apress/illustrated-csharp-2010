using System;
using System.Linq;
using System.Xml.Linq;

namespace Examples
{
   class Program
   {
      static void Main()
      {
         XDocument xd = XDocument.Load( "SimpleSample.xml" ); // Load the document.
         XElement rt = xd.Element( "MyElements" );            // Get the root element.

         var xyz = from e in rt.Elements()                  // Select elements whose
                   where e.Name.ToString().Length == 5      // names have 5 chars.
                   select e;

         foreach ( XElement x in xyz )                        // Display the
            Console.WriteLine( x.Name.ToString() );           // selected elements.

         Console.WriteLine();
         foreach ( XElement x in xyz )
            Console.WriteLine( "Name: {0}, color: {1}, size: {2}",
                              x.Name,
                              x.Attribute( "color" ).Value,
                              x.Attribute( "size" ).Value );
      }
   }
}
