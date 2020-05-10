using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aprendendo_CSharp
{
    class Program
    {

        static void Main(string[] args)
        {
            TelaInicial();
  
        }

        //Tela Inicial
        static void TelaInicial()
        {
            
            Console.WriteLine("-------------------------------");
            Console.WriteLine("Welcome to Bingo");
            Console.WriteLine("-------------------------------\n");
            Console.WriteLine("Press A to continue...Nota: Sempre pressione 'T' para voltar atrás.");
            ConsoleKeyInfo tecla = Console.ReadKey();
            if (tecla.KeyChar == 'a')
            {
                Console.Clear();
                AparecerTabela();
            }
            else
            {
                Console.Clear();
                TelaInicial();
            }
           
            
        }

        // Segunda tela
        static void AparecerTabela()
        {
           
            Console.WriteLine("Por favor escolha o que queres fazer clicando nas teclas das letras das opcoes");
            Console.WriteLine("A) Calculadora");
            Console.WriteLine("B) Login");
            Console.WriteLine("C) Fale sobre voce");
            Console.Write("Digite Aqui: ");
            ConsoleKeyInfo key = Console.ReadKey();
            char KeyInfo = key.KeyChar;

            //Sistema de escolha de Opcoes;
            switch (KeyInfo)
            {
                case 'a':
                    EscolherCalculo();
                    break;
                case 'b':
                    Login();
                    break;
                case 'c':
                    FaleConosco();
                    break;
                case 't':
                    Console.Clear();
                    TelaInicial();
                    break;
                default:
                    Console.Clear();
                    AparecerTabela();
                    break;
            }
            
        }
        // Escolher o calculo
        static void EscolherCalculo()
        {
            bool calculeReturn = true;

            Console.Clear();
            Console.WriteLine("Que tipo de calculo queres fazer?");
            Console.WriteLine("A) Soma");
            Console.WriteLine("B) Subtracao");
            Console.WriteLine("C) Multiplicacao");
            Console.WriteLine("D) Divisao");
            Console.Write("Pressione as teclas das letras acima indicada para escolher: ");
            ConsoleKeyInfo KeySoma = Console.ReadKey();
            char KeySomaInfo = KeySoma.KeyChar;

            switch (KeySomaInfo)
            {
                //Soma
                case 'a':
                    while (calculeReturn == true)
                    {
                        Console.Clear();
                        Console.WriteLine("Digite o primeiro numero");
                        float x = float.Parse(Console.ReadLine());
                        Console.WriteLine("Digite o segundo numero");
                        float y = float.Parse(Console.ReadLine());
                        Console.WriteLine($"O valor total da soma é: {Soma(x, y)}");
                        Console.WriteLine("Pressione qualquer tecla pra continuar ou pressione 'T' para voltar");
                        ConsoleKeyInfo voltarDeCalculo = Console.ReadKey();
                        if (voltarDeCalculo.KeyChar == 't')
                        {
                            calculeReturn = false;
                        }
                        if (calculeReturn == false)
                        {
                            EscolherCalculo();
                        }
                    }

                    break;
                //Subtracao
                case 'b':
                    while (calculeReturn == true)
                    {
                        Console.Clear();
                        Console.WriteLine("Digite o primeiro numero");
                        float z = float.Parse(Console.ReadLine());
                        Console.WriteLine("Digite o segundo numero");
                        float r = float.Parse(Console.ReadLine());
                        Console.WriteLine($"O valor total da subtracao é: {Subtracao(z, r)}");
                        Console.WriteLine("Pressione qualquer tecla pra continuar ou pressione 'T' para voltar");
                        ConsoleKeyInfo voltarDeCalculo = Console.ReadKey();
                        if (voltarDeCalculo.KeyChar == 't')
                        {
                            calculeReturn = false;
                        }
                        if (calculeReturn == false)
                        {
                            EscolherCalculo();
                        }
                    }
                    
                    break;
                //Multiplicacao
                case 'c':
                    while (calculeReturn == true)
                    {
                        Console.Clear();
                        Console.WriteLine("Digite o primeiro numero");
                        float t = float.Parse(Console.ReadLine());
                        Console.WriteLine("Digite o segundo numero");
                        float e = float.Parse(Console.ReadLine());
                        Console.WriteLine($"O valor total da multiplicacao é: {Multiplicacao(t, e)}");
                        Console.WriteLine("Pressione qualquer tecla pra continuar ou pressione 'T' para voltar");
                        ConsoleKeyInfo voltarDeCalculo = Console.ReadKey();
                        if (voltarDeCalculo.KeyChar == 't')
                        {
                            calculeReturn = false;
                        }
                        if (calculeReturn == false)
                        {
                            EscolherCalculo();
                        }
                    }
                    break;
                //Divisao
                case 'd':
                    while (calculeReturn == true)
                    {
                        Console.Clear();
                        Console.WriteLine("Digite o primeiro numero");
                        float u = float.Parse(Console.ReadLine());
                        Console.WriteLine("Digite o segundo numero");
                        float i = float.Parse(Console.ReadLine());
                        Console.WriteLine($"O valor total da divisao é: {Divisao(u, i)}");
                        Console.WriteLine("Pressione qualquer tecla pra continuar ou pressione 'T' para voltar");
                        ConsoleKeyInfo voltarDeCalculo = Console.ReadKey();
                        if (voltarDeCalculo.KeyChar == 't')
                        {
                            calculeReturn = false;
                        }
                        if (calculeReturn == false)
                        {
                            EscolherCalculo();
                        }
                    }
                    
                    break;
                //Voltar
                case 't':
                    Console.Clear();
                    AparecerTabela();
                    break;
                default:
                    Console.Clear();
                    Console.WriteLine("Pressionaste outra tecla. Tivemos que reniciar!\n");
                    EscolherCalculo();
                    break;
            }

        }
       
        // Opcao de calculo;
        static float Soma(float a, float b)
        {
        
           return a + b;
          
        }
        static float Subtracao(float a, float b)
        {
            return a - b;
        }
        static float Multiplicacao(float a, float b)
        {
            return a * b;
        }
        static float Divisao(float a, float b)
        {
            return a / b;
        }

        //Opcao de Login
        static void Login()
        {
            string nome;
            int idade;
            string nacionalidade;
            Console.Clear();
            Console.WriteLine("--------------------------");
            Console.WriteLine("Sistema de Login");
            Console.WriteLine("--------------------------");

            Console.WriteLine("Qual é o seu nome?");
            nome = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Qual é a sua idade?");
            idade = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Qual é a sua nacionalidade?");
            nacionalidade = Convert.ToString(Console.ReadLine());

            Console.WriteLine("Efectuou o cadastro com sucesso.\n");
            Console.WriteLine("Deseja ver a sua informacao? y/n");

            ConsoleKeyInfo keyConfirm = Console.ReadKey();

            if (keyConfirm.KeyChar == 'y')
            {
                Console.Clear();
                Console.WriteLine("---------------------------");
                Console.WriteLine("Name: {0}", nome);
                Console.WriteLine("Age: {0}", idade);
                Console.WriteLine("Nacionality: {0}", nacionalidade);
                Console.WriteLine("---------------------------");
                Console.WriteLine("Quer reiniciar? y/n");
                ConsoleKeyInfo showInfoLoginReturn = Console.ReadKey();
                if (showInfoLoginReturn.KeyChar == 'y')
                {
                    Console.Clear();
                    Login();
                }
                else
                {
                    Console.Clear();
                    AparecerTabela();
                }
                Console.ReadLine();
            }else if (keyConfirm.KeyChar == 'n')
            {
                Console.Clear();
                AparecerTabela();
            }
            else
            {
                Console.Clear();
                Console.WriteLine();
                Console.WriteLine("Pressionaste outra tecla. Tivemos que reniciar!\n");
                AparecerTabela();
            }

        }

        //FALE CONOSCO
        static void FaleConosco()
        {
            string texto;
            bool escrever = true;
            Console.Clear();
            Console.WriteLine("Seja bem vindo ao 'FALE CONOSCO':\n - Para voltar, pressione 'T'\n - Para ver, pressione 'W'\n");
            texto = Console.ReadLine();
            Console.Write("Já terminaste! Escolha as opcoes acima...");
            ConsoleKeyInfo sair = Console.ReadKey();
            if (sair.KeyChar == 't')
            {
                Console.Clear();
                AparecerTabela();
            }
            else if (sair.KeyChar == 'w')
            {
                
                Console.Clear();
                Console.WriteLine("***************************************\n");
                Console.WriteLine(texto + "\n");
                Console.WriteLine("***************************************\n");
                Console.WriteLine("Pressione T para voltar...");
                ConsoleKeyInfo retornar = Console.ReadKey();
                if (retornar.KeyChar == 't')
                {
                    FaleConosco();
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Tivemos que voltar para a Tela inicial\n");
                    AparecerTabela();
                }
                
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Pressionaste outra tecla. Tivemos que reniciar!\n");
                FaleConosco();
            }

        }
    }
    
}
