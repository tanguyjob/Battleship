namespace touchercouler
{
    public class Game
    {
        private string[,] _myBoard;
        private string[,] _myBoard2;

        private string[,] _boardComputer;
        private string[,] _boardComputer2;
        private Random _random;

        public Game()
        {

            _random = new Random();

            ArrayInitialization();

            PositionAllPieces();

            Play();

        }


        private void ArrayInitialization()
        {
            _myBoard = new string[,] { {"0 ","1  ","2  ","3  ","4  ","5  ","6  ","7  ","8  ","9  ","10 " },
                {"A","| |","| |","| |","| |","| |","| |","| |","| |","| |","| |" },
                {"B","| |","| |","| |","| |","| |","| |","| |","| |","| |","| |" },
                {"C","| |","| |","| |","| |","| |","| |","| |","| |","| |","| |" },
                {"D","| |","| |","| |","| |","| |","| |","| |","| |","| |","| |" },
                {"E","| |","| |","| |","| |","| |","| |","| |","| |","| |","| |" },
                {"F","| |","| |","| |","| |","| |","| |","| |","| |","| |","| |" },
                {"G", "| |","| |","| |","| |","| |","| |","| |","| |","| |","| |" },
                { "H","| |","| |","| |","| |","| |","| |","| |","| |","| |","| |" },
                { "I","| |","| |","| |","| |","| |","| |","| |","| |","| |","| |" },
                { "J","| |","| |","| |","| |","| |","| |","| |","| |","| |","| |" } };

            _myBoard2 = new string[,] { {"0 ","1  ","2  ","3  ","4  ","5  ","6  ","7  ","8  ","9  ","10 " },
                {"A","| |","| |","| |","| |","| |","| |","| |","| |","| |","| |" },
                {"B","| |","| |","| |","| |","| |","| |","| |","| |","| |","| |" },
                {"C","| |","| |","| |","| |","| |","| |","| |","| |","| |","| |" },
                {"D","| |","| |","| |","| |","| |","| |","| |","| |","| |","| |" },
                {"E","| |","| |","| |","| |","| |","| |","| |","| |","| |","| |" },
                {"F","| |","| |","| |","| |","| |","| |","| |","| |","| |","| |" },
                {"G", "| |","| |","| |","| |","| |","| |","| |","| |","| |","| |" },
                { "H","| |","| |","| |","| |","| |","| |","| |","| |","| |","| |" },
                { "I","| |","| |","| |","| |","| |","| |","| |","| |","| |","| |" },
                { "J","| |","| |","| |","| |","| |","| |","| |","| |","| |","| |" } };

            _boardComputer = new string[,] { {"0 ","1  ","2  ","3  ","4  ","5  ","6  ","7  ","8  ","9  ","10 " },
                {"A","| |","| |","| |","| |","| |","| |","| |","| |","| |","| |" },
                {"B","| |","| |","| |","| |","| |","| |","| |","| |","| |","| |" },
                {"C","| |","| |","| |","| |","| |","| |","| |","| |","| |","| |" },
                {"D","| |","| |","| |","| |","| |","| |","| |","| |","| |","| |" },
                {"E","| |","| |","| |","| |","| |","| |","| |","| |","| |","| |" },
                {"F","| |","| |","| |","| |","| |","| |","| |","| |","| |","| |" },
                {"G", "| |","| |","| |","| |","| |","| |","| |","| |","| |","| |" },
                { "H","| |","| |","| |","| |","| |","| |","| |","| |","| |","| |" },
                { "I","| |","| |","| |","| |","| |","| |","| |","| |","| |","| |" },
                { "J","| |","| |","| |","| |","| |","| |","| |","| |","| |","| |" } };

            _boardComputer2 = new string[,] { {"0 ","1  ","2  ","3  ","4  ","5  ","6  ","7  ","8  ","9  ","10 " },
                {"A","| |","| |","| |","| |","| |","| |","| |","| |","| |","| |" },
                {"B","| |","| |","| |","| |","| |","| |","| |","| |","| |","| |" },
                {"C","| |","| |","| |","| |","| |","| |","| |","| |","| |","| |" },
                {"D","| |","| |","| |","| |","| |","| |","| |","| |","| |","| |" },
                {"E","| |","| |","| |","| |","| |","| |","| |","| |","| |","| |" },
                {"F","| |","| |","| |","| |","| |","| |","| |","| |","| |","| |" },
                {"G", "| |","| |","| |","| |","| |","| |","| |","| |","| |","| |" },
                { "H","| |","| |","| |","| |","| |","| |","| |","| |","| |","| |" },
                { "I","| |","| |","| |","| |","| |","| |","| |","| |","| |","| |" },
                { "J","| |","| |","| |","| |","| |","| |","| |","| |","| |","| |" } };
        }

        private void PositionAllPieces()
        {
            PlacePawnComputer();
            Console.WriteLine("Bonjour, bienvenue sur le jeux de bataille navale");
            PlacePawn("Cuirassé", 4, 1);
            PlacePawn("Croiseurs", 3, 2);
            PlacePawn("Torpilleurs", 2, 3);
            PlacePawn("Sous-Marin", 1, 4);


        }


        public void Play()
        {
            int CounterComputer = 0;
            int CounterMe = 0;
            int begin = 0;


            if (_random.Next(2) == 1)
            {
                begin++;

            }


            for (int i = begin; i < 250; i++)
            {
                if (i % 2 == 0)
                {
                    if (RoundComputer())
                    {
                        CounterComputer++;
                    }

                }

                else
                {

                    if (MyRound())
                    {
                        CounterMe++;
                    }
                }
                if (CounterMe > 19)
                {
                    Console.WriteLine("Vous avez gagné, félicitation!!!!!!!!!");
                    break;
                }

                if (CounterComputer > 19)
                {
                    Console.WriteLine("Vous avez perdu!!!!!!!");
                    break;
                }
            }


        }


        public void DisplayAll()
        {
            Console.WriteLine("mon plateau");
            Display(_myBoard);
            Console.WriteLine("mon plateau nr 2");
            Display(_myBoard2);
        }

        public void Display(string[,] arr)
        {

            for (int i = 0; i < 11; i++)
            {

                Console.WriteLine();
                Console.Write(arr[i, 0]);
                Console.Write(arr[i, 1]);
                Console.Write(arr[i, 2]);
                Console.Write(arr[i, 3]);
                Console.Write(arr[i, 4]);
                Console.Write(arr[i, 5]);
                Console.Write(arr[i, 6]);
                Console.Write(arr[i, 7]);
                Console.Write(arr[i, 8]);
                Console.Write(arr[i, 9]);
                Console.Write(arr[i, 10]);



            }
            Console.WriteLine();
        }


        public bool RoundComputer()
        {
            bool again = true;
            int x = 0;
            int y = 0;

            while (again)
            {
                x = _random.Next(1, 11);
                y = _random.Next(1, 11);
                if (_boardComputer2[y, x] == "| |")
                {
                    again = false;
                }
            }
            string a;
            string b = x.ToString();

            switch (y)
            {
                case 1:
                    a = "A";
                    break;
                case 2:
                    a = "B";
                    break;
                case 3:
                    a = "C";
                    break;
                case 4:
                    a = "D";
                    break;
                case 5:
                    a = "E";
                    break;
                case 6:
                    a = "F";
                    break;
                case 7:
                    a = "G";
                    break;
                case 8:
                    a = "H";
                    break;
                case 9:
                    a = "I";
                    break;
                case 10:
                    a = "J";
                    break;
                default:
                    a = "Z";
                    break;
            }



            Console.WriteLine("l'ordinateur a joué " + b + a);
            if (_myBoard[y, x] == "| |")
            {
                Console.WriteLine("et c'est coulé!!!!");
                _boardComputer2[y, x] = "|C|";

            }
            else if (_myBoard[y, x] == "|N|")
            {
                Console.WriteLine("et c'est touché");
                _boardComputer2[y, x] = "|T|";


                return true;
            }



            Console.WriteLine("Tour computer");
            DisplayAll();
            return false;
        }


        public bool MyRound()
        {
            bool loop = true;
            int y;
            int x;

            while (loop)
            {


                Console.WriteLine("veuillez choisir une case (par exemple 3C)");

                string indication = Console.ReadLine();
                if ((indication.Length > 3) || String.IsNullOrEmpty(indication))
                {
                    Console.WriteLine("Veuillez compléter correctement la position de votre pion. Par exemple 3C");



                }
                else
                {
                    indication = indication.ToLower();
                    char[] tabchar = indication.ToCharArray();

                    char c = tabchar[tabchar.Length - 1];

                    switch (c)
                    {
                        case 'a':
                            y = 1;
                            break;
                        case 'b':
                            y = 2;
                            break;
                        case 'c':
                            y = 3;
                            break;
                        case 'd':
                            y = 4;
                            break;
                        case 'e':
                            y = 5;
                            break;
                        case 'f':
                            y = 6;
                            break;
                        case 'g':
                            y = 7;
                            break;
                        case 'h':
                            y = 8;
                            break;
                        case 'i':
                            y = 9;
                            break;
                        case 'j':
                            y = 10;
                            break;
                        default:
                            y = 0;
                            break;


                    }

                    string myString = " ";
                    if (tabchar.Length == 2)
                    {
                        myString = tabchar[0].ToString();
                    }
                    else if (tabchar.Length == 3)
                    {
                        myString = "10";
                    }
                    if (int.TryParse(myString, out x))
                    {
                        if ((x > 0) && (x < 11) && (y != 0))
                        {
                            if (_boardComputer[y, x] == "| |")
                            {
                                Console.WriteLine("Coulé");

                                _myBoard2[y, x] = "|C|";
                                loop = false;

                            }

                            else
                            {
                                Console.WriteLine("Touché");

                                _myBoard2[y, x] = "|T|";
                                loop = false;



                                DisplayAll();

                                return true;
                            }

                            DisplayAll();
                            return false;

                        }
                        else
                        {
                            Console.WriteLine("veuillez correctement écrire vos données (Par exemple 4C)");
                        }
                    }
                    else
                    {
                        Console.WriteLine("veuillez correctement écrire vos données (Par exemple 4C)");
                    }
                }
            }
            return false;
        }



        public void PlacePawn(string pawn, int nbrCase, int nbrIteration)
        {
            for (int iteration = 0; iteration < nbrIteration; iteration++)
            {
                int y;
                int x;
                Console.WriteLine("où souhaitez-vous metttre votre " + pawn + " ?(par ex. 4c)");

                string indication = Console.ReadLine();
                if ((indication.Length > 3) || String.IsNullOrEmpty(indication))
                {
                    Console.WriteLine("Veuillez compléter correctement la position de votre pion. Par exemple 4C");
                    iteration--;
                }
                else
                {
                    indication = indication.ToLower();
                    char[] tabchar = indication.ToCharArray();

                    char c = tabchar[tabchar.Length - 1];

                    switch (c)
                    {
                        case 'a':
                            y = 1;
                            break;
                        case 'b':
                            y = 2;
                            break;
                        case 'c':
                            y = 3;
                            break;
                        case 'd':
                            y = 4;
                            break;
                        case 'e':
                            y = 5;
                            break;
                        case 'f':
                            y = 6;
                            break;
                        case 'g':
                            y = 7;
                            break;
                        case 'h':
                            y = 8;
                            break;
                        case 'i':
                            y = 9;
                            break;
                        case 'j':
                            y = 10;
                            break;
                        default:
                            y = 0;
                            break;
                    }



                    string myString = " ";
                    if (tabchar.Length == 2)
                    {
                        myString = tabchar[0].ToString();
                    }
                    else if (tabchar.Length == 3)
                    {
                        myString = tabchar[0].ToString();
                        myString += tabchar[1].ToString();
                    }
                    if (int.TryParse(myString, out x))
                    {
                        Console.WriteLine("Souhaitez-vous le mettre en position horizontale(H) ou verticale(V) ?");

                        string horsvert = "aleatoire";
                        horsvert = Console.ReadLine();

                        if (horsvert.ToLower() == "v")
                        {
                            if ((x + nbrCase - 1 > 10) && (y == 0))
                            {
                                Console.WriteLine("Veuillez remplir correctement les informations");
                                iteration--;
                            }
                            else
                            {
                                bool writeInTheCase = true;
                                for (int i = 0; i < nbrCase; i++)
                                {
                                    if (_myBoard[y + i, x] == "|N|")
                                    {
                                        Console.WriteLine("Il y a déjà un bateau sur ma case");
                                        writeInTheCase = false;
                                        iteration--;
                                        break;
                                    }

                                }

                                if (writeInTheCase == true)
                                {
                                    for (int i = 0; i < nbrCase; i++)
                                    {
                                        _myBoard[y + i, x] = "|N|";
                                    }
                                }

                            }
                        }
                        else if (horsvert.ToLower() == "h")
                        {
                            if (x + nbrCase - 1 > 10 && (y == 0))
                            {
                                Console.WriteLine("Il n'y a pas assez de case horizontale");
                            }
                            else
                            {
                                for (int i = 0; i < nbrCase; i++)
                                {
                                    if (_myBoard[y, x + i] == "|N|")
                                    {
                                        throw new Exception("Il y a déjà un bateau sur ma case");
                                    }
                                    _myBoard[y, x + i] = "|N|";
                                }
                            }

                        }
                        else
                        {
                            Console.WriteLine("vous devez choir h ou v");
                            iteration--;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Le schémas n'est pas correct");
                        iteration--;
                    }
                    Console.WriteLine("le pion a été placé");
                    Display(_myBoard);
                }

            }
        }

        public void PlacePawnComputer()
        {
            Random random = new Random();
            int x = random.Next(1, 11);
            int y = random.Next(1, 11);
            PawnComputer(4);
            PawnComputer(3);
            PawnComputer(3);
            PawnComputer(2);
            PawnComputer(2);
            PawnComputer(2);
            PawnComputer(1);
            PawnComputer(1);
            PawnComputer(1);
            PawnComputer(1);

            Console.WriteLine("L'ordinateur a placé ces pions");
        }

        public void PawnComputer(int nombreDeCase)
        {

            int x, y;
            bool validPosition = true;

            while (validPosition)
            {
                x = _random.Next(1, 11);
                y = _random.Next(1, 11);
                if (_random.Next(2) == 1)
                {

                    if (y + nombreDeCase - 1 < 11)
                    {
                        validPosition = false;
                        for (int i = 0; i < nombreDeCase; i++)
                        {
                            if (_boardComputer[y + i, x] == "|N|")
                            {
                                validPosition = true;
                                break;
                            }
                        }
                        if (!validPosition)
                        {
                            for (int i = 0; i < nombreDeCase; i++)
                            {
                                _boardComputer[y + i, x] = "|N|";
                            }
                        }
                    }
                }
                else
                {
                    if (x + nombreDeCase - 1 < 11)
                    {
                        validPosition = false;
                        for (int i = 0; i < nombreDeCase; i++)
                        {
                            if (_boardComputer[y, x + i] == "|N|")
                            {
                                validPosition = true;
                                break;
                            }
                        }

                        if (!validPosition)
                            for (int i = 0; i < nombreDeCase; i++)
                            {
                                _boardComputer[y, x + i] = "|N|";
                            }
                    }
                }
            }
        }
        public string[,] Myboard
        {
            get { return _myBoard; }
        }

        public string[,] BoardComputer
        {
            get { return _boardComputer; }
        }

    }



}

