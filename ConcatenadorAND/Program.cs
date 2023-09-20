using System;

namespace Introducción
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            
            Console.WriteLine("Ingrese un nro");
            n = int.Parse(Console.ReadLine());

            if(n >= 30 && n <= 50)
                Console.WriteLine("Ud es millenial");
            else
                Console.WriteLine("O eres gen z o un boomer");
        }
    }
}
