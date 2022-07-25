/* SESION 16 - 
Conseguir un JSON de un API y usar su contenido */
using System.Net;

// Creamos un request y un response para obtener el JSON
// Request -> Petición al servidor de la API
// Response -> Guardamos los datos que obtenemos de la petición
HttpWebRequest request = (HttpWebRequest)WebRequest.Create(@"https://cat-fact.herokuapp.com/facts");
using HttpWebResponse response = (HttpWebResponse)request.GetResponse();

// Creamos un stream
Stream stream = response.GetResponseStream();
StreamReader reader = new StreamReader(stream);

var json = reader.ReadToEnd();
Console.WriteLine(json);