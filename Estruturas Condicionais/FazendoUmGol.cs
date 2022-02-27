/*using System;
using static System.Console;

namespace problemas
{
    public class FazendoUmGol
    {
        public static void Main (string[] arg) {
            string[] coluna = ReadLine().Split();
            string z = (coluna[0]);
            string g = (coluna[1]);

            string[] coluna2 = ReadLine().Split();
            string d = (coluna2[0]);
            string c = (coluna2[1]);

            if (z != d)
            {
                WriteLine("Bloqueado");
            }
            if (z == d)
            {
                WriteLine("Driblado");
            }
            if (z == d && c != g)
            {
                WriteLine("...e o goleiro pega");
            }
            if (z == d && c == g)
            {
                WriteLine("Gol");
            }
        }
    }
}*/