using System;
using System.Collections.Concurrent;
using System.Runtime.ConstrainedExecution;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Static
{
    class Program
    {
        static void Main(string[] args)
        {
            People cesar = new People()
            {
                Name = "Cesar",
                Age = 24
            };
            People juan = new People()
            {
                Name = "Juan",
                Age = 30
            };

            Console.WriteLine(People.GetCount());
        }

        public static class A  //Cuando se hace una clase estatica, todos lo demas debe ser estatico
        {
            public static void Some() //Se usa comúnmente para utilidades o herramientas.
            {
                Console.WriteLine("algo");
            }
        }
        public class People
        {

            public static int Count = 0; //Static se usa para declarar miembros que pertenecen a la clase en sí y
                                         //no a instancias específicas de esa clase. 
                                         //No necesitas crear un objeto para usarlo.
            public string Name {  get; set; }
            public int Age { get; set; }

            public People()
            {
                Count++; //esta aumentanndo cada vez que se usa la clase People
            }
            public static string GetCount()
            {
                //return "Esta clase se ah utilizado " + Count + " veces";  //String normal  

                return $"Esta clase se ah utilizado  { Count}  veces"; //Usando interpolacion de String
            }
    }
    }
}