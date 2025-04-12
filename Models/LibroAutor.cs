using BibliotecaEF.Models;

public class LibroAutor
{
    public int Id { get; set; }
    public int LibroId { get; set; }
    public required Libro Libro { get; set; }
    public int AutorId { get; set; }
    public required Autor Autor { get; set; }
}