using System;
using System.Collections.Generic;
using System.Linq;


namespace LINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Beer> beers = new List<Beer>()
            {
                new Beer()
                {
                    Name="Corona", Country="Mexico"
                },
                new Beer()
                {
                    Name="Delirium", Country="Belgica"
                },
                new Beer()
                {
                    Name="Erdinger", Country="Alemania"
                }
            };

            foreach (var beer in beers )
                Console.WriteLine(beer);

            Console.WriteLine("----------------------------");

            //select: hace la seleccion de ciertos elementos de nuestra lista
            var beersName = from b in beers
                            select new
                            {
                                Name = b.Name,
                                Letters = b.Name.Length,
                                Fixed = 1
                            };
            foreach (var beer in beersName)
                Console.WriteLine($"{beer.Name} {beer.Letters} {beer.Fixed}");

            var beersNameReal = from b in beersName
                                select new
                                {
                                    Name = b.Name
                                };
            Console.WriteLine("----------------------------");
            foreach (var beer in beersNameReal)
                Console.WriteLine(beer.Name);
            Console.WriteLine("----------------------------");
            //filtrar
            var beersMéxico = from b in beers
                              where b.Country == "Mexico"
                              || b.Country == "Alemania"
                              select b;

            foreach(var beer in beersMéxico)
                Console.WriteLine(beer);
            //Ordenar alfabeticamente por el pais de forma descendente
            Console.WriteLine("----------------------------");

            var orderedBeers = from b in beers
                               orderby b.Country descending
                               select b;

            foreach(var beer in orderedBeers)
                Console.WriteLine(beer);
        }
    }
    public class Beer
    {
        public string Name  { get; set; }
        public string Country  { get; set; }

        public override string ToString()
        {
            return $"Nombre: {Name} Pais: {Country}";
        }
    }
}