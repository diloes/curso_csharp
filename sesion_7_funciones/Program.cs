/* SESION 7 - FUNCIONES */

/* MAIN */
int resultadoCuadrado = CalcularCuadrado(2);
Console.WriteLine(resultadoCuadrado);

CalcularAprobado(10);
CalcularAprobado(4);
/* FIN MAIN */


/* DEFINICIONES DE LAS FUNCIONES */

// Función que calcula el cuadrado de un número
int CalcularCuadrado(int n) // de tipo int porque devuelve un int
{
  return n * n;
}

// Función que comprueba si has aprobado
void CalcularAprobado(int a)
{
  if (a < 5)
  {
    Console.WriteLine("Has suspendido.");
  }
  else if (a == 5)
  {
    Console.WriteLine("Aprovado raspado.");
  }
  else
  {
    Console.WriteLine("Has aprobado.");
  }
}

// FUNCIONES ANONIMAS O LAMBDAS -> (params) => expression

int[] numbers = new int[] { 1, 2, 3, 4, 5 };
var squaredNumbers = numbers.Select(n => n * n);
Console.WriteLine(string.Join(" ", squaredNumbers));

// METODOS

// instanciamos un objeto de la clase moto
var moto = new Motos();
// accedemos al método de la clase Motos con nuestro objeto
moto.Arrancar();

// accedemos a este 'static' sin necesidad de instanciar un objeto, directamente desde la clase.
Motos.EncenderLuces();

// EXTENSION
Sesion_7_Funciones.ExtensionMotos.Acelerar();

// RETORNO DE METODOS
int gasolina = moto.CantidadGasolina();
Console.WriteLine($"Nos quedan {gasolina} litros de gasolina.");

// SOBRECARGAS
int nivelDeposito = moto.EcharGasolina(10);
Console.WriteLine($"Ahora tenemos {nivelDeposito} litros de gasolina.");

float nivelDepositoFloat = moto.EcharGasolina(1.23f);
Console.WriteLine($"Ahora tenemos {nivelDepositoFloat} litros de gasolina.");

// Podemos usar la palabra dynamic que nos automatiza el tipo de dato que vamos a utilizar
dynamic nivelDepositoDyn = moto.EcharGasolina(1234.12344d);
Console.WriteLine($"Ahora tenemos {nivelDepositoDyn} litros de gasolina.");

class Motos
{
  public void Arrancar() // esto es un método
  {
    Console.WriteLine("Arranca");
  }

  public static void EncenderLuces() // al añadir static podemos acceder a el sin instanciar un objeto
  {
    Console.WriteLine("Luces Encendidas.");
  }

  public int CantidadGasolina()
  {
    int gasolina = 20;
    return gasolina;
  }

  // Tenemos el mismo método pero uno recibe y devuelve int y el otro float, esto es la SOBRECARGA
  public int EcharGasolina(int litros)
  {
    int nivelDeposito = 20 + litros;
    return nivelDeposito;
  }

  public float EcharGasolina(float litros)
  {
    float nivelDeposito = 20 + litros;
    return nivelDeposito;
  }

  public double EcharGasolina(double litros)
  {
    double nivelDeposito = 20 + litros;
    return nivelDeposito;
  }
}