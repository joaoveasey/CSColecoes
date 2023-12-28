Console.WriteLine("Array 3\n");

//array com laço foreach:
//o foreach permite executar uma instrução ou um bloco de instrução para CADA elemento presente em uma coleção

//foreach(tipo elemento in colecao)
//{
//    //instrução 
//}

int[] numeros = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

foreach (int numero in numeros)
{
    Console.WriteLine(numero);
}

Console.WriteLine("\n----------------\n");

string[] nomes = { "Maria", "João", "José", "Pedro" };

foreach (string nome in nomes)
{
    Console.WriteLine(nome);
}

