using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace aula2909
{
    class Program
    {
        public static void ConsultaBD(string str)
        {    
            string strConn = "Server=localhost;Database=test;Uid=root;Pwd=";
            MySqlConnection conn = new MySqlConnection(strConn);
            MySqlCommand command = new MySqlCommand();
            command.Connection = conn;
            string n = Console.ReadLine();
            command.CommandText = str;
            conn.Open();
            command.ExecuteNonQuery();
            conn.Close();
            Console.WriteLine("Carro cadastrada. Obrigado. Vai com Deus. Boa noite/dia. Bons sonhos/dia.");
        }        
        public static void Consulta()
        {
            string str = "Consultar";
            ConsultaBD(str);
        }
        public static void Cadastro()
        {
            Console.WriteLine("Insira o Modelo do Carro");
            string modelo = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Insira a Marca do Carro");
            string marca = Console.ReadLine();
            string str = string.Format("insert into Carro (Modelo, Marca) Valus ('{0}, {1}'),", modelo, marca);
            ConsultaBD(str);
        }
        public static void Remover()
        {
            string str = "Consultar";
            ConsultaBD(str);
        }
        public static void Atualizar()
        {
            string str = "Consultar";
            ConsultaBD(str);
        }
             
        static void Main(string[] args)
        {
            Console.WriteLine("CONSULTA AO BANCO DE DADOS.");
            Console.WriteLine("ESCOLHA UMA OPÇÃO:");
            Console.WriteLine("1- Consulta");
            Console.WriteLine("2- Cadastro ");
            Console.WriteLine("3- Remover");
            Console.WriteLine("4- Atualização de dados"); 
            Console.WriteLine("5- Sair");           
            string opcao = Convert.ToString(Console.ReadLine());
              
            while(opcao != "5")
            
                {
                  switch (opcao)
                   {
                    case "1": 
                        Consulta();
                        break;
                    case "2":
                        Cadastro();
                        break;
                    case "3":
                        Remover();
                        break;
                    case "4":
                        Atualizar();
                        break;
                    case "5":
                        Console.WriteLine("Obrigado por usar nossos serviços");   
                        break;
                   
                        default:
                        Console.WriteLine("INFORMAÇÃO INCORRETA. DIGITE NOVAMENTE");
                        break;
                }               
            }
        }                      
           
    }
}
