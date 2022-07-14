/* SESION 6 - BUCLES II */

// IF... ELSE
Console.WriteLine("Introduce el día de la semana:");
string? dia = Console.ReadLine();

if (dia == "lunes" || dia == "Lunes")
{
  Console.WriteLine("Feliz Lunes!");
}
else
{
  Console.WriteLine("Hoy no es lunes");
}

// SWITCH
string hoy = "Sábado";
switch (hoy)
{
  case "Lunes":
    Console.WriteLine("Hoy es Lunes");
    break; // break interrumpe la ejecución
  case "Martes":
    Console.WriteLine("Hoy es Martes");
    break;
  case "Miércoles":
    Console.WriteLine("Hoy es Miércoles");
    break;
  default:
    Console.WriteLine("Ese día no lo conozco.");
    break;
}

// BREAK
Console.WriteLine("Antes del IF");
if (hoy == "Sábado")
{
  for (int i = 0; i < 3; i++)
  {
    Console.WriteLine("Lunes");
    break; // break interrumpe la ejecución del for
  }
  Console.WriteLine("Después del for");
}
Console.WriteLine("Después del IF");

// CONTINUE
for (int z = 0; z < 10; z++)
{
  if (z < 5)
  {
    Console.WriteLine("z es mejor que 5");
    continue;
  }
}