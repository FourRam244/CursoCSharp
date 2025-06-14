using System;

namespace Herencia
{
    class Program
    {
        static void Main(string[] args)
        {
            Doctor doctor1 = new Doctor("Juan", 40, "Cardiologo");
            
            Console.WriteLine(doctor1.GetInfo());
            Console.WriteLine(doctor1.GetData());

            Dev dev1 = new Dev("Cesar", 24, "Python");
            Console.WriteLine(dev1.GetInfo());
            Console.WriteLine(dev1.GetData());
        }

        class People
        {
            private string _name;  //lo que sea privado se identifica con un _ en las variables
            private int _age;

            public People(string name, int age)
            {
                _name = name;
                _age = age;
            }

            public string GetInfo()
            {
                return _name +" " + _age;
            }
        }

        class Doctor : People  //Asi es la forma de Heredar, solo es posible heredar de una clase
        {
            private string _speciality;
            public Doctor(string name, int age, string speciality) : base(name, age)  //recibir el constructor y mandarlo al padre
            {
                _speciality = speciality;  //No es necesario poner this
            }

            public string GetData()
            {
                return GetInfo() + " " + _speciality;
            }
        }

        class Dev : People  //Asi es la forma de Heredar, solo es posible heredar de una clase
        {
            private string _lenguage;
            public Dev(string name, int age, string lenguage) : base(name, age)  //recibir el constructor y mandarlo al padre
            {
                _lenguage = lenguage;  //No es necesario poner this
            }

            public string GetData()
            {
                return GetInfo() + " " + _lenguage;
            }
        }
    }
}