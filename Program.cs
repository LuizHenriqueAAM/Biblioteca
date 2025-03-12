using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using System.Net.Http;
using Biblioteca.Controller;
namespace Biblioteca
{
    class Program
    {
        static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            var app = builder.Build();
            app.MapGet("/pesquisarlivro", LivroController.PesquisarLivro);
            app.MapGet("/Livro", LivroController.ListaDeLivros);
            app.MapPut("/Livro", LivroController.AtualizarLivro);
            app.MapDelete("/Livro",LivroController.DeletarLivro);
            app.MapPost("/Livro", LivroController.CriarLivro);
            app.Run();
        }
    }
}