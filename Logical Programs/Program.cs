using System.Diagnostics.Metrics;

namespace Logical_Programs
{
    internal class Program
    {
        public static void CouponNumberGenerator(int N)
        {
            int[] coupon = new int[N];
            Random random = new Random();
            for (int i = 0; i < N ; i++)
            {
                coupon[i] = random.Next(1000 , 10000);
                int check = coupon[i];
                for (int j = i-1; j >= 0 ; j--)
                {
                    if (coupon[i] == coupon[j])
                    {
                        i--;
                    }
                }
            }
            for (int i = 0; i < N; i++)
            {
                Console.WriteLine("Coupon "+(i+1)+" : "+coupon[i]);
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Reverse a number and Check palindrome or not");
            Console.Write("Enter the number of Distinct Coupon number you want : ");
            int N = Convert.ToInt32(Console.ReadLine());  
            CouponNumberGenerator(N);   
        }
    }
}