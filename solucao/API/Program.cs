//Testar as APIs
// - Rest CLient - extensão do vs code
// - Postman
// - Insomnia 

//MINIMAL APIs
using System.Runtime.InteropServices;
using API.models;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

//EndPoints - Funcionalidades
//Configurar a URL e p método/verbo HTTP
app.MapGet("/", () => "API de Produtos");

List<Produto> produtos = new List<Produto>();
produtos.Add(new Produto()
{
    Nome = "Notebook",
    Preco = 5000,
    Quantidade = 54
});
produtos.Add(new Produto()
{
    Nome = "avião",
    Preco = 50000000,
    Quantidade = 2
});

produtos.Add(new Produto()
{
    Nome = "PC",
    Preco = 10000,
    Quantidade = 60
});


app.MapGet("/produto/listar", () =>
{
    return Results.Ok(produtos);
});

app.MapGet("/produto/cadastrar/{nome}", (string nome) =>
{
    Produto produto = new Produto();
    produto.Nome = nome;
    produtos.Add(produto);
    return Results.Ok(produtos);
});

//Criar um funcionalidade para receber informações
// - Receber informações pela URL da req
// - Receber informações pelo corpo da req
//Guardar as informações em uma lista

app.Run();

//C# - Utilização dos gets e sets
//Produto produto = new Produto();]
//produto.Preco = 5;
//Console.WriteLine(produto.Preco);


//Java - Utilização dos gets e sets
//Produto produto = new Produto();
//produto.SetPreco(5);
//Console.WriteLine("Preço: " + produto.GetPreco());

