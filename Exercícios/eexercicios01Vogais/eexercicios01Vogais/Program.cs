using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eexercicios01Vogais
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("CONTADOR DE VOGAIS");
            Console.WriteLine();

            string texto;
            int conta = 0;
            string vogal = "áéíóúaeiouAEIOUÁÉÍÓÚàÀ";

            Console.WriteLine("Digite seu texto aqui ->");
            texto = Convert.ToString(Console.ReadLine());

            for (int i = 0; i < texto.Length; i++)
            {
                for (int y = 0; y < vogal.Length; y++)
                {
                    if (texto[i]==vogal[y])
                    {
                        conta+=1 ;
                    }
                }
            }

            if (conta==0)
            {
                Console.WriteLine("O texto inserido não possui vogais!");
            }
            if (conta == 1)
            {
                Console.WriteLine("O texto inserido possui 1 vogal.");
            }
            else
            {
                Console.WriteLine("O texto possui {0} vogais.", conta);
            }
            Console.ReadKey();










































        }
    }
}
