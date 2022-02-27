/*using System;
using static System.Console;

namespace Estudos {
  class Program {
    static void Main(string[] args) {
      bool primo = true;
 
      Console.Write("Informe um número inteiro positivo: ");
      int number = int.Parse(Console.ReadLine());
 
      if (number < 0) 
      {
        Console.WriteLine("nao");
      }
      else if ((number == 0) || (number == 1)) 
      {
        Console.WriteLine("nao");
      }
      else if (number >= 2)
      {
        for (int i = 2; i <= (number / 2); i++) 
        {
          if (number % i == 0) 
          {
            primo = false; // recebe false
              break;
          }
        }
 
        if (primo == true) 
        {
          Console.WriteLine("sim");
        }
        else 
        {
          Console.WriteLine("nao");
        }
      }
 
      Console.WriteLine("\n\nPressione qualquer tecla para sair...");
      Console.ReadKey();
    }
  }
}*/