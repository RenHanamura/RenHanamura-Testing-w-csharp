using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace Hash_table
{
    public class Da_table
    {
        Hashtable vtubas;

        public Da_table()
        {
            vtubas = new Hashtable();
        }

        public void AddVtubas()
        {
            vtubas.Add("Gen 0", "Hoshimachi Suisei");
            vtubas.Add("Gen 1", "Shirakami Fubuki");
            vtubas.Add("Gen 2", "Oozora Subaru");
            vtubas.Add("Hololive GAMERS", "Nekomata Okayu");
            vtubas.Add("Hololive Fantasy", "Hoshou Marine");
            vtubas.Add("Gen 4", "Kiryu Coco");
            vtubas.Add("HoloMyth", "Watson Amelia");
            vtubas.Add("HoloCouncil", "Ouro Kronii");
            vtubas.Add("Project HOPE", "IRyS");
            vtubas.Add("HoloID Gen 1", "Ayunda Risu");
            vtubas.Add("HoloID Gen 2", "Kureji Ollie");
            vtubas.Add("Gen 5", "Omaru Polka");
            vtubas.Add("HoloX", "Takane Lui");
        }

        public void ShowVtubas()
        {
            bool repeat = true;

            while (repeat == true)
            {
                Console.WriteLine("There are {0} Vtubers registered, please type the vtuber's gen", vtubas.Count);
                string holo = Console.ReadLine();

                if (vtubas[holo] == null)
                {
                    Console.WriteLine("Please introduce a existing gen");
                }
                else
                {
                    Console.WriteLine("The Vtuber is:");
                    Console.WriteLine(vtubas[holo]);
                    Console.ReadKey();
                    repeat = false;
                }
            }
        }
    }
}
