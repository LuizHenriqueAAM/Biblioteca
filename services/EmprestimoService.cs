using Microsoft.EntityFrameworkCore;

namespace Biblioteca
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