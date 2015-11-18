using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aulaa03112015
{
    class Program
    {
        static void Main(string[] args)
        {
            List<ContaPupanca> clientep = new List<ContaPupanca>();
            List<ContaEspecial> clientee = new List<ContaEspecial>();

            Console.WriteLine("Escolha o tipo de ação que você deseja fazer: 1 para criar uma conta Pupança e 2 para conta Especial, 3 para sacar, 4 para depositar , 5 para consultar uma informação de algum cliente e 6 para transferencia ");
            int c = int.Parse(Console.ReadLine());

            if (c == 1)
            {
                ContaPupanca cliente1 = new ContaPupanca();
                cliente1.cliente = Console.ReadLine();
                cliente1.num_conta = Console.ReadLine();
                cliente1.saldo = double.Parse(Console.ReadLine());
                cliente1.dia_rendimento = DateTime.Parse(Console.ReadLine());
                clientep.Add(cliente1);
                
            }

            else if (c == 2)
            {
                ContaEspecial cliente2 = new ContaEspecial();
                cliente2.cliente = Console.ReadLine();
                cliente2.num_conta = Console.ReadLine();
                cliente2.saldo = double.Parse(Console.ReadLine());
                cliente2.limite = double.Parse(Console.ReadLine());
                
                clientee.Add(cliente2);
            }

            else if (c == 3)
            {
                Console.WriteLine(" Digite o seu tipo de conta Bancária 1 para pupança e dois para Especial");
                int k = int.Parse(Console.ReadLine());
                if (k == 1)
                {
                    Console.WriteLine("Digite o valor a ser sacado:");
                    double valor = int.Parse(Console.ReadLine());
                    Console.WriteLine("Digite seu número da conta");
                    string numero = Console.ReadLine();

                    for (int i = 0; i < clientep.Count; i++)
                    {
                        if (clientep[i].num_conta == numero)
                        {
                            clientep[i].Sacar(valor);
                        }
                    }
                 
                     
                }
                else if (k == 2)
                    {
                            
                    Console.WriteLine("Digite o valor a ser sacado:");
                    double valor = int.Parse(Console.ReadLine());
                    Console.WriteLine("Digite seu número da conta");
                    string numero = Console.ReadLine();

                    for (int i = 0; i < clientee.Count; i++)
                    {
                        if (clientee[i].num_conta == numero)
                        {
                            clientee[i].Sacar(valor);
                        }
                    }
                 
                    }

            else if (c == 4 )
            {
                Console.WriteLine(" Digite o seu tipo de conta Bancária 1 para pupança e dois para Especial");
                int w = int.Parse(Console.ReadLine());
                Console.WriteLine("Digite seu número da conta");
                string t = Console.ReadLine();
                if (w == 1)
	            {		           
                    Console.WriteLine("Digite a quantia a ser depositada");
                    double qt = double.Parse(Console.ReadLine());
                    for (int j = 0; j < clientep.Count; j++)
			        {
			            if (clientep[j].num_conta == t )
	                        {
		                        clientep[j].Depositar(qt); 
	                        }
			        }
                }
                else
	                {
                      Console.WriteLine("Digite seu número da conta");
                      string b = Console.ReadLine();
                		           
                       Console.WriteLine("Digite a quantia a ser depositada");
                       double qt = double.Parse(Console.ReadLine());
                    for (int j = 0; j < clientee.Count; j++)
			            {
			                 if (clientep[j].num_conta == b )
	                        {
		                        clientee[j].Depositar(qt); 
	                        }
			            }
                   }
	                
            }

            else if (c == 5)
                {
                    Console.WriteLine(" Digite o seu tipo de conta Bancária 1 para pupança e dois para Especial");
                    int w = int.Parse(Console.ReadLine());
                    if (w == 1)
	               {
                    Console.WriteLine("Digite seu número da conta");
                    string t = Console.ReadLine();
                     for (int j = 0; j < clientep.Count; j++)
			           {
			            if (clientep[j].num_conta == t )
	                        {
                              Console.WriteLine(clientep[j]);
	                        }
			           }
                
                   }
                 else if (w == 2)
	                {
		              Console.WriteLine("Digite seu número da conta");
                      string t = Console.ReadLine();
                      for (int j = 0; j < clientee.Count; j++)
			           {
			            Console.WriteLine(clientep[j]);
			
                       }
	                }
                    else if (c == 6)
	                {
                        
                    Console.WriteLine(" Digite o seu tipo de conta Bancária 1 para pupança e dois para Especial");
                    int o = int.Parse(Console.ReadLine());
		                if (o == 1)
	               {
                                 Console.WriteLine("Digite seu número da conta a ser transferido o valor");
                                 Console.WriteLine("Digite seu número da conta a ser transferido o valor");
                                 string t = Console.ReadLine();
                                    for (int j = 0; j < clientep.Count; j++)
			                             {
			                                     
			                             }
                
                   }
                        else if (o == 2)
	               {
		                    Console.WriteLine("Digite seu número da conta");
                            string t = Console.ReadLine();
                      for (int j = 0; j < clientee.Count; j++)
			           {
			            Console.WriteLine(clientep[j]);
			
                       }
	                }
	                }
        }
    }
}
    
    