using System;

namespace SwitchCase
{
    class Program
    {
        static void Main(string[] args)
        {
            int op = 7;

            switch (op)
            {
                case 1:
                    Console.WriteLine("Seleccionaste 1");
                    break;
                case 2:
                    Console.WriteLine("Seleccionaste 2");
                    break;
                //Case anidado
                case 3:
                case 4:
                    Console.WriteLine("Seleccionaste la opcion 3 y 4");
                    break;
                //Case anidados rangos
                case < 0:
                case > 100:
                    Console.WriteLine("Fuera de rango");
                    break;
                // case con condiciones
                case > 4 and < 10:
                    Console.WriteLine("Seleccionaste una opcione netre 4 y 10");
                    break;
                default:
                    Console.WriteLine("Invalido");
                    break;
            }
        }
    }
}