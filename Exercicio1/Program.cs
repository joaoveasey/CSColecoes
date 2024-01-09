//1)
string[] frutas =
{
    "Maçã", "Banana", "Laranja", "Uva", "Manga","Pera", "Abacate", "Mamão", "Pêssego", "Amora"
};

for (int i = 0; i < frutas.Length; i++)
{
    Console.WriteLine($"{i} - {frutas[i]}");
}

Console.WriteLine($"\nSegunda fruta = {frutas[1]}\nPenúltima fruta = {frutas[8]}\n");

frutas[2] = "Kiwi";
frutas[9] = "Caqui";


Array.Sort(frutas);

Array.Reverse(frutas);

for (int i = 0; i < frutas.Length; i++)
{
    Console.WriteLine($"{i} - {frutas[i]}");
}