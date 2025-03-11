using System.Data.Common;
using Microsoft.AspNetCore.SignalR;

public class Emprestimo
{
    public int Id { get; set; }
    public Livro? Livro { get; set; }
    public Usuario? Usuario { get; set; }
    public DateTime DataEmprestimo { get; set; }
    public DateTime DataDevoluçãoPrevista { get; set; }
    public DateTime DataDevoluçãoReal { get; set; }
}