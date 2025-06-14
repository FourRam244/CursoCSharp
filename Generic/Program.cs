using System;

namespace Generic //Reutilizar codigo usando generics
{
    class Program
    {
        static void Main(string[] args)
        {
            //<int> Ejemplo cambiando el tipo a int
            MyList<int> numbers = new MyList<int>(10); 
            numbers.Add(19);
            numbers.Add(6);

            //<string> Ejemplo cambiando el tipo a string
            MyList<string> strings = new MyList<string>(10);
            strings.Add("Cesar");

            //<People> Ejemplo cambiando al tipo People
            MyList<People> people = new MyList<People>(5);
            people.Add(new People() { Name = "Cesar", Country = "Mexico" });
            people.Add(new People() { Name = "Miguel", Country = "Colombia" });

            Console.WriteLine(numbers.GetString());
            Console.WriteLine(strings.GetString());
            Console.WriteLine(people.GetString());

            Console.WriteLine(numbers.GetElement(11));
            Console.WriteLine(strings.GetElement(0));

        }
    }

    public class People
    {
        public string Name {  get; set; }
        public string Country {  get; set; }

        public override string ToString()//Sobreescritura
        {
            //Sobreescribiendo el ToString para mejor formato
            return $"Nombre: {Name}, Pais {Country}";
        }
    }

    public class MyList<T> //Esto indica que es un generic <T> que se puede cambiar el tipo al que se desee 
    {
        private T[] _elements;
        private int _index = 0;
        public MyList(int n)
        {
            _elements = new T[n];
        }

        public void Add(T e)
        {
            if (_index < _elements.Length)
            {
                _elements[_index] = e;
                _index++;
            }
        }
        public T GetElement(int i)
        {
            if (i <= _index && i >= 0)
            {
                return _elements[i];
            }

            return default(T);
        }
        public string GetString()
        {
            int i = 0;
            string result = "";
            while (i < _index)
            {
                result += _elements[i].ToString() + "|";
                i++;
            }
            return result;
        }
    }
}