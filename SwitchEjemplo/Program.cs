using System;

namespace IntroducciónDos
{
    class Program
    {
        static void Main(string[] args)
        {
            int nro;

            Console.WriteLine("Ingrese 1 para saber su sueldo o 2 para conocer su suerte");
            nro = int.Parse(Console.ReadLine());

            switch(nro){
                case 1:
                    Console.WriteLine("Su sueldo es uwu");
                    break;
                case 2:
                    Console.WriteLine("Su suerte es owo");
                    break;
                default:
                    Console.WriteLine("De una opción valida pls");
                    break;
            }

        }
    }
}
