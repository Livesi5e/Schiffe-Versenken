using SVgerman;
using System;

namespace SVAI7
{
    public class AIEasy
    {
        int[,] board = new int[,] {                     //Board für die AI. An sich das, was Spieler 1 auch sieht
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
        int[] pos = new int[18];                        //Array was die Positionen der Schiffe der AI speichert
        Random rnd = new Random();                      //Initialisierung des Random Zahlengenerator

        //Generiert die Positionen der Schiffe. Benötigt ein Board (b)
        public void Place(Board b)
        {
            pos[0] = rnd.Next(10) + 1;              //Generiert eine zufällige x-Koordinate
            pos[1] = rnd.Next(10) + 1;              //Generiert eine zufällige y-Koordinate
            pos[2] = rnd.Next(4);                   //Generiert eine zufällige Orientierung
            check(1, 2);                            //Checkt ob die Position in Bounds ist und übergibt die Positionen im Array und die Länge des Schiffes
            setC(2, 1);                             //Übergibt die Länge des Schiffs und die Positionen im Array
            pos[3] = rnd.Next(10) + 1;
            pos[4] = rnd.Next(10) + 1;
            pos[5] = rnd.Next(4);
            check(2, 2);
            checkO(1);                              //Check ob das Schiff mit einem anderem kollidiert und übergibt die Positionen im Array
            setC(2, 2);
            pos[6] = rnd.Next(10) + 1;
            pos[7] = rnd.Next(10) + 1;
            pos[8] = rnd.Next(4);
            check(3, 3);
            checkO(2);
            setC(3, 3);
            pos[9] = rnd.Next(10) + 1;
            pos[10] = rnd.Next(10) + 1;
            pos[11] = rnd.Next(4);
            check(4, 3);
            checkO(3);
            setC(3, 4);
            pos[12] = rnd.Next(10) + 1;
            pos[13] = rnd.Next(10) + 1;
            pos[14] = rnd.Next(4);
            check(5, 4);
            checkO(4);
            setC(4, 5);
            pos[15] = rnd.Next(10) + 1;
            pos[16] = rnd.Next(10) + 1;
            pos[17] = rnd.Next(4);
            check(6, 5);
            checkO(5);
            setC(5, 6);
            b.PlaceP2AI(pos);                       //Übergibt das Array dem Board und platziert die Schiffe
        }

        //Checkt ob das Schiff Out of Bounds ist. Benötigt die Positionen im Array (r) und die Länge des Schiffs (l)
        void check(int r, int l)
        {
            switch (r)                                      //Basierend auf der Zahl werden andere Positionen benutzt
            {
                case 1:
                    switch (pos[2])                         //Basierend auf der Zahl wird eine andere Richtung benutzt
                    {
                        case 0:
                            if (pos[0] - (l - 1) < 1)       //Checkt ob der weit entfernteste Punkt des Schiffs Out of Bounds liegt
                            {
                                pos[0] = rnd.Next(10) + 1;  //Generiert neue Punkte falls die alten Invalide sind
                                pos[1] = rnd.Next(10) + 1;
                                pos[2] = rnd.Next(4);
                                check(r, l);                //Ruft diese Funktion rekursiv auf
                            }
                            break;
                        case 1:
                            if (pos[0] + (l - 1) > 10)
                            {
                                pos[0] = rnd.Next(10) + 1;
                                pos[1] = rnd.Next(10) + 1;
                                pos[2] = rnd.Next(4);
                                check(r, l);
                            }
                            break;
                        case 2:
                            if (pos[1] - (l - 1) < 1)
                            {
                                pos[0] = rnd.Next(10) + 1;
                                pos[1] = rnd.Next(10) + 1;
                                pos[2] = rnd.Next(4);
                                check(r, l);
                            }
                            break;
                        case 3:
                            if (pos[1] + (l - 1) > 10)
                            {
                                pos[0] = rnd.Next(10) + 1;
                                pos[1] = rnd.Next(10) + 1;
                                pos[2] = rnd.Next(4);
                                check(r, l);
                            }
                            break;
                    }
                    break;
                case 2:
                    switch (pos[5])
                    {
                        case 0:
                            if (pos[3] - (l - 1) < 1)
                            {
                                pos[3] = rnd.Next(10) + 1;
                                pos[4] = rnd.Next(10) + 1;
                                pos[5] = rnd.Next(4);
                                check(r, l);
                            }
                            break;
                        case 1:
                            if (pos[3] + (l - 1) > 10)
                            {
                                pos[3] = rnd.Next(10) + 1;
                                pos[4] = rnd.Next(10) + 1;
                                pos[5] = rnd.Next(4);
                                check(r, l);
                            }
                            break;
                        case 2:
                            if (pos[4] - (l - 1) < 1)
                            {
                                pos[3] = rnd.Next(10) + 1;
                                pos[4] = rnd.Next(10) + 1;
                                pos[5] = rnd.Next(4);
                                check(r, l);
                            }
                            break;
                        case 3:
                            if (pos[4] + (l - 1) > 10)
                            {
                                pos[3] = rnd.Next(10) + 1;
                                pos[4] = rnd.Next(10) + 1;
                                pos[5] = rnd.Next(4);
                                check(r, l);
                            }
                            break;
                    }
                    break;
                case 3:
                    switch (pos[8])
                    {
                        case 0:
                            if (pos[6] - (l - 1) < 1)
                            {
                                pos[6] = rnd.Next(10) + 1;
                                pos[7] = rnd.Next(10) + 1;
                                pos[8] = rnd.Next(4);
                                check(r, l);
                            }
                            break;
                        case 1:
                            if (pos[6] + (l - 1) > 10)
                            {
                                pos[6] = rnd.Next(10) + 1;
                                pos[7] = rnd.Next(10) + 1;
                                pos[8] = rnd.Next(4);
                                check(r, l);
                            }
                            break;
                        case 2:
                            if (pos[7] - (l - 1) < 1)
                            {
                                pos[6] = rnd.Next(10) + 1;
                                pos[7] = rnd.Next(10) + 1;
                                pos[8] = rnd.Next(4);
                                check(r, l);
                            }
                            break;
                        case 3:
                            if (pos[7] + (l - 1) > 10)
                            {
                                pos[6] = rnd.Next(10) + 1;
                                pos[7] = rnd.Next(10) + 1;
                                pos[8] = rnd.Next(4);
                                check(r, l);
                            }
                            break;
                    }
                    break;
                case 4:
                    switch (pos[11])
                    {
                        case 0:
                            if (pos[9] - (l - 1) < 1)
                            {
                                pos[9] = rnd.Next(10) + 1;
                                pos[10] = rnd.Next(10) + 1;
                                pos[11] = rnd.Next(4);
                                check(r, l);
                            }
                            break;
                        case 1:
                            if (pos[9] + (l - 1) > 10)
                            {
                                pos[9] = rnd.Next(10) + 1;
                                pos[10] = rnd.Next(10) + 1;
                                pos[11] = rnd.Next(4);
                                check(r, l);
                            }
                            break;
                        case 2:
                            if (pos[10] - (l - 1) < 1)
                            {
                                pos[9] = rnd.Next(10) + 1;
                                pos[10] = rnd.Next(10) + 1;
                                pos[11] = rnd.Next(4);
                                check(r, l);
                            }
                            break;
                        case 3:
                            if (pos[10] + (l - 1) > 10)
                            {
                                pos[9] = rnd.Next(10) + 1;
                                pos[10] = rnd.Next(10) + 1;
                                pos[11] = rnd.Next(4);
                                check(r, l);
                            }
                            break;
                    }
                    break;
                case 5:
                    switch (pos[14])
                    {
                        case 0:
                            if (pos[12] - (l - 1) < 1)
                            {
                                pos[12] = rnd.Next(10) + 1;
                                pos[13] = rnd.Next(10) + 1;
                                pos[14] = rnd.Next(4);
                                check(r, l);
                            }
                            break;
                        case 1:
                            if (pos[12] + (l - 1) > 10)
                            {
                                pos[12] = rnd.Next(10) + 1;
                                pos[13] = rnd.Next(10) + 1;
                                pos[14] = rnd.Next(4);
                                check(r, l);
                            }
                            break;
                        case 2:
                            if (pos[13] - (l - 1) < 1)
                            {
                                pos[12] = rnd.Next(10) + 1;
                                pos[13] = rnd.Next(10) + 1;
                                pos[14] = rnd.Next(4);
                                check(r, l);
                            }
                            break;
                        case 3:
                            if (pos[13] + (l - 1) > 10)
                            {
                                pos[12] = rnd.Next(10) + 1;
                                pos[13] = rnd.Next(10) + 1;
                                pos[14] = rnd.Next(4);
                                check(r, l);
                            }
                            break;
                    }
                    break;
                case 6:
                    switch (pos[17])
                    {
                        case 0:
                            if (pos[15] - (l - 1) < 1)
                            {
                                pos[15] = rnd.Next(10) + 1;
                                pos[16] = rnd.Next(10) + 1;
                                pos[17] = rnd.Next(4);
                                check(r, l);
                            }
                            break;
                        case 1:
                            if (pos[15] + (l - 1) > 10)
                            {
                                pos[15] = rnd.Next(10) + 1;
                                pos[16] = rnd.Next(10) + 1;
                                pos[17] = rnd.Next(4);
                                check(r, l);
                            }
                            break;
                        case 2:
                            if (pos[16] - (l - 1) < 1)
                            {
                                pos[15] = rnd.Next(10) + 1;
                                pos[16] = rnd.Next(10) + 1;
                                pos[17] = rnd.Next(4);
                                check(r, l);
                            }
                            break;
                        case 3:
                            if (pos[16] + (l - 1) > 10)
                            {
                                pos[15] = rnd.Next(10) + 1;
                                pos[16] = rnd.Next(10) + 1;
                                pos[17] = rnd.Next(4);
                                check(r, l);
                            }
                            break;
                    }
                    break;
            }
        }

        //Platziert das Schiff im eigenen Board. Benötigt die Länge des Schiffs (l) und die Positionen im Array (r)
        void setC(int l, int r)
        {
            switch (r)
            {
                case 1:
                    switch (pos[2])
                    {
                        case 0:
                            for (int i = 0; i < l; i++)
                            {
                                board[pos[0] - i, pos[1]] = 1;
                            }
                            break;
                        case 1:
                            for (int i = 0; i < l; i++)
                            {
                                board[pos[0] + i, pos[1]] = 1;
                            }
                            break;
                        case 2:
                            for (int i = 0; i < l; i++)
                            {
                                board[pos[0], pos[1] - i] = 1;
                            }
                            break;
                        case 3:
                            for (int i = 0; i < l; i++)
                            {
                                board[pos[0], pos[1] + i] = 1;
                            }
                            break;
                    }
                    break;
                case 2:
                    switch (pos[5])
                    {
                        case 0:
                            for (int i = 0; i < l; i++)
                            {
                                board[pos[3] - i, pos[4]] = 1;
                            }
                            break;
                        case 1:
                            for (int i = 0; i < l; i++)
                            {
                                board[pos[3] + i, pos[4]] = 1;
                            }
                            break;
                        case 2:
                            for (int i = 0; i < l; i++)
                            {
                                board[pos[3], pos[4] - i] = 1;
                            }
                            break;
                        case 3:
                            for (int i = 0; i < l; i++)
                            {
                                board[pos[3], pos[4] + i] = 1;
                            }
                            break;
                    }
                    break;
                case 3:
                    switch (pos[8])
                    {
                        case 0:
                            for (int i = 0; i < l; i++)
                            {
                                board[pos[6] - i, pos[7]] = 1;
                            }
                            break;
                        case 1:
                            for (int i = 0; i < l; i++)
                            {
                                board[pos[6] + i, pos[7]] = 1;
                            }
                            break;
                        case 2:
                            for (int i = 0; i < l; i++)
                            {
                                board[pos[6], pos[7] - i] = 1;
                            }
                            break;
                        case 3:
                            for (int i = 0; i < l; i++)
                            {
                                board[pos[6], pos[7] + i] = 1;
                            }
                            break;
                    }
                    break;
                case 4:
                    switch (pos[11])
                    {
                        case 0:
                            for (int i = 0; i < l; i++)
                            {
                                board[pos[9] - i, pos[10]] = 1;
                            }
                            break;
                        case 1:
                            for (int i = 0; i < l; i++)
                            {
                                board[pos[9] + i, pos[10]] = 1;
                            }
                            break;
                        case 2:
                            for (int i = 0; i < l; i++)
                            {
                                board[pos[9], pos[10] - i] = 1;
                            }
                            break;
                        case 3:
                            for (int i = 0; i < l; i++)
                            {
                                board[pos[9], pos[10] + i] = 1;
                            }
                            break;
                    }
                    break;
                case 5:
                    switch (pos[14])
                    {
                        case 0:
                            for (int i = 0; i < l; i++)
                            {
                                board[pos[12] - i, pos[13]] = 1;
                            }
                            break;
                        case 1:
                            for (int i = 0; i < l; i++)
                            {
                                board[pos[12] + i, pos[13]] = 1;
                            }
                            break;
                        case 2:
                            for (int i = 0; i < l; i++)
                            {
                                board[pos[12], pos[13] - i] = 1;
                            }
                            break;
                        case 3:
                            for (int i = 0; i < l; i++)
                            {
                                board[pos[12], pos[13] + i] = 1;
                            }
                            break;
                    }
                    break;
                case 6:
                    switch (pos[17])
                    {
                        case 0:
                            for (int i = 0; i < l; i++)
                            {
                                board[pos[15] - i, pos[16]] = 1;
                            }
                            break;
                        case 1:
                            for (int i = 0; i < l; i++)
                            {
                                board[pos[15] + i, pos[16]] = 1;
                            }
                            break;
                        case 2:
                            for (int i = 0; i < l; i++)
                            {
                                board[pos[15], pos[16] - i] = 1;
                            }
                            break;
                        case 3:
                            for (int i = 0; i < l; i++)
                            {
                                board[pos[15], pos[16] + i] = 1;
                            }
                            break;
                    }
                    break;
            }
        }

        //Checkt ob das Aktuelle Schiff mit anderen Schiffen kollidiert
        void checkO(int r)
        {
            switch (r)
            {
                case 1:
                    switch (pos[5])
                    {
                        case 0:
                            for (int i = 0; i < 2; i++)
                            {
                                if (board[pos[3] - i, pos[4]] == 1)
                                {
                                    pos[3] = rnd.Next(10) + 1;
                                    pos[4] = rnd.Next(10) + 1;
                                    pos[5] = rnd.Next(4);
                                    check(r + 1, 2);
                                    checkO(r);
                                    break;
                                }
                            }
                            break;
                        case 1:
                            for (int i = 0; i < 2; i++)
                            {
                                if (board[pos[3] + i, pos[4]] == 1)
                                {
                                    pos[3] = rnd.Next(10) + 1;
                                    pos[4] = rnd.Next(10) + 1;
                                    pos[5] = rnd.Next(4);
                                    check(r + 1, 2);
                                    checkO(r);
                                    break;
                                }
                            }
                            break;
                        case 2:
                            for (int i = 0; i < 2; i++)
                            {
                                if (board[pos[3], pos[4] - i] == 1)
                                {
                                    pos[3] = rnd.Next(10) + 1;
                                    pos[4] = rnd.Next(10) + 1;
                                    pos[5] = rnd.Next(4);
                                    check(r + 1, 2);
                                    checkO(r);
                                    break;
                                }
                            }
                            break;
                        case 3:
                            for (int i = 0; i < 2; i++)
                            {
                                if (board[pos[3], pos[4] + i] == 1)
                                {
                                    pos[3] = rnd.Next(10) + 1;
                                    pos[4] = rnd.Next(10) + 1;
                                    pos[5] = rnd.Next(4);
                                    check(r + 1, 2);
                                    checkO(r);
                                    break;
                                }
                            }
                            break;
                    }
                    break;
                case 2:
                    switch (pos[8])
                    {
                        case 0:
                            for (int i = 0; i < 3; i++)
                            {
                                if (board[pos[6] - i, pos[7]] == 1)
                                {
                                    pos[6] = rnd.Next(10) + 1;
                                    pos[7] = rnd.Next(10) + 1;
                                    pos[8] = rnd.Next(4);
                                    check(r + 1, 3);
                                    checkO(r);
                                    break;
                                }
                            }
                            break;
                        case 1:
                            for (int i = 0; i < 3; i++)
                            {
                                if (board[pos[6] + i, pos[7]] == 1)
                                {
                                    pos[6] = rnd.Next(10) + 1;
                                    pos[7] = rnd.Next(10) + 1;
                                    pos[8] = rnd.Next(4);
                                    check(r + 1, 3);
                                    checkO(r);
                                    break;
                                }
                            }
                            break;
                        case 2:
                            for (int i = 0; i < 3; i++)
                            {
                                if (board[pos[6], pos[7] - i] == 1)
                                {
                                    pos[6] = rnd.Next(10) + 1;
                                    pos[7] = rnd.Next(10) + 1;
                                    pos[8] = rnd.Next(4);
                                    check(r + 1, 3);
                                    checkO(r);
                                    break;
                                }
                            }
                            break;
                        case 3:
                            for (int i = 0; i < 3; i++)
                            {
                                if (board[pos[6], pos[7] + i] == 1)
                                {
                                    pos[6] = rnd.Next(10) + 1;
                                    pos[7] = rnd.Next(10) + 1;
                                    pos[8] = rnd.Next(4);
                                    check(r + 1, 3);
                                    checkO(r);
                                    break;
                                }
                            }
                            break;
                    }
                    break;
                case 3:
                    switch (pos[11])
                    {
                        case 0:
                            for (int i = 0; i < 3; i++)
                            {
                                if (board[pos[9] - i, pos[10]] == 1)
                                {
                                    pos[9] = rnd.Next(10) + 1;
                                    pos[10] = rnd.Next(10) + 1;
                                    pos[11] = rnd.Next(4);
                                    check(r + 1, 3);
                                    checkO(r);
                                    break;
                                }
                            }
                            break;
                        case 1:
                            for (int i = 0; i < 3; i++)
                            {
                                if (board[pos[9] + i, pos[10]] == 1)
                                {
                                    pos[9] = rnd.Next(10) + 1;
                                    pos[10] = rnd.Next(10) + 1;
                                    pos[11] = rnd.Next(4);
                                    check(r + 1, 3);
                                    checkO(r);
                                    break;
                                }
                            }
                            break;
                        case 2:
                            for (int i = 0; i < 3; i++)
                            {
                                if (board[pos[9], pos[10] - i] == 1)
                                {
                                    pos[9] = rnd.Next(10) + 1;
                                    pos[10] = rnd.Next(10) + 1;
                                    pos[11] = rnd.Next(4);
                                    check(r + 1, 3);
                                    checkO(r);
                                    break;
                                }
                            }
                            break;
                        case 3:
                            for (int i = 0; i < 3; i++)
                            {
                                if (board[pos[9], pos[10] + i] == 1)
                                {
                                    pos[9] = rnd.Next(10) + 1;
                                    pos[10] = rnd.Next(10) + 1;
                                    pos[11] = rnd.Next(4);
                                    check(r + 1, 3);
                                    checkO(r);
                                    break;
                                }
                            }
                            break;
                    }
                    break;
                case 4:
                    switch (pos[14])
                    {
                        case 0:
                            for (int i = 0; i < 4; i++)
                            {
                                if (board[pos[12] - i, pos[13]] == 1)
                                {
                                    pos[12] = rnd.Next(10) + 1;
                                    pos[13] = rnd.Next(10) + 1;
                                    pos[14] = rnd.Next(4);
                                    check(r + 1, 4);
                                    checkO(r);
                                    break;
                                }
                            }
                            break;
                        case 1:
                            for (int i = 0; i < 4; i++)
                            {
                                if (board[pos[12] + i, pos[13]] == 1)
                                {
                                    pos[12] = rnd.Next(10) + 1;
                                    pos[13] = rnd.Next(10) + 1;
                                    pos[14] = rnd.Next(4);
                                    check(r + 1, 4);
                                    checkO(r);
                                    break;
                                }
                            }
                            break;
                        case 2:
                            for (int i = 0; i < 4; i++)
                            {
                                if (board[pos[12], pos[13] - i] == 1)
                                {
                                    pos[12] = rnd.Next(10) + 1;
                                    pos[13] = rnd.Next(10) + 1;
                                    pos[14] = rnd.Next(4);
                                    check(r + 1, 4);
                                    checkO(r);
                                    break;
                                }
                            }
                            break;
                        case 3:
                            for (int i = 0; i < 4; i++)
                            {
                                if (board[pos[12], pos[13] + i] == 1)
                                {
                                    pos[12] = rnd.Next(10) + 1;
                                    pos[13] = rnd.Next(10) + 1;
                                    pos[14] = rnd.Next(4);
                                    check(r + 1, 4);
                                    checkO(r);
                                    break;
                                }
                            }
                            break;
                    }
                    break;
                case 5:
                    switch (pos[17])
                    {
                        case 0:
                            for (int i = 0; i < 5; i++)
                            {
                                if (board[pos[15] - i, pos[16]] == 1)
                                {
                                    pos[15] = rnd.Next(10) + 1;
                                    pos[16] = rnd.Next(10) + 1;
                                    pos[17] = rnd.Next(4);
                                    check(r + 1, 5);
                                    checkO(r);
                                    break;
                                }
                            }
                            break;
                        case 1:
                            for (int i = 0; i < 5; i++)
                            {
                                if (board[pos[15] + i, pos[16]] == 1)
                                {
                                    pos[15] = rnd.Next(10) + 1;
                                    pos[16] = rnd.Next(10) + 1;
                                    pos[17] = rnd.Next(4);
                                    check(r + 1, 5);
                                    checkO(r);
                                    break;
                                }
                            }
                            break;
                        case 2:
                            for (int i = 0; i < 5; i++)
                            {
                                if (board[pos[15], pos[16] - i] == 1)
                                {
                                    pos[15] = rnd.Next(10) + 1;
                                    pos[16] = rnd.Next(10) + 1;
                                    pos[17] = rnd.Next(4);
                                    check(r + 1, 5);
                                    checkO(r);
                                    break;
                                }
                            }
                            break;
                        case 3:
                            for (int i = 0; i < 5; i++)
                            {
                                if (board[pos[15], pos[16] + i] == 1)
                                {
                                    pos[15] = rnd.Next(10) + 1;
                                    pos[16] = rnd.Next(10) + 1;
                                    pos[17] = rnd.Next(4);
                                    check(r + 1, 5);
                                    checkO(r);
                                    break;
                                }
                            }
                            break;
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

    }
}