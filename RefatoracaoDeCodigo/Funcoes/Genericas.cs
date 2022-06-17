using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


// Estas funções não estão a sert usadas
namespace Funcoes
{
    internal class Genericas
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
    }
}
