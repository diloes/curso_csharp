/* SESION 12 - COLLECTIONS */
using System.Collections.Generic;
using System.Collections.Concurrent;
using System.Collections;
/*
// Colección de strings
var coches = new List<string>();
coches.Add("Ford");
coches.Add("Audi");
coches.Add("Maseratti");

// Colección de strings introduciendo valores directamente
var coches2 = new List<string> { "Seat", "Ferrari", "BMW" };

// Recorremos la coleccion
foreach (var el in coches)
{
  Console.WriteLine("Coche: " + el);
}

// Creamos una lista llamada elemento de tipo Elemento con la función CrearLista()
List<Elemento> elemento = CrearLista();

// Creamos una consulta para ver la colección elemento. Esto nos devuelve una lista
var query = from el in elemento where el.NumeroAtomico < 20 select el;
foreach (Elemento el in query)
{
  Console.WriteLine($"Nombre: {el.Nombre}, Símbolo: {el.Simbolo}, Número Atómico: {el.NumeroAtomico}");
}

// Creamos una función que va a crear una lista(no era colección ¿?) de tipo Elemento
static List<Elemento> CrearLista()
{
  return new List<Elemento>
  {
    { new Elemento() {Simbolo = "K", Nombre = "Potasio", NumeroAtomico = 19 } },
    { new Elemento() {Simbolo = "Ca", Nombre = "Calcio", NumeroAtomico = 20 } },
    { new Elemento() {Simbolo = "Ti", Nombre = "Titanio", NumeroAtomico = 22 } }

  };
}

// Creamos la clase Elemento con 3 propiedades
public class Elemento
{
  public string Simbolo { get; set; }
  public string Nombre { get; set; }
  public int NumeroAtomico { get; set; }
}

*/

/* OTRO EJEMPLO 

ListarCoches();

/*
* Esta funcion crea una lista de tipo Car. Para ello cramos la variable cars
* donde instanciamos varios objetos de la clase Car que forman dicha lista. 
*/
/*
static void ListarCoches()
{
  var cars = new List<Car>
  {
    // Eso es una lista de objetos instanciados de la clase Car
    { new Car() { Name = "car4", Color = "blue", Speed = 40} },
    { new Car() { Name = "car5", Color = "blue", Speed = 60} },
    { new Car() { Name = "car1", Color = "blue", Speed = 20} },
    { new Car() { Name = "car2", Color = "red", Speed = 50} },
    { new Car() { Name = "car3", Color = "green", Speed = 10} }
  };

  cars.Sort(); // Esto no funciona porque hay que añadir IComparable a la clase y su método
  foreach (Car coche in cars)
  {
    Console.WriteLine($"{coche.Color}, {coche.Name}, {coche.Speed}");
  }
}

class Car
{
  public string Name { get; set; }
  public string Color { get; set; }
  public int Speed { get; set; }
}
*/

/* Clase de Collection personalidaza */
// Esto está sin terminar porque la clase del curso de OB es un desastre y no se entera ni el profesor
public class MisColores : System.Collections.IEnumerable
{
  public string Nombre { get; set; }
  Colores[] _colores =
    {
      new Colores() { Nombre = "Rojo", CodigoHex = "CB3234" },
      new Colores() { Nombre = "Azul", CodigoHex = "OOOOFF"},
      new Colores() { Nombre = "Verde", CodigoHex = "008F39"}
    };

  public System.Collections.IEnumerator GetEnumerator()
  {
    return new ColoresEnumerator(_colores);
  }

  private class ColoresEnumerator : System.Collections.IEnumerator
  {
    private Color[] _colores;
    private int _position = -1;
  }
}

public class Color
{
  public string Nombre { get; set; }
  public string CodigoHex { get; set; }
}