using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace semarray
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Bem vindo ao calculador de médias :D , insira 0 a qualquer momento para sair");
            int numero = 0;
            int media = 0;

            for (int i = 1; i != 0; i++)
            {
                Console.WriteLine("Insira o número desejado");
                numero = int.Parse(Console.ReadLine());

                media = (media + numero) / i;
                if (numero == 0)
                {
                    Console.Write("A média dos números é ;", media);
                    Console.ReadKey();
                   
                }

            }  
        }
    }
}
