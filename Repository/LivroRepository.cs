using Microsoft.EntityFrameworkCore;

namespace Biblioteca.Repository
{
    public class LivroRepository
    {
        public static void CriarLivro(Livro v)
        {
            using (var context = new DbConnection())
            {
                context.Livro.Add(v);
                context.SaveChanges();
            }
        }
        public static List<Livro> ListaLivros()
        {
            using (var context = new DbConnection())
            {
                return context.Livro.ToList();
            }
        }
        public static List<Livro> PesquisarLivroPorTitulo(string tituloLivro)
        {
            using (var context = new DbConnection())
            {
                return context.Livro.Where((l) => l.Titulo == tituloLivro).ToList();
            }
        }
        public static Livro PesquisarLivroPorId(int Id)
        {
            using (var context = new DbConnection())
            {
                return context.Livro.Find(Id)!;
            }
        }
        public static async Task AtualizarLivro(Livro novoLivro)
        {
            using (var context = new DbConnection())
            {
                Livro? antigo = await context.Livro.FirstOrDefaultAsync(L => L.Id == novoLivro.Id);
                if (antigo != null)
                {
                    Console.WriteLine(novoLivro.Titulo);
                    antigo.Titulo = novoLivro.Titulo;
                    antigo.ISBN = novoLivro.ISBN;
                    antigo.QuantidadeDisponivel = novoLivro.QuantidadeDisponivel;
                    //antigo.Autor = novoLivro.Autor;
                    context.Livro.Update(antigo);
                    await context.SaveChangesAsync();
                }
            }
        }
        public static void DeleteLivro(Livro livro)
        {
            using (var context = new DbConnection())
            {
                Livro? Alvo = context.Livro.Find(livro.Id);
                if (Alvo != null)
                {
                    context.Livro.Remove(Alvo);
                }
            }
        }
    }
}
