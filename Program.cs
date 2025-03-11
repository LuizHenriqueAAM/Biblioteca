using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using System.Net.Http;
namespace Biblioteca;

class Program
{
    static void Main(string[] args)
    {
        
        var builder = WebApplication.CreateBuilder(args);
        var app = builder.Build();
        app.MapGet("/pesquisarlivro", LivroController.PesquisarLivro);
        app.MapGet("/Livros", LivroController.ListaDeLivros);

        app.Run();
        

    }
}
