using SVgerman;
using SVAI7;

class UI
{
    static string end = "n";
    static AIEasy enemy = new AIEasy();
    static void Main(string[] args)
    {
        Console.WriteLine("Schiffe Versenken Console Edition");
        Console.WriteLine("---------------------------------");
        while (end == "n")
        {
            Board Gamestate = new Board();
            Console.WriteLine("Für eine neue Runde schreibe \"n\" und drücke \"Enter\"");
            Console.WriteLine("Um das Programm zu beenden drücke \"Enter\"");
            end = Console.ReadLine();
            Console.WriteLine();
            if(end != "n") break;
            Console.Clear();
            Console.WriteLine("Du kannst gegen eine AI spielen, oder gegen einen anderen Spieler");
            Console.WriteLine("1 Spieler                2 Spieler");
            string temp = Console.ReadLine();
            Console.Clear();
            if (temp == "1 Spieler")
            {
                bool gameEnd = false;
                bool won = false;
                Gamestate.Player1out();
                Console.WriteLine("\nZuerst plaziere die 2 XX-Schiffe, danach die 2 XXX-Schiffe, dann das XXXX-Schiff und das XXXXX-Schiff");
                Console.WriteLine("Gebe ein, wo das Schiff plaziert werden soll und wie das orientiert sein soll. Die Syntax dafür ist \"A,2,right\". Möglich sind \"up\",\"down\",\"left\",\"right\"");
                Console.WriteLine("Zuerst wird das erste XX-Schiff plaziert\n");
                Gamestate.PlaceP1(2);
                Console.Clear();
                Gamestate.Player1out();
                Console.WriteLine("\nGebe nun die Position des zweiten XX-Schiff ein");
                Gamestate.PlaceP1(2);
                Console.Clear();
                Gamestate.Player1out();
                Console.WriteLine("\nGebe nun die Position des ersten XXX-Schiff ein");
                Gamestate.PlaceP1(3);
                Console.Clear();
                Gamestate.Player1out();
                Console.WriteLine("\nGebe nun die Position des zweiten XXX-Schiff ein");
                Gamestate.PlaceP1(3);
                Console.Clear();
                Gamestate.Player1out();
                Console.WriteLine("\nGebe nun die Position des XXXX-Schiffs ein");
                Gamestate.PlaceP1(4);
                Console.Clear();
                Gamestate.Player1out();
                Console.WriteLine("\nGebe nun die Position des XXXXX-Schiffs ein");
                Gamestate.PlaceP1(5);
                Console.Clear();
                enemy.Place(Gamestate);
                while (gameEnd == false)
                {
                    Console.Clear();
                    Gamestate.Player2outhP1out();
                    Console.WriteLine("\nBitte gebe die Position an, wo du schießen möchtest. Die Syntax ist \"A,1\"\n");
                    Gamestate.P1shoot();
                    gameEnd = Gamestate.CheckWinP1();
                    if (gameEnd == true)
                    {
                        won = true;
                        break;
                    }
                    Console.WriteLine("\n");
                    enemy.Shoot(Gamestate);
                    gameEnd = Gamestate.CheckWinP2();
                    if (gameEnd == true) break;
                    Console.WriteLine("\n\n");
                }
                if (won == true)
                {
                    Console.WriteLine("Herzlichen Glückwunsch Spieler 1! Du hast gewonnen!\n");
                }
                else
                {
                    Console.WriteLine("Herzlichen Glückwunsch Spieler 2! Du hast gewonnen!\n");
                }
            }
            else if(temp == "2 Spieler")
            {
                
            }
        }
    }
}