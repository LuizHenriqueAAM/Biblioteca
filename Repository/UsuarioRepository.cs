using Microsoft.EntityFrameworkCore;

namespace Biblioteca.Repository
{
    class UsuarioRepository
    {
        public static void CriarUsuario(Usuario u)
        {
            using (var context = new DbConnection())
            {
                context.Usuario.Add(u);
                context.SaveChanges();
            }
        }
        public static List<Usuario> PesquisarUsuarioPorNome(string nomeUsuario)
        {
            using (var context = new DbConnection())
            {
                return context.Usuario.Where((u) => u.Nome == nomeUsuario).ToList();
            }
        }

        public static Usuario PesquisarUsuarioPorId(int Id)
        {
            using (var context = new DbConnection())
            {
                return context.Usuario.Find(Id)!;
            }
        }

        public static void AtualizarUsuario(Usuario novoUsuario)
        {
            using (var context = new DbConnection())
            {
                Usuario? antigo = context.Usuario.Find(novoUsuario.Id);
                if (antigo != null)
                {
                    Console.WriteLine("ok");
                    antigo.Nome = novoUsuario.Nome;
                    antigo.Email = novoUsuario.Email;
                    context.Usuario.Update(antigo);
                    context.SaveChanges();
                }
            }
        }
        public static void DeleteUsuario(Usuario Usuario)
        {
            using (var context = new DbConnection())
            {
                Usuario? Alvo = context.Usuario.Find(Usuario.Id);
                if (Alvo != null)
                {
                    context.Usuario.Remove(Alvo);
                    context.SaveChanges();
                }
            }
        }
    }
}
