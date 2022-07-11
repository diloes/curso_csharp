/* 
EJERCICIO 1 DATOS:
  Escribe un programa que reciba datos de una persona y genera un mensaje, usa una variable para 
  cada dato y otra para el mensaje. Ej: nombre, apellido, edad, sabe programar, etc.
*/

Console.WriteLine("Introduce tu nombre:");
string? nombre = Console.ReadLine();

Console.WriteLine("Introduce tu apellido:");
string? apellido = Console.ReadLine();

Console.WriteLine("Introduce tu edad:");
int? edad = Convert.ToInt32(Console.ReadLine()); 

Console.WriteLine("¿ Sabes programar ?");
string? respuesta = Console.ReadLine();

/*
EJERCICIO 2 TIPOS:
Usando los tipos de variables más adecuados, describe los objetos siguientes:

Coche: puertas, ruedas, marca, ITV vigente

Mesa: peso, largo, material, color

Nota: puedes escribir estos datos por consola si prefieres verlos. 
La idea del ejercicio es almacenar los datos en los tipos más adecuados.
*/

string coche = "Ford Fiesta";
int puertas = 5;
string marca = "Ford";
bool itv = true;

string mesa = "Mesa del Ikea";
float peso = 4.45f;
float largo = 1.40f;
string material = "Pino";
string color = "Marrón";

/*
EJERCICIO 3 OPERADORES: 
Determina los operadores para verificar las siguientes condiciones:

Un número es mayor o igual a 18

Un char es ‘a’

Se cumplen dos conciones a la vez (ambas verdaderas)

Se cumple una de dos condiciones a la vez (una true y otra false)

Nota: puedes escribir estos datos por consola si prefieres verlos. 
La idea del ejercicio es almacenar los datos en los tipos más adecuados.
*/

// Un número es mayor o igual a 18
int num = 20;

if(num >= 18){
  Console.WriteLine("Es mayor o igual");
};

// Un char es 'a' 
char caracter = 'a';

if(caracter == 'a'){
  Console.WriteLine("Es igual que 'a'");
}

//Se cumplen dos conciones a la vez (ambas verdaderas)
int num2 = 20;
int num3 = 30;

if( num2 > 10 && num3 > 20 ){
  Console.WriteLine("Ambas son verdaderas");
}

//Se cumple una de dos condiciones a la vez (una true y otra false)
int num4 = 40;
int num5 = 50;

if( num4 > 30 || num5 < 20 ){
  Console.WriteLine("Una de las dos se cumple");
}