using System;

namespace Interface
{
    class Program
    {
        static void Main(string[] args)
        {
            Shark[] sharks = new Shark[]
            {
                new Shark("Tiburoncin", 56),
                new Shark("Jaws", 65)
            };

            IFish[] fish = new IFish[]
            {
                new Siren(100),
                new Shark("Tiburoncin", 66)
            }; 

            ShowFish(sharks);
            ShowAnimals(sharks);
            ShowFish(fish);
        }

        public static void ShowAnimals(IAnimal[] fishs)
        {
            Console.WriteLine("Mostramos los Animales");
            int i = 0;
            while (i < fishs.Length)
            {
                Console.WriteLine(fishs[i].Name);
                i++;
            }
        }
        public static void ShowFish(IFish[] animals)
        {
            Console.WriteLine("Mostramos los peces");
            int i = 0;
            while(i < animals.Length)
            {
                Console.WriteLine(animals[i].Swim());
                i++;
            }
        }
    }

    public class Siren: IFish
    {
        public int Speed { get; set; }

        public Siren(int Speed)
        {
            this.Speed = Speed;
        }
        public string Swim()
        {
            return $"La sirena nada a {Speed}km/h";
        }
    }



    public class Shark: IAnimal, IFish
    {

        public string Name { get; set; }
        public int Speed {  get; set; }

        //Constructor
        public Shark (string name, int Speed)
        {
            this.Name = name;
            this.Speed = Speed; 
        }

        public string Swim()
        {
            return $"{Name} Nada {Speed} km/h";
        }
    }
    public interface IAnimal
        {
            public string Name { get; set; }
        }
    public interface IFish
    {
        public int Speed { get; set; }
        public string Swim();
    }
}