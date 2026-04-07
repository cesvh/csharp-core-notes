using _008_001_mc_herencia;
// using : es una directiva que permite utilizar tipos definidos en otros espacios de nombres sin tener que escribir el nombre completo del espacio de nombres cada vez.

Console.WriteLine("Herencia");
Console.WriteLine("");

Persona persona = new Persona(0, "cesar");

Console.WriteLine($"persona.Nombre: {persona.Nombre}");
Console.WriteLine($"persona.Anio: {persona.Anio}");
Console.WriteLine($"persona.obtenerInformacion(): {persona.obtenerInformacion()}");
Console.WriteLine("");

persona.Nombre = "César";
persona.Anio = 1991;

Console.WriteLine($"persona.Nombre: {persona.Nombre}");
Console.WriteLine($"persona.Anio: {persona.Anio}");
Console.WriteLine($"persona.obtenerInformacion(): {persona.obtenerInformacion()}");
Console.WriteLine("");

// 

Usuario usuario = new Usuario(1900, "cesar", "cvega");
Console.WriteLine($"usuario.obtenerDatos(): {usuario.obtenerDatos()}");
Console.WriteLine("");

//

Administrador administrador = new Administrador(1900, "cesar", "sistemas");
Console.WriteLine($"administrador.obtenerDatos(): {administrador.obtenerDatos()}");
Console.WriteLine("");
