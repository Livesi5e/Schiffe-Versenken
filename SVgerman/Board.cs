using System;

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

        Dictionary[] OwnBoard = new Dictionary[25];

        public void SetDictionary()
        {
            OwnBoard[0] = new Dictionary(); OwnBoard[0].letter = 'O'; OwnBoard[0].color = 0;
            OwnBoard[1] = new Dictionary(); OwnBoard[1].letter = 'X'; OwnBoard[1].color = 1;
            OwnBoard[2] = new Dictionary(); OwnBoard[2].letter = 'K'; OwnBoard[2].color = 2;
            OwnBoard[3] = new Dictionary(); OwnBoard[3].letter = ' '; OwnBoard[3].color = null;
            OwnBoard[4] = new Dictionary(); OwnBoard[4].letter = '1'; OwnBoard[4].color = 3;
            OwnBoard[5] = new Dictionary(); OwnBoard[5].letter = '2'; OwnBoard[5].color = 4;
            OwnBoard[6] = new Dictionary(); OwnBoard[6].letter = '3'; OwnBoard[6].color = 3;
            OwnBoard[7] = new Dictionary(); OwnBoard[7].letter = '4'; OwnBoard[7].color = 4;
            OwnBoard[8] = new Dictionary(); OwnBoard[8].letter = '5'; OwnBoard[8].color = 3;
            OwnBoard[9] = new Dictionary(); OwnBoard[9].letter = '6'; OwnBoard[9].color = 4;
            OwnBoard[10] = new Dictionary(); OwnBoard[10].letter = '7'; OwnBoard[10].color = 3;
            OwnBoard[11] = new Dictionary(); OwnBoard[11].letter = '8'; OwnBoard[11].color = 4;
            OwnBoard[12] = new Dictionary(); OwnBoard[12].letter = '9'; OwnBoard[12].color = 3;
            OwnBoard[13] = new Dictionary(); OwnBoard[13].letter = '1'; OwnBoard[13].letter2 = '0'; OwnBoard[13].color = 4;
            OwnBoard[14] = new Dictionary(); OwnBoard[14].letter = 'A'; OwnBoard[14].color = 3;
            OwnBoard[15] = new Dictionary(); OwnBoard[15].letter = 'B'; OwnBoard[15].color = 4;
            OwnBoard[16] = new Dictionary(); OwnBoard[16].letter = 'C'; OwnBoard[16].color = 3;
            OwnBoard[17] = new Dictionary(); OwnBoard[17].letter = 'D'; OwnBoard[17].color = 4;
            OwnBoard[18] = new Dictionary(); OwnBoard[18].letter = 'E'; OwnBoard[18].color = 3;
            OwnBoard[19] = new Dictionary(); OwnBoard[19].letter = 'F'; OwnBoard[19].color = 4;
            OwnBoard[20] = new Dictionary(); OwnBoard[20].letter = 'G'; OwnBoard[20].color = 3;
            OwnBoard[21] = new Dictionary(); OwnBoard[21].letter = 'H'; OwnBoard[21].color = 4;
            OwnBoard[22] = new Dictionary(); OwnBoard[22].letter = 'I'; OwnBoard[22].color = 3;
            OwnBoard[23] = new Dictionary(); OwnBoard[23].letter = 'J'; OwnBoard[23].color = 4;
            OwnBoard[24] = new Dictionary(); OwnBoard[24].letter = 'M'; OwnBoard[24].color = 5;
        }

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
                    switch (OwnBoard[P1board[i, o]].color)                      //Hier wird nach der ID an der Stelle [x|y] die zugehörige Farb-ID aufgerufen
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
                    Console.Write(OwnBoard[P1board[i, o]].letter);               //Hier wird nach der ID an der Stelle [x|y] der zugehörige Buchstabe geprinted
                    if (P1board[i, o] == 13) Console.Write(OwnBoard[P1board[i, o]].letter2);
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
                    switch (OwnBoard[P2board[i, o]].color)
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
                    Console.Write(OwnBoard[P2board[i, o]].letter);
                    if (P2board[i, o] == 13) Console.Write(OwnBoard[P2board[i, o]].letter2);
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
                    switch (OwnBoard[P1boardHidden[i, o]].color)
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
                    Console.Write(OwnBoard[P1boardHidden[i, o]].letter);
                    if (P1boardHidden[i, o] == 13) Console.Write(OwnBoard[P1boardHidden[i, o]].letter2);
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
                    switch (OwnBoard[P2boardHidden[i, o]].color)
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
                    Console.Write(OwnBoard[P2boardHidden[i, o]].letter);
                    if (P2boardHidden[i, o] == 13) Console.Write(OwnBoard[P2boardHidden[i, o]].letter2);
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
            Console.WriteLine("Gegnerisches Feld:\t\tDein Feld:");
            Console.ResetColor();
            for (int i = 0; i < 11; i++)                                    //Hier wird durch die y-Koordinate beider Boards geloopt
            {
                for (int o = 0; o < 11; o++)                                //Hier werden die ID's für die Punkte [x|y] des Boards von Spieler 2 geloopt
                {
                    switch (OwnBoard[P2boardHidden[i, o]].color)
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
                    Console.Write(OwnBoard[P2boardHidden[i, o]].letter);
                    if (P2boardHidden[i, o] == 13) Console.Write(OwnBoard[P2boardHidden[i, o]].letter2);
                    Console.Write(" ");
                    Console.ResetColor();
                }
                Console.Write("\t\t");                                          //Der Abstand zwischen den beiden Boards wird erstellt
                for (int o = 0; o < 11; o++)                                    //Hier werden die ID's für die Punkte [x|y] des Boards von Spieler 1 geloopt
                {
                    switch (OwnBoard[P1board[i, o]].color)
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
                    Console.Write(OwnBoard[P1board[i, o]].letter);
                    if (P1board[i, o] == 13) Console.Write(OwnBoard[P1board[i, o]].letter2);
                    Console.Write(" ");
                    Console.ResetColor();
                }
                Console.Write("\n");
            }
        }

        public void Player1outhP2out()
        {
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("Gegnerisches Feld:\t\tDein Feld:");
            Console.ResetColor();
            for (int i = 0; i < 11; i++)                                    //Hier wird durch die y-Koordinate beider Boards geloopt
            {
                for (int o = 0; o < 11; o++)                                //Hier werden die ID's für die Punkte [x|y] des Boards von Spieler 2 geloopt
                {
                    switch (OwnBoard[P1boardHidden[i, o]].color)
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
                    Console.Write(OwnBoard[P1boardHidden[i, o]].letter);
                    if (P1boardHidden[i, o] == 13) Console.Write(OwnBoard[P1boardHidden[i, o]].letter2);
                    Console.Write(" ");
                    Console.ResetColor();
                }
                Console.Write("\t\t");                                          //Der Abstand zwischen den beiden Boards wird erstellt
                for (int o = 0; o < 11; o++)                                    //Hier werden die ID's für die Punkte [x|y] des Boards von Spieler 1 geloopt
                {
                    switch (OwnBoard[P2board[i, o]].color)
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
                    Console.Write(OwnBoard[P2board[i, o]].letter);
                    if (P2board[i, o] == 13) Console.Write(OwnBoard[P2board[i, o]].letter2);
                    Console.Write(" ");
                    Console.ResetColor();
                }
                Console.Write("\n");
            }
        }

        public string[] sub;                                            //Der Array an User-Inputs [0] = y-Koordinate, [1] = x-Koordinate, [2] = Orientierung

        //Hier ist das Platzieren der Schiffe des ersten Spielers. Übergeben wird die Länge des Schiffes
        public void PlaceP1(int l)
        {
            bool input = true;                                          //Speichert ob ein Input vom User kam. false bedeutet, dass es einen Input gab
            int[] position = get();                                     //Hier wird die Position des Schiffes mithilfe der Funktion get() vom User abgegriffen
            position = check(position, l, sub[2]);                    //Hier wird gecheckt ob die Position des Schiffes innerhalb des Feldes ist
            position = P1checkO(position, l, sub[2]);                   //Hier wird gecheckt ob das Schiff mit anderen Schiffen kollidiert
            while (input)
            {
                switch (sub[2])                                         //Anhand der Länge und Orientierung wird das Schiff plaziert
                {
                    case "up":                                          //Um das Schiff nach "oben" zu platzieren wird die y-Koordinate um 1 subtrahiert.
                        for (int i = 0; i < l; i++)
                        {
                            P1board[position[0] - i, position[1]] = 1;
                        }
                        input = false;
                        break;
                    case "down":                                        //Um das Schiff nach "unten" zu platzieren wird die y-Koordinate um 1 addiert
                        for (int i = 0; i < l; i++)
                        {
                            P1board[position[0] + i, position[1]] = 1;
                        }
                        input = false;
                        break;
                    case "left":                                        //Um das Schiff nach "links" zu platzieren wird die x-Koordinate um 1 subtrahiert
                        for (int i = 0; i < l; i++)
                        {
                            P1board[position[0], position[1] - i] = 1;
                        }
                        input = false;
                        break;
                    case "right":                                       //Um das Schiff nach "rechts" zu platzieren wird die x-Koordinate um 1 addiert
                        for (int i = 0; i < l; i++)
                        {
                            P1board[position[0], position[1] + i] = 1;
                        }
                        input = false;
                        break;
                    default:                                            //Falls keine Richtung angegeben wurde oder eine nicht existierende Richtung angegeben wurde, wird eine neue Richtung abgefragt und noch mal gecheckt
                        Console.WriteLine("Bitte gib eine existierende Richtung an");
                        sub[2] = Console.ReadLine();
                        position = check(position, l, sub[2]);
                        position = P1checkO(position, l, sub[2]);
                        break;
                }
            }

        }

        //Eine Funtion, die einen int[] returnt, welche die Koordinaten für das zu platzierende Schiff beinhaltet
        int[] get()
        {
            temp = Console.ReadLine();      //User input wird gelesen
            sub = temp.Split(",");          //User input wird nach dem Zeichen "," getrennt
            int[] position = new int[3];
            switch (sub[0])                 //Die erste Stelle des Arrays wird in eine Zahl transferiert
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
            switch (sub[1])                 //Die zweite Stelle des Arrays wird transferiert
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
            return position;                //Das int[] mit der Position wird returnt
        }

        //Checkt, ob die angegebene Position innerhalb des Boards liegt, sollte das Schiff dort gesetzt werden. Benötigt die Position (p), Länge des Schiffs (l) und die Orientierung (d)
        int[] check(int[] p, int l, string d)
        {
            switch (d)                      //Nach der Orientierung wird unterschiedlich gecheckt
            {
                case "up":
                    if (p[0] - (l - 1) < 1)    //Es wird der entfernteste Punkt berechnet, welcher vom Schiff aus existiert und geguckt, ob dieser Out of Bounds liegt
                    {
                        Console.WriteLine("Das passt leider nicht :/ Gib bitte ne Position an, wo der passt");
                        p = get();                      //Sollte dieser nicht passen, wird nach einem neuen Punkt gefragt
                        p = check(p, l, sub[2]);      //Dieser wird rekursiv wieder mit dieser Funktion gecheckt
                    }
                    break;
                case "down":
                    if (p[0] + (l - 1) > 10)
                    {
                        Console.WriteLine("Das passt leider nicht :/ Gib bitte ne Position an, wo der passt");
                        p = get();
                        p = check(p, l, sub[2]);
                    }
                    break;
                case "left":
                    if (p[1] - (l - 1) < 1)
                    {
                        Console.WriteLine("Das passt leider nicht :/ Gib bitte ne Position an, wo der passt");
                        p = get();
                        p = check(p, l, sub[2]);
                    }
                    break;
                case "right":
                    if (p[1] + (l - 1) > 10)
                    {
                        Console.WriteLine("Das passt leider nicht :/ Gib bitte ne Position an, wo der passt");
                        p = get();
                        p = check(p, l, sub[2]);
                    }
                    break;
                default:
                    break;
            }
            return p;           //Sollte der aktuelle Punkt die Tests bestanden haben, werden die Koordinaten returnt
        }

        //Eine Funktion, die checkt, ob ein Schiff mit einem anderem kollidiert. Benötigt die Position (p), Länge des Schiffs (l) und die Orientierung (d)
        int[] P1checkO(int[] p, int l, string d)
        {
            for (int i = 0; i < l; i++)                     //Loopt durch jeden Punkt, der erstellt werden würde, um zu gucken, ob da schon einer ist
            {
                switch (d)                                  //Basierend auf der Orientierung wird in eine andere Richtung geguckt
                {
                    case "up":
                        if (P1board[p[0] - i, p[1]] == 1)    //Die Koordinate wird um die Loopanzahl versetzt und geguck, ob die ID dort einem anderem Schiff entspricht
                        {
                            Console.WriteLine("Hier ist leider schon ein Schiff, bitte gib einen freien Platz an");
                            p = get();                      //Wenn dies der Fall ist, wird ein neuer Punkt angefragt
                            p = check(p, l, sub[2]);        //Dieser auf Out of Bounds geprüft
                            p = P1checkO(p, l, sub[2]);     //und rekursiv in dieser Funktion geprüft, bis die Koordinaten passen
                        }
                        break;
                    case "down":
                        if (P1board[p[0] + i, p[1]] == 1)
                        {
                            Console.WriteLine("Hier ist leider schon ein Schiff, bitte gib einen freien Platz an");
                            p = get();
                            p = check(p, l, sub[2]);
                            p = P1checkO(p, l, sub[2]);
                        }
                        break;
                    case "left":
                        if (P1board[p[0], p[1] - i] == 1)
                        {
                            Console.WriteLine("Hier ist leider schon ein Schiff, bitte gib einen freien Platz an");
                            p = get();
                            p = check(p, l, sub[2]);
                            p = P1checkO(p, l, sub[2]);
                        }
                        break;
                    case "right":
                        if (P1board[p[0], p[1] + i] == 1)
                        {
                            Console.WriteLine("Hier ist leider schon ein Schiff, bitte gib einen freien Platz an");
                            p = get();
                            p = check(p, l, sub[2]);
                            p = P1checkO(p, l, sub[2]);
                        }
                        break;
                }
            }
            return p;           //Sollte der Punkt diese Tests bestanden haben, werden die Koordinaten hier returnt
        }


        //Diese Funktion macht den Schuss für Spieler 1
        public void P1shoot()
        {
            int[] target = Shootget();                      //Die Position, wohin der Spieler schießen möchte wird abgegriffen
            while (P2boardHidden[target[0], target[1]] == 1 || P2boardHidden[target[0], target[1]] == 2)       //Es wird auf dem Board des Spielers 2, welches Spieler 1 sieht gecheckt, ob die Koordinate entweder die ID für einen Treffer oder ein Miss beinhaltet
            {
                Console.WriteLine("Hier hast du schon hingeschossen. Wähle lieber ne Position wo du noch nicht geschossen hast");
                target = Shootget();                        //Sollte dies der Fall sein, wird eine neue Koordinate abgefragt
            }
            if (P2board[target[0], target[1]] == 1)           //Sobald der Punkt an einer Stelle ist, welche valide ist, wird gechekt, ob ein Schiff an der Stelle ist
            {
                P2boardHidden[target[0], target[1]] = 1;    //Wenn ja, dann wird beim Board des Gegners das Schiff als zerstört geändert und bei dem eigenen wird ein Schiff angezeigt
                P2board[target[0], target[1]] = 2;
            }
            else                                            //Ansonsten wird bei beiden Boards ein Miss markiert
            {
                P2boardHidden[target[0], target[1]] = 24;
                P2board[target[0], target[1]] = 24;
            }
        }

        int[] target = new int[2];                          //Speichert die Koordinaten des Ziels als int[]

        //Eine Funktion, die die Koordinaten des Ziels vom User abgreift
        public int[] Shootget()
        {
            temp = Console.ReadLine();          //Liest den Input vom User
            sub = temp.Split(",");              //und splittet diese nach dem Zeichen ","
            switch (sub[0])
            {
                case "A":
                    target[0] = 1;
                    target[1] = P1sg2(sub[1]);  //Die Zweite Zahl wird in der anderen Funktion gegriffen
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
                default:                        //Sollte der Input nicht im Spielfeld liegen, wird diese Funktion rekursiv aufgerufen
                    Console.WriteLine("Dies liegt leider nicht im Spielfeld. Bitte wähle eine andere Position");
                    target = Shootget();
                    break;
            }
            return target;
        }

        //Eine Funktion, die die zweite Zahl der Zielkoordinate returnt. Benötigt den String, welcher transkripiert werden soll (i)
        public int P1sg2(string i)
        {
            int temp;               //eine Temporäre Zahl, die am Ende returnt wird
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
                default:        //Wenn die Zahl nicht im Spielfeld liegt, wird nach einer neuen gefragt und diese Funktion rekursiv aufgerufen
                    Console.WriteLine("Dies liegt leider nicht im Spielfeld. Bitte wähle eine andere Zahl");
                    temp = P1sg2(Console.ReadLine());
                    break;
            }
            return temp;        //Die Zahl wird returnt
        }

        //Diese Funktion ist ist eine public get() Funktion für das Board von Spieler 1, welches Spieler 2 sieht
        public int[,] P1hget()
        {
            return P1boardHidden;
        }

        //Eine WIP Funktion für den Multiplayermodus
        public void PlaceP2(int l)
        {
            bool input = true;
            int[] position = get();
            position = check(position, l, sub[2]);
            position = P2checkO(position, l, sub[2]);
            while (input)
            {
                switch (sub[2])                                         //Anhand der Länge und Orientierung wird das Schiff plaziert
                {
                    case "up":                                          //Um das Schiff nach "oben" zu platzieren wird die y-Koordinate um 1 subtrahiert.
                        for (int i = 0; i < l; i++)
                        {
                            P2board[position[0] - i, position[1]] = 1;
                        }
                        input = false;
                        break;
                    case "down":                                        //Um das Schiff nach "unten" zu platzieren wird die y-Koordinate um 1 addiert
                        for (int i = 0; i < l; i++)
                        {
                            P2board[position[0] + i, position[1]] = 1;
                        }
                        input = false;
                        break;
                    case "left":                                        //Um das Schiff nach "links" zu platzieren wird die x-Koordinate um 1 subtrahiert
                        for (int i = 0; i < l; i++)
                        {
                            P2board[position[0], position[1] - i] = 1;
                        }
                        input = false;
                        break;
                    case "right":                                       //Um das Schiff nach "rechts" zu platzieren wird die x-Koordinate um 1 addiert
                        for (int i = 0; i < l; i++)
                        {
                            P2board[position[0], position[1] + i] = 1;
                        }
                        input = false;
                        break;
                    default:                                            //Falls keine Richtung angegeben wurde oder eine nicht existierende Richtung angegeben wurde, wird eine neue Richtung abgefragt und noch mal gecheckt
                        Console.WriteLine("Bitte gib eine existierende Richtung an");
                        sub[2] = Console.ReadLine();
                        position = check(position, l, sub[2]);
                        position = P2checkO(position, l, sub[2]);
                        break;
                }
            }
        }

        int[] P2checkO(int[] p, int l, string d)
        {
            for (int i = 0; i < l; i++)                     //Loopt durch jeden Punkt, der erstellt werden würde, um zu gucken, ob da schon einer ist
            {
                switch (d)                                  //Basierend auf der Orientierung wird in eine andere Richtung geguckt
                {
                    case "up":
                        if (P2board[p[0] - i, p[1]] == 1)   //Die Koordinate wird um die Loopanzahl versetzt und geguck, ob die ID dort einem anderem Schiff entspricht
                        {
                            Console.WriteLine("Hier ist leider schon ein Schiff, bitte gib einen freien Platz an");
                            p = get();                      //Wenn dies der Fall ist, wird ein neuer Punkt angefragt
                            p = check(p, l, sub[2]);        //Dieser auf Out of Bounds geprüft
                            p = P2checkO(p, l, sub[2]);     //und rekursiv in dieser Funktion geprüft, bis die Koordinaten passen
                        }
                        break;
                    case "down":
                        if (P2board[p[0] + i, p[1]] == 1)
                        {
                            Console.WriteLine("Hier ist leider schon ein Schiff, bitte gib einen freien Platz an");
                            p = get();
                            p = check(p, l, sub[2]);
                            p = P2checkO(p, l, sub[2]);
                        }
                        break;
                    case "left":
                        if (P2board[p[0], p[1] - i] == 1)
                        {
                            Console.WriteLine("Hier ist leider schon ein Schiff, bitte gib einen freien Platz an");
                            p = get();
                            p = check(p, l, sub[2]);
                            p = P2checkO(p, l, sub[2]);
                        }
                        break;
                    case "right":
                        if (P2board[p[0], p[1] + i] == 1)
                        {
                            Console.WriteLine("Hier ist leider schon ein Schiff, bitte gib einen freien Platz an");
                            p = get();
                            p = check(p, l, sub[2]);
                            p = P2checkO(p, l, sub[2]);
                        }
                        break;
                }
            }
            return p;           //Sollte der Punkt diese Tests bestanden haben, werden die Koordinaten hier returnt
        }

        public void P2shoot()
        {
            int[] target = Shootget();                      //Die Position, wohin der Spieler schießen möchte wird abgegriffen
            while (P1boardHidden[target[0], target[1]] == 1 || P1boardHidden[target[0], target[1]] == 2)       //Es wird auf dem Board des Spielers 2, welches Spieler 1 sieht gecheckt, ob die Koordinate entweder die ID für einen Treffer oder ein Miss beinhaltet
            {
                Console.WriteLine("Hier hast du schon hingeschossen. Wähle lieber ne Position wo du noch nicht geschossen hast");
                target = Shootget();                        //Sollte dies der Fall sein, wird eine neue Koordinate abgefragt
            }
            if (P1board[target[0], target[1]] == 1)         //Sobald der Punkt an einer Stelle ist, welche valide ist, wird gechekt, ob ein Schiff an der Stelle ist
            {
                P1boardHidden[target[0], target[1]] = 1;    //Wenn ja, dann wird beim Board des Gegners das Schiff als zerstört geändert und bei dem eigenen wird ein Schiff angezeigt
                P1board[target[0], target[1]] = 2;
            }
            else                                            //Ansonsten wird bei beiden Boards ein Miss markiert
            {
                P1boardHidden[target[0], target[1]] = 24;
                P1board[target[0], target[1]] = 24;
            }
        }

        //Diese Funktion returnt ein true, wenn im Board von Spieler 2 keine Schiffe mehr zu finden sind
        public bool CheckWinP1()
        {
            bool temp = true;
            for (int i = 0; i < 11; i++)
            {
                for (int o = 0; o < 11; o++)
                {
                    if (P2board[i, o] == 1)
                    {
                        temp = false;
                    }
                }
            }
            return temp;
        }

        //Diese Funktion returnt ein true, wenn im Board von Spieler 1 keine Schiffe mehr zu finden sind
        public bool CheckWinP2()
        {
            bool temp = true;
            for (int i = 0; i < 11; i++)
            {
                for (int o = 0; o < 11; o++)
                {
                    if (P1board[i, o] == 1)
                    {
                        temp = false;
                    }
                }
            }
            return temp;
        }

        //Eine Funktion welche die Schiffe der AI platziert
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


        //Eine Funktion, die für die AI schießt
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

    class Dictionary
    {
        public char letter { get; set; }
        public char letter2 { get; set; }
        public int? color { get; set; }
    }
}