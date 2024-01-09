List<Produto> Produtos = new List<Produto>();

Produto produto = new Produto() { Nome = "Clips", Preco = 3.95m };
Produto produto1 = new Produto() { Nome = "Caneta", Preco = 5.99m };
Produto produto2 = new Produto() { Nome = "Lápis", Preco = 4.15m };
Produto produto3 = new Produto() { Nome = "Estojo", Preco = 6.99m };
Produto produto4 = new Produto() { Nome = "Caderno", Preco = 7.55m };

Produtos.Add(produto);
Produtos.Add(produto1);
Produtos.Add(produto2);
Produtos.Add(produto3);
Produtos.Add(produto4);

Exibir(Produtos);

//adicionando mochila e exibindo novamente a lista
Produto mochila = new Produto() { Nome = "Mochila", Preco = 22.44m };
Produtos.Add(mochila);

Exibir(Produtos);

//ordenando a lista por nome
var listaOrdenadaNome = Produtos.OrderBy(n => n.Nome).ToList();

Exibir(listaOrdenadaNome);

//ordenando a lista por preço
var listaOrdenadaPreco = Produtos.OrderBy(n => n.Preco).ToList();

Exibir(listaOrdenadaPreco);

//obtendo e exibindo no console apenas produtos com valor < 5
var produtosMenor5 = Produtos.FindAll(n => n.Preco < 5).ToList();

Exibir(produtosMenor5);

//localizando o produto estojo
var estojo = Produtos.Find(n => n.Nome.Equals("Estojo"));

Console.WriteLine($"{estojo.Nome}, R${estojo.Preco}");

//metodo exibir
static void Exibir(List<Produto> Produtos)
{
    decimal precoTotal = 0;
    foreach (var item in Produtos)
    {
        Console.WriteLine($"{item.Nome}, R${item.Preco}");
        precoTotal += item.Preco;
    }
    Console.WriteLine($"A soma total dos preços: {precoTotal}");
    Console.WriteLine($"A média dos preços: {precoTotal / Produtos.Count}");
    Console.WriteLine($"A quantidade de produtos: {Produtos.Count}\n\n");
}

//classe produto
public class Produto
{
    public string Nome;
    public decimal Preco;
}