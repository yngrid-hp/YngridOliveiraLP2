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
        public static void Main(string[] args)
        {

            int p;
            Console.WriteLine("Digite o programa desejado, de 1 a 8: ");
            p = int.Parse(Console.ReadLine());
            if (p == 1)
            {
                Ex1();
            }
            else if (p == 2)
            {
                Ex2();
            }
            else if (p == 3)
            {
                Ex3();
            }
            else if (p == 4)
            {
                Ex4();
            }
            else if (p == 5)
            {
                Ex5();
            }
            else if (p == 6)
            {
                Ex6();
            }
            else if (p == 7)
            {
                Ex7();
            }
            else if (p == 8)
            {
                Ex8();
            }

        }

        static void Ex1()
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
        static void Ex2()
        {
            Console.WriteLine("Digite o número desejado: ");
            int num = int.Parse(Console.ReadLine());
            int seq = 0;
            int den = 1;
            double result = 0;

            for (int i = 0; i < num; i++)
            {
                den = (den * 2) + 1;
                result = Fatoriall(i) / den;
                Console.Write(seq);
            }
            Console.ReadKey();

        }
        static void Ex3()
        {
            List<string> func = new List<string>();
            List<double> sal = new List<double>();
            List<double> novo = new List<double>();
            Console.WriteLine("Escreva o número de funcionários: ");
            int n = int.Parse(Console.ReadLine());
            string texto;
            int sala;

            double y = 0;
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
                Console.WriteLine(func[b] + "  Salário Antigo: " + sal[b] + "  -----------------  " + "Novo Salário: " + novo[b]);
            }
            Console.ReadKey();

        }

        static void Ex4()
        {
            string x;
            int um = 0;
            int dois = 0;

            while (dois < 21 && um < 21)
            {
                Console.WriteLine("Digite se você é o jogador um ou dois");
                x = Convert.ToString(Console.ReadLine());
                if (x == "um")
                {
                    um = um + 1;
                    Console.WriteLine("Um ponto adicionado. Total até agora: {0}", um);
                }
                else if (x == "dois")
                {
                    dois = dois + 1;
                    Console.WriteLine("Um ponto adicionado. Total até agora: {0}", dois);
                }
            }

            if (um == 21 && um - dois >= 2)
            {
                Console.WriteLine("O jogador número um venceu!");
            }
            else if (dois == 21 && dois - um >= 2)
            {
                Console.WriteLine("O jogador número dois venceu!");
            }

            Console.ReadKey();



        }



        static void Ex5()
        {
            int dis = 0;
            int comb = 0;
            int media;
            int totdis = 0;
            int totcomb = 0;

            while ((totdis < 600) || (totcomb < 50))
            {
                Console.Write("DIGITE A DISTÂNCIA EM KM: ");
                dis = int.Parse(Console.ReadLine());
                totdis = totdis + dis;
                Console.Write("DIGITE O COMBUSTÍVEL CONSUMIDO: ");
                comb = int.Parse(Console.ReadLine());
                totcomb = totcomb + comb;
            }


            if (totdis == 600)
            {
                Console.Write("O carro chegou ao seu destino! ");
                media = totdis / totcomb;
                Console.Write("Média: {0}Km/L. ", media);
                Console.ReadKey();
            }

            else if (totcomb == 50)
            {
                media = totdis / totcomb;
                Console.Write("O carro parou antes de chegar por falta de combustível!");
                Console.Write("Média: {0}Km/l. ", media);
                Console.ReadKey();
            }
        }

        static void Ex6()
        {
            List<string> nome = new List<string>();
            List<int> altura = new List<int>();
            string y = " ";
            int z;
            int max = 0;
            int i = 1;
            int k = 0;
            int MAXY = 0;
            while (y != "FIM")
            {

                Console.WriteLine("Digite o nome da modelo: " + "     ");
                y = Convert.ToString(Console.ReadLine());
                nome.Add(y);
                Console.WriteLine("Digite a altura: " + "     ");
                z = int.Parse(Console.ReadLine());
                altura.Add(z);

            }

            for (int f = 0; f < altura.Count; f++)
            {
                if (altura[f] > max)
                {
                    max = altura[f];
                }
            }


            Console.Write("As maiores alturas são {0}", max);
            altura.Remove(max);

            for (int u = 0; u < altura.Count; u++)
            {
                if (altura[u] > MAXY)
                {
                    k = altura[u];
                }
            }

            for (int s = 0; s < altura.Count; s++)
            {
                if (altura[s] == max)
                {
                    i++;
                }
            }
            for (int T = 0; T < altura.Count; T++)
            {
                if (altura[T] == k)
                {
                    i = i + 1;
                }

            }
            Console.Write(" e {0}. {1} Modelos as possuem", k, i);
            Console.ReadKey();
        }

        static void Ex7()
        {
            int prova = 0;
            int qtdnadador=1;
            string nomenadador;
            string clube;
            int classi;
            double tempo;
            int clubea = 0;
            int clubeb=0;
            int Atot =0;
            int Btot=0;
            
            for (int i = prova; i != 999 && qtdnadador!= 0; i++)
            {
                Console.Write("Digite o número da prova: ");
                prova = int.Parse(Console.ReadLine());
                Console.Write("Digite a quantidade de nadadores da prova: ");
                qtdnadador = int.Parse(Console.ReadLine());

                for (int j = 0; j <qtdnadador; j++)
                {
                
                Console.Write("Digite os nomes dos nadadores: ");
                nomenadador = Convert.ToString(Console.ReadLine());
                Console.Write("Digite o  clube de {0}: ", nomenadador);
                clube = Convert.ToString(Console.ReadLine());   
                Console.Write("Digite a classificação de {0}: ", nomenadador);
                classi = int.Parse(Console.ReadLine());

                if (classi == 1 && clube == "a")
                {
                    clubea = clubea + 9;
                }
                else if (classi == 1 && clube == "b")
                {
                    clubeb = clubeb + 9;
                }
                else if (classi == 2 && clube == "a")
                {
                    clubea = clubea + 6;
                }
                else if (classi == 2 && clube == "b")
                {
                    clubeb = clubeb + 6;
                }
                else if (classi == 3 && clube == "a")
                {
                    clubea = clubea + 4;
                }
                else if (classi == 3 && clube == "b")
                {
                    clubeb = clubeb + 4;
                }
                else if (classi == 4 && clube == "a")
                {
                    clubea = clubea + 3;
                }
                else if (classi == 4 && clube == "b")
                {
                    clubeb = clubeb + 3;
                }
                Console.Write("Digite o tempo de {0}: " , nomenadador);
                tempo = double.Parse(Console.ReadLine());
                Atot = Atot + clubea;
                Btot = Btot + clubeb;
                }
                Console.WriteLine("Na prova {0}, o clube A obteve {1} pontos, e o clube B obteve {2} pontos." + "      ", prova, clubea, clubeb);
                clubea = 0;
                clubeb = 0;
            }

            if (Atot>Btot)
            {
                Console.WriteLine("O clube A venceu! Parabéns!");
            }
            else if (Btot == Atot)
            {
                Console.WriteLine("Houve empate entre o clube A e o clube B. ");
            }
            else
            {
                Console.WriteLine("O clube B venceu! Parabéns!");
            }
            Console.ReadKey();
        }


        static void Ex8()
        {
            int n;
            int result=0;
            Console.WriteLine("Digite o número desejado: ");
            n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                result = result + i;
            }
            Console.WriteLine("Soma: {0} ", result);
            Console.ReadKey();
        }
    }
}

