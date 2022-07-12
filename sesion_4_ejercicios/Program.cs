/* SESION 4 - EJERCICIOS */

/* 
EJERCICIO 1:
WHILE - Escribe una tabla de multiplicar del 1 al 10 para un número entero que recibe por consola. 
Es decir, un programa que presente para el 1:

1 x 1 = 1
1 x 2 = 2
…
1 x 10 = 10
*/
int a = 0;
Console.WriteLine("Introduce el número del quieres allar la tabla de multiplicar: ");
int b = Convert.ToInt32(Console.ReadLine());
while (a <= 10)
{
  Console.WriteLine($"{b} x {a} = {b * a}");
  a++;
}

/*
EJERCICIO 2: DO WHILE
Escribe un programa que realice estos pasos:

- Reciba al menos un número por consola
- Determine si el número es positivo o negativo
- Presente un contador para cada tipo (positivo y negativo).

Nota: el cero se puede abordar en una clase adicional ya que no es ni positivo ni negativo. 
Tienes completa libertad para elegir el formato de la salida.
*/
Console.WriteLine("Introduce un número:");
string? num = Console.ReadLine();
int k = 0;
int j = 0;
if (num.Contains('-'))
{
  Console.WriteLine("El número " + num + " es negativo.");
  do
  {
    Console.WriteLine($"k = {k}");
    k--;
  } while (k >= Convert.ToInt32(num));

}
else
{
  Console.WriteLine("El número " + num + " es positivo.");
  do
  {
    Console.WriteLine($"j = {j}");
    j++;
  } while (j <= Convert.ToInt32(num));
}

/*
EJERCICIO 3 - FOR : 
Escribe un programa que realice estos pasos:

 - Reciba 3 datos:
    ancho
    alto
    relleno o no

 - Dibuje en consola con un mismo caracter, por ejemplo *, un rectángulo de las dimensiones 
introducidas y use el tercer dato para discernir si el rectángulo está relleno (tiene más * dentro) o no.

En caso de recibir el mismo número n dos veces debe dibujar un cuadrado de lado n.

Reto: Extiende el programa anterior para recibir otro número que sea el número de cuadrados o rectángulos 
que se deben dibujar en la pantalla. Ejemplos:

Input: 2,2,2, relleno = true

Output:

** **

** **

Input: 3, 4, 1, relleno = false

Output:

***

* *

* *

***
*/

Console.WriteLine("Introduce el ancho:");
int ancho = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Introduce el alto:");
int alto = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Pulsa la 's' si quieres que sea relleno, si no, cualquier otra tecla:");
string? relleno = Console.ReadLine();

if (relleno.Contains('s'))
{
  for (int r = 0; r < alto; r++)
  {
    for (int p = 0; p < ancho; p++)
    {
      Console.Write('*');
    }
    Console.WriteLine("");
  }
}
else
{
  for (int r = 0; r < alto; r++)
  {
    if (r == 0 || r == alto - 1)
    {
      for (int s = 0; s < ancho; s++)
      {
        Console.Write('*');
      }
      Console.WriteLine("");
    }

    for (int p = 0; p < ancho; p++)
    {
      if (p == 0 || p == ancho - 1)
      {
        Console.Write('*');
      }
      else
      {
        Console.Write('-');
      }
    }
    Console.WriteLine("");
  }
}