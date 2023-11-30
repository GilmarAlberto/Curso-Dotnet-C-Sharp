﻿/*
18. Faça um programa que peça o tamanho de um arquivo para download (em MB) e a velocidade de um link de Internet (em Mbps), calcule e informe o tempo aproximado de download do arquivo usando este link (em minutos).

*/

class Program
{
    static void Main(string[] args)
    {
        double tamanho, velocidade, tempo;

        do
        {
            System.Console.WriteLine("Digite o tamanho do arquivo: ");
        } while ((!double.TryParse(Console.ReadLine(), out tamanho)));

        do
        {
            System.Console.WriteLine("Digite a velocidade da internet: ");
        } while ((!double.TryParse(Console.ReadLine(), out velocidade)));

        tempo = tamanho / velocidade;

        System.Console.WriteLine($"O tempo gasto para efetuar o download é de: {tempo}");
     
    }

}

