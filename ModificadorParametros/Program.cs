Console.WriteLine("Soma dos números inteiros");
//nesse caso usamos um array como parâmetro do método, para somar todos os valores presentes no array

//NomeDoMetodo(params tipo[] nomeDaVariavel) {}

int[] valores = {1,2,3};

var resultado = Calcular.Soma(valores);
Console.WriteLine(resultado);

var resultado2 = Calcular.Soma(1,2,3,4,5);
Console.WriteLine(resultado2);

Console.ReadKey();

public class Calcular
{
    public static int Soma(params int[] numeros)
    {
        int total = 0;
        foreach(int numero in numeros)
        {
            total += numero;
        }
        return total;
    }
}