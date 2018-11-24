using System;

namespace csIteration1
{
    class Program
    {
        static void Main(string[] args)
        {
            var name = "John Smith";

            for ( var i = 0; i < name.Length; i++)
            {
                System.Console.WriteLine(name[i]);
            }
        }
    }
}
