using System;
using System.Collections.Generic;
using System.Text;
using _100_001_002_estructura_console_1.Modelos;

namespace _100_001_002_estructura_console_1.Servicios
{
    internal class PersonaServicio
    {
        public void MostrarPersona(Persona persona)
        {
            Console.WriteLine($"ID: {persona.Id}");
            Console.WriteLine($"Nombre: {persona.Nombre}");
            Console.WriteLine($"Edad: {persona.Edad}");
        }
    }
}
