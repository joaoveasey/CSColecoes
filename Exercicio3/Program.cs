//3)
int[] grupo1 = new int[5];
int[] grupo2 = new int[5];

for (int i = 0; i < grupo1.Length; i++)
{
    Console.WriteLine("Informe as notas dos alunos grupo 1: ");
    grupo1[i] = Convert.ToInt32(Console.ReadLine());
}

for (int i = 0; i < grupo2.Length; i++)
{
    Console.WriteLine("Informe as notas dos alunos grupo 2: ");
    grupo2[i] = Convert.ToInt32(Console.ReadLine());
}

float totalGrupo1 = 0;

foreach (int i in grupo1)
{
    totalGrupo1 += i;
}

float totalGrupo2 = 0;

foreach (int i in grupo2)
{
    totalGrupo2 += i;
}

Console.WriteLine($"\nA média aritmética do grupo 1 => {totalGrupo1 / grupo1.Length}\nA média aritmética do grupo 2 => {totalGrupo2 / grupo2.Length}\n");