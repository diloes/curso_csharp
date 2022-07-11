/* SESION 2 - TIPOS DE DATOS C# */
int enteroSinDecimales4Bytes = 0; // Stores whole numbers from -2,147,483,648 to 2,147,483,647
long enteroSinDecimales8Bytes = 1; // Stores whole numbers from -9,223,372,036,854,775,808 to 9,223,372,036,854,775,807

float decimales4Bytes = 1.55555f; // Stores fractional numbers. Sufficient for storing 6 to 7 decimal digits
double decimales8Bytes = 2.999999999d; // Stores fractional numbers. Sufficient for storing 15 decimal digits

bool verdaderoOFalso = false; // Stores true or false values

char caracter2Bytes = 'c'; // Stores a single character/letter, surrounded by single quotes
string cadenaDeCaracteres = "palabra"; // Stores a sequence of characters, surrounded by double quotes

// Imprimimos en pantalla todos los datos
Console.Write("int: " + enteroSinDecimales4Bytes);
Console.WriteLine(" - long: " + enteroSinDecimales8Bytes);

Console.Write("float: " + decimales4Bytes);
Console.WriteLine(" - double: " + decimales8Bytes);

Console.WriteLine("boolean: " + verdaderoOFalso);

Console.Write("caracter: " + caracter2Bytes);
Console.WriteLine(" - string: " + cadenaDeCaracteres);

/* SEGUIMOS TRABAJANDO CON TIPOS DE DATOS */ 

// Nombre del usuario
Console.WriteLine("Introduce tu nombre: ");
string? nombre = Console.ReadLine(); // la interrogacion es poque puede ser null si el campo se queda vacio

// Edad del usuario
Console.WriteLine("Introduce tu edad: ");
int edad = Convert.ToInt32(Console.ReadLine());

// Ciudad del usuario
Console.WriteLine("Introduce tu ciudad: ");
string? ciudad = Console.ReadLine(); // la interrogacion es poque puede ser null si el campo se queda vacio

// Presentar mensaje "Hola, NOMBRE. Tienes AÑOS. Vives en CIUDAD.
Console.WriteLine("Hola, " + nombre + ". Tienes " + edad + " años. Vives en " + ciudad + ".");

/* CONVERSION DE TIPOS */
/*
* Implicit Casting (automatically) - converting a smaller type to a larger type size
* char -> int -> long -> float -> double 
*/

// Convertimos un int en un float automaticamente porque convertimos de un tipo pequeño a uno más grande
int numeroEntero = 0;
float numeroDecimal = numeroEntero;
Console.WriteLine("numeroEntero = " + numeroEntero);
Console.WriteLine("numeroDecimal = " + numeroDecimal);

/*
* Explicit Casting (manually) - converting a larger type to a smaller size type
* double -> float -> long -> int -> char
*/

// Convertimos un string en un int manualmente porque convertimos de un tipo más grande a uno más pequeño
string str = "32";
int miInt = Convert.ToInt32(str);
Console.WriteLine("str = " + str);
Console.WriteLine("str + 1 = " + str + 1);
Console.WriteLine("miInt = " + miInt);
Console.WriteLine("miInt + 1 = " + (miInt + 1));

/* LA PALABRA RESERVADA const para las constantes */

const int miInt2 = 4; // No podremos nunca reasignarle un valor. 
// miInt2 = 5; esto nos da un error porque estamos reasignando el valor de la constante.

/* TIPO null */

/* Para definir como tipo null le añadimos un signo de interrogacion al tipo de variable */
Console.WriteLine("Introduce tu apellido: ");
string? apellido = Console.ReadLine();
// Si el usuiario no introduce su nombre la variable quedará como null, no será un string, será un null.

