using System;

namespace Tuplas
{
    class Program
    {
        static void Main(string[] args)
        {
            //Esto es una tupla
            (int id, string name) product = (1, "cerveza stout");

            Console.WriteLine($"{product.id} {product.name}");
            //La tupla si es editable
            product.name = "cerverza modelo";
            Console.WriteLine($"{product.id} {product.name}");

            //Segunda forma de escribir una tupla
            var person = (1, "Cesar");
            Console.WriteLine($"persona {person.Item1} {person.Item2}");

            //Areglo de tuplas
            var people = new[]
            {
                (1, "Cesar"),
                (2, "Pedro"),
                (3, "Juan"),
            };

            foreach (var p in people)
            {
                Console.WriteLine($"{p.Item1} {p.Item2}");
            }
            //Conexion de tuplas
            (int id, string name)[] people2 = new[]
            {
                (1, "Cesar"),
                (2, "Pedro"),
                (3, "Juan"),
            };

            foreach (var p in people2)
            {
                Console.WriteLine($"{p.id} {p.name}");
            }


            var cityInfo = getLocationCDMX();
            Console.WriteLine($"lat: {cityInfo.lat} long:{cityInfo.lng} nombre:{cityInfo.name}");

            //Se usan _ para ignorar algo, obteniendo un valor especifico de la tupla
            var (_, lng, _) = getLocationCDMX();

            Console.WriteLine(lng);

        }
        //Metodo con tuplas
        public static (float lat, float lng, string name) getLocationCDMX()
        {
            float lat = 19.12121f;
            float lng = -99.1921f;
            string name = "CDMX";


            return (lat, lng, name);
        }
    }
}