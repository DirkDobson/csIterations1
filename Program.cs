using System;

namespace csIteration1
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                System.Console.Write("Type your name: ");
                var input = System.Console.ReadLine();

                if (!String.IsNullOrWhiteSpace(input))
                {
                    System.Console.WriteLine("@Echo: " + input);
                    continue;
                }
                   
                break;
            }
        }
    }
}
