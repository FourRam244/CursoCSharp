using System;

namespace Funciones
{
    class Program
    {
        //Funcion main
        static void Main(string[] args)
        {
            int a = 1;
            int b = 2;
            //Invocamos la funcion
            Show();
            Sum(1, 2);
            Sum(3, 4);

            int m = Mul(5,5);
            Console.WriteLine(m);
        }

        //Funcion 1
        static void Show()
        {
            Console.WriteLine("Hola soy un texto que se imprime desde funcion");
        }

        //Funcion 2
        static void Sum(int number1, int number2)
        {
            int number3 = number1 + number2;
            Console.WriteLine(number3);
        }

        //Funcion 3 quew regresa algo
        static int Mul(int num1, int num2)
        {
            return num1 * num2;
        }
    }
}