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

////5)
//List<Produto> Produtos = new List<Produto>();

//Produto produto = new Produto() { Nome = "Clips", Preco = 3.95m };
//Produto produto1 = new Produto() { Nome = "Caneta", Preco = 5.99m };
//Produto produto2 = new Produto() { Nome = "Lápis", Preco = 4.15m };
//Produto produto3 = new Produto() { Nome = "Estojo", Preco = 6.99m };
//Produto produto4 = new Produto() { Nome = "Caderno", Preco = 7.55m };

//Produtos.Add(produto);
//Produtos.Add(produto1);
//Produtos.Add(produto2);
//Produtos.Add(produto3);
//Produtos.Add(produto4);

//Exibir(Produtos);

////adicionando mochila e exibindo novamente a lista
//Produto mochila = new Produto() { Nome = "Mochila", Preco = 22.44m };
//Produtos.Add(mochila);

//Exibir(Produtos);

////ordenando a lista por nome
//var listaOrdenadaNome = Produtos.OrderBy(n=> n.Nome).ToList();

//Exibir(listaOrdenadaNome);

////ordenando a lista por preço
//var listaOrdenadaPreco = Produtos.OrderBy(n=> n.Preco).ToList();

//Exibir(listaOrdenadaPreco);

////obtendo e exibindo no console apenas produtos com valor < 5
//var produtosMenor5 = Produtos.FindAll(n => n.Preco < 5).ToList();

//Exibir(produtosMenor5);

////localizando o produto estojo
//var estojo = Produtos.Find(n => n.Nome.Equals("Estojo"));

//Console.WriteLine($"{estojo.Nome}, R${estojo.Preco}");

////metodo exibir
//static void Exibir(List<Produto> Produtos)
//{
//    decimal precoTotal = 0;
//    foreach(var item in Produtos)
//    {
//        Console.WriteLine($"{item.Nome}, R${item.Preco}");
//        precoTotal += item.Preco;
//    }
//    Console.WriteLine($"A soma total dos preços: {precoTotal}");
//    Console.WriteLine($"A média dos preços: {precoTotal / Produtos.Count}");
//    Console.WriteLine($"A quantidade de produtos: {Produtos.Count}\n\n");
//}

////classe produto
//public class Produto
//{
//    public string Nome;
//    public decimal Preco;
//}

//6)
//List<object> Objetos = new List<object>();

//Objetos.Add(1);
//Objetos.Add("Maria");
//Objetos.Add(3.45m);
//Objetos.Add(new());
//Objetos.Add(null);

//ProcessaObjetos(Objetos);

//static void ProcessaObjetos(List<object> Objetos)
//{
//    foreach (object obj in Objetos)
//    {
//        if(obj == null)
//        {
//            Console.WriteLine("Tipo Nulo");
//        }
//        Console.WriteLine(obj.GetType());
//    }
//}

//7)
Aluno aluno = new Aluno();
aluno[0] = "João";
aluno[1] = "Maria";
aluno[2] = "Carlos";
aluno[3] = "Ana";
aluno[4] = "Pedro";
aluno[5] = "Laura";
aluno[6] = "Lucas";
aluno[7] = "Isabela";
aluno[8] = "Fernando";
aluno[9] = "Juliana";

string valor0 = aluno[0];
string valor1 = aluno[1];
string valor2 = aluno[2];
string valor3 = aluno[3];
string valor4 = aluno[4];
string valor5 = aluno[5];
string valor6 = aluno[6];
string valor7 = aluno[7];
string valor8 = aluno[8];
string valor9 = aluno[9];

aluno.Exibir();

public class Aluno
{
    string[] alunos = new string[10];
    
    public void Exibir()
    {
        for(int i = 0; i < alunos.Length; i++)
        {
            Console.WriteLine($"Índice {i} - {alunos[i]}");
        }
    }

    public string this [int i]
    {
        get
        {
            if (i>= 0 && i <= alunos.Length)
            {
                return alunos[i];
            }
            return "Erro";
        }
        set
        {
            if (i >= 0 && i <= alunos.Length)
            {
                alunos[i] = value;
            }
        }
    }
}