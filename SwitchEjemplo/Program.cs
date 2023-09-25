using System;

namespace IntroducciónDos
{
    class Program
    {
        static void Main(string[] args)
        {
            int nro;

            Console.WriteLine("Ingrese 1 para receibir obtener ayuda, 2 para saber más o 3 para salir");
            nro = int.Parse(Console.ReadLine());

            switch(nro){
                case 1:
                    Console.WriteLine("Usted va a obtener ayuda contactando al 55 6677");
                    break;
                case 2:
                    Console.WriteLine("Usted va a conocer más llamando al 55 6688");
                    break;
                case 3:
                    Console.WriteLine("Usted esta saliendo del programa, Adiós.");
                    break;
                default:
                    Console.WriteLine("Seleccione una opción valida, por favor!");
                    break;
            }

        }
    }
}
