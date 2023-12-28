Console.WriteLine("Array Métodos");

//Array.Reverse(nomeDoArray); => inverte a sequência de um array unidimensional
//Array.Sort(nomeDoArray); => ordena os itens de um array
//Array.BinarySearch(nomeDoArray, objeto); => faz a busca de um array ordenado , se encontrar valor, retorna o índice, se não, retorna um valor negativo

string[] nomes = { "Maria", "João", "José", "Pedro" };

//-------------Exibindo o Array original:
Console.WriteLine("\n\nExibindo o Array original: ");
ExibeArray(nomes);

//-------------Invertendo a ordem do Array:
Console.WriteLine("\n\nInvertendo a ordem do Array: ");
Array.Reverse(nomes);
ExibeArray(nomes);

//-------------Ordenando o Array:
Console.WriteLine("\n\nOrdenando o Array: ");
Array.Sort(nomes);
ExibeArray(nomes);

//-------------Procurando elemento do Array:
Console.WriteLine("\n\nProcurando elemento do Array: ");
Console.WriteLine("Insira um nome: ");
string nome = Console.ReadLine();
var indice = Array.BinarySearch(nomes,nome);

if (indice >= 0)
    Console.WriteLine($"{nome} foi encontrado com índice {indice}");
else
    Console.WriteLine("valor não encontrado");


Console.ReadKey();

static void ExibeArray(string[] nomes)
{
    foreach (string nome in nomes)
    {
        Console.WriteLine($"{nome}");
    }
}