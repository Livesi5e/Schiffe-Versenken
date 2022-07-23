using System;
using SVAI7;
using SVgerman;
using SVLang;
class UI
{
    static string end = "n";                                                                //Beinhaltet, ob das Spiel beendet wurde
    static string lang;
    static void Main(string[] args)
    {
        Console.WriteLine("Schiffe Versenken Console Edition");
        Console.WriteLine("---------------------------------");
        while (end == "n")                                                                  //Beendet sich, sobald das Spiel beendet wurde
        {
            Board Gamestate = new Board();                                                  //Initialisiert ein neues Board
            dict d = new dict();                                                            //Initialisiert ein neues Language Dictionary
            Gamestate.SetDictionary();
            Console.WriteLine("Please Select your Language:\n\nDeutsch\n");
            lang = Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Schiffe Versenken Console Edition");
            Console.WriteLine("---------------------------------");
            Console.WriteLine(d.text(0, lang));
            Console.WriteLine(d.text(1, lang));
            end = Console.ReadLine();                                                       //Hier entscheidet der User, ob das Spiel beendet wird
            Console.WriteLine();
            if(end != "n") break;
            Console.Clear();
            Console.WriteLine(d.text(2, lang));
            Console.WriteLine(d.text(3, lang));
            string temp = Console.ReadLine();                                               //Der User gibt an, ob er alleine oder zu zweit spielen will
            Console.Clear();                                                                //Momentan funktioniert nur 1 Spieler
            if (temp == "1 Spieler")
            {
                AIEasy enemy = new AIEasy();                                                //Initialisiert eine Einfache AI
                bool gameEnd = false;                                                       //Beinhaltet, ob die momentane Runde beendet wurde
                bool won = false;                                                           //Beinhaltet, wer gewonnen hat. true = Spieler 1, false = Spieler 2
                Gamestate.Player1out();                                                     //Printed das Board von Spieler 1
                Console.WriteLine(d.text(4, lang));
                Console.WriteLine(d.text(5, lang));
                Console.WriteLine(d.text(6, lang));
                Gamestate.PlaceP1(1);
                Console.Clear();
                for (int i = 0; i < 9; i++)
                {
                    Gamestate.Player1out();
                    Console.WriteLine(d.text(i + 7, lang));
                    Gamestate.PlaceP1(d.place(i));
                    Console.Clear();
                }
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
                Console.WriteLine(d.text(4, lang));
                Console.WriteLine("Gebe ein, wo das Schiff plaziert werden soll und wie das orientiert sein soll. Die Syntax dafür ist \"A,2,right\". Möglich sind \"up\",\"down\",\"left\",\"right\"");
                Console.WriteLine("Fangen wir mit dem ersten X-Schiff an");
                Gamestate.PlaceP1(1);
                Console.Clear();
                Gamestate.Player1out();
                Console.WriteLine("Gebe nun die Position des zweiten X-Schiffs an");
                Gamestate.PlaceP1(1);
                Console.Clear();
                Gamestate.Player1out();
                Console.WriteLine("Gebe nun die Position des dritten X-Schiffs an");
                Gamestate.PlaceP1(1);
                Console.Clear();
                Gamestate.Player1out();
                Console.WriteLine("Gebe nun die Position des vierten X-Schiffs an");
                Gamestate.PlaceP1(1);
                Console.Clear();
                Gamestate.Player1out();
                Console.WriteLine("Gebe nun die Position des ersten XX-Schiffs an");
                Gamestate.PlaceP1(2);
                Console.Clear();
                Gamestate.Player1out();
                Console.WriteLine("Gebe nun die Position des zweiten XX-Schiffs an");
                Gamestate.PlaceP1(2);
                Console.Clear();
                Gamestate.Player1out();
                Console.WriteLine("Gebe nun die Position des dritten XX-Schiffs an");
                Gamestate.PlaceP1(2);
                Console.Clear();
                Gamestate.Player1out();
                Console.WriteLine("Gebe nun die Position des ersten XXX-Schiffs an");
                Gamestate.PlaceP1(3);
                Console.Clear();
                Gamestate.Player1out();
                Console.WriteLine("Gebe nun die Position des zweiten XXX-Schiffs an");
                Gamestate.PlaceP1(3);
                Console.Clear();
                Gamestate.Player1out();
                Console.WriteLine("Gebe nun die Position des XXXX-Schiffs an");
                Gamestate.PlaceP1(4);
                Console.Clear();
                Gamestate.Player1out();
                Console.WriteLine("\nDies sind die Schiffe. Drücke \"Enter\" um fortzufahren");
                Console.ReadLine();
                Console.Clear();
                Console.WriteLine("Spieler 2 darf nun die Schiffe platzieren.\nDrücke \"Enter\" sobald Spieler 1 den Bildschirm nicht mehr sieht");
                Console.ReadLine();
                Console.Clear();
                Gamestate.Player2out();                                                     //Printed das Board von Spieler 1
                Console.WriteLine("\nZuerst platziere die 4 X-Schiffe, dann die 3 XX-Schiffe, dann die 2 XXX-Schiffe und dann das XXXX-Schiff");
                Console.WriteLine("Gebe ein, wo das Schiff plaziert werden soll und wie das orientiert sein soll. Die Syntax dafür ist \"A,2,right\". Möglich sind \"up\",\"down\",\"left\",\"right\"");
                Console.WriteLine("Fangen wir mit dem ersten X-Schiff an\n");
                Gamestate.PlaceP2(1);
                Console.Clear();
                Gamestate.Player2out();
                Console.WriteLine("Gebe nun die Position des zweiten X-Schiffs an");
                Gamestate.PlaceP2(1);
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
                "v.1.3:\n" + 
                "\tMajor Update!\n" +
                "\t- Rewrote the gamerules\n" +
                "\t- Cleaned up a lot of spaghetticode and optimized the game a bit\n" +
                "\t- Added an icon for the game (still WIP tho)\n" +
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