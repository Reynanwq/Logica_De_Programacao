/*using System;

namespace problemas
{
    public class BitsTrocados
    {
        public static void Main (string[] args) {
            int n = 0;
            while (true)
            {
                int v = int.Parse(Console.ReadLine());
                if (v == 0)
                {
                    break;
                }
                int i = 0;
                int j = 0;
                int k = 0;
                int l = 0;

                while (v > 0)
                {
                    if (v >= 50)
                    {
                        v = v - 50;
                        i = i + 1;
                    }
                    else if (v >= 10)
                    {
                        v = v - 10;
                        j = j + 1;
                    }
                    else if (v >= 5)
                    {
                        v = v - 5;
                        k = k + 1;
                    }
                    else if (v >= 1)
                    {
                        v = v - 1;
                        l = l + 1;
                    }
                }
                n = n + 1;
                Console.WriteLine("Teste " + n);
                Console.WriteLine(i + " " + j + " " + k + " " + l);
                Console.WriteLine("\n");
            }

        }
    }
}*/