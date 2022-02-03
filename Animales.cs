using System;
using System.Collections.Generic;
using System.Text;

namespace Clases_y_animales
{
    class Animales
    {
        public string Tipo { get; set; }
        public string Peso { get; set; }
        public string Color { get; set; }

        public Animales(string Type, string Height, string Colour) : this()
        {
            Tipo = Type;
            Peso = Height;
            Color = Colour;
        }

        class Anfibios : Animales
        {
            public string Data()
            {
                Animales Rana = new Animales("Anfibio", "3gr", "Oliva");
            }
        }

        class Terrestres : Animales
        {

        }

        class Voladores: Animales
        {
            
        }
        public Animales() { }
    
    }
}
