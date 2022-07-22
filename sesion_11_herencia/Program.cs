/* SESION 11 - Herencia */

Vehiculo vehiculo = new Vehiculo();
vehiculo.Arrancar();

Coche coche = new Coche();
coche.Arrancar(); // Podemos acceder a este metodo porque hemos heredado de la clase Vehiculo

// Clase padre
class Vehiculo
{
  /* Ya no es necesario crear un atributo y después el metodo para modificarlo o obtnerlo.
  Ahora declaramos directamente como propiedad con get y set. */
  public float Combustible { get; set; }
  public int Aforo { get; set; }
  public void Arrancar()
  {
    Console.WriteLine("Arrancaaa");
  }
}

// Clase hija que hereda de Vehiculo
class Coche : Vehiculo
{
  public int Ruedas { get; set; }
  public void DetenerCoche()
  {
    Console.WriteLine("Para");
  }
  // Se pueden cambiar los metodos que heredamos de la clase padre.
  public void Arrancar()
  {
    Console.WriteLine("Arranca Coche");
  }
}