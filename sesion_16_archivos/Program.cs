/* SESION 16 - Crear archivos txt y realizar operaciones */
using System.IO;

// Escribir en miArchivo.txt ( se borrará el contenido anterior que haya en él )
try
{
  StreamWriter sw = new StreamWriter("miArchivo.txt");
  sw.WriteLine("Estoy escribiendo en miArchivo.txt");
  sw.WriteLine("Añadimos otra línea");
  sw.Close();
}
catch (Exception e)
{
  Console.WriteLine("Error: " + e.Message);
}

// Escribir en miArchivo.txt con modo append, es decir, añadir contenido sin eliminar el que ya tiene
try
{
  StreamWriter sw = new StreamWriter("miArchivo.txt", true);
  sw.WriteLine("Añado otra linea");
  sw.WriteLine("Y otra linea más");
  sw.Close();
}
catch (Exception e)
{
  Console.WriteLine("Error: " + e.Message);
}

// Leer un archivo
try
{
  StreamReader sr = new StreamReader("miArchivo.txt");
  var linea = sr.ReadLine();
  while (linea != null)
  {
    Console.WriteLine(linea);
    linea = sr.ReadLine();
  }
  sr.Close(); // Cerramos el stream asociado al archivo
  Console.ReadKey(); // Se queda esperando que pulsemos una tecla
}
catch (Exception ex)
{
  Console.WriteLine("Error: " + ex.Message);
}
finally
{
  Console.WriteLine("Final del try-catch-finally.");
}

/* Operaciones con archivos
 - Crear archivo
 - Leer -> No modifica el contenido // modo lectura
 - Escribir -> Sí modifica y borra lo anterior // modo escritura
 - Append -> Escribe añadiendo contenido al final, no borra lo anterior // modo append
*/