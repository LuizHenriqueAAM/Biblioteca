using Microsoft.AspNetCore.Http.Timeouts;
using Biblioteca.Repository;
using System.Threading.Tasks;
namespace Biblioteca.Services
{
    public class LivroService 
    {
        public static void CriarLivro(Livro livro)
        {
            LivroRepository.CriarLivro(livro);
        }
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
        public static void DeletarLivro(Livro livro)
        {
            LivroRepository.DeleteLivro(livro);
        }
    }
}