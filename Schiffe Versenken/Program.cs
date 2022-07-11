using SVgerman;
using SVAI7;

class UI
{
    static string end = "n";                //Beinhaltet, ob das Spiel beendet wurde
    static AIEasy enemy = new AIEasy();     //Initialisiert eine Einfache AI
    static void Main(string[] args)
    {
        Console.WriteLine("Schiffe Versenken Console Edition");
        Console.WriteLine("---------------------------------");
        while (end == "n")                                                                  //Beendet sich, sobald das Spiel beendet wurde
        {
            Board Gamestate = new Board();                                                  //Initialisiert ein neues Board
            Console.WriteLine("Für eine neue Runde schreibe \"n\" und drücke \"Enter\"");
            Console.WriteLine("Um das Programm zu beenden drücke \"Enter\"");
            end = Console.ReadLine();                                                       //Hier entscheidet der User, ob das Spiel beendet wird
            Console.WriteLine();
            if(end != "n") break;                                                           //Wenn der User was anderes als "n" eingegeben hat, wird das Spiel beendet
            Console.Clear();
            Console.WriteLine("Du kannst gegen eine AI spielen, oder gegen einen anderen Spieler");
            Console.WriteLine("1 Spieler                2 Spieler");
            string temp = Console.ReadLine();                                               //Der User gibt an, ob er alleine oder zu zweit spielen will
            Console.Clear();                                                                //Momentan funktioniert nur 1 Spieler
            if (temp == "1 Spieler")
            {
                bool gameEnd = false;                                                       //Beinhaltet, ob die momentane Runde beendet wurde
                bool won = false;                                                           //Beinhaltet, wer gewonnen hat. true = Spieler 1, false = Spieler 2
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
                
            }
        }
    }
}