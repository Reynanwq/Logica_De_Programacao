/*using System;
using static System.Console;

namespace problemas
{
    public class BatalhaPokémon
    {
        public static void Main (string[] arg){
            string[] coluna = Console.ReadLine().Split();
            int E = int.Parse(coluna[0]);
            int P = int.Parse(coluna[1]);
            int D = 0;

            while(E > 0 && P > 0)
            {
                E = E - P;
                P = P - 1;
                D = D + 1;
            }
            if(E <= 0)
            {
                WriteLine(D);
            } else{
                WriteLine("F");
            }

        }
    }
}*/