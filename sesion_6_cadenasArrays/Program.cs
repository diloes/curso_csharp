/* SESION 6 - CADENAS Y ARRAYS */

// Array de chars
char[] letters = { 'A', 'B', 'C' };
Console.WriteLine(letters[0]);

// Un string al fin y al cabo es un array de chars
string str = "RED";
Console.WriteLine(str[0]);

/* LITERALES */

/* Caracteres escapados:
    - \n -> salto de línea 
    - \u00C6 -> caracter hexadecimal
    - \t -> tabulador
    - \r -> row 
    - \" -> comillas dobles
    - \' -> comillas simples
*/

string multilinea = @"Este texto
es un mensaje 
en varías líneas
gracias a la arroba.";
Console.WriteLine(multilinea);

string comillas = @"Él se autoproclama ""programador"".";
Console.WriteLine(comillas);

/* INTERPOLACION */
var persona = (nombre: "Diego", edad: 32, lenguaje: "C#"); // esto es un objeto
Console.WriteLine($"{persona.nombre} tiene {persona.edad} años y está aprendiendo {persona.lenguaje}.");

/* Subcadenas, substring, replace, trim, indexof */
string miCadena = "Este es mi mensaje.";
string miCadena2 = miCadena.Substring(0, 10); // los 10 primeros caracteres
Console.WriteLine(miCadena2);

string miCadena3 = miCadena.Replace("mensaje", "poscast");
Console.WriteLine(miCadena3);

string miCadena4 = miCadena.Trim(); // qutiar espacios delante y detrás de la cadena

int index = miCadena.IndexOf('m'); // busca el char y nos devuelve su posición

/* STRINGS NULOS Y VACIOS */
string str10 = "hello";
string nullStr = null;
string emptyStr = String.Empty;

string tempStr = str10 + nullStr;
Console.WriteLine(tempStr);

bool b = (emptyStr == nullStr);
Console.WriteLine(b);

string newStr = nullStr + emptyStr;
Console.WriteLine(newStr);

Console.WriteLine(tempStr.Length);
Console.WriteLine(newStr.Length);

// STRING BUILDER
StringBuilder strBuilder = new StringBuilder("Hola mundo.");
Console.WriteLine(strBuilder);
Console.WriteLine(strBuilder[0]);

// TRANSFORMAR UNA CADENA A NUMERO SI ES POSIBLE
int i = 0;
string s = "121212";
bool result = int.TryParse(s, out i); // pasamos a int la variable 's' y lo guardamos en 'i'
// y además almacenamos si ha sido true o false la 'operación'
Console.WriteLine(result + ", i: " + i);

// ARRAYS
int[] arr = new int[2];
string[] names = new string[2]; // indices 0, 1
names[0] = "Rogelio Mercado";
names[1] = "Rigoberta Bandini";

foreach (string elemento in names)
{
  Console.WriteLine(elemento);
}
// también se pueden declarar los valores directamente
int[] numbers = { 4, 3, 2, 1, 0, 8 };
Array.Sort(numbers); // ordenamos numbers
foreach (int number in numbers)
{
  Console.WriteLine(number);
}

// ARRAY DE 2 DIMENSIONES
int[,] array2D = new int[2, 2];

array2D[0, 0] = 1;
array2D[0, 1] = 2;
array2D[1, 0] = 3;
array2D[1, 1] = 4;

for (int j = 0; j < 2; j++)
{
  for (int k = 0; k < 2; k++)
  {
    Console.WriteLine(array2D[j, k]);
  }
}


/*
  NOTAS: 
  - El TryParse no nos dará error nunca, porque lo que hace es intentar pasarlo, si 
  no se puede no hace nada. 
*/