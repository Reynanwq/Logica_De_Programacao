/*using System;

namespace problemas
{
    public class Listas
    {
        public static void Main(string[] args){
            List<int> valores = new List<int>();

            valores.Add(16); //metodo add insere elementos no final da lista
            valores.Add(18);
            valores.Add(23);
            valores.Add(12);
            int[] numeros = new int[] { 32, 12, 7, 20};
            valores.AddRange(numeros);

            valores.Insert(1, 13); //add elem 13 na 1° psoção da lista
            valores.Remove(12); //remove o elem 12 da lista 
            valores.RemoveAt(3); //remover pela posição
            
            int valorProcurado = 50;
            bool valorExiste;
            valorExiste = valores.Contains(valorProcurado); //verificar se existe na lista
            if (valorExiste)
            {
                Console.WriteLine("Valor encontrado!");
            } else{
                Console.WriteLine("Valor não encontrado");
            }

            valores.Sort(); //ordenar

            Console.WriteLine("A lista possui " + valores.Count() + " elementos");

            foreach (int item in valores)
            {
                Console.WriteLine(item.ToString());
            }
            Console.ReadLine();
        }
    }
}*/