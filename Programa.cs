using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testing
{
    class Program
    {
        static void Main(string[] args)
        {
            //Pibe recuerda usar el Ctrl+F5 para que se quede un rato tu  aplicación de consola sin que se depure

            /*Console.WriteLine("HELLO IT'S ME REN HANAMURA, GWAK!");
            Console.WriteLine("HOLY SHIT THE AUTOCOMPLETE WORKS");
            int n1 = 100;
            int resulm = n1 * 5;
            Console.WriteLine(resulm);

            int o1 = 25 + 35;
            Console.WriteLine(o1);

            string chain = "Aguante Hanamura, sigue practicando y seras alto capo pa";
            Console.WriteLine(chain);

            // Tipos de datos
            // 1. Enteros

            int enterop = 400; // Almacenamiento maximo: 32 bits, su tipo es System.Int32
            short rigby = 240; // Almacenamiento maximo de 16 bits, su tipo es System.Int16
            byte NES = 8; // Almacenamiento maximo de 8 bits, su tipo es System.Byte
            long giraffe = 31451692691; // Almacenamiento maximo de 64 bits, su tipo es System.Int64

            //placeholders 0 se sustituye con enterop ya que es la primera variable nombrada y 1 con rigby dado que 0=1 y 1=2
            Console.WriteLine("int: {0}, short: {1}", enterop, rigby);

            // 2. Flotantes
            float globo = 345.6f; // Su tipos es System.Single
            double doh = 3.14161; // Su tipo es System.Double
            decimal peso = 399.99m; // Se pone la m paea que C# lo reconozca como decimal, su tipo es System.Decimal
            Console.WriteLine("float: {0}, decimal: {1}", globo, peso);

            // 3 - 4: Wea variada (texto e indicador)
            char uno = 'a'; // Su tipo es System.Char
            bool vof = false; //Su tipo es System.Boolean y no hay que olvidar que representa un valor ya sea Verdadero o Falso
            Console.WriteLine("Char: {0}", uno);
            Console.WriteLine("Bool: {0}", vof);*/

            int n1 = 50;
            int n2 = 25;
            Console.WriteLine(n1 + n2);
            Console.WriteLine(n1 - n2);
            Console.WriteLine(n1 * n2);
            Console.WriteLine(n1 / n2);
            Console.WriteLine(n1 % n2); // Modulo (Residuo de una división)
            Console.WriteLine(n1 > n2);
            Console.WriteLine(n1 < n2);
            Console.WriteLine(n1 >= n2);
            Console.WriteLine(n1 <= n2);
            Console.WriteLine(n1 == n2);
            Console.WriteLine(n1 != n2);
        }
    }
}
