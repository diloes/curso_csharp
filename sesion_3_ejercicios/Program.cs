/* 
EJERCICIO 1:
Crea una estructura de datos para un cliente con estos campos:

Nombre completo
Teléfono
Dirección
Email
Si es nuevo cliente

Bonus: escribe un método para presentar estos datos desde la estructura al hacer Console.WriteLine(...)  
*/

public struct Client
{
  public Client(string name, int phone, string address, string email, bool newClient) 
  {
    NAME = name;
    PHONE = phone;
    ADDRESS = address;
    EMAIL = email;
    NEW_CLIENT = newClient; 
  }

  public string NAME { get; set; }
  public int PHONE { get; set; }
  public string ADDRESS { get; set; }
  public string EMAIL { get; set; }
  public bool NEW_CLIENT { get; set; }

  public override string ToString() => $"{NAME}, {PHONE}, {ADDRESS}, {EMAIL} {NEW_CLIENT}";
}