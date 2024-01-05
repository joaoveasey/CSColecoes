Console.WriteLine("List - Métodos Find\n");

List<string> frutas = new() 
{ 
    "Uva", "Banana", "Pera", "Maçã", "Abacate", "Laranja", "Morango" 
};

//usando predicado como função
var fruta1 = frutas.Find(Procura);
Console.WriteLine("Predicado => "+fruta1);

//usando a expressão lambda
var fruta2 = frutas.Find(i => i.Contains("n"));
Console.WriteLine("Lambda => "+fruta2);

Console.ReadKey();

static bool Procura(string item)
{
    return item.Contains("n");
}