using Microsoft.AspNetCore.Builder;
using System.Net.Http;
namespace Biblioteca;

class Program
{
    static void Main(string[] args)
    {
        /*
        var builder = WebApplication.CreateBuilder(args);
        var app = builder.Build();

        app.MapGet("/", () => "Hello World!");

        app.Run();
        */

        AutorRepository.DeleteAutor(AutorRepository.PesquisarAutorPorId(10));
    }
}
