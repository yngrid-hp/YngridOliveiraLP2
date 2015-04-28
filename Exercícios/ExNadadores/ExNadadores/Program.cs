using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExNadadores
{
    class Program
    {
        static void Main(string[] args)
        {

            /* Uma Competição de Natação ESTÁ dividida em 3 Provas.
             * Nessa Competição estao Inscritos 5 Nadadores, e de Todos os Nadadores participam de Todas As Provas.
             * FACA UM Programa that leia OS Resultados de Cada prova - O Tempo de Cada nadador na prova - e determinar:
             * 
             * 1) O nadador Campeão (menor ritmo total)
             * 2) O nadador vencedor de Cada prova (menor ritmo na prova)
             * 
             * O Programa comeca com a Leitura dos nomos dos 5 Participantes. Em SEGUIDA, rápido Você DEVE LER OS tempos de Cada prova
             * (SEJA OU, OS tempos de Cada nadador da prova) Todas Pará como Segundos EM provas.O Tempo e Dado, com Precisão de Duas casas decimais.
             * 
             * Veja o Exemplo de entrada no Quadro:
             * 
             * 
             * */
            string[] nomes = new string[5];
            int[,] nadadoreprova = new int[5, 3];
            float tempo;
            string nome;
            float melhortempo = -16;
            int melhor = 0;
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Digite os nomes");
                nome = Convert.ToString(Console.ReadLine());
                nomes[i] = nome;
            }

            for (int j = 0; j < 3; j++)
            {
                Console.WriteLine("Digite as notas da prova {0} :", j + 1);
                for (int y = 0; y < 5; y++)
                {
                    tempo = float.Parse(Console.ReadLine());
                    tempo = nadadoreprova[y, j];

                }

            }
            for (int a = 0; a < 3; a++)
            {
                for (int x = 0; x < 5; x++)
                {
                    if (nadadoreprova[x, a] > melhortempo)
                    {
                        nadadoreprova[x, a] = melhor;
                        melhortempo = melhor;


                    }
                }
                Console.Write("{0} Ganhou a {1} prova" + "   ", nomes[a], a);
            }

        }
    }
}