using System;

namespace Introducción
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            
            Console.WriteLine("Ingrese su edad por favor");
            n = int.Parse(Console.ReadLine());

            if(n >= 80)
                Console.WriteLine("Usted pertenece a los boomers");
            else if(n >= 20 && n <= 40)
                Console.WriteLine("Usted pertenece a los millenials");
            else
                Console.WriteLine("Usted pertenece a la gen z");
        }
    }
}
