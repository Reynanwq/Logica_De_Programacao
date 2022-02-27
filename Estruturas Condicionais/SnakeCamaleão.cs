/*using System;
using static System.Console;

namespace problemas
{
    public class SnakeCamaleão
    {
        public static void Main (string[] args){
            int Q = int.Parse(ReadLine());
            int d = Q / 3;

            if (Q % 3 == 0)
            {
                WriteLine("Vermelho" + " " + d);
                WriteLine("Azul" + " " + d);
                WriteLine("Amarelo" + " " + d);
            }
            if (Q % 3 == 1) 
            {
                WriteLine("Vermelho" + " " + (d + 1));
                WriteLine("Azul" + " " + d);
                WriteLine("Amarelo" + " " + d);
            }
            if (Q % 3 == 2) 
            {
                WriteLine("Vermelho" + " " + (d + 1));
                WriteLine("Azul" + " " + (d + 1));
                WriteLine("Amarelo" + " " + d);
            }
        }
    }
}*/