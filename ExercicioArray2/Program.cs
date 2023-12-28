Console.WriteLine("Exercício Array Bidimensional");

string?[,] nomes;

nomes = new string[2,2];

//recebendo os valores
for (int i = 0; i < nomes.GetLength(0); i++)
{
    for (int j = 0; j < nomes.GetLength(1); j++)
    {
        Console.Write("Insira o nome do aluno: ");
        nomes[i, j] = Console.ReadLine();
    }
}

//imprimindo os valores
for (int i = 0; i < nomes.GetLength(0); i++)
{
    for (int j = 0; j < nomes.GetLength(1); j++)
    {
        Console.Write($"[{i}, {j}] = {nomes[i, j]} ");
    }
    Console.WriteLine();
}

Console.ReadKey();