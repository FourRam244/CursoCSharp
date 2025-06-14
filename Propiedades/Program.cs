using System;

namespace ClasesyObejtos
{
    class Program
    {
        static void Main(string[] args)
        {
            Sale mySale = new Sale(100, DateTime.Now);
            
            Console.WriteLine(mySale.Total);
        }
    }

    class Sale
    {
        private int total;
        private DateTime date;

        //Cambiar el formato de la fecha y que no se pueda editar
        public string Date
        {
            get
            {
                return date.ToLongDateString();
            }
        }
        //Esto es unna  propiedad
        public int Total
        {
            get
            {
                return total;
            }
            set
            {
                if(value < 0) 
                    value = 0;
                total = value;
            }
        }

        public Sale(int total, DateTime date)
        {
            this.total = total;
            this.date = date;
        }

    }
}