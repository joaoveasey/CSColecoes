using System.Collections;

Console.WriteLine("Exercícios\n ");

//1)
//string[] frutas =
//{
//    "Maçã", "Banana", "Laranja", "Uva", "Manga","Pera", "Abacate", "Mamão", "Pêssego", "Amora"
//};

//for (int i = 0; i < frutas.Length; i++)
//{
//    Console.WriteLine($"{i} - {frutas[i]}");
//}

//Console.WriteLine($"\nSegunda fruta = {frutas[1]}\nPenúltima fruta = {frutas[8]}\n");

//frutas[2] = "Kiwi";
//frutas[9] = "Caqui";


//Array.Sort(frutas);

//Array.Reverse(frutas);

//for (int i = 0; i < frutas.Length; i++)
//{
//    Console.WriteLine($"{i} - {frutas[i]}");
//}


//2)
//Console.WriteLine("Insira aqui o número de valores do array: \n");
//int numeroDeValoresArray = Convert.ToInt32(Console.ReadLine());

//int[] MeuArray = new int[numeroDeValoresArray];
//int numeroProcurado;

//do
//{
//    Console.WriteLine("Qual número deseja procurar? (pressione 0 para sair do loop) \n");
//    numeroProcurado = Convert.ToInt32(Console.ReadLine());
//    if (!MeuArray.Contains(numeroProcurado))
//    {
//        Console.WriteLine("Número NÃO existe no array\n");
//    }
//    else
//    {
//        Console.WriteLine("Número existe no array\n");
//    }
//} while (numeroProcurado != 0);

//3)
//int[] grupo1 = new int[5];
//int[] grupo2 = new int[5];

//for (int i = 0; i < grupo1.Length; i++)
//{
//    Console.WriteLine("Informe as notas dos alunos grupo 1: ");
//    grupo1[i] = Convert.ToInt32(Console.ReadLine());
//}

//for (int i = 0; i < grupo2.Length; i++)
//{
//    Console.WriteLine("Informe as notas dos alunos grupo 2: ");
//    grupo2[i] = Convert.ToInt32(Console.ReadLine());
//}

//float mediaGrupo1 = 0;
//float totalGrupo1 = 0;

//foreach (int i in grupo1)
//{
//    totalGrupo1 += i;
//}

//float mediaGrupo2 = 0;
//float totalGrupo2 = 0;

//foreach (int i in grupo2)
//{
//    totalGrupo2 += i;
//}

//Console.WriteLine($"\nA média aritmética do grupo 1 => {totalGrupo1/grupo1.Length}\nA média aritmética do grupo 2 => {totalGrupo2 / grupo2.Length}\n");

//4)
ArrayList pessoas = new ArrayList();
Pessoa pessoa = new Pessoa();
Pessoa pessoa1 = new Pessoa();
Pessoa pessoa2 = new Pessoa();

Console.WriteLine("Insira o nome da pessoa: ");
pessoa.Nome = Console.ReadLine();
Console.WriteLine("Insira a idade da pessoa: ");
pessoa.Idade = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Insira o nome da pessoa 1: ");
pessoa1.Nome = Console.ReadLine();
Console.WriteLine("Insira a idade da pessoa 1: ");
pessoa1.Idade = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Insira o nome da pessoa 3: ");
pessoa2.Nome = Console.ReadLine();
Console.WriteLine("Insira a idade da pessoa 3: ");
pessoa2.Idade = Convert.ToInt32(Console.ReadLine());

pessoa.Exibir();
pessoa1.Exibir();
pessoa2.Exibir();

pessoas.Add("Jaime", 20);


public class Pessoa
{
    public string? Nome;
    public int Idade;
    public void Exibir()
    {
        Console.WriteLine($"Nome: {Nome}\nIdade: {Idade}\n");
    }
}