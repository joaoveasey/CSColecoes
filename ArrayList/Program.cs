using System.Collections;

Console.WriteLine("ArrayList\n");

//outras formas de declarar um arraylist:

ArrayList lista = new ArrayList();
var lista1 = new ArrayList();
ArrayList lista2 = new();

//declarando e já atribuindo uma capacidade:

ArrayList lista3 = new ArrayList(5);
var lista4 = new ArrayList(5);
ArrayList lista5 = new(5); 


//declarando valores no arraylist:

ArrayList lista6 = new ArrayList();

lista6.Add("Paulo");
lista6.Add(15);
lista6.Add("M");
lista6.Add(100.00);
lista6.Add(true);
lista6.Add(" ");
lista6.Add(null);


ArrayList lista7 = new ArrayList()
{
    "Paulo", 15, "M", 100.00, true, "" , null
};


Console.ReadKey();  