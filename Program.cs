using System;

namespace perfect_numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, n1, n2, sum = 0;
            Console.WriteLine("enter number1");
            n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("enter number2");
            n2 = int.Parse(Console.ReadLine());
            n = n1 + 1;
            while (n < n2)
            {
                for (int i = 1; i <= n / 2; i++)
                {
                    if ((n % i) == 0)
                        sum += i;
                }
                if (sum == n)
                    Console.WriteLine(n);
                sum = 0;
                n++;
            }
        }
    }
}
