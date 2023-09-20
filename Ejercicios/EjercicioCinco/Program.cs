using System;

namespace EjercicioCinco
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c, d;

            Console.WriteLine("Ingrese un número");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese otro número");
            b = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese otro número");
            c = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese un último número");
            d = int.Parse(Console.ReadLine());

            if(a > b && b > c && c > d)
                Console.WriteLine("Estan ordenados de mayor a menor");

            Console.WriteLine("Fin del programa");

        }
    }
}
