using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace LIsta_1
{
    class Program
    {
        static void Main(string[] args)
        {

            int p;
            Console.WriteLine("Digite o programa desejado, de 1 a 8: ");
            p = int.Parse(Console.ReadLine());
            if (p == 1)
            {
                Fatorial();

            }
            else if (p == 2)
            {
                sequencia();
            }
             else if (p==3)
             {
                 Funcionarios();
             }
            else if (p == 4)
            {
                PinguePongue();
            }

            
        }

        static int Fatorial()
        {
            Console.WriteLine("Digite o número desejado: ");
            int n = int.Parse(Console.ReadLine());
            int fat = n;
            if (n > 4)
            {
                n = n - 1;
                while (n > 0)
                {
                    fat = fat * n;
                    n--;

                }
                Console.WriteLine("O fatorial do número é: {0}", fat);
            }
            else
            {
                while (n > 1)
                {
                    fat = fat * (n - 1);

                    n--;

                }
                Console.WriteLine("O fatorial do número é: {0}", fat);

            }
            Console.ReadKey();


            return 0;
        }

        static int Fatoriall(int y)
        {


            int fat = y;
            if (y > 4)
            {
                y = y - 1;
                while (y > 0)
                {
                    fat = fat * y;
                    y--;

                }

            }
            else
            {
                while (y > 1)
                {
                    fat = fat * (y - 1);

                    y--;
                    Console.ReadKey();
                }

            }

            return fat;

        }

        static int sequencia()
        {
            Console.WriteLine("Digite o número desejado: ");
            int num = int.Parse(Console.ReadLine());
            int seq = 0;
            int den = 1;

            Console.WriteLine("A sequência é:");
            for (int i = 0; i <= num; i++)
            {
                den = (den * 2) + 1;
                seq = Fatoriall(i);
                Console.WriteLine(seq + "/" + den + " , ");

            }
            Console.ReadKey();
            return 0;

        }

        static int Funcionarios()
        {
            List<string> func = new List<string> (); 
            List<double> sal = new List<double> ();
            List<double> novo = new List<double> ();
            Console.WriteLine("Escreva o número de funcionários: ");
            int n = int.Parse(Console.ReadLine());
            string texto;
            int sala;
            
            double y=0;
            double por;
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Nome: ");
                texto = Convert.ToString(Console.ReadLine());
                func.Add(texto);
                Console.WriteLine("Salário: ");
                sala = int.Parse(Console.ReadLine());
                sal.Add(sala);
            }

           


            for (int j = 0; j < sal.Count; j++)
            {
                if (sal[j] < 3000)
                {
                    por = 0.25;
                    y = sal[j] + sal[j] * por;
                    novo.Add(y);
                }
                else if (sal[j] < 4000)
                {
                    por = 0.20;
                    y = sal[j] + sal[j] * por;
                    novo.Add(y);
                }

                else if (sal[j] < 5000)
                {
                    por = 0.15;
                    y = sal[j] + sal[j] * por;
                    novo.Add(y);
                }
                else if (sal[j] > 5999)
                {
                    por = 0.10;
                    y = sal[j] + sal[j] * por;
                    novo.Add(y);
                }
            }
            for (int b = 0; b < novo.Count; b++)
            {
                Console.WriteLine(func[b]+ "  Salário Antigo: " + sal[b] + "  -----------------  " + "Novo Salário: " + novo[b] );               
            }
            Console.ReadKey();
            return 0;            
        }

        static int PinguePongue ()
        {
            string x;
            int um = 0;
            int dois = 0;
            
            Console.WriteLine("Digite FIM quando acabar a partida: ");
            x = Convert.ToString(Console.ReadLine());
            while (x != "FIM")
            {
             Console.WriteLine("Digite se você é o jogador um ou dois");
            x = Convert.ToString(Console.ReadLine());
            
            if (x == "um")
            {
                um = um + 1;
                Console.WriteLine("Um ponto adicionado. Total até agora: {0}", um);
            }
            else if (x=="dois")
            {  
                dois = dois + 1;
                Console.WriteLine("Um ponto adicionado. Total até agora: {0}", dois);
            }

            }

            if (x=="FIM")
            {
                if (um>=21 && um-dois >= 2)
                {
                    Console.WriteLine("O jogador número um venceu!");
                }
                else if (dois>=21 && dois-um >= 2)
                {
                     Console.WriteLine("O jogador número dois venceu!");
                }
                else
                {
                    Console.WriteLine("O Jogo Ainda não Acabou!");
                }
                Console.ReadKey();
            }

            return 0;

        }

    }
}


