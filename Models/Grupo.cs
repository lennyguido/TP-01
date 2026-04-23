namespace TP01.Models;

public class Grupo
{
    private Dictionary<int, Integrante> Integrantes;

    public Grupo(Dictionary<int, Integrante> integrantes)
    {
        this.Integrantes = integrantes;
    }

    public void CargaDatosManual()
    {
        int dni = 49757661;
        string nombre = "lenny";
        DateTime fechaNacimiento = new DateTime(2009, 8, 10);

        string foto = "foto.jpg";
        List<string> familiares = new List<string> { "padre", "madre" };
        List<string> intereses = new List<string> { "futbol", "musica" };

        Integrante nuevo = new Integrante(dni, nombre, fechaNacimiento, foto, familiares, intereses);

        Integrantes.Add(dni, nuevo);
    }
    public Dictionary<int, Integrante> DevolverIntegrantes(){
        return integrantes;
    }
    
    public Integrante GetIntegrante(int dni){
          if (Integrantes.ContainsKey(dni))
    {
        return Integrantes[dni];
    }
    else
    {
        return null; 
    }
}

    }
