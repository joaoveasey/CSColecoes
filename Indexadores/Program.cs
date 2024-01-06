using Indexadores;

Time time = new Time();

//atribui valores = get
time[1] = "Palmeiras";
time[3] = "Santos";
time[4] = "Vasco";
time[-1] = "Flamengo";
time[1000] = "Corinthians";

//obtendo os valores = set
string valor1 = time[1];
string valor2 = time[3];
string valor3 = time[4];
string valor4 = time[-1];
string valor5 = time[1000];

//exibir valores
Console.WriteLine(valor1);
Console.WriteLine(valor2);
Console.WriteLine(valor3);
Console.WriteLine(valor4);
Console.WriteLine(valor5);

Console.ReadKey();