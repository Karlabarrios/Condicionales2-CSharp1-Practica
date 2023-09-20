using System;

namespace EjercicioDos
{
    class Program
    {
        static void Main(string[] args)
        {
            float it, lt, tp;

            Console.WriteLine("Ingrese importe total de compra");
            it = float.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese litros comprados");
            lt = float.Parse(Console.ReadLine());

            if(lt >= 101){
                if(lt >= 301)
                    if(lt > 500)
                        tp = it * .75F;
                    else
                        tp = it * .85F;
                else
                    tp = it * .90F;
            }
            else
                tp = it;
            
            Console.WriteLine("Su total a pagar es: " + tp);
        }
    }
}
