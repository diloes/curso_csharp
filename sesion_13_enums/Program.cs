/* SESION 13 - ENUMS */
// Se usan cuando son constantes. Ej: Estaciones, días de semana, meses, etc.

Console.WriteLine(Estaciones.Otoño);
Console.WriteLine((int)CodigosError.Conexion);

enum Estaciones
{
  Verano,
  Primavera,
  Otoño,
  Invierno
}

enum CodigosError : ushort
{
  Ninguno = 0,
  Descononido = 1,
  SinConexion = 100,
  Conexion = 200
}