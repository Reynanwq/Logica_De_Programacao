/*using System;
using static System.Console;

namespace problemas
{
    public class PuDean
    {
        public static void Main (string[] arg){
            string[] coluna = Console.ReadLine().Split();
            int c = int.Parse(coluna[0]);
            int o = int.Parse(coluna[1]);
            int l = int.Parse(coluna[2]);
            int x = int.Parse(coluna[3]);

            c = (c / 4);
            o = (o / 8);
            l = (l / 2);

            int menor = c;            
            int N;

            if (menor > o)
            {
                menor = o;
            }
            if (menor > l)
            {
                menor = l;
            }
            if (menor > x)
            {
                menor = x;
            }
            N = (menor * 1259);
            int H = (N / 3600);
            int SegundosRestantes = (N % 3600);
            int M = (SegundosRestantes / 60);
            int S = (N % 60);

            WriteLine(H + " " + "h" + " " + M + " " + "m" + " " + S + " " + "s");
            //WriteLine(Math.Min(c, o));

        }
    }
}*/