using System;
using static Evidencia_Unidad_1.Artistas;

namespace Evidencia_Unidad_1
{
    class Program
    {
        static void Main(string[] args)
        {

            string elec;
            Console.WriteLine("Bienvenido a este programa el cual te dira algunos de mis artistas favoritos, por favor selecciona uno:\n1. Joji\n2. DEMONDICE\n3. half·alive");
            elec = Console.ReadLine();

            switch (elec)
            {
                case "1":
                    {
                        MoarData Joji = new MoarData("Joji", "R&B/Soul", "In Tongues, Ballads 1, Nectar", "Slow Dancing in the dark, Sanctuary, Test Drive, Wanted U, Yeah Right", "Spotify, Youtube Music, Apple Music, Deezer", "\nTwitter: @sushitrash, Instagram: @sushitrash, Facebook: @jojikansai");
                        Console.WriteLine("Artista: {0}\nGenero: {1}\nAlbums: {2}\nCanciones recomendadas: {3}\nLo encontraras en: {4}\nSus redes son: {5}", Joji.NombreA, Joji.Genero, Joji.Albums, Joji.CanRec, Joji.Streaming, Joji.SM);
                        break;
                    }
                case "2":
                    {
                        MoarData DD = new MoarData("DEMONDICE", "Hip-hop/Rap", "DEMONDICE, The Red, White and Black, American Saikoro, Kakigori Galaxy Astronout, Strange Fiction, Alkatraz", "Soundless, Gang Gang, Kawaii!!, Wannabe, Alt-er-native!!, Legendary Stray, Words That I Could Say to You", "Spotify, Youtube Music, Apple Music, Deezer", "\nTwitter: @DEMONDICEKaren");
                        Console.WriteLine("Artista: {0}\nGenero: {1}\nAlbums: {2}\nCanciones recomendadas: {3}\nLa encontraras en: {4}\nSus redes son: {5}", DD.NombreA, DD.Genero, DD.Albums, DD.CanRec, DD.Streaming, DD.SM);
                        break;
                    }
                case "3":
                    {
                        MoarData Ha = new MoarData("half·alive", "Alternative/Indie", "Now, Not Yet, In florescence", "Ice cold, RUNAWAY, Tip toes, What's wrong?, arrow", "Spotify, Youtube Music, Apple Music, Deezer", "\nTwitter: @halfaliveco, Instagram: @halfaliveco, Facebook: @halfalivejoshtaylor");
                        Console.WriteLine("Artista: {0}\nGenero: {1}\nAlbums: {2}\nCanciones recomendadas: {3}\nLos encontraras en: {4}\nSus redes son: {5}", Ha.NombreA, Ha.Genero, Ha.Albums, Ha.CanRec, Ha.Streaming, Ha.SM);
                        break;
                    }
            }

            
        }
    }
}
