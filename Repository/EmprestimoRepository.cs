using Microsoft.EntityFrameworkCore;

namespace Biblioteca.Repository{
    class EmprestimoRepository{
        public static void CriarEmprestimo(Emprestimo emprestimo){
            using(var context = new DbConnection())
            {
                context.Emprestimo.Add(emprestimo);
                context.SaveChanges();
            }
        }
        public static Emprestimo PesquisarEmprestimoPorId(int Id)
        {
            using (var context = new DbConnection())
            {
                return context.Emprestimo.Find(Id)!;
            }
        }
        public static void AtualizarEmprestimo(Emprestimo novoEmprestimo)
        {
            using (var context = new DbConnection())
            {
                Emprestimo? antigo = context.Emprestimo.Find(novoEmprestimo.Id);
                if (antigo != null)
                {
                    Console.WriteLine("ok");
                    antigo.Livro!.titulo = novoEmprestimo.Livro!.titulo;
                    antigo.Usuario!.Id = novoEmprestimo.Usuario!.Id;
                    antigo.DataEmprestimo = novoEmprestimo.DataEmprestimo;
                    antigo.DataDevoluçãoPrevista = novoEmprestimo.DataDevoluçãoPrevista;
                    context.Emprestimo.Update(antigo);
                    context.SaveChanges();
                }
            }
        }
       public static void DeleteEmprestimo(Emprestimo emprestimo)
        {
            using (var context = new DbConnection())
            {
                Emprestimo? Alvo = context.Emprestimo.Find(emprestimo.Id);
                if (Alvo != null)
                {
                    context.Emprestimo.Remove(Alvo);
                    context.SaveChanges();
                }
            }
        }
        
    }
}