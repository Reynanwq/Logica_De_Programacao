/*using System;

namespace problemas
{
    public class Colisao
    {
        static void Main(string[] args) {
        string[] coluna = Console.ReadLine().Split();

        int xesquerda_superior1 = int.Parse(coluna[0]);
        int yesquerda_inferior1 = int.Parse(coluna[1]);
        int xdireita_superior1 = int.Parse(coluna[2]);
        int ydireita_superior1 = int.Parse(coluna[3]);

        string[] coluna02 = Console.ReadLine().Split();

        int xesquerda_inferior2 = int.Parse(coluna02[0]);
        int yesquerda_inferior2 = int.Parse(coluna02[1]);
        int xdireita_superior2 = int.Parse(coluna02[2]);
        int ydireita_superior2 = int.Parse(coluna02[3]);

        if ((xdireita_superior1 < xesquerda_inferior2) || (ydireita_superior1 < yesquerda_inferior2) || (xdireita_superior2 < xesquerda_superior1) || (ydireita_superior2 <  yesquerda_inferior1))
        {
            Console.WriteLine("0");
        } else{
            Console.WriteLine("1");
        }

    }
    }
}*/