using Microsoft.AspNetCore.Http;
using Biblioteca.Services;
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
        public static void AtualizarLivro(HttpContext contexto)
        {
            LivroService.AtualizarLivro();
        }
    }
}