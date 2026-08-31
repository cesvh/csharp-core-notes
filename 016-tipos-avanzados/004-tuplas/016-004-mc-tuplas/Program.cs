// Las tuplas son una estructura de datos que permite almacenar un conjunto de valores relacionados entre sí. Cada valor en la tupla se llama "elemento" y puede ser de cualquier tipo de dato.
// Las tuplas son inmutables, lo que significa que una vez que se han creado, no se pueden modificar sus elementos. Sin embargo, se pueden crear nuevas tuplas a partir de las existentes con diferentes valores. Las tuplas son útiles para agrupar datos relacionados sin la necesidad de crear una clase o estructura personalizada para ello. Por ejemplo, se pueden usar tuplas para representar coordenadas geográficas (latitud y longitud) o para devolver múltiples valores desde un método sin tener que definir una clase específica para ello.
// Las tuplas son editables, lo que significa que se pueden modificar sus elementos después de haber sido creadas. Sin embargo, es importante tener en cuenta que las tuplas son inmutables en cuanto a su estructura, lo que significa que no se pueden agregar o eliminar elementos de una tupla existente. En cambio, se pueden crear nuevas tuplas a partir de las existentes con diferentes valores para los elementos. Por ejemplo, si se tiene una tupla que representa un punto en el espacio con coordenadas (x, y), se puede crear una nueva tupla con diferentes valores para x e y sin modificar la tupla original.

Console.WriteLine("Tuplas");
Console.WriteLine();

// La estructura de una tupla se define utilizando paréntesis y separando los elementos con comas. Cada elemento de la tupla puede tener un nombre opcional, lo que facilita su acceso y mejora la legibilidad del código.
(int id, string name) product = (1, "cerveza victoria");
Console.WriteLine($"{product.id} {product.name}");

product.name = "cerveza corona";
Console.WriteLine($"{product.id} {product.name}");

// Se pueden crear tuplas sin especificar los nombres de los elementos
var person = (1, "César");
Console.WriteLine($"persona {person.Item1} {person.Item2}");

var people = new[]
{
    (1, "Ángel"),
    (2, "César"),
    (3, "Wendy")
};
foreach (var p in people)
{
    Console.WriteLine($"{p.Item1} {p.Item2}");
}

var cityInfo = getLocationCDMX();
Console.WriteLine($"lat: {cityInfo.lat} long: {cityInfo.lng} nombre: {cityInfo.name}");

// Desestructuración de tupla
var (_, lng, _) = getLocationCDMX();
Console.WriteLine(lng);

static (float lat, float lng, string name) getLocationCDMX()
{
    float lat = 19.12121f;
    float lng = -99.19212f;
    string name = "CDMX";
    return (lat, lng, name);
}