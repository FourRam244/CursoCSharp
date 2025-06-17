using System;

namespace TiposAnonimos
{
    class Program
    {
        static void Main(string[] args)
        {
            //Esto es solo un objeto aninimo que solo es de lectura no se pueden modificar sus valores
            var cesar = new
            {
                Name = "Cesar",
                Country = "México"
            };
            Console.WriteLine($"{cesar.Name} {cesar.Country}");

            var beers = new[]
            {
                new {Name = "Red", brand= "Delirium"},
                new {Name = "Corona", brand= "Modelo"},
            };

            foreach ( var b in beers ) 
            {
                Console.WriteLine($"cerveza{b.Name} {b.brand}");
            }
    }
    }
}