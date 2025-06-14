using System;

//Invocamos el paquete para Json
using System.Text.Json;
namespace Json
{
    class Program
    {
        static void Main(string[] args)
        {
            Beer mybeer = new Beer()
            {
                Name = "Pikantus",
                Brand = "Erdinger"
            };
            //Equivalente en Json
            //string json = "{\"Name\": \"Pikantus\", \"Brand\": \"Erdinger\"}";

            string json = JsonSerializer.Serialize(mybeer);  //Serializar un objeto a formato Json

            //Proceso inverso, deserilizacion, 
            Beer beer = JsonSerializer.Deserialize<Beer>(json); //Este funciona con generics
            
            //Para representar un arreglo
            Beer[] beers = new Beer[]
            {
                new Beer()
                {
                    Name = "Pikantus",
                    Brand = "Erdinger"
                },
                new Beer()
                {
                    Name = "Corona",
                    Brand = "Modelo"
                }
            };
            //Equivalente en Json para arreglos
           /* string json2 = "[" +
                "{\"Name\": \"Pikantus\", \"Brand\": \"Erdinger\"}," +
                "{\"Name\": \"Corona\", \"Brand\": \"Modelo\"}," +
                "]";*/

            //Serilizar el arreglo
            string json2 = JsonSerializer.Serialize(beers);
            //Deserializar arreglo
            Beer[] beers2 = JsonSerializer.Deserialize<Beer[]>(json2);


        }
        public class Beer
        {
            public string Name { get; set; }
            public string Brand { get; set; }
        }

    }

}