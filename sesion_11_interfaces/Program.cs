/* SESION 11 - INTERFACES */
// Una interfaz es una clase que define atributos, métodos, etc. sin implementarlos.

Vehiculo vehiculo = new Vehiculo();
vehiculo.Marca = "Ford";

interface IVehiculo
{
  string Marca { get; set; }
  void Arrancar();
}

class Vehiculo : IVehiculo
{
  public string Marca { get; set; }
  void IVehiculo.Arrancar()
  {
    Console.WriteLine("Arrancar");
  }
}