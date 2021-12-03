using System;

namespace TP1_Daniel__DJIKPA
{
    public class Exercise2
    {
        public static void Prime()
        {
            bool isPrime = true;
            for (int i = 1; i <= 1000; i++)
            {
                for (int j = 2; j <= Math.Sqrt(i); j++)
                {
                    if (i % j == 0)
                    {
                        isPrime = false;
                    }
                }

                if (isPrime)
                    Console.WriteLine(i);
                isPrime = true;
            }
        }

        public static int F(int N)
        {
            if (N == 0) return 0;
            else if (N == 1) return 1;
            else
            {
                return F(N - 1) + F(N - 2);
            }
        }

        public static void factorial(int N)
        {
            int result = 1;
            for(int i = N; i > 0; i--)
            {
                result = result * i;
            }

            Console.WriteLine("{0}! = {1}",N, result);
        }
    }
}