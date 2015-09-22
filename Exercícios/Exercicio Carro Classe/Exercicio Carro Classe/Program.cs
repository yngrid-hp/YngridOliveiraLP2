using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace carro
{
    class Program
    {
        static void Main(string[] args)
        {
            Carro c1 = new Carro();
            c1.placa = "ABC-9999";
            c1.modelo = "Uno";
            c1.consumoKmL = 10.3;
            c1.qtdCombustivelL = 22.8;

            Carro c2 = new Carro();
            c2.placa = "BLB-2995";
            c2.modelo = "Santana";
            c2.consumoKmL = 15.2;

            c2 = c1;
            /* c1.modelo = "Opala";
            c2.modelo = "Ka"; // Muda o modelo do c1 também, já que c2 passa a apontar para o objeto que c1 já apontava//
            Console.WriteLine(c1.modelo);// Mesmo carro, mesmo modelo//
            Console.WriteLine(c2.modelo);*/

            Console.WriteLine(c2.AutonomiaKm());
            Console.WriteLine("{0:0.00} Km", c2.AutonomiaKm());
            Console.WriteLine("Autonomia: {0:0.00} Km", c2.AutonomiaKm());//duas casas decimais
            Console.WriteLine("{0:0.0000} Km", c2.AutonomiaKm());

        }
    }
}

