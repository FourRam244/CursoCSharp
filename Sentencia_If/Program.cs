using System;

namespace SetenciaIf_ElseIf
{
    class Program
    {
        static void Main(string[] args) {
            bool areYouHungry = true;
            bool youHaveMoney = true;

            // && = y
            // || = or
            if (areYouHungry && youHaveMoney && isOpenRestaurant("Lonches juan",11)) 
            {
                Console.WriteLine("Come");
            }
            else
            {
                Console.WriteLine("No comes");
            }
        }

        static bool isOpenRestaurant(string name, int hour=0)
        {
            if (name == "Lonches pepe" && hour > 8 && hour < 23 )
            {
                return true;
            }
            else if (name == "Restauran 24 horas")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}