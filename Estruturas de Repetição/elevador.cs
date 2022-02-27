/*using System;

namespace problemas
{
    public class elevador
    {
        static void Main(string[] args) 
        {
            string[] coluna = Console.ReadLine().Split();
            int n = int.Parse(coluna[0]);
            int c = int.Parse(coluna[1]);

            int rm = 0;
            string ex = "N";
            for (int i = 0; i < n; i++)
            {
                string[] coluna2 = Console.ReadLine().Split();
                int s = int.Parse(coluna2[0]);
                int e = int.Parse(coluna2[1]);

                rm = rm - s;
                rm = rm - e;

                if (rm > c)
                {
                    ex = "S";
                }
            }
            Console.WriteLine(ex);

        }

    }
}
*/