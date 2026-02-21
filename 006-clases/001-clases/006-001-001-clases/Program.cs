
var personaObj = new Persona();
var personaObj2 = new Persona();
//var personaObj0 = new Persona();
// ????? Revisar la diferencia entre usar var y el tipo de dato explícito

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

    // Métodos de una clase, comportamientos o acciones de un objeto
    public string ObtenerNombreCompleto()
    {
        return $"{nombre} {apellidos} {edad}";
    }
}