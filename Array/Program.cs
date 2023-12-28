Console.WriteLine("Array 1\n");

//um array é usado para armazenar mais de um valor literal do mesmo tipo em uma variável de mesmo nome.
//sintaxe:
//TipoDeDado[] NomeDoArray;
//TipoDeDado[] NomeDoArray = new TipoDeDado[qtdDeValores]{valores}
//exemplo:
//int[] numeros = new int[10] {1,2,3,4,5,6,7,8,9,10}; 

//apenas declaração
int[] numeros;

//alocando memória e inicializei
numeros = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

string[] nomes = { "Ana", "Maria", "João", "Roger", "Camilo" };

//acessando elementos do array
Console.WriteLine(nomes[0]);
Console.WriteLine(nomes[1]);
Console.WriteLine(nomes[2]);
Console.WriteLine(nomes[3]);
Console.WriteLine(nomes[4]);

Console.ReadKey();