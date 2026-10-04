using _100_001_002_estructura_console_1.Modelos;
using _100_001_002_estructura_console_1.Servicios;

Console.WriteLine("Estructura Consola 1");

var persona = new Persona { Id = 1, Nombre = "Juan", Edad = 30 };
var personaServicio = new PersonaServicio();
personaServicio.MostrarPersona(persona);
