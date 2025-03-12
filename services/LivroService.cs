using Microsoft.AspNetCore.Http.Timeouts;
using Biblioteca.Repository;
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

        public static void AtualizarLivro(Livro livro)
        {
            LivroRepository.AtualizarLivro(livro);
        }

        internal static void AtualizarLivro()
        {
            throw new NotImplementedException();
        }
    }
}