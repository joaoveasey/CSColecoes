//2)
Console.WriteLine("Insira aqui o número de valores do array: \n");
int numeroDeValoresArray = Convert.ToInt32(Console.ReadLine());

int[] MeuArray = new int[numeroDeValoresArray];
int numeroProcurado;

do
{
    Console.WriteLine("Qual número deseja procurar? (pressione 0 para sair do loop) \n");
    numeroProcurado = Convert.ToInt32(Console.ReadLine());
    if (!MeuArray.Contains(numeroProcurado))
    {
        Console.WriteLine("Número NÃO existe no array\n");
    }
    else
    {
        Console.WriteLine("Número existe no array\n");
    }
} while (numeroProcurado != 0);