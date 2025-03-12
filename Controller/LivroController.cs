using Microsoft.AspNetCore.Http;
using Biblioteca.Services;
using System.Runtime.InteropServices;
using System.Text.Json.Serialization;
using System.Text.Json;
namespace Biblioteca.Controller
{
    public class LivroController 
    {
        //Isso aqui pesquisa o livro leo ID
        public static Livro PesquisarLivro(HttpContext contexto)
        {
            var id = contexto.Request.Query.Where((q) => q.Key == "id").FirstOrDefault();
            return LivroService.PesquisarLivro(int.Parse(id.Value!));
        }
        //Retorna a lista completa de livros
        public static List<Livro> ListaDeLivros(HttpContext contexto){

            return LivroService.ListaDeLivros();
        }
        //Modifica um livro existente
        public static async Task AtualizarLivro(HttpContext contexto)
        {
            
            
            Livro novoLivro = await JsonSerializer.DeserializeAsync<Livro>(contexto.Request.BodyReader.AsStream())!;
            
            await LivroService.AtualizarLivro(novoLivro);
        }
    }
}