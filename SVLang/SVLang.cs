namespace SVLang
{
    public class dict
    {
        public static int[] placement = { 1, 1, 1, 2, 2, 2, 3, 3, 4 };
        public static string[] germanStrings = 
        {   "Für eine neue Runde schreibe \"n\" und drücke \"Enter\"",
            "Um das Programm zu beenden drücke \"Enter\"",
            "Du kannst gegen eine AI spielen, oder gegen einen anderen Spieler",
            "1 Spieler                2 Spieler",
            "\nZuerst plaziere die 4 X-Schiffe, danach die 3 XX-Schiffe, dann die 2 XXX-Schiff und das XXXX-Schiff",
            "Gebe ein, wo das Schiff plaziert werden soll und wie das orientiert sein soll. Die Syntax dafür ist \"A,2,right\". Möglich sind \"up\",\"down\",\"left\",\"right\"",
            "Zuerst wird das erste X-Schiff plaziert\n",
            "\nGebe nun die Position des zweiten X-Schiff ein",
            "\nGebe nun die Position des dritten X-Schiff ein",
            "\nGebe nun die Position des vierten X-Schiff ein",
            "\nGebe nun die Position des ersten XX-Schiffs ein",
            "\nGebe nun die Position des zweiten XX-Schiffs ein",
            "\nGebe nun die Position des dritten XX-Schiffs ein",
            "\nGebe nun die Position des ersten XXX-Schiffs ein",
            "\nGebe nun die Position des zweiten XXX-Schiffs ein",
            "\nGebe nun die Position des XXXX-Schiffs ein"
        };

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
    }
}