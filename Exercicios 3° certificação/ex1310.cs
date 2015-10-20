using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;


namespace Ex13102015
{
    class Program
    {

        
                
        public static void Cadastro()
        {    
            Console.WriteLine("Insira o nome da pessoa");
            string nome = Console.ReadLine();
            Console.WriteLine("Insira o sobrenome");
            string sobrenome = Console.ReadLine();
            Console.WriteLine("Insira o Peso");
            double peso = double.Parse(Console.ReadLine());
            Console.WriteLine("Insira a altura");
            double altura = double.Parse(Console.ReadLine());
            Console.WriteLine("Insira o telefone");
            int telefone = int.Parse(Console.ReadLine());
            string str = string.Format("new CultureInfo('en') insert into Pessoa (NOME, SOBRENOME, PESO, ALTURA, TELEFONE) Valus ('{0}, {1}, {2}, {3}, {4}, {5}'),", nome, sobrenome, peso, altura, telefone);
            
        }

        public static void ConsultaComId()
        {
            Console.WriteLine("insira o id:");
            int id = int.Parse(Console.ReadLine());
            string str = string.Format("Select {0} into id FROM Pessoa", id);

        }
        public static void ConsultaComNome()
        {
            Console.WriteLine("insira o nome:");
            string nome = Console.ReadLine();
            string str = string.Format("Select {0} into Nome FROM Pessoa", nome);

        }
        
        static void Main(string[] args)
        {


            Console.WriteLine("Insira 1 para cadastrar, 2 para consultar e 0 para saír: ");
            int option = int.Parse(Console.ReadLine());

          while(option != 0)
          {

          
              if (option==1)
	          {
                   Cadastro();  		 
	          }
              else
               {
                 Console.WriteLine("Insira 1 para pesquisar por id e 2 para pesquisar por nome");
                 int num = int.Parse(Console.ReadLine());
                 if (num == 1)
                 {
                     ConsultaComId();
                 }
                 else ConsultaComNome();

              }


        }  
      }
          public void Bloco()
          {
            string strConn = "Server=localhost;Database=test;Uid=root;Pwd=";
            MySqlConnection conn = new MySqlConnection(strConn);
            MySqlCommand command = new MySqlCommand();
            command.Connection = conn;
            string n = Console.ReadLine();
            
            if (option == 1)
            {    command.CommandText = str;
                 conn.Open();
                 command.ExecuteNonQuery();
                
            }
        }

    


        }
    }
}
