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
            Console.WriteLine("Please Select your Language:\n\nDeutsch\n");
            lang = Console.ReadLine();
            Gamestate.lang = lang;
            reset();
            Console.WriteLine(d.text(0, lang));
            Console.WriteLine(d.text(1, lang));
            end = Console.ReadLine();                                                       //Hier entscheidet der User, ob das Spiel beendet wird
            Console.WriteLine();
            if(end != "n") break;
            reset();
            Console.WriteLine(d.text(2, lang));
            Console.WriteLine(d.text(3, lang));
            string temp = Console.ReadLine();                                               //Der User gibt an, ob er alleine oder zu zweit spielen will
            reset();                                                                        //Der zweite Spieler beim Multiplayer spielt noch nach alten Platzierungsregeln
            if (temp == "1 Spieler")
            {
                AIEasy enemy = new AIEasy();                                                //Initialisiert eine Einfache AI
                bool gameEnd = false;                                                       //Beinhaltet, ob die momentane Runde beendet wurde
                bool won = false;                                                           //Beinhaltet, wer gewonnen hat. true = Spieler 1, false = Spieler 2
                Gamestate.Player1out();                                                     //Printed das Board von Spieler 1
                Console.WriteLine(d.text(4, lang));
                Console.WriteLine(d.text(5, lang));
                Console.WriteLine(d.text(6, lang));
                Gamestate.PlaceP1(1, 0);
                reset();
                for (int i = 0; i < 9; i++)
                {
                    Gamestate.Player1out();
                    Console.WriteLine(d.text(i + 7, lang));
                    Gamestate.PlaceP1(d.place(i), i + 1);
                    reset();
                }
                enemy.Place(Gamestate);
                while (gameEnd == false)
                {
                    reset();
                    Gamestate.Player2outhP1out();
                    Console.WriteLine(d.text(16, lang));
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
                    Console.WriteLine(d.text(18, lang));
                }
                else
                {
                    Console.WriteLine(d.text(18, lang));
                }
            }
            else if(temp == "2 Spieler")                                                    //WIP für Mehrspieler Modus
            {
                bool gameEnd = false;
                bool won = false;
                Console.WriteLine(d.text(19, lang));
                Console.ReadLine();
                reset();
                Gamestate.Player1out();                                                     //Printed das Board von Spieler 1
                Console.WriteLine(d.text(4, lang));
                Console.WriteLine(d.text(5, lang));
                Console.WriteLine(d.text(6, lang));
                Gamestate.PlaceP1(1, 0);
                reset();
                for (int i = 0; i < 9; i++)
                {
                    Gamestate.Player1out();
                    Console.WriteLine(d.text(i + 7, lang));
                    Gamestate.PlaceP1(d.place(i), i + 1);
                    reset();
                }
                Gamestate.Player1out();
                Console.WriteLine(d.text(20, lang));
                Console.ReadLine();
                reset();
                Console.WriteLine(d.text(21, lang));
                Console.ReadLine();
                reset();
                Gamestate.Player2out();                                                     //Printed das Board von Spieler 1
                Console.WriteLine(d.text(4, lang));
                Console.WriteLine(d.text(5, lang));
                Console.WriteLine(d.text(6, lang));
                Gamestate.PlaceP2(1, 0);
                reset();
                for (int i = 0; i < 9; i++)
                {
                    Gamestate.Player2out();
                    Console.WriteLine(d.text(i + 7, lang));
                    Gamestate.PlaceP2(d.place(i), i + 1);
                    reset();
                }
                Gamestate.Player2out();
                Console.WriteLine(d.text(20, lang));
                Console.ReadLine();
                reset();
                while(gameEnd == false)
                {
                    Console.WriteLine(d.text(22, lang));
                    Console.ReadLine();
                    reset();
                    Gamestate.Player2outhP1out();
                    Console.WriteLine(d.text(16, lang));
                    Gamestate.P1shoot();
                    if (Gamestate.CheckWinP1()) { won = true; break; }
                    reset();
                    Gamestate.Player2outhP1out();
                    Console.WriteLine(d.text(23, lang));
                    Console.ReadLine();
                    reset();
                    Console.WriteLine(d.text(24, lang));
                    Console.ReadLine();
                    reset();
                    Gamestate.Player1outhP2out();
                    Console.WriteLine(d.text(16, lang));
                    Gamestate.P2shoot();
                    if (Gamestate.CheckWinP2()) break;
                    reset();
                    Gamestate.Player1outhP2out();
                    Console.WriteLine(d.text(23, lang));
                    Console.ReadLine();
                    reset();
                }
                reset();
                if (won)
                {
                    Console.WriteLine(d.text(17, lang));
                }
                else
                {
                    Console.WriteLine(d.text(18, lang));
                }
                Console.WriteLine(d.text(23, lang));
                Console.ReadLine();
            }
        }
        if(end == "changelog")
        {
            reset();
            Console.WriteLine
            (
                "Changelog:\n" +
                "v.1.3:\n" + 
                "\tMajor Update!\n" +
                "\t- Rewrote the gamerules\n" +
                "\t- Cleaned up a lot of spaghetticode and optimized the game a bit\n" +
                "\t- Added an icon for the game (still WIP tho)\n" +
                "\t- Added the beginning for multiple Language support (English may be supportet in future versions)\n" +
                "\t- You can now see the ammount of ships present on the board beneath it\n" +
                "\n\tBugfixes:\n" +
                "\t- Fixed a bug, which crashed the game when trying to place a ship in I,8 or lower\n" +
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
            reset();
            end = "n";
            Main(args);
        }
    }

    static void reset()
    {
        Console.Clear();
        Console.WriteLine("Schiffe Versenken Console Edition");
        Console.WriteLine("---------------------------------\n");
    }
}