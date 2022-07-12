/* SESION 3 - ESTRUCTURAS */
// Creamos un objeto de la struc Coords
Coords misCoordenadas = new Coords(23.93382, -12.12345);
Console.WriteLine(misCoordenadas.X);
Console.WriteLine(misCoordenadas.Y);

// Creamos un objeto similar al anterior pero cambiando un valor
Coords misCoodernadas2 = misCoordenadas with { X = 06.34562 };

public struct Coords
{
    public Coords(double x, double y)
    {
      X = x;
      Y = y;
    }
    public double X { get; set; }
    public double Y { get; }

    public override string ToString() => $"{X} {Y}";

}