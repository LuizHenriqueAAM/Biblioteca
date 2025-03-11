using Microsoft.AspNetCore.Http.Timeouts;

namespace Biblioteca
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
    }
}