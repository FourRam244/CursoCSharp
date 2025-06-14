using System;
// int valores enteros
// double valores de punto flotante
// char caracteres individuales
// string alamcena texto
// bool valores con dos estados: true, false
namespace Variables
{
    class Program
    {
        static void Main(string[] args) {
            int number1 = 1;
            int number2 = 2;

            Console.WriteLine(number1);
            Console.WriteLine(number2);

            int number3 = number1 + number2;

            Console.WriteLine(number3);
        }
    }
}