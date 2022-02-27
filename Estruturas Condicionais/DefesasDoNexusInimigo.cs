/*using System;

namespace problemas
{
    public class DefesasDoNexusInimigo
    {
        public static void Main (string[] args){
            string[] coluna = Console.ReadLine().Split();
            int torresDaRota = int.Parse(coluna[0]);
            int inibidores = int.Parse(coluna[1]);
            int torresDoNexus = int.Parse(coluna[2]);

            int torresDaRota1 = (9 - torresDaRota);
            int inibidores1 = (3 - inibidores);
            int torresDoNexus1 = (2 - torresDoNexus);

            if(torresDaRota <= 9 && inibidores <= 3 && torresDoNexus < 2)
            {
                Console.WriteLine( torresDaRota1 + " " + inibidores1 + " " + torresDoNexus1 );
            }else{
                Console.WriteLine("VITORIA");   
            }
            Console.ReadKey();
        }
    }
}*/