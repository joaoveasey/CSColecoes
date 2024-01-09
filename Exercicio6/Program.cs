//6) Crie um programa C# e defina um método chamado ProcessaObjetos() que possa receber um número
//variáveis de argumentos e que possa exibir os seus valores e também o tipo do objeto (Use o método
//GetType() herdado de Object) no console.

//Passe os seguintes argumentos ao invocar o método : ProcessaObjetos(1, "Maria", 3.45m, new Teste(), null)

List<object> Objetos = new List<object>();

Objetos.Add(1);
Objetos.Add("Maria");
Objetos.Add(3.45m);
Objetos.Add(new());
Objetos.Add(null);

ProcessaObjetos(Objetos);

static void ProcessaObjetos(List<object> Objetos)
{
    foreach (object obj in Objetos)
    {
        if (obj == null)
        {
            Console.WriteLine("Tipo Nulo");
        }
        Console.WriteLine(obj.GetType());
    }
}