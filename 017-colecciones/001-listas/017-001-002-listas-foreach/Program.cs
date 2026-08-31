Console.WriteLine("Listas - foreach");
Console.WriteLine();

// La palabra reservada var se utiliza para declarar variables locales con un tipo implícito. El compilador infiere el tipo de la variable a partir del valor que se le asigna en el momento de la declaración.
// var solo se usa en el ámbito local dentro de un método, y no se puede usar para declarar variables a nivel de clase o en otros contextos fuera de un método.
var numbers = new List<int>()
            {
                23,3,5,10,22,12
            };

foreach (var number in numbers)
{
    Console.WriteLine(number);
}

// Una lista de objectos de tipo People, cada objeto tiene dos propiedades: Name y Country.
var students = new List<People>()
            {
                new People(){ Name ="Héctor", Country="México"},
                new People(){ Name ="Roberto", Country="Argentina"},
                new People(){ Name ="Ana", Country="Estados Unidos"},
            };

Show(students);
// El método RemoveAt elimina el elemento en la posición especificada de la lista. En este caso, se elimina el primer elemento de la lista (índice 0).
students.RemoveAt(0);

Show(students);
// El método Show recibe una lista de objetos de tipo People y muestra en la consola el nombre y país de cada persona en la lista. Utiliza un bucle foreach para iterar a través de cada objeto People en la lista y acceder a sus propiedades Name y Country para imprimir la información en la consola.

static void Show(List<People> students)
{
    Console.WriteLine("-- Personas --");
    foreach (var people in students)
    {
        Console.WriteLine($"Nombre: {people.Name}, País: {people.Country}");
    }
}

class People
{
    public string? Name { get; set; }
    public string? Country { get; set; }
}