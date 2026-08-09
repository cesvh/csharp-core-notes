// Sistem.Text.Json es un espacio de nombres que proporciona clases para trabajar con JSON (JavaScript Object Notation) en C#. Incluye funcionalidades para serializar objetos a JSON y deserializar JSON a objetos, así como para manipular datos JSON de manera eficiente.
using System.Text.Json;

Console.WriteLine("Json");
Console.WriteLine();

Persona objPersona = new Persona() {
    Nombre = "César",
    Edad = 1991
};

// JsonSerializer.Seriealize: es un método que convierte un objeto de C# en una cadena JSON. Toma un objeto como entrada y devuelve su representación en formato JSON.
string jsonPersona = JsonSerializer.Serialize(objPersona);
Console.WriteLine();
Console.WriteLine("string jsonPersona = JsonSerializer.Serialize(objPersona);");
Console.WriteLine(jsonPersona);

// JsonSerializer.Deserialize: es un método que convierte una cadena JSON en un objeto de C#. Toma una cadena JSON como entrada y devuelve un objeto de C#.
// Persona? objPersonaJson: es una variable que almacena el objeto deserializado. El signo de interrogación (?) indica que la variable puede ser nula, lo que significa que si la deserialización falla o el JSON no coincide con la estructura de la clase Persona, objPersonaJson será null.
Persona? objPersonaJson = JsonSerializer.Deserialize<Persona>(jsonPersona);
Console.WriteLine();
Console.WriteLine("Persona? objPersonaJson = JsonSerializer.Deserialize<Persona>(jsonPersona);");
// obPersonaJson?.Nombre: es una forma de acceder a la propiedad Nombre del objeto objPersonaJson de manera segura. El operador ?. (operador de acceso condicional) se utiliza para evitar una excepción si objPersonaJson es null. Si objPersonaJson es null, la expresión completa devolverá null en lugar de lanzar una excepción.
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
Console.WriteLine("string stringArrayObjPersonas = JsonSerializer.Serialize(arrayObjPersona);");
Console.WriteLine(stringArrayObjPersonas);

// JsonSerializer.Deserialize<Persona[]?>: es un método que convierte una cadena JSON que representa un arreglo de objetos en un arreglo de objetos de C#. Toma una cadena JSON como entrada y devuelve un arreglo de objetos de tipo Persona. El signo de interrogación (?) indica que el arreglo puede ser nulo, lo que significa que si la deserialización falla o el JSON no coincide con la estructura del arreglo, jsonArrayObjPersona será null.
Persona[]? jsonArrayObjPersona = JsonSerializer.Deserialize<Persona[]?>(stringArrayObjPersonas);
Console.WriteLine();
Console.WriteLine("Persona[]? jsonArrayObjPersona = JsonSerializer.Deserialize<Persona[]?>(stringArrayObjPersonas);");
Console.WriteLine($"Nombre: {jsonArrayObjPersona?[1].Nombre}, Edad: {jsonArrayObjPersona?[1].Edad}");

class Persona { 
    public string? Nombre { get; set; }
    public int? Edad { get; set; }
}
