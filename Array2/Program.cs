Console.WriteLine("Array 2\n");

//array com laço for:

int[] numeros = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
for (int i = 0; i < numeros.Length; i++)
{
    Console.WriteLine($"Índice {i}: {numeros[i]}");
}

Console.WriteLine("\n----------------\n");

string[] nomes = { "Maria", "João", "José", "Pedro" };

for (int i = 0;i < nomes.Length; i++)
{
    Console.WriteLine($"Índice {i}: {nomes[i]}");
}