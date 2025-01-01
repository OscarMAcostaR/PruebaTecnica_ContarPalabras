// Prueba Tecnica contar palabras

//inyeccion de librerias o de dependencias para expresiones regulares
using System.Text.RegularExpressions;

Console.WriteLine("Ingrese una cadena");
string cadena = Console.ReadLine();

int contador = 0;

// El metodo Trim() elimina los espacios en blanco al principio y al final de la cadena
// El metodo Split() divide la cadena en palabras separadas por un espacio
// Las expresiones regulares 
// \s indica un espacio 
// Como le indico que quiero que sea 1 o mas espacios \s+
// Nada o algo \s*
// lo siguiente indica que si hay un espacio o mas los conviente todo a un espacio simple @"\s", " "

cadena = Regex.Replace(cadena, @"\s+", " ").Trim();
var palabras = cadena.Split(' ');
contador = palabras.Length;

Console.WriteLine($"La cantidad de palabras es: {contador}");