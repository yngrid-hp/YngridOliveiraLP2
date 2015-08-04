using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aula0804
{
    class Nome
    {

       
        private string _nome;
        
        public string Nome
        {
            get
            {
                
                return _nome;
            }
            set
            
            {
              string n = _nome;
              string [] partes = n.Split(' ');
              _nome = partes[1] + ',' + partes[0];
            }

        }
        private string _cpf;

         public string Cpf
        {
            get
            {
                
                return _cpf;
            }
            set
            
            {

             string p = _cpf.Substring(0, 3);
             string q = _cpf.Substring(3, 3);
             string r = _cpf.Substring(6, 3);
             string s = _cpf.Substring(7, 2);
             _cpf = p + '.' + q + '.' + r + '-' + s;
            }

        }
        private DateTime _dataNasc;


        public DateTime Data
       {
    
            get
            {

                return _dataNasc;
            }
            set

            {
                DateTime t;
                t = _dataNasc;
            }

        }

        public string _placaCarro;

        public string Placa
        {

            get
            {

                return _placaCarro;
            }
            set
            {
                string x = _placaCarro;
                string numero;
                string letra;

                 letra = x.Substring(0, 3);
                 numero = x.Substring(4, 3);
                 _placaCarro =  letra + '-' + numero;
            }

        }
        public string _creditos;

        public string Creditos
        {

            get
            {

                return _creditos;
            }
            set
            {
                string c = _creditos;
                string numero1;
                string numero2;

                numero1 = c.Substring(0, 2);
                numero2 = c.Substring(3, 2);
                _creditos = "R$" + numero1  + ',' + numero2;
            }

        }
        


















    }
}
