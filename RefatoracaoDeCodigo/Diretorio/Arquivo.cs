using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diretorio
{
    internal class Arquivo
    {
        public static void Ler(int numeroArquivo)
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
                Arquivo.Ler(numeroArquivo + 1);
            }
        }
    }
}
