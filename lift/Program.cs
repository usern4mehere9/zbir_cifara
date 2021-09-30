using System;

namespace lift
{
    class Program
    {
        static void Main(string[] args)
        {
            int k, n, a, b;

            n = int.Parse(Console.ReadLine());
            k = int.Parse(Console.ReadLine());

            a = n / k;
            b = n % k;
           
            if (b > 0)
            {
                a++;
            }

            Console.WriteLine(a);
        }
    }
}
