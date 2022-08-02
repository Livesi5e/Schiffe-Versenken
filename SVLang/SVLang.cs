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
            /*id = 20*/"Dies sind deine Schiffe. Drücke\"Enter\" um fortzufahren",
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
        static int?[] color = { 0, 1, 2, null, 3, 4, 3, 4, 3, 4, 3, 4, 3, 4, 3, 4, 3, 4, 3, 4, 3, 4, 3, 4, 5, 5 };
        static char[] letters = { 'O', 'X', 'K', ' ', '1', '2', '3', '4', '5', '6', '7', '8', '9', '1', 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'M', 'O' };

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