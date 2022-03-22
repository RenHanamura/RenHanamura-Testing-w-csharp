using System;
using System.Collections;
using System.Linq;

namespace Hash_table
{
    class Program
    {
        static void Main(string[] args)
        {
            bool restart = true;
            string op;
            //Hash table w/ hash search
            Da_table Show;
            Show = new Da_table();
            Show.AddVtubas();

            while (restart == true)
            {
                Show.ShowVtubas();
                Console.WriteLine("Do you want to do it again?\n Y/N");
                op = Console.ReadLine();

                if (op == "Y")
                {
                    Console.WriteLine("Let's do it again IKZ!!!");
                }
                else
                {
                    Console.WriteLine("Long live to the vtubers!");
                    restart = false;
                }
            }
        }
    }
}
