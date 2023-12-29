using System.Collections;

Console.WriteLine("ArrayList 2\n");
//podemos utilizar metodos do arraylist:
//add - permite incluir elementos no final do arraylist
//insert - permite incluir um elemento em uma posição qualquer usando um índice específico => Insert(int index, Object value);

var lista1 = new ArrayList() { "Maria", 5, true, " ", null };

//lista.Add(3.5);

//lista.Insert(2, "Paulo");

//-----------podemos adicionar coleção de elementos-----

int[] array = { 1, 2, 3, 4, 5, 6 };

lista1.AddRange(array);


Console.ReadKey();