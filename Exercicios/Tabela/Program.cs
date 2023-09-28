csharp
using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Dictionary<string, string> tabelaHash = new Dictionary<string, string>();
        string opcao;

        do
        {
            Console.WriteLine("1 - Inserir CPF e Nome");
            Console.WriteLine("2 - Exibir todos os dados");
            Console.WriteLine("3 - Sair");
            Console.Write("Digite a opção desejada: ");
            opcao = Console.ReadLine();

            switch (opcao)
            {
                case "1":
                    Console.Write("Digite o CPF: ");
                    string cpf = Console.ReadLine();
                    Console.Write("Digite o Nome: ");
                    string nome = Console.ReadLine();

                    if (tabelaHash.ContainsKey(cpf))
                    {
                        Console.WriteLine("CPF já inserido previamente.");
                    }
                    else
                    {
                        tabelaHash.Add(cpf, nome);
                        Console.WriteLine("Dados inseridos com sucesso.");
                    }
                    break;

                case "2":
                    Console.WriteLine("CPF\tNome");
                    foreach (KeyValuePair<string, string> entry in tabelaHash)
                    {
                        Console.WriteLine($"{entry.Key}\t{entry.Value}");
                    }
                    break;

                case "3":
                    Console.WriteLine("Saindo...");
                    break;

                default:
                    Console.WriteLine("Opção inválida.");
                    break;
            }
        } while (opcao != "3");
    }
}