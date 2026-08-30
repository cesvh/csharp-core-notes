using System;
using System.IO;

string rutaArchivo1 = @"C:\Users\Admin\Documents\x\1.txt";
string rutaArchivo2 = @"C:\Users\Admin\Documents\x\2.txt";

try
{
    Console.WriteLine("--> Iniciando bloque try...");

    string contenido1 = File.ReadAllText(rutaArchivo1);
    Console.WriteLine($"Contenido 1:\n{contenido1}\n");

    string contenido2 = File.ReadAllText(rutaArchivo2);
    Console.WriteLine($"Contenido 2:\n{contenido2}\n");
}
catch (Exception ex)
{
    // Captura general para cualquier otro tipo de error
    Console.WriteLine($"[ERROR GENERAL] Ocurrió una excepción de tipo '{ex.GetType().Name}'.");
    Console.WriteLine($"Mensaje: {ex.Message}");
}
finally
{
    // Se ejecuta SIEMPRE, haya ocurrido una excepción o no
    Console.WriteLine("\n--> Bloque finally: Liberación de recursos o limpieza finalizada.");
}

// El flujo del programa continúa normalmente tras manejar la excepción
Console.WriteLine("--> El programa continúa su ejecución sin colapsar.");