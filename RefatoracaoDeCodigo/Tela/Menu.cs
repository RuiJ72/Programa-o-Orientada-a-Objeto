using Calculo;
using Diretorio;
using Funcoes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tela
{
     class Menu
     {
        public const int SAIDA_PROGRAMA = 0;
        public const int LER_ARQUIVOS = 1;
        public const int TABUADA = 2;
        public const int CALCULO_MEDIA = 3;

        public static void Criar()
        {
        
            // Montando o menu
            while (true)
            {

                string mensagem = "         Bem vindo, usuário." +
                    "\n    Digite uma das opções abaixo: " +
                    "\n0 -     Sair do Programa" +
                    "\n1 -     Para Ler Arquivos" +
                    "\n2 -     Para Executar a Tabuada" +
                    "\n3 -     Calcular Média de Alunos";
                Console.WriteLine(mensagem);

                int valor = int.Parse(Console.ReadLine());




                if (valor == SAIDA_PROGRAMA)
                {
                    break;
                }
                else if (valor == LER_ARQUIVOS)
                {
                    Console.WriteLine("################# Opção Ler Arquivos ########################");
                    Arquivo.Ler(1);
                    Console.WriteLine("########################");
                }
                else if (valor == TABUADA)
                {
                    Console.WriteLine("################# Opção Tabuada ########################");
                    Console.WriteLine("Digite o número da tabuada que deseja");
                    int numero = int.Parse(Console.ReadLine());
                    Tabuada.Calcular(numero);
                    Console.WriteLine("##########################");
                }
                else if (valor == CALCULO_MEDIA)
                {
                    Media.Aluno(); // Instanciando Aluno que se encontra na classe Media

                    Console.WriteLine("##########################");
                }
                else
                {
                    Console.WriteLine("Opção inválida. Digite novamente ");
                }


            }


        }
    }
}
