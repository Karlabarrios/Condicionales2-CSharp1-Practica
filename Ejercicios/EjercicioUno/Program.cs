using System;

namespace EjercicioUno
{
    class Program
    {
        static void Main(string[] args)
        {
            int A, B, resultado;

            Console.WriteLine("Ingrese un primer número");
            A = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese un segundo número");
            B = int.Parse(Console.ReadLine());

            if(A > B)
                resultado = A - B;
            else{
                if(A == B)
                    resultado = A + B;
                else
                    resultado = A * B;
            }

            
            Console.WriteLine("El resultado es: " + resultado);
        }
    }
}
