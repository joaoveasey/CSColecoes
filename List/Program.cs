Console.WriteLine("Listas Genéricas\n");

//equivalente a uma arraylist, sendo uma versão genérica e com maior desempenho pois NÃO faz boxing e unboxing!!
//List<T> , onde T é o tipo do objeto.
//inicia vazia e seus elementos são alocados sob demanda (dinâmica)

//formas equivalentes de declarar uma lista 
List<string> lista;
lista = new List<string>();

List<int> lista1 = new List<int>();
var lista2 = new List<float>();
List<double> lista3 = new();

//adicionando elementos nas listas
List<string> nomes = new();
nomes.Add("Mario");
nomes.Add("Paula");

var lista4 = new List<string>()
{
    "Paula", "Mario", "João", "José","Antonio"
};

Console.ReadKey();