using System.Diagnostics.Metrics;

namespace Logical_Programs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Reverse a number and Check palindrome or not");
            Console.Write("Enter the number : ");
            int number = Convert.ToInt32(Console.ReadLine());
            int temp = number;
            int rev = 0, rem=0;
            while (number != 0)
            {   
                rem = number % 10;
                rev = rem + rev;
                rev = rev * 10;               
                number = number / 10;
            }
            rev /= 10;
            Console.WriteLine("Reverse number of {0} is {1}",temp,rev);

            if (temp == rev)
            {
                Console.WriteLine("Palindrome Number");
            }
            else
            {
                Console.WriteLine("Not a Palindrome Number");
            }
        }
    }
}