using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace carro
{
    public class Carro
    {
        public string placa;
        public string modelo;
        public double consumoKmL;
        public double qtdCombustivelL;

        public double AutonomiaKm() // Método. Esse não tem parâmetro porque não precisa de nenhuma outra informação
        {
            double autonomia = consumoKmL * qtdCombustivelL;
            return autonomia;

        }




    }
}
