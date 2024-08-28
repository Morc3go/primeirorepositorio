//Testar as APIs
// - Rest CLient - extensão do vs code
// - Postman
// - Insomnia 

//MINIMAL APIs
using System.Runtime.InteropServices;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

//EndPoints - Funcionalidades
//Configurar a URL e p método/verbo
app.MapGet("/", () => "Hello World em C#");

app.MapGet("/segundafuncionalidade", () => "sla");

app.MapGet("/retornarendereco", () => 
{
    dynamic endereco = new {
        rua = "Parigot de Souza",
        numero = 5300,
        cep = "81290-350"
    };
    return endereco;
});

app.Run();
