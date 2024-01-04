
using System.Collections;

var lista = new ArrayList() { "Ana", 5, true, " ", 1.1, "Zé", 3, 9, 0 };

lista.Remove(null); //remove o primeiro elemento que seja igual a null

lista.RemoveAt(4); //remove em determinado indice

lista.RemoveRange(0, 2); //a partir do elemento 0, remover 2 elementos

lista.Contains("Zé"); //retorna true pois existe "Zé" na Arraylist

lista.Sort(); //ordena todos os elementos ascendente, apenas para elementos de tipos iguais

lista.Clear(); //count = 0

Console.ReadKey();