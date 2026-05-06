using System.Text.Json;

Console.WriteLine("Json");
Console.WriteLine();

Persona objPersona = new Persona() {
    Nombre = "César",
    Edad = 1991
};

string jsonPersona = JsonSerializer.Serialize(objPersona);
Console.WriteLine();
Console.WriteLine("string");
Console.WriteLine(jsonPersona);

Persona? objPersonaJson = JsonSerializer.Deserialize<Persona>(jsonPersona);
Console.WriteLine();
Console.WriteLine("Persona");
Console.WriteLine($"Nombre: {objPersonaJson?.Nombre}, Edad: {objPersonaJson?.Edad}");

Persona[] arrayObjPersona = new Persona[] 
{
    new Persona() {
        Nombre = "César",
        Edad = 1991
    },
    new Persona() {
        Nombre = "Cesar",
        Edad = 1992
    }
};

string stringArrayObjPersonas = JsonSerializer.Serialize(arrayObjPersona);
Console.WriteLine();
Console.WriteLine("stringArrayObjPersonas");
Console.WriteLine(stringArrayObjPersonas);

Persona[]? jsonArrayObjPersona = JsonSerializer.Deserialize<Persona[]?>(stringArrayObjPersonas);
Console.WriteLine();
Console.WriteLine("jsonArrayObjPersona");
Console.WriteLine($"Nombre: {jsonArrayObjPersona?[1].Nombre}, Edad: {jsonArrayObjPersona?[1].Edad}");

class Persona { 
    public string? Nombre { get; set; }
    public int? Edad { get; set; }
}
