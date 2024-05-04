using System;

namespace curso
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 0;
            int y = 4;

            while (x < 3)
            {
                y = y + 2;
                x = x + 1;
                Console.WriteLine(x + "-" + y);
                Console.ReadLine();
            }

        }
    }
}