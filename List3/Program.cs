Console.WriteLine("List - Métodos Find\n");

List<string> frutas = new() 
{ 
    "Uva", "Banana", "Pera", "Maçã", "Abacate", "Laranja", "Morango" 
};

//usando predicado como função
var fruta1 = frutas.Find(Procura);
Console.WriteLine("Predicado => "+fruta1);

//usando a expressão lambda
var fruta2 = frutas.Find(i => i.Contains('n'));
Console.WriteLine("Find => "+fruta2);

var fruta3 = frutas.FindLast(i => i.Contains('n'));
Console.WriteLine("FindLast => " + fruta3);

var fruta4 = frutas.FindIndex(i => i.Contains('n'));
Console.WriteLine("FindIndex =>  Indice = ["+ fruta4 +"] Item = " + frutas[fruta4]);

var fruta5 = frutas.FindLastIndex(i => i.Contains('n'));
Console.WriteLine("FindLastIndex =>  Indice = [" + fruta5 + "] Item = " + frutas[fruta5]);

var frutas6 = frutas.FindAll(i => i.Contains('n'));
Console.Write("FindAll: ");
foreach (var fruta in frutas6)
{
    Console.Write($"{fruta} ");
}



Console.ReadKey();

static bool Procura(string item)
{
    return item.Contains("n");
}