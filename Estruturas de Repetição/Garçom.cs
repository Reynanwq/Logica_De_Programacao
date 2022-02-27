/*using System;
using static System.Console;

namespace problemas
{
    class Garçom
    {
        static void Main(string[] args) {
            int NumeroDeBandejas = int.Parse(Console.ReadLine());
            int copos = 0;

                for (int i = 0; i < NumeroDeBandejas; i++)
                {
                    string[] coluna = Console.ReadLine().Split();
                    int l = int.Parse(coluna[0]);
                    int c = int.Parse(coluna[1]);
                    if (l > c)
                    {
                        copos = copos + c;
                    }     
                }
            Console.WriteLine(copos);
                
        }
    }
}
*/