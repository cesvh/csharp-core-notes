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

class Persona
{
    public string Nombre { get; set; }
    public int Edad { get; set; }
    public static int CantidadPersonas { get; private set; }
    public Persona(string nombre, int edad)
    {
        Nombre = nombre;
        Edad = edad;
        CantidadPersonas++;
    }
}