using System;

namespace EjerciciosTres
{
    class Program
    {
        static void Main(string[] args)
        {
            int op, or, od;
            float pt = 0;

            Console.WriteLine("Ingrese que procesador quiere. Pulse 1 para i5, pulse 2 para i7 y 3 para i9");
            op = int.Parse(Console.ReadLine());
            switch (op){
                case 1:
                    Console.WriteLine("Ingrese que tipo de memoria quiere. Pulse 1 para 8 RAM, pulse 2 para 16 RAM, pulse 3 para 32 RAM");
                    or = int.Parse(Console.ReadLine());
                    switch (or)
                    {
                        case 1:
                            pt = 800;
                            break;
                        case 2:
                            pt = 900;
                            break;
                        case 3:
                            pt = 1000;
                            break;
                        default:
                            Console.WriteLine("Opción incorrecta");
                            break;
                    }
                    break;
                case 2:
                    Console.WriteLine("Ingrese que tipo de memoria quiere. Pulse 1 para 8 RAM, pulse 2 para 16 RAM, pulse 3 para 32 RAM");
                    or = int.Parse(Console.ReadLine());
                    switch (or)
                    {
                        case 1:
                            pt = 900;
                            break;
                        case 2:
                            pt = 1000;
                            break;
                        case 3:
                            pt = 1400;
                            break;
                        default:
                            Console.WriteLine("Opción incorrecta");
                            break;
                    }
                    break;
                case 3:
                    Console.WriteLine("Ingrese que tipo de memoria quiere. Pulse 1 para 8 RAM, pulse 2 para 16 RAM, pulse 3 para 32 RAM");
                    or = int.Parse(Console.ReadLine());
                    switch (or)
                    {
                        case 1:
                            pt = 1200;
                            break;
                        case 2:
                            pt = 1400;
                            break;
                        case 3:
                            pt = 2000;
                            break;
                        default:
                            Console.WriteLine("Opción incorrecta");
                            break;
                    }
                    break;
                default:
                Console.WriteLine("Opción incorrecta");
                break;

            }
            Console.WriteLine("Para expandir disco pulse 1, si no quiere hacerlo pulse 0");
            od = int.Parse(Console.ReadLine());

            if(od == 1)
                pt = pt + 300;
            
            Console.WriteLine("El precio de su computadora es: $" + pt);
        }
    }
}
