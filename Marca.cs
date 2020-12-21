using System;
using System.Collections.Generic;
using System.Threading;

namespace projeto
{
    public class Marca
    {       
        public string Codigo { get; set; }
        public string NomeDaMarca { get; set; }
        public string DataDeCadastro { get; set; }
       
                           List<Produto> carrinho = new List<Produto>();






                           public void MostrarMenu(){
                               
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("------------------------------");
            Console.WriteLine("--------------MENU------------");
            Console.WriteLine("------------------------------");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("CADASTRAR PRODUTO     ---> [1]");
            Console.WriteLine("CARRINHO              ---> [2]");
            Console.WriteLine("REMOVER PRODUTO       ---> [3]");
            Console.WriteLine("SUBSTITUIR PRODUTO    ---> [4]");
            Console.WriteLine("PARABÉNS PARA VOCÊ :) ---> [5]");
            Console.WriteLine("SAIR                  ---> [0]");
            Console.WriteLine("______________________________");
            int opcao = int.Parse(Console.ReadLine());


            switch (opcao)
            {
                case 1:
                    Cadastrar();
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("deseja voltar para o menu? s/n");
                    string resposta1 = Console.ReadLine();
                    if (resposta1 == "s")
                    {
                        MostrarMenu();
                    }else
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine("ATÉ A PROXIMA! :)");
                    }
                    break;

                case 2:
                    Listar();
                    Console.WriteLine("deseja voltar para o menu? s/n");
                    string resposta2 = Console.ReadLine();
                    if (resposta2 == "s")
                    {
                        MostrarMenu();
                    }else
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine("ATÉ A PROXIMA! :)");
                    }
                    break;

                case 3:
                    Remover();
                    Console.WriteLine("deseja voltar para o menu? s/n");
                    string resposta3 = Console.ReadLine();
                    if (resposta3 == "s")
                    {
                        MostrarMenu();
                    }else
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine("ATÉ A PROXIMA! :)");
                    }
                    break;

                     case 4:

                        Alterar();
                      
                    Console.WriteLine("deseja voltar para o menu? s/n");
                    string resposta4 = Console.ReadLine();
                    if (resposta4 == "s")
                    {
                        MostrarMenu();
                    }else
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine("ATÉ A PROXIMA! :)");
                    }
                    break;

                     case 0:    Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine("ATÉ A PROXIMA! :)");
                    break;
                    
                        case 5:  
                      Musiquinha();
                    Console.WriteLine("deseja voltar para o menu? s/n");
                    string resposta5 = Console.ReadLine();
                    if (resposta5 == "s")
                    {
                        MostrarMenu();
                    }else
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine("ATÉ A PROXIMA! :)");
                    }
                    break;
                   


                default:
                    break;
            }
                                
                           }
            public void Cadastrar(){
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("ok! vamos cadastrar seus produtos!");
            Console.WriteLine(" Para começar, digite o codigo do seu produto");
            int CPcodigo = int.Parse(Console.ReadLine());
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($" Codigo [{CPcodigo}] cadastrado :)");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("digite o nome do seu produto");
            string CPnome = Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($" Nome [{CPnome}] cadastrado :)");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("digite a Marca do seu produto");
            string CPmarca = Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($" Marca [{CPmarca}] cadastrado :)");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("digite o Preço do seu produto");
            float CPpreco = int.Parse(Console.ReadLine());
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($" Preço de [R${CPpreco.ToString("n2")}] cadastrado :)");
            Console.WriteLine("Insira a data de hoje:");
            DateTime date = DateTime.Parse(Console.ReadLine());
            Produto p = new Produto(CPcodigo, CPnome, CPmarca, CPpreco, date);
            carrinho.Add(p);
            Console.WriteLine("Ótimo! seu produto foi cadastrado com sucesso :)");
            }
            //---------------------------------------------------------------------------------------
            public void Listar(){
                foreach (var lista in carrinho)
                {
                    Console.WriteLine("______________________________________________________PRODUTOS__________________________________________________________________");
                    Console.WriteLine("");
                    Console.WriteLine("________________________________________________________________________________________________________________________________");
                    Console.WriteLine($"Código: [{lista.Codigo}] || Nome: [{lista.Nome}] || Marca: [{lista.Marca}] || Preço: [{lista.preco}] || Data De Cadastro: [{lista.Data}]  ");
                }
            }

            //------------------------------------------------------------------------------------------------

           public void Remover(){
                Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("REMOVER UM PRODUTO           ---> [1]");
            Console.WriteLine("REMOVER TODOS OS PRODUTOS    ---> [2]");
            int opcaoREMOVE = int.Parse(Console.ReadLine());

            switch (opcaoREMOVE)
            {
                case 1:
                    Console.WriteLine("ok! vamos remover um produto :(");
                    Console.WriteLine("insira o Código do produto que voce deseja remover.");
                    int remo = int.Parse(Console.ReadLine());
                    foreach (var p in carrinho)
                    {
                            if (p.Codigo == remo)
                            {
                                carrinho.Remove(p);
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine($"item {remo} removido!");
                                Console.ResetColor();
                                break;
                            }
                            else
                            {
                                Console.WriteLine("Codigo não encontrado");
                            }
                    }
                    break;


                case 2:
                    foreach (var produto in carrinho)
                    {
                        carrinho.Clear();
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("todos os itens removidos");
                        break;
                    }
                    break;
                default:
                    break;
            }
           }


           //-----------------------------------------------------------------------------------------

           public void Substituir(int _codigo, Produto newProduto ){
                if (carrinho.Count != 0)
            {
            carrinho.Find(x => x.Codigo == _codigo ).Nome = newProduto.Nome;
            carrinho.Find(x => x.Codigo == _codigo ).Marca = newProduto.Marca;
            carrinho.Find(x => x.Codigo == _codigo ).preco = newProduto.preco;
            carrinho.Find(x => x.Codigo == _codigo ).Codigo = newProduto.Codigo;
        }else
        {   Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("opa! voce não tem nenhum produto no carrinho para alterar!");
            Console.WriteLine("Cadastre um produto primeiro para altera-lo:(");
            Console.ResetColor();
           }
           }

           public void Alterar(){
                if (carrinho.Count != 0)
            {
             Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("ok! vamos alterar seus produtos!");
            Console.WriteLine(" Para começar, digite o codigo produto que voce deseja alterar");
            int Acodigo = int.Parse(Console.ReadLine());
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Ótimo! agora insira o seu novo código");
             int NEWcodigo = int.Parse(Console.ReadLine());
            Console.WriteLine("agora insira o novo nome do seu produto");
            string NEWnome = Console.ReadLine();
             Console.WriteLine("agora insira a nova marca nome do seu produto");
            string NEWmarca = Console.ReadLine();
            Console.WriteLine("agora insira o novo preço do seu produto");
            float NEWpreco = int.Parse(Console.ReadLine());
            Console.WriteLine("agora insira a data de hoje");
            DateTime NEWdata = DateTime.Parse(Console.ReadLine());
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($" Código [{NEWcodigo}] cadastrado :)");
            Console.WriteLine($" Nome [{NEWnome}] cadastrado :)");
            Console.WriteLine($" marca [R${NEWmarca}] cadastrada :)");
            Console.WriteLine($" Preço de [R${NEWpreco}] cadastrado :)");
            Console.WriteLine($" data de cadastro: [R${NEWpreco}] :)");
         
            Produto newP = new Produto(NEWcodigo, NEWnome, NEWmarca, NEWpreco, NEWdata);
            Substituir(Acodigo, newP);
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("Ótimo! seu produto foi alterado com sucesso :)");
            }else
            {   Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Opa! voce não possui nenhum produto no carrinho :(");
                Console.WriteLine("Cadastre um produto primeiro para altera-lo:(");
                Console.ResetColor();
            }  
        
        }
        
 public void Musiquinha(){
               Grasshoper();
        }
        private static void Grasshoper()
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("happy birthday! :)");
            Console.ResetColor();
            Thread.Sleep(2000);
            Console.Beep(264, 125);
            Thread.Sleep(250);
            Console.Beep(264, 125);
            Thread.Sleep(125);
            Console.Beep(297, 500);
            Thread.Sleep(125);
            Console.Beep(264, 500);
            Thread.Sleep(125);
            Console.Beep(352, 500);
            Thread.Sleep(125);
            Console.Beep(330, 1000);
            Thread.Sleep(250);
            Console.Beep(264, 125);
            Thread.Sleep(250);
            Console.Beep(264, 125);
            Thread.Sleep(125);
            Console.Beep(297, 500);
            Thread.Sleep(125);
            Console.Beep(264, 500);
            Thread.Sleep(125);
            Console.Beep(396, 500);
            Thread.Sleep(125);
            Console.Beep(352, 1000);
            Thread.Sleep(250);
            Console.Beep(264, 125);
            Thread.Sleep(250);
            Console.Beep(264, 125);
            Thread.Sleep(125);
            Console.Beep(2642, 500);
            Thread.Sleep(125);
            Console.Beep(440, 500);
            Thread.Sleep(125);
            Console.Beep(352, 250);
            Thread.Sleep(125);
            Console.Beep(352, 125);
            Thread.Sleep(125);
            Console.Beep(330, 500);
            Thread.Sleep(125);
            Console.Beep(297, 1000);
            Thread.Sleep(250);
            Console.Beep(466, 125);
            Thread.Sleep(250);
            Console.Beep(466, 125);
            Thread.Sleep(125);
            Console.Beep(440, 500);
            Thread.Sleep(125);
            Console.Beep(352, 500);
            Thread.Sleep(125);
            Console.Beep(396, 500);
            Thread.Sleep(125);
            Console.Beep(352, 1000);
        }
    
        
    }
}