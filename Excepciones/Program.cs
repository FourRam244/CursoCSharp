using System;
using System.IO;

namespace Excepciones
{
    class Program
    {
        static void Main(string[] args)
        {
            //estructura de una Excepcion

            try
            {
                //Lectura de un archivo txt
                string content = File.ReadAllText(@"C:\Users\Cesar Ramirez\Desktop\Cruso C#\Cruso Completo\Tema1_Variables\Texto.txt");
                Console.WriteLine(content);
                //Archivo que no existe
                string content2 = File.ReadAllText(@"C:\Users\Cesar Ramirez\Desktop\Cruso C#\Cruso Completo\Tema1_Variables\Texto2.txt");
                Console.WriteLine(content2);

                //Crear nuestra excepcion
                throw new Exception("Ocurrio algo raro");
            }
            catch(FileNotFoundException ex)
            {
                Console.WriteLine("El archivo no existe" );
            }
            //Podemos encadenar los catch que queramos pero que sean diferentes
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally //Este siempre se ejecutara, exista o no una excepcion
            {
                Console.WriteLine("Aqui me eh ejecutado pase lo que pase");
            }
            Console.WriteLine("Sigue la ejecuciion del programa");

        }
    }
}