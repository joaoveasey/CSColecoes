using System.Collections;
using System.ComponentModel;

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
//ArrayList pessoas = new ArrayList();

//for (int i = 0; i < 3; i++)
//{
//    Console.WriteLine("Insira o nome da pessoa: ");
//    string nome = Console.ReadLine();
//    Console.WriteLine("Insira a idade da pessoa: ");
//    int idade = int.Parse(Console.ReadLine());

//    pessoas.Add(new Pessoa
//    {
//        Nome = nome,
//        Idade = idade,
//    });
//}

//ListaPessoas(pessoas);

//Pessoa jaime = new Pessoa() { Nome = "Jaime", Idade = 20 };
//Pessoa tania = new Pessoa() { Nome = "Tânia", Idade = 18 };

//pessoas.Add(jaime); 
//pessoas.Add(tania);

//Console.WriteLine("\nLista de pessoas após adicionar Jaime e Tânia: ");
//ListaPessoas(pessoas);

//pessoas.RemoveAt(4);

//Console.WriteLine("\nLista de pessoas após remover o último elemento: ");
//ListaPessoas(pessoas);


//static void ListaPessoas(ArrayList pessoas)
//{
//    Console.WriteLine("Lista de pessoas atuais\n");

//    foreach(Pessoa pessoa in pessoas)
//    {
//        Console.WriteLine(pessoa.Exibir());
//    }
//}

//public class Pessoa
//{
//    public string? Nome;
//    public int Idade;
//    public string Exibir()
//    {
//        return Nome + " - " + Idade;
//    }
//}

////5)5- Dada uma classe Produto contendo duas propriedades : Nome (string) e Preco (decimal). Crie uma lista
//de objetos do tipo Produto usando os seguinte dados:
//Clips, R$ 3,95 - Caneta, R$ 5,99 - - Lápis, R$ 4,15 - Estojo, R$ 6,99 e Caderno, R$ 7,55
//A seguir realize as seguintes operações na lista de objetos Produto criada :
//1 - Crie um método para exibir a relação de produtos , a soma total dos preços dos produtos, a média do
//preço dos produtos e a quantidade de produtos na lista
//2- Inclua na lista o seguinte produto : Mochila, R$ 22,44 e exiba novamente a lista de produtos
//3- Ordene a lista pelo nome do produto e exiba a lista ordenada
//4- Obtenha e exiba no console os produtos com preço inferior a R$ 5,00
//5- Localize na lista o produto com nome Estojo

List<Produto> list = new List<Produto>();

Produto produto = new Produto() { Nome = "Clips", Preco = 3.95m };
Produto produto1 = new Produto() { Nome = "Caneta", Preco = 5.99m };
Produto produto2 = new Produto() { Nome = "Lápis", Preco = 4.15m };
Produto produto3 = new Produto() { Nome = "Estojo", Preco = 6.99m };
Produto produto4 = new Produto() { Nome = "Caderno", Preco = 7.55m };

list.Add(produto);
list.Add(produto1);
list.Add(produto2);
list.Add(produto3);
list.Add(produto4);

produto.Exibir();
produto1.Exibir();
produto2.Exibir();
produto3.Exibir();
produto4.Exibir();

public class Produto
{
    public string Nome;
    public decimal Preco;
    public string Exibir()
    {
        return Nome + ", R$ " + Preco;  
    }
}