public class UsuarioNoEncontradoException : Exception
{
  public UsuarioNoEncontradoException()
  {
    Console.WriteLine("Usuario No Encontrado");
  }

  public UsuarioNoEncontradoException(string mensaje) : base(mensaje)
  {

  }

  public UsuarioNoEncontradoException(string mensaje, Exception e) : base(mensaje, e)
  {

  }

}