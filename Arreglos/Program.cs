using System;

namespace Arrgelos
{

    class Program
    {
        static void Main(string[] args)
        {
            string[] friends = new string[7]{
                "Pancho",
                "Cesar",
                "Alejandro",
                "Pedro",
                "Luis",
                "Sofia",
                null  //Esta reservado pero no tiene ninngun valor
            };

        
            Console.WriteLine(friends[0]);
            Console.WriteLine(friends[1]);
            Console.WriteLine(friends[2]);
            Console.WriteLine(friends[3]);
            Console.WriteLine(friends[4]);
            Console.WriteLine(friends[5]);
            Console.WriteLine(friends[6]);

            //Asginarle un valor despues
            friends[6] = "Carlos";
            Console.WriteLine(friends[6]);
        }
    }
}