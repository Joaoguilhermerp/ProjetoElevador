using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoFinalElevador.Model
{
    internal class Elevador
    {

        public int AndarAtual { get; set; }
        public int LimiteAndares { get; set; }
        public int LimitePessoas { get; set; }
        public int Pessoas { get; set; }



        public void Inicializar(int limitePessoas, int limiteAndares)
        {
            LimiteAndares = limiteAndares;
            LimitePessoas = limitePessoas;
            AndarAtual = 0;
            Pessoas = 0;

        
        }

        public void Entrar()
        {
            if (Pessoas < LimitePessoas)
            {
                Pessoas++;
                Console.WriteLine("Passageiros no elevador: " + Pessoas);
            }
            else
            {
                Console.WriteLine("O Elevador está lotado no momento, aguarde o retorno.");
            }


        }

        public void Sair()
        {
            if (Pessoas > 0)
            {
                Pessoas--;
                Console.WriteLine("Passageiros no elevador: " + Pessoas);
            }
            else
            {
                Console.WriteLine("O elevador está vazio");
            }




        }

        public void Subir()
        {
            if (AndarAtual < LimiteAndares)
            {
                AndarAtual++;
                Console.WriteLine(AndarAtual + "ºAndar");
            }
            else
            {
                Console.WriteLine("Você está no último andar");
            }

        }

        public void Descer()
        {
            if (AndarAtual > 0)
            {
                AndarAtual--;
                Console.WriteLine(AndarAtual + "ºAndar");
            }
            else
            {
                Console.WriteLine("Você já está no térreo");
            }


        }


    }
}
