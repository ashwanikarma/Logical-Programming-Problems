using System.Diagnostics.Metrics;

namespace Logical_Programs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Prime Number");
            Console.Write("Enter the number : ");
            int number = Convert.ToInt32(Console.ReadLine());
            int counter = 0;
            for (int i = 1; i <= number; i++)
            {
                if ( number % i == 0)
                {
                    counter++;
                }
            }
            if (counter == 2)
            {
                Console.WriteLine("It's a Prime Number");
            }
            else
            {
                Console.WriteLine("It's not a Prime Number");
            }
        }
    }
}