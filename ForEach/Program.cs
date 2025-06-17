using System;
using System.Collections.Generic;

namespace ForEach
//foreach es una estructura de control que se utiliza
//para recorrer colecciones como arreglos, listas, diccionarios
//y otros tipos que implementan IEnumerable.
{
    class Program
    {
        static void Main(string[] args)
        {

            //var te ahorra escribir codigo ya que se determina con lo escribas a la derecha
            //List<int> numbers = new List<int>()  forma normal
            var numbers = new List<int>()  //forma reducida
            {
                23,3,5,10,22,12
            };
            foreach (var number in numbers)  //recorido mas natural que while
            {
                Console.WriteLine(number);
            }

            var students = new List<People>()
            {
                new People(){ Name = "Cesar", Country="Mexico"},
                new People(){ Name = "Roberto", Country="Argentina"},
                new People(){ Name = "Anna", Country="Colombia"},
            };

            Show(students);

            students.RemoveAt(0); //Remover algo especificando la posicion

            Show(students);
        }
        static void Show(List<People> students)
        {
            Console.WriteLine("-- Personas --");
            foreach (var people in students)
            {
                Console.WriteLine($"Nombre {people.Name}, Pais {people.Country}");
            }
        }
    }

    class People
    {
        public string Name { get; set; }
        public string Country { get; set; }
    }
}