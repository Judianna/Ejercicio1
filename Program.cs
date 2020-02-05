using System;
using System.Globalization;
using System.Threading;

namespace ejer1
{
    class Program
    {
        static void Main(string[] args)
        { 
            DateTime f1, f2;
            TimeSpan dif;
            Console.WriteLine("Ingrese una fecha en formato AAAA/MM/DD");
            f1= Convert.ToDateTime(Console.ReadLine());
            Console.WriteLine("Ingrese la segunda fecha en el mismo formato");
            f2= Convert.ToDateTime(Console.ReadLine());
            dif= f1-f2;
            float dias= dif.Days;
            float semanas= dias/7;
            Console.WriteLine("La cantidad de días son {0}",dias);
            Console.WriteLine("la cantidad de semanas {0}",semanas);
            Console.WriteLine("La fecha 1 es: {0}", f1.ToString("dddd, d 'de' MMMM 'de' yyyy"));
        

        }
    }
}
