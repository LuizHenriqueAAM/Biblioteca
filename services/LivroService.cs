using Microsoft.AspNetCore.Http.Timeouts;
using Biblioteca.Repository;
using System.Threading.Tasks;
namespace Biblioteca.Services
{
    public class LivroService 
    {
        public static Livro PesquisarLivro(int id)
        {
            return LivroRepository.PesquisarLivroPorId(id);
        }
        public static List<Livro> ListaDeLivros()
        {
            return LivroRepository.ListaLivros();
        }
        public static async Task AtualizarLivro(Livro livro)
        {
            await LivroRepository.AtualizarLivro(livro);
        }
    }
}