using System;
using System.Collections.Generic;
namespace List
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>();
            numbers.Add(5);
            numbers.Add(2);
            //Contar el numero de elementos con Count
            Console.WriteLine(numbers.Count);

            List<int> numbers2 = new List<int>() { 
            1,6,7,10,14
            };
            //Como agregar mas elmentos a la lista
            numbers2.Add(55);
            //Contar el numero de elementos con Count
            Console.WriteLine(numbers2.Count);

            //Limpiar la lista, borrar todos los elementos
            numbers2.Clear();
            Console.WriteLine(numbers2.Count);


            List<string> countries = new List<string>()
            {
                "Mexico", "Argentina", "España"
            };
            countries.Add("Portugal");
            Console.WriteLine(countries.Count);
        }
    }
}