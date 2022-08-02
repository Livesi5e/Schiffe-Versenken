using System;
using SVLang;

namespace SVgerman
{
    public class Board
    {
        public string temp;
        public string lang;
        dict d = new dict();

        int[,] P1board = {                          //Das Board von Spieler 1
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

        int[,] P1boardHidden = {                    //Das Board von Spieler 1, welches Spieler 2 sieht
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

        int[,] P2board = {                          //Das Board von Spieler 2
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

        int[,] P2boardHidden = {                    //Das Board von Spieler 2, welches Spieler 1 sieht
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

        public int?[][] P1Schiffe = { 
            new int?[] { 0, 0},
            new int?[] { 0, 0},
            new int?[] { 0, 0},
            new int?[] { 0, 0},
            new int?[] { 0, 0, 0, 0},
            new int?[] { 0, 0, 0, 0},
            new int?[] { 0, 0, 0, 0},
            new int?[] { 0, 0, 0, 0, 0, 0},
            new int?[] { 0, 0, 0, 0, 0, 0},
            new int?[] { 0, 0, 0, 0, 0, 0, 0, 0},
            new int?[] { 0, 0, 0, 0},
            new int?[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
            new int?[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
        };

        int[][] P1SchiffeC ={
            new int[] { 0, 0},
            new int[] { 0, 0},
            new int[] { 0, 0},
            new int[] { 0, 0},
            new int[] { 0, 0, 0, 0},
            new int[] { 0, 0, 0, 0},
            new int[] { 0, 0, 0, 0},
            new int[] { 0, 0, 0, 0, 0, 0},
            new int[] { 0, 0, 0, 0, 0, 0},
            new int[] { 0, 0, 0, 0, 0, 0, 0, 0},
        };

        public int?[][] P2Schiffe = {
            new int?[] { 0, 0},
            new int?[] { 0, 0},
            new int?[] { 0, 0},
            new int?[] { 0, 0},
            new int?[] { 0, 0, 0, 0},
            new int?[] { 0, 0, 0, 0},
            new int?[] { 0, 0, 0, 0},
            new int?[] { 0, 0, 0, 0, 0, 0},
            new int?[] { 0, 0, 0, 0, 0, 0},
            new int?[] { 0, 0, 0, 0, 0, 0, 0, 0},
            new int?[] { 0, 0, 0, 0},
            new int?[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
            new int?[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
        };

        int[][] P2SchiffeC ={
            new int[] { 0, 0},
            new int[] { 0, 0},
            new int[] { 0, 0},
            new int[] { 0, 0},
            new int[] { 0, 0, 0, 0},
            new int[] { 0, 0, 0, 0},
            new int[] { 0, 0, 0, 0},
            new int[] { 0, 0, 0, 0, 0, 0},
            new int[] { 0, 0, 0, 0, 0, 0},
            new int[] { 0, 0, 0, 0, 0, 0, 0, 0},
        };

        //Dies printed das Board von Spieler 1 in die Konsole
        public void Player1out()
        {
            Console.ForegroundColor = ConsoleColor.Gray;                        //Konsolenfarbe wird auf Grau umgestellt
            Console.WriteLine(d.text(25, lang));
            Console.ResetColor();                                               //Farbe wird geresettet für weiters umfärben
            for (int i = 0; i < 11; i++)                                        //Hier wird durch die y-Koordinate geloopt
            {
                for (int o = 0; o < 11; o++)                                    //Hier wird durch die x-Koordinate geloopt
                {
                    switch (d.col(P1board[i, o]))                      //Hier wird nach der ID an der Stelle [x|y] die zugehörige Farb-ID aufgerufen
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
                    Console.Write(d.lett(P1board[i, o]));               //Hier wird nach der ID an der Stelle [x|y] der zugehörige Buchstabe geprinted
                    if (P1board[i, o] == 13) Console.Write('0');
                    Console.Write(" ");                                         //Aus Schönheitsgründen wird ein Leerzeichen zwischen den Buchstaben platziert
                    Console.ResetColor();                                       //Farbe wird geresettet für den nächsten Loop
                }
                Console.Write("\n");                                            //Nächste Zeile wird gestartet für den nächsten x-Koordinatenloop
            }
            Console.WriteLine("\n" + P1Schiffe[10][0] + " " + d.text(33, lang) + "\n" + P1Schiffe[10][1] + " " + d.text(34, lang) + "\n" + P1Schiffe[10][2] + " " + d.text(35, lang) + "\n" + P1Schiffe[10][3] + " " + d.text(36, lang) + "\n");
        }

        //Dies printed das Board von Spieler 2 in die Konsole
        public void Player2out()
        {
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine(d.text(25, lang));
            Console.ResetColor();
            for (int i = 0; i < 11; i++)
            {
                for (int o = 0; o < 11; o++)
                {
                    switch (d.col(P2board[i, o]))
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
                    Console.Write(d.lett(P2board[i, o]));
                    if (P2board[i, o] == 13) Console.Write('0');
                    Console.Write(" ");
                    Console.ResetColor();
                }
                Console.Write("\n");
            }
            Console.WriteLine("\n" + P2Schiffe[10][0] + " " + d.text(33, lang) + "\n" + P2Schiffe[10][1] + " " + d.text(34, lang) + "\n" + P2Schiffe[10][2] + " " + d.text(35, lang) + "\n" + P2Schiffe[10][3] + " " + d.text(36, lang) + "\n");
        }

        //Dies printed die Sicht von Spieler 2 auf das Board von Spieler 1 in die Konsole
        public void Player1outh()
        {
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine(d.text(26, lang));
            for (int i = 0; i < 11; i++)
            {
                for (int o = 0; o < 11; o++)
                {
                    switch (d.col(P1boardHidden[i, o]))
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
                    Console.Write(d.lett(P1boardHidden[i, o]));
                    if (P1boardHidden[i, o] == 13) Console.Write('0');
                    Console.Write(" ");
                    Console.ResetColor();
                }
                Console.Write("\n");
            }
            Console.WriteLine("\n" + P1Schiffe[10][0] + " " + d.text(33, lang) + "\n" + P1Schiffe[10][1] + " " + d.text(34, lang) + "\n" + P1Schiffe[10][2] + " " + d.text(35, lang) + "\n" + P1Schiffe[10][3] + " " + d.text(36, lang) + "\n");
        }

        //Dies printed die Sicht von Spieler 1 auf das Board von Spieler 2 in die Konsole
        public void Player2outh()
        {
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine(d.text(26, lang));
            Console.ResetColor();
            for (int i = 0; i < 11; i++)
            {
                for (int o = 0; o < 11; o++)
                {
                    switch (d.col(P2boardHidden[i, o]))
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
                    Console.Write(d.lett(P2boardHidden[i, o]));
                    if (P2boardHidden[i, o] == 13) Console.Write('0');
                    Console.Write(" ");
                    Console.ResetColor();
                }
                Console.Write("\n");
            }
            Console.WriteLine("\n" + P2Schiffe[10][0] + " " + d.text(33, lang) + "\n" + P2Schiffe[10][1] + " " + d.text(34, lang) + "\n" + P2Schiffe[10][2] + " " + d.text(35, lang) + "\n" + P2Schiffe[10][3] + " " + d.text(36, lang) + "\n");
        }

        //Dies printed beide Boards die Spieler 1 sehen kann nebeneinander aus. Zuerst das von Spieler 2 und dann sein eigenes
        public void Player2outhP1out()
        {
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine(d.text(26, lang) + "\t\t" + d.text(25, lang));
            Console.ResetColor();
            for (int i = 0; i < 11; i++)                                    //Hier wird durch die y-Koordinate beider Boards geloopt
            {
                for (int o = 0; o < 11; o++)                                //Hier werden die ID's für die Punkte [x|y] des Boards von Spieler 2 geloopt
                {
                    switch (d.col(P2boardHidden[i, o]))
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
                    Console.Write(d.lett(P2boardHidden[i, o]));
                    if (P2boardHidden[i, o] == 13) Console.Write('0');
                    Console.Write(" ");
                    Console.ResetColor();
                }
                Console.Write("\t\t");                                          //Der Abstand zwischen den beiden Boards wird erstellt
                for (int o = 0; o < 11; o++)                                    //Hier werden die ID's für die Punkte [x|y] des Boards von Spieler 1 geloopt
                {
                    switch (d.col(P1board[i, o]))
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
                    Console.Write(d.lett(P1board[i, o]));
                    if (P1board[i, o] == 13) Console.Write('0');
                    Console.Write(" ");
                    Console.ResetColor();
                }
                Console.Write("\n");
            }
            Console.WriteLine("\n" + P2Schiffe[10][0] + " " + d.text(33, lang) + "\t\t\t" + P1Schiffe[10][0] + " " + d.text(33, lang) + "\n" + P2Schiffe[10][1] + " " + d.text(34, lang) + "\t\t\t" + P1Schiffe[10][1] + " " + d.text(34, lang) + "\n" + P2Schiffe[10][2] + " " + d.text(35, lang) + "\t\t\t" + P1Schiffe[10][2] + " " + d.text(35, lang) + "\n" + P2Schiffe[10][3] + " " + d.text(36, lang) + "\t\t\t" + P1Schiffe[10][3] + " " + d.text(36, lang) + "\n");
        }

        public void Player1outhP2out()
        {
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine(d.text(26, lang) + "\t\t" + d.text(25, lang));
            Console.ResetColor();
            for (int i = 0; i < 11; i++)                                    //Hier wird durch die y-Koordinate beider Boards geloopt
            {
                for (int o = 0; o < 11; o++)                                //Hier werden die ID's für die Punkte [x|y] des Boards von Spieler 2 geloopt
                {
                    switch (d.col(P1boardHidden[i, o]))
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
                    Console.Write(d.lett(P1boardHidden[i, o]));
                    if (P1boardHidden[i, o] == 13) Console.Write('0');
                    Console.Write(" ");
                    Console.ResetColor();
                }
                Console.Write("\t\t");                                          //Der Abstand zwischen den beiden Boards wird erstellt
                for (int o = 0; o < 11; o++)                                    //Hier werden die ID's für die Punkte [x|y] des Boards von Spieler 1 geloopt
                {
                    switch (d.col(P2board[i, o]))
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
                    Console.Write(d.lett(P2board[i, o]));
                    if (P2board[i, o] == 13) Console.Write('0');
                    Console.Write(" ");
                    Console.ResetColor();
                }
                Console.Write("\n");
            }
            Console.WriteLine("\n" + P1Schiffe[10][0] + " " + d.text(33, lang) + "\t\t\t" + P2Schiffe[10][0] + " " + d.text(33, lang) + "\n" + P1Schiffe[10][1] + " " + d.text(34, lang) + "\t\t\t" + P2Schiffe[10][1] + " " + d.text(34, lang) + "\n" + P1Schiffe[10][2] + " " + d.text(35, lang) + "\t\t\t" + P2Schiffe[10][2] + " " + d.text(35, lang) + "\n" + P1Schiffe[10][3] + " " + d.text(36, lang) + "\t\t\t" + P2Schiffe[10][3] + " " + d.text(36, lang) + "\n");
        }

        public string[] sub;                                            //Der Array an User-Inputs [0] = y-Koordinate, [1] = x-Koordinate, [2] = Orientierung

        //Hier ist das Platzieren der Schiffe des ersten Spielers. Übergeben wird die Länge des Schiffes
        public void PlaceP1(int l, int r)
        {
            bool input = true;                                          //Speichert ob ein Input vom User kam. false bedeutet, dass es einen Input gab
            int temp = 0;
            int[] position = get();                                     //Hier wird die Position des Schiffes mithilfe der Funktion get() vom User abgegriffen
            position = check(position, l, sub[2]);                      //Hier wird gecheckt ob die Position des Schiffes innerhalb des Feldes ist
            position = P1checkO(position, l, sub[2]);                   //Hier wird gecheckt ob das Schiff mit anderen Schiffen kollidiert
            while (input)
            {
                switch (sub[2])                                         //Anhand der Länge und Orientierung wird das Schiff plaziert
                {
                    case "up":                                          //Um das Schiff nach "oben" zu platzieren wird die y-Koordinate um 1 subtrahiert.
                        if (position[0] + 1 < 11)
                        {
                            P1board[position[0] + 1, position[1]] = 25;
                            if (position[1] + 1 < 11) P1board[position[0] + 1, position[1] + 1] = 25;
                            if (position[1] - 1 > 0) P1board[position[0] + 1, position[1] - 1] = 25;
                        }
                        for (int i = 0; i < l; i++)
                        {
                            P1board[position[0] - i, position[1]] = 1;
                            if (position[1] + 1 < 11) P1board[position[0] - i, position[1] + 1] = 25;
                            if (position[1] - 1 > 0) P1board[position[0] - i, position[1] - 1] = 25;
                            P1Schiffe[r][temp] = position[0] - i;
                            P1Schiffe[r][temp + 1] = position[1];
                            temp = temp + 2;
                        }
                        if (position[0] - l > 0)
                        {
                            P1board[position[0] - l, position[1]] = 25;
                            if (position[1] - 1 > 0) P1board[position[0] - l, position[1] - 1] = 25;
                            if (position[1] + 1 < 11) P1board[position[0] - l, position[1] + 1] = 25;
                        }
                        P1Schiffe[10][l - 1]++;
                        P1Schiffe[12][r] = 0;
                        input = false;
                        break;
                    case "down":                                        //Um das Schiff nach "unten" zu platzieren wird die y-Koordinate um 1 addiert
                        if (position[0] - 1 > 0)
                        {
                            P1board[position[0] - 1, position[1]] = 25;
                            if (position[1] - 1 > 0) P1board[position[0] - 1, position[1] - 1] = 25;
                            if (position[1] + 1 < 11) P1board[position[0] - 1, position[1] + 1] = 25;
                        }
                        for (int i = 0; i < l; i++)
                        {
                            P1board[position[0] + i, position[1]] = 1;
                            if (position[1] + 1 < 11) P1board[position[0] + i, position[1] + 1] = 25;
                            if (position[1] - 1 > 0) P1board[position[0] + i, position[1] - 1] = 25;
                            P1Schiffe[r][temp] = position[0] + i;
                            P1Schiffe[r][temp + 1] = position[1];
                            temp = temp + 2;
                        }
                        if (position[0] + l < 11)
                        {
                            P1board[position[0] + l, position[1]] = 25;
                            if (position[1] - 1 > 0) P1board[position[0] + l, position[1] - 1] = 25;
                            if (position[1] + 1 < 11) P1board[position[0] + l, position[1] + 1] = 25;
                        }
                        P1Schiffe[10][l - 1]++;
                        P1Schiffe[12][r] = 1;
                        input = false;
                        break;
                    case "left":                                        //Um das Schiff nach "links" zu platzieren wird die x-Koordinate um 1 subtrahiert
                        if (position[1] + 1 < 11)
                        {
                            P1board[position[0], position[1] + 1] = 25;
                            if (position[0] - 1 > 0) P1board[position[0] - 1, position[1] + 1] = 25;
                            if (position[0] + 1 < 11) P1board[position[0] + 1, position[1] + 1] = 25;
                        }
                        for (int i = 0; i < l; i++)
                        {
                            P1board[position[0], position[1] - i] = 1;
                            if (position[0] + 1 < 11) P1board[position[0] + 1, position[1] - i] = 25;
                            if (position[0] - 1 > 0) P1board[position[0] - 1, position[1] - i] = 25;
                            P1Schiffe[r][temp] = position[0];
                            P1Schiffe[r][temp + 1] = position[1] - i;
                            temp = temp + 2;
                        }
                        if (position[1] - l > 0)
                        {
                            P1board[position[0], position[1] - l] = 25;
                            if (position[0] - 1 > 0) P1board[position[0] - 1, position[1] - l] = 25;
                            if (position[0] + 1 < 11) P1board[position[0] + 1, position[1] - l] = 25;
                        }
                        P1Schiffe[10][l - 1]++;
                        P1Schiffe[12][r] = 2;
                        input = false;
                        break;
                    case "right":                                       //Um das Schiff nach "rechts" zu platzieren wird die x-Koordinate um 1 addiert
                        if (position[1] - 1 > 0)
                        {
                            P1board[position[0], position[1] - 1] = 25;
                            if (position[0] - 1 > 0) P1board[position[0] - 1, position[1] - 1] = 25;
                            if (position[0] + 1 < 11) P1board[position[0] + 1, position[1] - 1] = 25;
                        }
                        for (int i = 0; i < l; i++)
                        {
                            P1board[position[0], position[1] + i] = 1;
                            if (position[0] + 1 < 11) P1board[position[0] + 1, position[1] + i] = 25;
                            if (position[0] - 1 > 0) P1board[position[0] - 1, position[1] + i] = 25;
                            P1Schiffe[r][temp] = position[0];
                            P1Schiffe[r][temp + 1] = position[1] + i;
                        }
                        if (position[1] + l < 11)
                        {
                            P1board[position[0], position[1] + l] = 25;
                            if (position[0] - 1 > 0) P1board[position[0] - 1, position[1] + l] = 25;
                            if (position[0] + 1 < 11) P1board[position[0] + 1, position[1] + l] = 25;
                        }
                        P1Schiffe[10][l - 1]++;
                        P1Schiffe[12][r] = 3;
                        input = false;
                        break;
                    default:                                            //Falls keine Richtung angegeben wurde oder eine nicht existierende Richtung angegeben wurde, wird eine neue Richtung abgefragt und noch mal gecheckt
                        Console.WriteLine(d.text(27, lang));
                        sub[2] = Console.ReadLine();
                        position = check(position, l, sub[2]);
                        position = P1checkO(position, l, sub[2]);
                        break;
                }
            }
            for (int i = 0; i < P1SchiffeC[r].Length; i++)
            {
                P1SchiffeC[r][i] = (int)P1Schiffe[r][i];
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
        int[] check(int[] p, int l, string di)
        {
            switch (di)                      //Nach der Orientierung wird unterschiedlich gecheckt
            {
                case "up":
                    if (p[0] - (l - 1) < 1)    //Es wird der entfernteste Punkt berechnet, welcher vom Schiff aus existiert und geguckt, ob dieser Out of Bounds liegt
                    {
                        Console.WriteLine(d.text(28, lang));
                        p = get();                      //Sollte dieser nicht passen, wird nach einem neuen Punkt gefragt
                        p = check(p, l, sub[2]);      //Dieser wird rekursiv wieder mit dieser Funktion gecheckt
                    }
                    break;
                case "down":
                    if (p[0] + (l - 1) > 10)
                    {
                        Console.WriteLine(d.text(28, lang));
                        p = get();
                        p = check(p, l, sub[2]);
                    }
                    break;
                case "left":
                    if (p[1] - (l - 1) < 1)
                    {
                        Console.WriteLine(d.text(28, lang));
                        p = get();
                        p = check(p, l, sub[2]);
                    }
                    break;
                case "right":
                    if (p[1] + (l - 1) > 10)
                    {
                        Console.WriteLine(d.text(28, lang));
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
        int[] P1checkO(int[] p, int l, string di)
        {
            for (int i = 0; i < l; i++)                     //Loopt durch jeden Punkt, der erstellt werden würde, um zu gucken, ob da schon einer ist
            {
                switch (di)                                  //Basierend auf der Orientierung wird in eine andere Richtung geguckt
                {
                    case "up":
                        if (P1board[p[0] - i, p[1]] == 1 || P1board[p[0] - i, p[1]] == 25)    //Die Koordinate wird um die Loopanzahl versetzt und geguck, ob die ID dort einem anderem Schiff entspricht
                        {
                            Console.WriteLine(d.text(29, lang));
                            p = get();                      //Wenn dies der Fall ist, wird ein neuer Punkt angefragt
                            p = check(p, l, sub[2]);        //Dieser auf Out of Bounds geprüft
                            p = P1checkO(p, l, sub[2]);     //und rekursiv in dieser Funktion geprüft, bis die Koordinaten passen
                        }
                        break;
                    case "down":
                        if (P1board[p[0] + i, p[1]] == 1 || P1board[p[0] + i, p[1]] == 25)
                        {
                            Console.WriteLine(d.text(29, lang));
                            p = get();
                            p = check(p, l, sub[2]);
                            p = P1checkO(p, l, sub[2]);
                        }
                        break;
                    case "left":
                        if (P1board[p[0], p[1] - i] == 1 || P1board[p[0], p[1] - i] == 25)
                        {
                            Console.WriteLine(d.text(29, lang));
                            p = get();
                            p = check(p, l, sub[2]);
                            p = P1checkO(p, l, sub[2]);
                        }
                        break;
                    case "right":
                        if (P1board[p[0], p[1] + i] == 1 || P1board[p[0], p[1] + i] == 25)
                        {
                            Console.WriteLine(d.text(29, lang));
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
            bool found = false;
            int[] target = Shootget();                      //Die Position, wohin der Spieler schießen möchte wird abgegriffen
            while (P2boardHidden[target[0], target[1]] == 1 || P2boardHidden[target[0], target[1]] == 24)       //Es wird auf dem Board des Spielers 2, welches Spieler 1 sieht gecheckt, ob die Koordinate entweder die ID für einen Treffer oder ein Miss beinhaltet
            {
                Console.WriteLine(d.text(30, lang));
                target = Shootget();                        //Sollte dies der Fall sein, wird eine neue Koordinate abgefragt
            }
            if (P2board[target[0], target[1]] == 1)           //Sobald der Punkt an einer Stelle ist, welche valide ist, wird gechekt, ob ein Schiff an der Stelle ist
            {
                P2boardHidden[target[0], target[1]] = 1;    //Wenn ja, dann wird beim Board des Gegners das Schiff als zerstört geändert und bei dem eigenen wird ein Schiff angezeigt
                P2board[target[0], target[1]] = 2;
                while (found == false) 
                {
                    for (int i = 0; i < P2Schiffe.Length - 3; i++)
                    {
                        for (int o = 0; o < P2Schiffe[i].Length ; o = o + 2)
                        {
                            if (P2Schiffe[i][o] == target[0] && P2Schiffe[i][o + 1] == target[1])
                            {
                                found = true;
                                P2Schiffe[i][o] = null;
                                P2Schiffe[i][o + 1] = null;
                                break;
                            }
                        }
                        if (found) break;
                    }
                }
            }
            else                                            //Ansonsten wird bei beiden Boards ein Miss markiert
            {
                P2boardHidden[target[0], target[1]] = 24;
                P2board[target[0], target[1]] = 24;
            }
            checkSP2();
        }

        void checkSP2()
        {
            if (P2Schiffe[0][0] == null && P2Schiffe[0][1] == null && P2Schiffe[11][0] == 0) 
            {
                P2Schiffe[10][0]--;
                P2Schiffe[11][0]++;
                if (P2SchiffeC[0][0] - 1 > 0)
                {
                    P1board[P2SchiffeC[0][0] - 1, P2SchiffeC[0][1]] = 24;
                    P1boardHidden[P2SchiffeC[0][0] - 1, P2SchiffeC[0][1]] = 24;
                    if (P2SchiffeC[0][1] + 1 < 11)
                    {
                        P1board[P2SchiffeC[0][0] - 1, P2SchiffeC[0][1] + 1] = 24;
                        P1boardHidden[P2SchiffeC[0][0] - 1, P2SchiffeC[0][1] + 1] = 24;
                    }
                    if (P2SchiffeC[0][1] - 1 > 0)
                    {
                        P1board[P2SchiffeC[0][0] - 1, P2SchiffeC[0][1] - 1] = 24;
                        P1boardHidden[P2SchiffeC[0][0] - 1, P2SchiffeC[0][1] - 1] = 24;
                    }
                }
                if (P2SchiffeC[0][1] + 1 < 11)
                {
                    P1board[P2SchiffeC[0][0], P2SchiffeC[0][1] + 1] = 24;
                    P1boardHidden[P2SchiffeC[0][0], P2SchiffeC[0][1] + 1] = 24;
                }
                if (P2SchiffeC[0][1] - 1 > 0)
                {
                    P1board[P2SchiffeC[0][0], P2SchiffeC[0][1] - 1] = 24;
                    P1boardHidden[P2SchiffeC[0][0], P2SchiffeC[0][1] - 1] = 24;
                }
                if (P2SchiffeC[0][0] + 1 < 11)
                {
                    P1board[P2SchiffeC[0][0] + 1, P2SchiffeC[0][1]] = 24;
                    P1boardHidden[P2SchiffeC[0][0] + 1, P2SchiffeC[0][1]] = 24;
                    if (P2SchiffeC[0][1] + 1 < 11)
                    {
                        P1board[P2SchiffeC[0][0] + 1, P2SchiffeC[0][1] + 1] = 24;
                        P1boardHidden[P2SchiffeC[0][0] + 1, P2SchiffeC[0][1] + 1] = 24;
                    }
                    if (P2SchiffeC[0][1] - 1 > 0)
                    {
                        P1board[P2SchiffeC[0][0] + 1, P2SchiffeC[0][1] - 1] = 24;
                        P1boardHidden[P2SchiffeC[0][0] + 1, P2SchiffeC[0][1] - 1] = 24;
                    }
                }
            }
            if (P2Schiffe[1][0] == null && P2Schiffe[1][1] == null && P2Schiffe[11][1] == 0)
            {
                P2Schiffe[10][0]--;
                P2Schiffe[11][1]++;
                if (P2SchiffeC[1][0] - 1 > 0)
                {
                    P1board[P2SchiffeC[1][0] - 1, P2SchiffeC[1][1]] = 24;
                    P1boardHidden[P2SchiffeC[1][0] - 1, P2SchiffeC[1][1]] = 24;
                    if (P2SchiffeC[1][1] + 1 < 11)
                    {
                        P1board[P2SchiffeC[1][0] - 1, P2SchiffeC[1][1] + 1] = 24;
                        P1boardHidden[P2SchiffeC[1][0] - 1, P2SchiffeC[1][1] + 1] = 24;
                    }
                    if (P2SchiffeC[1][1] - 1 > 0)
                    {
                        P1board[P2SchiffeC[1][0] - 1, P2SchiffeC[1][1] - 1] = 24;
                        P1boardHidden[P2SchiffeC[1][0] - 1, P2SchiffeC[1][1] - 1] = 24;
                    }
                }
                if (P2SchiffeC[1][1] + 1 < 11)
                {
                    P1board[P2SchiffeC[1][0], P2SchiffeC[1][1] + 1] = 24;
                    P1boardHidden[P2SchiffeC[1][0], P2SchiffeC[1][1] + 1] = 24;
                }
                if (P2SchiffeC[1][1] - 1 > 0)
                {
                    P1board[P2SchiffeC[1][0], P2SchiffeC[1][1] - 1] = 24;
                    P1boardHidden[P2SchiffeC[1][0], P2SchiffeC[1][1] - 1] = 24;
                }
                if (P2SchiffeC[1][0] + 1 < 11)
                {
                    P1board[P2SchiffeC[1][0] + 1, P2SchiffeC[1][1]] = 24;
                    P1boardHidden[P2SchiffeC[1][0] + 1, P2SchiffeC[1][1]] = 24;
                    if (P2SchiffeC[1][1] + 1 < 11)
                    {
                        P1board[P2SchiffeC[1][0] + 1, P2SchiffeC[1][1] + 1] = 24;
                        P1boardHidden[P2SchiffeC[1][0] + 1, P2SchiffeC[1][1] + 1] = 24;
                    }
                    if (P2SchiffeC[1][1] - 1 > 0)
                    {
                        P1board[P2SchiffeC[1][0] + 1, P2SchiffeC[1][1] - 1] = 24;
                        P1boardHidden[P2SchiffeC[1][0] + 1, P2SchiffeC[1][1] - 1] = 24;
                    }
                }
            }
            if (P2Schiffe[2][0] == null && P2Schiffe[2][1] == null && P2Schiffe[11][2] == 0)
            {
                P2Schiffe[10][0]--;
                P2Schiffe[11][2]++;
                if (P2SchiffeC[2][0] - 1 > 0)
                {
                    P1board[P2SchiffeC[2][0] - 1, P2SchiffeC[2][1]] = 24;
                    P1boardHidden[P2SchiffeC[2][0] - 1, P2SchiffeC[2][1]] = 24;
                    if (P2SchiffeC[2][1] + 1 < 11)
                    {
                        P1board[P2SchiffeC[2][0] - 1, P2SchiffeC[2][1] + 1] = 24;
                        P1boardHidden[P2SchiffeC[2][0] - 1, P2SchiffeC[2][1] + 1] = 24;
                    }
                    if (P2SchiffeC[2][1] - 1 > 0)
                    {
                        P1board[P2SchiffeC[2][0] - 1, P2SchiffeC[2][1] - 1] = 24;
                        P1boardHidden[P2SchiffeC[2][0] - 1, P2SchiffeC[2][1] - 1] = 24;
                    }
                }
                if (P2SchiffeC[2][1] + 1 < 11)
                {
                    P1board[P2SchiffeC[2][0], P2SchiffeC[2][1] + 1] = 24;
                    P1boardHidden[P2SchiffeC[2][0], P2SchiffeC[2][1] + 1] = 24;
                }
                if (P2SchiffeC[2][1] - 1 > 0)
                {
                    P1board[P2SchiffeC[2][0], P2SchiffeC[2][1] - 1] = 24;
                    P1boardHidden[P2SchiffeC[2][0], P2SchiffeC[2][1] - 1] = 24;
                }
                if (P2SchiffeC[2][0] + 1 < 11)
                {
                    P1board[P2SchiffeC[2][0] + 1, P2SchiffeC[2][1]] = 24;
                    P1boardHidden[P2SchiffeC[2][0] + 1, P2SchiffeC[2][1]] = 24;
                    if (P2SchiffeC[2][1] + 1 < 11)
                    {
                        P1board[P2SchiffeC[2][0] + 1, P2SchiffeC[2][1] + 1] = 24;
                        P1boardHidden[P2SchiffeC[2][0] + 1, P2SchiffeC[2][1] + 1] = 24;
                    }
                    if (P2SchiffeC[2][1] - 1 > 0)
                    {
                        P1board[P2SchiffeC[2][0] + 1, P2SchiffeC[2][1] - 1] = 24;
                        P1boardHidden[P2SchiffeC[2][0] + 1, P2SchiffeC[2][1] - 1] = 24;
                    }
                }
            }
            if (P2Schiffe[3][0] == null && P2Schiffe[3][1] == null && P2Schiffe[11][3] == 0)
            {
                P2Schiffe[10][0]--;
                P2Schiffe[11][3]++;
                if (P2SchiffeC[3][0] - 1 > 0)
                {
                    P1board[P2SchiffeC[3][0] - 1, P2SchiffeC[3][1]] = 24;
                    P1boardHidden[P2SchiffeC[3][0] - 1, P2SchiffeC[3][1]] = 24;
                    if (P2SchiffeC[3][1] + 1 < 11)
                    {
                        P1board[P2SchiffeC[3][0] - 1, P2SchiffeC[3][1] + 1] = 24;
                        P1boardHidden[P2SchiffeC[3][0] - 1, P2SchiffeC[3][1] + 1] = 24;
                    }
                    if (P2SchiffeC[3][1] - 1 > 0)
                    {
                        P1board[P2SchiffeC[3][0] - 1, P2SchiffeC[3][1] - 1] = 24;
                        P1boardHidden[P2SchiffeC[3][0] - 1, P2SchiffeC[3][1] - 1] = 24;
                    }
                }
                if (P2SchiffeC[3][1] + 1 < 11)
                {
                    P1board[P2SchiffeC[3][0], P2SchiffeC[3][1] + 1] = 24;
                    P1boardHidden[P2SchiffeC[3][0], P2SchiffeC[3][1] + 1] = 24;
                }
                if (P2SchiffeC[3][1] - 1 > 0)
                {
                    P1board[P2SchiffeC[3][0], P2SchiffeC[3][1] - 1] = 24;
                    P1boardHidden[P2SchiffeC[3][0], P2SchiffeC[3][1] - 1] = 24;
                }
                if (P2SchiffeC[3][0] + 1 < 11)
                {
                    P1board[P2SchiffeC[3][0] + 1, P2SchiffeC[3][1]] = 24;
                    P1boardHidden[P2SchiffeC[3][0] + 1, P2SchiffeC[3][1]] = 24;
                    if (P2SchiffeC[3][1] + 1 < 11)
                    {
                        P1board[P2SchiffeC[3][0] + 1, P2SchiffeC[3][1] + 1] = 24;
                        P1boardHidden[P2SchiffeC[3][0] + 1, P2SchiffeC[3][1] + 1] = 24;
                    }
                    if (P2SchiffeC[3][1] - 1 > 0)
                    {
                        P1board[P2SchiffeC[3][0] + 1, P2SchiffeC[3][1] - 1] = 24;
                        P1boardHidden[P2SchiffeC[3][0] + 1, P2SchiffeC[3][1] - 1] = 24;
                    }
                }
            }
            if (P2Schiffe[4][0] == null && P2Schiffe[4][1] == null && P2Schiffe[4][2] == null && P2Schiffe[4][3] == null && P2Schiffe[11][4] == 0)
            {
                P2Schiffe[10][1]--;
                P2Schiffe[11][4]++;
            }
            if (P2Schiffe[5][0] == null && P2Schiffe[5][1] == null && P2Schiffe[5][2] == null && P2Schiffe[5][3] == null && P2Schiffe[11][5] == 0)
            {
                P2Schiffe[10][1]--;
                P2Schiffe[11][5]++;
            }
            if (P2Schiffe[6][0] == null && P2Schiffe[6][1] == null && P2Schiffe[6][2] == null && P2Schiffe[6][3] == null && P2Schiffe[11][6] == 0)
            {
                P2Schiffe[10][1]--;
                P2Schiffe[11][6]++;
            }
            if (P2Schiffe[7][0] == null && P2Schiffe[7][1] == null && P2Schiffe[7][2] == null && P2Schiffe[7][3] == null && P2Schiffe[7][4] == null && P2Schiffe[7][5] == null && P2Schiffe[11][7] == 0)
            {
                P2Schiffe[10][2]--;
                P2Schiffe[11][7]++;
            }
            if (P2Schiffe[8][0] == null && P2Schiffe[8][1] == null && P2Schiffe[8][2] == null && P2Schiffe[8][3] == null && P2Schiffe[8][4] == null && P2Schiffe[8][5] == null && P2Schiffe[11][8] == 0)
            {
                P2Schiffe[10][2]--;
                P2Schiffe[11][8]++;
            }
            if (P2Schiffe[9][0] == null && P2Schiffe[9][1] == null && P2Schiffe[9][2] == null && P2Schiffe[9][3] == null && P2Schiffe[9][5] == null && P2Schiffe[9][5] == null && P2Schiffe[9][6] == null && P2Schiffe[9][7] == null && P2Schiffe[11][9] == 0)
            {
                P2Schiffe[10][3]--;
                P2Schiffe[11][8]++;
            }
        }
        void checkSP1()
        {
            if (P1Schiffe[0][0] == null && P1Schiffe[0][1] == null && P1Schiffe[11][0] == 0)
            {
                P1Schiffe[10][0]--;
                P1Schiffe[11][0]++;
                if (P1SchiffeC[0][0] - 1 > 0)
                {
                    P1board[P1SchiffeC[0][0] - 1, P1SchiffeC[0][1]] = 24;
                    P1boardHidden[P1SchiffeC[0][0] - 1, P1SchiffeC[0][1]] = 24;
                    if (P1SchiffeC[0][1] + 1 < 11)
                    {
                        P1board[P1SchiffeC[0][0] - 1, P1SchiffeC[0][1] + 1] = 24;
                        P1boardHidden[P1SchiffeC[0][0] - 1, P1SchiffeC[0][1] + 1] = 24;
                    }
                    if (P1SchiffeC[0][1] - 1 > 0)
                    {
                        P1board[P1SchiffeC[0][0] - 1, P1SchiffeC[0][1] - 1] = 24;
                        P1boardHidden[P1SchiffeC[0][0] - 1, P1SchiffeC[0][1] - 1] = 24;
                    }
                }
                if (P1SchiffeC[0][1] + 1 < 11)
                {
                    P1board[P1SchiffeC[0][0], P1SchiffeC[0][1] + 1] = 24;
                    P1boardHidden[P1SchiffeC[0][0], P1SchiffeC[0][1] + 1] = 24;
                }
                if (P1SchiffeC[0][1] - 1 > 0)
                {
                    P1board[P1SchiffeC[0][0], P1SchiffeC[0][1] - 1] = 24;
                    P1boardHidden[P1SchiffeC[0][0], P1SchiffeC[0][1] - 1] = 24;
                }
                if (P1SchiffeC[0][0] + 1 < 11)
                {
                    P1board[P1SchiffeC[0][0] + 1, P1SchiffeC[0][1]] = 24;
                    P1boardHidden[P1SchiffeC[0][0] + 1, P1SchiffeC[0][1]] = 24;
                    if (P1SchiffeC[0][1] + 1 < 11)
                    {
                        P1board[P1SchiffeC[0][0] + 1, P1SchiffeC[0][1] + 1] = 24;
                        P1boardHidden[P1SchiffeC[0][0] + 1, P1SchiffeC[0][1] + 1] = 24;
                    }
                    if (P1SchiffeC[0][1] - 1 > 0)
                    {
                        P1board[P1SchiffeC[0][0] + 1, P1SchiffeC[0][1] - 1] = 24;
                        P1boardHidden[P1SchiffeC[0][0] + 1, P1SchiffeC[0][1] - 1] = 24;
                    }
                }
            }
            if (P1Schiffe[1][0] == null && P1Schiffe[1][1] == null && P1Schiffe[11][1] == 0)
            {
                P1Schiffe[10][0]--;
                P1Schiffe[11][1]++;
                if (P1SchiffeC[1][0] - 1 > 0)
                {
                    P1board[P1SchiffeC[1][0] - 1, P1SchiffeC[1][1]] = 24;
                    P1boardHidden[P1SchiffeC[1][0] - 1, P1SchiffeC[1][1]] = 24;
                    if (P1SchiffeC[1][1] + 1 < 11)
                    {
                        P1board[P1SchiffeC[1][0] - 1, P1SchiffeC[1][1] + 1] = 24;
                        P1boardHidden[P1SchiffeC[1][0] - 1, P1SchiffeC[1][1] + 1] = 24;
                    }
                    if (P1SchiffeC[1][1] - 1 > 0)
                    {
                        P1board[P1SchiffeC[1][0] - 1, P1SchiffeC[1][1] - 1] = 24;
                        P1boardHidden[P1SchiffeC[1][0] - 1, P1SchiffeC[1][1] - 1] = 24;
                    }
                }
                if (P1SchiffeC[1][1] + 1 < 11)
                {
                    P1board[P1SchiffeC[1][0], P1SchiffeC[1][1] + 1] = 24;
                    P1boardHidden[P1SchiffeC[1][0], P1SchiffeC[1][1] + 1] = 24;
                }
                if (P1SchiffeC[1][1] - 1 > 0)
                {
                    P1board[P1SchiffeC[1][0], P1SchiffeC[1][1] - 1] = 24;
                    P1boardHidden[P1SchiffeC[1][0], P1SchiffeC[1][1] - 1] = 24;
                }
                if (P1SchiffeC[1][0] + 1 < 11)
                {
                    P1board[P1SchiffeC[1][0] + 1, P1SchiffeC[1][1]] = 24;
                    P1boardHidden[P1SchiffeC[1][0] + 1, P1SchiffeC[1][1]] = 24;
                    if (P1SchiffeC[1][1] + 1 < 11)
                    {
                        P1board[P1SchiffeC[1][0] + 1, P1SchiffeC[1][1] + 1] = 24;
                        P1boardHidden[P1SchiffeC[1][0] + 1, P1SchiffeC[1][1] + 1] = 24;
                    }
                    if (P1SchiffeC[1][1] - 1 > 0)
                    {
                        P1board[P1SchiffeC[1][0] + 1, P1SchiffeC[1][1] - 1] = 24;
                        P1boardHidden[P1SchiffeC[1][0] + 1, P1SchiffeC[1][1] - 1] = 24;
                    }
                }
            }
            if (P1Schiffe[2][0] == null && P1Schiffe[2][1] == null && P1Schiffe[11][2] == 0)
            {
                P1Schiffe[10][0]--;
                P1Schiffe[11][2]++;
                if (P1SchiffeC[2][0] - 1 > 0)
                {
                    P1board[P1SchiffeC[2][0] - 1, P1SchiffeC[2][1]] = 24;
                    P1boardHidden[P1SchiffeC[2][0] - 1, P1SchiffeC[2][1]] = 24;
                    if (P1SchiffeC[2][1] + 1 < 11)
                    {
                        P1board[P1SchiffeC[2][0] - 1, P1SchiffeC[2][1] + 1] = 24;
                        P1boardHidden[P1SchiffeC[2][0] - 1, P1SchiffeC[2][1] + 1] = 24;
                    }
                    if (P1SchiffeC[2][1] - 1 > 0)
                    {
                        P1board[P1SchiffeC[2][0] - 1, P1SchiffeC[2][1] - 1] = 24;
                        P1boardHidden[P1SchiffeC[2][0] - 1, P1SchiffeC[2][1] - 1] = 24;
                    }
                }
                if (P1SchiffeC[2][1] + 1 < 11)
                {
                    P1board[P1SchiffeC[2][0], P1SchiffeC[2][1] + 1] = 24;
                    P1boardHidden[P1SchiffeC[2][0], P1SchiffeC[2][1] + 1] = 24;
                }
                if (P1SchiffeC[2][1] - 1 > 0)
                {
                    P1board[P1SchiffeC[2][0], P1SchiffeC[2][1] - 1] = 24;
                    P1boardHidden[P1SchiffeC[2][0], P1SchiffeC[2][1] - 1] = 24;
                }
                if (P1SchiffeC[2][0] + 1 < 11)
                {
                    P1board[P1SchiffeC[2][0] + 1, P1SchiffeC[2][1]] = 24;
                    P1boardHidden[P1SchiffeC[2][0] + 1, P1SchiffeC[2][1]] = 24;
                    if (P1SchiffeC[2][1] + 1 < 11)
                    {
                        P1board[P1SchiffeC[2][0] + 1, P1SchiffeC[2][1] + 1] = 24;
                        P1boardHidden[P1SchiffeC[2][0] + 1, P1SchiffeC[2][1] + 1] = 24;
                    }
                    if (P1SchiffeC[2][1] - 1 > 0)
                    {
                        P1board[P1SchiffeC[2][0] + 1, P1SchiffeC[2][1] - 1] = 24;
                        P1boardHidden[P1SchiffeC[2][0] + 1, P1SchiffeC[2][1] - 1] = 24;
                    }
                }
            }
            if (P1Schiffe[3][0] == null && P1Schiffe[3][1] == null && P1Schiffe[11][3] == 0)
            {
                P1Schiffe[10][0]--;
                P1Schiffe[11][3]++;
                if (P1SchiffeC[3][0] - 1 > 0)
                {
                    P1board[P1SchiffeC[3][0] - 1, P1SchiffeC[3][1]] = 24;
                    P1boardHidden[P1SchiffeC[3][0] - 1, P1SchiffeC[3][1]] = 24;
                    if (P1SchiffeC[3][1] + 1 < 11)
                    {
                        P1board[P1SchiffeC[3][0] - 1, P1SchiffeC[3][1] + 1] = 24;
                        P1boardHidden[P1SchiffeC[3][0] - 1, P1SchiffeC[3][1] + 1] = 24;
                    }
                    if (P1SchiffeC[3][1] - 1 > 0)
                    {
                        P1board[P1SchiffeC[3][0] - 1, P1SchiffeC[3][1] - 1] = 24;
                        P1boardHidden[P1SchiffeC[3][0] - 1, P1SchiffeC[3][1] - 1] = 24;
                    }
                }
                if (P1SchiffeC[3][1] + 1 < 11)
                {
                    P1board[P1SchiffeC[3][0], P1SchiffeC[3][1] + 1] = 24;
                    P1boardHidden[P1SchiffeC[3][0], P1SchiffeC[3][1] + 1] = 24;
                }
                if (P1SchiffeC[3][1] - 1 > 0)
                {
                    P1board[P1SchiffeC[3][0], P1SchiffeC[3][1] - 1] = 24;
                    P1boardHidden[P1SchiffeC[3][0], P1SchiffeC[3][1] - 1] = 24;
                }
                if (P1SchiffeC[3][0] + 1 < 11)
                {
                    P1board[P1SchiffeC[3][0] + 1, P1SchiffeC[3][1]] = 24;
                    P1boardHidden[P1SchiffeC[3][0] + 1, P1SchiffeC[3][1]] = 24;
                    if (P1SchiffeC[3][1] + 1 < 11)
                    {
                        P1board[P1SchiffeC[3][0] + 1, P1SchiffeC[3][1] + 1] = 24;
                        P1boardHidden[P1SchiffeC[3][0] + 1, P1SchiffeC[3][1] + 1] = 24;
                    }
                    if (P1SchiffeC[3][1] - 1 > 0)
                    {
                        P1board[P1SchiffeC[3][0] + 1, P1SchiffeC[3][1] - 1] = 24;
                        P1boardHidden[P1SchiffeC[3][0] + 1, P1SchiffeC[3][1] - 1] = 24;
                    }
                }
            }
            if (P1Schiffe[4][0] == null && P1Schiffe[4][1] == null && P1Schiffe[4][2] == null && P1Schiffe[4][3] == null && P1Schiffe[11][4] == 0)
            {
                P1Schiffe[10][1]--;
                P1Schiffe[11][4]++;
            }
            if (P1Schiffe[5][0] == null && P1Schiffe[5][1] == null && P1Schiffe[5][2] == null && P1Schiffe[5][3] == null && P1Schiffe[11][5] == 0)
            {
                P1Schiffe[10][1]--;
                P1Schiffe[11][5]++;
            }
            if (P1Schiffe[6][0] == null && P1Schiffe[6][1] == null && P1Schiffe[6][2] == null && P1Schiffe[6][3] == null && P1Schiffe[11][6] == 0)
            {
                P1Schiffe[10][1]--;
                P1Schiffe[11][6]++;
            }
            if (P1Schiffe[7][0] == null && P1Schiffe[7][1] == null && P1Schiffe[7][2] == null && P1Schiffe[7][3] == null && P1Schiffe[7][4] == null && P1Schiffe[7][5] == null && P1Schiffe[11][7] == 0)
            {
                P1Schiffe[10][2]--;
                P1Schiffe[11][7]++;
            }
            if (P1Schiffe[8][0] == null && P1Schiffe[8][1] == null && P1Schiffe[8][2] == null && P1Schiffe[8][3] == null && P1Schiffe[8][4] == null && P1Schiffe[8][5] == null && P1Schiffe[11][8] == 0)
            {
                P1Schiffe[10][2]--;
                P1Schiffe[11][8]++;
            }
            if (P1Schiffe[9][0] == null && P1Schiffe[9][1] == null && P1Schiffe[9][2] == null && P1Schiffe[9][3] == null && P1Schiffe[9][5] == null && P1Schiffe[9][5] == null && P1Schiffe[9][6] == null && P1Schiffe[9][7] == null && P1Schiffe[11][9] == 0)
            {
                P1Schiffe[10][3]--;
                P1Schiffe[11][8]++;
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
                    Console.WriteLine(d.text(31, lang));
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
                    Console.WriteLine(d.text(32, lang));
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
        public void PlaceP2(int l, int r)
        {
            bool input = true;
            int temp = 0;
            int[] position = get();
            position = check(position, l, sub[2]);
            position = P2checkO(position, l, sub[2]);
            while (input)
            {
                switch (sub[2])                                         //Anhand der Länge und Orientierung wird das Schiff plaziert
                {
                    case "up":                                          //Um das Schiff nach "oben" zu platzieren wird die y-Koordinate um 1 subtrahiert.
                        if (position[0] + 1 < 11)
                        {
                            P2board[position[0] + 1, position[1]] = 25;
                            if (position[1] - 1 > 0) P2board[position[0] + 1, position[1] - 1] = 25;
                            if (position[1] + 1 < 11) P2board[position[0] + 1, position[1] + 1] = 25;
                        }
                        for (int i = 0; i < l; i++)
                        {
                            P2board[position[0] - i, position[1]] = 1;
                            if (position[1] - 1 > 0) P2board[position[0] - i, position[1] - 1] = 25;
                            if (position[1] + 1 < 11) P2board[position[0] - i, position[1] + 1] = 25;
                            P2Schiffe[r][temp] = position[0] - i;
                            P2Schiffe[r][temp + 1] = position[1];
                            temp = temp + 2;
                        }
                        if (position[0] - l > 0)
                        {
                            P2board[position[0] - l, position[1]] = 25;
                            if (position[1] - 1 > 0) P2board[position[0] - l, position[1] - 1] = 25;
                            if (position[1] + 1 < 11) P2board[position[0] - l, position[1] + 1] = 25;
                        }
                        P2Schiffe[10][l - 1]++;
                        P2Schiffe[12][r] = 0;
                        input = false;
                        break;
                    case "down":                                        //Um das Schiff nach "unten" zu platzieren wird die y-Koordinate um 1 addiert
                        if (position[0] - 1 > 0)
                        {
                            P2board[position[0] - 1, position[1]] = 25;
                            if (position[1] - 1 > 0) P2board[position[0] - 1, position[1] - 1] = 25;
                            if (position[1] + 1 < 11) P2board[position[0] - 1, position[1] + 1] = 25;
                        }
                        for (int i = 0; i < l; i++)
                        {
                            P2board[position[0] + i, position[1]] = 1;
                            if (position[1] - 1 > 0) P2board[position[0] + i, position[1] - 1] = 25;
                            if (position[1] + 1 < 11) P2board[position[0] + i, position[1] + 1] = 25;
                            P2Schiffe[r][temp] = position[0] + i;
                            P2Schiffe[r][temp + 1] = position[1];
                            temp = temp + 2;
                        }
                        if (position[0] + l < 11)
                        {
                            P2board[position[0] + l, position[1]] = 25;
                            if (position[1] - 1 > 0) P2board[position[0] + l, position[1] - 1] = 25;
                            if (position[1] + 1 < 11) P2board[position[0] + l, position[1] + 1] = 25;
                        }
                        P2Schiffe[10][l - 1]++;
                        P2Schiffe[12][r] = 1;
                        input = false;
                        break;
                    case "left":                                        //Um das Schiff nach "links" zu platzieren wird die x-Koordinate um 1 subtrahiert
                        if (position[1] + 1 < 11)
                        {
                            P2board[position[0], position[1] + 1] = 25;
                            if (position[0] - 1 > 0) P2board[position[0] - 1, position[1] + 1] = 25;
                            if (position[0] + 1 < 11) P2board[position[0] + 1, position[1] + 1] = 25;
                        }
                        for (int i = 0; i < l; i++)
                        {
                            P2board[position[0], position[1] - i] = 1;
                            if (position[0] - 1 > 0) P2board[position[0] - 1, position[1] - i] = 25;
                            if (position[0] + 1 < 11) P2board[position[0] + 1, position[0] - i] = 25;
                            P2Schiffe[r][temp] = position[0];
                            P2Schiffe[r][temp + 1] = position[1] - i;
                            temp = temp + 2;
                        }
                        if (position[1] - l > 0)
                        {
                            P2board[position[0], position[1] - l] = 25;
                            if (position[0] - 1 > 0) P2board[position[0] - 1, position[1] - l] = 25;
                            if (position[0] + 1 < 11) P2board[position[0] + 1, position[1] - l] = 25;
                        }
                        P2Schiffe[10][l - 1]++;
                        P2Schiffe[12][r] = 2;
                        input = false;
                        break;
                    case "right":                                       //Um das Schiff nach "rechts" zu platzieren wird die x-Koordinate um 1 addiert
                        if (position[1] - 1 > 0)
                        {
                            P2board[position[0], position[1] - 1] = 25;
                            if (position[0] - 1 > 0) P2board[position[0] - 1, position[1] - 1] = 25;
                            if (position[0] + 1 < 11) P2board[position[0] + 1, position[1] - 1] = 25;
                        }
                        for (int i = 0; i < l; i++)
                        {
                            P2board[position[0], position[1] + i] = 1;
                            if (position[0] - 1 > 0) P2board[position[0] - 1, position[1] + i] = 25;
                            if (position[0] + 1 < 11) P2board[position[0] + 1, position[1] + i] = 25;
                            P2Schiffe[r][temp] = position[0];
                            P2Schiffe[r][temp + 1] = position[1] + i;
                            temp = temp + 2;
                        }
                        if (position[1] + l < 11)
                        {
                            P2board[position[0], position[1] + l] = 25;
                            if (position[0] - 1 > 0) P2board[position[0] - 1, position[1] + l] = 25;
                            if (position[0] + 1 < 11) P2board[position[0] + 1, position[1] + l] = 25;
                        }
                        P2Schiffe[10][l - 1]++;
                        P2Schiffe[12][r] = 3;
                        input = false;
                        break;
                    default:                                            //Falls keine Richtung angegeben wurde oder eine nicht existierende Richtung angegeben wurde, wird eine neue Richtung abgefragt und noch mal gecheckt
                        Console.WriteLine(d.text(27, lang));
                        sub[2] = Console.ReadLine();
                        position = check(position, l, sub[2]);
                        position = P2checkO(position, l, sub[2]);
                        break;
                }
            }
            for (int i = 0; i < P2SchiffeC[r].Length; i++)
            {
                P2SchiffeC[r][i] = (int)P2Schiffe[r][i];
            }        }

        int[] P2checkO(int[] p, int l, string di)
        {
            for (int i = 0; i < l; i++)                     //Loopt durch jeden Punkt, der erstellt werden würde, um zu gucken, ob da schon einer ist
            {
                switch (di)                                  //Basierend auf der Orientierung wird in eine andere Richtung geguckt
                {
                    case "up":
                        if (P2board[p[0] - i, p[1]] == 1 || P2board[p[0] - i, p[1]] == 25)   //Die Koordinate wird um die Loopanzahl versetzt und geguck, ob die ID dort einem anderem Schiff entspricht
                        {
                            Console.WriteLine(d.text(29, lang));
                            p = get();                      //Wenn dies der Fall ist, wird ein neuer Punkt angefragt
                            p = check(p, l, sub[2]);        //Dieser auf Out of Bounds geprüft
                            p = P2checkO(p, l, sub[2]);     //und rekursiv in dieser Funktion geprüft, bis die Koordinaten passen
                        }
                        break;
                    case "down":
                        if (P2board[p[0] + i, p[1]] == 1 || P2board[p[0] + i, p[1]] == 25)
                        {
                            Console.WriteLine(d.text(29, lang));
                            p = get();
                            p = check(p, l, sub[2]);
                            p = P2checkO(p, l, sub[2]);
                        }
                        break;
                    case "left":
                        if (P2board[p[0], p[1] - i] == 1 || P2board[p[0], p[1] - i] == 25)
                        {
                            Console.WriteLine(d.text(29, lang));
                            p = get();
                            p = check(p, l, sub[2]);
                            p = P2checkO(p, l, sub[2]);
                        }
                        break;
                    case "right":
                        if (P2board[p[0], p[1] + i] == 1 || P2board[p[0], p[1] + i] == 25)
                        {
                            Console.WriteLine(d.text(29, lang));
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
            bool found = false;
            int[] target = Shootget();                      //Die Position, wohin der Spieler schießen möchte wird abgegriffen
            while (P1boardHidden[target[0], target[1]] == 1 || P1boardHidden[target[0], target[1]] == 24)       //Es wird auf dem Board des Spielers 2, welches Spieler 1 sieht gecheckt, ob die Koordinate entweder die ID für einen Treffer oder ein Miss beinhaltet
            {
                Console.WriteLine(d.text(30, lang));
                target = Shootget();                        //Sollte dies der Fall sein, wird eine neue Koordinate abgefragt
            }
            if (P1board[target[0], target[1]] == 1)         //Sobald der Punkt an einer Stelle ist, welche valide ist, wird gechekt, ob ein Schiff an der Stelle ist
            {
                P1boardHidden[target[0], target[1]] = 1;    //Wenn ja, dann wird beim Board des Gegners das Schiff als zerstört geändert und bei dem eigenen wird ein Schiff angezeigt
                P1board[target[0], target[1]] = 2;
                while (found == false)
                {
                    for (int i = 0; i < P1Schiffe.Length - 3; i++)
                    {
                        for (int o = 0; o < P1Schiffe[i].Length; o = o + 2)
                        {
                            if (P1Schiffe[i][o] == target[0] && P1Schiffe[i][o + 1] == target[1])
                            {
                                found = true;
                                P1Schiffe[i][o] = null;
                                P1Schiffe[i][o + 1] = null;
                                break;
                            }
                        }
                        if (found) break;
                    }
                }
            }
            else                                            //Ansonsten wird bei beiden Boards ein Miss markiert
            {
                P1boardHidden[target[0], target[1]] = 24;
                P1board[target[0], target[1]] = 24;
            }
            checkSP1();
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
        public void PlaceP2AI(int l, int[] positions, int r)
        {
            int temp = 0;
            switch (positions[2])
            {
                case 0:
                    for (int i = 0; i < l; i++)
                    {
                        P2board[positions[0] - i, positions[1]] = 1;
                        P2Schiffe[r][temp] = positions[0] - i;
                        P2Schiffe[r][temp + 1] = positions[1];
                        temp = temp + 2;
                    }
                    P2Schiffe[12][r] = 0;
                    break;
                case 1:
                    for (int i = 0; i < l; i++)
                    {
                        P2board[positions[0] + i, positions[1]] = 1;
                        P2Schiffe[r][temp] = positions[0] + i;
                        P2Schiffe[r][temp + 1] = positions[1];
                        temp = temp + 2;
                    }
                    P2Schiffe[12][r] = 1;
                    break;
                case 2:
                    for (int i = 0; i < l; i++)
                    {
                        P2board[positions[0], positions[1] - i] = 1;
                        P2Schiffe[r][temp] = positions[0];
                        P2Schiffe[r][temp + 1] = positions[1] - i;
                        temp = temp + 2;
                    }
                    P2Schiffe[12][r] = 2;
                    break;
                case 3:
                    for (int i = 0; i < l; i++)
                    {
                        P2board[positions[0], positions[1] + i] = 1;
                        P2Schiffe[r][temp] = positions[0];
                        P2Schiffe[r][temp + 1] = positions[1] + i;
                        temp = temp + 2;
                    }
                    P2Schiffe[12][r] = 3;
                    break;
            }
            P2Schiffe[10][l - 1]++;
            for (int i = 0; i < P2SchiffeC[r].Length; i++)
            {
                P2SchiffeC[r][i] = (int)P2Schiffe[r][i];
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
            checkSP1();
        }

        public void setP2Board(int[,] i)
        {
            P2board = i;
        }
    }
}