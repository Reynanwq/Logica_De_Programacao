/*using System;
using static System.Console;

namespace problemas
{
    public class NivelDeMaestria
    {
        public static void Main (string[] arg){
            string[] coluna = Console.ReadLine().Split();
            int n1 = int.Parse(coluna[0]);
            int n2 = int.Parse(coluna[1]);
            int n3 = int.Parse(coluna[2]);
            int n4 = int.Parse(coluna[3]);
            int n5 = int.Parse(coluna[4]);
            int n6 = int.Parse(coluna[5]);

            int s = (n1 + n2 + n3 + n4 + n5 + n6);

            if (s >= 250)
            {
                WriteLine("S+");
            }else if (s >= 200)
            {
                WriteLine("S");
            }else if (s >= 180)
            {
                WriteLine("S-");
            }else if (s >= 150)
            {
                WriteLine("A+");
            }else if (s >= 100)
            {
                WriteLine("A");
            }else if (s >= 80)
            {
                WriteLine("A-");
            }else if (s >= 60)
            {
                WriteLine("B+");
            } else if (s >= 40)
            {
                WriteLine("B");
            }else{
                WriteLine("B-");
            }
        }         
    }
}*/