/* SESION 13 - USO DE INTERFACES */

var persona = new Persona();

public class Persona : IPersonas
{
  public string Nombre { get; set; }
  public string Apellido { get; set; }
  public int Edades { get; set; }
  public bool EnActivo { get; set; }
  public DateOnly FechaNacimiento { get; set; }

  // Constructor 
  public Persona()
  {
    PreguntarDatos(); // Cuando instanciemos la clase Persona el objeto creado ejecutará esta función "por defecto".
    EscribirDatos();
  }

  public void PreguntarDatos()
  {
    Console.WriteLine("¿Cual es tu nombre?");
    string? nombre = Console.ReadLine();
    if (nombre == null)
    {
      Console.WriteLine("No has introducido ningún nombre.");
    }
    else
    {
      Nombre = nombre;
    }
    Console.WriteLine("¿Cual es tu fecha de nacimiento?");
    var fecha = Console.ReadLine();
    FechaNacimiento = DateOnly.Parse(fecha);
  }
  public void EscribirDatos()
  {
    Console.WriteLine($"Nombre: {Nombre}, Fecha de Nacimiento: {FechaNacimiento}");
  }
}

public interface IPersonas
{
  public string Nombre { get; set; }
  public string Apellido { get; set; }
  public int Edades { get; set; }
  public bool EnActivo { get; set; }
  public DateOnly FechaNacimiento { get; set; }

  public void PreguntarDatos();
  public void EscribirDatos();

}