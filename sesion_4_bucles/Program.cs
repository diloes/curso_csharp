/* SESION 4 - BUCLES */

// WHILE - Se ejecuta mientras se cumpla la condición
int i = 0;
while (i < 10) // En este caso la condición es mientras i sea menor que 10
{
  Console.WriteLine("El valor de i es: " + i);
  i++;
}

// FOR - Igual que el while pero se escribe de otra manera
for (int j = 0; j < 10; j++)
{
  Console.WriteLine("El valor de j es: " + j);
}

// DO WHILE - Lo hace cómo mínimo una vez aunque la condición no coincida
int k = 20;
do
{
  Console.WriteLine("El valor de k es: " + k);
  k++;
} while(k < 10); // Vemos que aunque no se cumple la condición se ejecuta una vez

// FOREACH - Para recorrer arrays y listas. Por cada elemento de la lista hace la acción que le indiquemos
var names = new List<string>{ "Adela", "Rogelio", "Ofelia" };
foreach (var name in names)
{
  Console.WriteLine("Hola " + name);
}

/* EJEMPLOS DE BUCLES */

// Sumar los 100 primeros numeros 
int suma = 0;
for(int l = 0; l <= 100; l++)
{
  suma += l;
}
Console.WriteLine("Suma: " + suma); // 5050


// Expandimos el código para que el usuario indique un número hasta donde vamos a sumar
int m = 0;
int result = 0;
int limit = 0;
Console.WriteLine("Introduce el límite de la suma:");
limit = Convert.ToInt32(Console.ReadLine());
for(m = 0; m <= limit; m++)
{
  result += m;
}
Console.WriteLine($"Resultado: {result}");


// Escribir todos los elementos de un array
int[] arr = new int[3]; // Creamos un array de 3 elementos
arr[0] = 1;
arr[1] = 2;
arr[2] = 3;
foreach (int item in arr) // También se puede hacer con for o while, pero esto es mejor.
{
  Console.WriteLine(item);
}