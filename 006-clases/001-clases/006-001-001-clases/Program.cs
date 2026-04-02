
//var personaObj = new Persona("ObjetoPersonaNombre1", "ObjetoPersonaAPellido1", 33);
Persona personaObj = new("ObjetoPersonaNombre1", "ObjetoPersonaAPellido1", 33);
var personaObj2 = new Persona("ObjetoPersonaNombre1", "ObjetoPersonaAPellido1", 33);

Console.WriteLine(personaObj.ObtenerNombreCompleto());

personaObj.nombre = "Yun";
personaObj.apellidos = "Tianming";
personaObj.edad = 1991;
Console.WriteLine(personaObj.ObtenerNombreCompleto());

personaObj2.nombre = "R";
personaObj2.apellidos = "Daneel Olivaw";
personaObj2.edad = 1991;
Console.WriteLine(personaObj2.ObtenerNombreCompleto());

class Persona
{
    // Campos de una clase, estados o atributos de un objeto
    public string nombre = "";
    public string apellidos = "";
    public int edad;

    public Persona(string nombre, string apellidos, int edad)
    {
        this.nombre = nombre;
        this.apellidos = apellidos;
        this.edad = edad;
    }

    // Métodos de una clase, comportamientos o acciones de un objeto
    public string ObtenerNombreCompleto()
    {
        return $"{nombre} {apellidos} {edad}";
    }
}