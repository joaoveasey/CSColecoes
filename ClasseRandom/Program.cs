//Random random = new Random(2023);

//Console.WriteLine(random.Next()); //numero aleatorio gigante
//Console.WriteLine(random.Next(20)); //numero aleatorio entre 0 e 19
//Console.WriteLine(random.Next(10, 20)); //numero aleatorio entre 10 e 19
//Console.WriteLine(random.NextDouble()); //numero aleatorio entre 0 e 1

//Console.ReadKey();

Console.WriteLine("Sorteio Mega-Sena\n");

Random random = new Random();

int[] numerosSorteados = new int[6];

for (int i = 0; i < 6; i++)
{
    int numeroAleatorio;
    do
    {
        numeroAleatorio = random.Next(1, 61);
    }
    while (numerosSorteados.Contains(numeroAleatorio));

    numerosSorteados[i] = numeroAleatorio;
}

Array.Sort(numerosSorteados);

Console.WriteLine("Números Sorteados\n");

Console.WriteLine(string.Join(" ", numerosSorteados));
Console.ReadKey();