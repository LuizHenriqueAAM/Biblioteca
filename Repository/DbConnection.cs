using System;
using System.Net.Security;
using Microsoft.EntityFrameworkCore;
using Pomelo.EntityFrameworkCore.MySql;
namespace Biblioteca.Repository
{
    public class DbConnection : DbContext
    {
        static readonly string connectionString = "Server=localhost;User ID=root; Password=1234567;Database=bibliotecadb";
        public DbSet<Autor> Autor { get; set; }
        public DbSet<Livro> Livro { get; set; }
        public DbSet<Usuario> Usuario { get; set; }
        public DbSet<Emprestimo> Emprestimo { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString));
        }
        /*
        using (var context = new DbConnection())
        {
            Autor teste = new(){Nome = "teste", DataNascimento = DateTime.Now, Nacionalidade="brasil"};
            context.Autor.Add(teste);
            context.SaveChanges();
        }
        */
    }
}