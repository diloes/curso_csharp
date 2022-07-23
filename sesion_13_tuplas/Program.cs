/* SESION 13 - TUPLAS */

(string, double, int) miTupla = ("Diego", 1.1d, 9);

Console.WriteLine(miTupla);
Console.WriteLine($"Item 1: {miTupla.Item1}, Item 2: {miTupla.Item2}, Item 3: {miTupla.Item3}");

int miSuma = 0;
for (int i = 0; i < 100; i++) { miSuma += i; }
double cociente = 5 / 30d;

(int Suma, double Division) otraTupla = (miSuma, cociente);

Console.WriteLine($"Item 1: {otraTupla.Item1}, Item 2: {otraTupla.Item2}");

var tuplaInt = (1, 2, 3, 4, 5, 6, 7, 8, 9, 10);
Console.WriteLine(tuplaInt.GetType());