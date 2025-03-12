using Microsoft.EntityFrameworkCore;

namespace Biblioteca.Services
{
    class EmprestimoService
    {
        public static void VerificarAtraso(Emprestimo emprestimo)
        {
            if(emprestimo.DataDevoluçãoReal > emprestimo.DataDevoluçãoPrevista)
            {
                
            }
        }
    }

}