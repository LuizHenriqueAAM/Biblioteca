namespace Biblioteca;

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

    public static void AtualizarLivro(Livro novoLivro)
    {
        using (var context = new DbConnection())
        {
            Livro? antigo = context.Livro.Find(novoLivro.Id);
            if (antigo != null)
            {
                Console.WriteLine("ok");
                antigo.Titulo = novoLivro.Titulo;
                antigo.ISBN = novoLivro.ISBN;
                antigo.QuantidadeDisponivel = novoLivro.QuantidadeDisponivel;
                context.Livro.Update(antigo);
                context.SaveChanges();
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
                context.SaveChanges();
            }
        }
    }
}