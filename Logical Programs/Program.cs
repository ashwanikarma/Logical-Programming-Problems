namespace Logical_Programs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Perfect Number");
            Console.Write("Enter the number : ");
            int number = Convert.ToInt32(Console.ReadLine());
            int result=0;
            for (int i = 1; i < number ; i++)
            {
                if ( number % i == 0 )
                {
                    Console.Write(i+"+");
                    result += i;
                }
            }
            Console.WriteLine("\b : {0}",result);

            if (number == result)
            {
                Console.WriteLine("It's a Perfect Number.");
            }
            else
            {
                Console.WriteLine("It's not a Perfect Number.");
            }
        }
    }
}