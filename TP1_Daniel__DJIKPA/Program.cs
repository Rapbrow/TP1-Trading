using System;

namespace TP1_Daniel__DJIKPA
{
    class Program
    {
        private static int AskUserForParamater()
        {
            Console.WriteLine("Please write a number and press enter :");
            int.TryParse(Console.ReadLine(), out var result);
            return result;
        }
        
        static void Main(string[] args)
        {
            Console.WriteLine("               START TP1             ");
            Console.WriteLine();
            int rep = 0;
            do
            {
                bool current = true;
                do
                {
                    if (!current)
                    {
                        Console.WriteLine("Try again ! ");
                    }

                    Console.WriteLine("1- Exercise 1 ");
                    Console.WriteLine("2- Exercise 2 ");
                    Console.WriteLine("3- Exercise 3 ");
                    Console.WriteLine("4- Exercise 4 ");
                    Console.WriteLine("5- Exercise 5 ");
                    Console.WriteLine("6- Quit ");

                    rep = AskUserForParamater();

                    if (rep == 1)
                    {
                        Console.WriteLine();
                        Console.WriteLine("Which is the Number that you want display the multiplication table");
                        Exercise1.exo1(AskUserForParamater());
                    }
                    else if (rep == 2)
                    {
                        Console.WriteLine();
                        Console.WriteLine(" Display prime number between 1 and 1000");
                        Exercise2.Prime();
                        
                        Console.WriteLine();
                        Console.WriteLine(" Fibonacci function");
                        Console.WriteLine( Exercise2.F(AskUserForParamater()));
                        
                        Console.WriteLine();
                        Console.WriteLine(" Factorial function");
                        Exercise2.factorial(AskUserForParamater());
                        
                    }
                    else if (rep == 3)
                    {
                        Console.WriteLine();
                        Console.WriteLine("  try/catch :  F(x) = x²-4 With -3 <= x <= 3");
                        for (int i = -3; i <= 3; i++)
                        {
                            Console.WriteLine(Exercise3.PowerFunction(i));
                        }
                    }
                    else if (rep == 4)
                    {
                        Console.WriteLine();
                        Console.WriteLine(" SQUARE : Enter a N and M of your rectangle,");
                        Exercise4.square(AskUserForParamater(), AskUserForParamater());
                    }
                    else if (rep == 5)
                    {
                        Console.WriteLine();
                        Console.WriteLine(" CHRISTMAS TREE : ");
                        Exercise5.chrismasTree(AskUserForParamater());
                        
                    }
                    else
                        
                    
                        current = false;

                } while (rep <= 0 || rep > 7);

                Console.WriteLine();
                Console.Write("Continous ... ");Console.ReadLine();
                Console.Clear();
                
            } while (rep != 6);
           

        }
    }
}