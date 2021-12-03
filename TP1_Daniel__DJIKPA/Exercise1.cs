using System;
namespace TP1_Daniel__DJIKPA
{
    public class Exercise1
    {
        public static void exo1(int rep)
        {
            Console.WriteLine("----------- Every multiplication table from 1*1 to 10*10. ------------------");
            for (int i = 1; i <= 10; i++)
            {
                for (int j = 1; j <= 10; j++)
                {
                    Console.WriteLine(" {0} * {1} = {2} ",i,j,j*i);
                }

                Console.WriteLine("-----------------------------");
            }
            
            Console.WriteLine();
            Console.WriteLine("------------ 1 - ODD RESULT -----------------");
            for (int i = 1; i <= 10; i++)
            {
                for (int j = 1; j <= 10; j++)
                {
                    Console.WriteLine(" {0} * {1} = {2} ",i,j,j%i);
                }

                Console.WriteLine("-----------------------------");
            }

            Console.WriteLine();
            Console.WriteLine("------------ The display the multiplication table for this number N. -----------------");
            int r = rep;
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(" {0} * {1} = {2} ",r,i,r*i);
            }
        }
    }
}