/* SESION 10 - LINQ */
// LINQ -> Language Integrated Query( Lenguaje integrado de consulta )

// 1. Nuestro origen de datos
int[] numbers = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
string[] str = { "Ana", "Maria", "Jose", "Luis", "Diego" };

// 2. Obtener datos con una consulta
var numerosPares =
  from numero in numbers
  where (numero % 2) == 0
  select numero;

var numerosImpares =
  from numero in numbers
  where (numero % 2) != 0
  select numero;

var nums =
  from numero in numbers
  where (numero > 5 && numero <= 8)
  select numero;

var nombres =
  from el in str
  where (el.Length > 3)
  select el;

// 3. Ejecutar consulta
foreach (var num in numerosPares)
{
  Console.Write(num + " ");
}

Console.WriteLine(" ");

foreach (var num in numerosImpares)
{
  Console.Write(num + " ");
}

Console.WriteLine(" ");

foreach (var num in nums)
{
  Console.Write(num + " ");
}

Console.WriteLine(" ");

foreach (string el in nombres)
{
  Console.Write(el + " ");
}

/* Objetos  */
var coche = new { Marca = "Ford", Año = 2021 };
Console.WriteLine($"Tengo un coche de la marca {coche.Marca} del año {coche.Año}");

