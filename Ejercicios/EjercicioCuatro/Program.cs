using System;

namespace EjercicioCuatro
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c;

            Console.WriteLine("Ingrese un número");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese otro número");
            b = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese un último número");
            c = int.Parse(Console.ReadLine());

            if(a + b > b * c)
                Console.WriteLine("La suma de los primeros dos números es mayor que la multiplicación del segundo por el tercero");
            
        }
    }
}
