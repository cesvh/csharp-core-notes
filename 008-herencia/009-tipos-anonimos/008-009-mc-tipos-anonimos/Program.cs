// Los tipos anónimos son una característica de C# que permite crear objetos sin definir explícitamente una clase para ellos. Estos objetos se crean utilizando la palabra clave "var" y se inicializan con una lista de propiedades y sus valores. Los tipos anónimos son útiles cuando se necesita crear un objeto temporal para almacenar datos sin la necesidad de definir una clase completa.
// Los tipos anónimos son inmutables, lo que significa que una vez que se han creado, no se pueden modificar sus propiedades. Además, los tipos anónimos son de solo lectura, lo que significa que no se pueden asignar a variables de tipo diferente o pasar como argumentos a métodos que esperan un tipo específico. Sin embargo, los tipos anónimos son útiles para almacenar datos de forma rápida y sencilla sin la necesidad de definir una clase completa.
// Los tipos anónimos deben tener la misma estructura para ser considerados del mismo tipo. Esto significa que si se crean dos objetos anónimos con las mismas propiedades y tipos de datos, se considerarán del mismo tipo, incluso si se crean en diferentes partes del código. Por ejemplo, si se crean dos objetos anónimos con las propiedades "Name" y "Country" de tipo string, ambos objetos serán del mismo tipo, aunque se hayan creado en diferentes métodos o clases.

Console.WriteLine("Tipos anonimos");
Console.WriteLine("");

var Persona = new { 
    Nombre = "César"
    , Pais = "México"
};

Console.WriteLine($"{Persona.Nombre}, {Persona.Pais}");

var Libros = new[] {
    new { Nombre = "El problema de los 3 cuerpos" },
    new { Nombre = "Neuromante" }
};

foreach (var libro in Libros) {
    Console.WriteLine($"{libro.Nombre}");
};
