//4)
using System.Collections;

ArrayList pessoas = new ArrayList();

for (int i = 0; i < 3; i++)
{
    Console.WriteLine("Insira o nome da pessoa: ");
    string nome = Console.ReadLine();
    Console.WriteLine("Insira a idade da pessoa: ");
    int idade = int.Parse(Console.ReadLine());

    pessoas.Add(new Pessoa
    {
        Nome = nome,
        Idade = idade,
    });
}

ListaPessoas(pessoas);

Pessoa jaime = new Pessoa() { Nome = "Jaime", Idade = 20 };
Pessoa tania = new Pessoa() { Nome = "Tânia", Idade = 18 };

pessoas.Add(jaime);
pessoas.Add(tania);

Console.WriteLine("\nLista de pessoas após adicionar Jaime e Tânia: ");
ListaPessoas(pessoas);

pessoas.RemoveAt(4);

Console.WriteLine("\nLista de pessoas após remover o último elemento: ");
ListaPessoas(pessoas);


static void ListaPessoas(ArrayList pessoas)
{
    Console.WriteLine("Lista de pessoas atuais\n");

    foreach (Pessoa pessoa in pessoas)
    {
        Console.WriteLine(pessoa.Exibir());
    }
}

public class Pessoa
{
    public string? Nome;
    public int Idade;
    public string Exibir()
    {
        return Nome + " - " + Idade;
    }
}