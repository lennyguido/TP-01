namespace TP01.Models;

public class Integrante
{
    private int dni;
    private string nombre;
    private DateTime fechaNacimiento;
    private string foto;
    private List<string> familiares;
    private List<string> intereses;

    public Integrante(int dni, string nombre, DateTime fechaNacimiento, string foto, List<string> familiares, List<string> intereses)
    {
        this.dni = dni;
        this.nombre = nombre;
        this.fechaNacimiento = fechaNacimiento;
        this.foto = foto;
        this.familiares = familiares;
        this.intereses = intereses;
    }
}