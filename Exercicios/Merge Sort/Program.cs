using System;

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Digite os números separados por espaços:");
        string? input = Console.ReadLine();  // Adicionando ? para indicar que pode ser nulo

        if (input != null)
        {
            string[] inputArray = input.Split(' ');

            int[] numbers = new int[inputArray.Length];
            for (int i = 0; i < inputArray.Length; i++)
            {
                if (int.TryParse(inputArray[i], out int num))
                {
                    numbers[i] = num;
                }
                else
                {
                    Console.WriteLine("Digite apenas números inteiros separados por espaços.");
                    return;
                }
            }

            Console.WriteLine("Array antes da ordenação:");
            Utils.PrintArray(numbers);

            MergeSorter.MergeSort(numbers);

            Console.WriteLine("Array após a ordenação:");
            Utils.PrintArray(numbers);
        }
        else
        {
            Console.WriteLine("Entrada inválida. A entrada não pode ser nula.");
        }
    }
}
