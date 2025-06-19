using System;

namespace ExcepcionesPersonalizadas
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Beer beer = new Beer()
                {
                    //Name = "Corona",
                    Brand = "Modelo"
                };
                Console.WriteLine(beer);
            }catch (InvalidBeerExcepcion ex)
            {
                Console.WriteLine(ex.Message);
            }catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }

        //Excepcion Personalizada

        public class InvalidBeerExcepcion : Exception //Heredamos la clase padre Excepcion
        {
            public InvalidBeerExcepcion() :
                base("La cerveza no tiene nombre o marca, por lo cual es invalida")
                //Mandamos el mensaje al padre por medio de "base"
            {
            
            }
        }

        public class Beer
        {
            public string Name { get; set; }
            public string Brand { get; set; }

            //Sobreescribimos el metodo
            public override string ToString()
            {
                //Creamos nuestra excepcion
                if (Name == null || Brand == null)
                {
                    throw new InvalidBeerExcepcion();
                }
                return $"Cerveza {Name}, Brand: {Brand}";
            }
        }
    }
}