using System;
using System.Collections.Generic;
using System.Text;

namespace Evidencia_Unidad_1
{
    public class Artistas
    {
        public string NombreA { get; set; }
        public string Genero { get; set; }
        public string Albums { get; set; }
        public string CanRec { get; set; }

        public Artistas(string NombreArt, string Gen, string Album, string CanciRecom)
        {
            NombreA = NombreArt;
            Genero = Gen;
            Albums = Album;
            CanRec = CanciRecom;
        }

        public Artistas() { }

       public class MoarData : Artistas
        {
            public string Streaming;
            public string SM;

            public MoarData(string NombreArt, string Gen, string Album, string CanciRecom, string Plat, string Net) : base(NombreArt, Gen, Album, CanciRecom)
            {
                Streaming = Plat;
                SM = Net;
            }
        }
    }
   
}
