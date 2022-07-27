/* SESION 17 - EXCEPCIONES */

Console.WriteLine($"1 entre 2: {DivisionSegura(1, 2)}"); // Comprobamos que funciona

// El try catch sirve para que no se rompa el programa y deje de ejecutarse cuando
// se produce un error en él. Por lo tanto si tenemos alguna parte del código de la
// que no estemos seguro que vaya a funcionar lo pondremos dentro del try{} y capturamos
// el error con el catch{} después el resto del código sigue ejecutándose sin problema.
// finally es una continuación del try catch para hacer alguna cosa referente a él.
// Pero no es necesario poner el resto del código dentro del finally para que se ejecute. 
// Tampoco es obligatorio ponerlo para que funcione el try catch. Es algo opcional.

try
{
  Console.WriteLine($"1 entre 0: {DivisionSegura(1, 0)}");
}
catch (Exception e)
{
  Console.WriteLine($"ERROR. Ha ocurrido esto: {e.Message}");
}
finally
{
  Console.WriteLine("¿Es correcto el valor que aparece?");
}

static double DivisionSegura(double a, double b)
{
  if (b == 0)
  {
    //throw new DivideByZeroException(); // Excepción de C#
    throw new UsuarioNoEncontradoException(); // Probando nuestra excepción
  }
  return a / b;
}

/* 
 * Tipos de exceción:
 * - Exception -> Clase base de las excepciones
 * - IndexOutOfRangeException -> Se intentó pedir un elemento que no existe en un array, etc.
 * - NullReferenceException -> Se pidió un objeto null
    object obhj = null;
    obj.ToString();
 * - ArgumentException -> Clase base para las excepciones relacionadas con argumentos.
 * - ArgumentNullException -> Cuando el argumento es null
    string str = null; // El Substring nos da null porque str es igual a null
    str.Substring(0, 2); // Substring divide el string según los dos argumentos(posiciones) que le indiquemos
 * - ArgumentOutOfRangeException -> Cuando el argumento está fuera del .Length del string, por ejemplo.
    string str = "string;
    str.Substring(0, str.Length + 1); // Error porque le estamos pasando un argumento que no tiene
*/