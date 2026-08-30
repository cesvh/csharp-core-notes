// La palabra clave static se utiliza para declarar miembros estáticos en una clase.
// Un miembro estático pertenece a la clase en sí, en lugar de a una instancia específica de la clase.
// Esto significa que puedes acceder a los miembros estáticos sin crear una instancia de la clase.
// Los miembros estáticos se comparten entre todas las instancias de la clase, lo que significa que si cambias el valor de un miembro estático, ese cambio afectará a todas las instancias de la clase.

Console.WriteLine("Estaticos");
Console.WriteLine();

Persona objPersona = new Persona("César", 1991);
Console.WriteLine($"Cantidad de personas: {Persona.CantidadPersonas}");

Persona objPersona2 = new Persona("Cesar", 1991);
Console.WriteLine($"Cantidad de personas: {Persona.CantidadPersonas}");

Persona objPersona3 = new Persona("cesar", 1991);
Console.WriteLine($"Cantidad de personas: {Persona.CantidadPersonas}");

Persona objPersona4 = new Persona("ces", 1991);
Console.WriteLine($"Cantidad de personas: {Persona.CantidadPersonas}");

// Se puede acceder a los miembros estáticos sin crear una instancia de la clase, por lo que no es necesario crear un objeto de la clase Persona para llamar al método ObtenerCantidadPersonas.
Console.WriteLine($"Cantidad de personas final: {Persona.ObtenerCantidadPersonas()}");
class Persona
{
    public string Nombre { get; set; }
    public int Edad { get; set; }

    // CantidadPersonas es un miembro estático que se comparte entre todas las instancias de la clase Persona.
    public static int CantidadPersonas { get; private set; }
    public Persona(string nombre, int edad)
    {
        Nombre = nombre;
        Edad = edad;
        // Cada vez que se crea una nueva instancia de la clase Persona, se incrementa la cantidad de personas en 1.
        CantidadPersonas++;
    }

    // El método ObtenerCantidadPersonas es un método estático que devuelve la cantidad de personas creadas.
    public static int ObtenerCantidadPersonas()
    {
        return CantidadPersonas;
    }
}