using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectCsharp
{
    class Menu : Conta
    {
        
        private bool isValid = false;
        private int salario;
        private int salarioAtual;

        public void menu()
        {
            
            while (!isValid)
            {
              
                Console.WriteLine("Opções: Saldo [S] - Pagar - [P] Depósito [D] - Verificar - [V] - Criar usuário - [C]");
                Console.Write("Qual sua opção: ");
                String opcao = Console.ReadLine().ToUpper();
                
                switch (opcao)
                {
                    
                    case "S":
                        
                        Console.Write("Qual o seu salário: ");
                        this.salario = Convert.ToInt32(Console.ReadLine());
                        setValor(this.salario);
                        
                        break;
                    case "P":
                        
                        Console.Write("Qual o valor à pagar: ");
                        int valorPagar = Convert.ToInt32(Console.ReadLine());
                        setPagar(valorPagar);
                        
                        break;
                    case "D":
                        
                        Console.Write("Qual o valor de depósito: ");
                        int depositoValor = Convert.ToInt32(Console.ReadLine());
                        setDeposito(depositoValor);
                        
                        break;
                    case "V":
                        
                        Console.WriteLine($"Seu saldo atual: {getValor()}");
                        
                        break;
                    case "C":

                        Console.Write("Qual o seu nome: ");
                        String nome = Console.ReadLine();
                        Console.Write("Qual é sua idade: ");
                        int idade = int.Parse(Console.ReadLine());
                        
                        if (this.salario > 0)
                        {
                            Console.WriteLine("Saldo já indicado");
                            Usuario usuario = new Usuario(nome, idade, this.salario);
                            ArrayList list = new ArrayList();
                            list = usuario.lista();
                        
                            Console.WriteLine("----- Usuário -----");
                            foreach (var i in list)
                            {
                                Console.WriteLine(i);    
                            }
                            Console.WriteLine("------- End -------");
                        }
                        else
                        {
                            Console.Write("Qual é o seu salário: ");
                            this.salarioAtual = int.Parse(Console.ReadLine());
                            Usuario usuario = new Usuario(nome, idade, salarioAtual);
                            ArrayList list = new ArrayList();
                            list = usuario.lista();
                        
                            Console.WriteLine("----- Usuário -----");
                            foreach (var i in list)
                            {
                                Console.WriteLine(i);    
                            }
                            Console.WriteLine("------- End -------");
                        }
                        
                        break;
                    default:
                        Console.WriteLine("Encerrando programa!!!");
                        isValid = true;
                        break;
                }

            }
            
        }
        
    }
}
