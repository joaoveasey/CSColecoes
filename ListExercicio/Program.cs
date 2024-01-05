using ListExercicio;
using System.Runtime.CompilerServices;
using System.Transactions;

Console.WriteLine("List<T> - Exercício\n");

List<Aluno> alunos = FonteDados.GetAlunos();

//exibindo a lista pela primeira vez
ExibirAluno(alunos);

Aluno bia = new Aluno() { Nome = "Bia", Nota =  7.75 };
Aluno mario = new Aluno() { Nome = "Mario", Nota =  8.95 };
alunos.Add(bia);
alunos.Add(mario);

//exibindo a lista com os 2 novos alunos
ExibirAluno(alunos);

//exibindo a lista apos remover a amanda
var aluno1 = alunos.Find(x => x.Nome.Equals("Amanda"));
alunos.Remove(aluno1);

ExibirAluno(alunos);

//exibindo os alunos ordenados por nome
var listaOrdenada = alunos.OrderBy(x => x.Nome).ToList();

ExibirAluno(listaOrdenada);

//exibindo alunos nota maior q 8
var alunosNotaOito = alunos.FindAll(x => x.Nota >= 8);

ExibirAluno(alunosNotaOito);

Console.ReadKey();

static void ExibirAluno(List<Aluno> alunos)
{
    Console.WriteLine("\nRelação de Alunos\n");
    Console.WriteLine("\nNome\tNota");

    var somaNotas = 0.0;
    foreach (var item in alunos)
    {
        Console.WriteLine($"{item.Nome}\t{item.Nota}");
        somaNotas += item.Nota;
    }

    var mediaNotas = somaNotas / alunos.Count();

    Console.WriteLine($"\nMédia das notas: {Math.Round(mediaNotas, 2)}");
    Console.WriteLine($"\nTotal de Alunos: {alunos.Count()}");
}