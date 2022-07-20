/* SESION 11 - Generics */

/* GENERIC */
Generic<string> str = new Generic<string>();
str.Dato = "dato";
Console.WriteLine($"Generic dato: {str.Dato}");
Console.WriteLine($"Tipo de dato: {str.Dato.GetType().FullName}");
Console.WriteLine($"Tipo de clase: {str.GetType()}");

// Esto es una clase generica donde en T le indicaremos el tipo de dato con el que trabajaremos cuando la usemos
public class Generic<T>
{
  public T Dato { get; set; }
}

