using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6._0Funcoes
{
    internal class MostrarMensagemTela
    {
        public int CalcularSoma2()
        {
            int a = 1;
            int b = 2;
            int c = a + b;
            return c;
        }
        static int calcular() // Função estática
        {
            int a = 1;
            int b = 2;
            int c = a + b;


            return c; //retorna o valor da soma das duas outras funções a e b
        }

        public static void MostrarMensagemNaTela()
        {
            Console.WriteLine("Exemplo do resultado de uma função mostrando a tabuada dos 9");
        }

        // Criando uma função para executar a tabuada
        public static void Tabuada(int numero)
        {
            Console.WriteLine("##################### Calculo da Tabuada" + numero + "#######################");
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(numero + " x " + i + " = " + (numero * i));
            }
            Console.WriteLine("############################################");
        }

        private static void LerArquivos(int numeroArquivo)
        {
            string arquivoComCaminho = @"C:\arquivos\arq" + numeroArquivo + ".txt";
            Console.WriteLine("######## Lendo Arquivo ###############\n" + arquivoComCaminho + "\n#################");
            if (File.Exists(arquivoComCaminho))
            {
                using (StreamReader arquivo = File.OpenText(arquivoComCaminho))
                {
                    string linha;
                    while ((linha = arquivo.ReadLine()) != null)
                    {
                        Console.WriteLine(linha);
                    }
                }
            }
            string arquivoComCaminho2 = @"C:\arquivos\arq" + (numeroArquivo + 1) + ".txt";

            //Verificando se existe um novo arquivo, se existir ele faraá a leitura de quantos houver
            if (File.Exists(arquivoComCaminho2))
            {
                LerArquivos(numeroArquivo + 1);
            }
        }
        // Função para o cálculo da média

        private static void CalcularMediaAluno()
        {
            Console.WriteLine("Digite o nome do aluno: ");
            string nome = Console.ReadLine();

            int qtdNotas = 3;
            Console.WriteLine("Digite as " + qtdNotas + " notas do aluno: " + nome);

            //Criação de uma lista
            List<int> notas = new List<int>();  // Criando uma instância da lista
            int totalNotas = 0;
            for (int i = 1; i <= qtdNotas; i++)
            {
                Console.WriteLine("Digite a nota " + i);
                int nota = int.Parse(Console.ReadLine());
                totalNotas += nota;
                notas.Add(nota);
            }

            int media = totalNotas / notas.Count;
            Console.WriteLine("A média do aluno: " + nome + "é:  " + media);
            Console.WriteLine("As suas notas são:\n");

            foreach (int nota in notas)
            {
                Console.WriteLine("A nota do aluno: " + nota + "\n");
            }

        }

        private static void Menu()
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
                    LerArquivos(1);
                    Console.WriteLine("########################");
                }
                else if (valor == TABUADA)
                {
                    Console.WriteLine("################# Opção Tabuada ########################");
                    Console.WriteLine("Digite o número da tabuada que deseja");
                    int numero = int.Parse(Console.ReadLine());
                    Tabuada(numero);
                    Console.WriteLine("##########################");
                }
                else if (valor == CALCULO_MEDIA)
                {
                    CalcularMediaAluno();
                    Console.WriteLine("##########################");
                }
                else
                {
                    Console.WriteLine("Opção inválida. Digite novamente ");
                }


            }


        }


        // Criação de constantes
        public const int SAIDA_PROGRAMA = 0;
        public const int LER_ARQUIVOS = 1;
        public const int TABUADA = 2;
        public const int CALCULO_MEDIA = 3;
        public string qtdNotas;

        static void Main(string[] args)
        {
            Menu();
        }
    }
}