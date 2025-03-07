namespace Biblioteca;

public class LivroRepository{
    public static void CriarLivro(Livro v)
        {
            using (var context = new DbConnection())
            {
                context.Livro.Add(v);
                context.SaveChanges();
            }
        }
}