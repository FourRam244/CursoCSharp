using System;
using System.Collections.Generic;

namespace MetodosComunesListas
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>()
            {
                4,3,5,19
            };

            Show(numbers);
            numbers.Insert(1,6); //Insert: Insertar algo en una posicion especifica
            Show(numbers);

            if (numbers.Contains(33))  //Contains: Regresa true o false, para validar datos de una lista
                Console.WriteLine("Existe");
            else
            {
                Console.WriteLine("No existe");
            }

            //IndexOf //regresa la posicion de el numero dado, -1 si el elemnto no existe
            int pos = numbers.IndexOf(19);
            Console.WriteLine(pos);

            //Sort: para ordenar una lista de elementos
            numbers.Sort();
            Show(numbers);

            //Add Range agregar otra lista al final de la lista
            numbers.AddRange(new List<int>()
            {
                300,200,400
            });

            Show(numbers);
        }

        public static void Show(List<int> numbers)
        {
            Console.WriteLine("-- Numeros --");
            foreach (var n in numbers)
            {
                Console.WriteLine(n);
            }
        }
    }
}