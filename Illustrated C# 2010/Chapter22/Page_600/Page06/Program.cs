using System.Threading.Tasks;

class Program
{
   static void Main()
   {
      const int maxValues = 50;
      int[] squares = new int[maxValues];

      Parallel.For( 0, maxValues, i => squares[i] = i * i );
   }
}
