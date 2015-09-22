using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_Exercicio_14_07_2015
{
     class Cachorro
    {
        public double _tamanhoCm;
        private string _nome;
        private double _peso;

        public void SetNome(string n)
        {

            _nome = n;          
        }

         public string GetNome()
        {

            return _nome;           
        }
        public void SetPeso(double p)
        {
            _peso = p;           
        }
         public double GetPeso()
        {

            return _peso;            
        }
        public double TamanhoMetro(double _tamanhoCm)
        {
            double m;
            return m = _tamanhoCm / 100;
        }

        public double RacaoDiariaKg()
        {
            double t;
            return t = (_peso / (_tamanhoCm/100 * _tamanhoCm/100)) / 10;      
        }
         
    }
}
