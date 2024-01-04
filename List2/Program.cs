Console.WriteLine("Listas - Métodos e Operações\n");

//inclusão de itens => Add(T value); e Insert(int index, T value);

//inclusão de coleções => AddRange(ICollection); e InsertRange(int index, ICollection);

//acesso aos elementos => lista[indice]; -> caso não exista esse indice -> System.ArgumentOutOfRangeException

//iterar na lista => laço for(Count) e laço foreach

//verificar se um elemento está na lista => Contains(T);

//remover itens específicos => Remove(T value), RemoveAt(int index) e RemoveRange(int index, int count);

//ordenar => Sort(); 

//remover todos os itens => Clear();



//declarando uma lista e atribuindo seus valores
var lista = new List<string>() 
{
    "Maria", "Ana", "Pedro", "Carlos", "Zé"
};

lista.Add("Marta");

lista.Insert(2, "Bia");

//adicionando uma coleção em outra
string[] array1 = { "Diná", "Antônio" };

lista.AddRange(array1);

lista.InsertRange(1, array1);

//removendo itens
lista.Remove("Maria");

lista.RemoveAt(2);

lista.RemoveRange(0, 2);

//acessando elementos usando o índice
var primeiro = lista[0];
var ultimo = lista[6];

Console.WriteLine(primeiro);
Console.WriteLine(ultimo);

//qtd de itens na lista
Console.WriteLine(lista.Count + " itens");

//iteração usando for
for(int i = 0; i < lista.Count; i++)
{
    Console.WriteLine($"{lista[i]}");
}

//iteração usando foreach
foreach (var item in lista)
{
    Console.WriteLine(item);
}

//verificar se um elemento está na lista
var res1 = lista.Contains("Diná");

var res2 = lista.Contains("Dina"); //retorna um boolean

//ordenando e removendo todos os itens
lista.Sort();

lista.Clear();

Console.ReadKey();