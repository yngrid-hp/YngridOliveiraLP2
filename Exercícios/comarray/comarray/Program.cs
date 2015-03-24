using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace comarray
{
    class Program
    {
        static void Main(string[] args)
        {

            ArrayList array = new ArrayList();
            int numero = 1;
            int media = 0;
            int medio = 0;



            for (int i = numero; i != 0; i++)
            {

                Console.WriteLine("Insira o número");
                numero = int.Parse(Console.ReadLine());
                array.Add(numero);                
                media += numero;    
                medio ++;
                medio = media / medio;
                if (numero == 0)
                    
                {
                    Console.WriteLine("A Média é: {0}", medio);
                    Console.ReadKey();
                }
            }
            
        }
    }
}
