int[] numba = new int[20];
            Random NumRan = new Random();
            string op;

            while (repeat == true) {
                Console.WriteLine("Do you want to see the vector?\n Y/N");
                op = Console.ReadLine();
                if (op == "Y") {
                    for (int n = 0; n < 20; n++)
                    {
                        numba[n] = NumRan.Next(5, 20);
                        Console.WriteLine(numba[n]);
                    }
                }
                else {
                    for (int n = 0; n < 20; n++)
                    {
                        numba[n] = NumRan.Next(5, 20);
                    }
                    Console.WriteLine("The vector has been generated :D!");
                }
                int numbah, x = 0, post = 0;
                var vc = numba;
                bool found = false;

                Console.WriteLine("Please insert a number: ");
                numbah = int.Parse(Console.ReadLine());

                while (!(found) && x < 20)
                {
                    if (numbah == vc[x])
                    {
                        found = true;
                        post = x;
                    }
                    x = x + 1;
                }
                if (found)
                    Console.WriteLine("The data was found and this is its position: " + post);

                Console.ReadKey();

                Console.WriteLine("Do you want to do it again?\n Y/N");
                yn = Console.ReadLine();

                if (yn == "Y")
                {
                    Console.WriteLine("Ok then let's do ir again");
                }
                else
                {
                    Console.WriteLine("Allright thanks for using the program");
                    repeat = false;
                }
            }
