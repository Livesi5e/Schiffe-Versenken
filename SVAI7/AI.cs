using SVgerman;
using System;
using System.Collections.Generic;

namespace SVAI7
{
    public class AIEasy
    {
        int[,] board = {                                //Board für die AI. An sich das, was Spieler 2 auch sieht
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
        int[] pos = new int[4];                         //Array was die Positionen der Schiffe der AI speichert
        Random rnd = new Random();                      //Initialisierung des Random Zahlengenerator

        //Generiert die Positionen der Schiffe. Benötigt ein Board (b)
        public void Place(Board b)
        {
            pos[0] = rnd.Next(10) + 1;              //Generiert eine zufällige x-Koordinate
            pos[1] = rnd.Next(10) + 1;              //Generiert eine zufällige y-Koordinate
            pos[2] = rnd.Next(4);                   //Generiert eine zufällige Orientierung
            check(1);                               //Checkt ob die Position in Bounds ist und übergibt die Positionen im Array und die Länge des Schiffes
            setC(1);                                //Übergibt die Länge des Schiffs
            b.PlaceP2AI(1, pos, 0);                    //Platziert das Schiff auf dem "richtigen" Board
            //b.setP2Board(board);
            //b.Player2out();
            //Console.ReadLine();
            pos[0] = rnd.Next(10) + 1;              //Generiert die Zahlen für das nächste Schiff
            pos[1] = rnd.Next(10) + 1;
            pos[2] = rnd.Next(4);
            check(1);
            checkO(1);
            setC(1);
            b.PlaceP2AI(1, pos, 1);
            //b.setP2Board(board);
            //b.Player2out();
            //Console.ReadLine();
            pos[0] = rnd.Next(10) + 1;
            pos[1] = rnd.Next(10) + 1;
            pos[2] = rnd.Next(4);
            check(1);
            checkO(1);
            setC(1);
            b.PlaceP2AI(1, pos, 2);
            //b.setP2Board(board);
            //b.Player2out();
            //Console.ReadLine();
            pos[0] = rnd.Next(10) + 1;
            pos[1] = rnd.Next(10) + 1;
            pos[2] = rnd.Next(4);
            check(1);
            checkO(1);
            setC(1);
            b.PlaceP2AI(1, pos, 3);
            //b.setP2Board(board);
            //b.Player2out();
            //Console.ReadLine();
            pos[0] = rnd.Next(10) + 1;
            pos[1] = rnd.Next(10) + 1;
            pos[2] = rnd.Next(4);
            check(2);
            checkO(2);
            setC(2);
            b.PlaceP2AI(2, pos, 4);
            //b.setP2Board(board);
            //b.Player2out();
            //Console.ReadLine();
            pos[0] = rnd.Next(10) + 1;
            pos[1] = rnd.Next(10) + 1;
            pos[2] = rnd.Next(4);
            check(2);
            checkO(2);
            setC(2);
            b.PlaceP2AI(2, pos, 5);
            //b.setP2Board(board);
            //b.Player2out();
            //Console.ReadLine();
            pos[0] = rnd.Next(10) + 1;
            pos[1] = rnd.Next(10) + 1;
            pos[2] = rnd.Next(4);
            check(2);
            checkO(2);
            setC(2);
            b.PlaceP2AI(2, pos, 6);
            //b.setP2Board(board);
            //b.Player2out();
            //Console.ReadLine();
            pos[0] = rnd.Next(10) + 1;
            pos[1] = rnd.Next(10) + 1;
            pos[2] = rnd.Next(4);
            check(3);
            checkO(3);
            setC(3);
            b.PlaceP2AI(3, pos, 7);
            //b.setP2Board(board);
            //b.Player2out();
            //Console.ReadLine();
            pos[0] = rnd.Next(10) + 1;
            pos[1] = rnd.Next(10) + 1;
            pos[2] = rnd.Next(4);
            check(3);
            checkO(3);
            setC(3);
            b.PlaceP2AI(3, pos, 8);
            //b.setP2Board(board);
            //b.Player2out();
            //Console.ReadLine();
            pos[0] = rnd.Next(10) + 1;
            pos[1] = rnd.Next(10) + 1;
            pos[2] = rnd.Next(4);
            check(4);
            checkO(4);
            setC(4);
            b.PlaceP2AI(4, pos, 9);
            //b.setP2Board(board);
        }

        //Checkt ob das Schiff Out of Bounds ist. Benötigt die Positionen im Array (r) und die Länge des Schiffs (l)
        void check(int l)
        {
            switch (pos[2])
            {
                case 0:
                    if (pos[0] - l < 0)
                    {
                        pos[0] = rnd.Next(10) + 1;
                        pos[1] = rnd.Next(10) + 1;
                        pos[2] = rnd.Next(4);
                        check(l);
                    }
                    break;
                case 1:
                    if (pos[0] + l > 11)
                    {
                        pos[0] = rnd.Next(10) + 1;
                        pos[1] = rnd.Next(10) + 1;
                        pos[2] = rnd.Next(4);
                        check(l);
                    }
                    break;
                case 2:
                    if (pos[1] - l < 0)
                    {
                        pos[0] = rnd.Next(10) + 1;
                        pos[1] = rnd.Next(10) + 1;
                        pos[2] = rnd.Next(4);
                        check(l);
                    }
                    break;
                case 3:
                    if (pos[1] + l > 11)
                    {
                        pos[0] = rnd.Next(10) + 1;
                        pos[1] = rnd.Next(10) + 1;
                        pos[2] = rnd.Next(4);
                        check(l);
                    }
                    break;
            }
        }

        //Platziert das Schiff im eigenen Board. Benötigt die Länge des Schiffs (l) und die Positionen im Array (r)
        void setC(int l)
        {
            switch(pos[2])
            {
                case 0:                                          //Um das Schiff nach "oben" zu platzieren wird die y-Koordinate um 1 subtrahiert.
                    if (pos[0] + 1 < 11)
                    {
                        board[pos[0] + 1, pos[1]] = 25;
                        if (pos[1] + 1 < 11) board[pos[0] + 1, pos[1] + 1] = 25;
                        if (pos[1] - 1 > 0) board[pos[0] + 1, pos[1] - 1] = 25;
                    }
                    for (int i = 0; i < l; i++)
                    {
                        board[pos[0] - i, pos[1]] = 1;
                        if (pos[1] + 1 < 11) board[pos[0] - i, pos[1] + 1] = 25;
                        if (pos[1] - 1 > 0) board[pos[0] - i, pos[1] - 1] = 25;
                    }
                    if (pos[0] - l > 0)
                    {
                        board[pos[0] - l, pos[1]] = 25;
                        if (pos[1] - 1 > 0) board[pos[0] - l, pos[1] - 1] = 25;
                        if (pos[1] + 1 < 11) board[pos[0] - l, pos[1] + 1] = 25;
                    }
                    break;
                case 1:                                        //Um das Schiff nach "unten" zu platzieren wird die y-Koordinate um 1 addiert
                    if (pos[0] - 1 > 0)
                    {
                        board[pos[0] - 1, pos[1]] = 25;
                        if (pos[1] - 1 > 0) board[pos[0] - 1, pos[1] - 1] = 25;
                        if (pos[1] + 1 < 11) board[pos[0] - 1, pos[1] + 1] = 25;
                    }
                    for (int i = 0; i < l; i++)
                    {
                        board[pos[0] + i, pos[1]] = 1;
                        if (pos[1] + 1 < 11) board[pos[0] + i, pos[1] + 1] = 25;
                        if (pos[1] - 1 > 0) board[pos[0] + i, pos[1] - 1] = 25;
                    }
                    if (pos[0] + l < 11)
                    {
                        board[pos[0] + l, pos[1]] = 25;
                        if (pos[1] - 1 > 0) board[pos[0] + l, pos[1] - 1] = 25;
                        if (pos[1] + 1 < 11) board[pos[0] + l, pos[1] + 1] = 25;
                    }
                    break;
                case 2:                                        //Um das Schiff nach "links" zu platzieren wird die x-Koordinate um 1 subtrahiert
                    if (pos[1] + 1 < 11)
                    {
                        board[pos[0], pos[1] + 1] = 25;
                        if (pos[0] - 1 > 0) board[pos[0] - 1, pos[1] + 1] = 25;
                        if (pos[0] + 1 < 11) board[pos[0] + 1, pos[1] + 1] = 25;
                    }
                    for (int i = 0; i < l; i++)
                    {
                        board[pos[0], pos[1] - i] = 1;
                        if (pos[0] + 1 < 11) board[pos[0] + 1, pos[1] - i] = 25;
                        if (pos[0] - 1 > 0) board[pos[0] - 1, pos[1] - i] = 25;
                    }
                    if (pos[1] - l > 0)
                    {
                        board[pos[0], pos[1] - l] = 25;
                        if (pos[0] - 1 > 0) board[pos[0] - 1, pos[1] - l] = 25;
                        if (pos[0] + 1 < 11) board[pos[0] + 1, pos[1] - l] = 25;
                    }
                    break;
                case 3:                                       //Um das Schiff nach "rechts" zu platzieren wird die x-Koordinate um 1 addiert
                    if (pos[1] - 1 > 0)
                    {
                        board[pos[0], pos[1] - 1] = 25;
                        if (pos[0] - 1 > 0) board[pos[0] - 1, pos[1] - 1] = 25;
                        if (pos[0] + 1 < 11) board[pos[0] + 1, pos[1] - 1] = 25;
                    }
                    for (int i = 0; i < l; i++)
                    {
                        board[pos[0], pos[1] + i] = 1;
                        if (pos[0] + 1 < 11) board[pos[0] + 1, pos[1] + i] = 25;
                        if (pos[0] - 1 > 0) board[pos[0] - 1, pos[1] + i] = 25;
                    }
                    if (pos[1] + l < 11)
                    {
                        board[pos[0], pos[1] + l] = 25;
                        if (pos[0] - 1 > 0) board[pos[0] - 1, pos[1] + l] = 25;
                        if (pos[0] + 1 < 11) board[pos[0] + 1, pos[1] + l] = 25;
                    }
                    break;
                default:
                    break;
            }
        }

        //Checkt ob das Aktuelle Schiff mit anderen Schiffen kollidiert
        void checkO(int l)
        {
            switch (pos[2])
            {
                case 0:
                    for (int i = 0; i < l; i++)
                    {
                        if (board[pos[0] - i, pos[1]] == 1 || board[pos[0] - i, pos[1]] == 25){
                            pos[0] = rnd.Next(10) + 1;
                            pos[1] = rnd.Next(10) + 1;
                            pos[2] = rnd.Next(4);
                            check(l);
                            checkO(l);
                            break;
                        }
                    }
                    break;
                case 1:
                    for (int i = 0; i < l; i++)
                    {
                        if (board[pos[0] + i, pos[1]] == 1 || board[pos[0] + i, pos[1]] == 25)
                        {
                            pos[0] = rnd.Next(10) + 1;
                            pos[1] = rnd.Next(10) + 1;
                            pos[2] = rnd.Next(4);
                            check(l);
                            checkO(l);
                            break;
                        }
                    }
                    break;
                case 2:
                    for (int i = 0; i < l; i++)
                    {
                        if (board[pos[0], pos[1] - i] == 1 || board[pos[0], pos[1] - i] == 25)
                        {
                            pos[0] = rnd.Next(10) + 1;
                            pos[1] = rnd.Next(10) + 1;
                            pos[2] = rnd.Next(4);
                            check(l);
                            checkO(l);
                            break;
                        }
                    }
                    break;
                case 3:
                    for (int i = 0; i < l; i++)
                    {
                        if (board[pos[0], pos[1] + i] == 1 || board[pos[0], pos[1] + i] == 25)
                        {
                            pos[0] = rnd.Next(10) + 1;
                            pos[1] = rnd.Next(10) + 1;
                            pos[2] = rnd.Next(4);
                            check(l);
                            checkO(l);
                            break;
                        }
                    }
                    break;
            }
        }

        //Lässt die AI schießen. Benotigt das Board (b)
        public void Shoot(Board b)
        {
            int[] target = new int[2];                  //Speicher das Ziel der AI
            board = b.P1hget();                         //Speichert das aktuelle Board des Spielers 1, welches Spieler 2 sieht
            target[0] = rnd.Next(10) + 1;               //Generiert eine zufällige x-Koordinate
            target[1] = rnd.Next(10) + 1;               //Generiert eine zufällige y-Koordinate
            while (board[target[0], target[1]] != 0)    //Generiert einen neuen Schuss, sollte die AI da schon hingeschossen hat
            {
                target[0] = rnd.Next(10) + 1;
                target[1] = rnd.Next(10) + 1;
            }
            b.P2shootAI(target);                        //Übergibt die Koordinaten dem Board um zu schießen
        }
    }

    //WIP für unterschiedliche Schwierigkeitsgrade
    public class AIHard
    {
        int[,] board = {
        { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
        { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
        { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
        { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
        { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
        { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
        { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
        { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
        { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
        { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0}
        };

        int[,] chance = {
        { 1/100, 1/100, 1/100, 1/100, 1/100, 1/100, 1/100, 1/100, 1/100, 1/100},
        { 1/100, 1/100, 1/100, 1/100, 1/100, 1/100, 1/100, 1/100, 1/100, 1/100},
        { 1/100, 1/100, 1/100, 1/100, 1/100, 1/100, 1/100, 1/100, 1/100, 1/100},
        { 1/100, 1/100, 1/100, 1/100, 1/100, 1/100, 1/100, 1/100, 1/100, 1/100},
        { 1/100, 1/100, 1/100, 1/100, 1/100, 1/100, 1/100, 1/100, 1/100, 1/100},
        { 1/100, 1/100, 1/100, 1/100, 1/100, 1/100, 1/100, 1/100, 1/100, 1/100},
        { 1/100, 1/100, 1/100, 1/100, 1/100, 1/100, 1/100, 1/100, 1/100, 1/100},
        { 1/100, 1/100, 1/100, 1/100, 1/100, 1/100, 1/100, 1/100, 1/100, 1/100},
        { 1/100, 1/100, 1/100, 1/100, 1/100, 1/100, 1/100, 1/100, 1/100, 1/100},
        { 1/100, 1/100, 1/100, 1/100, 1/100, 1/100, 1/100, 1/100, 1/100, 1/100}
        };

        int[] pieces = { 4, 12, 4 };

        void ReChance(Board b)
        {
            board = b.P1hgetS();
            int temp = 0;

            foreach(int field in board)
            {
                if (field == 1 || field == 25)
                {
                    chance[temp % 10, temp - (10 * (temp % 10))] = 1 / 101;
                }
                if ((temp % 10) - 1 < 0)
                {
                    
                }
            }
        }
    }
}