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
        for (int i = 0; i < alunos.Length; i++)
        {
            Console.WriteLine($"Índice {i} - {alunos[i]}");
        }
    }

    public string this[int i]
    {
        get
        {
            if (i >= 0 && i <= alunos.Length)
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