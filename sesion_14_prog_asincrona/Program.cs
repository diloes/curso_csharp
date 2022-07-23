/* SESION 14 - PROG ASINCRONA */
using System.Diagnostics;
using System.Threading;
using System.Threading.Tasks;

Stopwatch sw = Stopwatch.StartNew();

// Task 1 
var task1 = new Task(() =>
{
  Stopwatch crono = new Stopwatch();
  crono.Start();
  Thread.Sleep(1000);
  crono.Stop();
  Console.WriteLine(crono.Elapsed);
});

// Task 2
var task2 = new Task(() =>
{
  Stopwatch crono = new Stopwatch();
  crono.Start();
  Thread.Sleep(1000);
  crono.Stop();
  Console.WriteLine(crono.Elapsed);
});

// Task 2
var task3 = new Task(() =>
{
  Stopwatch crono = new Stopwatch();
  crono.Start();
  Thread.Sleep(1000);
  crono.Stop();
  Console.WriteLine(crono.Elapsed);
});

task1.Start();
task2.Start();
task3.Start();

await task1;
await task2;
await task3;
sw.Stop();
Console.WriteLine($"Todo main: {sw.Elapsed}");
// Estas tres tareas se están realizando en paralelo, por eso tarda 1 seg también el total.

var str = await RandomAsync();
Console.WriteLine(str);

static async Task<string> RandomAsync()
{
  Stopwatch sw = Stopwatch.StartNew();
  var num = new Random().Next(1000);
  sw.Stop();
  var str = $"{num.ToString()} calculado en: {sw.Elapsed}";
  return str;
}