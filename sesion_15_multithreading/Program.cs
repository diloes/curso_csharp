/* SESION 15 - MULTITHREADING */
// Es la capacidad de tener varios flujos de trabajo. Realizar varias tareas en paralelo.
/* 
* EJEMPLO:
* Main Thread -> Pedimos datos a la BBDD
* Hilo 1 -> Conexion a la BBDD -> LINQ -> Hacer petición
* Hilo 2 -> Consultando la API
* Hilo 3 -> ...
*/
using System;
using System.Diagnostics;
using System.Threading;
// Main Thread o Hilo principal

// Asignar nomber al Main Thread
Thread hiloPrincipal = Thread.CurrentThread;
hiloPrincipal.Name = "Hilo Principal";
Console.WriteLine($"Estamos en el hilo: {hiloPrincipal.Name}");

Stopwatch crono2 = new Stopwatch();
crono2.Start();
ThreadStart refHilo = new ThreadStart(IniciarHilos);
Thread hiloSecundario = new Thread(refHilo);
hiloSecundario.Start();
Thread.Sleep(1000);
crono2.Stop();
Console.WriteLine($"El hilo 2 ha tardado: {crono2.Elapsed}");

static void IniciarHilos()
{
  Console.WriteLine("Iniciando hilo nuevo.");
}