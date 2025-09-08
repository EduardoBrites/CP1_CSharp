// Projeto de Avaliação (Revisado) - Variante 3: Cálculo de média de três notas
// Este programa deve solicitar o nome do estudante e três notas, calcular e exibir a média.
// Vários erros foram introduzidos na declaração dos tipos, controle de loop e operações aritméticas.

//Eduardo Brites Coutinho | rm 552943

using System;

class Program
{
    static void Main()
    {
        // Print na tela para o usuário informar o seu nome e guardade o valor na variavel de texto nome
        Console.WriteLine("Digite o nome do estudante:");
        String nome = Console.ReadLine();

        // Definindo a variavel soma para realizar a soma antes da divisão para a média
        double soma = 0;

        // Começo de um laço de repetição com for para pedir quatro vezes
        for (int i = 0; i < 3; i++)
        {
            Console.WriteLine("Digite a nota " + (i + 1) + ":");
            double nota = double.Parse(Console.ReadLine());

            soma = soma + nota;
        }

        double media = soma / 3;
        Console.WriteLine("A média do estudante " + nome + " é " + media);
    }
}