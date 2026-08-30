
// Propiedades de acceso: son miembros de una clase que permiten controlar el acceso a los datos de un objeto. Se definen mediante métodos get y set, que permiten leer y escribir valores respectivamente. Las propiedades proporcionan una forma de encapsular los datos y aplicar lógica adicional al acceder a ellos.

Console.WriteLine("Propiedades");

var usuario = new Usuario("cesar", -12000);

Console.WriteLine($"usuario.Nombre: {usuario.Nombre}");
Console.WriteLine($"usuario.AnioNacimiento: {usuario.AnioNacimiento}");

usuario.Nombre = "César";
usuario.AnioNacimiento = 1991;

Console.WriteLine($"usuario.Nombre: {usuario.Nombre}");
Console.WriteLine($"usuario.AnioNacimiento: {usuario.AnioNacimiento}");

class Usuario {

    // Campos privados: son variables que solo pueden ser accedidas desde dentro de la clase. Se utilizan para almacenar datos internos de un objeto y protegerlos de accesos externos no deseados.
    private string _nombre;
    private int _anioNacimiento;

    public Usuario(string nombre, int anioNacimiento)
    {
        _nombre = nombre;
        _anioNacimiento = anioNacimiento;
    }

    // Accesores de propiedades: son métodos especiales que permiten leer (get) y escribir (set) valores de una propiedad. Los accesores proporcionan control sobre cómo se accede a los datos y permiten aplicar validaciones o lógica adicional al establecer o recuperar valores.
    public string Nombre
    {
        // Accesor de lectura (get): permite obtener el valor de la propiedad Nombre.
        get
        {
            return _nombre;
        }
        // Accesor de escritura (set): permite establecer el valor de la propiedad Nombre. Si el valor es nulo o vacío, se asigna "Sin nombre" como valor predeterminado.
        // value: es una palabra clave que representa el valor que se está asignando a la propiedad en el momento de la asignación.
        set
        {
            if (string.IsNullOrEmpty(value)) {
                value = "Sin nombre";
            }
            _nombre = value;
        }
    }

    public int AnioNacimiento
    {
        get
        {
            return _anioNacimiento;
        }
        set
        {
            if (value < 1901)
            {
                value = 1901;
            }
            _anioNacimiento = value;
        }
    }
}
