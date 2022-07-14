/* SESION 5 - EJERCICIOS */

/*
EJERCICIO 1 
Escribe un programa que:
 - Pida datos a un cliente: Nombre, email, cupón
 - Determine si un cliente tiene un cupon descuento
 - Muestre un precio rebajado en función del descuento
 - Muestre el precio de un producto sin descuento si no hay cupón
Nota: puedes poner un precio fijo de un producto o uno variable.
*/
float precio = 30.50f;

Console.WriteLine("Introduce tu nombre");
string? nombre = Console.ReadLine();

Console.WriteLine("Introduce tu email");
string? email = Console.ReadLine();

Console.WriteLine("Indica con un 'si' si tienes cupón, si no con un 'no':");
string? cupon = Console.ReadLine();

float descuento = (precio * 10) / 100;

if (cupon == "si")
{
  Console.WriteLine("Tienes un descuento del 10%");
  Console.WriteLine("El precio del producto es de " + (precio - descuento));
}
else
{
  Console.WriteLine($"El precio del producto es de {precio}€");
}

/*
EJERCICIO 2
Haz una lista de lenguajes de programación, por ejemplo C#, Java, C++. Presenta la lista en la lista 
en consola y pide que el usuario seleccione el lenguaje mediante 1,2,3 o a,b,c.
Presenta el resultado en consola. 
Nota: puedes añadir al resultado el "Hola mundo" para el caso de C#.
*/

string[] lenguajes = new string[3];
lenguajes[0] = "Javascript: 1";
lenguajes[1] = "Python: 2";
lenguajes[2] = "C#: 3 ";

foreach (var lenguaje in lenguajes)
{
  Console.Write(lenguaje + " \n");
}
Console.WriteLine("Pulsa el número correspodiente al lenguaje que quieres elegir.");
char numElegido = Convert.ToChar(Console.ReadLine());

switch (numElegido)
{
  case '1':
    Console.WriteLine("Has elegido " + lenguajes[0]);
    break;
  case '2':
    Console.WriteLine("Has elegido " + lenguajes[1]);
    break;
  case '3':
    Console.WriteLine("Has elegido " + lenguajes[2] + "Hola mundo C#.");
    break;
  default:
    Console.WriteLine("No has seleccionado ninguno.");
    break;
}