public class Autor
{
    public int Id { get; set; }
    public required string Nombre { get; set; }
    public required string Nacionalidad { get; set; }
    public required ICollection<LibroAutor> LibroAutores { get; set; }
}