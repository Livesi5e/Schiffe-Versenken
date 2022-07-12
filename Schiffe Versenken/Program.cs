using System;
using SVAI7;
using SVgerman;
class UI
{
    static string end = "n";                                                                //Beinhaltet, ob das Spiel beendet wurde
    static void Main(string[] args)
    {
        Console.WriteLine("Schiffe Versenken Console Edition");
        Console.WriteLine("---------------------------------");
        while (end == "n")                                                                  //Beendet sich, sobald das Spiel beendet wurde
        {
            Board Gamestate = new Board();                                                  //Initialisiert ein neues Board
            Gamestate.SetDictionary();
            Console.WriteLine("Für eine neue Runde schreibe \"n\" und drücke \"Enter\"");
            Console.WriteLine("Um das Programm zu beenden drücke \"Enter\"");
            end = Console.ReadLine();                                                       //Hier entscheidet der User, ob das Spiel beendet wird
            Console.WriteLine();
            if(end != "n") break;
            Console.Clear();
            Console.WriteLine("Du kannst gegen eine AI spielen, oder gegen einen anderen Spieler");
            Console.WriteLine("1 Spieler                2 Spieler");
            string temp = Console.ReadLine();                                               //Der User gibt an, ob er alleine oder zu zweit spielen will
            Console.Clear();                                                                //Momentan funktioniert nur 1 Spieler
            if (temp == "1 Spieler")
            {
                AIEasy enemy = new AIEasy();                                                //Initialisiert eine Einfache AI
                bool gameEnd = false;                                                       //Beinhaltet, ob die momentane Runde beendet wurde
                bool won = false;                                                           //Beinhaltet, wer gewonnen hat. true = Spieler 1, false = Spieler 2
                Gamestate.Player1out();                                                     //Printed das Board von Spieler 1
                Console.WriteLine("\nZuerst plaziere die 4 X-Schiffe, danach die 3 XX-Schiffe, dann die 2 XXX-Schiff und das XXXX-Schiff");
                Console.WriteLine("Gebe ein, wo das Schiff plaziert werden soll und wie das orientiert sein soll. Die Syntax dafür ist \"A,2,right\". Möglich sind \"up\",\"down\",\"left\",\"right\"");
                Console.WriteLine("Zuerst wird das erste X-Schiff plaziert\n");
                Gamestate.PlaceP1(1);                                                       //Platziert ein Schiff der Länge 1
                Console.Clear();
                Gamestate.Player1out();
                Console.WriteLine("\nGebe nun die Position des zweiten X-Schiff ein");
                Gamestate.PlaceP1(1);                                                       //Platziert ein Schiff der Länge 1
                Console.Clear();
                Gamestate.Player1out();
                Console.WriteLine("\nGebe nun die Position des dritten X-Schiff ein");
                Gamestate.PlaceP1(1);                                                       //Platziert ein Schiff der Länge 1
                Console.Clear();
                Gamestate.Player1out();
                Console.WriteLine("\nGebe nun die Position des vierten X-Schiff ein");
                Gamestate.PlaceP1(1);                                                       //Platziert ein Schiff der Länge 1
                Console.Clear();
                Gamestate.Player1out();
                Console.WriteLine("\nGebe nun die Position des ersten XX-Schiffs ein");
                Gamestate.PlaceP1(2);                                                       //Platziert ein Schiff der Länge 2
                Console.Clear();
                Gamestate.Player1out();
                Console.WriteLine("\nGebe nun die Position des zweiten XX-Schiffs ein");
                Gamestate.PlaceP1(2);                                                       //Platziert ein Schiff der Länge 2
                Console.Clear();
                Gamestate.Player1out();
                Console.WriteLine("\nGebe nun die Position des dritten XX-Schiffs ein");
                Gamestate.PlaceP1(2);                                                       //Platziert ein Schiff der Länge 2
                Console.Clear();
                Gamestate.Player1out();
                Console.WriteLine("\nGebe nun die Position des ersten XXX-Schiffs ein");
                Gamestate.PlaceP1(3);                                                       //Platziert ein Schiff der Länge 3
                Console.Clear();
                Gamestate.Player1out();
                Console.WriteLine("\nGebe nun die Position des zweiten XXX-Schiffs ein");
                Gamestate.PlaceP1(3);                                                       //Platziert ein Schiff der Länge 3
                Console.Clear();
                Gamestate.Player1out();
                Console.WriteLine("\nGebe nun die Position des XXXX-Schiffs ein");
                Gamestate.PlaceP1(4);                                                       //Platziert ein Schiff der Länge 4
                Console.Clear();
                enemy.Place(Gamestate);
                while (gameEnd == false)
                {
                    Console.Clear();
                    Gamestate.Player2outhP1out();
                    Console.WriteLine("\nBitte gebe die Position an, wo du schießen möchtest. Die Syntax ist \"A,1\"\n");
                    Gamestate.P1shoot();                                                    //Spieler 1 kann schießen
                    gameEnd = Gamestate.CheckWinP1();                                       //Es wird gecheckt ob Spieler 1 gewonnen hat
                    if (gameEnd == true)
                    {
                        won = true;
                        break;
                    }
                    Console.WriteLine("\n");
                    enemy.Shoot(Gamestate);                                                 //Die AI schießt
                    gameEnd = Gamestate.CheckWinP2();                                       //Es wird gecheckt ob Spieler 2 gewonnen hat
                    if (gameEnd == true) break;
                    Console.WriteLine("\n\n");
                }
                if (won == true)                                                            //Es wird entschieden, wer gewonnen hat und die Nachricht rausgeprinted
                {
                    Console.WriteLine("Herzlichen Glückwunsch Spieler 1! Du hast gewonnen!\n");
                }
                else
                {
                    Console.WriteLine("Herzlichen Glückwunsch Spieler 2! Du hast gewonnen!\n");
                }
            }
            else if(temp == "2 Spieler")                                                    //WIP für Mehrspieler Modus
            {
                bool gameEnd = false;
                bool won = false;
                Console.WriteLine("Spieler 1 darf nun die Schiffe platzieren.\nBitte drück \"Enter\", sobald Spieler 2 den Bildschirm nicht mehr sehen kann");
                Console.ReadLine();
                Console.Clear();
                Gamestate.Player1out();                                                     //Printed das Board von Spieler 1
                Console.WriteLine("\nZuerst plaziere die 2 XX-Schiffe, danach die 2 XXX-Schiffe, dann das XXXX-Schiff und das XXXXX-Schiff");
                Console.WriteLine("Gebe ein, wo das Schiff plaziert werden soll und wie das orientiert sein soll. Die Syntax dafür ist \"A,2,right\". Möglich sind \"up\",\"down\",\"left\",\"right\"");
                Console.WriteLine("Zuerst wird das erste XX-Schiff plaziert\n");
                Gamestate.PlaceP1(2);                                                       //Platziert ein Schiff der Länge 2
                Console.Clear();
                Gamestate.Player1out();
                Console.WriteLine("\nGebe nun die Position des zweiten XX-Schiff ein");
                Gamestate.PlaceP1(2);                                                       //Platziert ein Schiff der Länge 2
                Console.Clear();
                Gamestate.Player1out();
                Console.WriteLine("\nGebe nun die Position des ersten XXX-Schiff ein");
                Gamestate.PlaceP1(3);                                                       //Platziert ein Schiff der Länge 3
                Console.Clear();
                Gamestate.Player1out();
                Console.WriteLine("\nGebe nun die Position des zweiten XXX-Schiff ein");
                Gamestate.PlaceP1(3);                                                       //Platziert ein Schiff der Länge 3
                Console.Clear();
                Gamestate.Player1out();
                Console.WriteLine("\nGebe nun die Position des XXXX-Schiffs ein");
                Gamestate.PlaceP1(4);                                                       //Platziert ein Schiff der Länge 4
                Console.Clear();
                Gamestate.Player1out();
                Console.WriteLine("\nGebe nun die Position des XXXXX-Schiffs ein");
                Gamestate.PlaceP1(5);                                                       //Platziert ein Schiff der Länge 5
                Console.Clear();
                Gamestate.Player1out();
                Console.WriteLine("\nDies sind die Schiffe. Drücke \"Enter\" um fortzufahren");
                Console.ReadLine();
                Console.Clear();
                Console.WriteLine("Spieler 2 darf nun die Schiffe platzieren.\nDrücke \"Enter\" sobald Spieler 1 den Bildschirm nicht mehr sieht");
                Console.ReadLine();
                Console.Clear();
                Gamestate.Player2out();                                                     //Printed das Board von Spieler 1
                Console.WriteLine("\nZuerst plaziere die 2 XX-Schiffe, danach die 2 XXX-Schiffe, dann das XXXX-Schiff und das XXXXX-Schiff");
                Console.WriteLine("Gebe ein, wo das Schiff plaziert werden soll und wie das orientiert sein soll. Die Syntax dafür ist \"A,2,right\". Möglich sind \"up\",\"down\",\"left\",\"right\"");
                Console.WriteLine("Zuerst wird das erste XX-Schiff plaziert\n");
                Gamestate.PlaceP2(2);                                                       //Platziert ein Schiff der Länge 2
                Console.Clear();
                Gamestate.Player2out();
                Console.WriteLine("\nGebe nun die Position des zweiten XX-Schiff ein");
                Gamestate.PlaceP2(2);                                                       //Platziert ein Schiff der Länge 2
                Console.Clear();
                Gamestate.Player2out();
                Console.WriteLine("\nGebe nun die Position des ersten XXX-Schiff ein");
                Gamestate.PlaceP2(3);                                                       //Platziert ein Schiff der Länge 3
                Console.Clear();
                Gamestate.Player2out();
                Console.WriteLine("\nGebe nun die Position des zweiten XXX-Schiff ein");
                Gamestate.PlaceP2(3);                                                       //Platziert ein Schiff der Länge 3
                Console.Clear();
                Gamestate.Player2out();
                Console.WriteLine("\nGebe nun die Position des XXXX-Schiffs ein");
                Gamestate.PlaceP2(4);                                                       //Platziert ein Schiff der Länge 4
                Console.Clear();
                Gamestate.Player2out();
                Console.WriteLine("\nGebe nun die Position des XXXXX-Schiffs ein");
                Gamestate.PlaceP2(5);
                Console.Clear();
                Gamestate.Player2out();
                Console.WriteLine("\nDies sind die Schiffe. Drücke \"Enter\" um fortzufahren");
                Console.ReadLine();
                Console.Clear();
                while(gameEnd == false)
                {
                    Console.WriteLine("Spieler 1 darf nun schießen.\nDrücke \"Enter\" sobald Spieler 2 den Bildschirm nicht mehr sieht");
                    Console.ReadLine();
                    Console.Clear();
                    Gamestate.Player2outhP1out();
                    Console.WriteLine("\nBitte gebe die Position an, wo du schießen möchtest. Die Syntax ist \"A,1\"\n");
                    Gamestate.P1shoot();
                    if (Gamestate.CheckWinP1()) { won = true; break; }
                    Console.Clear();
                    Gamestate.Player2outhP1out();
                    Console.WriteLine("\nUm fortzufahren, drücke \"Enter\"");
                    Console.ReadLine();
                    Console.Clear();
                    Console.WriteLine("Spieler 2 darf nun schießen.\nDrücke \"Enter\" sobald Spieler 1 den Bildschirm nicht mehr sieht");
                    Console.ReadLine();
                    Console.Clear();
                    Gamestate.Player1outhP2out();
                    Console.WriteLine("\nBitte gebe die Position an, wo du schießen möchtest. Die Syntax ist \"A,1\"\n");
                    Gamestate.P2shoot();
                    if (Gamestate.CheckWinP2()) break;
                    Console.Clear();
                    Gamestate.Player1outhP2out();
                    Console.WriteLine("\nUm fortzufahren, drücke \"Enter\"");
                    Console.ReadLine();
                    Console.Clear();
                }
                Console.Clear();
                if (won)
                {
                    Console.WriteLine("Herzlichen Glückwunsch Spieler 1! Du hast gewonnen!");
                }
                else
                {
                    Console.WriteLine("Herzlichen Glückwunsch Spieler 2! Du hast gewonnen!");
                }
                Console.WriteLine("\nZum fortfahren, drücke \"Enter\"");
                Console.ReadLine();
            }
        }
        if(end == "changelog")
        {
            Console.Clear();
            Console.WriteLine
            (
                "Changelog:\n" +
                "----------------\n" +
                "v.1.2:\n" +
                "\t- Added a build which runs on all Windows versions\n" +
                "\t- Compressed the files down to a single .exe\n" +
                "----------------\n" +
                "v1.1:\n" +
                "\t- Added the Changelog\n" +
                "\t- Added multiplayer\n" +
                "\t- Changed some of the comments in the code\n" +
                "\t- Fixed the Bug where printing out both boards resulted in printing \"Dein Feld Feld:\"\n" + 
                "\t  Now only prints \"Dein Feld:\"\n" + 
                "----------------\n" +
                "v1.0:\n" +
                "\tFirst working release of the game\n" +
                "\tOnly works on Win 10 or Win 11. Still figuring out how publishing works in VS 2022.\n" +
                "\tSo if the Game isn't running on your system please provide a comment with your OS\n" +
                "\n\tNote:\n" +
                "\tOnly Singleplayer works in this version and the AI has only one difficulty setting\n" +
                "\tDocks for WIP are already implemented but are not working right now"
            );
            Console.ReadLine();
            Console.Clear();
            end = "n";
            Main(args);
        }
    }
}