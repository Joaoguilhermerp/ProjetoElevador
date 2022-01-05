using ProjetoFinalElevador.Model;
using System;

namespace ProjetoElevador
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Elevador elevador = new Elevador();


            Inicializar(elevador);
            ExibeMenu(elevador);
        }

        static void Inicializar(Elevador elevador)
        {
            int confirma = 0;

            Console.WriteLine("Parabens voce acaba de adquirir seu elevador instantaneo patenteado pela ElevaDev");
            Console.WriteLine("Para instalação precisamos dos dados iniciais:");
                     
            do
            {
                Console.WriteLine("Qual o limite de pessoas no elevador ? ");
                int capacidade = Convert.ToInt16(Console.ReadLine());
                Console.WriteLine("Qual o tamanho do predio em andares?");
                int totalAndar = Convert.ToInt16(Console.ReadLine());

                Console.WriteLine(@$"A configuração digitada foi: 
                                 {capacidade} Pessoas e {totalAndar} Andares.");
                Console.WriteLine("Gravar configuração?");
                Console.WriteLine("1 - SIM \n0 - NÃO");
                confirma = Convert.ToInt16(Console.ReadLine());

                if (confirma == 1)
                {
                    elevador.Inicializar(capacidade, totalAndar);

                    Console.Clear();
                }
            } while (confirma == 0);
        }


        static void ExibeMenu(Elevador elevador)
            {
                int confirma = 0;
                int opcao;
                do
                {
                    Console.WriteLine("\n\nO que você deseja fazer?");

                    Console.WriteLine(@"Escolha uma opção:
                                1 - Entrar
                                2 - Sair
                                3 - Subir
                                4 - Descer
                                5 - Desligar
                                ");
                    opcao = Convert.ToInt16(Console.ReadLine());



                    switch (opcao)
                    {
                        case 1:
                            {
                                Console.Clear();
                                elevador.Entrar();
                                break;
                            }
                        case 2:
                            {
                                Console.Clear();
                                elevador.Sair();
                                break;
                            }
                        case 3:
                            {
                                Console.Clear();
                                elevador.Subir();
                                break;
                            }
                        case 4:
                            {
                                Console.Clear();
                                elevador.Descer();
                                break;
                            }
                        case 5:
                            {

                                break;
                            }
                        default:
                            {
                                Console.Clear();
                                Console.WriteLine("Digite uma opção valida");
                                break;
                            }
                    }
                } while (confirma == 0);
            }
        }
    }