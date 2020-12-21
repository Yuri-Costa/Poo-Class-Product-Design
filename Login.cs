using System;
using System.Collections.Generic;

namespace projeto
{
    public class Login 
    {       Marca M = new Marca();
            List<Usuario> LoginU = new List<Usuario>();
            Usuario U = new Usuario(Nome, Email, Senha);

        public static string Nome { get; private set; }
        public static string Email { get; private set; }
         public static int Senha { get; private set; }
        public bool Logado { get; set; }
        public void Cadastrar(){Console.ForegroundColor =  ConsoleColor.Cyan;
            Console.WriteLine("----------Cadastro----------");
            Console.ForegroundColor =  ConsoleColor.Yellow;
            Console.WriteLine("insira seu nome de usuario:");
            U.Nome = Console.ReadLine();
            //_________________________________________________
            Console.WriteLine("insira seu gmail:");
            U.Email = Console.ReadLine();
            //_________________________________________________
            Console.WriteLine("insira sua senha:");
            U.Senha = int.Parse(Console.ReadLine());
            //_________________________________________________
            Console.ForegroundColor =  ConsoleColor.Green;
            Console.WriteLine("CADASTRADO!");
            LoginU.Add(U);
            Logar();
         
    }

        public void Logar(){
                Console.ForegroundColor =  ConsoleColor.Cyan;
                Console.WriteLine("-------------LOGIN----------------");
                Console.ForegroundColor =  ConsoleColor.Yellow;
                Console.WriteLine("insira seu E mail:");
                string EmailL = Console.ReadLine();
                Console.WriteLine("insira sua senha:");
                int senhaL = int.Parse(Console.ReadLine());

                if (senhaL == U.Senha)
                {   Console.ForegroundColor =  ConsoleColor.Green;
                    Console.WriteLine($"Olá {U.Nome}, Seja muito Bem Vindo :)");
                    M.MostrarMenu();
                }else{Console.ForegroundColor =  ConsoleColor.Red;
                    Console.WriteLine("Essa usuario não esta cadastrado :(");
                }if (EmailL == U.Email)
                {
                    Console.ForegroundColor =  ConsoleColor.Green;
                    Console.WriteLine($"Olá {U.Nome}, Seja muito Bem Vindo :)");
                    M.MostrarMenu();
                }else{Console.ForegroundColor =  ConsoleColor.Red;
                    Console.WriteLine("Essa usuario não esta cadastrado :(");
                }

              
               
        }
                public void Mostrar1menu(){Console.ForegroundColor =  ConsoleColor.Magenta;
                        Console.WriteLine("Olá!!");
                        Console.WriteLine("");
                        Console.WriteLine("FAZER LOGIN    --- [1]");
                        Console.WriteLine("FAZER CADASTRO --- [2]");
                        Console.WriteLine("______________________");
                        int resposta = int.Parse(Console.ReadLine());
                        switch (resposta)
                        {
                            case 1:
                            Logar();
                                break;
                            case 2:
                            Cadastrar();
                                break;


                            default:
                                break;
                        }
                        

                }
                
    }
}