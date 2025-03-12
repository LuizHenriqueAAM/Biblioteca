using Microsoft.EntityFrameworkCore;

namespace Biblioteca.Repository
{
    class AutorRepository
    {
        public static void CriarAutor(Autor a)
        {
            using (var context = new DbConnection())
            {
                context.Autor.Add(a);
                context.SaveChanges();
            }
        }
        public static List<Autor> PesquisarAutorPorNome(string nomeAutor)
        {
            using (var context = new DbConnection())
            {
                return context.Autor.Where((a) => a.Nome == nomeAutor).ToList();
            }
        }

        public static Autor PesquisarAutorPorId(int Id)
        {
            using (var context = new DbConnection())
            {
                return context.Autor.Find(Id)!;
            }
        }

        public static void AtualizarAutor(Autor novoAutor)
        {
            using (var context = new DbConnection())
            {
                Autor? antigo = context.Autor.Find(novoAutor.Id);
                if (antigo != null)
                {
                    Console.WriteLine("ok");
                    antigo.Nacionalidade = novoAutor.Nacionalidade;
                    antigo.Nome = novoAutor.Nome;
                    context.Autor.Update(antigo);
                    context.SaveChanges();
                }
            }
        }
        public static void DeleteAutor(Autor Autor)
        {
            using (var context = new DbConnection())
            {
                Autor? Alvo = context.Autor.Find(Autor.Id);
                if(Alvo != null)
                {
                    context.Autor.Remove(Alvo);
                    context.SaveChanges();
                }
            }
        }
    }
}