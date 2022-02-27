/*using System;
using static System.Console;

namespace problemas
{
    class Bafo {
        static void Main(string[] args) {
            int n = 1;
            for (int j = 0; j < 10000000; j++)
            {                
                int r = int.Parse(Console.ReadLine());
                if (r == 0)
                {
                    break;
                }

                int aldo = 0; //fig number
                int beto = 0; //fig number

                for (int i = 0; i < r; i++)
                {
                    string[] coluna = Console.ReadLine().Split();
                    int a = int.Parse(coluna[0]);
                    int b = int.Parse(coluna[1]);

                    aldo = aldo + a;
                    beto = beto + b;
                }
                Console.WriteLine("Teste " + n);
                if (aldo > beto)
                {
                    Console.WriteLine("Aldo");
                }    
                else
                {
                    Console.WriteLine("Beto");
                }
                n = n + 1;
            }  Console.WriteLine("\n");
        }

    }
}*/