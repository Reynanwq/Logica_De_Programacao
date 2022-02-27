/*using System;
using static System.Console;

namespace problemas
{
    public class MissoesJediORetorno
    {
        public static void Main(string[] arg){
            string[] coluna = Console.ReadLine().Split();
            int N = int.Parse(coluna[0]);
            int X = int.Parse(coluna[1]);
            int XPmin = int.Parse(coluna[2]);
            for (int i = 0; i < N; i++)
            {
                string[] coluna2 = Console.ReadLine().Split();
                int XP = int.Parse(coluna2[0]);
                int Q = int.Parse(coluna2[1]);
                if (XP >= XPmin)
                {
                    XP = XP + X;
                    Q = Q + 1;
                    WriteLine(XP + " " + Q);
                } else{
                    WriteLine(XP + " " + Q);
                }
            }
        }

    }
}*/