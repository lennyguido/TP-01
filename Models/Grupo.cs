namespace TP01.Models;

public class Grupo
{
    private Dictionary<int, Integrante> Integrantes;

    public Grupo()
    {
        Integrantes = new Dictionary<int, Integrante>();
         CargaDatosManual();
    }

    public void CargaDatosManual()
    {
       

        Integrante lenny = new Integrante( 49757661,"lenny",new DateTime(2009, 8, 10),"/images/lenny.jpg.jpg",new List<string> { "padre", "madre" },new List<string> { "futbol", "musica" });
        Integrante tarsi = new Integrante(50154645,"tarsi",new DateTime(2010, 2, 20),"/images/tarsi.jpg.jpg"
        ,new List<string> { },new List<string> { "futbol", "deporte" });      
        Integrantes.Add(49757661, lenny);
        Integrantes.Add(50154645, tarsi);
    }

    public Dictionary<int, Integrante> DevolverIntegrantes()
    {
        return Integrantes;
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
