namespace BibliotecaEF.Models
{
    public class Libro
    {
    public int Id { get; set; }
    public required string Titulo { get; set; }
    public required string Editorial { get; set; }
    public required string Area { get; set; }
    public string? CoverUrl { get; set; }
    public string? DigitalUrl { get; set; }
    public bool DisponibleFisico { get; set; }
    public required ICollection<LibroAutor> LibroAutores { get; set; }
    public required ICollection<Prestamo> Prestamos { get; set; }
    }
}