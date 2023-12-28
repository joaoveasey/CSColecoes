Console.WriteLine("Exercício Array\n");

string[] nomes = new string[5];
double[] notas = new double[5];

for (int i = 0; i < 5; i++)
{
    Console.WriteLine("Insira o nome do aluno: ");
    string? nome = Console.ReadLine();
    nomes[i] = nome;
}

for (int i = 0;i < 5; i++)
{
    Console.WriteLine($"Insira as notas do aluno: ");
    double nota = Convert.ToDouble(Console.ReadLine());
    notas[i] = nota;
}

foreach (string nome in nomes)
{
    Console.WriteLine($"{nome}");
}

var somaNotas = 0.0;
var totalNotas = notas.Count();
foreach (double nota in notas)
{
    somaNotas += nota;
    Console.WriteLine($"{nota}");
}
Console.WriteLine($"\nMédia: \n{somaNotas/totalNotas}");

Console.ReadKey();