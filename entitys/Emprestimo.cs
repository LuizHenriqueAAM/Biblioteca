using System.Data.Common;

public class Emprestimo
{
    public int Id { get; set; }
    public Livro? livro { get; set; }
    public Usuario? usuario { get; set; }
    public DateTime DataEmprestimo { get; set; }
    public DateTime DataDevoluçãoPrevista { get; set; }
    public DateTime DataDevoluçãoReal { get; set; }

}