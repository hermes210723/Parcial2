using Microsoft.EntityFrameworkCore;
using BibliotecaEF.Models;

public class BibliotecaContext : DbContext
{
    public DbSet<Libro> Libros { get; set; }
    public DbSet<Autor> Autores { get; set; }
    public DbSet<LibroAutor> LibroAutores { get; set; }
    public DbSet<Prestamo> Prestamos { get; set; }
    public DbSet<Usuario> Usuarios { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("Server=.;Database=BibliotecaDB;Trusted_Connection=True;TrustServerCertificate=True;");
    }
}