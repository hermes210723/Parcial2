using BibliotecaEF.Models;

public class Usuario
{
    public int Id { get; set; }
    public required string Nombre { get; set; }
    public required string Programa { get; set; }
    public DateTime FechaNacimiento { get; set; }
    public required string Correo { get; set; }
    public required string Password { get; set; }

    public required ICollection<Prestamo> Prestamos { get; set; }
}