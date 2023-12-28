Console.WriteLine("Array Bidimensional");

//é basicamente um array dentro de um array
//pode ser declarado usando vírgulas entre os colchetes do array

// int[,] array2d; => array bidimensional
// int[,,] array3d; => array tridimensional
// int[,,] array4d; => array quadridimensional

//int[3, 3] a; => cria um array bidimensional com 3 linhas e 3 colunas

int[,] a;

a = new int[2, 2];

a[0, 0] = 0;
a[1, 0] = 1;
a[0, 1] = 2;
a[1, 1] = 3;

Console.WriteLine(a[0, 0]);
Console.WriteLine(a[0, 1]);
Console.WriteLine(a[1, 0]);
Console.WriteLine(a[1, 1]);

//outro jeito de declarar: 
//int[,] b = new int[2, 2] { { 20, 30 }, { 40,50 } };
int[,] b = { { 20, 30 }, { 40, 50 } };

Console.WriteLine(b[0, 0]);
Console.WriteLine(b[0, 1]);
Console.WriteLine(b[1, 0]);
Console.WriteLine(b[1, 1]);


//-------------- usando laço for/foreach com arrays bidimensionais --------------------

//criando o array bidimensional com 3 linhas e 3 colunas

int[,] n =  {
                { 11, 22, 33 },
                { 44, 55, 66 },
                { 77, 88, 99 }
            };

//for

Console.WriteLine("\nfor\n");

for (int i = 0; i < n.GetLength(0); i++)
{
    for (int j = 0; j < n.GetLength(1); j++)
    {
        Console.Write($"{n[i , j]} ");
    }
    Console.WriteLine();
}

//foreach

Console.WriteLine("\nforeach\n");

foreach (int num in n)
{
    Console.Write($"{num} ");
}

Console.ReadKey();