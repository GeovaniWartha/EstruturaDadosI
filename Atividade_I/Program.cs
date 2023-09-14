using System;

class Program
{
    static void Main()
    {
        int[,] matriz = new int[3, 3];

        Console.WriteLine("Preencha a matriz 3x3 com 0 ou 1:");

        while (true)
        {
            ImprimirMatriz(matriz);

            Console.Write("Informe a linha (0-2) onde deseja colocar 0 ou 1 (ou digite -1 para sair): ");
            int linha = int.Parse(Console.ReadLine());

            if (linha == -1)
            {
                break;
            }

            Console.Write("Informe a coluna (0-2) onde deseja colocar 0 ou 1: ");
            int coluna = int.Parse(Console.ReadLine());

            if (linha < 0 || linha > 2 || coluna < 0 || coluna > 2)
            {
                Console.WriteLine("Linha e/ou coluna fora do intervalo permitido (0-2).");
                Console.WriteLine("Pressione Enter para continuar.");
                Console.ReadLine();
                continue;
            }

            if (matriz[linha, coluna] != 0)
            {
                Console.WriteLine("A posição [" + linha + "," + coluna + "] já está ocupada. Escolha outra posição.");
                Console.WriteLine("Pressione Enter para continuar.");
                Console.ReadLine();
                continue;
            }

            Console.Write("Informe o valor (0 ou 1) para a posição [" + linha + "," + coluna + "]: ");
            int valor = int.Parse(Console.ReadLine());

            if (valor == 0 || valor == 1)
            {
                matriz[linha, coluna] = valor;
            }
            else
            {
                Console.WriteLine("Valor inválido. Use apenas 0 ou 1.");
                Console.WriteLine("Pressione Enter para continuar.");
                Console.ReadLine();
            }
        }

        Console.WriteLine("Matriz final:");
        ImprimirMatriz(matriz);
    }

    static void ImprimirMatriz(int[,] matriz)
    {
        Console.WriteLine("Matriz atual:");
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                Console.Write(matriz[i, j] + " ");
            }
            Console.WriteLine();
        }
    }
}
