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
                    string data = Anfibios.Rana;
                    Console.WriteLine("El animal es una rana, a continuacion se presentaran ciertos datos del animal\nTipo de animal: {0}\nPeso: {1}\nColor: {2}", Rana.Type, Rana.Height, Rana.Colour);
                    break;
                    break;
                case "2":
                    break;
                case "3":
                    break;
            }

        }
    }
}
