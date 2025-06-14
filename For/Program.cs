using System;

namespace SwitchCase
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] friends = new string[6]{
                "Pancho",
                "Cesar",
                "Alejandro",
                "Pedro",
                "Luis",
                "Sofia",
        };
            bool run = true;
            //Puede tener dos condiciones
            for (int i= 0; i < friends.Length && run; i++)
            {
                Console.WriteLine(friends[i]);
            }

        }
    }
}