using Microsoft.EntityFrameworkCore;

namespace Biblioteca{
    class EmprestimoRepository{

        public static void CriarEmprestimo(Emprestimo emprestimo){
            using(var context = new DbConnection())
            {
                context.Emprestimo.Add(emprestimo);
                context.SaveChanges();
            }
        }

        
    }
}