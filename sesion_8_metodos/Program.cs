/* 
* SESION 8 - METODOS */

// llamada a la funcion
float f = 3.1415f;
EscribirNumeroReal(f);

// llamada a la función
SumaDeNumerosReales(1.34f, 98.34f);

// Función que escribe un número
void EscribirNumeroReal(float n)
{
  Console.WriteLine(n.ToString("#.####"));
}

// Función que suma dos números
void SumaDeNumerosReales(float a, float b)
{
  float resultado = a + b;
  Console.WriteLine(resultado.ToString("#.##"));
}

/* RECURSIVIDAD */
/* 
 * Factorial -> !
 * 1! = 1
 * 2! = 2 * 1 = 2 
 * 3! = 3 * 2 * 1 = 3
*/

/* for (int i = 0; i <= 5; i++)
{
  long resultado = CalcularFactorial(i);
  Console.WriteLine(i + ": " + resultado);
} */

long CalcularFactorial(int n)
{
  if (n == 1)
  {
    return 1;
  }
  return n * CalcularFactorial(n - 1);
}
// Parece ser que la recursividad es cuando dentro de la propia función se llama a sí misma.

// Instanciamos un nuevo objeto de la clase Puerta
Puerta door = new Puerta();
door.CambiarAlto(200);
door.Abrir();
door.MostrarEstado();
door.Cerrar();
door.MostrarEstado();

// Clase
public class Puerta
{
  // Atributos
  int ancho;
  int alto;
  string? color;
  string? material;
  bool abierta;

  // Métodos
  public void CambiarAlto(int n)
  {
    alto = n;
  }
  public void PintarPuerta(string color)
  {
    // el atributo de la clase Puerta llamado 'color' es igual al parametro del método PintarPuerta llamado 'color'
    this.color = color;
  }
  public void Abrir()
  {
    abierta = true;
  }
  public void Cerrar()
  {
    abierta = false;
  }
  public void MostrarEstado()
  {
    Console.WriteLine("Ancho: {0}", ancho);
    Console.WriteLine("Alto: {0}", alto);
    Console.WriteLine("Material: {0}", material);
    Console.WriteLine("Color: {0}", color);
    Console.WriteLine("¿Abierta?: {0}", abierta);
  }

}