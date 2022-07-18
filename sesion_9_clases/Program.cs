/* SESION 9 - CLASES */

Puerta door = new Puerta(100, 200, 123, false);
door.MostrarEstado();

Persona alumno = new Persona();
alumno.nombre = "Roger";
alumno.fechaNacimiento = Convert.ToDateTime("10/10/1996");
alumno.registrar();

Persona2 alumna = new Persona2();
alumna.Nombre = "Rocio";
Console.WriteLine($"Puedo acceder a experiencia directamente desde la clase porque es static {Persona2.experiencia}");
Persona2.ExperienciaMetodo(); // porque es un metodo estatico no necesitamos objeto al igual que el atributo experiencia

class Puerta
{
  // Atributos
  int ancho;
  int alto;
  int color;
  bool abierta;

  // Constructor con parametros por defecto 
  public Puerta(int ancho = 50, int alto = 150, int color = 923432, bool abierta = false)
  {
    this.ancho = ancho;
    this.alto = alto;
    this.color = color;
    this.abierta = abierta;
  }

  // Métodos
  public void MostrarEstado()
  {
    Console.WriteLine($"El ancho de la puerta es: {ancho}");
    Console.WriteLine($"El alto de la puerta es: {alto}");
    Console.WriteLine($"El color de la puerta es: {color}");
  }

  // Destructor o Finalizador
  ~Puerta()
  {
    Console.WriteLine("Puerta destruida o finalizada.");
  }
}

public class Persona
{
  // Atributos
  public string? nombre;
  public DateTime fechaNacimiento;
  private int edad;

  // Métodos
  public void registrar()
  {
    calcularEdad(fechaNacimiento);
    Console.WriteLine(nombre + " con " + edad + " años de edad, ha sido registrado correctamente.");
  }
  private void calcularEdad(DateTime fechaNacimientoPersona)
  {
    DateTime fechaActual = DateTime.Now;
    edad = fechaActual.Year - fechaNacimientoPersona.Year;
  }
}

public class Persona2
{
  // Atributos
  public static string experiencia = "C#";
  private string? _nombre;
  private DateTime _fechaNacimiento;
  private int _edad;

  // Propiedades
  public int Edad
  {
    get // Encapsulación nivel abierta, por defecto es publico porque la propiedad es publica.
    {
      return _edad;
    }
    private set // Encapsulación nivel cerrado - Privado
    {
      _edad = value;
    }
  }
  public string? Nombre
  {
    get
    {
      return _nombre;
    }
    set
    {
      _nombre = value;
    }
  }
  public DateTime FechaNacimiento
  {
    get
    {
      return _fechaNacimiento;
    }
    set
    {
      _fechaNacimiento = value;
    }
  }

  // Métodos
  public void registrar()
  {
    calcularEdad(FechaNacimiento);
    Console.WriteLine(Nombre + " con " + Edad + " años de edad, ha sido registrado correctamente.");
  }
  private void calcularEdad(DateTime fechaNacimientoPersona)
  {
    DateTime fechaActual = DateTime.Now;
    Edad = fechaActual.Year - fechaNacimientoPersona.Year;
  }
  public static void ExperienciaMetodo()
  {
    Console.WriteLine("Esto es un metodo static que se puede llamar sin tener un objeto");
  }
}
/*
NOTAS:
 - Cuando ponemos parametros por defecto en un constructor no es necesario pasarlos cuando
 queremos crear un objeto porque ya tienen un valor por defecto.
 - El simbolo '~' en mac es pulsando option + ñ 
*/