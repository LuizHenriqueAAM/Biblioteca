using System;
using System.Net.Security;
using Microsoft.EntityFrameworkCore;
using Pomelo.EntityFrameworkCore.MySql;
namespace Biblioteca;
public class DbConnection : DbContext
{
    static readonly string connectionString = "Server=localhost;User ID=root; Password=1234567;Database=bibliotecadb";
    public DbSet<Autor> Autor { get; set; }
    public DbSet<Livro> Livros { get; set; }
    public DbSet<Usuario> Usuario { get; set; }
    public DbSet<Emprestimo> Emprestimo { get; set; }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString));
    }
    /*
    using (var context = new DbConnection())
    {
        Autor andrew = new(){Nome = "andrew", DataNascimento = DateTime.Now, Nacionalidade="brasil"};
        context.Autor.Add(andrew);
        context.SaveChanges();
    }
    */
}