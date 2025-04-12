using BibliotecaEF.Models;

public class Prestamo
{
    /// <summary>
    /// solo para ver si se guardan los cambios en GitHub
    /// </summary>
    public int Id { get; set; }
    public DateTime FechaPrestamo { get; set; }
    public DateTime FechaDevolucion { get; set; }
    public bool Devuelto { get; set; }

    public int UsuarioId { get; set; }
    public required Usuario Usuario { get; set; }
    public int LibroId { get; set; }
    public required Libro Libro { get; set; }
}