﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculo
{
    internal class Media
    {
        public static void Aluno()
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
    }
}
