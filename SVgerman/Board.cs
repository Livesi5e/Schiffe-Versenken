namespace SVgerman
{
    public class Board
    {
        public string temp;

        int[,] P1board = new int[,] {               //Das Board von Spieler 1
    //x = 0   1  2  3  4  5  6  7  8  9  10
        { 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13},     //y = 0
        { 14, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0},        //y = 1
        { 15, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0},        //y = 2
        { 16, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0},        //y = 3
        { 17, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0},        //y = 4
        { 18, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0},        //y = 5
        { 19, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0},        //y = 6
        { 20, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0},        //y = 7
        { 21, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0},        //y = 8
        { 22, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0},        //y = 9
        { 23, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0}         //y = 10
        };

        int[,] P1boardHidden = new int[,] {         //Das Board von Spieler 1, welches Spieler 2 sieht
        { 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13},
        { 14, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
        { 15, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
        { 16, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
        { 17, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
        { 18, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
        { 19, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
        { 20, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
        { 21, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
        { 22, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
        { 23, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0}
        };

        int[,] P2board = new int[,] {               //Das Board von Spieler 2
        { 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13},
        { 14, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
        { 15, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
        { 16, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
        { 17, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
        { 18, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
        { 19, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
        { 20, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
        { 21, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
        { 22, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
        { 23, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0}
        };

        int[,] P2boardHidden = new int[,] {         //Das Board von Spieler 2, welches Spieler 1 sieht
        { 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13},
        { 14, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
        { 15, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
        { 16, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
        { 17, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
        { 18, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
        { 19, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
        { 20, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
        { 21, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
        { 22, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
        { 23, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0}
        };
        
        Dictionary<int, Tuple<string, Nullable<int>>> OwnBoard = new Dictionary<int, Tuple<string, Nullable<int>>>()    //Ein Dictionary, die für jede ID einen Buchstaben und eine Farb-ID beinhaltet
        {
            {0, new Tuple<string, Nullable<int>>("O", 0)},                                          //Die ID "0" hat den Buchstaben "O" und die Farbe Blau
            {1, new Tuple<string, Nullable<int>>("X", 1)},                                          //Die ID "1" hat den Buchstaben "X" und die Farbe Weiß
            {2, new Tuple<string, Nullable<int>>("K", 2)},                                          //Die ID "2" hat den Buchstaben "K" und die Farbe Rot
            {3, new Tuple<string, Nullable<int>>(" ", null)},                                       //Die ID "3" ist ein Leerzeichen und hat keine Farbe
            {4, new Tuple<string, Nullable<int>>("1", 3)},                                          //Die ID "4" hat den Buchstaben "1" und die Farbe Grün
            {5, new Tuple<string, Nullable<int>>("2", 4)},                                          //Die ID "5" hat den Buchstaben "2" und die Farbe Dunkelblau
            {6, new Tuple<string, Nullable<int>>("3", 3)},                                          //Die ID "6" hat den Buchstaben "3" und die Farbe Grün
            {7, new Tuple<string, Nullable<int>>("4", 4)},                                          //Die ID "7" hat den Buchstaben "4" und die Farbe Dunkelblau
            {8, new Tuple<string, Nullable<int>>("5", 3)},                                          //Die ID "8" hat den Buchstaben "5" und die Farbe Grün
            {9, new Tuple<string, Nullable<int>>("6", 4)},                                          //Die ID "9" hat den Buchstaben "6" und die Farbe Dunkelblau
            {10, new Tuple<string, Nullable<int>>("7", 3)},                                         //Die ID "10" hat den Buchstaben "7" und die Farbe Grün
            {11, new Tuple<string, Nullable<int>>("8", 4)},                                         //Die ID "11" hat den Buchstaben "8" und die Farbe Dunkelblau
            {12, new Tuple<string, Nullable<int>>("9", 3)},                                         //Die ID "12" hat den Buchstaben "9" und die Farbe Grün
            {13, new Tuple<string, Nullable<int>>("10", 4)},                                        //Die ID "13" hat den Buchstaben "10" und die Farbe Dunkelblau
            {14, new Tuple<string, Nullable<int>>("A", 3)},                                         //Die ID "14" hat den Buchstaben "A" und die Farbe Grün
            {15, new Tuple<string, Nullable<int>>("B", 4)},                                         //Die ID "15" hat den Buchstaben "B" und die Farbe Dunkelblau
            {16, new Tuple<string, Nullable<int>>("C", 3)},                                         //Die ID "16" hat den Buchstaben "C" und die Farbe Grün
            {17, new Tuple<string, Nullable<int>>("D", 4)},                                         //Die ID "17" hat den Buchstaben "D" und die Farbe Dunkelblau
            {18, new Tuple<string, Nullable<int>>("E", 3)},                                         //Die ID "18" hat den Buchstaben "E" und die Farbe Grün
            {19, new Tuple<string, Nullable<int>>("F", 4)},                                         //Die ID "19" hat den Buchstaben "F" und die Farbe Dunkelblau
            {20, new Tuple<string, Nullable<int>>("G", 3)},                                         //Die ID "20" hat den Buchstaben "G" und die Farbe Grün
            {21, new Tuple<string, Nullable<int>>("H", 4)},                                         //Die ID "21" hat den Buchstaben "H" und die Farbe Dunkelblau
            {22, new Tuple<string, Nullable<int>>("I", 3)},                                         //Die ID "22" hat den Buchstaben "I" und die Farbe Grün
            {23, new Tuple<string, Nullable<int>>("J", 4)},                                         //Die ID "23" hat den Buchstaben "J" und die Farbe Dunkelblau
            {24, new Tuple<string, Nullable<int>>("M", 5)}                                          //Die ID "24" hat den Buchstaben "M" und die Farbe Dunkelgrün
        };

        //Dies printed das Board von Spieler 1 in die Konsole
        public void Player1out()
        {
            Console.ForegroundColor = ConsoleColor.Gray;                        //Konsolenfarbe wird auf Grau umgestellt
            Console.WriteLine("Dein Feld:\n");
            Console.ResetColor();                                               //Farbe wird geresettet für weiters umfärben
            for (int i = 0; i < 11; i++)                                        //Hier wird durch die y-Koordinate geloopt
            {
                for (int o = 0; o < 11; o++)                                    //Hier wird durch die x-Koordinate geloopt
                {
                    switch (OwnBoard[P1board[i, o]].Item2)                      //Hier wird nach der ID an der Stelle [x|y] die zugehörige Farb-ID aufgerufen
                    {
                        case 0:
                            Console.ForegroundColor = ConsoleColor.Blue;        //0 = Blau
                            break;
                        case 1:
                            Console.ForegroundColor = ConsoleColor.White;       //1 = Weiß
                            break;
                        case 2:
                            Console.ForegroundColor = ConsoleColor.Red;         //2 = Rot
                            break;
                        case 3:
                            Console.ForegroundColor = ConsoleColor.Green;       //3 = Grün
                            break;
                        case 4:
                            Console.ForegroundColor = ConsoleColor.DarkBlue;    //4 = Dunkelblau
                            break;
                        case 5:
                            Console.ForegroundColor = ConsoleColor.DarkGreen;   //5 = Dunkelgrün
                            break;
                        default:
                            break;
                    }
                    Console.Write(OwnBoard[P1board[i, o]].Item1);               //Hier wird nach der ID an der Stelle [x|y] der zugehörige Buchstabe geprinted
                    Console.Write(" ");                                         //Aus Schönheitsgründen wird ein Leerzeichen zwischen den Buchstaben platziert
                    Console.ResetColor();                                       //Farbe wird geresettet für den nächsten Loop
                }
                Console.Write("\n");                                            //Nächste Zeile wird gestartet für den nächsten x-Koordinatenloop
            }
        }

        //Dies printed das Board von Spieler 2 in die Konsole
        public void Player2out()
        {
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("Dein Feld:\n");
            Console.ResetColor();
            for (int i = 0; i < 11; i++)
            {
                for (int o = 0; o < 11; o++)
                {
                    switch (OwnBoard[P2board[i, o]].Item2)
                    {
                        case 0:
                            Console.ForegroundColor = ConsoleColor.Blue;
                            break;
                        case 1:
                            Console.ForegroundColor = ConsoleColor.White;
                            break;
                        case 2:
                            Console.ForegroundColor = ConsoleColor.Red;
                            break;
                        case 3:
                            Console.ForegroundColor = ConsoleColor.Green;
                            break;
                        case 4:
                            Console.ForegroundColor = ConsoleColor.DarkBlue;
                            break;
                        case 5:
                            Console.ForegroundColor = ConsoleColor.DarkGreen;
                            break;
                        default:
                            break;
                    }
                    Console.Write(OwnBoard[P2board[i, o]].Item1);
                    Console.Write(" ");
                    Console.ResetColor();
                }
                Console.Write("\n");
            }
        }

        //Dies printed die Sicht von Spieler 2 auf das Board von Spieler 1 in die Konsole
        public void Player1outh()
        {
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("Gegnerisches Feld:");
            for (int i = 0; i < 11; i++)
            {
                for (int o = 0; o < 11; o++)
                {
                    switch (OwnBoard[P1boardHidden[i, o]].Item2)
                    {
                        case 0:
                            Console.ForegroundColor = ConsoleColor.Blue;
                            break;
                        case 1:
                            Console.ForegroundColor = ConsoleColor.White;
                            break;
                        case 2:
                            Console.ForegroundColor = ConsoleColor.Red;
                            break;
                        case 3:
                            Console.ForegroundColor = ConsoleColor.Green;
                            break;
                        case 4:
                            Console.ForegroundColor = ConsoleColor.DarkBlue;
                            break;
                        case 5:
                            Console.ForegroundColor = ConsoleColor.DarkGreen;
                            break;
                        default:
                            break;
                    }
                    Console.Write(OwnBoard[P1boardHidden[i, o]].Item1);
                    Console.Write(" ");
                    Console.ResetColor();
                }
                Console.Write("\n");
            }
        }

        //Dies printed die Sicht von Spieler 1 auf das Board von Spieler 2 in die Konsole
        public void Player2outh()
        {
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("Gegnerisches Feld");
            Console.ResetColor();
            for (int i = 0; i < 11; i++)
            {
                for (int o = 0; o < 11; o++)
                {
                    switch (OwnBoard[P2boardHidden[i, o]].Item2)
                    {
                        case 0:
                            Console.ForegroundColor = ConsoleColor.Blue;
                            break;
                        case 1:
                            Console.ForegroundColor = ConsoleColor.White;
                            break;
                        case 2:
                            Console.ForegroundColor = ConsoleColor.Red;
                            break;
                        case 3:
                            Console.ForegroundColor = ConsoleColor.Green;
                            break;
                        case 4:
                            Console.ForegroundColor = ConsoleColor.DarkBlue;
                            break;
                        case 5:
                            Console.ForegroundColor = ConsoleColor.DarkGreen;
                            break;
                        default:
                            break;
                    }
                    Console.Write(OwnBoard[P2boardHidden[i, o]].Item1);
                    Console.Write(" ");
                    Console.ResetColor();
                }
                Console.Write("\n");
            }
        }

        //Dies printed beide Boards die Spieler 1 sehen kann nebeneinander aus. Zuerst das von Spieler 2 und dann sein eigenes
        public void Player2outhP1out()
        {
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("Gegnerisches Feld:\t\tDein Feld Feld:");
            Console.ResetColor();
            for (int i = 0; i < 11; i++)                                    //Hier wird durch die y-Koordinate beider Boards geloopt
            {
                for (int o = 0; o < 11; o++)                                //Hier werden die ID's für die Punkte [x|y] des Boards von Spieler 2 geloopt
                {
                    switch (OwnBoard[P2boardHidden[i, o]].Item2)
                    {
                        case 0:
                            Console.ForegroundColor = ConsoleColor.Blue;
                            break;
                        case 1:
                            Console.ForegroundColor = ConsoleColor.White;
                            break;
                        case 2:
                            Console.ForegroundColor = ConsoleColor.Red;
                            break;
                        case 3:
                            Console.ForegroundColor = ConsoleColor.Green;
                            break;
                        case 4:
                            Console.ForegroundColor = ConsoleColor.DarkBlue;
                            break;
                        case 5:
                            Console.ForegroundColor = ConsoleColor.DarkGreen;
                            break;
                        default:
                            break;
                    }
                    Console.Write(OwnBoard[P2boardHidden[i, o]].Item1);
                    Console.Write(" ");
                    Console.ResetColor();
                }
                Console.Write("\t\t");                                          //Der Abstand zwischen den beiden Boards wird erstellt
                for (int o = 0; o < 11; o++)                                    //Hier werden die ID's für die Punkte [x|y] des Boards von Spieler 1 geloopt
                {
                    switch (OwnBoard[P1board[i, o]].Item2)
                    {
                        case 0:
                            Console.ForegroundColor = ConsoleColor.Blue;
                            break;
                        case 1:
                            Console.ForegroundColor = ConsoleColor.White;
                            break;
                        case 2:
                            Console.ForegroundColor = ConsoleColor.Red;
                            break;
                        case 3:
                            Console.ForegroundColor = ConsoleColor.Green;
                            break;
                        case 4:
                            Console.ForegroundColor = ConsoleColor.DarkBlue;
                            break;
                        case 5:
                            Console.ForegroundColor = ConsoleColor.DarkGreen;
                            break;
                        default:
                            break;
                    }
                    Console.Write(OwnBoard[P1board[i, o]].Item1);
                    Console.Write(" ");
                    Console.ResetColor();
                }
                Console.Write("\n");
            }
        }

        public string[] sub;                                            //Der Array an User-Inputs
        
        //Hier ist das Platzieren der Schiffe des ersten Spielers. Übergeben wird die Länge des Schiffes
        public void PlaceP1(int l)
        {
            bool input = true;                                          //Speichert ob ein Input vom User kam. false bedeutet, dass es einen Input gab
            int[] position = get();                                     //Hier wird die Position des Schiffes mithilfe der Funktion get() vom User abgegriffen
            position = P1check(position, l, sub[2]);                    //Hier wird gecheckt ob die Position des Schiffes innerhalb des Feldes ist
            position = P1checkO(position, l, sub[2]);                   //Hier wird gecheckt ob das Schiff mit anderen Schiffen kollidiert
            while (input)
            {
                switch (sub[2])
                {
                    case "up":
                        for (int i = 0; i < l; i++)
                        {
                            P1board[position[0] - i, position[1]] = 1;
                        }
                        input = false;
                        break;
                    case "down":
                        for (int i = 0; i < l; i++)
                        {
                            P1board[position[0] + i, position[1]] = 1;
                        }
                        input = false;
                        break;
                    case "left":
                        for (int i = 0; i < l; i++)
                        {
                            P1board[position[0], position[1] - i] = 1;
                        }
                        input = false;
                        break;
                    case "right":
                        for (int i = 0; i < l; i++)
                        {
                            P1board[position[0], position[1] + i] = 1;
                        }
                        input = false;
                        break;
                    default:
                        Console.WriteLine("Bitte gib eine existierende Richtung an");
                        sub[2] = Console.ReadLine();
                        position = P1check(position, l, sub[2]);
                        position = P1checkO(position, l, sub[2]);
                        break;
                }
            }
            
        }

        int[] get()
        {
            temp = Console.ReadLine();
            sub = temp.Split(",");
            int[] position = new int[3];
            switch (sub[0])
            {
                case "A":
                    position[0] = 1;
                    break;
                case "B":
                    position[0] = 2;
                    break;
                case "C":
                    position[0] = 3;
                    break;
                case "D":
                    position[0] = 4;
                    break;
                case "E":
                    position[0] = 5;
                    break;
                case "F":
                    position[0] = 6;
                    break;
                case "G":
                    position[0] = 7;
                    break;
                case "H":
                    position[0] = 8;
                    break;
                case "I":
                    position[0] = 9;
                    break;
                case "J":
                    position[0] = 10;
                    break;
            }
            switch (sub[1])
            {
                case "1":
                    position[1] = 1;
                    break;
                case "2":
                    position[1] = 2;
                    break;
                case "3":
                    position[1] = 3;
                    break;
                case "4":
                    position[1] = 4;
                    break;
                case "5":
                    position[1] = 5;
                    break;
                case "6":
                    position[1] = 6;
                    break;
                case "7":
                    position[1] = 7;
                    break;
                case "8":
                    position[1] = 8;
                    break;
                case "9":
                    position[1] = 9;
                    break;
                case "10":
                    position[1] = 10;
                    break;
            }
            return position;
        }

        int[] P1check(int[] p, int l, string d)
        {
            switch (d)
            {
                case "up":
                    if(p[0] - (l-1) < 1)
                    {
                        Console.WriteLine("Das passt leider nicht :/ Gib bitte ne Position an, wo der passt");
                        p = get();
                        p = P1check(p, l, sub[2]);
                    }
                    break;
                case "down":
                    if (p[0] + (l - 1) > 10)
                    {
                        Console.WriteLine("Das passt leider nicht :/ Gib bitte ne Position an, wo der passt");
                        p = get();
                        p = P1check(p, l, sub[2]);
                    }
                    break;
                case "left":
                    if(p[1] - (l-1) < 1)
                    {
                        Console.WriteLine("Das passt leider nicht :/ Gib bitte ne Position an, wo der passt");
                        p = get();
                        p = P1check(p, l, sub[2]);
                    }
                    break;
                case "right":
                    if(p[1] + (l-1) > 10)
                    {
                        Console.WriteLine("Das passt leider nicht :/ Gib bitte ne Position an, wo der passt");
                        p = get();
                        p = P1check(p, l, sub[2]);
                    }
                    break;
                default:
                    break;
            }
            return p;
        }

        int[] P1checkO(int[] p, int l, string d)
        {
            for (int i = 0; i < l; i++)
            {
                switch (d)
                {
                    case "up":
                        if(P1board[p[0] - i, p[1]] == 1)
                        {
                            Console.WriteLine("Hier ist leider schon ein Schiff, bitte gib einen freien Platz an");
                            p = get();
                            p = P1check(p, l, sub[2]);
                            p = P1checkO(p, l, sub[2]);
                        }
                        break;
                    case "down":
                        if (P1board[p[0] + i, p[1]] == 1)
                        {
                            Console.WriteLine("Hier ist leider schon ein Schiff, bitte gib einen freien Platz an");
                            p = get();
                            p = P1check(p, l, sub[2]);
                            p = P1checkO(p, l, sub[2]);
                        }
                        break;
                    case "left":
                        if (P1board[p[0], p[1] - i] == 1)
                        {
                            Console.WriteLine("Hier ist leider schon ein Schiff, bitte gib einen freien Platz an");
                            p = get();
                            p = P1check(p, l, sub[2]);
                            p = P1checkO(p, l, sub[2]);
                        }
                        break;
                    case "right":
                        if (P1board[p[0], p[1] + i] == 1)
                        {
                            Console.WriteLine("Hier ist leider schon ein Schiff, bitte gib einen freien Platz an");
                            p = get();
                            p = P1check(p, l, sub[2]);
                            p = P1checkO(p, l, sub[2]);
                        }
                        break;
                }
            }
            return p;
        }

        public void P1shoot()
        {
            int[] target = P1shootget();
            while(P2boardHidden[target[0],target[1]] == 1 || P2boardHidden[target[0],target[1]] == 2)
            {
                Console.WriteLine("Hier hast du schon hingeschossen. Wähle lieber ne Position wo du noch nicht geschossen hast");
                target = P1shootget();
            }
            if(P2board[target[0],target[1]] == 1)
            {
                P2boardHidden[target[0], target[1]] = 1;
                P2board[target[0], target[1]] = 2;
            }
            else
            {
                P2boardHidden[target[0], target[1]] = 24;
                P2board[target[0], target[1]] = 24;
            }
        }

        int[] target = new int[2];

        public int[] P1shootget()
        {
            temp = Console.ReadLine();
            sub = temp.Split(",");
            switch (sub[0])
            {
                case "A":
                    target[0] = 1;
                    target[1] = P1sg2(sub[1]);
                    break;
                case "B":
                    target[0] = 2;
                    target[1] = P1sg2(sub[1]);
                    break;
                case "C":
                    target[0] = 3;
                    target[1] = P1sg2(sub[1]);
                    break;
                case "D":
                    target[0] = 4;
                    target[1] = P1sg2(sub[1]);
                    break;
                case "E":
                    target[0] = 5;
                    target[1] = P1sg2(sub[1]);
                    break;
                case "F":
                    target[0] = 6;
                    target[1] = P1sg2(sub[1]);
                    break;
                case "G":
                    target[0] = 7;
                    target[1] = P1sg2(sub[1]);
                    break;
                case "H":
                    target[0] = 8;
                    target[1] = P1sg2(sub[1]);
                    break;
                case "I":
                    target[0] = 9;
                    target[1] = P1sg2(sub[1]);
                    break;
                case "J":
                    target[0] = 10;
                    target[1] = P1sg2(sub[1]);
                    break;
                default:
                    Console.WriteLine("Dies liegt leider nicht im Spielfeld. Bitte wähle eine andere Position");
                    target = P1shootget();                
                    break;
            }
            return target;
        }

        public int P1sg2(string i)
        {
            int temp;
            switch (i)
            {
                case "1":
                    temp = 1;
                    break;
                case "2":
                    temp = 2;
                    break;
                case "3":
                    temp = 3;
                    break;
                case "4":
                    temp = 4;
                    break;
                case "5":
                    temp = 5;
                    break;
                case "6":
                    temp = 6;
                    break;
                case "7":
                    temp = 7;
                    break;
                case "8":
                    temp = 8;
                    break;
                case "9":
                    temp = 9;
                    break;
                case "10":
                    temp = 10;
                    break;
                default:
                    Console.WriteLine("Dies liegt leider nicht im Spielfeld. Bitte wähle eine andere Zahl");
                    temp = P1sg2(Console.ReadLine());
                    break;
            }
            return temp;
        }

        public int[,] P1hget()
        {
            return P1boardHidden;
        }

        public void PlaceP2()
        {

        }

        public bool CheckWinP1()
        {
            bool temp = true;
            for (int i = 0; i < 11; i++)
            {
                for (int o = 0; o < 11; o++)
                {
                    if(P2board[i,o] == 1)
                    {
                        temp = false;
                    }
                }
            }
            return temp;
        }

        public bool CheckWinP2()
        {
            bool temp = true;
            for (int i = 0; i < 11; i++)
            {
                for (int o = 0; o < 11; o++)
                {
                    if(P1board[i,o] == 1)
                    {
                        temp = false;
                    }
                }
            }
            return temp;
        }

        public void PlaceP2AI(int[] positions)
        {
            switch (positions[2])
            {
                case 0:
                    for (int i = 0; i < 2; i++)
                    {
                        P2board[positions[0] - i, positions[1]] = 1;
                    }
                    break;
                case 1:
                    for (int i = 0; i < 2; i++)
                    {
                        P2board[positions[0] + i, positions[1]] = 1;
                    }
                    break;
                case 2:
                    for (int i = 0; i < 2; i++)
                    {
                        P2board[positions[0], positions[1] - i] = 1;
                    }
                    break;
                case 3:
                    for (int i = 0; i < 2; i++)
                    {
                        P2board[positions[0], positions[1] + i] = 1;
                    }
                    break;
            }
            switch (positions[5])
            {
                case 0:
                    for (int i = 0; i < 2; i++)
                    {
                        P2board[positions[3] - i, positions[4]] = 1;
                    }
                    break;
                case 1:
                    for (int i = 0; i < 2; i++)
                    {
                        P2board[positions[3] + i, positions[4]] = 1;
                    }
                    break;
                case 2:
                    for (int i = 0; i < 2; i++)
                    {
                        P2board[positions[3], positions[4] - i] = 1;
                    }
                    break;
                case 3:
                    for (int i = 0; i < 2; i++)
                    {
                        P2board[positions[3], positions[4] + i] = 1;
                    }
                    break;
            }
            switch (positions[8])
            {
                case 0:
                    for (int i = 0; i < 3; i++)
                    {
                        P2board[positions[6] - i, positions[7]] = 1;
                    }
                    break;
                case 1:
                    for (int i = 0; i < 3; i++)
                    {
                        P2board[positions[6] + i, positions[7]] = 1;
                    }
                    break;
                case 2:
                    for (int i = 0; i < 3; i++)
                    {
                        P2board[positions[6], positions[7] - i] = 1;
                    }
                    break;
                case 3:
                    for (int i = 0; i < 3; i++)
                    {
                        P2board[positions[6], positions[7] + i] = 1;
                    }
                    break;
            }
            switch (positions[11])
            {
                case 0:
                    for (int i = 0; i < 3; i++)
                    {
                        P2board[positions[9] - i, positions[10]] = 1;
                    }
                    break;
                case 1:
                    for (int i = 0; i < 3; i++)
                    {
                        P2board[positions[9] + i, positions[10]] = 1;
                    }
                    break;
                case 2:
                    for (int i = 0; i < 3; i++)
                    {
                        P2board[positions[9], positions[10] - i] = 1;
                    }
                    break;
                case 3:
                    for (int i = 0; i < 3; i++)
                    {
                        P2board[positions[9], positions[10] + i] = 1;
                    }
                    break;
            }
            switch (positions[14])
            {
                case 0:
                    for (int i = 0; i < 4; i++)
                    {
                        P2board[positions[12] - i, positions[13]] = 1;
                    }
                    break;
                case 1:
                    for (int i = 0; i < 4; i++)
                    {
                        P2board[positions[12] + i, positions[13]] = 1;
                    }
                    break;
                case 2:
                    for (int i = 0; i < 4; i++)
                    {
                        P2board[positions[12], positions[13] - i] = 1;
                    }
                    break;
                case 3:
                    for (int i = 0; i < 4; i++)
                    {
                        P2board[positions[12], positions[13] + i] = 1;
                    }
                    break;
            }
            switch (positions[17])
            {
                case 0:
                    for (int i = 0; i < 5; i++)
                    {
                        P2board[positions[15] - i, positions[16]] = 1;
                    }
                    break;
                case 1:
                    for (int i = 0; i < 5; i++)
                    {
                        P2board[positions[15] + i, positions[16]] = 1;
                    }
                    break;
                case 2:
                    for (int i = 0; i < 5; i++)
                    {
                        P2board[positions[15], positions[16] - i] = 1;
                    }
                    break;
                case 3:
                    for (int i = 0; i < 5; i++)
                    {
                        P2board[positions[15], positions[16] + i] = 1;
                    }
                    break;
            }
        }

        public void P2shootAI(int[] target)
        {
            if (P1board[target[0], target[1]] == 1)
            {
                P1boardHidden[target[0], target[1]] = 1;
                P1board[target[0], target[1]] = 2;
            }
            else
            {
                P1boardHidden[target[0], target[1]] = 24;
                P1board[target[0], target[1]] = 24;
            }
        }
    }
}