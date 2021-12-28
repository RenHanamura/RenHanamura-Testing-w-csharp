using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnotherTesting
{
    class Program
    {
        static void Main(string[] args)
        {
            // If, If else, Switch
            // If con un toque de else
            int n = 14;
            if (n > 4)
            {
                Console.WriteLine("El numero es mayor que 4");
            } /*
            else
            {
                Console.WriteLine("El numero no es mayor a 4");
            }*/ // ^ ¿Esto se podria considerar como una condicional compuesta? (Actualización: No no es una condicional compuesta, abajo pondre el ejemplo de la compuesta), esto es mas un If-Else

            // Condicional compuesta v
            string user = "RenPapi123";
            string pass = "Alinne";
            if (user == "RenPapi123" && pass == "Alinne")
            {
                Console.WriteLine("Bienvenido Ren, feo po qliao");
            }
            //If-Else
            int edad = 46;
            if (edad >= 18)
            {
                Console.WriteLine("Binvenido a esta pagina, distinguible señor o joven mayor de edad C;");
            }
            else
            {
                Console.WriteLine("Orele chamaco saquese a ver Discovery Kids, que pija haces aca?");
            }
            // If-Else-If
            int n1 = 5;
            int n2 = 3;
            if (n1 > n2)
            {
                Console.WriteLine(n1 + " es mayor que " + n2);
            }
            else if(n1 < n2)
            {
                Console.WriteLine(n1 + " es menor que " + n2);
            }
            else
            {
                Console.WriteLine(n1 + " es igual que " + n2);
            }

            // Switch
            string gei = "Eder";
            switch (gei)
            {
                case "Cris":
                    Console.WriteLine(gei + " es puto");
                    break;
                case "Isaac":
                    Console.WriteLine(gei + " no man, nerfeenlo");
                    break;
                case "Ren":
                    Console.WriteLine(gei + " es alto pendejo la vdd");
                    break;
                case "Eder":
                    Console.WriteLine(gei + " es alto raton, rey de los ratones y de ratalandia");
                    break;
                default:
                    Console.WriteLine("Man a quien pija mencionas?, no es miembro del santo grial");
                    break;
            }

            // Ciclos
            // For:
            Console.WriteLine("Este es el cilco for pa'");
            for (int x = 1; x < 6; x++){
                Console.WriteLine("Valor de x es: "+x);
            }

            // While
            Console.WriteLine("\nEste es el while");
            int z = 1;
            while (z < 6)
            {
                Console.WriteLine("El valor de z es: " + z);
                z++;
            }

            // Do While
            Console.WriteLine("\nDo While");
            int p = 1;
            do
            {
                Console.WriteLine("El valor de p es: " + p);
                p++;
            } while (p < 6); 

            
            // Break
            Console.WriteLine("Break: ");
            for (int y = 1; y < 11; y++)
            {
                if (y == 6)
                {
                    break; // Esto de aqui le hara un Bite the dust al codigo holy shit
                }
                Console.WriteLine("El valor de y es: " + y);
            }

            // Continue
            Console.WriteLine("\nContinue");
            int i = 1;
            while (i < 11)
            {
                if (i % 2 == 0) // Esto es para ver si un numero es par, en este caso haria la sucesión pero quitando los numeros pares 
                {
                    i++;
                    continue; // Continue se salta el ciclo y vuelve a evaluar
                }
                Console.WriteLine("Valor de i: " + i);
                i++;
            } 

            
            //Leer Datos desde el teclado

            Console.WriteLine("Suma de 2 numeros");
            Console.Write("Ingresa el primer numero: ");
            String data = Console.ReadLine();
            // Se viene la conversión shabales
            int num1 = int.Parse(data);
            // Fin de la conversión
            Console.Write("Ingresa un segundo numero: ");
            data = Console.ReadLine(); // Por alguna razón se puede reutilizar la variable de "data" para ahorrar la memoria del programa
            int num2 = int.Parse(data);
            int Suma = num1 + num2;
            Console.WriteLine("El resultado de la suma de los 2 numeros es de: "+Suma); 

            
            Console.WriteLine("Reto de la tabla de multiplicar:");
            Console.Write("Ingresa un numero del 1 al 10 para ver su respectiva tabla de multiplicar: ");
            String numin = Console.ReadLine();
            int ingresao = int.Parse(numin);
            switch (ingresao)
            {
                case 1:
                    Console.WriteLine(ingresao + "x1= " + ingresao*1);
                    Console.WriteLine(ingresao + "x2= " + ingresao * 2);
                    Console.WriteLine(ingresao + "x3= " + ingresao * 3);
                    Console.WriteLine(ingresao + "x4= " + ingresao * 4);
                    Console.WriteLine(ingresao + "x5= " + ingresao * 5);
                    Console.WriteLine(ingresao + "x6= " + ingresao * 6);
                    Console.WriteLine(ingresao + "x7= " + ingresao * 7);
                    Console.WriteLine(ingresao + "x8= " + ingresao * 8);
                    Console.WriteLine(ingresao + "x9= " + ingresao * 9);
                    Console.WriteLine(ingresao + "x10= " + ingresao * 10);
                    break;
                case 2:
                    Console.WriteLine(ingresao + "x1= " + ingresao * 1);
                    Console.WriteLine(ingresao + "x2= " + ingresao * 2);
                    Console.WriteLine(ingresao + "x3= " + ingresao * 3);
                    Console.WriteLine(ingresao + "x4= " + ingresao * 4);
                    Console.WriteLine(ingresao + "x5= " + ingresao * 5);
                    Console.WriteLine(ingresao + "x6= " + ingresao * 6);
                    Console.WriteLine(ingresao + "x7= " + ingresao * 7);
                    Console.WriteLine(ingresao + "x8= " + ingresao * 8);
                    Console.WriteLine(ingresao + "x9= " + ingresao * 9);
                    Console.WriteLine(ingresao + "x10= " + ingresao * 10);
                    break;
                case 3:
                    Console.WriteLine(ingresao + "x1= " + ingresao * 1);
                    Console.WriteLine(ingresao + "x2= " + ingresao * 2);
                    Console.WriteLine(ingresao + "x3= " + ingresao * 3);
                    Console.WriteLine(ingresao + "x4= " + ingresao * 4);
                    Console.WriteLine(ingresao + "x5= " + ingresao * 5);
                    Console.WriteLine(ingresao + "x6= " + ingresao * 6);
                    Console.WriteLine(ingresao + "x7= " + ingresao * 7);
                    Console.WriteLine(ingresao + "x8= " + ingresao * 8);
                    Console.WriteLine(ingresao + "x9= " + ingresao * 9);
                    Console.WriteLine(ingresao + "x10= " + ingresao * 10);
                    break;
                case 4:
                    Console.WriteLine(ingresao + "x1= " + ingresao * 1);
                    Console.WriteLine(ingresao + "x2= " + ingresao * 2);
                    Console.WriteLine(ingresao + "x3= " + ingresao * 3);
                    Console.WriteLine(ingresao + "x4= " + ingresao * 4);
                    Console.WriteLine(ingresao + "x5= " + ingresao * 5);
                    Console.WriteLine(ingresao + "x6= " + ingresao * 6);
                    Console.WriteLine(ingresao + "x7= " + ingresao * 7);
                    Console.WriteLine(ingresao + "x8= " + ingresao * 8);
                    Console.WriteLine(ingresao + "x9= " + ingresao * 9);
                    Console.WriteLine(ingresao + "x10= " + ingresao * 10);
                    break;
                case 5:
                    Console.WriteLine(ingresao + "x1= " + ingresao * 1);
                    Console.WriteLine(ingresao + "x2= " + ingresao * 2);
                    Console.WriteLine(ingresao + "x3= " + ingresao * 3);
                    Console.WriteLine(ingresao + "x4= " + ingresao * 4);
                    Console.WriteLine(ingresao + "x5= " + ingresao * 5);
                    Console.WriteLine(ingresao + "x6= " + ingresao * 6);
                    Console.WriteLine(ingresao + "x7= " + ingresao * 7);
                    Console.WriteLine(ingresao + "x8= " + ingresao * 8);
                    Console.WriteLine(ingresao + "x9= " + ingresao * 9);
                    Console.WriteLine(ingresao + "x10= " + ingresao * 10);
                    break;
                case 6:
                    Console.WriteLine(ingresao + "x1= " + ingresao * 1);
                    Console.WriteLine(ingresao + "x2= " + ingresao * 2);
                    Console.WriteLine(ingresao + "x3= " + ingresao * 3);
                    Console.WriteLine(ingresao + "x4= " + ingresao * 4);
                    Console.WriteLine(ingresao + "x5= " + ingresao * 5);
                    Console.WriteLine(ingresao + "x6= " + ingresao * 6);
                    Console.WriteLine(ingresao + "x7= " + ingresao * 7);
                    Console.WriteLine(ingresao + "x8= " + ingresao * 8);
                    Console.WriteLine(ingresao + "x9= " + ingresao * 9);
                    Console.WriteLine(ingresao + "x10= " + ingresao * 10);
                    break;
                case 7:
                    Console.WriteLine(ingresao + "x1= " + ingresao * 1);
                    Console.WriteLine(ingresao + "x2= " + ingresao * 2);
                    Console.WriteLine(ingresao + "x3= " + ingresao * 3);
                    Console.WriteLine(ingresao + "x4= " + ingresao * 4);
                    Console.WriteLine(ingresao + "x5= " + ingresao * 5);
                    Console.WriteLine(ingresao + "x6= " + ingresao * 6);
                    Console.WriteLine(ingresao + "x7= " + ingresao * 7);
                    Console.WriteLine(ingresao + "x8= " + ingresao * 8);
                    Console.WriteLine(ingresao + "x9= " + ingresao * 9);
                    Console.WriteLine(ingresao + "x10= " + ingresao * 10);
                    break;
                case 8:
                    Console.WriteLine(ingresao + "x1= " + ingresao * 1);
                    Console.WriteLine(ingresao + "x2= " + ingresao * 2);
                    Console.WriteLine(ingresao + "x3= " + ingresao * 3);
                    Console.WriteLine(ingresao + "x4= " + ingresao * 4);
                    Console.WriteLine(ingresao + "x5= " + ingresao * 5);
                    Console.WriteLine(ingresao + "x6= " + ingresao * 6);
                    Console.WriteLine(ingresao + "x7= " + ingresao * 7);
                    Console.WriteLine(ingresao + "x8= " + ingresao * 8);
                    Console.WriteLine(ingresao + "x9= " + ingresao * 9);
                    Console.WriteLine(ingresao + "x10= " + ingresao * 10);
                    break;
                case 9:
                    Console.WriteLine(ingresao + "x1= " + ingresao * 1);
                    Console.WriteLine(ingresao + "x2= " + ingresao * 2);
                    Console.WriteLine(ingresao + "x3= " + ingresao * 3);
                    Console.WriteLine(ingresao + "x4= " + ingresao * 4);
                    Console.WriteLine(ingresao + "x5= " + ingresao * 5);
                    Console.WriteLine(ingresao + "x6= " + ingresao * 6);
                    Console.WriteLine(ingresao + "x7= " + ingresao * 7);
                    Console.WriteLine(ingresao + "x8= " + ingresao * 8);
                    Console.WriteLine(ingresao + "x9= " + ingresao * 9);
                    Console.WriteLine(ingresao + "x10= " + ingresao * 10);
                    break;
                case 10:
                    Console.WriteLine(ingresao + "x1= " + ingresao * 1);
                    Console.WriteLine(ingresao + "x2= " + ingresao * 2);
                    Console.WriteLine(ingresao + "x3= " + ingresao * 3);
                    Console.WriteLine(ingresao + "x4= " + ingresao * 4);
                    Console.WriteLine(ingresao + "x5= " + ingresao * 5);
                    Console.WriteLine(ingresao + "x6= " + ingresao * 6);
                    Console.WriteLine(ingresao + "x7= " + ingresao * 7);
                    Console.WriteLine(ingresao + "x8= " + ingresao * 8);
                    Console.WriteLine(ingresao + "x9= " + ingresao * 9);
                    Console.WriteLine(ingresao + "x10= " + ingresao * 10);
                    break;
                default:
                    Console.WriteLine("Man eso no es un numero del 1 al 10 ._.");
                    break;
            }

            // Versión simplificada en vez de tanto desmadre
            Console.Write("Ingresa un numero del 1 al 10 para ver su respectiva tabla de multiplicar: ");
            string numb = Console.ReadLine();
            int numba = int.Parse(numb);
            if (numba >= 1 && numba <= 10)
            {
                Console.WriteLine("La tabla de multiplicar de " + numba + " es:");
                for (int e = 1; e <= 10; e++)
                {
                    int resul = numba * e;
                    Console.WriteLine(numba + "x" + e + "= " + resul);

                }
            }
            else
            {
                Console.WriteLine("Man eso no es un numero del 1 al 10 ._.");
            }
        }
    }
}
