/*using System;

namespace problemas
{
    public class EmBuscaDaEsmeralda
    {
        public static void Main(){
            int n = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());

            List<int> valores = new List<int>();
            int[] numeros = new int[] { 1, 2, 3, 4, 5, 6, 7, 8};
            //int[] numeros = new int[] { 12, 1, 4, 7, 9, 8, 1, 2, 3, 90 };
            valores.AddRange(numeros);

            bool valorExiste;
            valorExiste = valores.Contains(c);
            if (valorExiste)
            {
                Console.WriteLine(c);
            } else{
                Console.WriteLine("-1");
            }


        }
    }
}*/