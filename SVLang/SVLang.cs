namespace SVLang
{
    public class dict
    {
        static int[] placement = { 1, 1, 1, 2, 2, 2, 3, 3, 4 };
        static string[] germanStrings = 
        {   /*id = 0*/"Für eine neue Runde schreibe \"n\" und drücke \"Enter\"",
            /*id = 1*/"Um das Programm zu beenden drücke \"Enter\"",
            /*id = 2*/"Du kannst gegen eine AI spielen, oder gegen einen anderen Spieler",
            /*id = 3*/"1 Spieler                2 Spieler",
            /*id = 4*/"\nZuerst plaziere die 4 X-Schiffe, danach die 3 XX-Schiffe, dann die 2 XXX-Schiff und das XXXX-Schiff",
            /*id = 5*/"Gebe ein, wo das Schiff plaziert werden soll und wie das orientiert sein soll. Die Syntax dafür ist \"A,2,right\". Möglich sind \"up\",\"down\",\"left\",\"right\"",
            /*id = 6*/"Zuerst wird das erste X-Schiff plaziert\n",
            /*id = 7*/"\nGebe nun die Position des zweiten X-Schiff ein",
            /*id = 8*/"\nGebe nun die Position des dritten X-Schiff ein",
            /*id = 9*/"\nGebe nun die Position des vierten X-Schiff ein",
            /*id = 10*/"\nGebe nun die Position des ersten XX-Schiffs ein",
            /*id = 11*/"\nGebe nun die Position des zweiten XX-Schiffs ein",
            /*id = 12*/"\nGebe nun die Position des dritten XX-Schiffs ein",
            /*id = 13*/"\nGebe nun die Position des ersten XXX-Schiffs ein",
            /*id = 14*/"\nGebe nun die Position des zweiten XXX-Schiffs ein",
            /*id = 15*/"\nGebe nun die Position des XXXX-Schiffs ein",
            /*id = 16*/"\nBitte gebe die Position an, wo du schießen möchtest. Die Syntax ist \"A,1\"\n",
            /*id = 17*/"Herzlichen Glückwunsch Spieler 1! Du hast gewonnen!\n",
            /*id = 18*/"Herzlichen Glückwunsch Spieler 2! Du hast gewonnen!\n",
            /*id = 19*/"Spieler 1 darf nun die Schiffe platzieren.\nBitte drück \"Enter\", sobald Spieler 2 den Bildschirm nicht mehr sehen kann",
            /*id = 20*/"Dies sind deine Schiffe. Drücke \"Enter\" um fortzufahren",
            /*id = 21*/"Spieler 2 darf nun die Schiffe platzieren.\nDrücke \"Enter\" sobald Spieler 1 den Bildschirm nicht mehr sieht",
            /*id = 22*/"Spieler 1 darf nun schießen.\nDrücke \"Enter\" sobald Spieler 2 den Bildschirm nicht mehr sieht",
            /*id = 23*/"\nUm fortzufahren, drücke \"Enter\"",
            /*id = 24*/"Spieler 2 darf nun schießen.\nDrücke \"Enter\" sobald Spieler 1 den Bildschirm nicht mehr sieht",
            /*id = 25*/"Dein Feld:\n",
            /*id = 26*/"Gegnerisches Feld:",
            /*id = 27*/"Bitte gib eine existierende Richtung an",
            /*id = 28*/"Das passt leider nicht :/ Gib bitte ne Position an, wo der passt",
            /*id = 29*/"Hier ist leider schon ein Schiff. Bitte gib ne Position an, wo noch kein Schiff ist",
            /*id = 30*/"Hier has du schon hingeschossen. Wähle lieber ne Position, wo du noch nicht hingeschossen hast",
            /*id = 31*/"Das liegt nicht im Spielfeld, bitte wähle eine andere Position",
            /*id = 32*/"Das liegt nicht im Spielfeld, bitte wähle eine andere Zahl",
            /*id = 33*/"X-Schiffe",
            /*id = 34*/"XX-Schiffe",
            /*id = 35*/"XXX-Schiffe",
            /*id = 36*/"XXXX-Schiffe"
        };
        static string[] englishStrings =
        {
            /*id = 0*/"Type \"n\" and press \"Enter\" for a new round",
            /*id = 1*/"To quit the program press \"Enter\"",
            /*id = 2*/"Play against an AI or against a friend",
            /*id = 3*/"1 Player                2 Player",
            /*id = 4*/"\nAt first place the 4 X-Ships, afterwards the 3 XX-Ships, then the 2 XXX-Ships and finally the XXXX-Ship",
            /*id = 5*/"Please provide the origin of the ship and the direction it is facing. The syntax is \"A,2,right\". possible directions are \"up\",\"down\",\"left\",\"right\"",
            /*id = 6*/"At first we place the first X-Ship\n",
            /*id = 7*/"\nNow we place the second X-Ship",
            /*id = 8*/"\nNow we place the third X-Ship",
            /*id = 9*/"\nNow we place the last X-Ship",
            /*id = 10*/"\nNow we place the first XX-Ship",
            /*id = 11*/"\nNow we place the second XX-Ship",
            /*id = 12*/"\nNow we place the last XX-Ship",
            /*id = 13*/"\nNow we place the first XXX-Ship",
            /*id = 14*/"\nNow we place the last XXX-Ship",
            /*id = 15*/"\nNow we place the final XXXX-Ship",
            /*id = 16*/"\nPlease provide the position you want to shoot at. The syntax is \"A,1\"\n",
            /*id = 17*/"Congratulations Player 1! You have won!\n",
            /*id = 18*/"Congratulations Player 2! You have won!\n",
            /*id = 19*/"Player 1 can now place their ships.\nAs soon as player 2 can not see the screen anymore press \"Enter\"",
            /*id = 20*/"These are your Ships. To continue, press \"Enter\"",
            /*id = 21*/"Player 2 can now place their ships.\nAs soon as player 1 can not see the screen anymore press \"Enter\"",
            /*id = 22*/"Player 1 can now shoot.\nAs soon as player 2 can not see the screen anymore press \"Enter\"",
            /*id = 23*/"\nTo continue, press \"Enter\"",
            /*id = 24*/"Player 2 can now shoot\nAs soon as player 2 can not see the screen anymore press \"Enter\"",
            /*id = 25*/"Your board:\n",
            /*id = 26*/"Enemy board:",
            /*id = 27*/"Please provide an existing direction",
            /*id = 28*/"This wont fit there :/ Please enter a position where the ship will fit",
            /*id = 29*/"You have already a ship here. Please enter a position where is no ship present",
            /*id = 30*/"You have already shot here. It would be better to shoot at a position you have not shot yet",
            /*id = 31*/"This isnt on the board. Please choose another target",
            /*id = 32*/"This number isnt on the board. Please provide a valid number",
            /*id = 33*/"X-Ships",
            /*id = 34*/"XX-Ships",
            /*id = 35*/"XXX-Ships",
            /*id = 36*/"XXXX-Ships"
        };
        static int?[] color = { 0, 1, 2, null, 3, 4, 3, 4, 3, 4, 3, 4, 3, 4, 3, 4, 3, 4, 3, 4, 3, 4, 3, 4, 5, 5 };
        static char[] letters = { /*0*/'O', /*1*/'X', /*2*/'K', /*3*/' ', /*4*/'1', /*5*/'2', /*6*/'3', /*7*/'4', /*8*/'5', /*9*/'6', /*10*/'7', /*11*/'8', /*12*/'9', /*13*/'1', /*14*/'A', /*15*/'B', /*16*/'C', /*17*/'D', /*18*/'E', /*19*/'F', /*20*/'G', /*21*/'H', /*22*/'I', /*23*/'J', /*24*/'M', /*25*/'O' };

        public int place(int p)
        {
            return placement[p];
        }

        public string text (int p, string l)
        {
            switch (l)
            {
                case "Deutsch":
                    return germanStrings[p];
                case "deutsch":
                    return germanStrings[p];
                case "English":
                    return englishStrings[p];
                case "english":
                    return englishStrings[p];
                default:
                    return null;
            }
        }

        public char lett(int p)
        {
            return letters[p];
        }

        public int? col(int p)
        {
            return color[p];
        }
    }
}