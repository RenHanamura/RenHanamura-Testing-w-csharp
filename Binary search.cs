bool repeat = true;
            string yn;
            // Binaria
            int[] arnmbrs = new int[10];
            int nmbr;
            string yeno;
            int nent;
            int opt;

            while (repeat == true)
            {
                Console.WriteLine("Type the amount of numbers that you would like to save:\n");
                nent = int.Parse(Console.ReadLine());

                for (int s = 0; s < nent; s++)
                {
                    Console.WriteLine("Please type a number");

                    nmbr = Convert.ToInt32(Console.ReadLine());
                    if (!arnmbrs.Contains(nmbr))
                    {
                        arnmbrs[s] = nmbr;
                        nmbr++;
                    }
                    else
                    {
                        Console.WriteLine("That number already exists");
                    }

                }

                Console.WriteLine("What would you like to do?\n1. See the numbers      2. Search the numbers");
                opt = int.Parse(Console.ReadLine());

                switch (opt)
                {
                    case 1:
                        Console.WriteLine("Dou you want to see the numbers?\n Y/N");
                        yeno = Console.ReadLine();

                        if (yeno == "Y")
                        {
                            Console.WriteLine("Typed numbers:");
                            for (int s = 0; s < nent; s++)
                            {
                                Console.WriteLine("[{0}]", arnmbrs[s]);
                            }
                        }
                        else
                        {
                            Console.WriteLine("The vector has been generated!");
                        }

                        Console.ReadKey();
                        break;
                    case 2:
                        int numba, point = 0, final = 9, middle = -999;
                        var vk = arnmbrs;
                        bool find = false;

                        Console.WriteLine("Please insert a number");
                        numba = int.Parse(Console.ReadLine());

                        while (!find && point <= final)
                        {
                            middle = (int)((point + final) / 2);

                            if (numba == vk[middle])
                                find = true;

                            else if (numba < vk[middle])
                                final = middle - 1;
                            else
                                point = middle + 1;
                        }

                        if (find)
                            Console.WriteLine("The data is in and is on this position: " + (middle + 1));
                        else
                            Console.WriteLine("There's no data");

                        Console.ReadKey();
                        break;
                }
                Console.WriteLine("Do you want to do it again?\n Y/N");
                yn = Console.ReadLine();

                if(yn == "Y")
                {
                    Console.WriteLine("Allrighty then");
                }
                else
                {
                    Console.WriteLine("Well that's all buddy!");
                    repeat = false;
                }

            }           
