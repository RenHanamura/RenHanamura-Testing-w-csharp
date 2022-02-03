using System;

namespace Clases_y_animales
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Bienvenido a este humilde programa porfavor selecciona una opcion\n1. Animal anfibio\n2. Animal terrestre\n3. Animal volador");
            string option = Console.ReadLine();
            switch (option)
            {
                case "1":
                    Console.WriteLine("Ok");
                    break;
                case "2":
                    Console.WriteLine("this shit");
                    break;
                case "3":
                    Console.WriteLine("works!");
                    break;
            }

        }
    }
}
