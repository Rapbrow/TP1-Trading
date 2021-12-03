using System;

namespace TP1_Daniel__DJIKPA
{
    public class Exercise4
    {
        public static void square(int N,int M)
        {
            int cnt = 0;
            if (N > 1 && N <= 1000 || M > 1 && M <= 1000)
            {
                Console.Write("0");
                for (int j = 1; j < N - 1; j++)
                {
                    Console.Write("-");
                }

                Console.Write("0");
                Console.WriteLine();
                int p = 0;
                for (int i = 1; i < M - 1; i++)
                {
                    p = i % 3;
                    Console.Write("|");
                    cnt++;

                    for (int j = 1; j < N - 1; j++)
                    {
                        if (j % 3 == p)
                            Console.Write("*");
                        else
                            Console.Write(" ");
                    }

                    Console.Write("|");
                    Console.WriteLine();
                }

                Console.Write("0");
                for (int j = 1; j < N - 1; j++)
                {
                    Console.Write("-");
                }

                Console.Write("0");
            }
            else
                Console.Write('0');

        }
    }
}