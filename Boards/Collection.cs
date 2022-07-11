﻿using System;

namespace Boards
{
    public class Collection
    {
        int[,] board1 = new int[,] {
        { 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13},
        { 14, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
        { 15, 0, 1, 1, 0, 0, 1, 1, 1, 1, 1},
        { 16, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
        { 17, 0, 0, 1, 0, 0, 1, 0, 0, 0, 0},
        { 18, 1, 0, 1, 0, 0, 1, 0, 0, 0, 0},
        { 19, 1, 0, 0, 0, 0, 1, 0, 0, 0, 0},
        { 20, 1, 0, 0, 0, 0, 1, 0, 0, 0, 0},
        { 21, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
        { 22, 0, 0, 0, 1, 1, 1, 0, 0, 0, 0},
        { 23, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0}
        };

        int[,] board2 = new int[,] {
        { 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13},
        { 14, 1, 1, 1, 1, 0, 0, 0, 0, 0, 0},
        { 15, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
        { 16, 0, 1, 0, 0, 0, 1, 1, 0, 0, 0},
        { 17, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0},
        { 18, 0, 1, 0, 1, 0, 0, 0, 0, 0, 0},
        { 19, 1, 0, 0, 1, 0, 0, 0, 0, 0, 0},
        { 20, 1, 0, 0, 0, 0, 0, 1, 0, 0, 0},
        { 21, 1, 0, 0, 0, 0, 0, 1, 0, 0, 0},
        { 22, 1, 0, 0, 0, 0, 0, 1, 0, 0, 0},
        { 23, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0}
        };

        int[,] board3 = new int[,] {
        { 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13},
        { 14, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
        { 15, 1, 1, 1, 0, 0, 0, 1, 1, 0, 0},
        { 16, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
        { 17, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
        { 18, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0},
        { 19, 0, 1, 0, 1, 0, 0, 1, 0, 0, 0},
        { 20, 0, 1, 0, 0, 0, 0, 1, 0, 0, 0},
        { 21, 0, 1, 0, 0, 0, 0, 1, 0, 0, 0},
        { 22, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0},
        { 23, 0, 0, 0, 0, 0, 1, 1, 1, 1, 1}
        };

        int[,] board4 = new int[,] {
        { 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13},
        { 14, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0},
        { 15, 0, 1, 1, 1, 0, 0, 1, 0, 0, 0},
        { 16, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0},
        { 17, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0},
        { 18, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0},
        { 19, 1, 1, 1, 1, 0, 0, 0, 0, 0, 0},
        { 20, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
        { 21, 0, 1, 0, 0, 0, 1, 1, 0, 0, 0},
        { 22, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0},
        { 23, 0, 1, 0, 0, 1, 1, 0, 0, 0, 0}
        };

        int[,] board5 = new int[,] {
        { 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13},
        { 14, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
        { 15, 1, 0, 0, 0, 1, 1, 1, 1, 0, 0},
        { 16, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0},
        { 17, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0},
        { 18, 0, 0, 1, 1, 1, 1, 1, 0, 0, 0},
        { 19, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
        { 20, 0, 0, 0, 1, 0, 1, 0, 0, 0, 0},
        { 21, 0, 0, 0, 1, 0, 1, 0, 0, 0, 0},
        { 22, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
        { 23, 0, 0, 0, 0, 0, 0, 1, 1, 1, 0}
        };

        int[,] board6 = new int[,] {
        { 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13},
        { 14, 0, 0, 0, 0, 0, 1, 1, 1, 1, 1},
        { 15, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
        { 16, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0},
        { 17, 1, 0, 0, 0, 0, 1, 0, 0, 0, 0},
        { 18, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0},
        { 19, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0},
        { 20, 1, 1, 1, 0, 0, 0, 0, 1, 0, 0},
        { 21, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0},
        { 22, 0, 0, 1, 1, 0, 0, 0, 1, 0, 0},
        { 23, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0}
        };

        int[,] board7 = new int[,] {
        { 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13},
        { 14, 1, 1, 1, 1, 0, 0, 0, 0, 0, 0},
        { 15, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
        { 16, 0, 1, 1, 0, 0, 0, 1, 0, 0, 0},
        { 17, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0},
        { 18, 0, 0, 0, 0, 0, 0, 1, 0, 1, 0},
        { 19, 0, 0, 0, 0, 0, 0, 1, 0, 1, 0},
        { 20, 0, 1, 1, 1, 0, 0, 1, 0, 1, 0},
        { 21, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
        { 22, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0},
        { 23, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0}
        };

        Random rnd = new Random();

        public int[,] getRandomBoard()
        {
            switch(rnd.Next(7))
            {
                case 0:
                    return board1;
                    break;
                case 1:
                    return board2;
                    break;
                case 2:
                    return board3;
                    break;
                case 3:
                    return board4;
                    break;
                case 4:
                    return board5;
                    break;
                case 5:
                    return board6;
                    break;
                case 6:
                    return board7;
                    break;
                default:
                    return board1;
                    break;
            }
        }
    }
}