using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using System.Threading.Tasks;

namespace Exercicios01Vogais
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("VOGAIS");

            ArrayList texto = new ArrayList(); 
             int conta = 0;

            Console.WriteLine("Digite o texto: ");
            texto.Add(Convert.ToString(Console.ReadLine()));

            for (int i = 0; i < texto.Count; i++)
            {
                if (texto[] == "a")
                {
                    conta = conta+1 ;
                }

                else if (texto[] == "e")
                {
                    conta = conta+1 ;
                }

                else if (texto[] == "i")
                {
                    conta = conta+1 ;
                }

                else if (texto[] == "o")
                {
                    conta = conta+1 ;
                }

                else if (texto[] == "u")
                {
                    conta = conta+1 ;
                }

                else 
                {
                    Console.Write("Não há vogais no seu texto!");
                }
            }

            Console.Write("O texto Possui {0} vogais", conta);
            Console.ReadKey();
        }
    }
}
