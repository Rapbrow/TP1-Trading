using System;

namespace TP1_Daniel__DJIKPA
{
    public class Exercise3
    {
        public static int PowerFunction(int x)
        {

            int result = 0;
            if (x <= 3 && x >= -3)
            {
                try
                {
                    result = 10/(int)(Math.Pow(x, 2) - 4);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }

            return result;
        }
    }
}